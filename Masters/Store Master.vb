Imports System.IO
Public Class Store_Master
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_StoreDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_StoreCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_StoreDescription As System.Windows.Forms.Label
    Friend WithEvents lbl_StoreCode As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents cmdStoreCode As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Opt_Mainstore As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Substore As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Store_Master))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.txt_StoreDesc = New System.Windows.Forms.TextBox
        Me.txt_StoreCode = New System.Windows.Forms.TextBox
        Me.lbl_StoreDescription = New System.Windows.Forms.Label
        Me.lbl_StoreCode = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.cmdStoreCode = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Opt_Mainstore = New System.Windows.Forms.RadioButton
        Me.Opt_Substore = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(264, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(210, 31)
        Me.lbl_Heading.TabIndex = 9
        Me.lbl_Heading.Text = "STORE  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_StoreDesc
        '
        Me.txt_StoreDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_StoreDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_StoreDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StoreDesc.Location = New System.Drawing.Point(320, 136)
        Me.txt_StoreDesc.MaxLength = 50
        Me.txt_StoreDesc.Name = "txt_StoreDesc"
        Me.txt_StoreDesc.Size = New System.Drawing.Size(236, 26)
        Me.txt_StoreDesc.TabIndex = 1
        Me.txt_StoreDesc.Text = ""
        '
        'txt_StoreCode
        '
        Me.txt_StoreCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_StoreCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_StoreCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StoreCode.Location = New System.Drawing.Point(320, 96)
        Me.txt_StoreCode.MaxLength = 10
        Me.txt_StoreCode.Name = "txt_StoreCode"
        Me.txt_StoreCode.Size = New System.Drawing.Size(212, 26)
        Me.txt_StoreCode.TabIndex = 0
        Me.txt_StoreCode.Text = ""
        '
        'lbl_StoreDescription
        '
        Me.lbl_StoreDescription.AutoSize = True
        Me.lbl_StoreDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StoreDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StoreDescription.Location = New System.Drawing.Point(120, 136)
        Me.lbl_StoreDescription.Name = "lbl_StoreDescription"
        Me.lbl_StoreDescription.Size = New System.Drawing.Size(158, 18)
        Me.lbl_StoreDescription.TabIndex = 13
        Me.lbl_StoreDescription.Text = "STORE DESCRIPTION :"
        '
        'lbl_StoreCode
        '
        Me.lbl_StoreCode.AutoSize = True
        Me.lbl_StoreCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StoreCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StoreCode.Location = New System.Drawing.Point(184, 96)
        Me.lbl_StoreCode.Name = "lbl_StoreCode"
        Me.lbl_StoreCode.Size = New System.Drawing.Size(104, 18)
        Me.lbl_StoreCode.TabIndex = 11
        Me.lbl_StoreCode.Text = "STORE CODE :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Location = New System.Drawing.Point(24, 248)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(688, 56)
        Me.frmbut.TabIndex = 15
        Me.frmbut.TabStop = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(464, 16)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 8
        Me.cmd_Print.Text = " Print[F10]"
        '
        'cmdStoreCode
        '
        Me.cmdStoreCode.Image = CType(resources.GetObject("cmdStoreCode.Image"), System.Drawing.Image)
        Me.cmdStoreCode.Location = New System.Drawing.Point(536, 96)
        Me.cmdStoreCode.Name = "cmdStoreCode"
        Me.cmdStoreCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdStoreCode.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(88, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 160)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(145, 224)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(311, 25)
        Me.lbl_Freeze.TabIndex = 14
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(32, 264)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 5
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(376, 264)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 7
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(264, 264)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 6
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(144, 264)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 4
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(600, 264)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 8
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Opt_Mainstore
        '
        Me.Opt_Mainstore.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Mainstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Mainstore.Location = New System.Drawing.Point(320, 172)
        Me.Opt_Mainstore.Name = "Opt_Mainstore"
        Me.Opt_Mainstore.Size = New System.Drawing.Size(128, 32)
        Me.Opt_Mainstore.TabIndex = 2
        Me.Opt_Mainstore.Text = "MAIN STORE"
        '
        'Opt_Substore
        '
        Me.Opt_Substore.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Substore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Substore.Location = New System.Drawing.Point(456, 172)
        Me.Opt_Substore.Name = "Opt_Substore"
        Me.Opt_Substore.Size = New System.Drawing.Size(120, 32)
        Me.Opt_Substore.TabIndex = 3
        Me.Opt_Substore.Text = "SUB STORE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(176, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 21)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'Store_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(726, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Opt_Substore)
        Me.Controls.Add(Me.Opt_Mainstore)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txt_StoreDesc)
        Me.Controls.Add(Me.txt_StoreCode)
        Me.Controls.Add(Me.lbl_StoreDescription)
        Me.Controls.Add(Me.lbl_StoreCode)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.cmdStoreCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Store_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STORE MASTER"
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    'FINAL
    Dim dr As DataRow
    Dim dc As DataColumn
    Dim pageno As Integer
    Dim pagesize As Integer

    Private Sub Store_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_StoreCode.Enabled = True
        txt_StoreCode.ReadOnly = False
        txt_StoreDesc.ReadOnly = False
        Opt_Substore.Checked = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        StoreMasterbool = True
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            strSQL = " INSERT INTO StoreMaster (Storecode,Storedesc,StoreStatus,Freeze,Adduser,Adddate)"
            strSQL = strSQL & " VALUES ( '" & Trim(txt_StoreCode.Text) & "','" & Replace(Trim(txt_StoreDesc.Text), "'", "") & "',"
            strSQL = strSQL & " '" & IIf(Opt_Mainstore.Checked = True, "M", "S") & "',"
            strSQL = strSQL & " 'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, strSQL, "StoreMaster")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            strSQL = "UPDATE  StoreMaster "
            strSQL = strSQL & " SET Storedesc='" & Replace(Trim(txt_StoreDesc.Text), "'", "") & "',StoreStatus = '" & IIf(Opt_Mainstore.Checked = True, "M", "S") & "',"
            strSQL = strSQL & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Freeze='N'"
            strSQL = strSQL & " WHERE Storecode = '" & Trim(txt_StoreCode.Text) & "'"
            gconnection.dataOperation(2, strSQL, "StoreMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  StoreMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Storecode = '" & Trim(txt_StoreCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "StoreMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  StoreMaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Storecode = '" & Trim(txt_StoreCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "StoreMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_StoreCode.Enabled = True
        txt_StoreCode.ReadOnly = False
        txt_StoreDesc.ReadOnly = False
        Opt_Substore.Checked = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_StoreCode.Focus()
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INVENTORY' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        'Dim FrReport As New ReportDesigner
        'tables = " FROM STOREMASTER"
        'Gheader = "STORE MASTER"
        'FrReport.SsGridReport.SetText(2, 1, "STORECODE")
        'FrReport.SsGridReport.SetText(3, 1, 15)
        'FrReport.SsGridReport.SetText(2, 2, "STOREDESC")
        'FrReport.SsGridReport.SetText(3, 2, 35)
        'FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        'FrReport.SsGridReport.SetText(3, 3, 5)
        'FrReport.Show()
        gPrint = False
        PRINTOPERATION()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Store_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 Then
            Call Cmd_Freeze_Click(Cmd_Freeze, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F7 Then
            Call Cmd_Add_Click(Cmd_Add, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F10 Then
            Call cmd_Print_Click(cmd_Print, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub

    Private Sub cmdStoreCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStoreCode.Click
        gSQLString = "SELECT ISNULL(STORECODE,'') AS STORECODE,ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER"
        M_WhereCondition = "  "
        Dim vform As New List_Operation
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "       STORE CODE       |       STORE DESCRIPTION                             "
        vform.vCaption = "STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_StoreCode.Text = Trim(vform.keyfield & "")
            Call txt_StoreCode_Validated(txt_StoreCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_StoreCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_StoreCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdStoreCode.Enabled = True Then
                search = Trim(txt_StoreCode.Text)
                Call cmdStoreCode_Click(cmdStoreCode, e)
            End If
        End If
    End Sub

    Private Sub txt_StoreDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_StoreDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Opt_Mainstore.Focus()
        End If
    End Sub

    Private Sub txt_StoreCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_StoreCode.Validated
        If Trim(txt_StoreCode.Text) <> "" Then
            sqlstring = "SELECT ISNULL(STORECODE,'') AS STORECODE,ISNULL(STOREDESC,'') AS STOREDESC,ISNULL(STORESTATUS,'') AS STORESTATUS,ISNULL(FREEZE,'') AS FREEZE,ADDDATE FROM StoreMaster WHERE storecode='" & Trim(txt_StoreCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "StoreMaster")
            If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                txt_StoreCode.Text = Trim(gdataset.Tables("StoreMaster").Rows(0).Item("STORECODE"))
                txt_StoreDesc.Text = Trim(gdataset.Tables("StoreMaster").Rows(0).Item("STOREDESC"))
                If gdataset.Tables("StoreMaster").Rows(0).Item("FREEZE") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("StoreMaster").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                If Trim(gdataset.Tables("StoreMaster").Rows(0).Item("STORESTATUS")) = "M" Then
                    Opt_Mainstore.Checked = True
                Else
                    Opt_Substore.Checked = True
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                txt_StoreCode.ReadOnly = True
                txt_StoreDesc.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txt_StoreCode.ReadOnly = False
                txt_StoreDesc.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            txt_StoreCode.Text = ""
            txt_StoreDesc.Focus()
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Store Code Can't be blank *********************'''
        If Trim(txt_StoreCode.Text) = "" Then
            MessageBox.Show(" Store Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_StoreCode.Focus()
            Exit Sub
        End If
        '''********** Check  Store desc Can't be blank *********************'''
        If Trim(txt_StoreDesc.Text) = "" Then
            MessageBox.Show(" Store Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_StoreDesc.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub


    Private Sub Store_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        StoreMasterbool = False
    End Sub

    Private Sub Opt_Mainstore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Opt_Mainstore.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub txt_StoreCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_StoreCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_StoreCode.Text) = "" Then
                Call cmdStoreCode_Click(cmdStoreCode, e)
            Else
                txt_StoreCode_Validated(txt_StoreCode, e)
            End If
        End If
    End Sub

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        gPrint = True
        PRINTOPERATION()
    End Sub

    Private Sub PRINTOPERATION()
        Dim x, docno, printline As String
        Dim I As Integer
        Dim booldocno As Boolean
        Dim total(10) As Double
        Dim vsubheader() As String = {"DOC NO. : ", "DOC DATE : ", "MAIN STORE CODE : ", "MAIN STORE NAME : ", "TO STORE CODE  : ", "TO STORE NAME :"}
        Dim PAGEHEADING() As String = {"STORE MASTER"}
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            sqlstring = "SELECT STORECODE,STOREDESC,STORESTATUS,FREEZE FROM STOREMASTER ORDER BY STORECODE"
            gconnection.getDataSet(sqlstring, "INVENTORYSTOREMASTER")
            Call Print_Headers(PAGEHEADING)
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For Each dr In gdataset.Tables("INVENTORYSTOREMASTER").Rows
                Filewrite.WriteLine("|{0,-15}|{1,-40}|{2,10}|{3,10}|", Mid(dr.Item("STORECODE"), 1, 15), Mid(dr.Item("STOREDESC"), 1, 40), Mid(dr.Item("STORESTATUS"), 1, 10), Mid(dr.Item("FREEZE"), 1, 10))
                pagesize = pagesize + 1
                If pagesize > 58 Then
                    Filewrite.Write(StrDup(80, "-"))
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call Print_Headers(PAGEHEADING)
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                End If
            Next dr
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Function Print_Headers(ByVal pageheading() As String)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine(Chr(18))
            Filewrite.WriteLine("{0,40}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,1}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(pageheading(0)), 1, 30), " ", " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-1}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(pageheading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,70}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(80, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("|{0,-15}|{1,-40}|{2,10}|{3,10}|", "STORECODE", "STORE DESCRIPTION", "STATUS", "FREEZE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(80, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
