Imports System.Data.SqlClient
Imports System.IO
Public Class StockIndent
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
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents dtp_Excisepassdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Grndate As System.Windows.Forms.Label
    Friend WithEvents lbl_Grnno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Excisepassno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents grp_Grngroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Grn As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdValueby As System.Windows.Forms.Button
    Friend WithEvents OptPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents OptValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtChangeValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRoundoff As System.Windows.Forms.Button
    Friend WithEvents OptNearest As System.Windows.Forms.RadioButton
    Friend WithEvents OptNone As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Help As System.Windows.Forms.Label
    Friend WithEvents grp_StockGrndetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_StockGrndetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_StockGrnprint As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnView As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnClear As System.Windows.Forms.Button
    Friend WithEvents grp_Billingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_Excisedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Trucknumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stockindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Trucknumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Stockindate As System.Windows.Forms.Label
    Friend WithEvents lbl_Billterms As System.Windows.Forms.Label
    Friend WithEvents ssgrid_billdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents txt_storeDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents txt_storecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_IndentNo As System.Windows.Forms.TextBox
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_Indentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_indentnoHelp As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_FREEZE As System.Windows.Forms.Button
    Friend WithEvents lbl_Totalamount As System.Windows.Forms.Label
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROMSTORECODE As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromStorename As System.Windows.Forms.TextBox
    Friend WithEvents cmd_fromStorecodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_indent As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StockIndent))
        Me.dtp_Excisepassdate = New System.Windows.Forms.DateTimePicker
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Suppliercode = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_FREEZE = New System.Windows.Forms.Button
        Me.cmd_Add = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.dtp_Indentdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.lbl_Grndate = New System.Windows.Forms.Label
        Me.lbl_Grnno = New System.Windows.Forms.Label
        Me.grp_Grngroup1 = New System.Windows.Forms.GroupBox
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.lbl_Excisepassno = New System.Windows.Forms.Label
        Me.lbl_Excisepassdate = New System.Windows.Forms.Label
        Me.txt_Excisepassno = New System.Windows.Forms.TextBox
        Me.lbl_Grn = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdRoundoff = New System.Windows.Forms.Button
        Me.OptNearest = New System.Windows.Forms.RadioButton
        Me.OptNone = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdValueby = New System.Windows.Forms.Button
        Me.OptPercentage = New System.Windows.Forms.RadioButton
        Me.OptValue = New System.Windows.Forms.RadioButton
        Me.txtChangeValue = New System.Windows.Forms.TextBox
        Me.lbl_Help = New System.Windows.Forms.Label
        Me.grp_StockGrndetails = New System.Windows.Forms.GroupBox
        Me.lbl_StockGrndetails = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Cmd_StockGrnprint = New System.Windows.Forms.Button
        Me.Cmd_StockGrnView = New System.Windows.Forms.Button
        Me.Cmd_StockGrnexit = New System.Windows.Forms.Button
        Me.Cmd_StockGrnClear = New System.Windows.Forms.Button
        Me.lbl_FromDocno = New System.Windows.Forms.Label
        Me.txt_FromDocno = New System.Windows.Forms.TextBox
        Me.Cmd_FromDocno = New System.Windows.Forms.Button
        Me.txt_ToDocno = New System.Windows.Forms.TextBox
        Me.Cmd_ToDocno = New System.Windows.Forms.Button
        Me.lbl_ToDocno = New System.Windows.Forms.Label
        Me.grp_Billingdetails = New System.Windows.Forms.GroupBox
        Me.ssgrid_billdetails = New AxFPSpreadADO.AxfpSpread
        Me.Label2 = New System.Windows.Forms.Label
        Me.grp_Excisedetails = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Trucknumber = New System.Windows.Forms.TextBox
        Me.dtp_Stockindate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Trucknumber = New System.Windows.Forms.Label
        Me.lbl_Stockindate = New System.Windows.Forms.Label
        Me.txt_IndentNo = New System.Windows.Forms.TextBox
        Me.txt_storeDesc = New System.Windows.Forms.TextBox
        Me.lbl_Billterms = New System.Windows.Forms.Label
        Me.cbo_type = New System.Windows.Forms.ComboBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.cmd_storecode = New System.Windows.Forms.Button
        Me.txt_storecode = New System.Windows.Forms.TextBox
        Me.cmd_indentnoHelp = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl_Totalamount = New System.Windows.Forms.Label
        Me.txt_Totalamount = New System.Windows.Forms.TextBox
        Me.TXT_FROMSTORECODE = New System.Windows.Forms.TextBox
        Me.txt_FromStorename = New System.Windows.Forms.TextBox
        Me.cmd_fromStorecodeHelp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_footer = New System.Windows.Forms.GroupBox
        Me.Txt_signature = New System.Windows.Forms.TextBox
        Me.Txt_footer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_item = New System.Windows.Forms.CheckBox
        Me.lbl_indent = New System.Windows.Forms.Label
        Me.frmbut.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_StockGrndetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grp_Billingdetails.SuspendLayout()
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Excisedetails.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_Excisepassdate
        '
        Me.dtp_Excisepassdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Excisepassdate.Location = New System.Drawing.Point(240, 128)
        Me.dtp_Excisepassdate.Name = "dtp_Excisepassdate"
        Me.dtp_Excisepassdate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Excisepassdate.TabIndex = 2
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Location = New System.Drawing.Point(152, 432)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(376, 40)
        Me.txt_Remarks.TabIndex = 14
        Me.txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(72, 432)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(75, 17)
        Me.lbl_Remarks.TabIndex = 43
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(114, 96)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(88, 18)
        Me.lbl_Suppliercode.TabIndex = 28
        Me.lbl_Suppliercode.Text = "INDENT NO :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Controls.Add(Me.cmd_Exit)
        Me.frmbut.Controls.Add(Me.cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_FREEZE)
        Me.frmbut.Controls.Add(Me.cmd_Add)
        Me.frmbut.Location = New System.Drawing.Point(64, 512)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(872, 56)
        Me.frmbut.TabIndex = 44
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
        Me.cmd_Print.TabIndex = 384
        Me.cmd_Print.Text = "Print[F10]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(736, 16)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(96, 32)
        Me.cmd_Exit.TabIndex = 382
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(32, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 378
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_FREEZE
        '
        Me.Cmd_FREEZE.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_FREEZE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_FREEZE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FREEZE.ForeColor = System.Drawing.Color.White
        Me.Cmd_FREEZE.Image = CType(resources.GetObject("Cmd_FREEZE.Image"), System.Drawing.Image)
        Me.Cmd_FREEZE.Location = New System.Drawing.Point(312, 16)
        Me.Cmd_FREEZE.Name = "Cmd_FREEZE"
        Me.Cmd_FREEZE.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_FREEZE.TabIndex = 380
        Me.Cmd_FREEZE.Text = "Void[F8]"
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.White
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.Location = New System.Drawing.Point(176, 16)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Add.TabIndex = 379
        Me.cmd_Add.Text = "Add [F7]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.White
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(664, 528)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 381
        Me.cmd_View.Text = " View[F9]"
        '
        'dtp_Indentdate
        '
        Me.dtp_Indentdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Indentdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Indentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Indentdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Indentdate.Location = New System.Drawing.Point(680, 89)
        Me.dtp_Indentdate.Name = "dtp_Indentdate"
        Me.dtp_Indentdate.Size = New System.Drawing.Size(104, 26)
        Me.dtp_Indentdate.TabIndex = 1
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(432, 40)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(105, 31)
        Me.lbl_Heading.TabIndex = 21
        Me.lbl_Heading.Text = "INDENT"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(560, 464)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(312, 25)
        Me.lbl_Freeze.TabIndex = 47
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Grndate
        '
        Me.lbl_Grndate.AutoSize = True
        Me.lbl_Grndate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grndate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grndate.Location = New System.Drawing.Point(560, 95)
        Me.lbl_Grndate.Name = "lbl_Grndate"
        Me.lbl_Grndate.Size = New System.Drawing.Size(105, 18)
        Me.lbl_Grndate.TabIndex = 25
        Me.lbl_Grndate.Text = "INDENT DATE :"
        '
        'lbl_Grnno
        '
        Me.lbl_Grnno.AutoSize = True
        Me.lbl_Grnno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grnno.Location = New System.Drawing.Point(96, 132)
        Me.lbl_Grnno.Name = "lbl_Grnno"
        Me.lbl_Grnno.Size = New System.Drawing.Size(108, 18)
        Me.lbl_Grnno.TabIndex = 23
        Me.lbl_Grnno.Text = "DEPARTMENT :"
        '
        'grp_Grngroup1
        '
        Me.grp_Grngroup1.BackColor = System.Drawing.Color.Transparent
        Me.grp_Grngroup1.Location = New System.Drawing.Point(72, 72)
        Me.grp_Grngroup1.Name = "grp_Grngroup1"
        Me.grp_Grngroup1.Size = New System.Drawing.Size(848, 135)
        Me.grp_Grngroup1.TabIndex = 22
        Me.grp_Grngroup1.TabStop = False
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.Location = New System.Drawing.Point(784, 1000)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Storelocation.TabIndex = 8
        '
        'lbl_Excisepassno
        '
        Me.lbl_Excisepassno.AutoSize = True
        Me.lbl_Excisepassno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassno.Location = New System.Drawing.Point(64, 88)
        Me.lbl_Excisepassno.Name = "lbl_Excisepassno"
        Me.lbl_Excisepassno.Size = New System.Drawing.Size(164, 21)
        Me.lbl_Excisepassno.TabIndex = 5
        Me.lbl_Excisepassno.Text = "EXCISE PASS NO       :"
        '
        'lbl_Excisepassdate
        '
        Me.lbl_Excisepassdate.AutoSize = True
        Me.lbl_Excisepassdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassdate.Location = New System.Drawing.Point(64, 128)
        Me.lbl_Excisepassdate.Name = "lbl_Excisepassdate"
        Me.lbl_Excisepassdate.Size = New System.Drawing.Size(168, 21)
        Me.lbl_Excisepassdate.TabIndex = 6
        Me.lbl_Excisepassdate.Text = "EXCISE PASS DATE   :"
        '
        'txt_Excisepassno
        '
        Me.txt_Excisepassno.BackColor = System.Drawing.Color.White
        Me.txt_Excisepassno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Excisepassno.Location = New System.Drawing.Point(240, 88)
        Me.txt_Excisepassno.MaxLength = 15
        Me.txt_Excisepassno.Name = "txt_Excisepassno"
        Me.txt_Excisepassno.Size = New System.Drawing.Size(216, 26)
        Me.txt_Excisepassno.TabIndex = 1
        Me.txt_Excisepassno.Text = ""
        '
        'lbl_Grn
        '
        Me.lbl_Grn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grn.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Grn.Location = New System.Drawing.Point(400, 488)
        Me.lbl_Grn.Name = "lbl_Grn"
        Me.lbl_Grn.Size = New System.Drawing.Size(160, 24)
        Me.lbl_Grn.TabIndex = 45
        Me.lbl_Grn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 1000)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 128)
        Me.GroupBox1.TabIndex = 352
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdRoundoff)
        Me.GroupBox2.Controls.Add(Me.OptNearest)
        Me.GroupBox2.Controls.Add(Me.OptNone)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(264, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 88)
        Me.GroupBox2.TabIndex = 353
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rounded Off"
        '
        'cmdRoundoff
        '
        Me.cmdRoundoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRoundoff.ForeColor = System.Drawing.Color.Blue
        Me.cmdRoundoff.Location = New System.Drawing.Point(136, 16)
        Me.cmdRoundoff.Name = "cmdRoundoff"
        Me.cmdRoundoff.Size = New System.Drawing.Size(56, 39)
        Me.cmdRoundoff.TabIndex = 2
        Me.cmdRoundoff.Text = "Round Off"
        '
        'OptNearest
        '
        Me.OptNearest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNearest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNearest.Location = New System.Drawing.Point(24, 44)
        Me.OptNearest.Name = "OptNearest"
        Me.OptNearest.Size = New System.Drawing.Size(85, 16)
        Me.OptNearest.TabIndex = 2
        Me.OptNearest.Text = "Nearest Rs"
        '
        'OptNone
        '
        Me.OptNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(24, 18)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(88, 16)
        Me.OptNone.TabIndex = 1
        Me.OptNone.Text = "None"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdValueby)
        Me.GroupBox3.Controls.Add(Me.OptPercentage)
        Me.GroupBox3.Controls.Add(Me.OptValue)
        Me.GroupBox3.Controls.Add(Me.txtChangeValue)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 88)
        Me.GroupBox3.TabIndex = 352
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount Amount"
        '
        'cmdValueby
        '
        Me.cmdValueby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValueby.ForeColor = System.Drawing.Color.Blue
        Me.cmdValueby.Location = New System.Drawing.Point(191, 16)
        Me.cmdValueby.Name = "cmdValueby"
        Me.cmdValueby.Size = New System.Drawing.Size(48, 40)
        Me.cmdValueby.TabIndex = 3
        Me.cmdValueby.Text = "Value Chg"
        '
        'OptPercentage
        '
        Me.OptPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPercentage.Location = New System.Drawing.Point(10, 56)
        Me.OptPercentage.Name = "OptPercentage"
        Me.OptPercentage.Size = New System.Drawing.Size(87, 16)
        Me.OptPercentage.TabIndex = 2
        Me.OptPercentage.Text = "Percentage"
        '
        'OptValue
        '
        Me.OptValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptValue.Location = New System.Drawing.Point(10, 24)
        Me.OptValue.Name = "OptValue"
        Me.OptValue.Size = New System.Drawing.Size(80, 16)
        Me.OptValue.TabIndex = 1
        Me.OptValue.Text = "Value"
        '
        'txtChangeValue
        '
        Me.txtChangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangeValue.Location = New System.Drawing.Point(100, 56)
        Me.txtChangeValue.MaxLength = 10
        Me.txtChangeValue.Name = "txtChangeValue"
        Me.txtChangeValue.Size = New System.Drawing.Size(92, 20)
        Me.txtChangeValue.TabIndex = 3
        Me.txtChangeValue.Text = ""
        '
        'lbl_Help
        '
        Me.lbl_Help.AutoSize = True
        Me.lbl_Help.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Help.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Help.ForeColor = System.Drawing.Color.Red
        Me.lbl_Help.Location = New System.Drawing.Point(200, 568)
        Me.lbl_Help.Name = "lbl_Help"
        Me.lbl_Help.Size = New System.Drawing.Size(624, 21)
        Me.lbl_Help.TabIndex = 46
        Me.lbl_Help.Text = "Press F4 For help option/Press F3 for deleting particular row/Alt+R to focus on R" & _
        "emarks box "
        '
        'grp_StockGrndetails
        '
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_StockGrndetails)
        Me.grp_StockGrndetails.Controls.Add(Me.GroupBox5)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_ToDocno)
        Me.grp_StockGrndetails.Location = New System.Drawing.Point(222, 1000)
        Me.grp_StockGrndetails.Name = "grp_StockGrndetails"
        Me.grp_StockGrndetails.Size = New System.Drawing.Size(514, 238)
        Me.grp_StockGrndetails.TabIndex = 361
        Me.grp_StockGrndetails.TabStop = False
        '
        'lbl_StockGrndetails
        '
        Me.lbl_StockGrndetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_StockGrndetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockGrndetails.ForeColor = System.Drawing.Color.White
        Me.lbl_StockGrndetails.Location = New System.Drawing.Point(0, 7)
        Me.lbl_StockGrndetails.Name = "lbl_StockGrndetails"
        Me.lbl_StockGrndetails.Size = New System.Drawing.Size(520, 25)
        Me.lbl_StockGrndetails.TabIndex = 26
        Me.lbl_StockGrndetails.Text = "GRN CHECKLIST"
        Me.lbl_StockGrndetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnprint)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnView)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnexit)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnClear)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        '
        'Cmd_StockGrnprint
        '
        Me.Cmd_StockGrnprint.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnprint.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_StockGrnprint.Name = "Cmd_StockGrnprint"
        Me.Cmd_StockGrnprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnprint.TabIndex = 25
        Me.Cmd_StockGrnprint.Text = "Print [F10]"
        '
        'Cmd_StockGrnView
        '
        Me.Cmd_StockGrnView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnView.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_StockGrnView.Name = "Cmd_StockGrnView"
        Me.Cmd_StockGrnView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnView.TabIndex = 13
        Me.Cmd_StockGrnView.Text = "View [F9]"
        '
        'Cmd_StockGrnexit
        '
        Me.Cmd_StockGrnexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_StockGrnexit.Name = "Cmd_StockGrnexit"
        Me.Cmd_StockGrnexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnexit.TabIndex = 15
        Me.Cmd_StockGrnexit.Text = "Exit[F11]"
        '
        'Cmd_StockGrnClear
        '
        Me.Cmd_StockGrnClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_StockGrnClear.Name = "Cmd_StockGrnClear"
        Me.Cmd_StockGrnClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnClear.TabIndex = 24
        Me.Cmd_StockGrnClear.Text = "Clear[F6]"
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(38, 67)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 22)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM GRN NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(184, 64)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        Me.txt_FromDocno.Text = ""
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(392, 64)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(184, 112)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        Me.txt_ToDocno.Text = ""
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(392, 112)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(64, 114)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(109, 22)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO GRN NO :"
        '
        'grp_Billingdetails
        '
        Me.grp_Billingdetails.BackColor = System.Drawing.SystemColors.Control
        Me.grp_Billingdetails.Controls.Add(Me.ssgrid_billdetails)
        Me.grp_Billingdetails.Controls.Add(Me.Label2)
        Me.grp_Billingdetails.Location = New System.Drawing.Point(16, 1000)
        Me.grp_Billingdetails.Name = "grp_Billingdetails"
        Me.grp_Billingdetails.Size = New System.Drawing.Size(664, 310)
        Me.grp_Billingdetails.TabIndex = 364
        Me.grp_Billingdetails.TabStop = False
        '
        'ssgrid_billdetails
        '
        Me.ssgrid_billdetails.ContainingControl = Me
        Me.ssgrid_billdetails.DataSource = Nothing
        Me.ssgrid_billdetails.Location = New System.Drawing.Point(24, 48)
        Me.ssgrid_billdetails.Name = "ssgrid_billdetails"
        Me.ssgrid_billdetails.OcxState = CType(resources.GetObject("ssgrid_billdetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_billdetails.Size = New System.Drawing.Size(608, 248)
        Me.ssgrid_billdetails.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(661, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BILLING DETAILS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_Excisedetails
        '
        Me.grp_Excisedetails.Controls.Add(Me.Label5)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassdate)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Excisepassdate)
        Me.grp_Excisedetails.Location = New System.Drawing.Point(216, 1000)
        Me.grp_Excisedetails.Name = "grp_Excisedetails"
        Me.grp_Excisedetails.Size = New System.Drawing.Size(512, 206)
        Me.grp_Excisedetails.TabIndex = 366
        Me.grp_Excisedetails.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(506, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXCISE DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Trucknumber
        '
        Me.txt_Trucknumber.BackColor = System.Drawing.Color.White
        Me.txt_Trucknumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Trucknumber.Location = New System.Drawing.Point(240, 168)
        Me.txt_Trucknumber.MaxLength = 15
        Me.txt_Trucknumber.Name = "txt_Trucknumber"
        Me.txt_Trucknumber.Size = New System.Drawing.Size(216, 26)
        Me.txt_Trucknumber.TabIndex = 3
        Me.txt_Trucknumber.Text = ""
        '
        'dtp_Stockindate
        '
        Me.dtp_Stockindate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Stockindate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Stockindate.Location = New System.Drawing.Point(240, 48)
        Me.dtp_Stockindate.Name = "dtp_Stockindate"
        Me.dtp_Stockindate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Stockindate.TabIndex = 0
        '
        'lbl_Trucknumber
        '
        Me.lbl_Trucknumber.AutoSize = True
        Me.lbl_Trucknumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trucknumber.Location = New System.Drawing.Point(64, 168)
        Me.lbl_Trucknumber.Name = "lbl_Trucknumber"
        Me.lbl_Trucknumber.Size = New System.Drawing.Size(162, 21)
        Me.lbl_Trucknumber.TabIndex = 7
        Me.lbl_Trucknumber.Text = "TRUCK NUMBER      :"
        '
        'lbl_Stockindate
        '
        Me.lbl_Stockindate.AutoSize = True
        Me.lbl_Stockindate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stockindate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockindate.Location = New System.Drawing.Point(64, 48)
        Me.lbl_Stockindate.Name = "lbl_Stockindate"
        Me.lbl_Stockindate.Size = New System.Drawing.Size(163, 21)
        Me.lbl_Stockindate.TabIndex = 4
        Me.lbl_Stockindate.Text = "STOCK IN DATE        :"
        '
        'txt_IndentNo
        '
        Me.txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IndentNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IndentNo.Location = New System.Drawing.Point(256, 88)
        Me.txt_IndentNo.MaxLength = 50
        Me.txt_IndentNo.Name = "txt_IndentNo"
        Me.txt_IndentNo.Size = New System.Drawing.Size(256, 26)
        Me.txt_IndentNo.TabIndex = 0
        Me.txt_IndentNo.Text = ""
        '
        'txt_storeDesc
        '
        Me.txt_storeDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_storeDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storeDesc.Location = New System.Drawing.Point(328, 128)
        Me.txt_storeDesc.MaxLength = 50
        Me.txt_storeDesc.Name = "txt_storeDesc"
        Me.txt_storeDesc.Size = New System.Drawing.Size(208, 26)
        Me.txt_storeDesc.TabIndex = 4
        Me.txt_storeDesc.Text = ""
        '
        'lbl_Billterms
        '
        Me.lbl_Billterms.AutoSize = True
        Me.lbl_Billterms.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billterms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billterms.Location = New System.Drawing.Point(154, 168)
        Me.lbl_Billterms.Name = "lbl_Billterms"
        Me.lbl_Billterms.Size = New System.Drawing.Size(49, 18)
        Me.lbl_Billterms.TabIndex = 31
        Me.lbl_Billterms.Text = "TYPE :"
        '
        'cbo_type
        '
        Me.cbo_type.BackColor = System.Drawing.Color.Wheat
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.Items.AddRange(New Object() {"REVENUE", "CAPITAL", "FINISHED GOOD", "INTERMEDIATE GOOD", "RAW MATERIAL", "SERVICE"})
        Me.cbo_type.Location = New System.Drawing.Point(256, 168)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(280, 27)
        Me.cbo_type.TabIndex = 6
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(56, 224)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(888, 192)
        Me.ssgrid.TabIndex = 367
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(304, 127)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 375
        '
        'txt_storecode
        '
        Me.txt_storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_storecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storecode.Location = New System.Drawing.Point(256, 128)
        Me.txt_storecode.MaxLength = 50
        Me.txt_storecode.Name = "txt_storecode"
        Me.txt_storecode.Size = New System.Drawing.Size(48, 26)
        Me.txt_storecode.TabIndex = 376
        Me.txt_storecode.Text = ""
        '
        'cmd_indentnoHelp
        '
        Me.cmd_indentnoHelp.Image = CType(resources.GetObject("cmd_indentnoHelp.Image"), System.Drawing.Image)
        Me.cmd_indentnoHelp.Location = New System.Drawing.Point(512, 88)
        Me.cmd_indentnoHelp.Name = "cmd_indentnoHelp"
        Me.cmd_indentnoHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_indentnoHelp.TabIndex = 377
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(487, -88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 88)
        Me.Button1.TabIndex = 383
        Me.Button1.Text = "Print[F10]"
        '
        'lbl_Totalamount
        '
        Me.lbl_Totalamount.AutoSize = True
        Me.lbl_Totalamount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalamount.Location = New System.Drawing.Point(896, 472)
        Me.lbl_Totalamount.Name = "lbl_Totalamount"
        Me.lbl_Totalamount.Size = New System.Drawing.Size(90, 18)
        Me.lbl_Totalamount.TabIndex = 385
        Me.lbl_Totalamount.Text = "TOTAL AMT :"
        Me.lbl_Totalamount.Visible = False
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamount.Location = New System.Drawing.Point(752, 416)
        Me.txt_Totalamount.MaxLength = 15
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamount.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamount.TabIndex = 384
        Me.txt_Totalamount.Text = ""
        '
        'TXT_FROMSTORECODE
        '
        Me.TXT_FROMSTORECODE.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROMSTORECODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROMSTORECODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROMSTORECODE.Location = New System.Drawing.Point(680, 128)
        Me.TXT_FROMSTORECODE.MaxLength = 50
        Me.TXT_FROMSTORECODE.Name = "TXT_FROMSTORECODE"
        Me.TXT_FROMSTORECODE.Size = New System.Drawing.Size(48, 26)
        Me.TXT_FROMSTORECODE.TabIndex = 394
        Me.TXT_FROMSTORECODE.Text = ""
        '
        'txt_FromStorename
        '
        Me.txt_FromStorename.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromStorename.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromStorename.Location = New System.Drawing.Point(752, 128)
        Me.txt_FromStorename.MaxLength = 50
        Me.txt_FromStorename.Name = "txt_FromStorename"
        Me.txt_FromStorename.Size = New System.Drawing.Size(160, 26)
        Me.txt_FromStorename.TabIndex = 392
        Me.txt_FromStorename.Text = ""
        '
        'cmd_fromStorecodeHelp
        '
        Me.cmd_fromStorecodeHelp.Image = CType(resources.GetObject("cmd_fromStorecodeHelp.Image"), System.Drawing.Image)
        Me.cmd_fromStorecodeHelp.Location = New System.Drawing.Point(728, 128)
        Me.cmd_fromStorecodeHelp.Name = "cmd_fromStorecodeHelp"
        Me.cmd_fromStorecodeHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_fromStorecodeHelp.TabIndex = 393
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "FROM STORE :"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.Wheat
        Me.txt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_qty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(592, 416)
        Me.txt_qty.MaxLength = 15
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_qty.Size = New System.Drawing.Size(88, 26)
        Me.txt_qty.TabIndex = 396
        Me.txt_qty.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(896, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 397
        Me.Label3.Text = "TOTAL QTY :"
        Me.Label3.Visible = False
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(112, 424)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(833, 80)
        Me.grp_footer.TabIndex = 438
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(696, 20)
        Me.Txt_signature.TabIndex = 441
        Me.Txt_signature.Text = ""
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(696, 20)
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
        'Chk_item
        '
        Me.Chk_item.BackgroundImage = CType(resources.GetObject("Chk_item.BackgroundImage"), System.Drawing.Image)
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_item.Location = New System.Drawing.Point(64, 480)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(120, 24)
        Me.Chk_item.TabIndex = 463
        Me.Chk_item.Text = "FooterUpdation"
        '
        'lbl_indent
        '
        Me.lbl_indent.BackColor = System.Drawing.Color.Transparent
        Me.lbl_indent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indent.ForeColor = System.Drawing.Color.Red
        Me.lbl_indent.Location = New System.Drawing.Point(48, 32)
        Me.lbl_indent.Name = "lbl_indent"
        Me.lbl_indent.Size = New System.Drawing.Size(272, 23)
        Me.lbl_indent.TabIndex = 464
        '
        'StockIndent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(998, 604)
        Me.Controls.Add(Me.lbl_indent)
        Me.Controls.Add(Me.grp_footer)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_FROMSTORECODE)
        Me.Controls.Add(Me.txt_FromStorename)
        Me.Controls.Add(Me.lbl_Totalamount)
        Me.Controls.Add(Me.txt_Totalamount)
        Me.Controls.Add(Me.txt_storecode)
        Me.Controls.Add(Me.lbl_Billterms)
        Me.Controls.Add(Me.txt_storeDesc)
        Me.Controls.Add(Me.txt_IndentNo)
        Me.Controls.Add(Me.lbl_Help)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_Suppliercode)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Grndate)
        Me.Controls.Add(Me.lbl_Grnno)
        Me.Controls.Add(Me.cmd_fromStorecodeHelp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmd_indentnoHelp)
        Me.Controls.Add(Me.cmd_storecode)
        Me.Controls.Add(Me.grp_StockGrndetails)
        Me.Controls.Add(Me.grp_Billingdetails)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.grp_Excisedetails)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.lbl_Grn)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.dtp_Indentdate)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.grp_Grngroup1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.frmbut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "StockIndent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK INDENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_StockGrndetails.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grp_Billingdetails.ResumeLayout(False)
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Excisedetails.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_footer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public i, TotalCount, billrow As Integer
    Dim GRNno(), sqlstring, Gr As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode, sstr, LastIndentNo As String
    Public Listbox As System.Windows.Forms.ListBox
    Dim boolchk, costcentercodestatus, slcodestatus, blnchkupdateclsbal, Dupchk As Boolean
    Dim CATEGORY As String
    Private Sub StockIndent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_type.SelectedIndex = 0
        Call FOOTER()
        'If Mid(MyCompanyName, 1, 4) = "HIND" Then
        Call lastindent()
        'End If

        grp_footer.Visible = False
        txt_IndentNo.Text = LastIndentNo
        txt_IndentNo.Focus()
        'txt_IndentNo.ReadOnly = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub lastindent()
        'sqlstring = "select max(cast(isnull(indent_no,0)as int)) as ind from INVENTORY_INDENTHDR "
        sqlstring = "select ISNULL(max(cast(isnull(indent_no,0)as int)),0) as ind from INVENTORY_INDENTHDR "
        gconnection.getDataSet(sqlstring, "indt")
        If gdataset.Tables("indt").Rows.Count > 0 Then
            lbl_indent.Text = "LAST INDENT  " & gdataset.Tables("indt").Rows(0).Item(0)
            LastIndentNo = (gdataset.Tables("indt").Rows(0).Item(0)) + 1
        End If
    End Sub
    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FREEZE.Click
        Try
            Call checkValidation() ''-->Check Validation
            Dim insert(0) As String
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_FREEZE.Text, 1, 1) = "V" Then
                '''***************************************** Void the INDENT in IND_header **************************'''
                sqlstring = "UPDATE  INVENTORY_INDENTHDR "
                sqlstring = sqlstring & " SET Void= 'Y',"
                sqlstring = sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                sqlstring = sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                insert(0) = sqlstring
                '''***************************************** Void the INDENT in Complete **********************************'''
                ''''******************************* INSERT INTO A TEMP TABLE B4 DELETE INDENT FRM HDR ******************************'''
                'sqlstring = " INSERT INTO INVENTORY_INDENTHDR_DEL( INDENT_NO , INDENT_DATE , STORELOCATIONCODE , STORELOCATIONNAME , PRODUCT_TYPE , REMARKS , VOID , ADDUSER , ADDDATETIME , UPDATEUSER , UPDATETIME )"
                'sqlstring = sqlstring & " SELECT  INDENT_NO , INDENT_DATE , STORELOCATIONCODE , STORELOCATIONNAME , PRODUCT_TYPE , REMARKS , VOID , ADDUSER , ADDDATETIME , UPDATEUSER , UPDATETIME FROM INVENTORY_INDENTHDR A"
                'sqlstring = sqlstring & " WHERE(A.INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                'insert(0) = sqlstring
                ''''******************************* INDENT DELETION FRM HDR ******************************'''
                'sqlstring = " DELETE FROM INVENTORY_INDENTHDR"
                'sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                'ReDim Preserve insert(insert.Length)
                'insert(insert.Length - 1) = sqlstring
                ''''******************************* INDENT DELETION FRM HDR COMPLETE ******************************'''

                '''***************************************** Void the INDENT in INDENT_details **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "UPDATE  INVENTORY_INDENTDET "
                        sqlstring = sqlstring & " SET Void= 'Y',"
                        sqlstring = sqlstring & " FREEZEuser='" & Trim(gUsername) & " ',"
                        sqlstring = sqlstring & " FREEZEDATEtime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring
                    End With
                Next i
                '''***************************************** Void the INDENT is Complete **********************************'''
                '''***************************************** Void the INDENT in INDENT_header **************************'''

                '''***************************************** DELETE INDENT FROM INDENTDET **********************************'''
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        sqlstring = "  INSERT INTO INVENTORY_INDENTDET_DEL( INDENT_NO , INDENT_DATE , ITEMCODE , ITEMNAME , UOM , QTY , RATE , AMOUNT , CLSQTY , VOID , ADDUSER , ADDDATETIME , UPDATEUSER , UPDATETIME , FREEZEUSER , FREEZEDATETIME )"
                '        sqlstring = sqlstring & " SELECT  INDENT_NO , INDENT_DATE , ITEMCODE , ITEMNAME , UOM , QTY , RATE , AMOUNT , CLSQTY , VOID , ADDUSER , ADDDATETIME , UPDATEUSER , UPDATETIME , FREEZEUSER , FREEZEDATETIME  FROM INVENTORY_INDENTDET A"
                '        sqlstring = sqlstring & " WHERE(A.INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                '        ReDim Preserve insert(insert.Length)
                '        insert(insert.Length - 1) = sqlstring
                '    End With
                'Next i
                'sqlstring = " DELETE FROM INVENTORY_INDENTDET"
                'sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                'ReDim Preserve insert(insert.Length)
                'insert(insert.Length - 1) = sqlstring
                '''***************************************** DELETE INDENT FROM INDENTDET COMPLETE **********************************'''
                gconnection.MoreTrans(insert)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add [F7]"

            ElseIf Mid(Me.Cmd_FREEZE.Text, 1, 1) = "U" Then
                '''***************************************** UnVoid the INDENT in IND_header **************************'''
                sqlstring = "UPDATE  INVENTORY_INDENTHDR "
                sqlstring = sqlstring & " SET Void= 'N',"
                sqlstring = sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                sqlstring = sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                insert(0) = sqlstring
                '''***************************************** UnVoid the INDENT in Complete **********************************'''
                '''***************************************** UnVoid the INDENT in INDENT_details **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "UPDATE  INVENTORY_INDENTDET "
                        sqlstring = sqlstring & " SET Void= 'N',"
                        sqlstring = sqlstring & " FREEZEuser='" & Trim(gUsername) & " ',"
                        sqlstring = sqlstring & " FREEZEDATEtime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        sqlstring = sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring
                    End With
                Next i
                '''***************************************** UnVoid the INDENT is Complete **********************************'''
                '''***************************************** UnVoid the INDENT in INDENT_header **************************'''
                gconnection.MoreTrans(insert)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD_FREEZE" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Function printoperation()
        Try
            Dim i As Integer
            'Dim objGrncumpurchase As New rptGrncumpurchaseNote
            Dim Sqlstring = Sqlstring & " SELECT 	ISNULL(HDR.INDENT_NO,'') INDENT_NO, ISNULL(HDR.INDENT_DATE,'')  INDENT_DATE,"
            Sqlstring = Sqlstring & " ISNULL(HDR.FROMSTORECODE,'') FROMSTORECODE , ISNULL(HDR.STORELOCATIONCODE,'') STORELOCATIONCODE, ISNULL(HDR.STORELOCATIONNAME,'') STORELOCATIONNAME,"
            Sqlstring = Sqlstring & " ISNULL(HDR.PRODUCT_TYPE,'') PRODUCT_TYPE, ISNULL(HDR.REMARKS,'') REMARKS,ISNULL(HDR.updsign,'') updsign,ISNULL(HDR.updfooter,'') updfooter,"

            Sqlstring = Sqlstring & "	ISNULL(ITEMCODE,'') ITEMCODE, ISNULL(ITEMNAME,'') ITEMNAME, ISNULL(UOM,'') UOM,"
            Sqlstring = Sqlstring & " ISNULL(QTY,0) QTY, ISNULL(RATE,0) RATE, ISNULL(AMOUNT,0) AMOUNT, ISNULL(CLSQTY,0) CLSQTY"
            Sqlstring = Sqlstring & " FROM INVENTORY_INDENTHDR HDR"
            Sqlstring = Sqlstring & " INNER JOIN INVENTORY_INDENTDET AS DET ON HDR.INDENT_NO = DET.INDENT_NO"
            Sqlstring = Sqlstring & " WHERE HDR.INDENT_NO BETWEEN '" & Trim(txt_IndentNo.Text) & "' AND '" & Trim(txt_IndentNo.Text) & "'"

            Dim heading() As String = {"INDENT DETAILS"}
            ReportDetails(Sqlstring, heading, txt_IndentNo.Text, txt_IndentNo.Text)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Printoperation " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        Try
            gPrint = False
            Call printoperation()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    '    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
    '        Try
    '            Me.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Exit Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Grnno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Grnno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_Grnno.Text) = "" Then
    '                    Call cmd_Grnnohelp_Click(cmd_Grnnohelp, e)
    '                Else
    '                    txt_Grnno_Validated(txt_Grnno, e)
    '                    dtp_Grndate.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Grnno Key Press " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Grndate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Grndate.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Supplierinvno.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Grn Date Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Supplierinvno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                dtp_Supplierinvdate.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Supplier Invno Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Supplierinvdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                grp_Excisedetails.Top = 104
    '                grp_Excisedetails.Left = 216
    '                grp_Excisedetails.BringToFront()
    '                dtp_Stockindate.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Supplierinvdate_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliercode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Suppliercode.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_Suppliercode.Text) = "" Then
    '                    Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
    '                Else
    '                    Call txt_Suppliercode_Validated(txt_Suppliercode, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If slcodestatus = True Then
    '                    Txt_Slcode.Focus()
    '                Else
    '                    ssgrid.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliername_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Excisepassno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Excisepassno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                dtp_Excisepassdate.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Excisepassno_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Excisepassdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Excisepassdate.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Trucknumber.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Excisepassdate_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub cbo_Storelocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Storelocation.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Creditdays.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cbo_Storelocation_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Creditdays_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                ssgrid.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Creditdays_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Totalamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Vatamount.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Totalamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Billamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                Cmd_Add.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Billamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub cmd_Grnnohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Grnnohelp.Click
    '        Try
    '            gSQLString = "SELECT Grndetails,Grndate FROM Grn_header"
    '            M_WhereCondition = " "
    '            Dim vform As New List_Operation
    '            vform.Field = "GRNDETAILS,GRNDATE"
    '            vform.vFormatstring = "       GRN CODE       |         GRN DATE                             "
    '            vform.vCaption = "GRN CUM PURCHASE BILL HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_Grnno.Text = Trim(vform.keyfield & "")
    '                Call txt_Grnno_Validated(txt_Grnno, e)
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cmd_Grnnohelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Grnno_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Grnno.Validated
    '        Dim I, J, K As Integer
    '        Dim vString, sqlstring As String
    '        Dim vTypeseqno, Clsquantity As Double
    '        Dim vGroupseqno As Double
    '        Dim dt As New DataTable
    '        If Trim(txt_Grnno.Text) <> "" Then
    '            Try
    '                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE,ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,"
    '                sqlstring = sqlstring & " SUPPLIERDATE,ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,ISNULL(TYPECODE,'') AS TYPECODE,"
    '                sqlstring = sqlstring & " ISNULL(TYPEDESC,'') AS TYPEDESC, ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,EXCISEDATE,STOCKINDATE,ISNULL(TRUCKNUMBER,'') AS TRUCKNUMBER,"
    '                sqlstring = sqlstring & " ISNULL(CREDITDAYS,0) AS CREDITDAYS,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
    '                sqlstring = sqlstring & " ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME,ISNULL(COSTCENTERCODE,'') AS COSTCENTERCODE,ISNULL(COSTCENTERNAME,'') AS COSTCENTERNAME,"
    '                sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(REMARKS,'') AS REMARKS,"
    '                sqlstring = sqlstring & " ISNULL(VOID,'') AS VOID,ISNULL(ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(UPDATEUSER,'') AS UPDATEUSER,UPDATETIME  FROM GRN_HEADER"
    '                sqlstring = sqlstring & " WHERE GRNNO = '" & Format(Val(txt_Grnno.Text), "0000") & "' OR Grndetails='" & Trim(txt_Grnno.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "GRNHEADER")
    '                '''************************************************* SELECT record from Grn_header *********************************************''''                
    '                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
    '                    Call GridUnLock()
    '                    Cmd_Add.Text = "Update[F7]"
    '                    Me.txt_Grnno.ReadOnly = True
    '                    txt_Grnno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
    '                    dtp_Grndate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDATE")), "dd-MMM-yyyy")
    '                    txt_Supplierinvno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERINVNO"))
    '                    dtp_Supplierinvdate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERDATE")), "dd-MMM-yyyy")
    '                    txt_Suppliercode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERCODE"))
    '                    txt_Suppliername.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERNAME"))
    '                    cbo_Billingterms.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TYPECODE")) & "  " & Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TYPEDESC"))
    '                    txt_Excisepassno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("EXCISEPASSNO"))
    '                    dtp_Excisepassdate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("EXCISEDATE")), "dd-MMM-yyyy")
    '                    dtp_Stockindate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("STOCKINDATE")), "dd-MMM-yyyy")
    '                    txt_Trucknumber.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TRUCKNUMBER"))
    '                    txt_Creditdays.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("CREDITDAYS")), "0")
    '                    Txt_GLAcIn.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GLACCOUNTCODE"))
    '                    Txt_GLAcDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GLACCOUNTNAME"))
    '                    Txt_Slcode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SLCODE"))
    '                    Txt_SlDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SLNAME"))
    '                    txt_Totalamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("TOTALAMOUNT")), "0.00")
    '                    If Trim(Txt_Slcode.Text) <> "" Then
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Width = 848
    '                        grp_grnposting.Height = 80
    '                        ssgrid.Left = 72
    '                        ssgrid.Top = 272
    '                        ssgrid.Height = 280
    '                        Lbl_SubledgerCode.Visible = True
    '                        Lbl_SubledgerName.Visible = True
    '                        Txt_Slcode.Visible = True
    '                        Cmd_SlCodeHelp.Visible = True
    '                        Txt_SlDesc.Visible = True
    '                    Else
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Height = 48
    '                        grp_grnposting.Width = 848
    '                        ssgrid.Top = 240
    '                        ssgrid.Left = 72
    '                        ssgrid.Height = 264
    '                    End If
    '                    Txt_CostCenterCode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("COSTCENTERCODE"))
    '                    Txt_CostCenterDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("COSTCENTERNAME"))
    '                    If Trim(Txt_CostCenterCode.Text) <> "" And Trim(Txt_Slcode.Text) <> "" Then
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Height = 120
    '                        grp_grnposting.Width = 848
    '                        ssgrid.Top = 312
    '                        ssgrid.Left = 72
    '                        ssgrid.Height = 240
    '                        lbl_Creditdays.Top = 280
    '                        lbl_Creditdays.Left = 504
    '                        txt_Creditdays.Top = 280
    '                        txt_Creditdays.Left = 672
    '                    ElseIf Trim(Txt_CostCenterCode.Text) = "" And Trim(Txt_Slcode.Text) <> "" Then
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Width = 848
    '                        grp_grnposting.Height = 80
    '                        ssgrid.Left = 72
    '                        ssgrid.Top = 272
    '                        ssgrid.Height = 224
    '                        Lbl_SubledgerCode.Visible = True
    '                        Lbl_SubledgerName.Visible = True
    '                        Txt_Slcode.Visible = True
    '                        Cmd_SlCodeHelp.Visible = True
    '                        Txt_SlDesc.Visible = True
    '                    Else
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Height = 48
    '                        grp_grnposting.Width = 848
    '                        ssgrid.Top = 240
    '                        ssgrid.Left = 72
    '                        ssgrid.Height = 264
    '                    End If
    '                    txt_Discountamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("DISCOUNT")), "0.00")
    '                    txt_Vatamount.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("VATAMOUNT")), "0.00")
    '                    txt_Surchargeamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("SURCHARGEAMT")), "0.00")
    '                    txt_Billamount.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("BILLAMOUNT")), "0.00")
    '                    txt_Remarks.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("REMARKS"))
    '                    If Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("VOID")) = "Y" Then
    '                        Cmd_Add.Enabled = False
    '                        Cmd_Freeze.Enabled = False
    '                    End If
    '                    '''************************************************* SELECT record from Grn_details *********************************************''''                

    '                    Dim vtmpitemcode, strsql As String
    '                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,"
    '                    sqlstring = sqlstring & " ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(CATEGORY,'')AS CATEGORY,"
    '                    sqlstring = sqlstring & " ISNULL(DBLAMOUNT,0) AS DBLAMOUNT,ISNULL(DBLUOM,'') AS DBLUOM,ISNULL(HIGHRATIO,0) AS HIGHRATIO,ISNULL(VOIDITEM,'') AS VOIDITEM FROM GRN_DETAILS WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
    '                    gconnection.getDataSet(sqlstring, "GRNDETAILS")
    '                    If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
    '                        For I = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
    '                            ssgrid.SetText(1, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE")))
    '                            vtmpitemcode = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE"))
    '                            ssgrid.SetText(2, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMNAME")))
    '                            ssgrid.Col = 3
    '                            ssgrid.Row = I
    '                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM"))
    '                            ssgrid.Text = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM"))
    '                            ssgrid.SetText(4, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("QTY")))
    '                            ssgrid.SetText(5, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("RATE")), "0.00"))
    '                            ssgrid.SetText(6, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("DISCOUNT")), "0.00"))
    '                            ssgrid.SetText(7, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("AMOUNT")), "0.00"))
    '                            ssgrid.SetText(8, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("DBLAMOUNT")), "0.00"))
    '                            ssgrid.SetText(9, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("DBLUOM")))
    '                            ssgrid.SetText(10, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("HIGHRATIO")), "0.00"))
    '                            ssgrid.SetText(11, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("QTY")))
    '                            'Clsquantity = ClosingQuantity(vtmpitemcode, "MNS")
    '                            Clsquantity = ClosingQuantity(vtmpitemcode, GetMainStore())
    '                            ssgrid.SetText(12, I, Clsquantity)
    '                            CMB_CATEGORY.Text = gdataset.Tables("GRNDETAILS").Rows(J).Item("CATEGORY")
    '                            'strsql = "SELECT ISNULL(MAINCLSTOCK,0) AS MAINCLSTOCK FROM OPENINGSTOCK WHERE ITEMCODE = '" & Trim(vtmpitemcode) & "' "
    '                            'gconnection.getDataSet(strsql, "OPENINGSTOCK")
    '                            'If gdataset.Tables("OPENINGSTOCK").Rows.Count > 0 Then
    '                            '    ssgrid.SetText(12, I, gdataset.Tables("OPENINGSTOCK").Rows(0).Item(0))
    '                            'End If
    '                            J = J + 1
    '                        Next
    '                    End If
    '                    TotalCount = gdataset.Tables("GRNDETAILS").Rows.Count
    '                    ssgrid.SetActiveCell(1, 1)
    '                    sqlstring = "SELECT ISNULL(BillTerms,'') AS BillTerms,ISNULL(Percentage,0) AS Percentage,ISNULL(TaxCode,'') AS Taxcode,ISNULL(Amount,0) AS Amount,ISNULL(SlNo,0) AS SlNo,ISNULL(Formula,'')AS Formula,"
    '                    sqlstring = sqlstring & "ISNULL(Signs,'') AS Signs,ISNULL(Accode,'') AS Accode,ISNULL(Acdesc,'') AS Acdesc FROM grn_billterms WHERE  Grndetails='" & Trim(txt_Grnno.Text) & "' ORDER BY AUTOID"
    '                    gconnection.getDataSet(sqlstring, "grn_billterms")
    '                    If gdataset.Tables("grn_billterms").Rows.Count > 0 Then
    '                        For I = 1 To gdataset.Tables("grn_billterms").Rows.Count
    '                            ssgrid_billdetails.SetText(1, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("BillTerms")))
    '                            ssgrid_billdetails.SetText(2, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("Percentage")), "0.00"))
    '                            ssgrid_billdetails.SetText(3, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Taxcode")))
    '                            ssgrid_billdetails.SetText(4, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("Amount")), "0.00"))
    '                            ssgrid_billdetails.SetText(5, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("SlNo")), "0"))
    '                            ssgrid_billdetails.SetText(6, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Formula")))
    '                            ssgrid_billdetails.SetText(7, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Signs")))
    '                            ssgrid_billdetails.SetText(8, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Accode")))
    '                            ssgrid_billdetails.SetText(9, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Acdesc")))
    '                            K = K + 1
    '                        Next
    '                    End If
    '                    If gUserCategory <> "S" Then
    '                        Call GetRights()
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show("Enter valid GRN No : txt_Grnno_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                Exit Sub
    '            End Try
    '        End If
    '    End Sub
    '    Private Sub cmd_Suppliercodehelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Suppliercodehelp.Click
    '        Try
    '            gSQLString = "SELECT SLCODE,SLNAME FROM accountssubledgermaster "
    '            M_WhereCondition = " WHERE ACCODE = '" & Trim(gCreditors) & "' "
    '            Dim vform As New List_Operation
    '            vform.Field = "SLCODE,SLNAME"
    '            vform.vFormatstring = "       SLCODE                    |                      SLNAME                             "
    '            vform.vCaption = "SIDE LEDGER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_Suppliercode.Text = Trim(vform.keyfield & "")
    '                Call txt_Suppliercode_Validated(txt_Suppliercode, e)
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cmd_Suppliercodehelp_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    '    Private Sub txt_Grnno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Grnno.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If cmd_Grnnohelp.Enabled = True Then
    '                    search = Trim(txt_Grnno.Text)
    '                    Call cmd_Grnnohelp_Click(cmd_Grnnohelp, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Grnno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    Private Sub Indent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_FREEZE, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_IndentNo.Text = ""
                txt_IndentNo.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Then
                Call cmd_Exit_Click(cmd_Exit, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Then
                Call cmd_Exit_Click(cmd_Exit, e)
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Indent_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    '    Private Sub autogenerate()
    '        Try
    '            Dim sqlstring, financalyear As String
    '            Dim month As String
    '            Dim CATLEN As Integer

    '            month = UCase(Format(Now, "MMM"))
    '            gcommand = New SqlCommand
    '            financalyear = Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2)

    '            sqlstring = "SELECT ISNULL(CATEGORY,'') AS CATEGORY FROM INVENTORYITEMMASTER WHERE ISNULL(CATEGORY,'')='" & Trim(CMB_CATEGORY.Text & "") & "' GROUP BY CATEGORY"
    '            gconnection.getDataSet(sqlstring, "CATEGORY")
    '            If gdataset.Tables("CATEGORY").Rows.Count > 0 Then
    '                CATEGORY = Mid(Trim(gdataset.Tables("CATEGORY").Rows(0).Item("CATEGORY") & ""), 1, 3)
    '                CATLEN = Len(Trim(CATEGORY))
    '            Else
    '                CATLEN = 3
    '                CATEGORY = month
    '            End If
    '            sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER WHERE SUBSTRING(GRNDETAILS,5," & CATLEN & ")='" & CATEGORY & "'"
    '            '        sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER"
    '            gconnection.openConnection()
    '            gcommand.CommandText = sqlstring
    '            gcommand.CommandType = CommandType.Text
    '            gcommand.Connection = gconnection.Myconn
    '            gdreader = gcommand.ExecuteReader
    '            If gdreader.Read Then
    '                If gdreader(0) Is System.DBNull.Value Then
    '                    txt_Grnno.Text = "GRN/" & CATEGORY & "/0001/" & financalyear
    '                    gdreader.Close()
    '                    gcommand.Dispose()
    '                    gconnection.closeConnection()
    '                Else
    '                    txt_Grnno.Text = "GRN/" & CATEGORY & "/" & Format(gdreader(0) + 1, "0000") & "/" & financalyear
    '                    gdreader.Close()
    '                    gcommand.Dispose()
    '                    gconnection.closeConnection()
    '                End If
    '            Else
    '                txt_Grnno.Text = "GRN/" & CATEGORY & "/0001/" & financalyear
    '                gdreader.Close()
    '                gcommand.Dispose()
    '                gconnection.closeConnection()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : autogenerate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Calculate()
    '        Try
    '            Dim ValQty, ValRate, ValDiscount, VarTotal As Double
    '            Dim ValHighratio, ValItemamount, ValDblamount As Double
    '            Dim i As Integer
    '            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
    '                i = ssgrid.ActiveRow
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                ValQty = Val(ssgrid.Text)
    '                ssgrid.Col = 5
    '                ssgrid.Row = i
    '                ValRate = Val(ssgrid.Text)
    '                ssgrid.Col = 6
    '                ssgrid.Row = i
    '                ValDiscount = Val(ssgrid.Text)
    '                ssgrid.Col = 10
    '                ssgrid.Row = i
    '                ValHighratio = Val(ssgrid.Text())
    '                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
    '                ValDblamount = Format(Val(ValQty) * Val(ValHighratio), "0.00")
    '                If Val(ValItemamount) = 0 Then
    '                    ssgrid.SetText(7, i, "")
    '                    ssgrid.SetText(8, i, "")
    '                Else
    '                    ssgrid.SetText(7, i, Val(ValItemamount))
    '                    ssgrid.SetText(8, i, Val(ValDblamount))
    '                End If
    '                Me.txt_Totalamt.Text = 0
    '                'Me.txt_Discountamt.Text = 0
    '                Me.txt_Billamount.Text = 0
    '                ValDiscount = 0 : VarTotal = 0
    '                For i = 1 To ssgrid.DataRowCnt
    '                    ssgrid.Col = 6
    '                    ssgrid.Row = i
    '                    ValDiscount = Val(ssgrid.Text)
    '                    ssgrid.Col = 7
    '                    ssgrid.Row = i
    '                    VarTotal = Val(ssgrid.Text)
    '                    'Me.txt_Discountamt.Text = Format(Val(Me.txt_Discountamt.Text) + Val(ValDiscount), "0.00")
    '                    Me.txt_Totalamt.Text = Format(Val(Me.txt_Totalamt.Text) + Val(VarTotal), "0.00")
    '                    Me.txt_Billamount.Text = Format(Val(Me.txt_Totalamt.Text) - Val(Me.txt_Discountamt.Text), "0.00")
    '                Next i
    '                i = i - 1
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Calculate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    Private Sub checkValidation()
        Try
            boolchk = False
            '''**************************************** Check DATEVALIDATION *******************************************''
            Call Checkdatevalidate(Format(dtp_Indentdate.Value, "dd-MMM-yyyy"))
            If chkdatevalidate = False Then Exit Sub
            '''**************************************** Check GRN NO. can't be blank *******************************************''
            If Trim(txt_IndentNo.Text) = "" Then
                MessageBox.Show("INDENT NO. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_IndentNo.Focus()
                Exit Sub
            End If
            '''**************************************** Check Storecode can't be blank *******************************************''
            If Trim(TXT_FROMSTORECODE.Text) = "" Then
                MessageBox.Show("Storecode. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_storecode.Focus()
                Exit Sub
            End If
            '''**************************************** Check storedesc can't be blank *******************************************''
            If Trim(txt_FromStorename.Text) = "" Then
                MessageBox.Show("StoreDesc Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_storeDesc.Focus()
                Exit Sub
            End If
            '''**************************************** Check Type can't be blank *******************************************''
            If Trim(cbo_type.Text) = "" Then
                MessageBox.Show("Product Type Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbo_type.Focus()
                Exit Sub
            End If

            '''********************************************* Check ssgrid value can't be blank ********************************************'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 2
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 3
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 4
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 5
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 6
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If

            Next
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : checkValidation" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    '    Private Sub FillMenu()
    '        Try
    '            Dim vform As New List_Operation
    '            Dim K As Integer
    '            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
    '            gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            gSQLString = gSQLString & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '            If Trim(search) = " " Then
    '                M_WhereCondition = ""
    '            Else
    '                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
    '            End If
    '            vform.Field = " I.ITEMNAME,I.ITEMCODE"
    '            vform.vFormatstring = "    ITEMCODE    |                     ITEMNAME                    |  STOCKUOM  | PURCHASERATE | CONVUOM | HIGHRATIO |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                'For K = 1 To ssgrid.DataRowCnt
    '                '    ssgrid.Row = K
    '                '    ssgrid.Col = 1
    '                '    If Itemvalidate(ssgrid, Trim(vform.keyfield), 1) = True Then
    '                '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                '        ssgrid.Focus()
    '                '        Exit Sub
    '                '    End If
    '                'Next
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                ssgrid.Col = 3
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 9
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 10
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
    '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenu" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillMenuItem()
    '        Try
    '            Dim vform As New List_Operation
    '            Dim K As Integer
    '            Dim ssql As String
    '            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
    '            gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            gSQLString = gSQLString & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '            If Trim(search) = " " Then
    '                M_WhereCondition = ""
    '            Else
    '                M_WhereCondition = " WHERE I.ITEMNAME LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
    '            End If
    '            vform.Field = "I.ITEMNAME,I.ITEMCODE"
    '            vform.vFormatstring = "                     ITEMNAME                |   ITEMCODE    | STOCKUOM  |PURCHASERATE | CONVUOM | HIGHRATIO |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                'For K = 1 To ssgrid.DataRowCnt
    '                '    ssgrid.Row = K
    '                '    ssgrid.Col = 1
    '                '    If Itemvalidate(ssgrid, Trim(vform.keyfield1), 1) = True Then
    '                '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                '        ssgrid.Focus()
    '                '        Exit Sub
    '                '    End If
    '                'Next
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                ssgrid.Col = 3
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 9
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 10
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
    '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenuItem" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Totalamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            txt_Totalamt.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Totalamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Discountamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            If Val(txt_Discountamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '            txt_Discountamt.Text = Format(Val(txt_Discountamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    'Private Sub txt_Taxamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '    txt_Taxamt.Text = Format(Val(txt_Taxamt.Text), "0.00")
    '    'End Sub

    '    'Private Sub txt_Billamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '    txt_Billamt.Text = Format(Val(txt_Billamt.Text), "0.00")
    '    'End Sub

    '    Private Sub txt_Supplierinvno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Call supplerinvno()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Supplierinvno_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub supplerinvno()
    '        Try
    '            If Trim(txt_Supplierinvno.Text) = "" Then
    '                txt_Supplierinvno.Text = Trim(txt_Grnno.Text)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : supplerinvno" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillStore()
    '        Try
    '            Dim i As Integer
    '            sqlstring = "SELECT distinct(Storedesc) FROM StoreMaster ORDER BY Storedesc ASC"
    '            gconnection.getDataSet(sqlstring, "StoreMaster")
    '            cbo_Storelocation.Items.Clear()
    '            cbo_Storelocation.Sorted = True
    '            If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
    '                For i = 0 To gdataset.Tables("StoreMaster").Rows.Count - 1
    '                    cbo_Storelocation.Items.Add(gdataset.Tables("StoreMaster").Rows(i).Item("Storedesc"))
    '                Next i
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillStore" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    'Private Sub txt_Totalamt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Totalamt.TextChanged
    '    '    Me.txt_Billamt.Text = Format(Val(Me.txt_Taxamt.Text) + Val(Me.txt_Totalamt.Text) - Val(Me.txt_Discountamt.Text), "0.00")
    '    'End Sub

    '    'Private Sub txt_Taxamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '    Me.txt_Billamt.Text = Format(Val(Me.txt_Taxamt.Text) + Val(Me.txt_Totalamt.Text) - Val(Me.txt_Discountamt.Text), "0.00")
    '    'End Sub

    '    'Private Sub txt_Discountamt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Discountamt.TextChanged
    '    '    Me.txt_Billamt.Text = Format(Val(Me.txt_Taxamt.Text) + Val(Me.txt_Totalamt.Text) - Val(Me.txt_Discountamt.Text), "0.00")
    '    'End Sub
    '    Public Function CreateListBox()
    '        Try
    '            Listbox = New System.Windows.Forms.ListBox
    '            Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '            Listbox.Name = "ListViewHelp"
    '            Listbox.Size = New System.Drawing.Size(10, 10)
    '            Listbox.TabIndex = 29
    '            Listbox.ScrollAlwaysVisible = False
    '            Listbox.HorizontalScrollbar = False
    '            Me.Controls.Add(Listbox)
    '            Listbox.BringToFront()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : CreateListBox" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Function
    '        End Try
    '    End Function
    '    Public Function TextBoxKeydownevent(ByVal e As System.Windows.Forms.KeyEventArgs, ByVal ObjTextBox As TextBox)
    '        If e.KeyCode = Keys.Down Then
    '            Try
    '                Listbox.SelectedIndex = Listbox.SelectedIndex + 1
    '            Catch ex As Exception
    '                Listbox.SelectedIndex = 0
    '            End Try
    '        End If
    '        If e.KeyCode = Keys.Up Then
    '            Try
    '                Listbox.SelectedIndex = Listbox.SelectedIndex - 1
    '            Catch ex As Exception
    '                Listbox.SelectedIndex = Listbox.Items.Count - 1
    '            End Try
    '        End If
    '        If e.KeyCode = Keys.Enter Then
    '            ObjTextBox.Text = Listbox.SelectedItem()
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '        End If
    '        If e.KeyCode = Keys.Escape Then
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '            ObjTextBox.Focus()
    '        End If
    '    End Function
    '    Public Function TextBoxTextchangeevent(ByVal e As System.EventArgs, ByVal ObjTextBox As TextBox, ByVal Sqlstring As String, ByVal Tablename As String, ByVal ds As DataSet)
    '        Try
    '            gadapter = New SqlDataAdapter(Sqlstring, gconnection.Myconn)
    '            If ds.Tables.Contains(Tablename) = True Then
    '                ds.Tables.Remove(Tablename)
    '            End If
    '            gadapter.Fill(ds, Tablename)
    '            Call TextBoxHelp(ObjTextBox, Tablename, ds)
    '        Catch ex As Exception
    '            Exit Function
    '        End Try
    '    End Function
    '    Public Function TextBoxHelp(ByVal ObjTextBox As TextBox, ByVal Tablename As String, ByVal ds As DataSet)
    '        Dim drow As DataRow
    '        Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    '        Listbox.Location = New System.Drawing.Point(ObjTextBox.Left, ObjTextBox.Top + ObjTextBox.Height)
    '        Listbox.Size = New System.Drawing.Size(ObjTextBox.Width, 100)
    '        Listbox.Items.Clear()
    '        If ds.Tables(Tablename).Rows.Count > 0 Then
    '            For Each drow In ds.Tables(Tablename).Rows
    '                Listbox.Items.Add(drow.Item(1))
    '            Next
    '        End If
    '        Try
    '            Listbox.SelectedIndex = 0
    '        Catch ex As Exception
    '        End Try
    '    End Function

    '    Private Sub txt_Suppliername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        'If txt_Suppliername.Focus = True Then
    '        '    sqlstring = "SELECT SLCODE,SLNAME FROM accountssubledgermaster WHERE ACCODE = 'SCRS' AND SLNAME LIKE '" & Trim(txt_Suppliername.Text) & "%'"
    '        '    Call TextBoxTextchangeevent(e, txt_Suppliername, sqlstring, "MASTER", gdataset)
    '        'End If
    '    End Sub

    '    Private Sub txt_Suppliername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        'If e.KeyCode = Keys.F4 Then
    '        '    Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
    '        'Else
    '        '    Call TextBoxKeydownevent(e, txt_Suppliername)
    '        'End If
    '    End Sub

    '    Private Sub txt_Suppliername_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            If Trim(txt_Suppliername.Text) <> "" Then
    '                sqlstring = "SELECT SLCODE,SLNAME FROM accountssubledgermaster WHERE ACCODE = '" & Trim(gCreditors) & "'AND SLNAME='" & Trim(txt_Suppliername.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
    '                    txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
    '                    txt_Excisepassno.Focus()
    '                    txt_Suppliercode.ReadOnly = True
    '                Else
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliercode.ReadOnly = False
    '                    txt_Suppliername.Focus()
    '                End If
    '            Else
    '                txt_Suppliercode.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliername_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    '    Private Sub Cmd_StockGrnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnClear.Click
    '        Try
    '            Me.txt_FromDocno.Text = ""
    '            Me.txt_ToDocno.Text = ""
    '            Me.txt_FromDocno.ReadOnly = False
    '            Me.txt_FromDocno.ReadOnly = False
    '            Me.txt_FromDocno.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnClear_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnView.Click
    '        Try
    '            Dim i As Integer
    '            Dim objGrncumpurchase As New rptGrncumpurchase
    '            gPrint = False
    '            If Trim(txt_FromDocno.Text) = "" Then
    '                MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            ElseIf Trim(txt_ToDocno.Text) = "" Then
    '                MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            End If
    '            'Dim sqlstring = "SELECT ISNULL(G.GRNDETAILS,'') AS GRNDETAILS,G.GRNDATE, ISNULL(G.SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(G.SUPPLIERNAME,'') AS SUPPLIERNAME,"
    '            'sqlstring = sqlstring & " ISNULL(G.SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(G.EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(G.GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(G.GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
    '            'sqlstring = sqlstring & " ISNULL(G.TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(G.SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(G.DISCOUNT,0) AS DISCOUNT,ISNULL(G.BILLAMOUNT,0) AS BILLAMOUNT,"
    '            'sqlstring = sqlstring & " ISNULL(D.ITEMCODE,'') AS ITEMCODE, ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM, ISNULL(D.QTY,0) AS QTY, ISNULL(D.RATE,0) AS RATE, "
    '            'sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT FROM GRN_HEADER AS G INNER JOIN GRN_DETAILS AS D ON G.GRNDETAILS = D.GRNDETAILS"
    '            'sqlstring = sqlstring & " WHERE G.GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            'sqlstring = sqlstring & " ORDER BY G.GRNDETAILS,G.GRNDATE"
    '            'Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            'objGrncumpurchase.ReportDetails(sqlstring, heading, Now, Now)
    '            sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
    '            sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            'gconnection.getDataSet(sqlstring, "GRIDVIEW")
    '            'gridviewstatus = "Purchasereisterreport"
    '            'Dim griddesign As New GridDesign
    '            'griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
    '            'griddesign.MdiParent = MDIParentobj
    '            'Me.Close()
    '            'griddesign.Show()
    '            Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '            ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnView_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnprint.Click
    '        Try
    '            gPrint = True
    '            'Call Cmd_StockGrnView_Click(sender, e)
    '            Dim i As Integer
    '            Dim objGrncumpurchase As New rptGrncumpurchase
    '            If Trim(txt_FromDocno.Text) = "" Then
    '                MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            ElseIf Trim(txt_ToDocno.Text) = "" Then
    '                MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            End If
    '            'Dim sqlstring = "SELECT ISNULL(G.GRNDETAILS,'') AS GRNDETAILS,G.GRNDATE, ISNULL(G.SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(G.SUPPLIERNAME,'') AS SUPPLIERNAME,"
    '            'sqlstring = sqlstring & " ISNULL(G.SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(G.EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(G.GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(G.GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
    '            'sqlstring = sqlstring & " ISNULL(G.TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(G.SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(G.DISCOUNT,0) AS DISCOUNT,ISNULL(G.BILLAMOUNT,0) AS BILLAMOUNT,"
    '            'sqlstring = sqlstring & " ISNULL(D.ITEMCODE,'') AS ITEMCODE, ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM, ISNULL(D.QTY,0) AS QTY, ISNULL(D.RATE,0) AS RATE, "
    '            'sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT FROM GRN_HEADER AS G INNER JOIN GRN_DETAILS AS D ON G.GRNDETAILS = D.GRNDETAILS"
    '            'sqlstring = sqlstring & " WHERE G.GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            'sqlstring = sqlstring & " ORDER BY G.GRNDETAILS,G.GRNDATE"
    '            'Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            'objGrncumpurchase.ReportDetails(sqlstring, heading, Now, Now)
    '            sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
    '            sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            'gconnection.getDataSet(sqlstring, "GRIDVIEW")
    '            'gridviewstatus = "Purchasereisterreport"
    '            'Dim griddesign As New GridDesign
    '            'griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
    '            'griddesign.MdiParent = MDIParentobj
    '            'Me.Close()
    '            'griddesign.Show()
    '            Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '            ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnprint_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnexit.Click
    '        Try
    '            txt_FromDocno.Text = ""
    '            txt_ToDocno.Text = ""
    '            grp_StockGrndetails.Top = 1000
    '            Cmd_Clear_Click(Cmd_Clear, e)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnexit_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromDocno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_FromDocno.Text) = "" Then
    '                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
    '                Else
    '                    txt_FromDocno_Validated(txt_FromDocno, e)
    '                    txt_ToDocno.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_ToDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToDocno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_ToDocno.Text) = "" Then
    '                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
    '                Else
    '                    txt_ToDocno_Validated(txt_ToDocno, e)
    '                    Cmd_StockGrnView.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
    '        Try
    '            gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
    '            M_WhereCondition = " "
    '            Dim vform As New List_Operation
    '            vform.Field = "GRNDETAILS,GRNDATE"
    '            vform.vFormatstring = "          GRN CODE              |         GRN DATE                             "
    '            vform.vCaption = "GRN CUM PURCHASE BILL HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_FromDocno.Text = Trim(vform.keyfield & "")
    '                txt_ToDocno.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_FromDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_ToDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToDocno.Click
    '        Try
    '            gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
    '            M_WhereCondition = " "
    '            Dim vform As New List_Operation
    '            vform.Field = "GRNDETAILS,GRNDATE"
    '            vform.vFormatstring = "          GRN CODE              |         GRN DATE                             "
    '            vform.vCaption = "GRN CUM PURCHASE BILL HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_ToDocno.Text = Trim(vform.keyfield & "")
    '                Cmd_StockGrnView.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_ToDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_GLAcHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New List_Operation
    '            gSQLString = "SELECT accode,acdesc FROM accountsglaccountmaster"
    '            M_WhereCondition = ""
    '            vform.Field = "ACCODE,ACDESC"
    '            vform.vFormatstring = "  ACCODE                              |                      ACDESC                                "
    '            vform.vCaption = "GLACCOUNT MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_GLAcIn.Text = Trim(vform.keyfield & "")
    '                Txt_GLAcDesc.Text = Trim(vform.keyfield1 & "")
    '                Call Glaccountvalidate()
    '            Else
    '                Me.Txt_GLAcIn.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_GLAcHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Glaccountvalidate()
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                sqlstring = "SELECT slcode,slname FROM accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    Lbl_SubledgerCode.Visible = True
    '                    Lbl_SubledgerName.Visible = True
    '                    Txt_Slcode.Visible = True
    '                    Cmd_SlCodeHelp.Visible = True
    '                    Txt_SlDesc.Visible = True
    '                    slcodestatus = True
    '                    grp_grnposting.Top = 192
    '                    grp_grnposting.Height = 80
    '                    ssgrid.Left = 72
    '                    ssgrid.Top = 272
    '                    ssgrid.Height = 224
    '                    ssgrid.Focus()
    '                Else
    '                    Lbl_SubledgerCode.Visible = False
    '                    Lbl_SubledgerName.Visible = False
    '                    Txt_Slcode.Visible = False
    '                    Cmd_SlCodeHelp.Visible = False
    '                    Txt_SlDesc.Visible = False
    '                    slcodestatus = False
    '                    grp_grnposting.Top = 192
    '                    grp_grnposting.Height = 48
    '                    grp_grnposting.Width = 848
    '                    ssgrid.Top = 240
    '                    ssgrid.Left = 72
    '                    ssgrid.Height = 264
    '                    ssgrid.Focus()
    '                End If
    '                gdataset.Tables("accountssubledgermaster").Dispose()
    '                Call Costcentervalidate()
    '            Else
    '                Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Glaccountvalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Costcentervalidate()
    '        Try
    '            Dim SQLSTRING As String
    '            Dim DR As DataRow
    '            Dim i As Integer
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                SQLSTRING = "SELECT PRIMARYGROUPCODE FROM ACCOUNTTAGGING WHERE GLACCODE = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(SQLSTRING, "MASTER1")
    '                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
    '                    Lbl_CostCenterCode.Visible = True
    '                    Lbl_CostCenterDesc.Visible = True
    '                    Txt_CostCenterCode.Visible = True
    '                    Txt_CostCenterDesc.Visible = True
    '                    Cmd_CostCenterCodeHelp.Visible = True
    '                    costcentercodestatus = True
    '                    grp_grnposting.Top = 192
    '                    grp_grnposting.Width = 848
    '                    grp_grnposting.Height = 120
    '                    ssgrid.Top = 312
    '                    ssgrid.Left = 72
    '                    ssgrid.Height = 240
    '                    lbl_Creditdays.Top = 280
    '                    lbl_Creditdays.Left = 504
    '                    txt_Creditdays.Top = 280
    '                    txt_Creditdays.Left = 672
    '                    Gr = Nothing
    '                    For Each DR In gdataset.Tables("MASTER1").Rows
    '                        If Trim(Gr) = "" Then
    '                            Gr = "'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
    '                        Else
    '                            Gr = Gr & ",'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
    '                        End If
    '                    Next
    '                Else
    '                    Lbl_CostCenterCode.Visible = False
    '                    Lbl_CostCenterDesc.Visible = False
    '                    Txt_CostCenterCode.Visible = False
    '                    Txt_CostCenterDesc.Visible = False
    '                    Cmd_CostCenterCodeHelp.Visible = False
    '                    costcentercodestatus = False
    '                    If slcodestatus = True Then
    '                        grp_grnposting.Top = 192
    '                        grp_grnposting.Height = 80
    '                        ssgrid.Left = 72
    '                        ssgrid.Top = 272
    '                        ssgrid.Height = 224
    '                        Txt_Slcode.Focus()
    '                    Else
    '                        grp_grnposting.Height = 48
    '                        grp_grnposting.Width = 848
    '                        ssgrid.Top = 240
    '                        ssgrid.Left = 72
    '                        ssgrid.Height = 264
    '                        ssgrid.Focus()
    '                    End If
    '                End If
    '            Else
    '                Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Costcentervalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                sqlstring = "select accode, acdesc from accountsglaccountmaster where accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
    '                If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
    '                    Txt_GLAcDesc.Text = Trim(UCase(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("acdesc")))
    '                    If slcodestatus = True Then
    '                        Txt_Slcode.Focus()
    '                    Else
    '                        ssgrid.Focus()
    '                    End If
    '                Else
    '                    Txt_GLAcIn.Text = ""
    '                    Txt_GLAcDesc.Text = ""
    '                End If
    '                gdataset.Tables("accountsglaccountmaster").Dispose()
    '                Call Glaccountvalidate()
    '            Else
    '                Txt_GLAcIn.Text = ""
    '                Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_Slcode.Text) <> "" Then
    '                sqlstring = "SELECT slcode, sldesc from accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "' and slcode = '" & Trim(Txt_Slcode.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    Txt_Slcode.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("slcode")))
    '                    Txt_SlDesc.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("sldesc")))
    '                    If costcentercodestatus = True Then
    '                        Txt_CostCenterCode.Focus()
    '                    Else
    '                        ssgrid.Focus()
    '                    End If
    '                Else
    '                    Txt_Slcode.Text = ""
    '                    Txt_SlDesc.Text = ""
    '                End If
    '                gdataset.Tables("accountssubledgermaster").Dispose()
    '            Else
    '                Txt_Slcode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_CostCenterCode.Text) = "" Then
    '                sqlstring = "SELECT COSTCENTERCODE,COSTCENTERDESC from accountscostcentermaster where COSTCENTERCODE = '" & Trim(Txt_CostCenterCode.Text) & "' And PRIMARYGROUPCODE IN (" & Gr & ")"
    '                gconnection.getDataSet(sqlstring, "accountscostcentermaster")
    '                If gdataset.Tables("accountscostcentermaster").Rows.Count > 0 Then
    '                    Txt_CostCenterDesc.Text = Trim(UCase(gdataset.Tables("accountscostcentermaster").Rows(0).Item("COSTCENTERDESC")))
    '                    Cmd_Add.Focus()
    '                Else
    '                    Txt_CostCenterDesc.Text = ""
    '                    Txt_CostCenterCode.Text = ""
    '                End If
    '                gdataset.Tables("accountscostcentermaster").Dispose()
    '            Else
    '                Txt_CostCenterCode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Cmd_CostCenterCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New List_Operation
    '            gSQLString = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER"
    '            M_WhereCondition = " WHERE PRIMARYGROUPCODE IN (" & Gr & ")"
    '            vform.Field = "COSTCENTERCODE"
    '            vform.Field = "COSTCENTERDESC"
    '            vform.vFormatstring = "  COSTCENTERCODE                   |                          COSTCENTERDESC                                "
    '            vform.vCaption = "COSTCENTER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_CostCenterCode.Text = Trim(vform.keyfield & "")
    '                Txt_CostCenterDesc.Text = Trim(vform.keyfield1 & "")
    '                ssgrid.Focus()
    '            Else
    '                Me.Txt_Slcode.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_CostCenterCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_SlCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New List_Operation
    '            gSQLString = "SELECT slcode,sldesc FROM accountssubledgermaster"
    '            M_WhereCondition = " WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '            vform.Field = "SLCODE"
    '            vform.Field = "SLDESC"
    '            vform.vFormatstring = "  SLCODE                             |                          SLDESC                                "
    '            vform.vCaption = "SUBLEDGER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_Slcode.Text = Trim(vform.keyfield & "")
    '                Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
    '            Else
    '                Me.Txt_GLAcIn.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_SlCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_GLAcHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_SlCodeHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_CostCenterCodeHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_GLAcIn.Text) = "" Then
    '                    Call Cmd_GLAcHelp_Click(Cmd_GLAcHelp, e)
    '                Else
    '                    Call Txt_GLAcIn_Validated(sender, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_Slcode.Text) = "" Then
    '                    Call Cmd_SlCodeHelp_Click(Cmd_SlCodeHelp, e)
    '                    ssgrid.Focus()
    '                Else
    '                    Call Txt_Slcode_Validated(Txt_Slcode, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_Slcode.Text) = "" Then
    '                    Call Cmd_CostCenterCodeHelp_Click(Cmd_CostCenterCodeHelp, e)
    '                Else
    '                    Call Txt_CostCenterCode_Validated(sender, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Suppliercode.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliercode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.Validated
    '        Try
    '            If Trim(txt_Suppliercode.Text) <> "" Then
    '                sqlstring = "SELECT SLCODE,SLNAME,creditperiod FROM accountssubledgermaster WHERE ACCODE = '" & Trim(gCreditors) & "'AND SLCODE='" & Trim(txt_Suppliercode.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
    '                    txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
    '                    txt_Creditdays.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("creditperiod"))
    '                    txt_Suppliername.ReadOnly = True
    '                    cbo_Billingterms.Focus()
    '                Else
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliername.ReadOnly = False
    '                    txt_Suppliercode.Focus()
    '                End If
    '            Else
    '                txt_Suppliercode.Text = ""
    '                txt_Suppliername.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliercode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Stockindate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Stockindate.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Excisepassno.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Stockindate_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Trucknumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Trucknumber.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                grp_Excisedetails.Top = 1000
    '                txt_Suppliercode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Trucknumber_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Trucknumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Trucknumber.LostFocus
    '        Try
    '            grp_Excisedetails.Top = 1000
    '            txt_Suppliercode.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Trucknumber_LostFocus " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Supplierinvdate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            grp_Excisedetails.Top = 104
    '            grp_Excisedetails.Left = 216
    '            dtp_Stockindate.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Supplierinvdate_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub cbo_Billingterms_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Billingterms.KeyPress
    '        Try
    '            Call Blank(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                'DISABLE GLACCOUNT
    '                Txt_GLAcIn.Focus()

    '                ssgrid.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cbo_Billingterms_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillBillterms()
    '        Try
    '            Dim i As Integer
    '            sqlstring = "SELECT DISTINCT ISNULL(TYPECODE,'') AS TYPECODE,ISNULL(TYPEDESC,'') AS TYPEDESC  FROM PURCHASEBILLTERMS WHERE  ISNULL(FREEZE,'')<>'Y'"
    '            gconnection.getDataSet(sqlstring, "PURCHASEBILLTERMS")
    '            If gdataset.Tables("PURCHASEBILLTERMS").Rows.Count > 0 Then
    '                For i = 0 To gdataset.Tables("PURCHASEBILLTERMS").Rows.Count - 1 Step 1
    '                    cbo_Billingterms.Text = Trim(gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typecode")) & "  " & Trim(UCase(gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typedesc")))
    '                Next i
    '            Else
    '                cbo_Billingterms.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillBillterms " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub billingterms()
    '        Try
    '            Dim per As Double
    '            Call FillBillterms()
    '            Call Fillbilldetails()
    '            grp_Billingdetails.Top = 144
    '            grp_Billingdetails.Left = 160
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '            ssgrid_billdetails.Focus()
    '            ssgrid_billdetails.SetActiveCell(2, 2)
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = 2
    '            ssgrid_billdetails.Text = Format(Val(txt_Discountamt.Text), "0.00")
    '            per = (Val(txt_Discountamt.Text) * 100) / Val(txt_Totalamt.Text)
    '            ssgrid_billdetails.Col = 2
    '            ssgrid_billdetails.Row = 2
    '            ssgrid_billdetails.Text = per
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = billrow
    '            ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingterms" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Remarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Remarks.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                Call billingterms()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Remarks_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Fillbilldetails()
    '        Try
    '            Dim i, j As Integer
    '            Dim typecode() As String
    '            typecode = Split(Trim(cbo_Billingterms.Text), "  ")
    '            sqlstring = "SELECT ISNuLL(Billdescription,'') As Billdescription,ISNULL(slno,0) AS SLNO,FORMULA,SIGNS,ISNULL(Accode,'') AS ACCODE ,ISNULL(Acdesc,'') AS ACDESC FROM purchasebillterms WHERE  Typecode = '" & Trim(typecode(0)) & "' AND ISNULL(Freeze,'')<>'Y'"
    '            gconnection.getDataSet(sqlstring, "purchasebillterms")
    '            j = 2
    '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                ssgrid_billdetails.SetText(1, 1, "BASIC" & "  " & ":")
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 2
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 3
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                For i = 0 To gdataset.Tables("purchasebillterms").Rows.Count - 1 Step 1
    '                    ssgrid_billdetails.SetText(1, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("Billdescription")) & "  " & ":")
    '                    ssgrid_billdetails.SetText(5, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SLNO")))
    '                    ssgrid_billdetails.SetText(6, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("FORMULA")))
    '                    ssgrid_billdetails.SetText(7, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SIGNS")))
    '                    ssgrid_billdetails.SetText(8, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACCODE")))
    '                    ssgrid_billdetails.SetText(9, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACDESC")))
    '                    j = j + 1
    '                Next i
    '                ssgrid_billdetails.SetText(1, j, "BILL AMOUNT" & "  " & ":")
    '                billrow = j
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 2
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 3
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.SetActiveCell(2, 2)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Fillbilldetails " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub billingtermsrefresh(ByVal Activerow As Integer)
    '        Try
    '            Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, BillAmount, Batchno, Avgrate, Avgquantity As Double
    '            Dim dblBasic, dblDiscount, dblExcise, dblVAT, dblSurchase, dblTranportation, dblOthpostcharge, dblOthNegcharge As Double
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double

    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Col = 4
    '            amt = Val(ssgrid_billdetails.Text)

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '            ssgrid_billdetails.Text = amt

    '            dblBasic = Format(Val(ssgrid_billdetails.Text), "0.00")

    '            For i = 2 To ssgrid_billdetails.DataRowCnt - 1
    '                ssgrid_billdetails.Row = i
    '                ssgrid_billdetails.Col = 7
    '                Sign = ssgrid_billdetails.Text

    '                ssgrid_billdetails.Col = 4
    '                Gramt = Val(ssgrid_billdetails.Text)

    '                If Sign = "+" Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '                    ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) + Val(Gramt), "0.00")
    '                End If

    '                If Sign = "-" Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '                    Bamt = ssgrid_billdetails.Text
    '                    ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) - Val(Gramt), "0.00")
    '                End If

    '                ssgrid_billdetails.Row = i
    '                ssgrid_billdetails.Col = 1
    '                If Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BAS" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblBasic = dblBasic + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "DIS" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblDiscount = dblDiscount + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "EXC" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblExcise = dblExcise + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "V.A" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblVAT = dblVAT + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "SUR" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblSurchase = dblSurchase + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "TRA" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblTranportation = dblTranportation + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (+)" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblOthpostcharge = dblOthpostcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (-)" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblOthNegcharge = dblOthNegcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BIL" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        BillAmount = BillAmount + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                End If
    '            Next i

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '            BillAmount = Format(Val(ssgrid_billdetails.Text), "0.00")

    '            txt_Totalamt.Text = Format(dblBasic, "0.00")
    '            txt_Vatamount.Text = Format(dblVAT + dblExcise, "0.00")
    '            txt_Surchargeamt.Text = Format(dblSurchase + dblOthpostcharge + dblTranportation, "0.00")
    '            txt_Discountamt.Text = Format(dblDiscount + dblOthNegcharge, "0.00")
    '            txt_Billamount.Text = Format(BillAmount, "0.00")
    '            ssgrid_billdetails.Row = Activerow
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingtermsrefresh " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub billingtermstaxamount(ByVal Activerow)
    '        'new
    '        Try
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double

    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Col = 4
    '            amt = Val(ssgrid_billdetails.Text)

    '            ssgrid_billdetails.Row = Activerow
    '            ssgrid_billdetails.Col = 2
    '            per = Val(ssgrid_billdetails.Text)
    '            ssgrid_billdetails.Col = 7
    '            Sign = ssgrid_billdetails.Text

    '            ssgrid_billdetails.Col = 6
    '            Formula = ssgrid_billdetails.Text
    '            Formule = Formula.ToCharArray

    '            Gtot = 0
    '            ssgrid_billdetails.Row = Activerow
    '            ssgrid_billdetails.Col = 2
    '            per = Val(ssgrid_billdetails.Text)

    '            For II = 1 To Formule.Length - 1
    '                For J = 2 To ssgrid_billdetails.DataRowCnt
    '                    ssgrid_billdetails.Col = 5
    '                    ssgrid_billdetails.Row = J
    '                    If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
    '                        ssgrid_billdetails.Col = 4
    '                        Gtot = Gtot + Val(ssgrid_billdetails.Text)
    '                        Exit For
    '                    End If
    '                Next J
    '            Next II
    '            Camt = ((Gtot + amt) * per) / 100
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = Activerow
    '            If Camt > 0 Then
    '                ssgrid_billdetails.Text = Format(Val(Camt), "0.00")
    '            Else
    '                ssgrid_billdetails.Text = 0.0
    '            End If
    '            Call billingtermsrefresh(Activerow)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingtermstaxamount" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '        'end new
    '    End Sub
    '    Private Sub BillingTermsTaxPercentage(ByVal Activerow)
    '        'new
    '        Try
    '            Dim Sign, Formula, slno, Billdesc() As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double


    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Col = 4
    '            amt = Val(ssgrid_billdetails.Text)

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = billrow
    '            ssgrid_billdetails.Text = Format(amt, "0.00")

    '            ssgrid_billdetails.Row = Activerow
    '            ssgrid_billdetails.Col = 2
    '            per = ssgrid_billdetails.Text
    '            ssgrid_billdetails.Col = 7
    '            Sign = ssgrid_billdetails.Text

    '            ssgrid_billdetails.Col = 6
    '            Formula = ssgrid_billdetails.Text
    '            Formule = Formula.ToCharArray

    '            Gtot = 0
    '            For II = 1 To Formule.Length - 1
    '                For J = 2 To ssgrid_billdetails.DataRowCnt
    '                    ssgrid_billdetails.Col = 5
    '                    ssgrid_billdetails.Row = J
    '                    If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
    '                        ssgrid_billdetails.Col = 4
    '                        Gtot = Gtot + Val(ssgrid_billdetails.Text)
    '                        Exit For
    '                    End If
    '                Next J
    '            Next II


    '            ssgrid_billdetails.Col = 1
    '            ssgrid_billdetails.Row = Activerow
    '            Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

    '            sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '            gconnection.getDataSet(sqlstring, "purchasebillterms")
    '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" <> "Y" Then
    '                    GrTot = Gtot + amt
    '                    ssgrid_billdetails.Row = Activerow
    '                    ssgrid_billdetails.Col = 2
    '                    If Gtot > 0 Then
    '                        ssgrid_billdetails.Col = 4
    '                        Gtot = Val(ssgrid_billdetails.Text)
    '                        ssgrid_billdetails.Col = 2
    '                        ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
    '                    Else
    '                        If GrTot > 0 Then
    '                            ssgrid_billdetails.Col = 4
    '                            Gtot = Val(ssgrid_billdetails.Text)
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
    '                        Else
    '                            ssgrid_billdetails.Text = 0.0
    '                        End If
    '                    End If
    '                    Call billingtermsrefresh(Activerow)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : BillingTermsTaxPercentage" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_billdetails_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_billdetails.KeyDownEvent
    '        Try
    '            Dim Taxcode, Billdesc(), Sqlstring As String

    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double
    '            If e.keyCode = Keys.Enter Or e.keyCode = Keys.Tab Then
    '                If ssgrid_billdetails.ActiveCol = 1 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    If Trim(ssgrid_billdetails.Text) <> "" Then
    '                        ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 2 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

    '                    Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '                    gconnection.getDataSet(Sqlstring, "purchasebillterms")
    '                    If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                        If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            ssgrid_billdetails.Lock = True
    '                            ssgrid_billdetails.Text = "0.00"
    '                            ssgrid_billdetails.Col = 3
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            ssgrid_billdetails.Text = ""
    '                            ssgrid_billdetails.Lock = False
    '                            ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                        Else
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            If Val(ssgrid_billdetails.Text) = 0 Then
    '                                ssgrid_billdetails.Text = "0.00"
    '                                ssgrid_billdetails.Col = 4
    '                                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                ssgrid_billdetails.Text = "0.00"
    '                                ssgrid_billdetails.Lock = False
    '                                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            Else
    '                                ssgrid_billdetails.Col = 4
    '                                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                                ssgrid_billdetails.Lock = False
    '                                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            End If
    '                        End If
    '                        Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 3 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")
    '                    Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '                    gconnection.getDataSet(Sqlstring, "purchasebillterms")
    '                    If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                        If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
    '                            ssgrid_billdetails.Col = 3
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            If Trim(ssgrid_billdetails.Text) = "" Then
    '                                Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
    '                                Exit Sub
    '                            Else
    '                                Taxcode = Trim(ssgrid.Text)
    '                                Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
    '                                gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
    '                                If gdataset.Tables("AccountsTaxMaster").Rows.Count = 0 Then
    '                                    Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
    '                                    gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
    '                                End If
    '                                If gdataset.Tables("AccountsTaxMaster").Rows.Count > 0 Then
    '                                    ssgrid_billdetails.Col = 2
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxpercentage") & "")
    '                                    ssgrid_billdetails.Col = 3
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxcode") & "")
    '                                    ssgrid_billdetails.Col = 8
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTIN") & "")
    '                                    ssgrid_billdetails.Col = 9
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTDESC") & "")
    '                                    gdataset.Tables("AccountsTaxMaster").Dispose()
    '                                Else
    '                                    Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
    '                                End If
    '                            End If
    '                        End If
    '                        Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 4 Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '                    ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow + 1)
    '                End If
    '            End If

    '            If e.keyCode = Keys.F4 Then
    '                If ssgrid_billdetails.ActiveCol = 3 Then
    '                    If ssgrid_billdetails.Lock = False Then
    '                        search = Nothing
    '                        ssgrid.GetText(2, ssgrid.ActiveRow, search)
    '                        Dim vform As New List_Operation
    '                        gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
    '                        M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
    '                        vform.Field = "TAXCODE,TAXDESC"
    '                        vform.vFormatstring = "           TAXCODE            |                  TAX DESCRIPTION         |       TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
    '                        vform.vCaption = "TAX MASTER HELP"
    '                        vform.KeyPos = 0
    '                        vform.KeyPos1 = 1
    '                        vform.KeyPos2 = 2
    '                        vform.Keypos3 = 3
    '                        vform.keypos4 = 4
    '                        vform.Keypos5 = 5
    '                        vform.ShowDialog(Me)
    '                        If Trim(vform.keyfield & "") <> "" Then
    '                            ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
    '                            ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
    '                            ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
    '                            ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
    '                            Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                            ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            Taxcode = Trim(vform.keyfield & "")
    '                        Else
    '                            ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
    '                            ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
    '                            Taxcode = ""
    '                        End If
    '                        vform.Close()
    '                        vform = Nothing
    '                        Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_billdetails_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillTaxmaster()
    '        Try
    '            Dim ACHEAD As String
    '            search = Nothing
    '            ssgrid.GetText(2, ssgrid.ActiveRow, search)
    '            Dim vform As New List_Operation
    '            gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
    '            M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
    '            vform.Field = "TAXCODE,TAXDESC"
    '            vform.vFormatstring = "           TAXCODE       |             TAX DESCRIPTION         |    TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
    '            vform.vCaption = "TAX MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
    '                ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
    '                ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
    '                ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
    '                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                ACHEAD = Trim(vform.keyfield & "")
    '            Else
    '                ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
    '                ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
    '                ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                ACHEAD = ""
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillTaxmaster " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_billdetails_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid_billdetails.LeaveCell
    '        Try
    '            Dim Taxcode, Billdesc(), Sqlstring As String
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double
    '            If ssgrid_billdetails.ActiveCol = 1 Then
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                If Trim(ssgrid_billdetails.Text) <> "" Then
    '                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                Else
    '                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                End If
    '            ElseIf ssgrid_billdetails.ActiveCol = 2 Then
    '                Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '            ElseIf ssgrid_billdetails.ActiveCol = 3 Then
    '                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '            ElseIf ssgrid_billdetails.ActiveCol >= 4 Then
    '                Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_billdetails_LeaveCell " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub GridLock()
    '        Try
    '            Dim Row, Col As Integer
    '            ssgrid.Col = 6
    '            ssgrid.Row = ssgrid.ActiveRow
    '            For Row = 1 To 50
    '                For Col = 1 To 6
    '                    ssgrid.Row = Row
    '                    ssgrid.Col = Col
    '                    ssgrid.Lock = True
    '                Next
    '            Next
    '            ssgrid.Row = 1
    '            For Col = 1 To 6
    '                ssgrid.Col = Col
    '                ssgrid.Lock = False
    '            Next
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : GridLock " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub GridUnLock()
    '        Try
    '            Dim i, j As Integer
    '            For i = 1 To 100
    '                For j = 1 To 6
    '                    ssgrid.Col = j
    '                    ssgrid.Row = i
    '                    ssgrid.Lock = False
    '                Next j
    '            Next i
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error :  GridUnLock" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
    '        Dim ItemQty, ItemAmount, ItemRate, Highratio, Dblamount As Double
    '        Dim sqlstring, Itemcode, Itemdesc As String
    '        Dim focusbool As Boolean
    '        Dim VaritemDesc As String
    '        Dim i, j, K As Integer
    '        search = Nothing
    '        Try
    '            If e.keyCode = Keys.Enter Then
    '                i = ssgrid.ActiveRow
    '                If ssgrid.ActiveCol = 1 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = 1
    '                    VaritemDesc = Trim(ssgrid.Text)
    '                    ssgrid.Col = 1
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
    '                        ElseIf Trim(ssgrid.Text) <> "" Then
    '                            If VaritemDesc = "" Then
    '                                Itemcode = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
    '                                sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '                                sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' AND STORECODE='MNS' "
    '                                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
    '                                If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    'For K = 1 To ssgrid.DataRowCnt
    '                                    '    ssgrid.Row = K
    '                                    '    ssgrid.Col = 1
    '                                    '    If Itemvalidate(ssgrid, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), 1) = True Then
    '                                    '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                                    '        ssgrid.Focus()
    '                                    '        Exit Sub
    '                                    '    End If
    '                                    'Next
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.Col = 3
    '                                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
    '                                    ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(9, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    ssgrid.SetText(10, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 2 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
    '                        Else
    '                            ssgrid.Col = 4
    '                            ssgrid.Row = i
    '                            If Trim(ssgrid.Text) = "" Then
    '                                Itemdesc = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC  $ **************************************'''
    '                                sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '                                sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
    '                                gconnection.getDataSet(sqlstring, "inventoryitemMaster")
    '                                If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    'For K = 1 To ssgrid.DataRowCnt
    '                                    '    ssgrid.Row = K
    '                                    '    ssgrid.Col = 1
    '                                    '    If Itemvalidate(ssgrid, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), 1) = True Then
    '                                    '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                                    '        ssgrid.Focus()
    '                                    '        Exit Sub
    '                                    '    End If
    '                                    'Next
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.Col = 3
    '                                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
    '                                    ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(9, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    ssgrid.SetText(10, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 3 Then
    '                    ssgrid.Col = 3
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 4 Then
    '                    ssgrid.Col = 4
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                        Else
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                            ssgrid.Focus()
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 5 Then
    '                    ssgrid.Col = 5
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                        Else
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                            ssgrid.Focus()
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 6 Then
    '                    ssgrid.Col = 6
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.Col = 6
    '                            ssgrid.Row = ssgrid.ActiveRow
    '                            ssgrid.Text = "0.00"
    '                            ssgrid.Row = ssgrid.ActiveRow + 1
    '                            ssgrid.Col = 1
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 2
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 3
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 4
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 5
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 6
    '                            ssgrid.Lock = False
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        Else
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.Row = ssgrid.ActiveRow + 1
    '                            ssgrid.Col = 1
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 2
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 3
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 4
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 5
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 6
    '                            ssgrid.Lock = False
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 7 Then
    '                    ssgrid.Col = 7
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 8 Then
    '                    ssgrid.Col = 8
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 9 Then
    '                    ssgrid.Col = 9
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 10 Then
    '                    ssgrid.Col = 3
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                End If
    '            ElseIf e.keyCode = Keys.F4 Then
    '                If ssgrid.ActiveCol = 1 Then
    '                    ssgrid.Col = 1
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        ssgrid.Col = 1
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        search = Trim(ssgrid.Text)
    '                        Call FillMenu()
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 2 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        ssgrid.Col = 2
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        search = Trim(ssgrid.Text)
    '                        Call FillMenuItem()
    '                    End If
    '                End If
    '            ElseIf e.keyCode = Keys.F3 Then
    '                ssgrid.Col = ssgrid.ActiveCol
    '                ssgrid.Row = i
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.ClearRange(1, ssgrid.ActiveRow, 15, ssgrid.ActiveRow, True)
    '                ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
    '                Call Calculate()
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Col = 1
    '                ssgrid.Lock = False
    '                ssgrid.Col = 2
    '                ssgrid.Lock = False
    '                ssgrid.Col = 3
    '                ssgrid.Lock = False
    '                ssgrid.Col = 4
    '                ssgrid.Lock = False
    '                ssgrid.Col = 5
    '                ssgrid.Lock = False
    '                ssgrid.Col = 6
    '                ssgrid.Lock = False
    '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
    '        Dim ItemQty, ItemAmount, ItemRate, Highratio, Dblamount, DblQty As Double
    '        Dim sqlstring, Itemcode, Itemdesc As String
    '        Dim discount, quantity As Double
    '        Dim focusbool As Boolean
    '        Dim i, j As Integer
    '        Dim vitemdesc As String
    '        search = Nothing
    '        Try
    '            i = ssgrid.ActiveRow
    '            If ssgrid.ActiveCol = 2 Then
    '                ssgrid.Col = 2
    '                ssgrid.Row = i
    '                vitemdesc = Trim(ssgrid.Text)
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                DblQty = Val(ssgrid.Text)
    '                ssgrid.Col = 2
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) <> "" Then
    '                        If vitemdesc = "" Then
    '                            If Val(DblQty) = 0 Then
    '                                Itemdesc = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC  $ **************************************'''
    '                                sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '                                sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
    '                                gconnection.getDataSet(sqlstring, "inventoryitemMaster")
    '                                If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(9, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    ssgrid.SetText(10, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 3 Then
    '                ssgrid.Col = 3
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 4 Then
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Val(ssgrid.Text) = 0 Then
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    Else
    '                        Call Calculate() '''--> Calculate total amount
    '                        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 6 Then
    '                ssgrid.Col = 6
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Val(ssgrid.Text) = 0 Then
    '                        Call Calculate() '''--> Calculate total amount
    '                        ssgrid.Col = 6
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        ssgrid.Text = "0.00"
    '                        ssgrid.Row = ssgrid.ActiveRow + 1
    '                        ssgrid.Col = 1
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 2
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 3
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 4
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 5
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 6
    '                        ssgrid.Lock = False
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    Else
    '                        Call Calculate() '''--> Calculate total amount
    '                        ssgrid.Row = ssgrid.ActiveRow + 1
    '                        ssgrid.Col = 1
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 2
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 3
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 4
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 5
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 6
    '                        ssgrid.Lock = False
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 7 Then
    '                ssgrid.Col = 7
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 8 Then
    '                ssgrid.Col = 8
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 9 Then
    '                ssgrid.Col = 9
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 10 Then
    '                ssgrid.Col = 3
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_LeaveCell " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            If Val(txt_Vatamount.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_TextChanged " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Surchargeamt.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Discountamt.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Discountamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                Cmd_Add.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            If Val(txt_Surchargeamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Discountamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            If Val(txt_Discountamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            txt_Vatamount.Text = Format(Val(txt_Vatamount.Text), "0.00")
    '            If Val(txt_Vatamount.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            txt_Surchargeamt.Text = Format(Val(txt_Surchargeamt.Text), "0.00")
    '            If Val(txt_Surchargeamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Indent_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '        Try
    '            GRNCumPurchaseBillTransbool = False
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Indent_Closed" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromDocno.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If Cmd_FromDocno.Enabled = True Then
    '                    search = Trim(txt_FromDocno.Text)
    '                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_ToDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToDocno.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If Cmd_ToDocno.Enabled = True Then
    '                    search = Trim(txt_ToDocno.Text)
    '                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
    '        If Trim(txt_FromDocno.Text) <> "" Then
    '            Try
    '                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
    '                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_FromDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_FromDocno.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "GRNHEADER")
    '                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
    '                    Me.txt_FromDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
    '                    Me.txt_FromDocno.ReadOnly = True
    '                End If
    '            Catch
    '                Exit Sub
    '            End Try
    '        End If
    '    End Sub

    '    Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
    '        If Trim(txt_ToDocno.Text) <> "" Then
    '            Try
    '                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
    '                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_ToDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_ToDocno.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "GRNHEADER")
    '                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
    '                    Me.txt_ToDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
    '                    Me.txt_ToDocno.ReadOnly = True
    '                End If
    '            Catch
    '                Exit Sub
    '            End Try
    '        End If
    '    End Sub
    '    Private Sub CMB_CATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Call autogenerate()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
    '        Try
    '            gPrint = True
    '            Call printoperation()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cmd_print_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub CMB_CATEGORY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
    '                Call autogenerate()
    '                dtp_Grndate.Focus()
    '                CMB_CATEGORY.Enabled = False
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : CMB_CATEGORY_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Add.Click
        Try
            Dim Totalamt, totalqty, Avgrate, AvgQuantity As Double
            Dim sqlstring, Itemcode, Insert(0), docno1 As String
            Dim dblval, dblqty As Double
            Dim i, j As Integer
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub

            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            '''*********************************************************** Case-1 : Add [F7] *******************************************'''
            If cmd_Add.Text = "Add [F7]" Then
                Call lastindent()
                txt_IndentNo.Text = LastIndentNo
                'docno1 = Split(Trim(txt_Docno.Text), "/")
                sqlstring = "INSERT INTO INVENTORY_INDENTHDR(INDENT_NO,INDENT_DATE,fromStoreCode,Storelocationcode,Storelocationname,Product_type, "
                sqlstring = sqlstring & " Remarks,Void,Adduser,Adddatetime,updfooter,updsign)"
                sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                sqlstring = sqlstring & " '" & Trim(TXT_FROMSTORECODE.Text) & "','" & Trim(txt_storecode.Text) & "',"
                sqlstring = sqlstring & " '" & Trim(txt_storeDesc.Text) & "','" & Trim(cbo_type.Text) & "',"
                sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N',"
                sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '" & Trim(CStr(Txt_footer.Text)) & "','" & Trim(Txt_signature.Text) & "')"
                Insert(0) = sqlstring
                '''******************************************************** Insert into Indentdet **********************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    sqlstring = "INSERT INTO INVENTORY_INDENTDET(INDENT_NO,INDENT_DATE,Itemcode,Itemname,Uom,Qty,Rate,Amount,CLSQTY,"
                    sqlstring = sqlstring & " VOID,Adduser,adddatetime)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"

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
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","

                    sqlstring = sqlstring & "'N',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next i
                gconnection.MoreTrans(Insert)
                cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call cmd_Print_Click(cmd_View, e)
                    Call cmd_Clear_Click(sender, e)
                Else
                    Call cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
                'docno1 = Split(Trim(txt_Docno.Text), "/")
                'Dim CURQTY, PREVQTY, CLSQTY, VDIFF As Double
                'For i = 1 To ssgrid.DataRowCnt
                '    ssgrid.Row = i
                '    ssgrid.Col = 4
                '    CURQTY = Val(ssgrid.Text)
                '    ssgrid.Col = 12
                '    PREVQTY = Val(ssgrid.Text)
                '    ssgrid.Col = 13
                '    CLSQTY = Val(ssgrid.Text)
                '    VDIFF = Val(CLSQTY) + Val(PREVQTY) - Val(CURQTY)
                '    If Val(VDIFF) < 0 Then
                '        MessageBox.Show("STOCK IS NOT SUFFICIENT TO  MODIFY...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        ssgrid.Col = 4
                '        'ssgrid.Text = ""
                '        ssgrid.SetActiveCell(4, i)
                '        ssgrid.Focus()
                '        'SendKeys.Send("{home}+{end}")
                '        Exit Sub
                '    End If
                'Next
                ''''*************************************
                sqlstring = "UPDATE INVENTORY_INDENTHDR SET INDENT_DATE='" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "', "
                sqlstring = sqlstring & " fromStorecode='" & Trim(TXT_FROMSTORECODE.Text) & "',"
                sqlstring = sqlstring & " Storelocationcode='" & Trim(txt_storecode.Text) & "',"
                sqlstring = sqlstring & " Storelocationname='" & Trim(txt_storeDesc.Text) & "',"
                sqlstring = sqlstring & " PRODUCT_TYPE ='" & cbo_type.Text & "',"
                sqlstring = sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,Void='N',"
                sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & "',"
                sqlstring = sqlstring & " updfooter='" & Trim(CStr(Txt_footer.Text)) & "',"
                sqlstring = sqlstring & " updsign='" & Trim(Txt_signature.Text) & "',"
                sqlstring = sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE INDENT_NO='" & Trim(txt_IndentNo.Text) & "' "
                Insert(0) = sqlstring
                '''********************************************************* DELETE FROM stockissuedetail *****************************************************'''
                sqlstring = "DELETE FROM INVENTORY_INDENTDET WHERE INDENT_NO='" & Trim(txt_IndentNo.Text) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''******************************************************** INSERT INTO stockissuedetail ******************************************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    sqlstring = "INSERT INTO INVENTORY_INDENTDET(INDENT_NO,INDENT_DATE,Itemcode,Itemname,Uom,Qty,Rate,Amount,CLSQTY,"
                    sqlstring = sqlstring & " VOID,UPDATEUSER,UPdatetime)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"

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
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","

                    sqlstring = sqlstring & "'N',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next i
                gconnection.MoreTrans(Insert)
                cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    If Trim(txt_IndentNo.Text) <> "" Then
                        txt_FromDocno.Text = Trim(txt_IndentNo.Text)
                        txt_ToDocno.Text = Trim(txt_IndentNo.Text)
                    End If
                    Call cmd_Print_Click(cmd_View, e)
                    Call cmd_Clear_Click(sender, e)
                Else
                    Call cmd_Clear_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, clsquantiy As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty, varqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Then
                i = ssgrid.ActiveRow
                ssgrid.Col = 4
                ssgrid.Row = i
                ValQty = Val(ssgrid.Text)
                ssgrid.Col = 5
                ssgrid.Row = i
                ValRate = Val(ssgrid.Text)
                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
                If Val(ValItemamount) = 0 Then
                    ssgrid.SetText(6, i, "")
                    ssgrid.SetText(7, i, "")
                Else
                    ssgrid.SetText(6, i, Val(ValItemamount))
                End If
                ssgrid.Col = 2
                ssgrid.Row = i
                Me.txt_Totalamount.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1
                varqty = 0
                Me.txt_qty.Text = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    varqty = Val(ssgrid.Text)
                    Me.txt_qty.Text = Format(Val(Me.txt_qty.Text) + Val(varqty), "0.00")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim i, j, k As Integer
        Dim Rate, clsquantity, AMOUNT As Double
        Dim Itemcode, Itemdesc, ClsItem, Clsq As String
        Try
            If e.keyCode = Keys.Enter Then
                i = ssgrid.ActiveRow
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        Dim temp, TEMP1 As String
                        temp = 0
                        TEMP1 = ""
                        ssgrid.Col = 1
                        ssgrid.Row = i

                        'TEMP1 = ssgrid.Text
                        'If Trim(TEMP1) <> "" Then
                        '    ssgrid.SetText(5, i, (CalAverageRate_new(Trim(TEMP1), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)))
                        'End If

                        ssgrid.Col = 4
                        ssgrid.Row = i
                        temp = ssgrid.Text

                        ssgrid.Col = 1
                        ssgrid.Row = i
                        If Val(temp) = 0 Then
                            If Trim(ssgrid.Text) = "" Then
                                Call fillmenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                            Else
                                Itemcode = Trim(ssgrid.Text)
                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                sqlstring = " SELECT   ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM "
                                sqlstring = sqlstring & "FROM INVENTORYITEMMASTER AS I "
                                sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")

                                If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                    If Mid(MyCompanyName, 1, 4) <> "HIND" Then
                                        Call check_Duplicate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                        If Dupchk = True Then
                                            ssgrid.Focus()
                                            Exit Sub
                                        End If
                                    End If
                                    Call GridUOM(i) '''---> Fill the UOM feild
                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))

                                    'For k = 1 To ssgrid.DataRowCnt
                                    '    ssgrid.Row = k
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
                                    'Rate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                    If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                                        Rate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                    Else
                                        Rate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                    End If
                                    ssgrid.SetText(5, i, Format(Val(Rate), "0.00"))
                                    'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), GetMainStore())
                                    If Trim(txt_storecode.Text) <> "" Then
                                        'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text)
                                        clsquantity = ClosingQuantity_New(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text, dtp_Indentdate.Value)
                                    Else
                                        clsquantity = 0
                                    End If

                                    'lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                                    ssgrid.SetText(7, i, Format(Val(clsquantity), "0.000"))
                                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                    Call GridRowLock(i)
                                    ssgrid.Focus()
                                    Call SelectText()
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                    ssgrid.Text = ""
                                    ssgrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        Else
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                            Call SelectText()
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
                            sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM "
                            sqlstring = sqlstring & " FROM INVENTORYITEMMASTER AS I"
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
                                'Rate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                'Rate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                                    Rate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                Else
                                    Rate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                End If
                                ssgrid.SetText(5, i, Format(Val(Rate), "0.00"))
                                'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), GetMainStore())
                                If Trim(txt_storecode.Text) <> "" Then
                                    'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text)
                                    clsquantity = ClosingQuantity_New(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text, dtp_Indentdate.Value)
                                Else
                                    clsquantity = 0
                                End If
                                'lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                                ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
                                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                Call GridRowLock(i)
                            Else
                                MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 4 Then
                    ssgrid.Col = 4
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Val(ssgrid.Text) = 0 Then
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                        Else
                            Call Calculate() '''CALC TOTAL AMOUNT
                            ssgrid.Col = 5
                            Rate = ssgrid.Text
                            ssgrid.Col = 4
                            'AMOUNT = ssgrid.Text * Rate
                            'ssgrid.SetText(6, i, AMOUNT)
                            'ssgrid.Row = ssgrid.ActiveRow + 1
                            ssgrid.Col = 1
                            ssgrid.Row = i
                            ClsItem = ssgrid.Text
                            If Trim(txt_storecode.Text) <> "" Then
                                'If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                '    clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text)
                                'Else
                                'clsquantity = ClosingQuantity(Trim(ClsItem), TXT_FROMSTORECODE.Text)
                                clsquantity = ClosingQuantity_New(Trim(ClsItem), TXT_FROMSTORECODE.Text, dtp_Indentdate.Value)
                                'End If
                            Else
                                clsquantity = 0
                            End If
                            For i = 1 To ssgrid.DataRowCnt
                                ssgrid.Col = 1
                                ssgrid.Row = i
                                If ClsItem = ssgrid.Text Then
                                    ssgrid.Col = 4
                                    ssgrid.Row = i
                                    Clsq = Clsq + Val(ssgrid.Text)
                                End If
                            Next i
                            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity - Clsq), "0.000"))
                            'ssgrid.Col = 1
                            'ssgrid.Lock = False
                            'ssgrid.Col = 2
                            'ssgrid.Lock = False
                            'ssgrid.Col = 3
                            'ssgrid.Lock = False
                            'ssgrid.Col = 4
                            'ssgrid.Lock = False
                            'ssgrid.Col = 5
                            'ssgrid.Lock = False
                            'ssgrid.Col = 6
                            'ssgrid.Lock = False
                            ssgrid.Col = 4
                            ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                            End If
                    End If
                ElseIf ssgrid.ActiveCol = 5 Then
                    'ssgrid.Col = 5
                    'i = ssgrid.ActiveRow
                    'ssgrid.Row = i
                    'If ssgrid.Lock = False Then
                    '    If Val(ssgrid.Text) = 0 Then
                    '        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    '    Else
                    '        'Call Calculate() '''--> Calculate total amount
                    '        'ssgrid.Row = ssgrid.ActiveRow + 1
                    '        'ssgrid.Col = 1
                    '        'ssgrid.Lock = False
                    '        'ssgrid.Col = 2
                    '        'ssgrid.Lock = False
                    '        'ssgrid.Col = 3
                    '        'ssgrid.Lock = False
                    '        'ssgrid.Col = 4
                    '        'ssgrid.Lock = False
                    '        'ssgrid.Col = 5
                    '        'ssgrid.Lock = False
                    '        'ssgrid.Col = 6
                    '        'ssgrid.Lock = False
                    '        'ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                    '    End If
                    'End If
                ElseIf ssgrid.ActiveCol = 6 Then
                    'ssgrid.Col = 6
                    'i = ssgrid.ActiveRow
                    'ssgrid.Row = i
                    'If ssgrid.Lock = False Then
                    '    If Val(ssgrid.Text) = 0 Then
                    '        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                    '    Else
                    '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                    '    End If
                    'Else
                    '    ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    'End If
                ElseIf ssgrid.ActiveCol = 7 Then
                    'ssgrid.Col = 7
                    'i = ssgrid.ActiveRow
                    'ssgrid.Row = i
                    'If ssgrid.Lock = False Then
                    '    If Trim(ssgrid.Text) = "" Then
                    '        ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    '    Else
                    '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                    '    End If
                    'End If
                End If
            ElseIf e.keyCode = Keys.F4 Then
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 1
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call fillmenu()
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    'ssgrid.Col = 2
                    'ssgrid.Row = i
                    'If ssgrid.Lock = False Then
                    '    ssgrid.Col = 2
                    '    ssgrid.Row = ssgrid.ActiveRow
                    '    search = Trim(ssgrid.Text)
                    '    Call FillMenuItem()
                    'End If
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
                        'Call Calculate()
                        .SetActiveCell(1, ssgrid.ActiveRow)
                        .Focus()
                    End With
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function SelectText() '''-->Select text in cell
        SendKeys.Send("Space")
        SendKeys.Send("{Home}")
        SendKeys.Send("+{End}")
    End Function
    Private Function GridRowLock(ByVal rnum As Integer)

        With ssgrid
            .Row = rnum
            '.Col = 1
            '.Lock = True

            .Col = 2
            .Lock = True

            .Col = 3
            .Lock = True

            .Col = 5
            .Lock = True

            .Col = 6
            .Lock = True

            .Col = 7
            .Lock = True
        End With

    End Function
    Private Function GridLock()
        Dim i As Integer

        With ssgrid
            For i = 1 To .DataRowCnt
                .Row = i
                '.Col = 1
                '.Lock = True

                .Col = 2
                .Lock = True

                .Col = 3
                .Lock = True

                .Col = 5
                .Lock = True

                .Col = 6
                .Lock = True

                .Col = 7
                .Lock = True
            Next i
        End With

    End Function
    Private Function GridRowUnLock()
        Dim i As Integer
        With ssgrid
            For i = 1 To .DataRowCnt
                .Row = i
                '.Col = 1
                '.Lock = True

                .Col = 2
                .Lock = False

                .Col = 3
                .Lock = False

                .Col = 5
                .Lock = False

                .Col = 6
                .Lock = False
            Next i
        End With

    End Function
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dupchk = False
        ssgrid.Col = 1
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Row = i
            If i <> ssgrid.ActiveRow Then
                If Trim(ssgrid.Text) = Itemcode Then
                    MsgBox("Item Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function
    Private Function fillmenu()
        Dim Avgrate, clsquantity As Double
        Dim K As Integer
        Dim vform As New List_Operation
        chkClsQty = True
        Dupchk = False
        chkStorecode = Trim(txt_storecode.Text & "")
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        'gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME, "
        'gSQLString = gSQLString & " ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
        'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "

        'gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = gSQLString & " ISNULL(clstock,0) AS clstock FROM INVENTORYITEMMASTER AS I "

        If Trim(vsearch) = " " Then
            M_WhereCondition = "WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' "
        Else
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
        End If
        vform.Field = "I.ITEMNAME,I.ITEMCODE"
        vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | STOCKUOM    | Clstock  "
        vform.vCaption = "INVENTORY ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        'vform.keypos4 = 4
        'vform.Keypos5 = 5
        'vform.Keypos6 = 6
        'vform.Keypos7 = 7
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            If Mid(MyCompanyName, 1, 4) <> "HIND" Then
                Call check_Duplicate(Trim(vform.keyfield))
                If Dupchk = True Then
                    Exit Function
                End If
            End If
            Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)

            'For K = 1 To ssgrid.DataRowCnt
            '    ssgrid.Row = K
            '    ssgrid.Col = 1
            '    If Itemvalidate(ssgrid, Trim(vform.keyfield), 1) = True Then
            '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Function
            '    End If
            'Next

            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            'ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeComboBox
            ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
            ssgrid.Text = Trim(vform.keyfield2)
            ssgrid.Col = 5
            ssgrid.Row = ssgrid.ActiveRow
            'Avgrate = CalAverageRate(Trim(vform.keyfield))
            'Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            Else
                Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            End If
            ssgrid.Text = Format(Val(Avgrate), "0.00")
            'clsquantity = ClosingQuantity(Trim(vform.keyfield), GetMainStore())
            clsquantity = ClosingQuantity_New(Trim(vform.keyfield), GetMainStore(), dtp_Indentdate.Value)
            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Function
        End If
        vform.Close()
        vform = Nothing
    End Function
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
                    ssgrid.Lock = True
                Next Z
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub



    Private Sub cmd_storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' "
        Dim vform As New List_Operation
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "             STORE CODE                   |                   STORE DESCRIPTION                             "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_storecode.Text = Trim(vform.keyfield & "")
            txt_storeDesc.Text = Trim(vform.keyfield1 & "")
            cbo_type.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_IndentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IndentNo.TextChanged

    End Sub

    Private Sub txt_IndentNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IndentNo.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmd_indentnoHelp.Enabled = True Then
                    search = Trim(txt_IndentNo.Text)
                    Call cmd_indentnoHelp_Click(cmd_indentnoHelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IndentNo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_IndentNo.Text) = "" Then
                    Call cmd_indentnoHelp_Click(cmd_indentnoHelp, e)
                Else
                    txt_IndentNo_Validated(txt_IndentNo, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_indentnoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_indentnoHelp.Click
        Try

            gSQLString = "SELECT cast(isnull(indent_no,0)as int),indent_date FROM inventory_indenthdr "
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "INDENT_DATE,INDENT_NO"
            vform.vFormatstring = "       INDENT_NO            |         INDENT_DATE                             "
            vform.vCaption = "STOCK INDENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_IndentNo.Text = Trim(vform.keyfield & "")
                Call txt_IndentNo_Validated(txt_IndentNo, e)
                dtp_Indentdate.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        Try
            If Trim(txt_IndentNo.Text) <> "" Then

                sqlstring = " SELECT ISNULL(H.INDENT_NO,'') AS INDENT_NO,H.INDENT_DATE AS INDENT_DATE,ISNULL(FROMSTORECODE,'') FROMSTORECODE , ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.PRODUCT_TYPE,'') AS PRODUCT_TYPE,"
                sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(H.VOID,'') AS VOID,"
                sqlstring = sqlstring & " ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATETIME,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME , isnull(updfooter,'') as updfooter,isnull(updsign,'') as updsign "
                sqlstring = sqlstring & " FROM INVENTORY_INDENTHDR AS H "
                sqlstring = sqlstring & " WHERE INDENT_NO='" & txt_IndentNo.Text & "'"
                gconnection.getDataSet(sqlstring, "INDENTHDR")
                '''************************************************* SELECT RECORD FROM INDENTHDR *********************************************''''                
                If gdataset.Tables("INDENTHDR").Rows.Count > 0 Then
                    cmd_Add.Text = "Update[F7]"
                    Me.txt_IndentNo.ReadOnly = True
                    'VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_IndentNo.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_NO") & "")
                    dtp_Indentdate.Value = Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_DATE")), "dd-MM-yyyy")
                    TXT_FROMSTORECODE.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("fromStoreCode") & "")
                    Call TXT_FROMSTORECODE_Validated(txt_IndentNo.Text, e)
                    txt_storecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONCODE"))
                    txt_storeDesc.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONNAME"))
                    cbo_type.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("PRODUCT_TYPE"))
                    remarks = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    Txt_footer.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("updfooter"))
                    Txt_signature.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("updsign"))
                    If gdataset.Tables("INDENTHDR").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                        Me.Cmd_FREEZE.Enabled = True
                        Me.cmd_Add.Enabled = False
                        Me.Cmd_FREEZE.Text = "UnVoid[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_FREEZE.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_FREEZE.Text = "Void[F8]"
                    End If
                    'If Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("VOID")) = "Y" Then
                    '    cmd_Add.Enabled = False
                    '    Cmd_FREEZE.Enabled = False
                    'End If
                    '''************************************************* SELECT RECORD FROM INDENTDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT , ISNULL(CLSQTY,0) CLSQTY"
                    sqlstring = sqlstring & " FROM INVENTORY_INDENTDET WHERE  INDENT_NO ='" & Trim(txt_IndentNo.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "INDENTDETAILS")
                    If gdataset.Tables("INDENTDETAILS").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("INDENTDETAILS").Rows.Count
                            Call GridUOM(i) '''---> FILL GRID UOM
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00"))
                            'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                            Clsquantity = ClosingQuantity(STRITEMCODE, Trim(TXT_FROMSTORECODE.Text))
                            'ssgrid.SetText(13, i, Clsquantity)
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("clsqty")), "0.00"))
                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    ssgrid.SetActiveCell(1, 1)
                    Call Calculate()
                Else
                    Call lastindent()
                    txt_IndentNo.Text = LastIndentNo
                    txt_IndentNo.ReadOnly = True
                    txt_storecode.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub
    Private Sub FillMenuItem()
        Dim Avgrate, clsquantity As Double
        Dim K As Integer
        Dim vform As New List_Operation
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        'gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME, "
        'gSQLString = gSQLString & " ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
        'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "

        'gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = gSQLString & " ISNULL(CONVVALUE,'') AS CONVUOM FROM INVENTORYITEMMASTER AS I "

        If Trim(vsearch) = " " Then
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' "
        Else
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND I.ITEMNAME LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
        End If
        vform.Field = "I.ITEMNAME,I.ITEMCODE"
        vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | STOCKUOM    "
        vform.vCaption = "INVENTORY ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        'vform.keypos4 = 4
        'vform.Keypos5 = 5
        'vform.Keypos6 = 6
        'vform.Keypos7 = 7
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)

            'For K = 1 To ssgrid.DataRowCnt
            '    ssgrid.Row = K
            '    ssgrid.Col = 1
            '    If Itemvalidate(ssgrid, Trim(vform.keyfield), 1) = True Then
            '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            'Next

            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            'ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeComboBox
            ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
            ssgrid.Col = 5
            ssgrid.Row = ssgrid.ActiveRow
            'Avgrate = CalAverageRate(Trim(vform.keyfield))
            'Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            Else
                Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
            End If
            ssgrid.Text = Format(Val(Avgrate), "0.00")
            'clsquantity = ClosingQuantity(Trim(vform.keyfield), GetMainStore())
            clsquantity = ClosingQuantity_New(Trim(vform.keyfield), GetMainStore(), dtp_Indentdate.Value)
            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Sub
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        If MsgBox("Are you Sure to Quit", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub dtp_Indentdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Indentdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXT_FROMSTORECODE.Focus()
        End If
    End Sub

    Private Sub cbo_type_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_type.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Indentdate.Focus()
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
            Me.cmd_Add.Enabled = False
            Me.Cmd_FREEZE.Enabled = False
            Me.cmd_View.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.cmd_Add.Enabled = True
                        Me.Cmd_FREEZE.Enabled = True
                        Me.cmd_View.Enabled = True
                        Exit Sub
                    End If
                    If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                        If Right(x) = "S" Then
                            Me.cmd_Add.Enabled = True
                        End If
                    Else
                        If Right(x) = "M" Then
                            Me.cmd_Add.Enabled = True
                        End If
                    End If
                    If Right(x) = "D" Then
                        Me.Cmd_FREEZE.Enabled = True
                    End If
                    If Right(x) = "V" Then
                        Me.cmd_View.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            Dim temp, temp1 As String
            temp = Trim(TXT_FROMSTORECODE.Text)
            temp1 = Trim(txt_FromStorename.Text)
            Call clearform(Me)
            TXT_FROMSTORECODE.Text = temp
            txt_FromStorename.Text = temp1
            txt_IndentNo.ReadOnly = False
            'Call FillStore() '''-->Fill Store Desc
            Call FOOTER()
            grp_footer.Visible = False
            Me.lbl_Freeze.Visible = False
            Me.dtp_Indentdate.Value = Format(Now, "dd/MM/yyyy")
            Me.lbl_Freeze.Text = "Record Void  On "
            Call GridRowUnLock()
            ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_FREEZE.Text = "Void [F8]"
            cmd_Add.Text = "Add [F7]"
            ssgrid.SetActiveCell(1, 1)
            cmd_Add.Enabled = True
            Cmd_FREEZE.Enabled = True
            Me.Cmd_FREEZE.Enabled = True
            'If Mid(MyCompanyName, 1, 4) = "HIND" Then
            Call lastindent()
            'End If
            txt_IndentNo.Text = LastIndentNo
            txt_IndentNo.Focus()
            'txt_IndentNo.ReadOnly = True
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Show()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_storecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_storecode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_storecode.Text = "" Then
                Call cmd_storecode_Click(cmd_storecode, e)
                cbo_type.Focus()
            Else
                sqlstring = " SELECT DISTINCT(storecode),storedesc FROM storemaster"
                sqlstring = sqlstring & " WHERE STORECODE = '" & txt_storecode.Text & "'"
                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                    txt_storeDesc.Text = gdataset.Tables("STOREMASTER1").Rows(0).Item("STOREDESC")
                    cbo_type.Focus()
                End If
            End If
        End If
    End Sub
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMNO As String, ByVal TONO As String)
        Dim DBLDOCTOTAL, DBLGROUPTOTAL, DBLGRANDTOTAL, TOTQTY As Double
        Dim dbltaxamount As Double
        Dim FROMSTORE, STROEDESC, DOCDETAILS, SSql As String
        Dim STOREBOOL, DOCBOOL As Boolean
        Dim I, J, K, CC, ItemCnt As Integer
        Dim dr As DataRow
        Dim dc As DataColumn
        Dim pageno As Integer
        Dim pagesize As Integer
        Dim gconnection As New GlobalClass

        Try
            ItemCnt = 0
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            DBLGRANDTOTAL = 0
            TOTQTY = 0
            '            Filewrite.Write(Chr(15))
            gconnection.getDataSet(SQLSTRING, "INDENT")

            If gdataset.Tables("INDENT").Rows.Count > 0 Then
                SSql = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE") & "' "
                gconnection.getDataSet(SSql, "FROMSTORE")
                If gdataset.Tables("FROMSTORE").Rows.Count > 0 Then
                    FROMSTORE = gdataset.Tables("FROMSTORE").Rows(0).Item("STOREDESC")
                End If
            Else
                MsgBox("NO DATA FOUND", MsgBoxStyle.Critical, "INVENTORY")
                Exit Function
            End If

            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine(Space(50) & Chr(14) & Chr(15) & "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 5
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(18) & Chr(27) & "E")
            Filewrite.WriteLine(Space(39 - Len(Trim(Mid(MyCompanyName, 1, 30))) / 2) & Mid(MyCompanyName, 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space(39 - Len(Trim(Mid(PAGEHEAD(0), 1, 30))) / 2) & Trim(Mid(PAGEHEAD(0), 1, 30)))
            pagesize = pagesize + 1

            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space(43) & "INDENT NO   : " & Space(12 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("INDENT_NO"))), 1, 12))) & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("INDENT_NO"))), 1, 12))
            Filewrite.WriteLine(Space(43) & "INDENT DATE : " & Space(12 - Len(Mid(Format(CDate(gdataset.Tables("INDENT").Rows(K).Item("INDENT_DATE")), "dd/MM/yyyy"), 1, 12))) & Mid(Format(CDate(gdataset.Tables("INDENT").Rows(K).Item("INDENT_DATE")), "dd/MM/yyyy"), 1, 12))
            pagesize = pagesize + 2
            Filewrite.WriteLine()
            pagesize = pagesize + 1

            Filewrite.WriteLine(" FROM : -" & Space(34) & "TO : -" & Chr(27) & "F")
            Filewrite.Write(Chr(27) & "E" & " DEPT CODE : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE")))
            Filewrite.Write(Space(30 - Len(Trim(gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE")))))
            Filewrite.WriteLine(Chr(27) & "E" & " DEPT CODE : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("STORELOCATIONCODE")))

            Filewrite.Write(Chr(27) & "E" & " DEPT NAME : " & Chr(27) & "F" & FROMSTORE & Space(30 - Len(FROMSTORE)))
            Filewrite.WriteLine(Chr(27) & "E" & " DEPT NAME : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("STORELOCATIONNAME")))
            Filewrite.WriteLine()
            pagesize = pagesize + 4

            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 4
            Filewrite.WriteLine("SNO CODE     ITEM NAME                 UOM         QTY       RATE        AMOUNT ")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1

            If gdataset.Tables("INDENT").Rows.Count > 0 Then
                For K = 0 To gdataset.Tables("INDENT").Rows.Count - 1
                    If pagesize > 58 Then
                        Filewrite.WriteLine(StrDup(82, "-"))
                        Filewrite.WriteLine(Chr(12))
                        pagesize = 0

                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()

                        Filewrite.WriteLine(StrDup(80, "-"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("SNO CODE       ITEM NAME                 UOM         QTY       RATE        AMOUNT ")

                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(80, "-"))
                        pagesize = pagesize + 1
                        pageno = pageno + 1
                    End If
                    'Filewrite.WriteLine(Space(3 - Len(Trim(Mid(CStr(K + 1), 1, 3)))) & Trim(Mid(CStr(K + 1), 1, 3)) & Space(1) & Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("ITEMCODE"))), 1, 6) & Space(6 - Len(Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("ITEMCODE"))), 1, 6))) & Space(1) & Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("ITEMNAME"))), 1, 25) & Space(25 - Len(Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("ITEMNAME"))), 1, 25))) & Space(1) & Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("UOM"))), 1, 5) & Space(5 - Len(Mid(Trim(CStr(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("UOM"))), 1, 5))) & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("QTY")), "0.000"), 1, 10))) & Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("QTY")), "0.000"), 1, 10) & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("RATE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("RATE")), "0.00"), 1, 10) & Space(1) & Space(12 - Len(Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("AMOUNT")), "0.00"), 1, 12))
                    SSql = Space(3 - Len(Trim(Mid(CStr(K + 1), 1, 3)))) & Trim(Mid(CStr(K + 1), 1, 3)) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMCODE"))), 1, 8) & Space(8 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMCODE"))), 1, 8))) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMNAME"))), 1, 25) & Space(25 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMNAME"))), 1, 25))) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("UOM"))), 1, 5) & Space(5 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("UOM"))), 1, 5))) & Space(1)
                    SSql = SSql & Space(10 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("QTY")), "0.000"), 1, 10))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("QTY")), "0.000"), 1, 10) & Space(1)
                    SSql = SSql & Space(10 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("RATE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("RATE")), "0.00"), 1, 10) & Space(1)
                    SSql = SSql & Space(12 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT")), "##,##0.00"), 1, 12))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT")), "##,##0.00"), 1, 12)

                    DBLGRANDTOTAL = DBLGRANDTOTAL + Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT"))
                    TOTQTY = TOTQTY + Val(gdataset.Tables("INDENT").Rows(K).Item("QTY"))
                    Filewrite.WriteLine(SSql)

                    pagesize = pagesize + 1
                    ItemCnt = ItemCnt + 1
                    'DBLDOCTOTAL = DBLDOCTOTAL + Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("AMOUNT")), "0.00")
                    'dbltaxamount = dbltaxamount + Format(Val(gdataset.Tables("GRNPURCHASEBILL").Rows(K).Item("TAXAMOUNT")), "0.00")

                Next K
                CC = 0
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine(Chr(27) & "E" & Space(31) & "TOTAL :" & Space(15 - Len(Format(TOTQTY, "0.000"))) & Format(TOTQTY, "##,##0.00") & Space(12) & Space(12 - Len(Format(DBLGRANDTOTAL, "##,##0.00"))) & Format(DBLGRANDTOTAL, "##,##0.00") & Chr(27) & "F")
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Space(0) & " Remarks:" & Trim(gdataset.Tables("INDENT").Rows(0).Item("remarks")))
                pagesize = pagesize + 3
                If pagesize < 50 Then
                    For I = 0 To (50 - pagesize)
                        Filewrite.WriteLine()
                    Next
                End If
                'Filewrite.WriteLine(" Store Keeper                 Asst. Manager Purchase               Secretary ")


                If gdataset.Tables("INDENT").Rows(0).Item("updfooter") <> "" And gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE") <> "DRR" Then
                    Filewrite.WriteLine(Chr(27) & "E" & Trim(gdataset.Tables("INDENT").Rows(0).Item("updfooter")) & Chr(27) & "F")
                    Filewrite.WriteLine(Chr(12))
                Else
                    Filewrite.WriteLine(Chr(27) & "E" & " Indent By         Supervisor          Initials of Issues         Received by " & Chr(27) & "F")
                    Filewrite.WriteLine(Chr(12))
                End If
            Else
                MessageBox.Show("NO RECORD TO BE DISPLAYED", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If
            '            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        Try
            gPrint = True
            Call printoperation()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Print Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub TXT_FROMSTORECODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FROMSTORECODE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(TXT_FROMSTORECODE.Text) = "" Then
                Call cmd_fromStorecodeHelp_Click(TXT_FROMSTORECODE.Text, e)
            Else
                Call TXT_FROMSTORECODE_Validated(TXT_FROMSTORECODE.Text, e)
                'ssgrid.Focus()
                'ssgrid.SetActiveCell(1, 1)
            End If
        End If
    End Sub

    Private Sub cmd_fromStorecodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_fromStorecodeHelp.Click
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
            TXT_FROMSTORECODE.Text = Trim(vform.keyfield & "")
            txt_FromStorename.Text = Trim(vform.keyfield1 & "")
        Else
            Call TXT_FROMSTORECODE_Validated(TXT_FROMSTORECODE.Text, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub TXT_FROMSTORECODE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.Validated
        If Trim(TXT_FROMSTORECODE.Text) <> "" Then
            sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(TXT_FROMSTORECODE.Text) & "'"
            gconnection.getDataSet(sqlstring, "storemaster")
            If gdataset.Tables("storemaster").Rows.Count > 0 Then
                TXT_FROMSTORECODE.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                txt_FromStorename.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                ssgrid.Focus()
                ssgrid.SetActiveCell(1, 1)
            Else
                TXT_FROMSTORECODE.Text = ""
                TXT_FROMSTORECODE.Focus()
            End If
        End If
    End Sub

    Private Sub txt_IndentNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.GotFocus
        txt_IndentNo.BackColor = Color.Gold
    End Sub

    Private Sub txt_IndentNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.LostFocus
        txt_IndentNo.BackColor = Color.Wheat
    End Sub

    Private Sub txt_storecode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_storecode.GotFocus
        txt_storecode.BackColor = Color.Gold
    End Sub

    Private Sub txt_storecode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_storecode.LostFocus
        txt_storecode.BackColor = Color.Wheat
    End Sub
    Private Sub TXT_FROMSTORECODE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.GotFocus
        TXT_FROMSTORECODE.BackColor = Color.Gold
    End Sub

    Private Sub TXT_FROMSTORECODE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.LostFocus
        TXT_FROMSTORECODE.BackColor = Color.Wheat
    End Sub

    Private Sub dtp_Indentdate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Indentdate.GotFocus
        dtp_Indentdate.BackColor = Color.Gold
    End Sub

    Private Sub dtp_Indentdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Indentdate.LostFocus
        dtp_Indentdate.BackColor = Color.Wheat
    End Sub

    Private Sub ssgrid_EnterRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_EnterRowEvent) Handles ssgrid.EnterRow
        MsgBox("enter row")
    End Sub

    Private Sub ssgrid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.Validated
        'ssgrid.Col = ssgrid.ActiveCol
        'ssgrid.Row = ssgrid.ActiveRow
        'ssgrid.BackColor = Color.Orange
    End Sub
    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_item.CheckedChanged
        If Chk_item.Checked = True Then
            grp_footer.Visible = True
            Txt_footer.Focus()
        Else
            grp_footer.Visible = False
        End If
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
    Private Sub Txt_signature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_signature.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Chk_item.Focus()
        End If
    End Sub
    Public Function FOOTER()
        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM INVENTORY_INDENTHDR WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM INVENTORY_INDENTHDR )"
        gconnection.getDataSet(sqlstring, "INVENTORY_INDENTHDR")
        If gdataset.Tables("INVENTORY_INDENTHDR").Rows.Count > 0 Then
            Txt_footer.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPDFOOTER"))
            Txt_signature.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPdsign"))
        End If
    End Function

    Private Sub txt_Remarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Remarks.TextChanged
    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub
End Class
