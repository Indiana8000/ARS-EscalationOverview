Imports System.Collections.Specialized

Public Class Form1
    Dim oServer As BMC.ARSystem.Server
    Dim tEscalations As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Date.Now.Year > 2020 Or Date.Now.Month > 12 Then
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
        tEscalations.Columns.Add("Type", GetType(Integer))
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
            btn_exec.Select()
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
        Dim testQuery As ArrayList
        Dim de As DictionaryEntry

        Dim pool As Integer
        Dim interval As Integer
        Dim count As Integer = 0
        Dim countTotal, countMatch As Integer

        btn_exec.Enabled = False
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        tEscalations.Rows.Clear()
        es = oServer.GetListEscalation()
        For Each s As String In es
            count = count + 1
            btn_exec.Text = "Run " & count & "/" & es.Count
            ProgressBar1.Value = (count * 100) / es.Count
            Application.DoEvents()
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
            End While

            If ecl.TimeCriteria.GetType Is GetType(BMC.ARSystem.EscalationInterval) Then
                ti = ecl.TimeCriteria
                interval = ti.Minutes
                If chk_testQualification.Checked And ecl.Enabled Then
                    Try
                        testQuery = oServer.GetListEntry(ecl.PrimaryForm, ecl.RunIfQualification)
                    Catch ex As Exception
                        testQuery = New ArrayList
                    End Try
                    tEscalations.Rows.Add(s, 0, ecl.Enabled, pool, interval, getEntryCountOfForm(ecl.PrimaryForm), testQuery.Count)
                Else
                    tEscalations.Rows.Add(s, 0, ecl.Enabled, pool, interval, -1, -1)
                End If
            Else
                If chk_testQualification.Checked And ecl.Enabled Then
                    Try
                        testQuery = oServer.GetListEntry(ecl.PrimaryForm, ecl.RunIfQualification)
                    Catch ex As Exception
                        testQuery = New ArrayList
                    End Try
                    countTotal = getEntryCountOfForm(ecl.PrimaryForm)
                    countMatch = testQuery.Count
                Else
                    countTotal = -1
                    countMatch = -1
                End If

                tt = ecl.TimeCriteria
                For i = 0 To 31
                    If tt.Hours(1 << i) Then
                        tEscalations.Rows.Add(i.ToString("00") & ":" & tt.Minute.ToString("00") & " - " & s, 1, ecl.Enabled, pool, 0, countTotal, countMatch)
                    End If
                Next
            End If
        Next
        btn_exec.Enabled = True
        btn_exec.Text = "Run"
        ProgressBar1.Visible = False
    End Sub

    Private Sub lst_Pools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Pools.SelectedIndexChanged
        updateTable(lst_Pools.SelectedIndex + 1, chk_showdisabled.Checked, chk_time.Checked)
    End Sub

    Private Sub chk_showdisabled_CheckedChanged(sender As Object, e As EventArgs) Handles chk_showdisabled.CheckedChanged
        updateTable(lst_Pools.SelectedIndex + 1, chk_showdisabled.Checked, chk_time.Checked)
    End Sub
    Private Sub chk_time_CheckedChanged(sender As Object, e As EventArgs) Handles chk_time.CheckedChanged
        updateTable(lst_Pools.SelectedIndex + 1, chk_showdisabled.Checked, chk_time.Checked)
    End Sub

    Private Sub updateTable(pool As Integer, all As Boolean, timed As Boolean)
        Dim rows As DataRow()
        Dim EscalItem As ListViewItem
        Dim sql As String

        sql = "Pool = " & pool
        If Not all Then
            sql &= " And Enabled = True"
        End If
        If timed Then
            sql &= " And Type = 1"
        Else
            sql &= " And Type = 0"
        End If

        lst_escal.Items.Clear()
        rows = tEscalations.Select(sql, "Interval ASC, Name ASC")
        For Each row As DataRow In rows
            EscalItem = New ListViewItem
            EscalItem.Text = row("Name")
            EscalItem.SubItems.Add(row("Interval"))
            EscalItem.SubItems.Add(row("countAll"))
            EscalItem.SubItems.Add(row("countMatched"))
            If row("Enabled") = False Then
                EscalItem.ForeColor = Color.Gray
            End If
            lst_escal.Items.Add(EscalItem)
        Next
        col_Name.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        'col_Interval.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        'col_countAll.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        'col_countMatch.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Function getEntryCountOfForm(sFormName As String) As Integer
        Dim tmpTable As DataTable
        Try
            tmpTable = oServer.GetListSQL("Select schemaid, schematype FROM arschema WHERE name = '" & sFormName & "'", 1)
            tmpTable = oServer.GetListSQL("SELECT count(*) FROM T" & tmpTable.Rows(0).Item(0), 1)
            getEntryCountOfForm = tmpTable.Rows(0).Item(0).ToString
        Catch ex As Exception
            getEntryCountOfForm = -1
        End Try
    End Function

End Class
