<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Port = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Server = New System.Windows.Forms.TextBox()
        Me.btn_exec = New System.Windows.Forms.Button()
        Me.lst_Pools = New System.Windows.Forms.ListBox()
        Me.lst_escal = New System.Windows.Forms.ListView()
        Me.col_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Interval = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_countAll = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_countMatch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chk_showdisabled = New System.Windows.Forms.CheckBox()
        Me.chk_testQualification = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chk_time = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Enabled = False
        Me.btn_disconnect.Location = New System.Drawing.Point(774, 21)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(75, 20)
        Me.btn_disconnect.TabIndex = 73
        Me.btn_disconnect.Text = "Logout"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.Location = New System.Drawing.Point(693, 21)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(75, 20)
        Me.btn_Connect.TabIndex = 72
        Me.btn_Connect.Text = "Login"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(489, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Password"
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(487, 21)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(200, 20)
        Me.txt_Password.TabIndex = 70
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(283, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Username"
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(281, 21)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(200, 20)
        Me.txt_Username.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(217, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Port"
        '
        'txt_Port
        '
        Me.txt_Port.Location = New System.Drawing.Point(215, 21)
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(60, 20)
        Me.txt_Port.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Server"
        '
        'txt_Server
        '
        Me.txt_Server.Location = New System.Drawing.Point(9, 21)
        Me.txt_Server.Name = "txt_Server"
        Me.txt_Server.Size = New System.Drawing.Size(200, 20)
        Me.txt_Server.TabIndex = 64
        '
        'btn_exec
        '
        Me.btn_exec.Enabled = False
        Me.btn_exec.Location = New System.Drawing.Point(8, 6)
        Me.btn_exec.Name = "btn_exec"
        Me.btn_exec.Size = New System.Drawing.Size(95, 20)
        Me.btn_exec.TabIndex = 75
        Me.btn_exec.Text = "Run"
        Me.btn_exec.UseVisualStyleBackColor = True
        '
        'lst_Pools
        '
        Me.lst_Pools.FormattingEnabled = True
        Me.lst_Pools.Location = New System.Drawing.Point(8, 55)
        Me.lst_Pools.Name = "lst_Pools"
        Me.lst_Pools.Size = New System.Drawing.Size(95, 199)
        Me.lst_Pools.TabIndex = 76
        '
        'lst_escal
        '
        Me.lst_escal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Name, Me.col_Interval, Me.col_countAll, Me.col_countMatch})
        Me.lst_escal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_escal.Location = New System.Drawing.Point(0, 0)
        Me.lst_escal.Name = "lst_escal"
        Me.lst_escal.Size = New System.Drawing.Size(749, 335)
        Me.lst_escal.TabIndex = 77
        Me.lst_escal.UseCompatibleStateImageBehavior = False
        Me.lst_escal.View = System.Windows.Forms.View.Details
        '
        'col_Name
        '
        Me.col_Name.Text = "Name"
        Me.col_Name.Width = 200
        '
        'col_Interval
        '
        Me.col_Interval.Text = "Interval"
        Me.col_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'col_countAll
        '
        Me.col_countAll.Text = "Count All"
        Me.col_countAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'col_countMatch
        '
        Me.col_countMatch.Text = "Count Match"
        Me.col_countMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_countMatch.Width = 80
        '
        'chk_showdisabled
        '
        Me.chk_showdisabled.AutoSize = True
        Me.chk_showdisabled.Location = New System.Drawing.Point(8, 282)
        Me.chk_showdisabled.Name = "chk_showdisabled"
        Me.chk_showdisabled.Size = New System.Drawing.Size(97, 17)
        Me.chk_showdisabled.TabIndex = 78
        Me.chk_showdisabled.Text = "Show Disabled"
        Me.chk_showdisabled.UseVisualStyleBackColor = True
        '
        'chk_testQualification
        '
        Me.chk_testQualification.AutoSize = True
        Me.chk_testQualification.Location = New System.Drawing.Point(8, 32)
        Me.chk_testQualification.Name = "chk_testQualification"
        Me.chk_testQualification.Size = New System.Drawing.Size(72, 17)
        Me.chk_testQualification.TabIndex = 79
        Me.chk_testQualification.Text = "Test Qual"
        Me.chk_testQualification.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 258)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(95, 18)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 80
        Me.ProgressBar1.Value = 50
        Me.ProgressBar1.Visible = False
        '
        'chk_time
        '
        Me.chk_time.AutoSize = True
        Me.chk_time.Location = New System.Drawing.Point(8, 305)
        Me.chk_time.Name = "chk_time"
        Me.chk_time.Size = New System.Drawing.Size(95, 17)
        Me.chk_time.TabIndex = 81
        Me.chk_time.Text = "Interval/Timed"
        Me.chk_time.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Server)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Port)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Username)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Password)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_disconnect)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Connect)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(859, 386)
        Me.SplitContainer1.SplitterDistance = 47
        Me.SplitContainer1.TabIndex = 82
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lst_Pools)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chk_time)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chk_testQualification)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_exec)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chk_showdisabled)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lst_escal)
        Me.SplitContainer2.Size = New System.Drawing.Size(859, 335)
        Me.SplitContainer2.SplitterDistance = 106
        Me.SplitContainer2.TabIndex = 83
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 386)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(875, 425)
        Me.Name = "Form1"
        Me.Text = "ARS-EscalationOverview © Andreas Kreisl"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents btn_Connect As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_Port As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_Server As TextBox
    Friend WithEvents btn_exec As Button
    Friend WithEvents lst_Pools As ListBox
    Friend WithEvents lst_escal As ListView
    Friend WithEvents col_Name As ColumnHeader
    Friend WithEvents col_Interval As ColumnHeader
    Friend WithEvents col_countAll As ColumnHeader
    Friend WithEvents col_countMatch As ColumnHeader
    Friend WithEvents chk_showdisabled As CheckBox
    Friend WithEvents chk_testQualification As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents chk_time As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
End Class
