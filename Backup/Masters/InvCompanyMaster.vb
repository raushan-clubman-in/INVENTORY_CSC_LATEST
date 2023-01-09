Imports System.IO
Public Class InvCompanyMaster
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_GroupDescription As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmdCompanyCode As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents txt_CompanyDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_CompanyCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(InvCompanyMaster))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_CompanyDesc = New System.Windows.Forms.TextBox
        Me.txt_CompanyCode = New System.Windows.Forms.TextBox
        Me.lbl_GroupDescription = New System.Windows.Forms.Label
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.cmdCompanyCode = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(232, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(256, 31)
        Me.lbl_Heading.TabIndex = 8
        Me.lbl_Heading.Text = "COMPANY  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_CompanyDesc)
        Me.GroupBox1.Controls.Add(Me.txt_CompanyCode)
        Me.GroupBox1.Controls.Add(Me.lbl_GroupDescription)
        Me.GroupBox1.Controls.Add(Me.lbl_GroupCode)
        Me.GroupBox1.Controls.Add(Me.cmdCompanyCode)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 152)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txt_CompanyDesc
        '
        Me.txt_CompanyDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_CompanyDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CompanyDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CompanyDesc.Location = New System.Drawing.Point(341, 84)
        Me.txt_CompanyDesc.MaxLength = 50
        Me.txt_CompanyDesc.Name = "txt_CompanyDesc"
        Me.txt_CompanyDesc.Size = New System.Drawing.Size(213, 26)
        Me.txt_CompanyDesc.TabIndex = 13
        Me.txt_CompanyDesc.Text = ""
        '
        'txt_CompanyCode
        '
        Me.txt_CompanyCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_CompanyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CompanyCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CompanyCode.Location = New System.Drawing.Point(341, 42)
        Me.txt_CompanyCode.MaxLength = 10
        Me.txt_CompanyCode.Name = "txt_CompanyCode"
        Me.txt_CompanyCode.Size = New System.Drawing.Size(189, 26)
        Me.txt_CompanyCode.TabIndex = 12
        Me.txt_CompanyCode.Text = ""
        '
        'lbl_GroupDescription
        '
        Me.lbl_GroupDescription.AutoSize = True
        Me.lbl_GroupDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupDescription.Location = New System.Drawing.Point(203, 87)
        Me.lbl_GroupDescription.Name = "lbl_GroupDescription"
        Me.lbl_GroupDescription.Size = New System.Drawing.Size(126, 18)
        Me.lbl_GroupDescription.TabIndex = 16
        Me.lbl_GroupDescription.Text = "COMPANY NAME :"
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(205, 46)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(126, 18)
        Me.lbl_GroupCode.TabIndex = 14
        Me.lbl_GroupCode.Text = "COMPANY CODE :"
        '
        'cmdCompanyCode
        '
        Me.cmdCompanyCode.Image = CType(resources.GetObject("cmdCompanyCode.Image"), System.Drawing.Image)
        Me.cmdCompanyCode.Location = New System.Drawing.Point(533, 42)
        Me.cmdCompanyCode.Name = "cmdCompanyCode"
        Me.cmdCompanyCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdCompanyCode.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(21, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 21)
        Me.Label5.TabIndex = 420
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(223, 242)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 418
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.cmd_Print)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 56)
        Me.GroupBox2.TabIndex = 419
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 12)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 8
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(358, 12)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 10
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(244, 12)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 9
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(130, 12)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 7
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(580, 12)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 11
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(470, 13)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 6
        Me.cmd_Print.Text = " Print[F10]"
        '
        'InvCompanyMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(736, 366)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Heading)
        Me.KeyPreview = True
        Me.Name = "InvCompanyMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InvCompanyMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
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
    Private Sub InvCompanyMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_CompanyCode.Enabled = True
        txt_CompanyCode.ReadOnly = False
        txt_CompanyDesc.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        GroupMasterbool = True
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
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_CompanyCode.Enabled = True
        txt_CompanyCode.ReadOnly = False
        txt_CompanyDesc.ReadOnly = False
        txt_CompanyCode.Text = ""
        txt_CompanyDesc.Text = ""
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_CompanyCode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            strSQL = " INSERT INTO INVENTORYCOMPANYMASTER (Companycode,CompanyName,Freeze,Adduser,Adddate)"
            strSQL = strSQL & "VALUES ( '" & Trim(txt_CompanyCode.Text) & "','" & Replace(Trim(txt_CompanyDesc.Text), "'", "") & "',"
            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, strSQL, "inventorycompanymaster")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub
            strSQL = "UPDATE  INVENTORYCOMPANYMASTER "
            strSQL = strSQL & " SET CompanyName='" & Replace(Trim(txt_CompanyDesc.Text), "'", "") & "',"
            strSQL = strSQL & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            strSQL = strSQL & " WHERE Companycode = '" & Trim(txt_CompanyCode.Text) & "'"
            gconnection.dataOperation(2, strSQL, "inventorycompanymaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Group Code Can't be blank *********************'''
        If Trim(txt_CompanyCode.Text) = "" Then
            MessageBox.Show(" Company Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CompanyCode.Focus()
            Exit Sub
        End If
        '''********** Check  Group desc Can't be blank *********************'''
        If Trim(txt_CompanyDesc.Text) = "" Then
            MessageBox.Show(" Company Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CompanyDesc.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  INVENTORYCOMPANYMASTER "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Companycode = '" & Trim(txt_CompanyCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "inventorygroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  INVENTORYCOMPANYMASTER "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Companycode = '" & Trim(txt_CompanyCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "inventorygroupmaster")
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
        Dim vsubheader() As String = {"DOC NO. : ", "DOC DATE : ", "MAIN STORE CODE : ", "MAIN STORE NAME : ", "TO STORE CODE  : ", "TO STORE NAME :"}
        Dim PAGEHEADING() As String = {"INVENTORY COMPANY MASTER"}
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            sqlstring = "SELECT ISNULL(COMPANYCODE,'') AS COMPANYCODE,ISNULL(COMPANYNAME,'') AS COMPANYNAME,ISNULL(FREEZE,'') AS FREEZE FROM INVENTORYCOMPANYMASTER"
            gconnection.getDataSet(sqlstring, "INVENTORYCOMPANYMASTER")
            Call Print_Headers(PAGEHEADING)
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For Each dr In gdataset.Tables("INVENTORYCOMPANYMASTER").Rows
                Filewrite.WriteLine("|{0,-15}|{1,-45}|{2,5}|", Mid(dr.Item("COMPANYCODE"), 1, 15), Mid(dr.Item("COMPANYNAME"), 1, 45), Mid(dr.Item("FREEZE"), 1, 5))
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
            Filewrite.WriteLine("|{0,-15}|{1,-45}|{2,5}|", "COMPANYCODE", "COMAPNY NAME", "FREEZE")
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

    Private Sub InvCompanyMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        gPrint = True
        Call PRINTOPERATION()
    End Sub

    Private Sub txt_CompanyCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CompanyCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdCompanyCode.Enabled = True Then
                search = Trim(txt_CompanyCode.Text)
                Call cmdCompanyCode_Click(cmdCompanyCode, e)
            End If
        End If
    End Sub

    Private Sub txt_CompanyDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CompanyDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cmdCompanyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompanyCode.Click
        gSQLString = "SELECT ISNULL(COMPANYCODE,'') AS COMPANYCODE,ISNULL(COMPANYNAME,'') AS COMPANYNAME FROM INVENTORYCOMPANYMASTER"
        M_WhereCondition = " "
        Dim vform As New List_Operation
        vform.Field = "COMPANYNAME,COMPANYCODE"
        vform.vFormatstring = "         COMPANY CODE              |                  COMAPNY NAME                   "
        vform.vCaption = "COMPANY MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_CompanyCode.Text = Trim(vform.keyfield & "")
            Call txt_CompanyCode_Validated(txt_CompanyCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_CompanyCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CompanyCode.Validated
        If Trim(txt_CompanyCode.Text) <> "" Then
            sqlstring = "SELECT * FROM INVENTORYCOMPANYMASTER WHERE COMPANYCODE='" & Trim(txt_CompanyCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "inventorycompanymaster")
            If gdataset.Tables("inventorycompanymaster").Rows.Count > 0 Then
                txt_CompanyCode.Text = Trim(gdataset.Tables("inventorycompanymaster").Rows(0).Item("CompanyCode"))
                txt_CompanyDesc.Text = Trim(gdataset.Tables("inventorycompanymaster").Rows(0).Item("CompanyName"))
                txt_CompanyDesc.Focus()
                txt_CompanyCode.ReadOnly = True
                If gdataset.Tables("inventorycompanymaster").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("inventorycompanymaster").Rows(0).Item("AddDate")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txt_CompanyCode.ReadOnly = False
                txt_CompanyDesc.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            txt_CompanyCode.Text = ""
            txt_CompanyDesc.Focus()
        End If
    End Sub

    Private Sub txt_CompanyCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CompanyCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_CompanyCode.Text) = "" Then
                Call cmdCompanyCode_Click(cmdCompanyCode, e)
            Else
                txt_CompanyCode_Validated(txt_CompanyCode, e)
            End If
        End If
    End Sub
End Class
