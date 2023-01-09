Imports System.IO
Public Class Sub_Group_Master
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
    Friend WithEvents txt_GroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_GroupCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GroupDescription As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGroupCode As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Sub_Group_Master))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.txt_GroupDesc = New System.Windows.Forms.TextBox
        Me.txt_GroupCode = New System.Windows.Forms.TextBox
        Me.lbl_GroupDescription = New System.Windows.Forms.Label
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.cmdGroupCode = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.frmbut.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(248, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(270, 31)
        Me.lbl_Heading.TabIndex = 8
        Me.lbl_Heading.Text = "SUB GROUP  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_GroupDesc
        '
        Me.txt_GroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupDesc.Location = New System.Drawing.Point(368, 96)
        Me.txt_GroupDesc.MaxLength = 50
        Me.txt_GroupDesc.Name = "txt_GroupDesc"
        Me.txt_GroupDesc.Size = New System.Drawing.Size(213, 26)
        Me.txt_GroupDesc.TabIndex = 1
        Me.txt_GroupDesc.Text = ""
        '
        'txt_GroupCode
        '
        Me.txt_GroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupCode.Location = New System.Drawing.Point(368, 64)
        Me.txt_GroupCode.MaxLength = 10
        Me.txt_GroupCode.Name = "txt_GroupCode"
        Me.txt_GroupCode.Size = New System.Drawing.Size(192, 26)
        Me.txt_GroupCode.TabIndex = 0
        Me.txt_GroupCode.Text = ""
        '
        'lbl_GroupDescription
        '
        Me.lbl_GroupDescription.AutoSize = True
        Me.lbl_GroupDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupDescription.Location = New System.Drawing.Point(160, 96)
        Me.lbl_GroupDescription.Name = "lbl_GroupDescription"
        Me.lbl_GroupDescription.Size = New System.Drawing.Size(161, 18)
        Me.lbl_GroupDescription.TabIndex = 12
        Me.lbl_GroupDescription.Text = "GROUP DESCRIPTION :"
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(224, 64)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(107, 18)
        Me.lbl_GroupCode.TabIndex = 13
        Me.lbl_GroupCode.Text = "GROUP CODE :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Location = New System.Drawing.Point(16, 328)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(680, 56)
        Me.frmbut.TabIndex = 14
        Me.frmbut.TabStop = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(456, 16)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 7
        Me.cmd_Print.Text = "Print[F10]"
        '
        'cmdGroupCode
        '
        Me.cmdGroupCode.Image = CType(resources.GetObject("cmdGroupCode.Image"), System.Drawing.Image)
        Me.cmdGroupCode.Location = New System.Drawing.Point(560, 64)
        Me.cmdGroupCode.Name = "cmdGroupCode"
        Me.cmdGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdGroupCode.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(48, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 80)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(136, 303)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 15
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(48, 136)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(616, 160)
        Me.ssgrid.TabIndex = 2
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(584, 344)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(24, 344)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(360, 344)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 6
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(248, 344)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 5
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(136, 344)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 3
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(514, 21)
        Me.Label6.TabIndex = 418
        Me.Label6.Text = "Press F4 for HELP / Press F3 for DELETE record /Press ENTER to navigate"
        '
        'Sub_Group_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(726, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txt_GroupDesc)
        Me.Controls.Add(Me.txt_GroupCode)
        Me.Controls.Add(Me.lbl_GroupDescription)
        Me.Controls.Add(Me.lbl_GroupCode)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.cmdGroupCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Sub_Group_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUB GROUP MASTER "
        Me.frmbut.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Dim pagesize, pageno As Integer
    Dim dr As DataRow
    Dim i As Integer = 1
    Private Sub Sub_Group_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_GroupCode.Enabled = True
        txt_GroupCode.ReadOnly = False
        txt_GroupDesc.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        SubGroupMasterbool = True
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

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        ssgrid.ClearRange(1, 1, -1, -1, True)
        ssgrid.SetActiveCell(1, 1)
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_GroupCode.Enabled = True
        txt_GroupCode.ReadOnly = False
        txt_GroupDesc.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_GroupCode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        Dim Insert(0) As String
        Dim subgroupdesc As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            For i = 1 To ssgrid.DataRowCnt
                With ssgrid
                    .Col = 2
                    .Row = i
                    If Trim(.Text) <> "" Then
                        strSQL = " INSERT INTO inventorysubgroupmaster (Groupcode,Groupdesc,Subgroupcode,Subgroupdesc,Freeze,Adduser,Adddate)"
                        strSQL = strSQL & " VALUES ( '" & Trim(txt_GroupCode.Text) & "','" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
                        .Col = 1
                        strSQL = strSQL & "'" & Trim(.Text) & "',"
                        .Col = 2
                        strSQL = strSQL & "'" & Trim(.Text) & "',"
                        strSQL = strSQL & " 'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = strSQL
                    End If
                End With
            Next i
            gconnection.MoreTrans(Insert)
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
            strSQL = strSQL & " DELETE FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL
            For i = 1 To ssgrid.DataRowCnt
                With ssgrid
                    .Col = 2
                    .Row = i
                    If Trim(.Text) <> "" Then
                        strSQL = " INSERT INTO inventorysubgroupmaster (Groupcode,Groupdesc,Subgroupcode,Subgroupdesc,Freeze,Adduser,Adddate)"
                        strSQL = strSQL & " VALUES ( '" & Trim(txt_GroupCode.Text) & "','" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
                        .Col = 1
                        strSQL = strSQL & "'" & Trim(.Text) & "',"
                        .Col = 2
                        strSQL = strSQL & "'" & Trim(.Text) & "',"
                        strSQL = strSQL & " 'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = strSQL
                    End If
                End With
            Next i
            gconnection.MoreTrans(Insert)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  inventorysubgroupmaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txt_GroupCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "inventorysubgroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  inventorysubgroupmaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txt_GroupCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "inventorysubgroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        PRINTOPERATION()
    End Sub

    Private Sub PRINTOPERATION()
        Dim x, docno, printline As String
        Dim I As Integer
        Dim booldocno As Boolean
        Dim total(10) As Double
        Dim GROUPCODE As String
        Dim vsubheader() As String = {"DOC NO. : ", "DOC DATE : ", "MAIN STORE CODE : ", "MAIN STORE NAME : ", "TO STORE CODE  : ", "TO STORE NAME :"}
        Dim PAGEHEADING() As String = {"INVENTORY SUBGROUP MASTER"}
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            sqlstring = "SELECT GROUPCODE,GROUPDESC,SUBGROUPCODE,SUBGROUPDESC,FREEZE FROM INVENTORYSUBGROUPMASTER ORDER BY GROUPCODE"
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            Call Print_Headers(PAGEHEADING)
            For Each dr In gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows
                If GROUPCODE <> Trim(dr.Item("GROUPCODE")) Then
                    Filewrite.WriteLine("|{0,-9}|{1,-25}{2,-9}{3,-25}{4,9}|", Mid(dr.Item("GROUPCODE"), 1, 10), Mid(dr.Item("GROUPDESC"), 1, 30), " ", " ", " ")
                    pagesize = pagesize + 1
                End If
                GROUPCODE = Trim(dr.Item("GROUPCODE"))
                Filewrite.WriteLine("|{0,-9}|{1,-25}|{2,-9}|{3,-25}|{4,6}|", " ", " ", Mid(dr.Item("SUBGROUPCODE"), 1, 10), Mid(dr.Item("SUBGROUPDESC"), 1, 30), Mid(dr.Item("FREEZE"), 1, 6))
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
            Filewrite.WriteLine()
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
            Filewrite.WriteLine("|{0,-9}|{1,-25}|{2,-9}|{3,-25}|{4,6}|", "GROUPCODE", "GROUP DESCRIPTION", "SUBGROUP", "SUBGROUP DESCRIPTION", "FREEZE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(80, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function


    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub cmdGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupCode.Click
        gSQLString = "SELECT Groupcode,groupdesc FROM inventorygroupmaster"
        M_WhereCondition = " WHERE freeze='N' "
        Dim vform As New List_Operation
        vform.Field = "GROUPDESC,GROUPCODE"
        vform.vFormatstring = "       GROUP CODE     |        GROUP DESCRIPTION                             "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_GroupCode.Text = Trim(vform.keyfield & "")
            Call txt_GroupCode_Validated(txt_GroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_GroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_GroupCode.Text) = "" Then
                Call cmdGroupCode_Click(cmdGroupCode, e)
            Else
                Me.txt_GroupCode_Validated(txt_GroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_GroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupDesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssgrid.Focus()
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Store Code Can't be blank *********************'''
        If Trim(txt_GroupCode.Text) = "" Then
            MessageBox.Show(" Store Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  Store desc Can't be blank *********************'''
        If Trim(txt_GroupDesc.Text) = "" Then
            MessageBox.Show(" Store Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupDesc.Focus()
            Exit Sub
        End If
        ''' ********** Check SubgroupCode and Subgroupdesc can't be blank ***********'''
        With ssgrid
            For i = 1 To .DataRowCnt
                .Row = i
                .Col = 1
                If Trim(.Text) = "" Then
                    MessageBox.Show("SubGroupCode can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    .SetActiveCell(1, ssgrid.ActiveRow)
                    .Focus()
                    Exit Sub
                End If
                .Col = 2
                If Trim(.Text) = "" Then
                    MessageBox.Show("SubGroupdesc can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    .SetActiveCell(2, ssgrid.ActiveRow)
                    .Focus()
                    Exit Sub
                End If
            Next i
        End With
        boolchk = True
    End Sub

    Private Sub txt_GroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GroupCode.Validated
        Dim j As Integer
        If Trim(txt_GroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_GroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Groupdesc"))
                With ssgrid
                    For i = 1 To gdataset.Tables("inventorysubgroupmaster").Rows.Count
                        .SetText(1, i, Trim(gdataset.Tables("inventorysubgroupmaster").Rows(j).Item("Subgroupcode")) & "")
                        .SetText(2, i, Trim(gdataset.Tables("inventorysubgroupmaster").Rows(j).Item("Subgroupdesc")) & "")
                        j = j + 1
                    Next
                End With
                If gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("AddDate")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
            Else
                sqlstring = "SELECT * FROM inventorygroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND Freeze='N'"
                gconnection.getDataSet(sqlstring, "inventorygroupmaster")
                If gdataset.Tables("inventorygroupmaster").Rows.Count > 0 Then
                    txt_GroupCode.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupcode"))
                    txt_GroupDesc.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupdesc"))
                    txt_GroupCode.ReadOnly = True
                    Me.Cmd_Add.Text = "Add [F7]"
                    txt_GroupDesc.Focus()
                Else
                    txt_GroupCode.Text = ""
                    txt_GroupDesc.Text = ""
                    txt_GroupCode.Focus()
                End If
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            txt_GroupCode.Text = ""
            txt_GroupDesc.Focus()
        End If
    End Sub

    Private Sub Sub_Group_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txt_GroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_GroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdGroupCode.Enabled = True Then
                search = Trim(txt_GroupCode.Text)
                Call cmdGroupCode_Click(cmdGroupCode, e)
            End If
        End If
    End Sub

    Private Sub Sub_Group_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        SubGroupMasterbool = False
    End Sub


    Private Sub ssgrid_KeyDownEvent1(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        If e.keyCode = Keys.F3 Then
            With ssgrid
                .Row = .ActiveRow
                .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, ssgrid.ActiveRow)
                .Focus()
            End With
        End If
    End Sub

    Private Sub ssgrid_KeyPressEvent1(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles ssgrid.KeyPressEvent
        If Asc(e.keyAscii) = 13 Or ssgrid.ActiveCol = 1 Then
            With ssgrid
                If .ActiveRow = 1 Then
                    .SetText(1, .ActiveRow, 1)
                ElseIf .ActiveRow = 2 Then
                    .SetText(1, .ActiveRow, 2)
                ElseIf .ActiveRow = 3 Then
                    .SetText(1, .ActiveRow, 3)
                ElseIf .ActiveRow = 4 Then
                    .SetText(1, .ActiveRow, 4)
                ElseIf .ActiveRow = 5 Then
                    .SetText(1, .ActiveRow, 5)
                ElseIf .ActiveRow = 6 Then
                    .SetText(1, .ActiveRow, 6)
                ElseIf .ActiveRow = 7 Then
                    .SetText(1, .ActiveRow, 7)
                ElseIf .ActiveRow = 8 Then
                    .SetText(1, .ActiveRow, 8)
                ElseIf .ActiveRow = 9 Then
                    .SetText(1, .ActiveRow, 9)
                ElseIf .ActiveRow = 10 Then
                    .SetText(1, .ActiveRow, 10)
                End If
            End With
            If ssgrid.ActiveCol = 2 And ssgrid.ActiveRow = 10 Then
                Cmd_Add.Focus()
            End If
            i = i + 1
        End If
    End Sub

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        gPrint = True
        PRINTOPERATION()
    End Sub
End Class
