Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
'Imports System.Configuration
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.ComponentModel.Design
Imports System.IO
'Imports CrystalDecisions.reportsource
'Imports CrystalDecisions.shared
'Imports CrystalDecisions.web
Public Class MBILL
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5 As String
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim dr, dr1, dr2, dr4 As DataRow
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
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents chk_DuplicateBill As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bill As System.Windows.Forms.CheckBox
    Friend WithEvents txt_billno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_cchinese As System.Windows.Forms.TextBox
    Friend WithEvents txt_csail As System.Windows.Forms.TextBox
    Friend WithEvents txt_cmain As System.Windows.Forms.TextBox
    Friend WithEvents txt_entfee As System.Windows.Forms.TextBox
    Friend WithEvents txt_msub As System.Windows.Forms.TextBox
    Friend WithEvents txt_depmem As System.Windows.Forms.TextBox
    Friend WithEvents txt_club As System.Windows.Forms.TextBox
    Friend WithEvents txt_contig As System.Windows.Forms.TextBox
    Friend WithEvents txt_bsail As System.Windows.Forms.TextBox
    Friend WithEvents txt_bmain As System.Windows.Forms.TextBox
    Friend WithEvents txt_newyear As System.Windows.Forms.TextBox
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents txt_misc As System.Windows.Forms.TextBox
    Friend WithEvents txt_spdinner As System.Windows.Forms.TextBox
    Friend WithEvents txt_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_otherevnt As System.Windows.Forms.TextBox
    Friend WithEvents txt_tele As System.Windows.Forms.TextBox
    Friend WithEvents txt_salon As System.Windows.Forms.TextBox
    Friend WithEvents txt_lib As System.Windows.Forms.TextBox
    Friend WithEvents txt_lock As System.Windows.Forms.TextBox
    Friend WithEvents txt_health As System.Windows.Forms.TextBox
    Friend WithEvents txt_card As System.Windows.Forms.TextBox
    Friend WithEvents txt_sailing As System.Windows.Forms.TextBox
    Friend WithEvents txt_swim As System.Windows.Forms.TextBox
    Friend WithEvents txt_billard As System.Windows.Forms.TextBox
    Friend WithEvents txt_sqas As System.Windows.Forms.TextBox
    Friend WithEvents txt_badm As System.Windows.Forms.TextBox
    Friend WithEvents txt_tt As System.Windows.Forms.TextBox
    Friend WithEvents txt_tennis As System.Windows.Forms.TextBox
    Friend WithEvents txt_gams As System.Windows.Forms.TextBox
    Friend WithEvents txt_penalty As System.Windows.Forms.TextBox
    Friend WithEvents txt_credit As System.Windows.Forms.TextBox
    Friend WithEvents txt_debt As System.Windows.Forms.TextBox
    Friend WithEvents txt_bill As System.Windows.Forms.TextBox
    Friend WithEvents txt_bene As System.Windows.Forms.TextBox
    Friend WithEvents txt_bank As System.Windows.Forms.TextBox
    Friend WithEvents txt_gust As System.Windows.Forms.TextBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_chitsdining As System.Windows.Forms.TextBox
    Friend WithEvents txt_chitsbar As System.Windows.Forms.TextBox
    Friend WithEvents txt_amtcr As System.Windows.Forms.TextBox
    Friend WithEvents txt_paid As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents CMD_CLEAR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MBILL))
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.cmd_print = New System.Windows.Forms.Button
        Me.chk_DuplicateBill = New System.Windows.Forms.CheckBox
        Me.chk_bill = New System.Windows.Forms.CheckBox
        Me.txt_billno = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_cchinese = New System.Windows.Forms.TextBox
        Me.txt_csail = New System.Windows.Forms.TextBox
        Me.txt_cmain = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_entfee = New System.Windows.Forms.TextBox
        Me.txt_msub = New System.Windows.Forms.TextBox
        Me.txt_depmem = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_club = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_contig = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_bsail = New System.Windows.Forms.TextBox
        Me.txt_bmain = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txt_newyear = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txt_misc = New System.Windows.Forms.TextBox
        Me.txt_spdinner = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txt_trans = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txt_otherevnt = New System.Windows.Forms.TextBox
        Me.txt_tele = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txt_salon = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_lib = New System.Windows.Forms.TextBox
        Me.txt_lock = New System.Windows.Forms.TextBox
        Me.txt_health = New System.Windows.Forms.TextBox
        Me.txt_card = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_sailing = New System.Windows.Forms.TextBox
        Me.txt_swim = New System.Windows.Forms.TextBox
        Me.txt_billard = New System.Windows.Forms.TextBox
        Me.txt_sqas = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_badm = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_tt = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_tennis = New System.Windows.Forms.TextBox
        Me.txt_gams = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txt_penalty = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_credit = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.txt_debt = New System.Windows.Forms.TextBox
        Me.txt_bill = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.txt_amtcr = New System.Windows.Forms.TextBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txt_paid = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txt_bene = New System.Windows.Forms.TextBox
        Me.txt_bank = New System.Windows.Forms.TextBox
        Me.txt_gust = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.CMD_CLEAR = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.txt_remarks = New System.Windows.Forms.TextBox
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.txt_chitsdining = New System.Windows.Forms.TextBox
        Me.txt_chitsbar = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MM/yyyy"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(104, 48)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 2
        Me.CbxMonth.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 435
        Me.Label10.Text = "BILL MONTH :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Member Code"
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(144, 16)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(120, 22)
        Me.txt_mcode.TabIndex = 1
        Me.txt_mcode.Text = ""
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(336, 632)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 3
        Me.cmd_view.Text = "View [F8]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.Location = New System.Drawing.Point(592, 632)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 575
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(264, 16)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 577
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 578
        Me.Label1.Text = "Member Name"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(144, 48)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.ReadOnly = True
        Me.txt_mname.Size = New System.Drawing.Size(168, 22)
        Me.txt_mname.TabIndex = 579
        Me.txt_mname.Text = ""
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.Location = New System.Drawing.Point(464, 632)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_print.TabIndex = 5
        Me.cmd_print.Text = "Print [F9]"
        '
        'chk_DuplicateBill
        '
        Me.chk_DuplicateBill.BackColor = System.Drawing.Color.CornflowerBlue
        Me.chk_DuplicateBill.Location = New System.Drawing.Point(776, 96)
        Me.chk_DuplicateBill.Name = "chk_DuplicateBill"
        Me.chk_DuplicateBill.Size = New System.Drawing.Size(96, 24)
        Me.chk_DuplicateBill.TabIndex = 590
        Me.chk_DuplicateBill.Text = "Duplicate Bill"
        '
        'chk_bill
        '
        Me.chk_bill.BackColor = System.Drawing.Color.CornflowerBlue
        Me.chk_bill.Location = New System.Drawing.Point(680, 96)
        Me.chk_bill.Name = "chk_bill"
        Me.chk_bill.Size = New System.Drawing.Size(96, 24)
        Me.chk_bill.TabIndex = 591
        Me.chk_bill.Text = "Original Bill"
        '
        'txt_billno
        '
        Me.txt_billno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_billno.Location = New System.Drawing.Point(104, 16)
        Me.txt_billno.MaxLength = 8
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(112, 22)
        Me.txt_billno.TabIndex = 593
        Me.txt_billno.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 144)
        Me.GroupBox1.TabIndex = 594
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(104, 40)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "DEP MEMBER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "MEMBER"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(112, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ENTRANCE FEE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_cchinese)
        Me.GroupBox2.Controls.Add(Me.txt_csail)
        Me.GroupBox2.Controls.Add(Me.txt_cmain)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 144)
        Me.GroupBox2.TabIndex = 595
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 601
        Me.Label13.Text = "CHINESE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 600
        Me.Label12.Text = "SAILING"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cchinese
        '
        Me.txt_cchinese.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cchinese.Location = New System.Drawing.Point(96, 96)
        Me.txt_cchinese.Name = "txt_cchinese"
        Me.txt_cchinese.Size = New System.Drawing.Size(104, 22)
        Me.txt_cchinese.TabIndex = 599
        Me.txt_cchinese.Text = ""
        '
        'txt_csail
        '
        Me.txt_csail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_csail.Location = New System.Drawing.Point(96, 53)
        Me.txt_csail.Name = "txt_csail"
        Me.txt_csail.Size = New System.Drawing.Size(104, 22)
        Me.txt_csail.TabIndex = 598
        Me.txt_csail.Text = ""
        '
        'txt_cmain
        '
        Me.txt_cmain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmain.Location = New System.Drawing.Point(96, 16)
        Me.txt_cmain.Name = "txt_cmain"
        Me.txt_cmain.Size = New System.Drawing.Size(104, 22)
        Me.txt_cmain.TabIndex = 597
        Me.txt_cmain.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "MAIN"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_entfee
        '
        Me.txt_entfee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_entfee.Location = New System.Drawing.Point(144, 176)
        Me.txt_entfee.Name = "txt_entfee"
        Me.txt_entfee.Size = New System.Drawing.Size(112, 22)
        Me.txt_entfee.TabIndex = 596
        Me.txt_entfee.Text = ""
        '
        'txt_msub
        '
        Me.txt_msub.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_msub.Location = New System.Drawing.Point(144, 216)
        Me.txt_msub.Name = "txt_msub"
        Me.txt_msub.Size = New System.Drawing.Size(112, 22)
        Me.txt_msub.TabIndex = 597
        Me.txt_msub.Text = ""
        '
        'txt_depmem
        '
        Me.txt_depmem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_depmem.Location = New System.Drawing.Point(144, 256)
        Me.txt_depmem.Name = "txt_depmem"
        Me.txt_depmem.Size = New System.Drawing.Size(112, 22)
        Me.txt_depmem.TabIndex = 598
        Me.txt_depmem.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(24, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 40)
        Me.Label8.TabIndex = 599
        Me.Label8.Text = "MONTHLY SUBS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox3.Controls.Add(Me.txt_club)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txt_contig)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txt_bsail)
        Me.GroupBox3.Controls.Add(Me.txt_bmain)
        Me.GroupBox3.Location = New System.Drawing.Point(496, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 144)
        Me.GroupBox3.TabIndex = 600
        Me.GroupBox3.TabStop = False
        '
        'txt_club
        '
        Me.txt_club.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_club.Location = New System.Drawing.Point(152, 112)
        Me.txt_club.Name = "txt_club"
        Me.txt_club.Size = New System.Drawing.Size(96, 22)
        Me.txt_club.TabIndex = 607
        Me.txt_club.Text = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(112, 16)
        Me.Label18.TabIndex = 606
        Me.Label18.Text = "CLUB SHOP"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(136, 24)
        Me.Label17.TabIndex = 605
        Me.Label17.Text = "CONTINGENCY"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_contig
        '
        Me.txt_contig.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contig.Location = New System.Drawing.Point(152, 80)
        Me.txt_contig.Name = "txt_contig"
        Me.txt_contig.Size = New System.Drawing.Size(96, 22)
        Me.txt_contig.TabIndex = 604
        Me.txt_contig.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 603
        Me.Label15.Text = "MAIN"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 602
        Me.Label16.Text = "SAILING"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_bsail
        '
        Me.txt_bsail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bsail.Location = New System.Drawing.Point(152, 48)
        Me.txt_bsail.Name = "txt_bsail"
        Me.txt_bsail.Size = New System.Drawing.Size(96, 22)
        Me.txt_bsail.TabIndex = 600
        Me.txt_bsail.Text = ""
        '
        'txt_bmain
        '
        Me.txt_bmain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bmain.Location = New System.Drawing.Point(152, 16)
        Me.txt_bmain.Name = "txt_bmain"
        Me.txt_bmain.Size = New System.Drawing.Size(96, 22)
        Me.txt_bmain.TabIndex = 598
        Me.txt_bmain.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(272, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 40)
        Me.Label9.TabIndex = 601
        Me.Label9.Text = "CATERING"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(496, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(256, 40)
        Me.Label14.TabIndex = 602
        Me.Label14.Text = "BAR"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox4.Controls.Add(Me.txt_newyear)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.txt_fax)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.txt_misc)
        Me.GroupBox4.Controls.Add(Me.txt_spdinner)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.txt_trans)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.txt_otherevnt)
        Me.GroupBox4.Controls.Add(Me.txt_tele)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txt_salon)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txt_lib)
        Me.GroupBox4.Controls.Add(Me.txt_lock)
        Me.GroupBox4.Controls.Add(Me.txt_health)
        Me.GroupBox4.Controls.Add(Me.txt_card)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txt_sailing)
        Me.GroupBox4.Controls.Add(Me.txt_swim)
        Me.GroupBox4.Controls.Add(Me.txt_billard)
        Me.GroupBox4.Controls.Add(Me.txt_sqas)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txt_badm)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txt_tt)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txt_tennis)
        Me.GroupBox4.Controls.Add(Me.txt_gams)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(24, 304)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(728, 264)
        Me.GroupBox4.TabIndex = 603
        Me.GroupBox4.TabStop = False
        '
        'txt_newyear
        '
        Me.txt_newyear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newyear.Location = New System.Drawing.Point(344, 208)
        Me.txt_newyear.Name = "txt_newyear"
        Me.txt_newyear.Size = New System.Drawing.Size(104, 22)
        Me.txt_newyear.TabIndex = 642
        Me.txt_newyear.Text = ""
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(240, 208)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(96, 32)
        Me.Label39.TabIndex = 641
        Me.Label39.Text = "NEW YEAR GIFT"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(464, 224)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(120, 32)
        Me.Label47.TabIndex = 639
        Me.Label47.Text = "MISCELLANEOUS"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_fax
        '
        Me.txt_fax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax.Location = New System.Drawing.Point(344, 176)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(104, 22)
        Me.txt_fax.TabIndex = 637
        Me.txt_fax.Text = ""
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(456, 136)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(136, 32)
        Me.Label40.TabIndex = 636
        Me.Label40.Text = "OTHER EVENTS"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_misc
        '
        Me.txt_misc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_misc.Location = New System.Drawing.Point(592, 224)
        Me.txt_misc.Name = "txt_misc"
        Me.txt_misc.Size = New System.Drawing.Size(120, 22)
        Me.txt_misc.TabIndex = 635
        Me.txt_misc.Text = ""
        '
        'txt_spdinner
        '
        Me.txt_spdinner.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_spdinner.Location = New System.Drawing.Point(120, 224)
        Me.txt_spdinner.Name = "txt_spdinner"
        Me.txt_spdinner.Size = New System.Drawing.Size(112, 22)
        Me.txt_spdinner.TabIndex = 633
        Me.txt_spdinner.Text = ""
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 216)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(96, 32)
        Me.Label38.TabIndex = 632
        Me.Label38.Text = "SPECIAL DINNER"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_trans
        '
        Me.txt_trans.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_trans.Location = New System.Drawing.Point(592, 184)
        Me.txt_trans.Name = "txt_trans"
        Me.txt_trans.Size = New System.Drawing.Size(120, 22)
        Me.txt_trans.TabIndex = 631
        Me.txt_trans.Text = ""
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(472, 176)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(96, 32)
        Me.Label33.TabIndex = 630
        Me.Label33.Text = "TRANSIT QUATERS"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(248, 176)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 629
        Me.Label32.Text = "P&T/FAX"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_otherevnt
        '
        Me.txt_otherevnt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_otherevnt.Location = New System.Drawing.Point(592, 144)
        Me.txt_otherevnt.Name = "txt_otherevnt"
        Me.txt_otherevnt.Size = New System.Drawing.Size(120, 22)
        Me.txt_otherevnt.TabIndex = 628
        Me.txt_otherevnt.Text = ""
        '
        'txt_tele
        '
        Me.txt_tele.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tele.Location = New System.Drawing.Point(344, 144)
        Me.txt_tele.Name = "txt_tele"
        Me.txt_tele.Size = New System.Drawing.Size(104, 22)
        Me.txt_tele.TabIndex = 627
        Me.txt_tele.Text = ""
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(248, 144)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(80, 16)
        Me.Label31.TabIndex = 626
        Me.Label31.Text = "TELE/STD"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_salon
        '
        Me.txt_salon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salon.Location = New System.Drawing.Point(120, 176)
        Me.txt_salon.Name = "txt_salon"
        Me.txt_salon.Size = New System.Drawing.Size(112, 22)
        Me.txt_salon.TabIndex = 625
        Me.txt_salon.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 624
        Me.Label4.Text = "SALOON/  B.PARLOUR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_lib
        '
        Me.txt_lib.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lib.Location = New System.Drawing.Point(592, 112)
        Me.txt_lib.Name = "txt_lib"
        Me.txt_lib.Size = New System.Drawing.Size(120, 22)
        Me.txt_lib.TabIndex = 623
        Me.txt_lib.Text = ""
        '
        'txt_lock
        '
        Me.txt_lock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lock.Location = New System.Drawing.Point(592, 80)
        Me.txt_lock.Name = "txt_lock"
        Me.txt_lock.Size = New System.Drawing.Size(120, 22)
        Me.txt_lock.TabIndex = 622
        Me.txt_lock.Text = ""
        '
        'txt_health
        '
        Me.txt_health.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_health.Location = New System.Drawing.Point(592, 48)
        Me.txt_health.Name = "txt_health"
        Me.txt_health.Size = New System.Drawing.Size(120, 22)
        Me.txt_health.TabIndex = 621
        Me.txt_health.Text = ""
        '
        'txt_card
        '
        Me.txt_card.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_card.Location = New System.Drawing.Point(592, 16)
        Me.txt_card.Name = "txt_card"
        Me.txt_card.Size = New System.Drawing.Size(120, 22)
        Me.txt_card.TabIndex = 620
        Me.txt_card.Text = ""
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(480, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 619
        Me.Label30.Text = "LIBRARY"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(480, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(96, 16)
        Me.Label29.TabIndex = 618
        Me.Label29.Text = "LOCKER"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(456, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(128, 16)
        Me.Label28.TabIndex = 617
        Me.Label28.Text = "HEALTH CLUB"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(456, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 616
        Me.Label27.Text = "CARD ROOM"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_sailing
        '
        Me.txt_sailing.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sailing.Location = New System.Drawing.Point(344, 112)
        Me.txt_sailing.Name = "txt_sailing"
        Me.txt_sailing.Size = New System.Drawing.Size(104, 22)
        Me.txt_sailing.TabIndex = 615
        Me.txt_sailing.Text = ""
        '
        'txt_swim
        '
        Me.txt_swim.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_swim.Location = New System.Drawing.Point(344, 80)
        Me.txt_swim.Name = "txt_swim"
        Me.txt_swim.Size = New System.Drawing.Size(104, 22)
        Me.txt_swim.TabIndex = 614
        Me.txt_swim.Text = ""
        '
        'txt_billard
        '
        Me.txt_billard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_billard.Location = New System.Drawing.Point(344, 48)
        Me.txt_billard.Name = "txt_billard"
        Me.txt_billard.Size = New System.Drawing.Size(104, 22)
        Me.txt_billard.TabIndex = 613
        Me.txt_billard.Text = ""
        '
        'txt_sqas
        '
        Me.txt_sqas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sqas.Location = New System.Drawing.Point(344, 16)
        Me.txt_sqas.Name = "txt_sqas"
        Me.txt_sqas.Size = New System.Drawing.Size(104, 22)
        Me.txt_sqas.TabIndex = 612
        Me.txt_sqas.Text = ""
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(256, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 611
        Me.Label26.Text = "SAILING"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(240, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(104, 32)
        Me.Label25.TabIndex = 610
        Me.Label25.Text = "SWIMMING"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(240, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 609
        Me.Label24.Text = "BILLARDS"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(248, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 608
        Me.Label23.Text = "SQUASH"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_badm
        '
        Me.txt_badm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_badm.Location = New System.Drawing.Point(120, 136)
        Me.txt_badm.Name = "txt_badm"
        Me.txt_badm.Size = New System.Drawing.Size(112, 22)
        Me.txt_badm.TabIndex = 607
        Me.txt_badm.Text = ""
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(112, 16)
        Me.Label19.TabIndex = 606
        Me.Label19.Text = "BADMINTON"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(88, 32)
        Me.Label20.TabIndex = 605
        Me.Label20.Text = "TABLE TENNIS"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tt
        '
        Me.txt_tt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tt.Location = New System.Drawing.Point(120, 96)
        Me.txt_tt.Name = "txt_tt"
        Me.txt_tt.Size = New System.Drawing.Size(112, 22)
        Me.txt_tt.TabIndex = 604
        Me.txt_tt.Text = ""
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(104, 40)
        Me.Label21.TabIndex = 603
        Me.Label21.Text = "OTHER GAMES *"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 602
        Me.Label22.Text = "TENNIS"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tennis
        '
        Me.txt_tennis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tennis.Location = New System.Drawing.Point(120, 64)
        Me.txt_tennis.Name = "txt_tennis"
        Me.txt_tennis.Size = New System.Drawing.Size(112, 22)
        Me.txt_tennis.TabIndex = 600
        Me.txt_tennis.Text = ""
        '
        'txt_gams
        '
        Me.txt_gams.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gams.Location = New System.Drawing.Point(120, 24)
        Me.txt_gams.Name = "txt_gams"
        Me.txt_gams.Size = New System.Drawing.Size(112, 22)
        Me.txt_gams.TabIndex = 598
        Me.txt_gams.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txt_mcode)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txt_mname)
        Me.GroupBox5.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(432, 80)
        Me.GroupBox5.TabIndex = 604
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txt_billno)
        Me.GroupBox6.Controls.Add(Me.CbxMonth)
        Me.GroupBox6.Location = New System.Drawing.Point(448, 40)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(232, 80)
        Me.GroupBox6.TabIndex = 605
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 606
        Me.Label2.Text = " BILL NO : "
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox7.Controls.Add(Me.txt_penalty)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.txt_credit)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.txt_debt)
        Me.GroupBox7.Controls.Add(Me.txt_bill)
        Me.GroupBox7.Location = New System.Drawing.Point(752, 312)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 136)
        Me.GroupBox7.TabIndex = 606
        Me.GroupBox7.TabStop = False
        '
        'txt_penalty
        '
        Me.txt_penalty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_penalty.Location = New System.Drawing.Point(112, 104)
        Me.txt_penalty.Name = "txt_penalty"
        Me.txt_penalty.Size = New System.Drawing.Size(88, 22)
        Me.txt_penalty.TabIndex = 607
        Me.txt_penalty.Text = ""
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(88, 16)
        Me.Label34.TabIndex = 606
        Me.Label34.Text = "PENALTY"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 72)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(104, 24)
        Me.Label35.TabIndex = 605
        Me.Label35.Text = "CREDIT BF*"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_credit
        '
        Me.txt_credit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_credit.Location = New System.Drawing.Point(112, 72)
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.Size = New System.Drawing.Size(88, 22)
        Me.txt_credit.TabIndex = 604
        Me.txt_credit.Text = ""
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(96, 16)
        Me.Label36.TabIndex = 603
        Me.Label36.Text = "BILL AMT"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(96, 16)
        Me.Label37.TabIndex = 602
        Me.Label37.Text = "DEBIT BF*"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_debt
        '
        Me.txt_debt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_debt.Location = New System.Drawing.Point(112, 40)
        Me.txt_debt.Name = "txt_debt"
        Me.txt_debt.Size = New System.Drawing.Size(88, 22)
        Me.txt_debt.TabIndex = 600
        Me.txt_debt.Text = ""
        '
        'txt_bill
        '
        Me.txt_bill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bill.Location = New System.Drawing.Point(112, 8)
        Me.txt_bill.Name = "txt_bill"
        Me.txt_bill.Size = New System.Drawing.Size(88, 22)
        Me.txt_bill.TabIndex = 598
        Me.txt_bill.Text = ""
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox8.Controls.Add(Me.Label41)
        Me.GroupBox8.Location = New System.Drawing.Point(752, 448)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(112, 72)
        Me.GroupBox8.TabIndex = 607
        Me.GroupBox8.TabStop = False
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label41.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(4, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label41.Size = New System.Drawing.Size(100, 56)
        Me.Label41.TabIndex = 617
        Me.Label41.Text = "AMOUNT TO YOUR CREDIT"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox9.Controls.Add(Me.Label42)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(864, 448)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(104, 72)
        Me.GroupBox9.TabIndex = 608
        Me.GroupBox9.TabStop = False
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(4, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label42.Size = New System.Drawing.Size(92, 48)
        Me.Label42.TabIndex = 617
        Me.Label42.Text = "AMOUNT TO BE PAID"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox10.Controls.Add(Me.txt_amtcr)
        Me.GroupBox10.Location = New System.Drawing.Point(752, 520)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(112, 48)
        Me.GroupBox10.TabIndex = 609
        Me.GroupBox10.TabStop = False
        '
        'txt_amtcr
        '
        Me.txt_amtcr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amtcr.Location = New System.Drawing.Point(8, 16)
        Me.txt_amtcr.Name = "txt_amtcr"
        Me.txt_amtcr.TabIndex = 636
        Me.txt_amtcr.Text = ""
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox11.Controls.Add(Me.txt_paid)
        Me.GroupBox11.Location = New System.Drawing.Point(864, 520)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(104, 48)
        Me.GroupBox11.TabIndex = 610
        Me.GroupBox11.TabStop = False
        '
        'txt_paid
        '
        Me.txt_paid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paid.Location = New System.Drawing.Point(8, 16)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.Size = New System.Drawing.Size(86, 22)
        Me.txt_paid.TabIndex = 637
        Me.txt_paid.Text = ""
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox12.Controls.Add(Me.Label43)
        Me.GroupBox12.Controls.Add(Me.txt_bene)
        Me.GroupBox12.Controls.Add(Me.txt_bank)
        Me.GroupBox12.Controls.Add(Me.txt_gust)
        Me.GroupBox12.Controls.Add(Me.Label45)
        Me.GroupBox12.Controls.Add(Me.Label48)
        Me.GroupBox12.Location = New System.Drawing.Point(752, 160)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(216, 152)
        Me.GroupBox12.TabIndex = 611
        Me.GroupBox12.TabStop = False
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(8, 112)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(104, 32)
        Me.Label43.TabIndex = 601
        Me.Label43.Text = "BENE.FUND"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_bene
        '
        Me.txt_bene.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bene.Location = New System.Drawing.Point(112, 112)
        Me.txt_bene.Name = "txt_bene"
        Me.txt_bene.Size = New System.Drawing.Size(96, 22)
        Me.txt_bene.TabIndex = 599
        Me.txt_bene.Text = ""
        '
        'txt_bank
        '
        Me.txt_bank.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bank.Location = New System.Drawing.Point(112, 72)
        Me.txt_bank.Name = "txt_bank"
        Me.txt_bank.Size = New System.Drawing.Size(96, 22)
        Me.txt_bank.TabIndex = 598
        Me.txt_bank.Text = ""
        '
        'txt_gust
        '
        Me.txt_gust.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gust.Location = New System.Drawing.Point(112, 24)
        Me.txt_gust.Name = "txt_gust"
        Me.txt_gust.Size = New System.Drawing.Size(96, 22)
        Me.txt_gust.TabIndex = 597
        Me.txt_gust.Text = ""
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(8, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(88, 48)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "GUEST CHARGES"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(8, 72)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(88, 32)
        Me.Label48.TabIndex = 640
        Me.Label48.Text = "BANK CHARGES"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMD_CLEAR
        '
        Me.CMD_CLEAR.BackColor = System.Drawing.SystemColors.Menu
        Me.CMD_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_CLEAR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_CLEAR.Location = New System.Drawing.Point(208, 632)
        Me.CMD_CLEAR.Name = "CMD_CLEAR"
        Me.CMD_CLEAR.Size = New System.Drawing.Size(104, 32)
        Me.CMD_CLEAR.TabIndex = 612
        Me.CMD_CLEAR.Text = "Clear[F6]"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label44.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(752, 120)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(216, 40)
        Me.Label44.TabIndex = 613
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label49.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(24, 584)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label49.Size = New System.Drawing.Size(72, 16)
        Me.Label49.TabIndex = 614
        Me.Label49.Text = "REMARKS :"
        '
        'txt_remarks
        '
        Me.txt_remarks.AcceptsTab = True
        Me.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_remarks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(104, 584)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_remarks.Size = New System.Drawing.Size(536, 40)
        Me.txt_remarks.TabIndex = 615
        Me.txt_remarks.Text = ""
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox13.Controls.Add(Me.Label50)
        Me.GroupBox13.Controls.Add(Me.txt_chitsdining)
        Me.GroupBox13.Controls.Add(Me.txt_chitsbar)
        Me.GroupBox13.Controls.Add(Me.Label52)
        Me.GroupBox13.Location = New System.Drawing.Point(648, 568)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox13.TabIndex = 616
        Me.GroupBox13.TabStop = False
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(168, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label50.Size = New System.Drawing.Size(88, 32)
        Me.Label50.TabIndex = 641
        Me.Label50.Text = "NO.OF CHITS DINING"
        '
        'txt_chitsdining
        '
        Me.txt_chitsdining.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chitsdining.Location = New System.Drawing.Point(256, 16)
        Me.txt_chitsdining.Name = "txt_chitsdining"
        Me.txt_chitsdining.Size = New System.Drawing.Size(56, 22)
        Me.txt_chitsdining.TabIndex = 599
        Me.txt_chitsdining.Text = ""
        '
        'txt_chitsbar
        '
        Me.txt_chitsbar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chitsbar.Location = New System.Drawing.Point(88, 16)
        Me.txt_chitsbar.Name = "txt_chitsbar"
        Me.txt_chitsbar.Size = New System.Drawing.Size(56, 22)
        Me.txt_chitsbar.TabIndex = 598
        Me.txt_chitsbar.Text = ""
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(8, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label52.Size = New System.Drawing.Size(72, 32)
        Me.Label52.TabIndex = 640
        Me.Label52.Text = "NO.OF CHITS BAR"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(312, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(283, 31)
        Me.Label51.TabIndex = 617
        Me.Label51.Text = "MEMBER BILL QUERY"
        '
        'MBILL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(976, 678)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.CMD_CLEAR)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_depmem)
        Me.Controls.Add(Me.txt_msub)
        Me.Controls.Add(Me.txt_entfee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_bill)
        Me.Controls.Add(Me.chk_DuplicateBill)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_view)
        Me.Name = "MBILL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBILL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        ' gPrint = False
        'If Chk_subscriptionsummary.Checked = True Then
        '    Call Reportdetails_summary_subscription()
        '    Exit Sub
        'End If

        If chk_DuplicateBill.Checked = True Then
            gPrint = False
            Call Reportdetails_duplicate()
            Exit Sub
        End If

        'If chk_summary.Checked = True Then
        '    Call Reportdetails_summary()
        'Else
            Call Reportdetails()
        'End If
    End Sub
    Public Function Reportdetails()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR, SQLSTR1, SQLSTR2, SQLSTR3, SQLSTR4, SQLSTR5, SQLSTR6, SQLSTR7, SQLSTR8, SQLSTR9 As String
        Dim PAGESIZE As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
            Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
            Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

            'If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            'If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31
            ' txt_billno.Text = ""
            If txt_mcode.Text <> "" Then
                sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2,ISNULL(B.PPIN,'') AS CONTPIN  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.MCODE = '" & txt_mcode.Text & "' AND MONTH(A.BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(A.BILLDATE) = " & Year(CbxMonth.Text) & " GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.PPIN,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(B.SUBCD,'')"
            Else
                sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE as MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2,ISNULL(B.PPIN,'') AS CONTPIN  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.BILLNUMBER = " & Trim(txt_billno.Text) & "  GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.PPIN,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(B.SUBCD,'')"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count = 0 Then
                    MsgBox("PLEASE CHECK YOUR BILLNO", MyCompanyName, MsgBoxStyle.Information)
                Else
                    txt_mcode.Text = gdataset.Tables("MEMBER").Rows(0).Item("MCODE")
                    txt_mname.Text = gdataset.Tables("MEMBER").Rows(0).Item("MNAME")
                    'CbxMonth.Text=
                End If
            End If
            ' sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPIN,'') AS CONTPIN,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.MCODE = '" & txt_mcode.Text & "' AND MONTH(A.BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(A.BILLDATE) = " & Year(CbxMonth.Text) & "  GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPIN,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(A.MCODE,'')"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    For I = 1 To 4
                        Filewrite.WriteLine()
                    Next I
                    '1
                    SQLSTR1 = "" 'Space(29)
                    '1,1
                    'ENTRANCE FEE
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='2020' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='2020'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_entfee.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_entfee.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,2
                    'MEMBER
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND  ISNULL(ACCOUNTCODE,'') IN ('7030','7040','7020','7031','7012','7060','7050','7032','7014','7010')  and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & "  AND  ISNULL(ACCOUNTCODE,'') IN ('7030','7040','7020','7031','7012','7060','7050','7032','7014','7010')"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")

                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_msub.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_msub.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,3
                    'DEP MEMBER
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('7000') AND ISNULL(SLCODE,'') IN ('7011') and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('7000') AND ISNULL(SLCODE,'') IN ('7011')"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_depmem.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_depmem.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,4
                    'CATERING MAIN
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8010' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8010' "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_cmain.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_cmain.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If
                    '1,5
                    'CATERING SAILING
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8023' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE ='8023'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_csail.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_csail.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,6
                    'CATERING CHINESE
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8012' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & "  AND ACCOUNTCODE='8012' "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_cchinese.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_cchinese.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,7
                    'BAR MAIN


                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8020' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8020'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_bmain.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_bmain.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,8
                    'BAR SAILING
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8021' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8021'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_bsail.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_bsail.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,9
                    'CONTINENCY TAX
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2398') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('2398')"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_contig.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_contig.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,10
                    'CLUB SHOP
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8030' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8030'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_club.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_club.Text = 0
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If


                    '1,11
                    'MONTH
                    SQLSTR1 = SQLSTR1 & Mid(Trim(CbxMonth.Text), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4) & Space(7)


                    '1,12
                    'BILLNO
                    SQLSTR1 = SQLSTR1 & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8) & Space(17)
                    txt_billno.Text = Format(Val(dr("BILLNO")), "0")

                    SQLSTR1 = SQLSTR1 & Mid(Trim(CbxMonth.Text), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4) & Space(7)

                    '2,1
                    SQLSTR2 = ""
                    ' OTHER(GAMES)

                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='3598' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='3598'"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_gams.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_gams.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,2
                    'TENNIS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8041' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8041'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_tennis.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_tennis.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,3
                    'TABLE TENNIS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8042' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8042' "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_tt.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_tt.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,4
                    'BADMINTON
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8043' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8043'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_badm.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_badm.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,5
                    'SQUASH
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8044' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8044'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_sqas.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_sqas.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,6
                    'BILLIARDS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8045' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8045'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_billard.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_billard.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,7
                    'SWIMMING
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8046' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8046'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_swim.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_swim.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,8
                    'SAILING
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8047' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8047'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_sailing.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_sailing.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,9
                    'CARD ROOM

                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8048' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8048'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_card.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_card.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,10
                    'HEALTH CLUB
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8049' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8049'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_health.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_health.Text = 0
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,9
                    'BILLNO
                    '                    SQLSTR2 = SQLSTR2 & Space(42) & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8)

                    SQLSTR2 = SQLSTR2 & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30)))) & Space(14) & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30))))


                    '3,1
                    SQLSTR3 = ""
                    'LOCKER
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8050' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & "  AND ACCOUNTCODE='8050'"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_lock.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_lock.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,2
                    'LIBRARY
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8051' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE  BILLNUMBER = " & Trim(txt_billno.Text) & "  AND ACCOUNTCODE='8051'"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_lib.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_lib.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,3
                    'SALOON
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8052','8061','8062') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('8052','8061','8062') "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_salon.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_salon.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,4
                    'TELE/STD
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8053' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8053'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_tele.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_tele.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If


                    '3,5
                    'P&T/FAX
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8056','8113') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('8056','8113')"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_fax.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_fax.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,6
                    'TRANSIT QUARTERS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8035' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8035'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_trans.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_trans.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,7
                    'SPL. DINNER
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8013','8014') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & "  AND ACCOUNTCODE IN ('8013','8014')"
                    End If

                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_spdinner.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_spdinner.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,8
                    'BANK CHARGES
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('3910') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('3910') "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_bank.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_bank.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,9
                    'BENE FUND
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2346','2347') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('2346','2347')"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_bene.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_bene.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,10
                    'NEW YEAR GIFT
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2348') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('2348') "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_newyear.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_newyear.Text = 0
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    SQLSTR3 = SQLSTR3 & Trim(Mid(dr("CONTCITY"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTCITY"), 1, 30))))


                    '4
                    SQLSTR4 = ""

                    '4,1
                    'OTHER EVENTS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8068' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE='8068'"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_otherevnt.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_otherevnt.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,2
                    'GUEST CHARGES
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8071','8072','8073','8074','8075') and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('8071','8072','8073','8074','8075')"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_gust.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_gust.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,3
                    'MISCELLNEOUS
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2320','2321','2365','2366','2367','2368','2369','2361') and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & "  AND ACCOUNTCODE IN ('2320','2321','2365','2366','2367','2368','2369','2361') "
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                        txt_misc.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_misc.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,4
                    'BILL FOR THE MONTH
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text)
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_bill.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_bill.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,5
                    'DEBIT BF
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else

                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text)
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        txt_debt.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,6
                    'CREDIT BF
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text)
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        txt_credit.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,7
                    'PENALTY
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('1681') and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text) & " AND ACCOUNTCODE IN ('1681')"
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_penalty.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_penalty.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,8
                    'AMOUNT TO YOUR CREDIT
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text)
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        txt_amtcr.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,9
                    'AMOUNT TO YOUR DEBIT
                    If txt_mcode.Text <> "" Then
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & ""
                    Else
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE BILLNUMBER = " & Trim(txt_billno.Text)
                    End If
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                        txt_paid.Text = Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00")
                    Else
                        txt_paid.Text = 0
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If



                    '4,10
                    'DINNING
                    sqlstring = "SELECT KOTDETAILS FROM KOT_DET WHERE ISNULL(DELFLAG,'')<>'Y' AND ISNULL(KOTSTATUS,'')<>'Y' AND CATEGORY='CANTEEN' AND MCODE='" & dr("MCODE") & "' and MONTH(KOTDATE) = " & Month(CbxMonth.Text) & " AND YEAR(KOTDATE) = " & Year(CbxMonth.Text) & "GROUP BY KOTDETAILS"
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows.Count) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(3 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0.00"), 1, 3))) & Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0"), 1, 3) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(4)
                    End If

                    '4,11
                    'BAR
                    sqlstring = "SELECT KOTDETAILS FROM KOT_DET WHERE ISNULL(DELFLAG,'')<>'Y' AND ISNULL(KOTSTATUS,'')<>'Y' AND CATEGORY='CANTEEN' AND MCODE='" & dr("MCODE") & "' and MONTH(KOTDATE) = " & Month(CbxMonth.Text) & " AND YEAR(KOTDATE) = " & Year(CbxMonth.Text) & " GROUP BY KOTDETAILS"
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows.Count) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(3 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0.00"), 1, 3))) & Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0"), 1, 3) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(4)
                    End If


                    SQLSTR4 = SQLSTR4 & "Due date for the bill " & Format(DateAdd(DateInterval.Day, 35, dr("BILLDATE")), "MMM dd yyyy")
                    '                    Filewrite.WriteLine(SQLSTR)

                    'PRINTING
                    '5
                    Filewrite.WriteLine(SQLSTR1)
                    '6
                    Filewrite.WriteLine()

                    SQLSTR = Space(92) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10)))) & Space(10) & Trim(Mid(dr("MEMBERTYPE"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MEMBERTYPE"), 1, 30)))) & Space(15) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    Filewrite.WriteLine(SQLSTR)
                    '7

                    Filewrite.WriteLine(SQLSTR2)
                    '8
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 1, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 31, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 31, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 61, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 61, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    '9
                    Filewrite.WriteLine(SQLSTR3)
                    '10

                    SQLSTR = Space(92) & Trim(Mid(dr("CONTPIN"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPIN"), 1, 30))))
                    Filewrite.WriteLine(SQLSTR)

                    SQLSTR = Space(92) & "Payments Accounted Upto " & Format(DateAdd(DateInterval.Day, 6, dr("BILLDATE")), "MMM dd yyyy")
                    Filewrite.WriteLine(SQLSTR)

                    Filewrite.WriteLine(SQLSTR4)
                    '12

                    SQLSTR = Space(92) & Trim(Mid(dr("CONTPHONE1"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 15)))) & Space(10) & Trim(Mid(dr("CONTPHONE2"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE2"), 1, 15))))
                    Filewrite.WriteLine(SQLSTR)

                    '18
                    '                    SQLSTR = Space(96) & Format(dr("BILLDATE"), "dd/MM/yyyy")
                    '                   Filewrite.WriteLine(SQLSTR)

                    For I = 1 To 3
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            'Filewrite.Write(Chr(12))
            For I = 1 To 7
                Filewrite.WriteLine()
            Next I

            Filewrite.Close()
            If gPrint = False Then
                '   OpenTextFile(vOutfile)
            Else
                PrintTextFile(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function Reportdetails_PROPOSED()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            'If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            'If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            'If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            sqlstring = "SELECT MCODE FROM MEMBER_MONTH_BILL WHERE MCODE BETWEEN '" & txt_mcode.Text & "' AND MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(A.BILLDATE) = " & Year(CbxMonth.Text) & "   GROUP BY MCODE ORDER BY MCODE "
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    For I = 1 To 8
                        Filewrite.WriteLine()
                    Next I
                    sqlstring = "SELECT isnull(rowno,0) as rowno FROM MEMBER_MONTH_BILL_SETUP GROUP BY ROWNO"
                    gconnection.getDataSet(sqlstring, "BILLROW")
                    If gdataset.Tables("BILLROW").Rows.Count > 0 Then
                        For Each dr4 In gdataset.Tables("BILLROW").Rows
                            SQLSTR = Space(15)
                            Filewrite.WriteLine()
                            sqlstring = "SELECT isnull(rowno,0) as rowno,isnull(colno,0) as colno,isnull(accountcode,'') as accountcode,isnull(slcode,'') as slcode,isnull(flag,'') as flag FROM MEMBER_MONTH_BILL_SETUP WHERE ROWNO=" & dr4("ROWNO") & " ORDER BY COLNO"
                            gconnection.getDataSet(sqlstring, "BILLSETUP")
                            If gdataset.Tables("BILLSETUP").Rows.Count > 0 Then
                                For Each dr1 In gdataset.Tables("BILLSETUP").Rows
                                    If Trim(dr1("FLAG")) = "N" Then
                                        SQLSTR = SQLSTR & Space(18)
                                    Else
                                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & Trim(dr("MCODE")) & "' AND MONTH(BILLDATE) = " & month1 & " AND ACCOUNTCODE+ISNULL(SLCODE,'') IN (SELECT ACCOUNTCODE+ISNULL(SLCODE,'') FROM MEMBER_MONTH_BILL_SETUP WHERE ROWNO=" & Trim(dr1("ROWNO")) & " AND COLNO=" & Trim(dr1("COLNO")) & ")"
                                        gconnection.getDataSet(sqlstring, "BILL")
                                        If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                                            For Each dr2 In gdataset.Tables("BILL").Rows
                                                SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(dr2("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr2("AMOUNT"), "0.00"), 1, 8) & Space(10)
                                            Next
                                        Else
                                            SQLSTR = SQLSTR & Space(18)
                                        End If
                                    End If
                                Next
                            End If
                            Filewrite.WriteLine(SQLSTR)
                        Next
                    End If
                    For I = 1 To 2
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
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
    Public Function Reportdetails_summary_subscription()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT, TTAXAMOUNT, TNOOFPERSON, TOTALAMOUNT, TOTALTAXAMOUNT, NETAMOUNT, NETTAXAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            sqlstring = "SELECT MEMBERTYPE,TYPEDESC,SUBSCODE,SUBSDESC,AMOUNT,TAXAMOUNT,BILLDATE,NOOFPERSON FROM JHIC_SUBSCRIPTION_SUMMARY where  MONTH(BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(BILLDATE) = " & Year(CbxMonth.Text) & " ORDER BY MEMBERTYPE"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                Call PrintHeader_SUBSCRIPTION(CbxMonth.Text)
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    If PAGESIZE > 58 Then
                        Filewrite.Write(StrDup(105, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader_SUBSCRIPTION(CbxMonth.Text)
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                    End If
                    SQLSTR = Trim(Mid(CStr(dr2("MEMBERTYPE")), 1, 3)) & Space(3 - Len(Trim(Mid(CStr(dr2("MEMBERTYPE")), 1, 3)))) & Space(1)
                    SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("TYPEDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("TYPEDESC")), 1, 25)))) & Space(1)
                    ' SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SUBSCODE")), 1, 3)) & Space(3 - Len(Trim(Mid(CStr(dr2("SUBSCODE")), 1, 3)))) & Space(1)
                    'SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SUBSDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("SUBSDESC")), 1, 25)))) & Space(1)
                    SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("TAXAMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("TAXAMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(11 - Len(Mid(Format(CDate(dr2("BILLDATE")), "dd/MM/yyyy"), 1, 11))) & Mid(Format(CDate(dr2("BILLDATE")), "dd/MM/yyyy"), 1, 11) & Space(1)
                    SQLSTR = SQLSTR & Space(4 - Len(Mid(Format(Val(dr2("NOOFPERSON")), "0"), 1, 4))) & Mid(Format(Val(dr2("NOOFPERSON")), "0"), 1, 4) & Space(1)
                    TOTALAMOUNT = 0
                    TOTALTAXAMOUNT = 0

                    TOTALAMOUNT = Val(dr2("AMOUNT")) * Val(dr2("NOOFPERSON"))
                    TOTALTAXAMOUNT = Val(dr2("TAXAMOUNT")) * Val(dr2("NOOFPERSON"))
                    ' SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALAMOUNT), "0.00"), 1, 12) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALTAXAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALTAXAMOUNT), "0.00"), 1, 12) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALTAXAMOUNT) + Val(TOTALAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALTAXAMOUNT) + Val(TOTALAMOUNT), "0.00"), 1, 12)

                    Filewrite.WriteLine(SQLSTR)
                    PAGESIZE = PAGESIZE + 1
                    NETAMOUNT = NETAMOUNT + TOTALAMOUNT
                    NETTAXAMOUNT = NETTAXAMOUNT + TOTALTAXAMOUNT
                    TAMOUNT = TAMOUNT + TOTALTAXAMOUNT + TOTALAMOUNT
                    TNOOFPERSON = TNOOFPERSON + Val(dr2("NOOFPERSON"))

                Next dr2
                SQLSTR = Space(58) & Space(6 - Len(Mid(Format(Val(TNOOFPERSON), "0"), 1, 6))) & Mid(Format(Val(TNOOFPERSON), "0"), 1, 6) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(NETAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(NETAMOUNT), "0.00"), 1, 12) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(NETTAXAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(NETTAXAMOUNT), "0.00"), 1, 12) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12) & Space(1)
                Filewrite.WriteLine(StrDup(105, "="))
                Filewrite.WriteLine(SQLSTR)
                Filewrite.WriteLine(StrDup(105, "="))
                PAGESIZE = PAGESIZE + 3
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
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


    Public Function Reportdetails_summary()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            sqlstring = "select accountcode,isnull(accountcodedesc,'') as accountcodedesc,ISNULL(sum(ISNULL(amount,0)),0) as amount from VIEW_JHIC_MONTHBILL_SUMMARY where  MONTHNO = " & Month(CbxMonth.Text) & " AND YEAR(A.BILLDATE) = " & Year(CbxMonth.Text) & " group by accountcode,isnull(accountcodedesc,'') order by accountcode"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                Call PrintHeader(CbxMonth.Text)
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    If PAGESIZE > 58 Then
                        Filewrite.Write(StrDup(72, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(CbxMonth.Text)
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                    End If
                    SQLSTR = Trim(Mid(CStr(dr2("ACCOUNTCODE")), 1, 15)) & Space(15 - Len(Trim(Mid(CStr(dr2("ACCOUNTCODE")), 1, 15)))) & Space(2)
                    SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("ACCOUNTCODEDESC")), 1, 40)) & Space(40 - Len(Trim(Mid(CStr(dr2("ACCOUNTCODEDESC")), 1, 40)))) & Space(2)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 12)
                    Filewrite.WriteLine(SQLSTR)
                    PAGESIZE = PAGESIZE + 1
                    TAMOUNT = TAMOUNT + Val(dr2("AMOUNT"))
                Next dr2
                SQLSTR = Space(60) & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12)
                Filewrite.WriteLine(StrDup(72, "="))
                Filewrite.WriteLine(SQLSTR)
                Filewrite.WriteLine(StrDup(72, "="))
                PAGESIZE = PAGESIZE + 3
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
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
    Private Function PrintHeader(ByVal Heading As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("{0,10}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-50}{1,10}", "MONTH BILL SUMMARY FOR " & Heading, " PAGE : " & pageno + 1)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(72, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ACCOUNT CODE     ACCOUNT DESCRIPTION                             AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(72, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeader_SUBSCRIPTION(ByVal Heading As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("{0,10}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-50}{1,10}", "MONTH BILL SUBSCRIPTION SUMMARY FOR " & Heading, " PAGE : " & pageno + 1)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(105, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("TYPE  TYPEDESC                  AMOUNT TAXAMOUNT BILLDATE    NOS     TAMOUNT       TTAX        TOTAL")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(105, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New List_Operation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    ' txt_Tomcode.Focus()
                    'cmd_view.Focus()
                    CbxMonth.Focus()
                Else
                    txt_mcode.Text = ""
                    txt_mcode.Focus()
                End If
            Else
                '  txt_mcode.Text = ""
                ' txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MBILL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show()
        chk_bill.Checked = True
        txt_mcode.Focus()
    End Sub

    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub txt_Tomcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp1_Click(sender, e)
            Else
                ' txt_Tomcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vform As New List_Operation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            ' txt_Tomcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    'Private Sub txt_Tomcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Trim(txt_Tomcode.Text) <> "" Then
    '            sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_Tomcode.Text) & "'"
    '            gconnection.getDataSet(sqlstring, "MEMBER")
    '            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
    '                txt_Tomcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
    '                txt_Tomname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
    '                cmd_view.Focus()
    '            Else
    '                txt_Tomcode.Text = ""
    '                txt_Tomcode.Focus()
    '            End If
    '        Else
    '            txt_Tomcode.Text = ""
    '            txt_Tomcode.Focus()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub Validation()
        Dim BOOLCHK As Boolean
        boolchk = False
        If txt_mcode.Text = "" Then
            MessageBox.Show(" From MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_mcode.Focus()
            Exit Sub
        End If
        'If txt_Tomcode.Text = "" Then
        '    MessageBox.Show(" To MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_Tomcode.Focus()
        '    Exit Sub
        'End If
        boolchk = True
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        gPrint = True
        'If Chk_subscriptionsummary.Checked = True Then
        '    Call Reportdetails_summary_subscription()
        '    Exit Sub
        'End If
        If chk_DuplicateBill.Checked = True Then
            Call Reportdetails_duplicate()
            Exit Sub
        End If

        'If chk_summary.Checked = True Then
        '    Call Reportdetails_summary()
        'Else
            Call Reportdetails()
        ' End If
    End Sub
    Public Function Reportdetails_duplicate()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            ''If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            ''If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            ''If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            ''If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            ''If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            ''If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            ''If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            If txt_mcode.Text <> "" Then
                sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2,ISNULL(B.PPIN,'') AS CONTPIN  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.MCODE = '" & txt_mcode.Text & "' AND MONTH(A.BILLDATE) = " & Month(CbxMonth.Text) & " AND YEAR(A.BILLDATE) = " & Year(CbxMonth.Text) & " GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.PPIN,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(B.SUBCD,'')"
            Else
                sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2,ISNULL(B.PPIN,'') AS CONTPIN  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.BILLNUMBER = " & txt_billno.Text & "  GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.PPIN,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(B.SUBCD,'')"
                If gdataset.Tables("MEMBER").Rows.Count = 0 Then
                    MsgBox("PLEASE CHECK YOUR BILLNO", MyCompanyName, MsgBoxStyle.Information)
                Else
                    txt_mcode.Text = gdataset.Tables("MEMBER").Rows(0).Item("mcode")
                    txt_mname.Text = gdataset.Tables("MEMBER").Rows(0).Item("mname")
                End If
                End If
            gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    For Each dr2 In gdataset.Tables("MEMBER").Rows
                        TAMOUNT = 0
                        Call PrintHeader_Duplicate(CbxMonth.Text, dr2("MCODE"), dr2("MNAME"), dr2("CONTADD1"), dr2("CONTADD2"), dr2("CONTADD3"), dr2("CONTCITY"), dr2("BILLNO"))


                    sqlstring = "select accountcode,isnull(accountcodedesc,'') as accountcodedesc,isnull(sum(isnull(amount,0)),0) as amount from VIEW_JHIC_MONTHBILL_DUPLICATE where  MCODE='" & dr2("MCODE") & "' AND MONTHNO = " & Month(CbxMonth.Text) & "  group by accountcode,isnull(accountcodedesc,'') order by accountcode"


                    gconnection.getDataSet(sqlstring, "BILL")
                        If gdataset.Tables("BILL").Rows.Count > 0 Then
                            For Each dr1 In gdataset.Tables("BILL").Rows
                                If PAGESIZE > 58 Then
                                    Filewrite.Write(StrDup(72, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeader_Duplicate(CbxMonth.Text, dr2("MCODE"), dr2("MNAME"), dr2("CONTADD1"), dr2("CONTADD2"), dr2("CONTADD3"), dr2("CONTCITY"), dr2("BILLNO"))
                                    Filewrite.WriteLine()
                                    PAGESIZE = PAGESIZE + 1
                                End If
                                '                            SQLSTR = Trim(Mid(CStr(dr1("ACCOUNTCODE")), 1, 15)) & Space(15 - Len(Trim(Mid(CStr(dr1("ACCOUNTCODE")), 1, 15)))) & Space(2)
                                SQLSTR = Space(40) & Trim(Mid(CStr(dr1("ACCOUNTCODEDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr1("ACCOUNTCODEDESC")), 1, 25)))) & Space(1)
                                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12)
                                Filewrite.WriteLine(SQLSTR)
                                PAGESIZE = PAGESIZE + 1
                                TAMOUNT = TAMOUNT + Val(dr1("AMOUNT"))
                            Next
                            Filewrite.WriteLine(StrDup(79, "-"))
                            SQLSTR = Space(40) & "TOTAL FOR THE MONTH.." & Space(5) & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12)
                            Filewrite.WriteLine(SQLSTR)
                            Filewrite.WriteLine(StrDup(79, "-"))
                            SQLSTR = Space(40) & "RECEIPT ON           " & Space(5) & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12)
                            Filewrite.WriteLine(SQLSTR)
                            Filewrite.WriteLine(StrDup(79, "-"))
                            PAGESIZE = PAGESIZE + 5
                        End If
                        Filewrite.WriteLine(" Your Attention is drawn to the provisions of Bye-Law no 12(a) ")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine(" regarding credit stoppage and deposits for not clearing  the dues on due dates.")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine(Space(32) & " *Please ignore this if payment is already made")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("PRINTED ON : " & Format(Now, "dd/MM/yyyy") & " Prepared By :" & Trim(gUsername))
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine(Space(40) & " Sd/-")
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine(Space(40) & " SECRETARY")
                        PAGESIZE = PAGESIZE + 1
                        PAGESIZE = 60
                        Filewrite.Write(Chr(12))
                    Next dr2
                Else
                    MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Function
                End If
                Filewrite.Write(Chr(12))
                Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(VFilePath)
                ' PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Function PrintHeader_Duplicate(ByVal Heading As String, ByVal MCODE As String, ByVal MNAME As String, ByVal ADD1 As String, ByVal ADD2 As String, ByVal ADD3 As String, ByVal ADD4 As String, ByVal BILLNO As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("                      SECUNDERABAD CLUB")
                Filewrite.WriteLine("                PICKET, SECUNDERABAD - 500 026. ")
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("M.S.No:" & Mid(Trim(MCODE), 1, 10) & Space(10 - Len(Mid(Trim(MCODE), 1, 10))) & Space(30) & " For the Month of " & Heading, " PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("M.S.Name:" & Mid(Trim(MNAME), 1, 40) & Space(40 - Len(Mid(Trim(MNAME), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("Address :" & Mid(Trim(ADD1), 1, 40) & Space(40 - Len(Mid(Trim(ADD1), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD2), 1, 40) & Space(40 - Len(Mid(Trim(ADD2), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD3), 1, 40) & Space(40 - Len(Mid(Trim(ADD3), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD4), 1, 40) & Space(40 - Len(Mid(Trim(ADD4), 1, 40))) & Space(2) & "BILL NO...: " & Trim(BILLNO))
            pagesize = pagesize + 1

            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("DATE     CATERING        BAR          PARTICULARS                       AMOUNT")
            Filewrite.WriteLine("          (Rs.)         (Rs.)                                            (Rs.)")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            pageno = pageno + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    
    Private Sub CMD_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_CLEAR.Click
        txt_mcode.Text = ""
        txt_mcode.Focus()
        txt_mname.Text = ""
        txt_billno.Text = ""
        txt_amtcr.Text = 0
        txt_badm.Text = 0
        txt_bank.Text = 0
        txt_bene.Text = 0
        txt_billard.Text = 0
        txt_bill.Text = 0
        txt_bmain.Text = 0
        txt_bsail.Text = 0
        txt_card.Text = 0
        txt_cchinese.Text = 0
        txt_chitsbar.Text = 0
        txt_chitsdining.Text = 0
        txt_club.Text = 0
        txt_cmain.Text = 0
        txt_contig.Text = 0
        txt_credit.Text = 0
        txt_csail.Text = 0
        txt_debt.Text = 0
        txt_depmem.Text = 0
        txt_entfee.Text = 0
        txt_fax.Text = 0
        txt_gams.Text = 0
        txt_gust.Text = 0
        txt_health.Text = 0
        txt_lib.Text = 0
        txt_lock.Text = 0
        txt_newyear.Text = 0
        txt_otherevnt.Text = 0
        txt_paid.Text = 0
        txt_penalty.Text = 0
        txt_remarks.Text = ""
        txt_sailing.Text = 0
        txt_salon.Text = 0
        txt_spdinner.Text = 0
        txt_sqas.Text = 0
        txt_swim.Text = 0
        txt_tele.Text = 0
        txt_tennis.Text = 0
        txt_trans.Text = 0
        chk_bill.Checked = True
        chk_DuplicateBill.Checked = False



        Call clearform(Me)
    End Sub

    Private Sub txt_billno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_billno.KeyDown
        'cmd_view.Focus()
    End Sub

    Private Sub txt_billno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_billno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd_view.Focus()
        End If
    End Sub

    Private Sub CbxMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxMonth.ValueChanged

    End Sub

    Private Sub CbxMonth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxMonth.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd_view.Focus()
        End If
    End Sub
End Class
