Imports System.Data.SqlClient
Imports System.IO
Public Class Stock_Issue_Indent
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
    Friend WithEvents txt_Docno As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Docnohelp As System.Windows.Forms.Button
    Friend WithEvents txt_Mainstore As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Totalamount As System.Windows.Forms.Label
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tostore As System.Windows.Forms.Label
    Friend WithEvents lbl_Mainstore As System.Windows.Forms.Label
    Friend WithEvents dtp_Docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Docdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Docno As System.Windows.Forms.Label
    Friend WithEvents grp_issue1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_issue2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Tostore As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Tostorecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mainstorecode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents grp_Stockissue As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Stockissuedetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_IssueView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Issueexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_IssueClear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Issueprint As System.Windows.Forms.Button
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_closingqty As System.Windows.Forms.Label
    Friend WithEvents lbl_Help As System.Windows.Forms.Label
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_IndentNo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_IndentNoHelp As System.Windows.Forms.Button
    Friend WithEvents dtp_IndentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Stock_Issue_Indent))
        Me.txt_Docno = New System.Windows.Forms.TextBox
        Me.Cmd_Docnohelp = New System.Windows.Forms.Button
        Me.txt_Mainstore = New System.Windows.Forms.TextBox
        Me.lbl_Totalamount = New System.Windows.Forms.Label
        Me.txt_Totalamount = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Tostore = New System.Windows.Forms.Label
        Me.lbl_Mainstore = New System.Windows.Forms.Label
        Me.dtp_Docdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Docdate = New System.Windows.Forms.Label
        Me.lbl_Docno = New System.Windows.Forms.Label
        Me.grp_issue1 = New System.Windows.Forms.GroupBox
        Me.txt_Tostorecode = New System.Windows.Forms.TextBox
        Me.grp_issue2 = New System.Windows.Forms.GroupBox
        Me.cbo_Tostore = New System.Windows.Forms.ComboBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.txt_Mainstorecode = New System.Windows.Forms.TextBox
        Me.grp_Stockissue = New System.Windows.Forms.GroupBox
        Me.lbl_Stockissuedetails = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Issueprint = New System.Windows.Forms.Button
        Me.Cmd_IssueView = New System.Windows.Forms.Button
        Me.Cmd_Issueexit = New System.Windows.Forms.Button
        Me.Cmd_IssueClear = New System.Windows.Forms.Button
        Me.lbl_FromDocno = New System.Windows.Forms.Label
        Me.txt_FromDocno = New System.Windows.Forms.TextBox
        Me.lbl_ToDocno = New System.Windows.Forms.Label
        Me.txt_ToDocno = New System.Windows.Forms.TextBox
        Me.Cmd_ToDocno = New System.Windows.Forms.Button
        Me.Cmd_FromDocno = New System.Windows.Forms.Button
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.lbl_closingqty = New System.Windows.Forms.Label
        Me.lbl_Help = New System.Windows.Forms.Label
        Me.cmd_storecode = New System.Windows.Forms.Button
        Me.Txt_IndentNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_IndentNoHelp = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_IndentDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Txt_qty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chk_item = New System.Windows.Forms.CheckBox
        Me.grp_footer = New System.Windows.Forms.GroupBox
        Me.Txt_signature = New System.Windows.Forms.TextBox
        Me.Txt_footer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.frmbut.SuspendLayout()
        Me.grp_Stockissue.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Docno
        '
        Me.txt_Docno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Docno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Docno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Docno.Location = New System.Drawing.Point(256, 182)
        Me.txt_Docno.MaxLength = 15
        Me.txt_Docno.Name = "txt_Docno"
        Me.txt_Docno.Size = New System.Drawing.Size(232, 26)
        Me.txt_Docno.TabIndex = 1
        Me.txt_Docno.Text = ""
        '
        'Cmd_Docnohelp
        '
        Me.Cmd_Docnohelp.Image = CType(resources.GetObject("Cmd_Docnohelp.Image"), System.Drawing.Image)
        Me.Cmd_Docnohelp.Location = New System.Drawing.Point(488, 181)
        Me.Cmd_Docnohelp.Name = "Cmd_Docnohelp"
        Me.Cmd_Docnohelp.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_Docnohelp.TabIndex = 21
        '
        'txt_Mainstore
        '
        Me.txt_Mainstore.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Mainstore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstore.Location = New System.Drawing.Point(344, 106)
        Me.txt_Mainstore.MaxLength = 15
        Me.txt_Mainstore.Name = "txt_Mainstore"
        Me.txt_Mainstore.ReadOnly = True
        Me.txt_Mainstore.Size = New System.Drawing.Size(168, 26)
        Me.txt_Mainstore.TabIndex = 15
        Me.txt_Mainstore.Text = ""
        '
        'lbl_Totalamount
        '
        Me.lbl_Totalamount.AutoSize = True
        Me.lbl_Totalamount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalamount.Location = New System.Drawing.Point(880, 520)
        Me.lbl_Totalamount.Name = "lbl_Totalamount"
        Me.lbl_Totalamount.Size = New System.Drawing.Size(89, 18)
        Me.lbl_Totalamount.TabIndex = 23
        Me.lbl_Totalamount.Text = "TOTAL AMT :"
        Me.lbl_Totalamount.Visible = False
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamount.Location = New System.Drawing.Point(872, 488)
        Me.txt_Totalamount.MaxLength = 15
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamount.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamount.TabIndex = 4
        Me.txt_Totalamount.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(8, 528)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(80, 18)
        Me.lbl_Remarks.TabIndex = 25
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Tostore
        '
        Me.lbl_Tostore.AutoSize = True
        Me.lbl_Tostore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tostore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tostore.Location = New System.Drawing.Point(157, 144)
        Me.lbl_Tostore.Name = "lbl_Tostore"
        Me.lbl_Tostore.Size = New System.Drawing.Size(83, 18)
        Me.lbl_Tostore.TabIndex = 17
        Me.lbl_Tostore.Text = "TO STORE :"
        '
        'lbl_Mainstore
        '
        Me.lbl_Mainstore.AutoSize = True
        Me.lbl_Mainstore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mainstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mainstore.Location = New System.Drawing.Point(136, 110)
        Me.lbl_Mainstore.Name = "lbl_Mainstore"
        Me.lbl_Mainstore.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Mainstore.TabIndex = 14
        Me.lbl_Mainstore.Text = "FROM STORE :"
        '
        'dtp_Docdate
        '
        Me.dtp_Docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Docdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Docdate.Location = New System.Drawing.Point(680, 181)
        Me.dtp_Docdate.Name = "dtp_Docdate"
        Me.dtp_Docdate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Docdate.TabIndex = 2
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(408, 56)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(226, 31)
        Me.lbl_Heading.TabIndex = 12
        Me.lbl_Heading.Text = "ISSUE TO STORES"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Docdate
        '
        Me.lbl_Docdate.AutoSize = True
        Me.lbl_Docdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docdate.Location = New System.Drawing.Point(560, 146)
        Me.lbl_Docdate.Name = "lbl_Docdate"
        Me.lbl_Docdate.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Docdate.TabIndex = 22
        Me.lbl_Docdate.Text = "INDENT DATE :"
        '
        'lbl_Docno
        '
        Me.lbl_Docno.AutoSize = True
        Me.lbl_Docno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docno.Location = New System.Drawing.Point(576, 109)
        Me.lbl_Docno.Name = "lbl_Docno"
        Me.lbl_Docno.Size = New System.Drawing.Size(88, 18)
        Me.lbl_Docno.TabIndex = 20
        Me.lbl_Docno.Text = "INDENT NO :"
        '
        'grp_issue1
        '
        Me.grp_issue1.BackgroundImage = CType(resources.GetObject("grp_issue1.BackgroundImage"), System.Drawing.Image)
        Me.grp_issue1.Location = New System.Drawing.Point(120, 88)
        Me.grp_issue1.Name = "grp_issue1"
        Me.grp_issue1.Size = New System.Drawing.Size(400, 86)
        Me.grp_issue1.TabIndex = 13
        Me.grp_issue1.TabStop = False
        '
        'txt_Tostorecode
        '
        Me.txt_Tostorecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Tostorecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tostorecode.Location = New System.Drawing.Point(448, 141)
        Me.txt_Tostorecode.Name = "txt_Tostorecode"
        Me.txt_Tostorecode.Size = New System.Drawing.Size(64, 26)
        Me.txt_Tostorecode.TabIndex = 18
        Me.txt_Tostorecode.Text = ""
        '
        'grp_issue2
        '
        Me.grp_issue2.BackgroundImage = CType(resources.GetObject("grp_issue2.BackgroundImage"), System.Drawing.Image)
        Me.grp_issue2.Location = New System.Drawing.Point(520, 88)
        Me.grp_issue2.Name = "grp_issue2"
        Me.grp_issue2.Size = New System.Drawing.Size(392, 86)
        Me.grp_issue2.TabIndex = 19
        Me.grp_issue2.TabStop = False
        '
        'cbo_Tostore
        '
        Me.cbo_Tostore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tostore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tostore.Location = New System.Drawing.Point(256, 140)
        Me.cbo_Tostore.Name = "cbo_Tostore"
        Me.cbo_Tostore.Size = New System.Drawing.Size(184, 27)
        Me.cbo_Tostore.TabIndex = 0
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(56, 600)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 7
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(504, 600)
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
        Me.Cmd_Freeze.Location = New System.Drawing.Point(360, 600)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 9
        Me.Cmd_Freeze.Text = "Void[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(208, 600)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 8
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(800, 600)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 11
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Location = New System.Drawing.Point(16, 584)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(928, 56)
        Me.frmbut.TabIndex = 27
        Me.frmbut.TabStop = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(632, 16)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 22
        Me.cmd_Print.Text = "Print[F10]"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(616, 560)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Freeze.TabIndex = 26
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'txt_Mainstorecode
        '
        Me.txt_Mainstorecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstorecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstorecode.Location = New System.Drawing.Point(256, 106)
        Me.txt_Mainstorecode.Name = "txt_Mainstorecode"
        Me.txt_Mainstorecode.Size = New System.Drawing.Size(64, 26)
        Me.txt_Mainstorecode.TabIndex = 16
        Me.txt_Mainstorecode.Text = ""
        '
        'grp_Stockissue
        '
        Me.grp_Stockissue.BackgroundImage = CType(resources.GetObject("grp_Stockissue.BackgroundImage"), System.Drawing.Image)
        Me.grp_Stockissue.Controls.Add(Me.lbl_Stockissuedetails)
        Me.grp_Stockissue.Controls.Add(Me.GroupBox2)
        Me.grp_Stockissue.Controls.Add(Me.lbl_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.txt_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.lbl_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.txt_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_Stockissue.Location = New System.Drawing.Point(64, 1000)
        Me.grp_Stockissue.Name = "grp_Stockissue"
        Me.grp_Stockissue.Size = New System.Drawing.Size(520, 214)
        Me.grp_Stockissue.TabIndex = 360
        Me.grp_Stockissue.TabStop = False
        '
        'lbl_Stockissuedetails
        '
        Me.lbl_Stockissuedetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Stockissuedetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockissuedetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Stockissuedetails.Location = New System.Drawing.Point(0, 9)
        Me.lbl_Stockissuedetails.Name = "lbl_Stockissuedetails"
        Me.lbl_Stockissuedetails.Size = New System.Drawing.Size(520, 24)
        Me.lbl_Stockissuedetails.TabIndex = 26
        Me.lbl_Stockissuedetails.Text = "ISSUE CHECKLIST"
        Me.lbl_Stockissuedetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueprint)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueView)
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueexit)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueClear)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Issueprint
        '
        Me.Cmd_Issueprint.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Issueprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Issueprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Issueprint.ForeColor = System.Drawing.Color.White
        Me.Cmd_Issueprint.Image = CType(resources.GetObject("Cmd_Issueprint.Image"), System.Drawing.Image)
        Me.Cmd_Issueprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_Issueprint.Name = "Cmd_Issueprint"
        Me.Cmd_Issueprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Issueprint.TabIndex = 25
        Me.Cmd_Issueprint.Text = "Print [F10]"
        '
        'Cmd_IssueView
        '
        Me.Cmd_IssueView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_IssueView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_IssueView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_IssueView.ForeColor = System.Drawing.Color.White
        Me.Cmd_IssueView.Image = CType(resources.GetObject("Cmd_IssueView.Image"), System.Drawing.Image)
        Me.Cmd_IssueView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_IssueView.Name = "Cmd_IssueView"
        Me.Cmd_IssueView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_IssueView.TabIndex = 13
        Me.Cmd_IssueView.Text = "View [F9]"
        '
        'Cmd_Issueexit
        '
        Me.Cmd_Issueexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Issueexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Issueexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Issueexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Issueexit.Image = CType(resources.GetObject("Cmd_Issueexit.Image"), System.Drawing.Image)
        Me.Cmd_Issueexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_Issueexit.Name = "Cmd_Issueexit"
        Me.Cmd_Issueexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Issueexit.TabIndex = 15
        Me.Cmd_Issueexit.Text = "Exit[F11]"
        '
        'Cmd_IssueClear
        '
        Me.Cmd_IssueClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_IssueClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_IssueClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_IssueClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_IssueClear.Image = CType(resources.GetObject("Cmd_IssueClear.Image"), System.Drawing.Image)
        Me.Cmd_IssueClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_IssueClear.Name = "Cmd_IssueClear"
        Me.Cmd_IssueClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_IssueClear.TabIndex = 24
        Me.Cmd_IssueClear.Text = "Clear[F6]"
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(48, 56)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 22)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM DOC NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(200, 56)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        Me.txt_FromDocno.Text = ""
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(72, 104)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(109, 22)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO DOC NO :"
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(200, 104)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        Me.txt_ToDocno.Text = ""
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ToDocno.Image = CType(resources.GetObject("Cmd_ToDocno.Image"), System.Drawing.Image)
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(408, 104)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FromDocno.Image = CType(resources.GetObject("Cmd_FromDocno.Image"), System.Drawing.Image)
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(408, 56)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 232)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(976, 256)
        Me.ssgrid.TabIndex = 368
        '
        'lbl_closingqty
        '
        Me.lbl_closingqty.AutoSize = True
        Me.lbl_closingqty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_closingqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_closingqty.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.lbl_closingqty.Location = New System.Drawing.Point(24, 496)
        Me.lbl_closingqty.Name = "lbl_closingqty"
        Me.lbl_closingqty.Size = New System.Drawing.Size(155, 25)
        Me.lbl_closingqty.TabIndex = 369
        Me.lbl_closingqty.Text = "CLOSING QTY :"
        Me.lbl_closingqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_closingqty.Visible = False
        '
        'lbl_Help
        '
        Me.lbl_Help.AutoSize = True
        Me.lbl_Help.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Help.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Help.ForeColor = System.Drawing.Color.Red
        Me.lbl_Help.Location = New System.Drawing.Point(80, 640)
        Me.lbl_Help.Name = "lbl_Help"
        Me.lbl_Help.Size = New System.Drawing.Size(821, 21)
        Me.lbl_Help.TabIndex = 372
        Me.lbl_Help.Text = "Press F4 For help option/Press F3 for deleting particular row/Press F2 to focus o" & _
        "n DOCNO./Alt+R to focus on Remarks box"
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(320, 106)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 373
        '
        'Txt_IndentNo
        '
        Me.Txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.Txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_IndentNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IndentNo.Location = New System.Drawing.Point(680, 104)
        Me.Txt_IndentNo.MaxLength = 15
        Me.Txt_IndentNo.Name = "Txt_IndentNo"
        Me.Txt_IndentNo.Size = New System.Drawing.Size(192, 26)
        Me.Txt_IndentNo.TabIndex = 374
        Me.Txt_IndentNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 375
        Me.Label1.Text = "ISSUE DOC NO :"
        '
        'cmd_IndentNoHelp
        '
        Me.cmd_IndentNoHelp.Image = CType(resources.GetObject("cmd_IndentNoHelp.Image"), System.Drawing.Image)
        Me.cmd_IndentNoHelp.Location = New System.Drawing.Point(872, 104)
        Me.cmd_IndentNoHelp.Name = "cmd_IndentNoHelp"
        Me.cmd_IndentNoHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_IndentNoHelp.TabIndex = 376
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "ISSUE DOC DATE :"
        '
        'dtp_IndentDate
        '
        Me.dtp_IndentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_IndentDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_IndentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_IndentDate.Location = New System.Drawing.Point(680, 138)
        Me.dtp_IndentDate.Name = "dtp_IndentDate"
        Me.dtp_IndentDate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_IndentDate.TabIndex = 377
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 48)
        Me.GroupBox1.TabIndex = 379
        Me.GroupBox1.TabStop = False
        '
        'Txt_qty
        '
        Me.Txt_qty.BackColor = System.Drawing.Color.Wheat
        Me.Txt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_qty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_qty.Location = New System.Drawing.Point(696, 488)
        Me.Txt_qty.MaxLength = 15
        Me.Txt_qty.Name = "Txt_qty"
        Me.Txt_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_qty.Size = New System.Drawing.Size(88, 26)
        Me.Txt_qty.TabIndex = 380
        Me.Txt_qty.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 381
        Me.Label3.Text = "TOTAL QTY :"
        Me.Label3.Visible = False
        '
        'Chk_item
        '
        Me.Chk_item.BackgroundImage = CType(resources.GetObject("Chk_item.BackgroundImage"), System.Drawing.Image)
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_item.Location = New System.Drawing.Point(16, 560)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(120, 24)
        Me.Chk_item.TabIndex = 463
        Me.Chk_item.Text = "FooterUpdation"
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(56, 504)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(920, 80)
        Me.grp_footer.TabIndex = 464
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(776, 22)
        Me.Txt_signature.TabIndex = 441
        Me.Txt_signature.Text = ""
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(776, 22)
        Me.Txt_footer.TabIndex = 440
        Me.Txt_footer.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 439
        Me.Label9.Text = "FOOTER SIGN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 438
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 438
        Me.Label8.Text = "FOOTER NAME:"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Location = New System.Drawing.Point(96, 528)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(480, 32)
        Me.txt_Remarks.TabIndex = 443
        Me.txt_Remarks.Text = ""
        '
        'Stock_Issue_Indent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(982, 684)
        Me.Controls.Add(Me.grp_footer)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_qty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_IndentNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Help)
        Me.Controls.Add(Me.lbl_closingqty)
        Me.Controls.Add(Me.txt_Mainstorecode)
        Me.Controls.Add(Me.txt_Docno)
        Me.Controls.Add(Me.txt_Mainstore)
        Me.Controls.Add(Me.lbl_Totalamount)
        Me.Controls.Add(Me.txt_Totalamount)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_Tostore)
        Me.Controls.Add(Me.lbl_Mainstore)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Docdate)
        Me.Controls.Add(Me.lbl_Docno)
        Me.Controls.Add(Me.txt_Tostorecode)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.dtp_IndentDate)
        Me.Controls.Add(Me.cmd_IndentNoHelp)
        Me.Controls.Add(Me.cmd_storecode)
        Me.Controls.Add(Me.grp_Stockissue)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.cbo_Tostore)
        Me.Controls.Add(Me.Cmd_Docnohelp)
        Me.Controls.Add(Me.dtp_Docdate)
        Me.Controls.Add(Me.grp_issue2)
        Me.Controls.Add(Me.grp_issue1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Stock_Issue_Indent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK ISSUE ON INDENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.grp_Stockissue.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_footer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim TotalCount As Integer
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim docno, doctype, docno1() As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode As String
    Dim VSTORECODE, VSTORENAME, VSTRDOCNO As String
    Private Sub Stock_Issue_Indent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            StockIssueTransbool = True
            txt_Docno.ReadOnly = True
            Me.Cmd_Freeze.Enabled = True
            txt_Tostorecode.ReadOnly = True
            ssgrid.SetActiveCell(1, 1)
            grp_Stockissue.Top = 1000
            Call FOOTER()
            grp_footer.Visible = False
            Call FillStore() '''-->Fill Store Desc
            'Call FillMainstore() '''-->Fill Main Store
            'Call GridLocking() '''-->Fill Grid Locking
            lbl_closingqty.Text = ""
            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Show()
            Txt_IndentNo.Focus()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            Call clearform(Me)
            Call FillStore() '''-->Fill Store Desc
            'Call FillMainstore() '''-->Fill Main Store
            Me.dtp_Docdate.Value = Format(Now, "dd/MM/yyyy")
            Me.dtp_IndentDate.Value = Format(Now, "dd/MM/yyyy")
            Call FOOTER()
            grp_footer.Visible = False
            Me.lbl_Freeze.Visible = False
            Me.lbl_Freeze.Text = "Record Void  On "
            ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_Freeze.Text = "Void [F8]"
            Cmd_Add.Text = "Add [F7]"
            ssgrid.SetActiveCell(1, 1)
            grp_Stockissue.Top = 1000
            Cmd_Add.Enabled = True
            Cmd_Freeze.Enabled = True
            txt_Docno.Enabled = True
            txt_Docno.ReadOnly = False
            Txt_IndentNo.ReadOnly = False
            txt_Tostorecode.ReadOnly = False
            Me.Cmd_Freeze.Enabled = True
            txt_Mainstore.ReadOnly = True
            lbl_closingqty.Text = ""
            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Show()
            Txt_IndentNo.Focus()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim Totalamt, totalqty, Avgrate, AvgQuantity As Double
            Dim sqlstring, Itemcode, Insert(0) As String
            Dim dblval, dblqty As Double
            Dim i, j As Integer
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            Calculate()
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            '''*********************************************************** Case-1 : Add [F7] *******************************************'''
            If Cmd_Add.Text = "Add [F7]" Then
                docno1 = Split(Trim(txt_Docno.Text), "/")
                sqlstring = "INSERT INTO STOCKISSUEHEADER(Docno,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
                sqlstring = sqlstring & " Opstorelocationcode, Opstorelocationname, Totalamt,Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime,UPDFOOTER,UPDSIGN)"
                sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                'sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "','" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "','" & Trim(txt_Tostorecode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(cbo_Tostore.Text) & "'," & Format(Val(txt_Totalamount.Text), "0.00") & " ,"
                sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N','" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',"
                sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '" & Trim(Txt_footer.Text) & "',' " & Trim(Txt_signature.Text) & "' )"
                Insert(0) = sqlstring
                '''******************************************************** Insert into stockissuedetail **********************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    sqlstring = "INSERT INTO STOCKISSUEDETAIL(Docno,Docdetails,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname,"
                    sqlstring = sqlstring & " Opstorelocationcode,Opstorelocationname,Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                    sqlstring = sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,adddatetime,Updateuser,Updatetime)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"

                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                    ssgrid.Col = 2
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 9
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    sqlstring = sqlstring & "'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    sqlstring = sqlstring & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next i
                gconnection.MoreTrans(Insert)
                Cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call cmd_Print_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
                docno1 = Split(Trim(txt_Docno.Text), "/")
                'sqlstring = "DELETE FROM stockissueHEADER WHERE docdetails='" & Trim(txt_Docno.Text) & "' "
                ': autogenerate()
                ''''********************************************************** UPDATE stockissueheader *********************************************************'''
                'docno1 = Split(Trim(txt_Docno.Text), "/")
                'sqlstring = "INSERT INTO stockissueheader(docno,docdetails,doctype,docdate,storelocationcode,storelocationname, "
                'sqlstring = sqlstring & " opstorelocationcode, opstorelocationname, totalamt,totalqty,remarks,void,adduser,adddate)"
                'sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                'sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yy hh:mm:ss") & "',"
                'sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "', "
                'sqlstring = sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                'sqlstring = sqlstring & " " & Format(Val(txt_Totalamount.Text), "0.00") & " ," & Format(Val(txt_Totalqty.Text), "0.00") & ","
                'sqlstring = sqlstring & " '" & Trim(txt_Remarks.Text) & "' ,"
                'sqlstring = sqlstring & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                'Insert(0) = sqlstring
                ''''****************************************CHECK FOR CLSSTOCK OF CORRESPONDING SUBSTORE ******************************************************'''
                Dim CURQTY, PREVQTY, CLSQTY, VDIFF As Double
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 4
                    CURQTY = Val(ssgrid.Text)
                    ssgrid.Col = 12
                    PREVQTY = Val(ssgrid.Text)
                    ssgrid.Col = 13
                    CLSQTY = Val(ssgrid.Text)
                    VDIFF = Val(CLSQTY) + Val(PREVQTY) - Val(CURQTY)
                    If Val(VDIFF) < 0 Then
                        'MessageBox.Show("STOCK IS NOT SUFFICIENT TO  MODIFY...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'ssgrid.Col = 4
                        ''ssgrid.Text = ""
                        'ssgrid.SetActiveCell(4, i)
                        'ssgrid.Focus()
                        ''SendKeys.Send("{home}+{end}")
                        'Exit Sub
                    End If
                Next
                ''''*************************************
                sqlstring = "UPDATE STOCKISSUEHEADER SET Docdate='" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "', "
                sqlstring = sqlstring & " Storelocationcode='" & Trim(txt_Mainstorecode.Text) & "',"
                sqlstring = sqlstring & " Storelocationname='" & Trim(txt_Mainstore.Text) & "',"
                sqlstring = sqlstring & " Opstorelocationcode='" & Trim(txt_Tostorecode.Text) & "',"
                sqlstring = sqlstring & " Opstorelocationname='" & Trim(cbo_Tostore.Text) & "', "
                sqlstring = sqlstring & " Totalamt=" & Format(Val(txt_Totalamount.Text), "0.00") & ","
                sqlstring = sqlstring & " UPDFOOTER = ' " & Trim(Txt_footer.Text) & " ' ,"
                sqlstring = sqlstring & " UPDSIGN = ' " & Trim(Txt_signature.Text) & " ' ,"
                sqlstring = sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,Void='N',"
                sqlstring = sqlstring & " VoidReason = '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',Updateuser='" & Trim(gUsername) & "',"
                sqlstring = sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE Docdetails='" & Trim(txt_Docno.Text) & "' "
                sqlstring = sqlstring & " AND INDENTNO = '" & Trim(Txt_IndentNo.Text) & "'"
                Insert(0) = sqlstring
                '''********************************************************* DELETE FROM stockissuedetail *****************************************************'''
                sqlstring = "DELETE FROM STOCKISSUEDETAIL WHERE docdetails='" & Trim(txt_Docno.Text) & "' "
                sqlstring = sqlstring & " AND INDENTNO = '" & Trim(Txt_IndentNo.Text) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''******************************************************** INSERT INTO stockissuedetail ******************************************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    sqlstring = "INSERT INTO STOCKISSUEDETAIL(Docno,Docdetails,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname,"
                    sqlstring = sqlstring & " Opstorelocationcode,Opstorelocationname,Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                    sqlstring = sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,adddatetime,Updateuser,Updatetime)"
                    sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    If Itemcode = "10349" Then
                        sqlstring = sqlstring & " '379',"
                        ssgrid.Col = 2
                        sqlstring = sqlstring & " 'Fresh Lime With water',"
                        ssgrid.Col = 3
                        sqlstring = sqlstring & " 'BOTTLE',"
                        ssgrid.Col = 4
                        sqlstring = sqlstring & " " & 2 * Format(Val(ssgrid.Text), "0.000") & ","
                        ssgrid.Col = 5
                        sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 6
                        sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 7
                        sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                        ssgrid.Col = 8
                        sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 9
                        sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 10
                        sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 11
                        sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
                        sqlstring = sqlstring & " 'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                        sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                        sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                    Else
                        sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                        ssgrid.Col = 2
                        sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 3
                        sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 4
                        sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                        ssgrid.Col = 5
                        sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 6
                        sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 7
                        sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                        ssgrid.Col = 8
                        sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 9
                        sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                        ssgrid.Col = 10
                        sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                        ssgrid.Col = 11
                        sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                        sqlstring = sqlstring & "'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                        sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                        sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                    End If
                    'Dim VNEWCLQTY As Double
                    'ssgrid.Col = 4
                    'CURQTY = ssgrid.Text
                    'ssgrid.Col = 12
                    'PREVQTY = ssgrid.Text
                    'ssgrid.Col = 13
                    'CLSQTY = ssgrid.Text
                    'VNEWCLQTY = CHECKUPDATECLBAL(PREVQTY, CURQTY, CLSQTY)

                    '''****************************************** UPDATE Opening Stock ***************************************
                    'sqlstring = "UPDATE OpeningStock SET "
                    '.Col = 4
                    'sqlstring = sqlstring & " mainclstock = mainclstock - " & Format(Val(.Text), "0.000") & ", "
                    'sqlstring = sqlstring & " doublevalue = doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                    'sqlstring = sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    'sqlstring = sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    'sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '.Col = 1
                    'sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    'ReDim Preserve Insert(Insert.Length)
                    'Insert(Insert.Length - 1) = sqlstring
                    'If Trim(cbo_Tostore.Text) = "BAR-1" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    '.Col = 4
                    '    'sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                    '    sqlstring = sqlstring & " bar1doublevalue = (" & Format(Val(VNEWCLQTY), "0.000") & " * HIGHRATIO ),"
                    '    sqlstring = sqlstring & " mainclstock = mainclstock - " & Format(Val(VNEWCLQTY), "0.000") & " ,"
                    '    sqlstring = sqlstring & " doublevalue =  (" & Format(Val(VNEWCLQTY), "0.000") & " * HIGHRATIO) ,"
                    '    sqlstring = sqlstring & " bar1clstock =   " & Format(Val(VNEWCLQTY), "0.000") & " ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Tostore.Text) = "BAR-2" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 4
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                    '    sqlstring = sqlstring & " mainclstock = mainclstock - " & Format(Val(.Text), "0.000") & " "
                    '    sqlstring = sqlstring & " doublevalue = doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                    '    sqlstring = sqlstring & " bar2clstock =  bar2clstock + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Tostore.Text) = "BAR-3" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 4
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                    '    sqlstring = sqlstring & " mainclstock = mainclstock - " & Format(Val(.Text), "0.000") & " ,"
                    '    sqlstring = sqlstring & " doublevalue = doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                    '    sqlstring = sqlstring & " bar3clstock =  bar3clstock + " & Format(Val(.Text), "0.000") & " ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'End If
                    '''****************************************** UPDATE Complete *********************************************'''
                Next i
                gconnection.MoreTrans(Insert)
                Cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    If Trim(txt_Docno.Text) <> "" Then
                        txt_FromDocno.Text = Trim(txt_Docno.Text)
                        txt_ToDocno.Text = Trim(txt_Docno.Text)
                    End If
                    Call cmd_Print_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function CHECKUPDATECLBAL(ByVal VPREVQTY As Double, ByVal VCURQTY As Double, ByVal VCLQTY As Double) As Double
        Try
            CHECKUPDATECLBAL = Val(VCLQTY) + Val(VCURQTY) - Val(VPREVQTY)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Dim i As Integer
            Dim insert(0), strsql As String
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Then
                '''***************************************** Void the DOCNO in stockissueheader **************************'''
                'sqlstring = "UPDATE  STOCKISSUEHEADER "
                'sqlstring = sqlstring & " SET Void= 'Y',VoidReason = '" & Trim(txt_Remarks.Text) & "',"
                'sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & " ',"
                'sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                'sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                'insert(0) = sqlstring
                ''''***************************************** Void the DOCNO in Complete **********************************'''
                ''''***************************************** Void the DOCNO in stockissuedetails **************************'''
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        sqlstring = "UPDATE  STOCKISSUEDETAIL "
                '        sqlstring = sqlstring & " SET Void= 'Y',"
                '        sqlstring = sqlstring & " Updateuser='" & gUsername & " ',"
                '        sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '        sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                '        ReDim Preserve insert(insert.Length)
                '        insert(insert.Length - 1) = sqlstring
                '    End With
                'Next i
                '''***************************************** Void the DOCNO is Complete **********************************'''
                sqlstring = "INSERT INTO STOCKISSUEHEADER_DEL( Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime )                                        "
                sqlstring = sqlstring & " SELECT Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER A"
                sqlstring = sqlstring & " WHERE A.INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                insert(0) = sqlstring

                sqlstring = " DELETE FROM STOCKISSUEHEADER "
                sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                '''***************************************** DELETE the DOCNO in Complete **********************************'''
                '''***************************************** DELETE the DOCNO in stockissuedetails **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "INSERT INTO STOCKISSUEDETAIL_DEL( Docno , Docdetails , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode  , Opstorelocationname , Itemcode , Itemname , Uom , Qty , Rate , Amount , Dblamt , Dblconv , Highratio , Groupcode , Subgroupcode , Void , Avgqty , Avgrate , Adduser , Adddatetime , Updateuser , Updatetime )               "
                        sqlstring = sqlstring & " SELECT  Docno , Docdetails , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode  , Opstorelocationname , Itemcode , Itemname , Uom , Qty , Rate , Amount , Dblamt , Dblconv , Highratio , Groupcode , Subgroupcode , Void , Avgqty , Avgrate , Adduser , Adddatetime , Updateuser , Updatetime "
                        sqlstring = sqlstring & " FROM STOCKISSUEDETAIL A"
                        sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                        sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring
                    End With
                Next i
                sqlstring = " DELETE FROM STOCKISSUEDETAIL "
                sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                '''****************************************** UPDATE Opening Stock ***************************************
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        .Row = i
                '        .Col = 1
                '        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
                '        Dim opquantity, opamount, grnquantity, grnamount, calquantity As Double
                '        Dim issuequantity, issueamount As Double
                '        Dim calrate, clsquantity As Double
                '        ''''********************************* From Opening Stock *********************************'''
                '        sqlstring = "SELECT opstock,opvalue FROM inventoryitemmaster WHERE Itemcode='" & Trim(.Text) & "'"
                '        gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                '        If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                '            opquantity = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opstock") & ""), "0.000")
                '            opamount = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opvalue") & ""), "0.00")
                '        Else
                '            opquantity = 0
                '            opamount = 0
                '        End If
                '        ''''********************************* From Grn_details *********************************'''
                '        sqlstring = "SELECT SUM(qty) AS QTY ,SUM(AMOUNT) AS AMOUNT FROM grn_details WHERE Itemcode='" & Trim(.Text) & "' AND Voiditem='N'"
                '        gconnection.getDataSet(sqlstring, "grn_details")
                '        If gdataset.Tables("grn_details").Rows.Count > 0 Then
                '            grnquantity = Format(Val(gdataset.Tables("grn_details").Rows(0).Item("QTY") & ""), "0.000")
                '            grnamount = Format(Val(gdataset.Tables("grn_details").Rows(0).Item("AMOUNT") & ""), "0.00")
                '        Else
                '            grnquantity = 0
                '            grnamount = 0
                '        End If
                '        calquantity = Val(opquantity) + Val(grnquantity)
                '        If calquantity = 0 Then
                '            calrate = 0
                '        Else
                '            calrate = (Val(opamount) + Val(grnamount)) / Val(calquantity)
                '        End If
                '        ''''********************************* From Stockissuedetail *********************************'''
                '        sqlstring = "SELECT SUM(qty) AS QTY ,SUM(AMOUNT) AS AMOUNT FROM stockissuedetail WHERE Itemcode='" & Trim(.Text) & "' AND Void='N'"
                '        gconnection.getDataSet(sqlstring, "stockissuedetail")
                '        If gdataset.Tables("stockissuedetail").Rows.Count > 0 Then
                '            issuequantity = Format(Val(gdataset.Tables("stockissuedetail").Rows(0).Item("Qty") & ""), "0.000")
                '            issueamount = Format(Val(gdataset.Tables("stockissuedetail").Rows(0).Item("AMOUNT") & ""), "0.000")
                '        Else
                '            issuequantity = 0
                '            issueamount = 0
                '        End If
                '        ''' ********************************* To Find Out Closing Balance ***************************'''
                '        calquantity = (Val(opquantity) + Val(grnquantity) - Val(issuequantity))
                '        If calquantity = 0 Then
                '            calrate = 0
                '        Else
                '            calrate = (Val(opamount) + Val(grnamount) - Val(issueamount)) / (Val(calquantity))
                '        End If
                '        clsquantity = (Val(opquantity) + Val(grnquantity) - Val(issuequantity))
                '        '''******************************************
                '        '''****************************************** UPDATE Opening Stock ***************************************
                '        If Trim(cbo_Tostore.Text) = "BAR-1" Then
                '            ''Check stock of bar1
                '            strsql = "SELECT bar1clstock FROM openingstock WHERE itemcode='" & Trim(.Text) & "' "
                '            gconnection.getDataSet(strsql, "openingstock")
                '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
                '                .Col = 4
                '                If Val(gdataset.Tables("openingstock").Rows(0).Item("bar1clstock")) < Val(ssgrid.Text) Then
                '                    'MessageBox.Show("Specified quantity is not available" & vbCrLf & " , MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '                    MsgBox("Specified Quantity is not available")
                '                    .SetActiveCell(4, i)
                '                    .Text = ""
                '                    .Focus()
                '                    Exit Sub
                '                End If
                '            End If
                '            ''''''''''''''''''''''''''''
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 4
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                '            sqlstring = sqlstring & " mainclstock = mainclstock + " & Format(Val(.Text), "0.000") & " ,"
                '            sqlstring = sqlstring & " doublevalue = doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                '            sqlstring = sqlstring & " bar1clstock =  bar1clstock - " & Format(Val(.Text), "0.000") & " ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Tostore.Text) = "BAR-2" Then
                '            ''Check stock of bar2
                '            strsql = "SELECT bar2clstock FROM openingstock WHERE itemcode='" & Trim(.Text) & "' "
                '            gconnection.getDataSet(strsql, "openingstock")
                '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
                '                .Col = 4
                '                If Val(gdataset.Tables("openingstock").Rows(0).Item("bar2clstock")) < Val(ssgrid.Text) Then
                '                    'MessageBox.Show("Specified quantity is not available" & vbCrLf & " , MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '                    MsgBox("Specified Quantity is not available")
                '                    .SetActiveCell(4, i)
                '                    .Text = ""
                '                    .Focus()
                '                    Exit Sub
                '                End If
                '            End If
                '            ''''''''''''''''''''''''
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 4
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                '            sqlstring = sqlstring & " mainclstock = mainclstock + " & Format(Val(.Text), "0.000") & " "
                '            sqlstring = sqlstring & " doublevalue = doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                '            sqlstring = sqlstring & " bar2clstock =  bar2clstock - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Tostore.Text) = "BAR-3" Then
                '            ''Check stock of bar3
                '            strsql = "SELECT bar3clstock FROM openingstock WHERE itemcode='" & Trim(.Text) & "' "
                '            gconnection.getDataSet(strsql, "openingstock")
                '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
                '                .Col = 4
                '                If Val(gdataset.Tables("openingstock").Rows(0).Item("bar3clstock")) < Val(ssgrid.Text) Then
                '                    'MessageBox.Show("Specified quantity is not available" & vbCrLf & " , MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '                    MsgBox("Specified Quantity is not available")
                '                    .SetActiveCell(4, i)
                '                    .Text = ""
                '                    .Focus()
                '                    Exit Sub
                '                End If
                '            End If
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 4
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - (" & Format(Val(.Text), "0.000") & " * HIGHRATIO ),"
                '            sqlstring = sqlstring & " mainclstock = mainclstock + " & Format(Val(.Text), "0.000") & " ,"
                '            sqlstring = sqlstring & " doublevalue = doublevalue + (" & Format(Val(.Text), "0.000") & " * HIGHRATIO) ,"
                '            sqlstring = sqlstring & " bar3clstock =  bar3clstock - " & Format(Val(.Text), "0.000") & " ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        End If
                '        '''****************************************** UPDATE COMPLETE ***************************************
                '    End With
                'Next i
                gconnection.MoreTrans(insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            'grp_Stockissue.Top = 176
            'grp_Stockissue.Left = 216
            'txt_FromDocno.Focus()

            'grp_Stockissue.Top = 176
            'grp_Stockissue.Left = 216
            'txt_FromDocno.Focus()
            gPrint = False
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            'If Trim(txt_FromDocno.Text) = "" Then
            '    MessageBox.Show("From doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    Exit Sub
            'End If
            'If Trim(txt_ToDocno.Text) = "" Then
            '    MessageBox.Show("To doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    Exit Sub
            'End If
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount , dbo.stockissueheader.indentno ,  dbo.stockissueheader.indentdate,dbo.stockissueheader.remarks,dbo.stockissueheader.UPDFOOTER,dbo.stockissueheader.UPDSIGN"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails = '" & Trim(txt_Docno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            Dim arraystring() As String = {"SLNO", "ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE"}
            Dim colsize() As Integer = {5, 15, 40, 16, 10, 12, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillStore()
        Try
            Dim i As Integer
            sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER WHERE  ISNULL(STORESTATUS,'') = 'S' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            cbo_Tostore.Items.Clear()
            cbo_Tostore.Sorted = True
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                    cbo_Tostore.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub autogenerate()
        Try
            Dim sqlstring, financalyear As String
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            docno = doctype
            sqlstring = "SELECT MAX(SUBSTRING(docno,1,5)) FROM stockissueheader WHERE doctype='" & docno & "'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_Docno.Text = docno & "/00001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_Docno.Text = docno & "/" & Format(gdreader(0) + 1, "00000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_Docno.Text = docno & "/00001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Tostore.SelectedIndexChanged
        '''******************************* Show Store Code ****************************************'''
        Try
            Dim i As Integer
            If Cmd_Add.Text = "Add [F7]" Then
                sqlstring = "SELECT Storecode FROM StoreMaster Where Storedesc='" & Trim(cbo_Tostore.Text) & "'"
                gconnection.getDataSet(sqlstring, "StoreMaster")
                If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                    txt_Tostorecode.Text = Trim(gdataset.Tables("StoreMaster").Rows(i).Item("Storecode"))
                    txt_Tostorecode.ReadOnly = True
                End If
                '''******************************* End Store Code *****************************************'''
                doctype = Trim(txt_Tostorecode.Text)
                Call autogenerate()
            Else
                'If cbo_Tostore.Text <> VSTORENAME Then
                '    sqlstring = "SELECT Storecode FROM StoreMaster Where Storedesc='" & Trim(cbo_Tostore.SelectedItem) & "'"
                '    gconnection.getDataSet(sqlstring, "StoreMaster")
                '    If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                '        txt_Tostorecode.Text = Trim(gdataset.Tables("StoreMaster").Rows(i).Item("Storecode"))
                '        txt_Tostorecode.ReadOnly = True
                '    End If
                '    doctype = Trim(txt_Tostorecode.Text)
                '    Call autogenerate()
                'Else
                '    txt_Docno.Text = VSTRDOCNO
                '    txt_Tostorecode.Text = VSTORECODE
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GridUOM(ByVal i As Integer)
        Try
            Dim Z As Integer
            sqlstring = "SELECT ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER WHERE ISNULL(FREEZE,'') <> 'Y'"
            gconnection.getDataSet(sqlstring, "UOMMASTER1")
            If gdataset.Tables("UOMMASTER1").Rows.Count > 0 Then
                For Z = 0 To gdataset.Tables("UOMMASTER1").Rows.Count - 1
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                    ssgrid.Text = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                Next Z
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub checkValidation()
        Try
            Dim i, j As Integer
            Dim itemcode, strSqlString As String
            boolchk = False
            Call Checkdatevalidate(Format(dtp_Docdate.Value, "dd-MMM-yyyy"))
            If chkdatevalidate = False Then Exit Sub
            '''********** Check  Main Store Can't be blank *********************'''
            If Trim(txt_Mainstore.Text) = "" Then
                MessageBox.Show(" Main Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Mainstore.Focus()
                Exit Sub
            End If
            '''********** Check  To Store Can't be blank *********************'''
            If Trim(cbo_Tostore.Text) = "" Then
                MessageBox.Show(" To Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Tostore.Focus()
                Exit Sub
            End If
            '''********** Check  Doc No. Can't be blank *********************'''
            If Trim(txt_Docno.Text) = "" Then
                MessageBox.Show(" Doc No. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Docno.Focus()
                Exit Sub
            End If
            '''********** Check  Totalamount Can't be blank *********************'''
            If Val(txt_Totalamount.Text) = 0 Then
                MessageBox.Show(" Totalamount can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Totalamount.Focus()
                Exit Sub
            End If
            ''' ********** Check ItemCode,ItemDesc,UOM,Rate can't be blank ***********'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("ItemCode can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(1, i)
                    Exit Sub
                End If
                ssgrid.Col = 2
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Itemdesc can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(2, i)
                    Exit Sub
                End If
                ssgrid.Col = 3
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(3, i)
                    Exit Sub
                End If
                ssgrid.Col = 4
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(4, i)
                    Exit Sub
                End If
                ssgrid.Col = 5
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(5, i)
                    Exit Sub
                End If
                ssgrid.Col = 6
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(6, i)
                    Exit Sub
                End If
                'ssgrid.Col = 7
                'If Val(ssgrid.Text) = 0 Then
                '    MessageBox.Show("dblamount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(7, i)
                '    Exit Sub
                'End If
                'ssgrid.Col = 8
                'If Trim(ssgrid.Text) = "" Then
                '    MessageBox.Show("Dblconv can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(8, i)
                '    Exit Sub
                'End If
                'ssgrid.Col = 9
                'If Val(ssgrid.Text) = 0 Then
                '    MessageBox.Show("High Ratio can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(9, i)
                '    Exit Sub
                'End If
                'ssgrid.Col = 10
                'If Trim(ssgrid.Text) = "" Then
                '    MessageBox.Show("Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(10, i)
                '    Exit Sub
                'End If
                'ssgrid.Col = 11
                'If Trim(ssgrid.Text) = "" Then
                '    MessageBox.Show("Sub Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(11, i)
                '    Exit Sub
                'End If
            Next i
            '''****************************************** Check if that specified quantity is avaliable or not *************************************************'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                itemcode = Trim(ssgrid.Text)
                Dim VCHKCURQTY, VCHKCLQTY As Double
                ssgrid.Col = 4
                VCHKCURQTY = ssgrid.Text
                'VCHKCLQTY = ClosingQuantity(Trim(itemcode), "MNS")
                VCHKCLQTY = ClosingQuantity(Trim(itemcode), Trim(txt_Mainstorecode.Text))
                'If Val(VCHKCURQTY) > Val(VCHKCLQTY) Then
                '    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(4, i)
                '    'ssgrid.Text = ""
                '    ssgrid.Focus()
                '    Exit Sub
                'End If
                '''******************************** First validation *******************************************'''
                'sqlstring = "SELECT mainclstock,doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
                'gconnection.getDataSet(sqlstring, "openingstock")
                'If gdataset.Tables("openingstock").Rows.Count > 0 Then
                '.Col = 4
                'VCHKCURQTY = .Text
                '.Col = 13
                'VCHKCLQTY = .Text

                'If Val(gdataset.Tables("openingstock").Rows(j).Item("mainclstock")) < Val(ssgrid.Text) Then
                '    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    .SetActiveCell(4, i)
                '    .Text = ""
                '    .Focus()
                '    Exit Sub
                'End If
                '.Col = 7
                'If Val(gdataset.Tables("openingstock").Rows(j).Item("doublevalue")) < Val(ssgrid.Text) Then
                '    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    .SetActiveCell(4, i)
                '    .Text = ""
                '    .Focus()
                '    Exit Sub
                'End If
                'End If
                '''******************************* Validation Complete *****************************************'''
                '''******************************** Second validation *******************************************'''
                'sqlstring = "SELECT minqty FROM inventoryitemmaster WHERE itemcode='" & itemcode & "'"
                'gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                'If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                '    .Col = 4
                '    If Val(gdataset.Tables("inventoryitemmaster").Rows(j).Item("minqty")) >= Val(.Text) Then
                '        MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '        .SetActiveCell(4, i)
                '        .Text = ""
                '        .Focus()
                '        Exit Sub
                '    End If
                'End If
                '''******************************* Validation Complete *****************************************'''
            Next i

            strSqlString = "SELECT ISNULL(GLOBALCLOSE,'') AS GLOBALCLOSE FROM MONTHCLOSE WHERE MONTHNO = MONTH('" & Format(dtp_Docdate.Value, "dd-MMM-yyyy") & "') "
            gconnection.getDataSet(strSqlString, "MONTHCLOSE")
            If gdataset.Tables("MONTHCLOSE").Rows.Count > 0 Then
                If Trim(gdataset.Tables("MONTHCLOSE").Rows(0).Item("GLOBALCLOSE")) = "Y" Then
                    MessageBox.Show("For This Month Transaction is Closed....", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            '''****************************************** Check if that specified quantity is completed *************************************************'''
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Issue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_Docno.Text = ""
                txt_Docno.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F10 Then
                Call cmd_Print_Click(cmd_Print, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If grp_Stockissue.Top = 176 Then
                    grp_Stockissue.Top = 1000
                    Cmd_View.Focus()
                    Exit Sub
                Else
                    Call Cmd_Exit_Click(Cmd_Exit, e)
                    Exit Sub
                End If
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.A Then
                Me.txt_Totalamount.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub FillMenu()
        Try
            Dim Avgrate, clsquantity As Double
            Dim K As Integer
            Dim vform As New List_Operation
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT   ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
            If Trim(vsearch) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | CLSTOCK   | CLVALUE   | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 4
            vform.Keypos3 = 5
            vform.keypos4 = 6
            vform.Keypos5 = 7
            vform.Keypos6 = 8
            vform.Keypos7 = 9
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
               
                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeComboBox
                ssgrid.TypeComboBoxString = vform.keyfield2
                ssgrid.Text = Trim(vform.keyfield2)
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow
                'Avgrate = CalAverageRate(Trim(vform.keyfield))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, txt_Mainstorecode.Text)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, txt_Mainstorecode.Text)
                End If
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield4)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                'clsquantity = ClosingQuantity(Trim(vform.keyfield), "MNS")
                clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_Mainstorecode.Text))
                lbl_closingqty.Text = UCase(Trim(vform.keyfield1)) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenuItem()
        Try
            Dim Avgrate, clsquantity As Double
            Dim K As Integer
            Dim vform As New List_Operation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,'') AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
            If Trim(vsearch) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMNAME like '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "             ITEMNAME               |  ITEMCODE    | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.Keypos3 = 3
            vform.keypos4 = 4
            vform.Keypos5 = 5
            vform.Keypos6 = 6
            vform.Keypos7 = 7
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
              
                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeComboBox
                ssgrid.TypeComboBoxString = vform.keyfield2
                ssgrid.Text = Trim(vform.keyfield2)
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow
                'Avgrate = CalAverageRate(Trim(vform.keyfield))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, txt_Mainstorecode.Text)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, txt_Mainstorecode.Text)
                End If
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield4)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                'clsquantity = ClosingQuantity(Trim(vform.keyfield1), "MNS")
                clsquantity = ClosingQuantity(Trim(vform.keyfield1), Trim(txt_Mainstorecode.Text))
                lbl_closingqty.Text = UCase(Trim(vform.keyfield)) & "CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_Totalamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Totalamount.LostFocus
        Try
            txt_Totalamount.Text = Format(Val(txt_Totalamount.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMainstore()
        Try
            Dim i As Integer
            sqlstring = "SELECT ISNULL(STOREDESC,'') AS STOREDESC,ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE ISNULL(STORESTATUS,'') ='M' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "StoreMaster1")
            If gdataset.Tables("StoreMaster1").Rows.Count > 0 Then
                txt_Mainstore.Text = Trim(gdataset.Tables("StoreMaster1").Rows(i).Item("STOREDESC"))
                txt_Mainstorecode.Text = Trim(gdataset.Tables("StoreMaster1").Rows(i).Item("STORECODE"))
                txt_Mainstore.ReadOnly = True
                txt_Mainstorecode.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Tostore.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                dtp_Docdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Docdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Docdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                ssgrid.Focus()
                ssgrid.SetActiveCell(1, 1)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                txt_Remarks.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Remarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, clsquantiy, Varqty As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
                lbl_closingqty.Text = ""
                i = ssgrid.ActiveRow
                ssgrid.Col = 4
                ssgrid.Row = i
                ValQty = Val(ssgrid.Text)
                ssgrid.Col = 5
                ssgrid.Row = i
                ValRate = Val(ssgrid.Text)
                ssgrid.Col = 9
                ssgrid.Row = i
                ValHighratio = Val(ssgrid.Text())
                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
                ValDblamount = Format(Val(ValQty) * Val(ValHighratio), "0.000")
                If Val(ValItemamount) = 0 Then
                    ssgrid.SetText(6, i, "")
                    ssgrid.SetText(7, i, "")
                Else
                    ssgrid.SetText(6, i, Val(ValItemamount))
                    ssgrid.SetText(7, i, Val(ValDblamount))
                End If
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                Itemcode = Trim(ssgrid.Text)
                For j = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 1
                    ssgrid.Row = j
                    If Trim(Itemcode) = Trim(ssgrid.Text) Then
                        ssgrid.Col = 4
                        ssgrid.Row = j
                        Calqty = Calqty + Val(ssgrid.Text)
                    End If
                Next
                'clsquantiy = ClosingQuantity(Trim(Itemcode), "MNS")
                clsquantiy = ClosingQuantity(Trim(Itemcode), Trim(txt_Mainstorecode.Text))
                ssgrid.Col = 2
                ssgrid.Row = i
                lbl_closingqty.Text = UCase(Trim(ssgrid.Text)) & " CLOSING QTY : " & Format(Val(clsquantiy - Calqty), "0.000")
                Me.txt_Totalamount.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1


                Me.Txt_qty.Text = 0
                Varqty = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    Varqty = Val(ssgrid.Text)
                    Me.Txt_qty.Text = Format(Val(Me.Txt_qty.Text) + Val(Varqty), "0.00")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Docno.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        If Trim(txt_Docno.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME,ISNULL(H.UPDFOOTER,'') AS UPDFOOTER,ISNULL(H.UPDSIGN,'') AS UPDSIGN"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER AS H WHERE DOCNO='" & Trim(txt_Docno.Text) & "'OR DOCDETAILS='" & Trim(txt_Docno.Text) & "' "
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_Docno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    Txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    dtp_IndentDate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    txt_Tostorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    VSTORECODE = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    VSTORENAME = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("TOTALAMT")), "0.00")
                    txt_Remarks.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    Txt_footer.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDFOOTER"))
                    Txt_signature.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDSIGN"))
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        Cmd_Add.Enabled = False
                        Cmd_Freeze.Enabled = False
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(DBLAMT,0) AS DBLAMT,ISNULL(DBLCONV,'') AS DBLCONV,ISNULL(HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE FROM STOCKISSUEDETAIL WHERE  DOCDETAILS ='" & Trim(txt_Docno.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAILSALL")
                    If gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                            Call GridUOM(i) '''---> FILL GRID UOM
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            ssgrid.SetText(8, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLCONV")))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(11, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("SUBGROUPCODE")))
                            'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                            Clsquantity = ClosingQuantity(STRITEMCODE, Trim(txt_Mainstorecode.Text))
                            ssgrid.SetText(13, i, Clsquantity)


                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
        'If cbo_Tostore.Text = "BAR-1" Then
        '    strsql = "SELECT BAR1CLSTOCK FROM OPENINGSTOCK WHERE ITEMCODE='" & STRITEMCODE & "' "
        '    gconnection.getDataSet(strsql, "OPENINGSTOCK")
        '    If gdataset.Tables("stockissuedetail").Rows.Count > 0 Then
        '        'MsgBox((gdataset.Tables("OPENINGSTOCK").Rows(0).Item("BAR1CLSTOCK")))
        '        .SetText(13, i, (gdataset.Tables("OPENINGSTOCK").Rows(0).Item("BAR1CLSTOCK")) & "")
        '    End If
        'ElseIf cbo_Tostore.Text = "BAR-2" Then
        '    strsql = "SELECT BAR2CLSTOCK FROM OPENINGSTOCK WHERE ITEMCODE='" & STRITEMCODE & "' "
        '    gconnection.getDataSet(strsql, "OPENINGSTOCK")
        '    If gdataset.Tables("stockissuedetail").Rows.Count > 0 Then
        '        .SetText(13, i, (gdataset.Tables("OPENINGSTOCK").Rows(0).Item("BAR2CLSTOCK")) & "")
        '    End If
        'ElseIf cbo_Tostore.Text = "BAR-3" Then
        '    strsql = "SELECT BAR3CLSTOCK FROM OPENINGSTOCK WHERE ITEMCODE='" & STRITEMCODE & "' "
        '    gconnection.getDataSet(strsql, "OPENINGSTOCK")
        '    If gdataset.Tables("stockissuedetail").Rows.Count > 0 Then
        '        .SetText(13, i, (gdataset.Tables("OPENINGSTOCK").Rows(0).Item("BAR3CLSTOCK")) & "")
        '    End If
        'End If
    End Sub

    Private Sub Cmd_Docnohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Docnohelp.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM stockissueheader"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK ISSUE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_Docno.Text = Trim(vform.keyfield & "")
                Call txt_Docno_Validated(txt_Docno, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_Docno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Docno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_Docnohelp.Enabled = True Then
                    search = Trim(txt_Docno.Text)
                    Call Cmd_Docnohelp_Click(Cmd_Docnohelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Docno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_Docno.Text) = "" Then
                    Call Cmd_Docnohelp_Click(Cmd_Docnohelp, e)
                Else
                    txt_Docno_Validated(txt_Docno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub Cmd_IssueClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_IssueClear.Click
        Try
            txt_FromDocno.Text = ""
            txt_ToDocno.Text = ""
            txt_FromDocno.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_IssueView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_IssueView.Click
        Try
            gPrint = False
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            If Trim(txt_FromDocno.Text) = "" Then
                MessageBox.Show("From doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Trim(txt_ToDocno.Text) = "" Then
                MessageBox.Show("To doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE TO BAR"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Issueexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Issueexit.Click
        Try
            txt_FromDocno.Text = ""
            txt_ToDocno.Text = ""
            grp_Stockissue.Top = 1000
            'Call Cmd_Clear_Click(Cmd_Clear, e)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromDocno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_FromDocno.Text) = "" Then
                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
                Else
                    txt_FromDocno_Validated(txt_FromDocno, e)
                    txt_ToDocno.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ToDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToDocno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_ToDocno.Text) = "" Then
                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
                Else
                    txt_ToDocno_Validated(txt_ToDocno, e)
                    Cmd_IssueView.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM stockissueheader"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK ISSUE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_FromDocno.Text = Trim(vform.keyfield & "")
                txt_ToDocno.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_ToDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToDocno.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM stockissueheader"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK ISSUE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_ToDocno.Text = Trim(vform.keyfield & "")
                Cmd_IssueView.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    'Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
    '    Try
    '        sqlstring = "SELECT ISNULL(totalamt,0) AS totalamt,ISNULL(totalqty,0) AS totalqty,* FROM stockissueheader WHERE docno='" & Trim(txt_FromDocno.Text) & "'OR docdetails='" & Trim(txt_FromDocno.Text) & "'"
    '        gconnection.getDataSet(sqlstring, "stockissueheader")
    '        '''************************************************* SELECT record from Grn_header *********************************************''''                
    '        If gdataset.Tables("stockissueheader").Rows.Count > 0 Then
    '            Me.txt_FromDocno.ReadOnly = True
    '            txt_FromDocno.Text = Trim(gdataset.Tables("stockissueheader").Rows(0).Item("docdetails") & "")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
    '    Try
    '        sqlstring = "SELECT ISNULL(totalamt,0) AS totalamt,ISNULL(totalqty,0) AS totalqty,* FROM stockissueheader WHERE docno='" & Trim(txt_ToDocno.Text) & "'OR docdetails='" & Trim(txt_ToDocno.Text) & "'"
    '        gconnection.getDataSet(sqlstring, "stockissueheader")
    '        '''************************************************* SELECT record from Grn_header *********************************************''''                
    '        If gdataset.Tables("stockissueheader").Rows.Count > 0 Then
    '            Me.txt_ToDocno.ReadOnly = True
    '            txt_ToDocno.Text = Trim(gdataset.Tables("stockissueheader").Rows(0).Item("docdetails") & "")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub Cmd_Issueprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Issueprint.Click
        Try
            gPrint = True
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            If Trim(txt_FromDocno.Text) = "" Then
                MessageBox.Show("From doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Trim(txt_ToDocno.Text) = "" Then
                MessageBox.Show("To doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE TO BAR"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim Issuerate, Highratio, Dblamount, clsquantity As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j, K As Integer
        search = Nothing
        ssgrid.Lock = False
        Try
            If e.keyCode = Keys.Enter Then

                i = ssgrid.ActiveRow
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                        Else
                            Itemcode = Trim(ssgrid.Text)
                            ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                            '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                            sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
                            sqlstring = sqlstring & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I"
                            sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                            If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                'For K = 1 To ssgrid.DataRowCnt
                                '    ssgrid.Row = K
                                '    ssgrid.Col = 1
                                '    If Itemvalidate(ssgrid, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), 1) = True Then
                                '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                                '        ssgrid.Focus()
                                '        Exit Sub
                                '    End If
                                'Next
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                                ssgrid.Col = 3
                                ssgrid.Row = i
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                'Issuerate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                                    Issuerate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_Mainstorecode.Text)
                                Else
                                    Issuerate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_Mainstorecode.Text)
                                End If
                                ssgrid.SetText(5, i, Format(Val(Issuerate), "0.00"))
                                ssgrid.SetText(8, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(9, i, Val(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(11, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("SUBGROUPCODE")))
                                'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), "MNS")
                                clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), Trim(txt_Mainstorecode.Text))
                                ssgrid.SetText(13, i, Format(clsquantity, "0.000"))

                                lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                                Call WHITE(ssgrid.ActiveCol, ssgrid.ActiveRow)
                                Call gold(ssgrid.ActiveCol + 1, ssgrid.ActiveRow)
                                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                                ssgrid.Focus()
                            Else
                                MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    Else
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    ssgrid.Col = 2
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                        Else
                            Itemdesc = Trim(ssgrid.Text)
                            ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                            '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                            sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
                            sqlstring = sqlstring & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                            If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                'For K = 1 To ssgrid.DataRowCnt
                                '    ssgrid.Row = K
                                '    ssgrid.Col = 1
                                '    If Itemvalidate(ssgrid, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), 1) = True Then
                                '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                '        ssgrid.Focus()
                                '        Exit Sub
                                '    End If
                                'Next
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                                ssgrid.Col = 3
                                ssgrid.Row = i
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                'Issuerate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                                    Issuerate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_Mainstorecode.Text)
                                Else
                                    Issuerate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_Mainstorecode.Text)
                                End If
                                ssgrid.SetText(5, i, Format(Val(Issuerate), "0.00"))
                                ssgrid.SetText(8, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(9, i, Val(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(11, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("SUBGROUPCODE")))
                                'clsquantity = ClosingQuantity(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))), "MNS")
                                clsquantity = ClosingQuantity(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))), Trim(txt_Mainstorecode.Text))
                                lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                            Else
                                MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 3 Then
                    ssgrid.Col = 3
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 4 Then
                    ssgrid.Col = 4
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Val(ssgrid.Text) = 0 Then
                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                        Else
                            Call Calculate() '''--> Calculate total amount
                            ssgrid.Row = ssgrid.ActiveRow + 1
                            ssgrid.Col = 1
                            ssgrid.Lock = False
                            ssgrid.Col = 2
                            ssgrid.Lock = False
                            ssgrid.Col = 3
                            ssgrid.Lock = False
                            ssgrid.Col = 4
                            ssgrid.Lock = False
                            ssgrid.Col = 5
                            ssgrid.Lock = False
                            ssgrid.Col = 6
                            ssgrid.Lock = False
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    Else
                        ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                    End If
                ElseIf ssgrid.ActiveCol = 5 Then
                    ssgrid.Col = 5
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Val(ssgrid.Text) = 0 Then
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                        Else
                            Call Calculate() '''--> Calculate total amount
                            ssgrid.Row = ssgrid.ActiveRow + 1
                            ssgrid.Col = 1
                            ssgrid.Lock = False
                            ssgrid.Col = 2
                            ssgrid.Lock = False
                            ssgrid.Col = 3
                            ssgrid.Lock = False
                            ssgrid.Col = 4
                            ssgrid.Lock = False
                            ssgrid.Col = 5
                            ssgrid.Lock = False
                            ssgrid.Col = 6
                            ssgrid.Lock = False
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 6 Then
                    ssgrid.Col = 6
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Val(ssgrid.Text) = 0 Then
                            ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    Else
                        ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    End If
                ElseIf ssgrid.ActiveCol = 7 Then
                    ssgrid.Col = 7
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 8 Then
                    ssgrid.Col = 8
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 9 Then
                    ssgrid.Col = 9
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                End If
            ElseIf e.keyCode = Keys.F4 Then
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 1
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call FillMenu()
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    ssgrid.Col = 2
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 2
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call FillMenuItem()
                    End If
                End If
            ElseIf e.keyCode = Keys.F3 Then
                ssgrid.Col = ssgrid.ActiveCol
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                If ssgrid.Lock = False Then
                    With ssgrid
                        .Row = .ActiveRow
                        .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
                        .DeleteRows(.ActiveRow, 1)
                        Call Calculate()
                        .SetActiveCell(1, ssgrid.ActiveRow)
                        .Focus()
                    End With
                End If
            ElseIf ssgrid.ActiveCol = 4 Then
                i = ssgrid.ActiveRow
                With ssgrid
                    .Row = .ActiveRow
                    .Col = 4
                    .Lock = False
                    .EditModePermanent = True
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function WHITE(ByVal ColNum As Integer, ByVal Rownum As Integer)
        ssgrid.Col = ssgrid.ActiveCol
        ssgrid.Row = ssgrid.ActiveRow
        ssgrid.BackColor = Color.White
    End Function
    Private Function gold(ByVal ColNum As Integer, ByVal Rownum As Integer)
        ssgrid.Col = ssgrid.ActiveCol
        ssgrid.Row = ssgrid.ActiveRow
        ssgrid.BackColor = Color.Gold
    End Function
    'Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
    '    Dim Issuerate, Highratio, Dblamount, clsquantity As Double
    '    Dim ItemQty, ItemAmount, ItemRate As Double
    '    Dim sqlstring, Itemcode, Itemdesc As String
    '    Dim focusbool As Boolean
    '    Dim i, j, K As Integer
    '    search = Nothing
    '    If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Then
    '        Call Calculate()
    '    End If
    '    Try
    '        i = ssgrid.ActiveRow
    '        If ssgrid.ActiveCol = 4 Then
    '            ssgrid.Col = 4
    '            i = ssgrid.ActiveRow
    '            ssgrid.Row = i
    '            If ssgrid.Lock = False Then
    '                If Val(ssgrid.Text) = 0 Then
    '                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                Else
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.Row = ssgrid.ActiveRow + 1
    '                    ssgrid.Col = 1
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 2
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 3
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 4
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 5
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 6
    '                    ssgrid.Lock = False
    '                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                End If
    '            End If
    '        ElseIf ssgrid.ActiveCol = 5 Then
    '            ssgrid.Col = 5
    '            i = ssgrid.ActiveRow
    '            ssgrid.Row = i
    '            If ssgrid.Lock = False Then
    '                If Val(ssgrid.Text) = 0 Then
    '                    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                Else
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.Row = ssgrid.ActiveRow + 1
    '                    ssgrid.Col = 1
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 2
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 3
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 4
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 5
    '                    ssgrid.Lock = False
    '                    ssgrid.Col = 6
    '                    ssgrid.Lock = False
    '                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        Exit Sub
    '    End Try

    'End Sub
    Private Sub GridLocking()
        Try
            Dim Row, Col As Integer
            ssgrid.Col = 6
            ssgrid.Row = ssgrid.ActiveRow
            For Row = 1 To 50
                For Col = 1 To 6
                    ssgrid.Row = Row
                    ssgrid.Col = Col
                    ssgrid.Lock = True
                Next
            Next
            ssgrid.Row = 1
            For Col = 1 To 6
                ssgrid.Col = Col
                ssgrid.Lock = False
            Next
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function GridUnlocking(ByVal ActiveCol, ByVal ActiveRow)
        Try
            Dim i As Integer = 1
            ssgrid.Row = ActiveRow
            ssgrid.Col = ActiveCol
            For i = ActiveCol To ssgrid.MaxCols
                ssgrid.Row = ActiveRow
                ssgrid.Col = i
                ssgrid.Lock = False
            Next i
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Sub GridUnLock()
        Try
            Dim i, j As Integer
            For i = 1 To 100
                For j = 1 To 6
                    ssgrid.Col = j
                    ssgrid.Row = i
                    ssgrid.Lock = False
                Next j
            Next i
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Issue_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            StockIssueTransbool = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromDocno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_FromDocno.Enabled = True Then
                    search = Trim(txt_FromDocno.Text)
                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
        If Trim(txt_FromDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(DOCDETAILS,'') AS DOCDETAILS"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER WHERE DOCDETAILS='" & Trim(txt_FromDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT record from Grn_header *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Me.txt_FromDocno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS"))
                    Me.txt_FromDocno.ReadOnly = True
                End If
            Catch
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_ToDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToDocno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_ToDocno.Enabled = True Then
                    search = Trim(txt_ToDocno.Text)
                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
        If Trim(txt_ToDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(DOCDETAILS,'') AS DOCDETAILS"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER WHERE DOCDETAILS='" & Trim(txt_ToDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT record from Grn_header *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Me.txt_ToDocno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS"))
                    Me.txt_ToDocno.ReadOnly = True
                End If
            Catch ex As Exception
                MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub GetRights()
        Try
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
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        Dim Issuerate, Highratio, Dblamount, clsquantity As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j, K As Integer
        search = Nothing
        If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Then
            Call Calculate()
        End If
        Try
            i = ssgrid.ActiveRow
            If ssgrid.ActiveCol = 4 Then
                ssgrid.Col = 4
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                If ssgrid.Lock = False Then
                    If Val(ssgrid.Text) = 0 Then
                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                    End If
                End If
            ElseIf ssgrid.ActiveCol = 5 Then
                ssgrid.Col = 5
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                If ssgrid.Lock = False Then
                    If Val(ssgrid.Text) = 0 Then
                        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                    Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        Try
            gPrint = True
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount ,  dbo.stockissueheader.indentno ,  dbo.stockissueheader.indentdate,dbo.stockissueheader.remarks,dbo.stockissueheader.updfooter,dbo.stockissueheader.updsign"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails = '" & Trim(txt_Docno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            ' Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim arraystring() As String = {"SLNO", "ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE"}
            'Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            Dim colsize() As Integer = {5, 15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' and storecode in (select distinct storecode from grn_header)"
        Dim vform As New List_Operation
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "             STORE CODE                   |                   STORE DESCRIPTION                             "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Mainstorecode.Text = Trim(vform.keyfield & "")
            txt_Mainstore.Text = Trim(vform.keyfield1 & "")
            cbo_Tostore.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Mainstorecode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Mainstorecode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Mainstorecode.Text) = "" Then
                Call cmd_storecode_Click(cmd_storecode, e)
            Else
                Call txt_Mainstorecode_Validated(sender, e)
                cbo_Tostore.Focus()
            End If
        End If
    End Sub

    Private Sub txt_Mainstorecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Mainstorecode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_storecode_Click(cmd_storecode, e)
        End If
    End Sub

    Private Sub txt_Mainstorecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Mainstorecode.Validated
        Try
            If Trim(txt_Mainstorecode.Text) <> "" Then
                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Mainstorecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "storemaster")
                If gdataset.Tables("storemaster").Rows.Count > 0 Then
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                    cbo_Tostore.Focus()
                End If
            End If
        Catch
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_IndentNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_IndentNoHelp.Click
        Try
            gSQLString = "SELECT indent_no,indent_date FROM inventory_indenthdr"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "INDENT_NO,INDENT_DATE"
            vform.vFormatstring = "       INDENT_NO            |         INDENT_DATE                             "
            vform.vCaption = "STOCK INDENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Txt_IndentNo.Text = Trim(vform.keyfield & "")
                Call Txt_IndentNo_Validated(Txt_IndentNo, e)
                dtp_IndentDate.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_IndentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.TextChanged

    End Sub

    Private Sub Txt_IndentNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.Validated
        Try
            Dim Clsquantity, TotAmount, Totqty As Double
            Dim i, j, k As Integer
            Dim SSQL, remark As String
            If Trim(Txt_IndentNo.Text) <> "" Then

                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER AS H WHERE INDENTNO='" & Trim(Txt_IndentNo.Text) & "'OR DOCDETAILS='" & Trim(Txt_IndentNo.Text) & "' "
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")

                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Call DOCNO_INDNO_VALIDATE()
                Else
                    sqlstring = " SELECT ISNULL(H.INDENT_NO,'') AS INDENT_NO,H.INDENT_DATE AS INDENT_DATE,ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
                    sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.PRODUCT_TYPE,'') AS PRODUCT_TYPE,"
                    sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(H.VOID,'') AS VOID,"
                    sqlstring = sqlstring & " ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATETIME,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME , ISNULL(H.FROMSTORECODE,'') FROMSTORECODE"
                    sqlstring = sqlstring & " FROM INVENTORY_INDENTHDR AS H "
                    sqlstring = sqlstring & " WHERE INDENT_NO='" & Txt_IndentNo.Text & "'"
                    gconnection.getDataSet(sqlstring, "INDENTHDR")
                    '''************************************************* SELECT RECORD FROM INDENTHDR *********************************************''''                
                    If gdataset.Tables("INDENTHDR").Rows.Count > 0 Then
                        'Cmd_Add.Text = "Update[F7]"
                        Me.Txt_IndentNo.ReadOnly = True
                        'txt_Docno.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_NO") & "")
                        dtp_IndentDate.Value = Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_DATE")), "dd-MM-yyyy")
                        dtp_Docdate.Value = Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_DATE")), "dd-MM-yyyy")
                        txt_Tostorecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONCODE"))
                        cbo_Tostore.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONNAME"))
                        txt_Mainstorecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("FROMSTORECODE"))
                        remark = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                        txt_Remarks.Text = Replace(remark, "?", "'")
                        Call txt_Mainstorecode_Validated(Txt_IndentNo.Text, e)
                        'cbo_type.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("PRODUCT_TYPE"))
                        'txt_Remarks.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                        If gdataset.Tables("INDENTHDR").Rows(0).Item("VOID") = "Y" Then
                            Me.lbl_Freeze.Visible = True
                            Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                            Me.Cmd_Freeze.Enabled = False
                        Else
                            Me.lbl_Freeze.Visible = False
                            Me.Cmd_Freeze.Enabled = True
                            Me.lbl_Freeze.Text = "Record Freezed  On "
                            Me.Cmd_Freeze.Text = "Void[F8]"
                        End If
                        If Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("VOID")) = "Y" Then
                            Cmd_Add.Enabled = False
                            Cmd_Freeze.Enabled = False
                        End If
                        '''************************************************* SELECT RECORD FROM INDENTDETAILS *********************************************''''                
                        Dim strsql As String
                        Dim STRITEMCODE As String
                        sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                        sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT "
                        sqlstring = sqlstring & " FROM INVENTORY_INDENTDET WHERE  INDENT_NO ='" & Trim(Txt_IndentNo.Text) & "' ORDER BY AUTOID"
                        gconnection.getDataSet(sqlstring, "INDENTDETAILS")
                        If gdataset.Tables("INDENTDETAILS").Rows.Count > 0 Then
                            TotAmount = 0
                            For i = 1 To gdataset.Tables("INDENTDETAILS").Rows.Count
                                Call GridUOM(i) '''---> FILL GRID UOM
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")))
                                STRITEMCODE = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE"))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMNAME")))
                                ssgrid.Col = 3
                                ssgrid.Row = i
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                                If ClosingQuantity_New(STRITEMCODE, txt_Mainstorecode.Text, dtp_Docdate.Value) < Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")) Then
                                    MsgBox("STOCK NOT AVAILABLE FOR " & STRITEMCODE, MsgBoxStyle.Critical, "INVENTORY")
                                    ssgrid.SetText(4, i, Val(ClosingQuantity(STRITEMCODE, txt_Mainstorecode.Text)))
                                Else
                                    ssgrid.SetText(4, i, Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")))
                                End If
                                ssgrid.SetText(12, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")), "0.000"))
                                ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("RATE")), "0.00"))

                                SSQL = " select groupcode, subgroupcode from inventoryitemmaster"
                                SSQL = SSQL & " where itemcode = '" & Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")) & "'"
                                ' SSQL = SSQL & " and storecode = '" & txt_Mainstorecode.Text & "'"
                                gconnection.getDataSet(SSQL, "storecode")
                                If gdataset.Tables("storecode").Rows.Count > 0 Then
                                    ssgrid.SetText(10, i, gdataset.Tables("storecode").Rows(0).Item("groupcode"))
                                    ssgrid.SetText(11, i, gdataset.Tables("storecode").Rows(0).Item("subgroupcode"))
                                End If

                                TotAmount = TotAmount + Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00")
                                ssgrid.SetText(6, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00"))

                                'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                                Clsquantity = ClosingQuantity_New(STRITEMCODE, Trim(txt_Mainstorecode.Text), dtp_Docdate.Value)
                                ssgrid.SetText(13, i, Clsquantity)
                                Totqty = Totqty + Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("qty")), "0.00")
                                j = j + 1
                            Next
                            txt_Totalamount.Text = TotAmount

                            Txt_qty.Text = Format(Totqty, "0.00")

                        End If
                        If gUserCategory <> "S" Then
                            Call GetRights()
                        End If
                        'TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                        ssgrid.SetActiveCell(1, 1)
                    Else
                        MsgBox("NOT A VAILD INDENT NO", MsgBoxStyle.Question)
                        Txt_IndentNo.Text = ""
                        Txt_IndentNo.Focus()
                    End If
                End If
            End If
            Call Grid_lock()
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_IndentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_IndentNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Txt_IndentNo.Text = "" Then
                Call cmd_IndentNoHelp_Click(Txt_IndentNo, e)
            Else
                Call Txt_IndentNo_Validated(Txt_IndentNo, e)
            End If
        End If
    End Sub
    Private Sub DOCNO_INDNO_VALIDATE()
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks As String
        Dim vTypeseqno, Clsquantity, vGroupseqno, Totqty As Double
        If Trim(Txt_IndentNo.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM STOCKISSUEHEADER AS H WHERE INDENTNO='" & Trim(Txt_IndentNo.Text) & "'OR DOCDETAILS='" & Trim(Txt_IndentNo.Text) & "' "
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_Docno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    Txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    dtp_IndentDate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    txt_Tostorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    VSTORECODE = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    VSTORENAME = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("TOTALAMT")), "0.00")
                    remarks = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        Cmd_Add.Enabled = False
                        Cmd_Freeze.Enabled = False
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(DBLAMT,0) AS DBLAMT,ISNULL(DBLCONV,'') AS DBLCONV,ISNULL(HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE FROM STOCKISSUEDETAIL WHERE  DOCDETAILS ='" & Trim(txt_Docno.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAILSALL")
                    If gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                            Call GridUOM(i) '''---> FILL GRID UOM
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            ssgrid.SetText(8, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLCONV")))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(11, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("SUBGROUPCODE")))
                            'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                            Clsquantity = ClosingQuantity(STRITEMCODE, Trim(txt_Mainstorecode.Text))
                            ssgrid.SetText(13, i, Clsquantity)
                            Totqty = Totqty + Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("qty")), "0.00")
                            j = j + 1
                        Next
                        Txt_qty.Text = Totqty
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Function Grid_lock()
        Dim i, j As Integer
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Row = i
            For j = 1 To ssgrid.MaxCols
                ssgrid.Col = j
                ssgrid.Lock = True
            Next
        Next
    End Function

    Private Sub txt_Tostorecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tostorecode.Validated
        Call cbo_Tostore_SelectedIndexChanged(txt_Tostorecode, e)
    End Sub

    Private Sub Txt_IndentNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.GotFocus
        Txt_IndentNo.BackColor = Color.Gold
    End Sub

    Private Sub Txt_IndentNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.LostFocus
        Txt_IndentNo.BackColor = Color.Wheat
    End Sub

    Private Sub ssgrid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.GotFocus
        'Dim X, Y, A, B As Integer

        'For X = 1 To ssgrid.DataRowCnt
        '    For Y = 1 To ssgrid.MaxCols
        '        ssgrid.BackColor = Color.White
        '    Next
        'Next

        'ssgrid.Col = ssgrid.ActiveCol
        'ssgrid.Row = ssgrid.ActiveRow
        'ssgrid.BackColor = Color.Gold
    End Sub

    Private Sub ssgrid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.LostFocus

    End Sub
    Private Sub Txt_qty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_qty.LostFocus
        Try
            Txt_qty.Text = Format(Val(Txt_qty.Text), "0.00")
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub
    Private Sub Txt_footer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_footer.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(Txt_footer.Text) <> "" Then
                Txt_signature.Focus()
            Else
                Txt_footer.Focus()
            End If
        End If
    End Sub
    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_item.CheckedChanged
        If Chk_item.Checked = True Then
            grp_footer.Visible = True
            Txt_footer.Focus()
        Else
            grp_footer.Visible = False
        End If
    End Sub
    Private Sub Txt_signature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_signature.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Chk_item.Focus()
        End If
    End Sub
    Public Function FOOTER()
        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM STOCKISSUEHEADER WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM STOCKISSUEHEADER )"
        gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
        If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
            Txt_footer.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDFOOTER"))
            Txt_signature.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPdsign"))
        End If
    End Function

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub
End Class
