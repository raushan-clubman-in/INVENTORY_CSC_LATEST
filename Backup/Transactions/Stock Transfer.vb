Imports System.Data.SqlClient
Public Class Stock_Transfer
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
    Friend WithEvents lbl_Tostore As System.Windows.Forms.Label
    Friend WithEvents lbl_Fromstore As System.Windows.Forms.Label
    Friend WithEvents dtp_Docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Challanno As System.Windows.Forms.Label
    Friend WithEvents lbl_Docdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Docno As System.Windows.Forms.Label
    Friend WithEvents grp_Stocktransfer2 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_Stocktransfer1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Challanno As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Docnohelp As System.Windows.Forms.Button
    Friend WithEvents cbo_Fromstore As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Tostore As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_Challandate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Challandate As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Tostorecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_fromstorecode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Totalamt As System.Windows.Forms.Label
    Friend WithEvents txt_Totalamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Totalqty As System.Windows.Forms.Label
    Friend WithEvents txt_Totalqty As System.Windows.Forms.TextBox
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grp_Stockissue As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Stockissuedetails As System.Windows.Forms.Label
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Issueprint As System.Windows.Forms.Button
    Friend WithEvents Cmd_IssueView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Issueexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_IssueClear As System.Windows.Forms.Button
    Friend WithEvents lbl_Help As System.Windows.Forms.Label
    Friend WithEvents lbl_closingqty As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Stock_Transfer))
        Me.txt_Docno = New System.Windows.Forms.TextBox
        Me.lbl_Totalamt = New System.Windows.Forms.Label
        Me.txt_Totalamt = New System.Windows.Forms.TextBox
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Tostore = New System.Windows.Forms.Label
        Me.lbl_Fromstore = New System.Windows.Forms.Label
        Me.dtp_Docdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Challanno = New System.Windows.Forms.Label
        Me.lbl_Docdate = New System.Windows.Forms.Label
        Me.lbl_Docno = New System.Windows.Forms.Label
        Me.grp_Stocktransfer2 = New System.Windows.Forms.GroupBox
        Me.grp_Stocktransfer1 = New System.Windows.Forms.GroupBox
        Me.txt_Challanno = New System.Windows.Forms.TextBox
        Me.cmd_Docnohelp = New System.Windows.Forms.Button
        Me.cbo_Fromstore = New System.Windows.Forms.ComboBox
        Me.cbo_Tostore = New System.Windows.Forms.ComboBox
        Me.lbl_Totalqty = New System.Windows.Forms.Label
        Me.txt_Totalqty = New System.Windows.Forms.TextBox
        Me.dtp_Challandate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Challandate = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.txt_fromstorecode = New System.Windows.Forms.TextBox
        Me.txt_Tostorecode = New System.Windows.Forms.TextBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.grp_Stockissue = New System.Windows.Forms.GroupBox
        Me.lbl_Stockissuedetails = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Issueprint = New System.Windows.Forms.Button
        Me.Cmd_IssueView = New System.Windows.Forms.Button
        Me.Cmd_Issueexit = New System.Windows.Forms.Button
        Me.Cmd_IssueClear = New System.Windows.Forms.Button
        Me.txt_FromDocno = New System.Windows.Forms.TextBox
        Me.Cmd_FromDocno = New System.Windows.Forms.Button
        Me.lbl_FromDocno = New System.Windows.Forms.Label
        Me.txt_ToDocno = New System.Windows.Forms.TextBox
        Me.Cmd_ToDocno = New System.Windows.Forms.Button
        Me.lbl_ToDocno = New System.Windows.Forms.Label
        Me.lbl_Help = New System.Windows.Forms.Label
        Me.lbl_closingqty = New System.Windows.Forms.Label
        Me.frmbut.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Stockissue.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Docno
        '
        Me.txt_Docno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Docno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Docno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Docno.Location = New System.Drawing.Point(728, 96)
        Me.txt_Docno.MaxLength = 15
        Me.txt_Docno.Name = "txt_Docno"
        Me.txt_Docno.Size = New System.Drawing.Size(160, 26)
        Me.txt_Docno.TabIndex = 3
        Me.txt_Docno.Text = ""
        '
        'lbl_Totalamt
        '
        Me.lbl_Totalamt.AutoSize = True
        Me.lbl_Totalamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalamt.Location = New System.Drawing.Point(872, 520)
        Me.lbl_Totalamt.Name = "lbl_Totalamt"
        Me.lbl_Totalamt.Size = New System.Drawing.Size(90, 18)
        Me.lbl_Totalamt.TabIndex = 27
        Me.lbl_Totalamt.Text = "TOTAL AMT :"
        Me.lbl_Totalamt.Visible = False
        '
        'txt_Totalamt
        '
        Me.txt_Totalamt.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamt.Location = New System.Drawing.Point(872, 480)
        Me.txt_Totalamt.MaxLength = 15
        Me.txt_Totalamt.Name = "txt_Totalamt"
        Me.txt_Totalamt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamt.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamt.TabIndex = 8
        Me.txt_Totalamt.Text = ""
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(104, 520)
        Me.txt_Remarks.MaxLength = 100
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(456, 48)
        Me.txt_Remarks.TabIndex = 7
        Me.txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(16, 520)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(81, 18)
        Me.lbl_Remarks.TabIndex = 26
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Tostore
        '
        Me.lbl_Tostore.AutoSize = True
        Me.lbl_Tostore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tostore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tostore.Location = New System.Drawing.Point(168, 136)
        Me.lbl_Tostore.Name = "lbl_Tostore"
        Me.lbl_Tostore.Size = New System.Drawing.Size(83, 18)
        Me.lbl_Tostore.TabIndex = 18
        Me.lbl_Tostore.Text = "TO STORE :"
        '
        'lbl_Fromstore
        '
        Me.lbl_Fromstore.AutoSize = True
        Me.lbl_Fromstore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fromstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fromstore.Location = New System.Drawing.Point(144, 96)
        Me.lbl_Fromstore.Name = "lbl_Fromstore"
        Me.lbl_Fromstore.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Fromstore.TabIndex = 16
        Me.lbl_Fromstore.Text = "FROM STORE :"
        '
        'dtp_Docdate
        '
        Me.dtp_Docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Docdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Docdate.Location = New System.Drawing.Point(728, 136)
        Me.dtp_Docdate.Name = "dtp_Docdate"
        Me.dtp_Docdate.Size = New System.Drawing.Size(184, 26)
        Me.dtp_Docdate.TabIndex = 4
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(416, 24)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(234, 31)
        Me.lbl_Heading.TabIndex = 92
        Me.lbl_Heading.Text = "STOCK TRANSFER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Challanno
        '
        Me.lbl_Challanno.AutoSize = True
        Me.lbl_Challanno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Challanno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Challanno.Location = New System.Drawing.Point(144, 176)
        Me.lbl_Challanno.Name = "lbl_Challanno"
        Me.lbl_Challanno.Size = New System.Drawing.Size(101, 18)
        Me.lbl_Challanno.TabIndex = 20
        Me.lbl_Challanno.Text = "CHALLAN NO :"
        '
        'lbl_Docdate
        '
        Me.lbl_Docdate.AutoSize = True
        Me.lbl_Docdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docdate.Location = New System.Drawing.Point(600, 136)
        Me.lbl_Docdate.Name = "lbl_Docdate"
        Me.lbl_Docdate.Size = New System.Drawing.Size(84, 18)
        Me.lbl_Docdate.TabIndex = 24
        Me.lbl_Docdate.Text = "DOC DATE :"
        '
        'lbl_Docno
        '
        Me.lbl_Docno.AutoSize = True
        Me.lbl_Docno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docno.Location = New System.Drawing.Point(616, 96)
        Me.lbl_Docno.Name = "lbl_Docno"
        Me.lbl_Docno.Size = New System.Drawing.Size(68, 18)
        Me.lbl_Docno.TabIndex = 22
        Me.lbl_Docno.Text = "DOC NO :"
        '
        'grp_Stocktransfer2
        '
        Me.grp_Stocktransfer2.BackgroundImage = CType(resources.GetObject("grp_Stocktransfer2.BackgroundImage"), System.Drawing.Image)
        Me.grp_Stocktransfer2.Location = New System.Drawing.Point(552, 72)
        Me.grp_Stocktransfer2.Name = "grp_Stocktransfer2"
        Me.grp_Stocktransfer2.Size = New System.Drawing.Size(376, 144)
        Me.grp_Stocktransfer2.TabIndex = 21
        Me.grp_Stocktransfer2.TabStop = False
        '
        'grp_Stocktransfer1
        '
        Me.grp_Stocktransfer1.BackgroundImage = CType(resources.GetObject("grp_Stocktransfer1.BackgroundImage"), System.Drawing.Image)
        Me.grp_Stocktransfer1.Location = New System.Drawing.Point(136, 72)
        Me.grp_Stocktransfer1.Name = "grp_Stocktransfer1"
        Me.grp_Stocktransfer1.Size = New System.Drawing.Size(416, 144)
        Me.grp_Stocktransfer1.TabIndex = 15
        Me.grp_Stocktransfer1.TabStop = False
        '
        'txt_Challanno
        '
        Me.txt_Challanno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Challanno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Challanno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Challanno.Location = New System.Drawing.Point(280, 176)
        Me.txt_Challanno.MaxLength = 15
        Me.txt_Challanno.Name = "txt_Challanno"
        Me.txt_Challanno.Size = New System.Drawing.Size(176, 26)
        Me.txt_Challanno.TabIndex = 2
        Me.txt_Challanno.Text = ""
        '
        'cmd_Docnohelp
        '
        Me.cmd_Docnohelp.Image = CType(resources.GetObject("cmd_Docnohelp.Image"), System.Drawing.Image)
        Me.cmd_Docnohelp.Location = New System.Drawing.Point(888, 96)
        Me.cmd_Docnohelp.Name = "cmd_Docnohelp"
        Me.cmd_Docnohelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_Docnohelp.TabIndex = 23
        '
        'cbo_Fromstore
        '
        Me.cbo_Fromstore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Fromstore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Fromstore.Location = New System.Drawing.Point(280, 96)
        Me.cbo_Fromstore.Name = "cbo_Fromstore"
        Me.cbo_Fromstore.Size = New System.Drawing.Size(176, 27)
        Me.cbo_Fromstore.TabIndex = 0
        '
        'cbo_Tostore
        '
        Me.cbo_Tostore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tostore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tostore.Location = New System.Drawing.Point(280, 136)
        Me.cbo_Tostore.Name = "cbo_Tostore"
        Me.cbo_Tostore.Size = New System.Drawing.Size(176, 27)
        Me.cbo_Tostore.TabIndex = 1
        '
        'lbl_Totalqty
        '
        Me.lbl_Totalqty.AutoSize = True
        Me.lbl_Totalqty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalqty.Location = New System.Drawing.Point(696, 512)
        Me.lbl_Totalqty.Name = "lbl_Totalqty"
        Me.lbl_Totalqty.Size = New System.Drawing.Size(89, 18)
        Me.lbl_Totalqty.TabIndex = 28
        Me.lbl_Totalqty.Text = "TOTAL QTY :"
        Me.lbl_Totalqty.Visible = False
        '
        'txt_Totalqty
        '
        Me.txt_Totalqty.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalqty.Location = New System.Drawing.Point(696, 480)
        Me.txt_Totalqty.MaxLength = 15
        Me.txt_Totalqty.Name = "txt_Totalqty"
        Me.txt_Totalqty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalqty.Size = New System.Drawing.Size(96, 26)
        Me.txt_Totalqty.TabIndex = 9
        Me.txt_Totalqty.Text = ""
        '
        'dtp_Challandate
        '
        Me.dtp_Challandate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Challandate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Challandate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Challandate.Location = New System.Drawing.Point(728, 176)
        Me.dtp_Challandate.Name = "dtp_Challandate"
        Me.dtp_Challandate.Size = New System.Drawing.Size(184, 26)
        Me.dtp_Challandate.TabIndex = 5
        '
        'lbl_Challandate
        '
        Me.lbl_Challandate.AutoSize = True
        Me.lbl_Challandate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Challandate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Challandate.Location = New System.Drawing.Point(560, 176)
        Me.lbl_Challandate.Name = "lbl_Challandate"
        Me.lbl_Challandate.Size = New System.Drawing.Size(117, 18)
        Me.lbl_Challandate.TabIndex = 25
        Me.lbl_Challandate.Text = "CHALLAN DATE :"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(80, 600)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 10
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
        Me.Cmd_View.TabIndex = 13
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(368, 600)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 12
        Me.Cmd_Freeze.Text = "Void[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(224, 600)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 11
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(768, 600)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 14
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Location = New System.Drawing.Point(56, 584)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(848, 56)
        Me.frmbut.TabIndex = 30
        Me.frmbut.TabStop = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(584, 16)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 23
        Me.cmd_Print.Text = "Print[F10]"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(632, 544)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(147, 25)
        Me.lbl_Freeze.TabIndex = 29
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'txt_fromstorecode
        '
        Me.txt_fromstorecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fromstorecode.Location = New System.Drawing.Point(464, 96)
        Me.txt_fromstorecode.Name = "txt_fromstorecode"
        Me.txt_fromstorecode.Size = New System.Drawing.Size(80, 26)
        Me.txt_fromstorecode.TabIndex = 17
        Me.txt_fromstorecode.Text = ""
        '
        'txt_Tostorecode
        '
        Me.txt_Tostorecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tostorecode.Location = New System.Drawing.Point(464, 136)
        Me.txt_Tostorecode.Name = "txt_Tostorecode"
        Me.txt_Tostorecode.Size = New System.Drawing.Size(80, 26)
        Me.txt_Tostorecode.TabIndex = 19
        Me.txt_Tostorecode.Text = ""
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 224)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(976, 256)
        Me.ssgrid.TabIndex = 369
        '
        'grp_Stockissue
        '
        Me.grp_Stockissue.BackgroundImage = CType(resources.GetObject("grp_Stockissue.BackgroundImage"), System.Drawing.Image)
        Me.grp_Stockissue.Controls.Add(Me.lbl_Stockissuedetails)
        Me.grp_Stockissue.Controls.Add(Me.GroupBox2)
        Me.grp_Stockissue.Controls.Add(Me.txt_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.lbl_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.txt_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.lbl_ToDocno)
        Me.grp_Stockissue.Location = New System.Drawing.Point(231, 1000)
        Me.grp_Stockissue.Name = "grp_Stockissue"
        Me.grp_Stockissue.Size = New System.Drawing.Size(513, 230)
        Me.grp_Stockissue.TabIndex = 370
        Me.grp_Stockissue.TabStop = False
        '
        'lbl_Stockissuedetails
        '
        Me.lbl_Stockissuedetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Stockissuedetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockissuedetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Stockissuedetails.Location = New System.Drawing.Point(0, 10)
        Me.lbl_Stockissuedetails.Name = "lbl_Stockissuedetails"
        Me.lbl_Stockissuedetails.Size = New System.Drawing.Size(517, 24)
        Me.lbl_Stockissuedetails.TabIndex = 26
        Me.lbl_Stockissuedetails.Text = "TRANSFER CHECKLIST"
        Me.lbl_Stockissuedetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueprint)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueView)
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueexit)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueClear)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 168)
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
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(192, 64)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        Me.txt_FromDocno.Text = ""
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.Image = CType(resources.GetObject("Cmd_FromDocno.Image"), System.Drawing.Image)
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(400, 64)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(43, 64)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 22)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM DOC NO :"
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(192, 112)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        Me.txt_ToDocno.Text = ""
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.Image = CType(resources.GetObject("Cmd_ToDocno.Image"), System.Drawing.Image)
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(400, 111)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(72, 112)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(109, 22)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO DOC NO :"
        '
        'lbl_Help
        '
        Me.lbl_Help.AutoSize = True
        Me.lbl_Help.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Help.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Help.ForeColor = System.Drawing.Color.Red
        Me.lbl_Help.Location = New System.Drawing.Point(56, 648)
        Me.lbl_Help.Name = "lbl_Help"
        Me.lbl_Help.Size = New System.Drawing.Size(829, 21)
        Me.lbl_Help.TabIndex = 371
        Me.lbl_Help.Text = "Press F4 For Help Option/Press F3 for deleting particular row/Press F2 to focus o" & _
        "n DOCNO./Alt+R to focus on Remarks box"
        '
        'lbl_closingqty
        '
        Me.lbl_closingqty.AutoSize = True
        Me.lbl_closingqty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_closingqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_closingqty.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.lbl_closingqty.Location = New System.Drawing.Point(16, 488)
        Me.lbl_closingqty.Name = "lbl_closingqty"
        Me.lbl_closingqty.Size = New System.Drawing.Size(156, 25)
        Me.lbl_closingqty.TabIndex = 372
        Me.lbl_closingqty.Text = "CLOSING QTY :"
        Me.lbl_closingqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stock_Transfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(982, 699)
        Me.Controls.Add(Me.lbl_closingqty)
        Me.Controls.Add(Me.lbl_Help)
        Me.Controls.Add(Me.txt_fromstorecode)
        Me.Controls.Add(Me.txt_Tostorecode)
        Me.Controls.Add(Me.lbl_Challandate)
        Me.Controls.Add(Me.lbl_Totalqty)
        Me.Controls.Add(Me.txt_Totalqty)
        Me.Controls.Add(Me.txt_Challanno)
        Me.Controls.Add(Me.txt_Docno)
        Me.Controls.Add(Me.lbl_Totalamt)
        Me.Controls.Add(Me.txt_Totalamt)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_Tostore)
        Me.Controls.Add(Me.lbl_Fromstore)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Challanno)
        Me.Controls.Add(Me.lbl_Docdate)
        Me.Controls.Add(Me.lbl_Docno)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.grp_Stockissue)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.dtp_Challandate)
        Me.Controls.Add(Me.cbo_Tostore)
        Me.Controls.Add(Me.cmd_Docnohelp)
        Me.Controls.Add(Me.dtp_Docdate)
        Me.Controls.Add(Me.grp_Stocktransfer2)
        Me.Controls.Add(Me.cbo_Fromstore)
        Me.Controls.Add(Me.grp_Stocktransfer1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Stock_Transfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK TRANSFER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Stockissue.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim TotalCount As Integer
    Dim gconnection As New GlobalClass
    Dim sqlstring, financalyear As String
    Dim docno(), transferdocno, doctype1 As String
    Dim vsearch, vitem, accountcode As String
    Private Sub Stock_Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            doctype1 = ""
            StockTransferTransbool = True
            Me.dtp_Docdate.Value = Format(Now, "dd/MM/yyyy")
            Me.dtp_Challandate.Value = Format(Now, "dd/MM/yyyy")
            Call ToStoreLocation() '''--> Fill Store Desc
            Call FromStoreLocation() '''--> Fill Store Desc
            Call autogenerate() '''--> Fill DOC NO.
            Me.lbl_closingqty.Text = ""
            Me.grp_Stockissue.Top = 1000
            Me.txt_fromstorecode.ReadOnly = True
            Me.txt_Tostorecode.ReadOnly = True
            Me.lbl_Heading.Text = "STOCK TRANSFER"
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Me.ssgrid.SetActiveCell(1, 1)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            doctype1 = ""
            Call clearform(Me)
            Call ToStoreLocation()
            Call FromStoreLocation()
            Call autogenerate() '''--> Fill DOC NO.
            Me.dtp_Docdate.Value = Format(Now, "dd/MM/yyyy")
            Me.lbl_Freeze.Visible = False
            Me.grp_Stockissue.Top = 1000
            Me.lbl_Freeze.Text = "Record Void  On "
            Me.ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_Freeze.Text = "Void [F8]"
            Me.Cmd_Add.Text = "Add [F7]"
            Me.ssgrid.SetActiveCell(1, 1)
            Me.txt_Docno.Enabled = True
            Me.txt_Docno.ReadOnly = False
            Me.lbl_closingqty.Text = ""
            Me.lbl_Heading.Text = "STOCK TRANSFER"
            Me.txt_fromstorecode.ReadOnly = True
            Me.txt_Tostorecode.ReadOnly = True
            Me.cbo_Fromstore.Enabled = True
            Me.cbo_Tostore.Enabled = True
            Me.Cmd_Freeze.Enabled = True
            Me.Cmd_Add.Enabled = True
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Me.cbo_Fromstore.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim Totalamt, Totalqty, Avgrate, AvgQuantity As Double
            Dim Sqlstring, Insert(0), Doctype As String
            Dim i As Integer
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            Me.txt_Totalamt.Text = 0
            Me.txt_Totalqty.Text = 0
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 4
                Totalqty = Val(ssgrid.Text)
                Me.txt_Totalqty.Text = Format(Val(Me.txt_Totalqty.Text) + Val(Totalqty), "0.000")
                ssgrid.Col = 6
                Totalamt = Val(ssgrid.Text)
                Me.txt_Totalamt.Text = Format(Val(Me.txt_Totalamt.Text) + Val(Totalamt), "0.00")
            Next i
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            Sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(txt_Tostorecode.Text) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(Sqlstring, "STOREMASTER1")
            If gdataset.Tables("StoreMaster1").Rows.Count > 0 Then
                Doctype = ""
                If Trim(gdataset.Tables("StoreMaster1").Rows(0).Item("STORESTATUS")) = "M" Then
                    Doctype = "RET"
                Else
                    Doctype = "TRF"
                End If
            End If
            '''*****************************************************0****** CASE - 1 : ADD [F7] *******************************************'''
            '''******************************************************** $ INSERT INTO STOCKTRANSFERHEADER **********************************'''
            If Cmd_Add.Text = "Add [F7]" Then
                docno = Split(Trim(txt_Docno.Text), "/")
                transferdocno = Trim(txt_fromstorecode.Text) & "/" & Trim(txt_Tostorecode.Text) & "/" & docno(1) & "/" & financalyear
                Sqlstring = "INSERT INTO STOCKTRANSFERHEADER(Docno,Docdetails,Docdate,Doctype,Transferno,Fromstorecode,Fromstoredesc, "
                Sqlstring = Sqlstring & " Tostorecode, Tostoredesc,Challenno,Challendate, Totalamt,Remarks,Void,Adduser,Adddate,Updateuser,Updatetime)"
                Sqlstring = Sqlstring & " VALUES ('" & CStr(Trim(docno(1))) & "','" & CStr(Trim(txt_Docno.Text)) & "',"
                Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                Sqlstring = Sqlstring & " '" & Trim(Doctype) & "','" & Trim(transferdocno) & "',"
                Sqlstring = Sqlstring & " '" & Trim(txt_fromstorecode.Text) & "','" & Trim(cbo_Fromstore.Text) & "', "
                Sqlstring = Sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                Sqlstring = Sqlstring & " '" & Trim(txt_Challanno.Text) & "','" & Format(CDate(dtp_Challandate.Value), "dd-MMM-yyyy") & "',"
                Sqlstring = Sqlstring & " " & Format(Val(txt_Totalamt.Text), "0.00") & " ,"
                Sqlstring = Sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,"
                Sqlstring = Sqlstring & " 'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                Sqlstring = Sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                Insert(0) = Sqlstring
                '''******************************************************** $ INSERT INTO STOCKTRANSFERDETAILS **********************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    Sqlstring = "INSERT INTO STOCKTRANSFERDETAIL(Docno,Docdetails,Docdate,Doctype,Transferno,Fromstorecode,"
                    Sqlstring = Sqlstring & " Fromstoredesc,Tostorecode,Tostoredesc,Challenno,Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                    Sqlstring = Sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,Adddatetime,Updateuser,Updatetime)"
                    Sqlstring = Sqlstring & " VALUES ('" & CStr(Trim(docno(1))) & "','" & CStr(Trim(txt_Docno.Text)) & "',"
                    Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(Doctype) & "','" & Trim(transferdocno) & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_fromstorecode.Text) & "','" & Trim(cbo_Fromstore.Text) & "', "
                    Sqlstring = Sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_Challanno.Text) & "',"
                    ssgrid.Col = 1
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 2
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 9
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    Sqlstring = Sqlstring & " 'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    Sqlstring = Sqlstring & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstring
                    '''************************************************** UPDATE OPENING STOCK ********************'''
                    'If Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar1clstock = ((bar1doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar1clstock = ((bar1doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar2clstock = ((bar2doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar2clstock = ((bar2doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar3clstock = ((bar3doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 7
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(.Text), "0.000") & "  ,"
                    '    sqlstring = sqlstring & " bar3clstock = ((bar3doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'End If
                    ''''*********************************** UPDATE OPENING STOCK COMPLETE ********************'''
                Next i
                gconnection.MoreTrans(Insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
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
                        ''SendKeys.Send("{HOME}+{END}")
                        'Exit Sub
                    End If
                Next
                '''********************************************************** UPDATE stockissueheader *********************************************************'''
                Sqlstring = "UPDATE STOCKTRANSFERHEADER SET Docdate='" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "', "
                Sqlstring = Sqlstring & " Doctype='" & Trim(Doctype) & "',"
                Sqlstring = Sqlstring & " Fromstorecode='" & Trim(txt_fromstorecode.Text) & "',"
                Sqlstring = Sqlstring & " Fromstoredesc='" & Trim(cbo_Fromstore.Text) & "',"
                Sqlstring = Sqlstring & " Tostorecode='" & Trim(txt_Tostorecode.Text) & "',"
                Sqlstring = Sqlstring & " Tostoredesc='" & Trim(cbo_Tostore.Text) & "', "
                Sqlstring = Sqlstring & " Challenno='" & Trim(txt_Challanno.Text) & "',"
                Sqlstring = Sqlstring & " Challendate='" & Format(CDate(dtp_Challandate.Value), "dd-MMM-yyyy") & "', "
                Sqlstring = Sqlstring & " Totalamt=" & Format(Val(txt_Totalamt.Text), "0.00") & ","
                Sqlstring = Sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,"
                Sqlstring = Sqlstring & " Void='N',Updateuser='" & Trim(gUsername) & "',"
                Sqlstring = Sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "'"
                Sqlstring = Sqlstring & " WHERE Docdetails='" & Trim(txt_Docno.Text) & "' "
                Insert(0) = Sqlstring
                '''********************************************************* DELETE FROM stockissuedetail *****************************************************'''
                Sqlstring = "DELETE FROM STOCKTRANSFERDETAIL WHERE docdetails='" & Trim(txt_Docno.Text) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstring
                '''******************************************************** INSERT INTO stockissuedetail ******************************************************'''
                docno = Split(Trim(txt_Docno.Text), "/")
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    Sqlstring = "INSERT INTO STOCKTRANSFERDETAIL(Docno,Docdetails,Docdate,Doctype,Transferno,Fromstorecode,"
                    Sqlstring = Sqlstring & " Fromstoredesc,Tostorecode,Tostoredesc,Challenno,Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                    Sqlstring = Sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,Adddatetime,Updateuser,Updatetime)"
                    Sqlstring = Sqlstring & " VALUES ('" & CStr(Trim(docno(1))) & "','" & CStr(Trim(txt_Docno.Text)) & "',"
                    Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(Doctype) & "','" & Trim(transferdocno) & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_fromstorecode.Text) & "','" & Trim(cbo_Fromstore.Text) & "', "
                    Sqlstring = Sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_Challanno.Text) & "',"
                    ssgrid.Col = 1
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 2
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 9
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    Sqlstring = Sqlstring & " 'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstring
                    '''************************************************** UPDATE OPENING STOCK ********************'''
                    'If Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                    '    Sqlstring = "UPDATE OpeningStock SET "
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar1clstock = ((bar1doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar1clstock = ((bar1doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar2clstock = ((bar2doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar2clstock = ((bar2doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar3clstock = ((bar3doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                    '    ssgrid.Col = 7
                    '    Sqlstring = Sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(ssgrid.Text), "0.000") & "  ,"
                    '    Sqlstring = Sqlstring & " bar3clstock = ((bar3doublevalue - " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ","
                    '    Sqlstring = Sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(ssgrid.Text), "0.000") & ") / highratio) ,"
                    '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(AvgQuantity) * Val(Avgrate), "0.00") & ","
                    '    Sqlstring = Sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    ssgrid.Col = 1
                    '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(ssgrid.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = Sqlstring
                    'End If
                    '''*********************************** UPDATE OPENING STOCK COMPLETE ********************'''
                Next i
                gconnection.MoreTrans(Insert)
                Call Cmd_Clear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Dim i As Integer
            Dim insert(0) As String
            'Call checkValidation() ''-->Check Validation
            'If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Then
                '''***************************************** Void the DOCNO in stockissueheader **************************'''
                sqlstring = "UPDATE  STOCKTRANSFERHEADER "
                sqlstring = sqlstring & " SET Void= 'Y',"
                sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & " ',"
                sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                insert(0) = sqlstring
                '''***************************************** Void the DOCNO in Complete **********************************'''
                '''***************************************** Void the DOCNO in stockissuedetails **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "UPDATE  STOCKTRANSFERDETAIL "
                        sqlstring = sqlstring & " SET Void= 'Y',"
                        sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & " ',"
                        sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring
                    End With
                Next i
                ''''***************************************** Void the DOCNO is Complete **********************************'''
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
                '        '''****************************************** COMPLETE CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ****************'''
                '        sqlstring = "INSERT INTO stocktransferdetail(docno,docdetails,docdate,transferno,fromstorecode,"
                '        '''************************************************** UPDATE OPENING STOCK ********************'''
                '        If Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar1clstock = ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-1" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar1clstock = ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar2clstock = ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" And Trim(cbo_Tostore.Text) = "BAR-3" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar2clstock = ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-1" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar3clstock = ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" And Trim(cbo_Tostore.Text) = "BAR-2" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 7
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & "  ,"
                '            sqlstring = sqlstring & " bar3clstock = ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        End If
                '        '''*********************************** UPDATE OPENING STOCK COMPLETE ********************'''
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
            gPrint = False
            Dim i As Integer
            Dim objStockIssueClass As New rptStockTransferreport
            Dim sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE,ISNULL(H.FROMSTORECODE,'') AS FROMSTORECODE,"
            sqlstring = sqlstring & " ISNULL(H.FROMSTOREDESC,'') AS FROMSTOREDESC,ISNULL(H.TOSTORECODE,'') AS TOSTORECODE,ISNULL(H.TOSTOREDESC,'') AS TOSTOREDESC,"
            sqlstring = sqlstring & " ISNULL(H.CHALLENNO,'') AS CHALLENNO,H.CHALLENDATE AS CHALLENDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMNAME,'') AS ITEMNAME,"
            sqlstring = sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT"
            sqlstring = sqlstring & " FROM STOCKTRANSFERHEADER AS H INNER JOIN STOCKTRANSFERDETAIL AS D ON H.DOCDETAILS = D.DOCDETAILS"
            sqlstring = sqlstring & " WHERE H.DOCDETAILS ='" & Trim(txt_Docno.Text) & "'"
            sqlstring = sqlstring & " ORDER BY H.DOCDETAILS,H.DOCDATE"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
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
    Private Sub autogenerate()
        Dim Sqlstring, Financalyear As String
        Try
            Financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            Sqlstring = "SELECT MAX(Cast(SUBSTRING(DOCNO,1,6) As Numeric)) FROM STOCKTRANSFERHEADER WHERE doctype='" & Trim(doctype1) & "'"
            gconnection.openConnection()
            gcommand = New SqlCommand(Sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_Docno.Text = doctype1 & "/000001/" & Financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_Docno.Text = doctype1 & "/" & Format(gdreader(0) + 1, "000000") & "/" & Financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_Docno.Text = doctype1 & "/000001/" & Financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub

    Private Sub txt_Docno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Docno.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, STRITEMCODE, remarks As String
        Dim vTypeseqno, vGroupseqno, Clsquantity As Double
        Dim varqty As Double
        Me.txt_Totalqty.Text = 0
        varqty = 0
        If Trim(txt_Docno.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,ISNULL(H.TRANSFERNO,'') AS TRANSFERNO,"
                sqlstring = sqlstring & " ISNULL(H.FROMSTORECODE,'') AS FROMSTORECODE,ISNULL(H.FROMSTOREDESC,'') AS FROMSTOREDESC,ISNULL(H.TOSTORECODE,'') AS TOSTORECODE,"
                sqlstring = sqlstring & " ISNULL(H.TOSTOREDESC,'') AS TOSTOREDESC,ISNULL(H.CHALLENNO,'') AS CHALLENNO,H.CHALLENDATE,ISNULL(H.TOTALAMT,0) AS TOTALAMT,"
                sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS,ISNULL(H.VOID,'') AS VOID,ISNULL(ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(UPDATEUSER,'') AS UPDATEUSER,"
                sqlstring = sqlstring & " UPDATETIME FROM STOCKTRANSFERHEADER AS H WHERE DOCNO='" & Trim(txt_Docno.Text) & "'OR DOCDETAILS='" & Trim(txt_Docno.Text) & "'"
                gconnection.getDataSet(sqlstring, "stocktransferheader")
                '''************************************************* SELECT RECORD FROM STOCKTRANSFERHEADER *********************************************''''                
                If gdataset.Tables("stocktransferheader").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    txt_Docno.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("DOCDETAILS"))
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("stocktransferheader").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_fromstorecode.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("FROMSTORECODE"))
                    cbo_Fromstore.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_Fromstore.Enabled = False
                    cbo_Fromstore.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("FROMSTOREDESC"))
                    cbo_Fromstore.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Tostorecode.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("TOSTORECODE"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_Tostore.Enabled = False
                    cbo_Tostore.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("TOSTOREDESC"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Challanno.Text = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("CHALLENNO"))
                    dtp_Challandate.Value = Format(CDate(gdataset.Tables("stocktransferheader").Rows(0).Item("CHALLENDATE")), "dd-MM-yyyy")
                    txt_Totalamt.Text = Format(Val(gdataset.Tables("stocktransferheader").Rows(0).Item("TOTALAMT")), "0.00")
                    remarks = Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    ''''********************************* 
                    sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(txt_Tostorecode.Text) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
                    gconnection.getDataSet(sqlstring, "STOREMASTER1")
                    If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                        doctype1 = ""
                        If Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORESTATUS")) = "M" Then
                            doctype1 = "RET"
                            lbl_Heading.Text = "STOCK RETURN"
                        Else
                            doctype1 = "TRF"
                            lbl_Heading.Text = "STOCK TRANSFER"
                        End If
                    End If
                    If Trim(gdataset.Tables("stocktransferheader").Rows(0).Item("VOID") & "") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Void  On " & Format(CDate(gdataset.Tables("stocktransferheader").Rows(0).Item("adddate")), "dd-MMM-yyyy")
                        Me.Cmd_Add.Enabled = False
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Void  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKTRANSFERDETAISL *********************************************''''                
                    sqlstring = "SELECT ISNULL(D.DOCDETAILS,'') AS DOCDETAILS,D.DOCDATE AS DOCDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE, "
                    sqlstring = sqlstring & " ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,"
                    sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.DBLAMT,0) AS DBLAMT,ISNULL(D.DBLCONV,'') AS DBLCONV,ISNULL(D.HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(D.GROUPCODE,'') AS GROUPCODE,ISNULL(D.SUBGROUPCODE,'') AS SUBGROUPCODE"
                    sqlstring = sqlstring & " FROM STOCKTRANSFERDETAIL AS D WHERE  DOCDETAILS ='" & Trim(txt_Docno.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "stocktransferdetail")
                    If gdataset.Tables("stocktransferdetail").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("stocktransferdetail").Rows.Count
                            Call GridUOM(i) '''--> Fill UOM in ssgrid
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("DBLAMT")), "0.00"))
                            ssgrid.SetText(8, i, Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("DBLCONV")) & "")
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(11, i, Trim(gdataset.Tables("stocktransferdetail").Rows(j).Item("SUBGROUPCODE")))
                            Clsquantity = ClosingQuantity(STRITEMCODE, Trim(txt_fromstorecode.Text))
                            ssgrid.SetText(13, i, Clsquantity)
                          
                            varqty = varqty + Format(Val(gdataset.Tables("stocktransferdetail").Rows(j).Item("QTY")), "0.000")
                            j = j + 1
                        Next
                        Me.txt_Totalqty.Text = Format(varqty, "0.00")
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    TotalCount = gdataset.Tables("stocktransferdetail").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmd_Docnohelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_Docnohelp.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM stocktransferheader"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK TRANSFER HELP"
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
    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim Issuerate, Highratio, Dblamount As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j As Integer
        search = Nothing
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
                            sqlstring = " SELECT  DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
                            sqlstring = sqlstring & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
                            If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))

                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))

                                ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))

                                'Issuerate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Or UCase(SHORTNAME) = "CTC" Then
                                    Issuerate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_fromstorecode.Text)
                                Else
                                    Issuerate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_fromstorecode.Text)
                                End If
                                ssgrid.SetText(5, i, Format(Val(Issuerate), "0.00"))
                                ssgrid.SetText(8, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(9, i, Val(gdataset.Tables("inventoryitemMaster").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(11, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("SUBGROUPCODE")))
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
                            sqlstring = sqlstring & " ISNULL(CONVVALUE,'') AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "inventoryitemMaster")
                            If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
                                'Issuerate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Or UCase(SHORTNAME) = "CTC" Then
                                    Issuerate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_fromstorecode.Text)
                                Else
                                    Issuerate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, txt_fromstorecode.Text)
                                End If
                                ssgrid.SetText(5, i, Format(Val(Issuerate), "0.00"))
                                ssgrid.SetText(8, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(9, i, Val(gdataset.Tables("inventoryitemMaster").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(11, i, Trim(gdataset.Tables("inventoryitemMaster").Rows(j).Item("SUBGROUPCODE")))
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
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenu()
        Try
            Dim Avgrate, Clsquantity As Double
            Dim vform As New List_Operation
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,0 AS MAINCLSTOCK,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
            If Trim(vsearch) = " " Then
                M_WhereCondition = " "
            Else
                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "   ITEMCODE    |         ITEMNAME       | CLSTOCK   | CLVALUE    | MAINCLSTOCK | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 4
            vform.Keypos3 = 5
            vform.keypos4 = 6
            vform.Keypos5 = 7
            vform.Keypos6 = 8
            vform.Keypos7 = 9
            vform.Keypos8 = 10
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
                ssgrid.TypeComboBoxString = vform.keyfield3
                ssgrid.Text = Trim(vform.keyfield3)

                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow
                'Avgrate = CalAverageRate(Trim(vform.keyfield))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Or UCase(SHORTNAME) = "CTC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, txt_fromstorecode.Text)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, txt_fromstorecode.Text)
                End If
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield5)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield6), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield8)
                Clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_fromstorecode.Text))
                lbl_closingqty.Text = UCase(Trim(vform.keyfield1)) & " CLOSING QTY : " & Format(Val(Clsquantity), "0.000")
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
            Dim Avgrate, Clsquantity As Double
            Dim vform As New List_Operation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,0 AS MAINCLSTOCK,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,'') AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
            If Trim(vsearch) = " " Then
                M_WhereCondition = " I.STORECODE = '" & Trim(txt_fromstorecode.Text) & "' "
            Else
                M_WhereCondition = " WHERE I.STORECODE = '" & Trim(txt_fromstorecode.Text) & "' AND I.ITEMNAME like '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "             ITEMNAME               |  ITEMCODE   | MAINCLSTOCK | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.Keypos3 = 3
            vform.keypos4 = 4
            vform.Keypos5 = 5
            vform.Keypos6 = 6
            vform.Keypos7 = 7
            vform.Keypos8 = 8
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
                ssgrid.TypeComboBoxString = vform.keyfield3
                ssgrid.Text = Trim(vform.keyfield3)
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow
                'Avgrate = CalAverageRate(Trim(vform.keyfield))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Or UCase(SHORTNAME) = "CTC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, txt_fromstorecode.Text)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, txt_fromstorecode.Text)
                End If
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield5)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield6), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield8)
                Clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_fromstorecode.Text))
                lbl_closingqty.Text = UCase(Trim(vform.keyfield1)) & " CLOSING QTY : " & Format(Val(Clsquantity), "0.000")
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
    Private Sub FromStoreLocation()
        Try
            Dim i As Integer
            sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER WHERE  ISNULL(STORESTATUS,'') = 'S' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            cbo_Fromstore.Items.Clear()
            cbo_Fromstore.Sorted = True
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                    cbo_Fromstore.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ToStoreLocation()
        Try
            Dim i As Integer
            sqlstring = "SELECT ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER WHERE   ISNULL(FREEZE,'') <>'Y' ORDER BY STOREDESC ASC"
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

    Private Sub cbo_Fromstore_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Fromstore.SelectedIndexChanged
        Try
            If Cmd_Add.Text = "Add [F7]" Then
                Dim i As Integer
                '''******************************* Fill Corresponding Storecode *****************************************'''
                sqlstring = "SELECT Storecode FROM StoreMaster Where Storedesc='" & Trim(cbo_Fromstore.SelectedItem) & "'"
                gconnection.getDataSet(sqlstring, "StoreMaster")
                If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                    txt_fromstorecode.Text = Trim(gdataset.Tables("StoreMaster").Rows(i).Item("Storecode"))
                    txt_fromstorecode.ReadOnly = True
                End If
                '''******************************* End Store Code *****************************************'''
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Tostore.SelectedIndexChanged
        Try
            '''******************************* Show Store Code ****************************************'''
            Dim i As Integer
            If Cmd_Add.Text = "Add [F7]" Then
                sqlstring = "SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREDESC ='" & Trim(cbo_Tostore.SelectedItem) & "'"
                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                    txt_Tostorecode.Text = Trim(gdataset.Tables("STOREMASTER1").Rows(i).Item("Storecode"))
                    txt_Tostorecode.ReadOnly = True
                End If
                '''******************************* End Store Code *****************************************'''
                sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(txt_Tostorecode.Text) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                    doctype1 = ""
                    If Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORESTATUS")) = "M" Then
                        doctype1 = "RET"
                        lbl_Heading.Text = "STOCK RETURN"
                    Else
                        doctype1 = "TRF"
                        lbl_Heading.Text = "STOCK TRANSFER"
                    End If
                    Call autogenerate()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Fromstore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_Fromstore.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cbo_Tostore.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_Tostore.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Challanno.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Challanno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Challanno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dtp_Docdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Docdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Docdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dtp_Challandate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Challandate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Challandate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ssgrid.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalamt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Totalamt.LostFocus
        Try
            txt_Totalamt.Text = Format(Val(txt_Totalamt.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalqty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Totalqty.LostFocus
        Try
            txt_Totalqty.Text = Format(Val(txt_Totalqty.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Totalamt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Totalqty.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalqty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Totalqty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Remarks.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Remarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Remarks.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Transfer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_Docno.Text = ""
                txt_Docno.Focus()
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
                Me.txt_Totalamt.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.Q Then
                Me.txt_Totalqty.Focus()
                Exit Sub
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
            '''********** Check  From Store Can't be blank *********************'''
            If Trim(cbo_Fromstore.Text) = "" Then
                MessageBox.Show(" From Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Fromstore.Focus()
                Exit Sub
            End If
            '''********** Check  To Store Can't be blank *********************'''
            If Trim(cbo_Tostore.Text) = "" Then
                MessageBox.Show(" To Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Tostore.Focus()
                Exit Sub
            End If
            '''********** Check  Challan No. Can't be blank *********************'''
            If Trim(txt_Challanno.Text) = "" Then
                MessageBox.Show(" Challan No. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Challanno.Focus()
                Exit Sub
            End If
            '''********** Check  Totalamount Can't be blank *********************'''
            If Val(txt_Totalamt.Text) = 0 Then
                MessageBox.Show(" Totalamount can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Totalamt.Focus()
                Exit Sub
            End If
            ''''********** Check  Total Quantity Can't be blank *********************'''
            'If Val(txt_Totalqty.Text) = 0 Then
            '    MessageBox.Show(" Total Quantity can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txt_Totalqty.Focus()
            '    Exit Sub
            'End If
            '''********** Check  DOC No. Can't be blank *********************'''
            If Trim(txt_Docno.Text) = "" Then
                MessageBox.Show(" DOC No. field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Docno.Focus()
                Exit Sub
            End If
            '''********** Check  both from store and to store Can't be blank *********************'''
            If Trim(txt_fromstorecode.Text) = "" Then
                MessageBox.Show(" Inter department Transfer can't be possible ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Fromstore.Focus()
                Exit Sub
            End If
            If Trim(txt_Tostorecode.Text) = "" Then
                MessageBox.Show(" Inter department Transfer can't be possible ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Tostore.Focus()
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
                ssgrid.Col = 8
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("dblconv can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(8, i)
                    Exit Sub
                End If
                'ssgrid.Col = 9
                'If Val(ssgrid.Text) = 0 Then
                '    MessageBox.Show("High Ratio can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(9, i)
                '    Exit Sub
                'End If
                ssgrid.Col = 10
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(10, i)
                    Exit Sub
                End If
                ssgrid.Col = 11
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Sub Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(11, i)
                    Exit Sub
                End If
            Next i
            '''****************************************** Check if that specified quantity is avaliable or not *************************************************'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                itemcode = Trim(ssgrid.Text)
                Dim VCHKCURQTY, VCHKCLQTY As Double
                ssgrid.Col = 4
                VCHKCURQTY = ssgrid.Text
                VCHKCLQTY = ClosingQuantity(Trim(itemcode), Trim(txt_fromstorecode.Text))
                If Val(VCHKCURQTY) > Val(VCHKCLQTY) Then
                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(4, i)
                    ssgrid.Text = ""
                    ssgrid.Focus()
                    Exit Sub
                End If
            Next i
            'With ssgrid
            '    For i = 1 To .DataRowCnt
            '        .Row = i
            '        .Col = 1
            '        itemcode = Trim(.Text)
            '        If Trim(cbo_Fromstore.Text) = "BAR-1" Then
            '            sqlstring = "SELECT bar1clstock,bar1doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar1clstock")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar1doublevalue")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-2" Then
            '            sqlstring = "SELECT bar2clstock,bar2doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar2clstock")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar2doublevalue")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        ElseIf Trim(cbo_Fromstore.Text) = "BAR-3" Then
            '            sqlstring = "SELECT bar3clstock,bar3doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar3clstock")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar3doublevalue")) < Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        End If
            '        '''******************************** First validation *******************************************'''
            '    Next i
            'End With
            '''****************************************** Check if that specified quantity is completed *************************************************'''
            strSqlString = "SELECT ISNULL(GLOBALCLOSE,'') AS GLOBALCLOSE FROM MONTHCLOSE WHERE MONTHNO = MONTH('" & Format(dtp_Docdate.Value, "dd-MMM-yyyy") & "') "
            gconnection.getDataSet(strSqlString, "MONTHCLOSE")
            If gdataset.Tables("MONTHCLOSE").Rows.Count > 0 Then
                If Trim(gdataset.Tables("MONTHCLOSE").Rows(0).Item("GLOBALCLOSE")) = "Y" Then
                    MessageBox.Show("For This Month Transaction is Closed....", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GridUOM(ByVal i As Integer)
        Try
            Dim j As Integer
            sqlstring = "SELECT UOMdesc FROM UOMMaster WHERE freeze='N'"
            gconnection.getDataSet(sqlstring, "UOMMaster1")
            If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
                For j = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMaster1").Rows(j).Item("UOMdesc"))
                    ssgrid.Text = Trim(gdataset.Tables("UOMMaster1").Rows(j).Item("UOMdesc"))
                Next j
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, Clsquantiy As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty, Varqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
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
                ValDblamount = Format(Val(ValQty) * Val(ValHighratio), "0.00")
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
                Next j
                Clsquantiy = ClosingQuantity(Trim(Itemcode), Trim(txt_fromstorecode.Text))
                ssgrid.Col = 2
                ssgrid.Row = i
                lbl_closingqty.Text = UCase(Trim(ssgrid.Text)) & " CLOSING QTY : " & Format(Val(Clsquantiy - Calqty), "0.000")
                Me.txt_Totalamt.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamt.Text = Format(Val(Me.txt_Totalamt.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1

                Me.txt_Totalqty.Text = 0
                Varqty = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    Varqty = Val(ssgrid.Text)
                    Me.txt_Totalqty.Text = Format(Val(Me.txt_Totalqty.Text) + Val(Varqty), "0.00")
                Next i
                i = i - 1

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Docno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmd_Docnohelp.Enabled = True Then
                    search = Trim(txt_Docno.Text)
                    Call cmd_Docnohelp_Click(cmd_Docnohelp, e)
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
                    Call cmd_Docnohelp_Click(cmd_Docnohelp, e)
                Else
                    txt_Docno_Validated(txt_Docno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Transfer_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            StockTransferTransbool = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        Dim Issuerate, Highratio, Dblamount As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j As Integer
        search = Nothing

        Try
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Then
                Call Calculate()
            End If
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
    Private Sub txt_FromDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromDocno.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_FromDocno.Enabled = True Then
                search = Trim(txt_FromDocno.Text)
                Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
            End If
        End If
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
            Catch ex As Exception
                MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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

    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM STOCKTRANSFERHEADER"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK TRANSFER/RETURN HELP"
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
            gSQLString = "SELECT docdetails,docdate FROM STOCKTRANSFERHEADER"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK TRANSFER/RETURN HELP"
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
            'Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            'sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            'sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount"
            'sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            'sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "' "
            'sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE TO BAR"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        Try
            gPrint = True
            Dim i As Integer
            Dim objStockIssueClass As New rptStockTransferreport
            Dim sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE,ISNULL(H.FROMSTORECODE,'') AS FROMSTORECODE,"
            sqlstring = sqlstring & " ISNULL(H.FROMSTOREDESC,'') AS FROMSTOREDESC,ISNULL(H.TOSTORECODE,'') AS TOSTORECODE,ISNULL(H.TOSTOREDESC,'') AS TOSTOREDESC,"
            sqlstring = sqlstring & " ISNULL(H.CHALLENNO,'') AS CHALLENNO,H.CHALLENDATE AS CHALLENDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMNAME,'') AS ITEMNAME,"
            sqlstring = sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT"
            sqlstring = sqlstring & " FROM STOCKTRANSFERHEADER AS H INNER JOIN STOCKTRANSFERDETAIL AS D ON H.DOCDETAILS = D.DOCDETAILS"
            sqlstring = sqlstring & " WHERE H.DOCDETAILS ='" & Trim(txt_Docno.Text) & "'"
            sqlstring = sqlstring & " ORDER BY H.DOCDETAILS,H.DOCDATE"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub
End Class
