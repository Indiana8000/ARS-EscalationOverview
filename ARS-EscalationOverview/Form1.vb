Public Class Form1
    Dim oServer As BMC.ARSystem.Server
    Dim tEscalations As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Date.Now.Year > 2020 Or Date.Now.Month > 9 Then
            MsgBox("Trial Period Expired! Please contact the Developer.", vbExclamation, "Unregistered Version")
            Application.Exit()
        End If

        oServer = New BMC.ARSystem.Server

        txt_Server.Text = My.Settings.Server
        txt_Port.Text = My.Settings.Port
        txt_Username.Text = My.Settings.Username
        If txt_Server.Text.Length > 0 Then
            txt_Password.Select()
        End If

        tEscalations = New DataTable
        tEscalations.Columns.Add("Name", GetType(String))
        tEscalations.Columns.Add("Enabled", GetType(Boolean))
        tEscalations.Columns.Add("Pool", GetType(Integer))
        tEscalations.Columns.Add("Interval", GetType(Integer))
        tEscalations.Columns.Add("countAll", GetType(Integer))
        tEscalations.Columns.Add("countMatched", GetType(Integer))
    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        Dim alForms As ArrayList

        My.Settings.Server = txt_Server.Text
        My.Settings.Port = txt_Port.Text
        My.Settings.Username = txt_Username.Text
        My.Settings.Save()

        Try
            oServer.Login(txt_Server.Text, txt_Username.Text, txt_Password.Text, "", "de_DE", "UTF-8", txt_Port.Text)
            alForms = oServer.GetListForm()
            btn_Connect.Enabled = False
            btn_disconnect.Enabled = True
            btn_exec.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        oServer.Logout()
        btn_Connect.Enabled = True
        btn_disconnect.Enabled = False
        btn_exec.Enabled = False
    End Sub

    Private Sub txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Password.KeyPress
        If txt_Password.Text.Length > 0 And Asc(e.KeyChar) = 13 Then
            btn_Connect.Select()
            Application.DoEvents()
            btn_Connect_Click(sender, New EventArgs())
        End If
    End Sub

    Private Sub btn_exec_Click(sender As Object, e As EventArgs) Handles btn_exec.Click
        Dim es As ArrayList
        Dim ecl As BMC.ARSystem.Escalation
        Dim ti As BMC.ARSystem.EscalationInterval
        Dim tt As BMC.ARSystem.EscalationTime
        Dim de As DictionaryEntry

        Dim pool As Integer
        Dim interval As Integer

        btn_exec.Enabled = False
        es = oServer.GetListEscalation()
        For Each s As String In es
            ecl = oServer.GetEscalation(s)

            pool = 1
            If ecl.Properties.Contains(60024) Then
                Try
                    pool = ecl.Properties(60024)
                Catch ex As Exception
                    'TBD
                End Try
            End If

            While lst_Pools.Items.Count < pool
                lst_Pools.Items.Add("Pool " & (lst_Pools.Items.Count + 1))
                Application.DoEvents()
            End While

            If ecl.TimeCriteria.GetType Is GetType(BMC.ARSystem.EscalationInterval) Then
                ti = ecl.TimeCriteria
                interval = ti.Minutes
                tEscalations.Rows.Add(s, ecl.Enabled, pool, interval, 0, 0)
            Else
                tt = ecl.TimeCriteria
                'TBD
            End If
        Next
        btn_exec.Enabled = True
    End Sub

    Private Sub lst_Pools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Pools.SelectedIndexChanged
        Dim rows As DataRow()
        Dim EscalItem As ListViewItem

        lst_escal.Items.Clear()
        rows = tEscalations.Select("Pool = " & lst_Pools.SelectedIndex, "Interval ASC, Name ASC")
        For Each row As DataRow In rows
            Console.WriteLine("DEBUG: " & row("Name"))
            EscalItem = New ListViewItem

            EscalItem.Text = row("Name")
            EscalItem.SubItems.Add(row("Interval"))
            EscalItem.SubItems.Add(row("countAll"))
            EscalItem.SubItems.Add(row("countMatched"))

            If row("Enabled") = False Then
                EscalItem.ForeColor = Color.Silver
            End If

            lst_escal.Items.Add(EscalItem)
        Next

        col_Name.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        col_Interval.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        col_countAll.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        col_countMatch.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
End Class
