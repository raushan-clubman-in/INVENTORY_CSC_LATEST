Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class frmmainstockposition
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
    Friend WithEvents lbl_Itemlist As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chklist_itemdetails As System.Windows.Forms.CheckedListBox
    Friend WithEvents grp_orderby As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_code As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_name As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_SelectAllStore As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chklist_store As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_groupdesc As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_itemwise_month As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_deptwise As System.Windows.Forms.CheckBox
    Friend WithEvents chk_itemwise As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_SubledgerCode As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cmd_ITEMFROM As System.Windows.Forms.Button
    Friend WithEvents txt_itemto As System.Windows.Forms.TextBox
    Friend WithEvents cmd_itemto As System.Windows.Forms.Button
    Friend WithEvents TXT_FROM As System.Windows.Forms.TextBox
    Friend WithEvents CHK_ZEROQTY As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllSubgroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_SubGroup As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmmainstockposition))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Itemlist = New System.Windows.Forms.Label
        Me.chklist_itemdetails = New System.Windows.Forms.CheckedListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.grp_orderby = New System.Windows.Forms.GroupBox
        Me.rdo_name = New System.Windows.Forms.RadioButton
        Me.rdo_code = New System.Windows.Forms.RadioButton
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox
        Me.chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chklist_groupdesc = New System.Windows.Forms.CheckedListBox
        Me.chk_SelectAllStore = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chklist_store = New System.Windows.Forms.CheckedListBox
        Me.chk_itemwise_month = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk_deptwise = New System.Windows.Forms.CheckBox
        Me.CHK_ZEROQTY = New System.Windows.Forms.CheckBox
        Me.chk_itemwise = New System.Windows.Forms.CheckBox
        Me.Lbl_SubledgerCode = New System.Windows.Forms.Label
        Me.TXT_FROM = New System.Windows.Forms.TextBox
        Me.Cmd_ITEMFROM = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_itemto = New System.Windows.Forms.TextBox
        Me.cmd_itemto = New System.Windows.Forms.Button
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSubgroup = New System.Windows.Forms.CheckBox
        Me.Chklist_SubGroup = New System.Windows.Forms.CheckedListBox
        Me.GroupBox3.SuspendLayout()
        Me.frmbut.SuspendLayout()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.grp_orderby.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(408, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(218, 31)
        Me.lbl_Heading.TabIndex = 5
        Me.lbl_Heading.Text = "ISSUE SUMMARY"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Itemlist
        '
        Me.lbl_Itemlist.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Itemlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemlist.ForeColor = System.Drawing.Color.White
        Me.lbl_Itemlist.Location = New System.Drawing.Point(632, 72)
        Me.lbl_Itemlist.Name = "lbl_Itemlist"
        Me.lbl_Itemlist.Size = New System.Drawing.Size(376, 24)
        Me.lbl_Itemlist.TabIndex = 435
        Me.lbl_Itemlist.Text = "SELECT ITEMCODE :"
        '
        'chklist_itemdetails
        '
        Me.chklist_itemdetails.CheckOnClick = True
        Me.chklist_itemdetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_itemdetails.Location = New System.Drawing.Point(632, 96)
        Me.chklist_itemdetails.Name = "chklist_itemdetails"
        Me.chklist_itemdetails.Size = New System.Drawing.Size(376, 403)
        Me.chklist_itemdetails.TabIndex = 434
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(160, 544)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(688, 64)
        Me.GroupBox3.TabIndex = 446
        Me.GroupBox3.TabStop = False
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(152, 24)
        Me.dtp_Fromdate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Fromdate.TabIndex = 0
        Me.dtp_Fromdate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(392, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(512, 24)
        Me.dtp_Todate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Todate.TabIndex = 1
        Me.dtp_Todate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FROM DATE :"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(528, 624)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 445
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(352, 624)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 442
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(704, 624)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 443
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(32, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 441
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Location = New System.Drawing.Point(144, 608)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(712, 56)
        Me.frmbut.TabIndex = 444
        Me.frmbut.TabStop = False
        '
        'Timer1
        '
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(160, 544)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(688, 64)
        Me.grp_SalebillChecklist.TabIndex = 448
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(672, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'grp_orderby
        '
        Me.grp_orderby.BackColor = System.Drawing.Color.Transparent
        Me.grp_orderby.Controls.Add(Me.rdo_name)
        Me.grp_orderby.Controls.Add(Me.rdo_code)
        Me.grp_orderby.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_orderby.Location = New System.Drawing.Point(808, 504)
        Me.grp_orderby.Name = "grp_orderby"
        Me.grp_orderby.Size = New System.Drawing.Size(200, 40)
        Me.grp_orderby.TabIndex = 451
        Me.grp_orderby.TabStop = False
        Me.grp_orderby.Text = "Order By"
        '
        'rdo_name
        '
        Me.rdo_name.Location = New System.Drawing.Point(104, 16)
        Me.rdo_name.Name = "rdo_name"
        Me.rdo_name.Size = New System.Drawing.Size(96, 16)
        Me.rdo_name.TabIndex = 1
        Me.rdo_name.Text = "Item Name"
        '
        'rdo_code
        '
        Me.rdo_code.Checked = True
        Me.rdo_code.Location = New System.Drawing.Point(16, 16)
        Me.rdo_code.Name = "rdo_code"
        Me.rdo_code.Size = New System.Drawing.Size(88, 16)
        Me.rdo_code.TabIndex = 0
        Me.rdo_code.TabStop = True
        Me.rdo_code.Text = "Item Code"
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(632, 56)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(128, 16)
        Me.Chk_SelectAllItem.TabIndex = 453
        Me.Chk_SelectAllItem.Text = "SELECT ALL"
        '
        'chk_SelectAllGroup
        '
        Me.chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.chk_SelectAllGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_SelectAllGroup.Location = New System.Drawing.Point(352, 56)
        Me.chk_SelectAllGroup.Name = "chk_SelectAllGroup"
        Me.chk_SelectAllGroup.Size = New System.Drawing.Size(128, 16)
        Me.chk_SelectAllGroup.TabIndex = 454
        Me.chk_SelectAllGroup.Text = "SELECT ALL"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(352, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 24)
        Me.Label6.TabIndex = 452
        Me.Label6.Text = "SELECT GROUP CODE :"
        '
        'chklist_groupdesc
        '
        Me.chklist_groupdesc.CheckOnClick = True
        Me.chklist_groupdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_groupdesc.Location = New System.Drawing.Point(352, 96)
        Me.chklist_groupdesc.Name = "chklist_groupdesc"
        Me.chklist_groupdesc.Size = New System.Drawing.Size(256, 151)
        Me.chklist_groupdesc.TabIndex = 437
        '
        'chk_SelectAllStore
        '
        Me.chk_SelectAllStore.BackColor = System.Drawing.Color.Transparent
        Me.chk_SelectAllStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_SelectAllStore.Location = New System.Drawing.Point(16, 56)
        Me.chk_SelectAllStore.Name = "chk_SelectAllStore"
        Me.chk_SelectAllStore.Size = New System.Drawing.Size(128, 16)
        Me.chk_SelectAllStore.TabIndex = 457
        Me.chk_SelectAllStore.Text = "SELECT ALL"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 24)
        Me.Label4.TabIndex = 456
        Me.Label4.Text = "SELECT STORE CODE :"
        '
        'chklist_store
        '
        Me.chklist_store.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_store.Location = New System.Drawing.Point(16, 96)
        Me.chklist_store.Name = "chklist_store"
        Me.chklist_store.Size = New System.Drawing.Size(320, 403)
        Me.chklist_store.TabIndex = 455
        '
        'chk_itemwise_month
        '
        Me.chk_itemwise_month.BackgroundImage = CType(resources.GetObject("chk_itemwise_month.BackgroundImage"), System.Drawing.Image)
        Me.chk_itemwise_month.Checked = True
        Me.chk_itemwise_month.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_itemwise_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_itemwise_month.Location = New System.Drawing.Point(864, 624)
        Me.chk_itemwise_month.Name = "chk_itemwise_month"
        Me.chk_itemwise_month.TabIndex = 459
        Me.chk_itemwise_month.Text = "MONTHLY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(104, 664)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(795, 21)
        Me.Label5.TabIndex = 460
        Me.Label5.Text = "Press F1 for Advance Search Of Item/Press F3 to Search Store/Press F2 to GroupSea" & _
        "rch / Press ENTER key to navigate"
        '
        'chk_deptwise
        '
        Me.chk_deptwise.BackgroundImage = CType(resources.GetObject("chk_deptwise.BackgroundImage"), System.Drawing.Image)
        Me.chk_deptwise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_deptwise.Location = New System.Drawing.Point(496, 512)
        Me.chk_deptwise.Name = "chk_deptwise"
        Me.chk_deptwise.TabIndex = 461
        Me.chk_deptwise.Text = "DEPTWISE"
        '
        'CHK_ZEROQTY
        '
        Me.CHK_ZEROQTY.BackgroundImage = CType(resources.GetObject("CHK_ZEROQTY.BackgroundImage"), System.Drawing.Image)
        Me.CHK_ZEROQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CHK_ZEROQTY.Location = New System.Drawing.Point(864, 560)
        Me.CHK_ZEROQTY.Name = "CHK_ZEROQTY"
        Me.CHK_ZEROQTY.Size = New System.Drawing.Size(136, 24)
        Me.CHK_ZEROQTY.TabIndex = 462
        Me.CHK_ZEROQTY.Text = "WITH ZERO QTY"
        '
        'chk_itemwise
        '
        Me.chk_itemwise.BackgroundImage = CType(resources.GetObject("chk_itemwise.BackgroundImage"), System.Drawing.Image)
        Me.chk_itemwise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_itemwise.Location = New System.Drawing.Point(864, 592)
        Me.chk_itemwise.Name = "chk_itemwise"
        Me.chk_itemwise.TabIndex = 463
        Me.chk_itemwise.Text = "ITEMWISE"
        '
        'Lbl_SubledgerCode
        '
        Me.Lbl_SubledgerCode.AutoSize = True
        Me.Lbl_SubledgerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SubledgerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SubledgerCode.Location = New System.Drawing.Point(0, 512)
        Me.Lbl_SubledgerCode.Name = "Lbl_SubledgerCode"
        Me.Lbl_SubledgerCode.Size = New System.Drawing.Size(90, 18)
        Me.Lbl_SubledgerCode.TabIndex = 464
        Me.Lbl_SubledgerCode.Text = "ITEM  FROM:"
        '
        'TXT_FROM
        '
        Me.TXT_FROM.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROM.Location = New System.Drawing.Point(96, 512)
        Me.TXT_FROM.MaxLength = 20
        Me.TXT_FROM.Name = "TXT_FROM"
        Me.TXT_FROM.Size = New System.Drawing.Size(96, 26)
        Me.TXT_FROM.TabIndex = 465
        Me.TXT_FROM.Text = ""
        '
        'Cmd_ITEMFROM
        '
        Me.Cmd_ITEMFROM.Image = CType(resources.GetObject("Cmd_ITEMFROM.Image"), System.Drawing.Image)
        Me.Cmd_ITEMFROM.Location = New System.Drawing.Point(192, 512)
        Me.Cmd_ITEMFROM.Name = "Cmd_ITEMFROM"
        Me.Cmd_ITEMFROM.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ITEMFROM.TabIndex = 466
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 467
        Me.Label7.Text = "TO:"
        '
        'txt_itemto
        '
        Me.txt_itemto.BackColor = System.Drawing.Color.Wheat
        Me.txt_itemto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemto.Location = New System.Drawing.Point(312, 512)
        Me.txt_itemto.MaxLength = 20
        Me.txt_itemto.Name = "txt_itemto"
        Me.txt_itemto.Size = New System.Drawing.Size(96, 26)
        Me.txt_itemto.TabIndex = 468
        Me.txt_itemto.Text = ""
        '
        'cmd_itemto
        '
        Me.cmd_itemto.Image = CType(resources.GetObject("cmd_itemto.Image"), System.Drawing.Image)
        Me.cmd_itemto.Location = New System.Drawing.Point(408, 512)
        Me.cmd_itemto.Name = "cmd_itemto"
        Me.cmd_itemto.Size = New System.Drawing.Size(23, 26)
        Me.cmd_itemto.TabIndex = 469
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.ItemHeight = 13
        Me.cbo_Storelocation.Items.AddRange(New Object() {"GDN", "DRR", "MNS"})
        Me.cbo_Storelocation.Location = New System.Drawing.Point(608, 512)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(80, 21)
        Me.cbo_Storelocation.TabIndex = 458
        Me.cbo_Storelocation.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(352, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 24)
        Me.Label8.TabIndex = 472
        Me.Label8.Text = "SELECT SUBGROUP :"
        '
        'Chk_SelectAllSubgroup
        '
        Me.Chk_SelectAllSubgroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSubgroup.Location = New System.Drawing.Point(352, 248)
        Me.Chk_SelectAllSubgroup.Name = "Chk_SelectAllSubgroup"
        Me.Chk_SelectAllSubgroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllSubgroup.TabIndex = 470
        Me.Chk_SelectAllSubgroup.Text = "SELECT ALL"
        '
        'Chklist_SubGroup
        '
        Me.Chklist_SubGroup.CheckOnClick = True
        Me.Chklist_SubGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_SubGroup.Location = New System.Drawing.Point(352, 296)
        Me.Chklist_SubGroup.Name = "Chklist_SubGroup"
        Me.Chklist_SubGroup.Size = New System.Drawing.Size(264, 193)
        Me.Chklist_SubGroup.TabIndex = 471
        '
        'frmmainstockposition
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chk_SelectAllSubgroup)
        Me.Controls.Add(Me.Chklist_SubGroup)
        Me.Controls.Add(Me.cmd_itemto)
        Me.Controls.Add(Me.txt_itemto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_FROM)
        Me.Controls.Add(Me.Lbl_SubledgerCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.chk_itemwise_month)
        Me.Controls.Add(Me.Cmd_ITEMFROM)
        Me.Controls.Add(Me.chk_itemwise)
        Me.Controls.Add(Me.CHK_ZEROQTY)
        Me.Controls.Add(Me.chk_deptwise)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.chk_SelectAllStore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chklist_store)
        Me.Controls.Add(Me.chk_SelectAllGroup)
        Me.Controls.Add(Me.Chk_SelectAllItem)
        Me.Controls.Add(Me.grp_orderby)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.lbl_Itemlist)
        Me.Controls.Add(Me.chklist_itemdetails)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chklist_groupdesc)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmmainstockposition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT [ MAIN STOCK POSITION ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.frmbut.ResumeLayout(False)
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.grp_orderby.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub FillStore()
        Dim i As Integer
        sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER WHERE isnull(storestatus,'') <> 'M' ORDER BY STOREDESC ASC"
        sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC , STORECODE FROM STOREMASTER ORDER BY STOREDESC ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        'cbo_Storelocation.Items.Clear()
        chklist_store.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                ' cbo_Storelocation.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
                chklist_store.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC") & Space(100) & "-->" & gdataset.Tables("STOREMASTER").Rows(i).Item("STORECODE"))
            Next i
        End If
    End Sub

    Private Sub FillItemdetails()
        Dim i As Integer
        Dim sqlstring As String
        Chklist_Itemdetails.Items.Clear()
        sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER ORDER BY ITEMCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYITEMMASTER").Rows(i)
                    Chklist_Itemdetails.Items.Add(Trim(CStr(.Item("ITEMCODE"))) & "-->" & Trim(CStr(.Item("ITEMNAME"))))
                End With
            Next
        End If
    End Sub

    Private Sub FillGroupdetails()
        Dim i As Integer
        Dim sqlstring As String
        Chklist_Groupdesc.Items.Clear()
        sqlstring = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM INVENTORYGROUPMASTER ORDER BY GROUPCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYGROUPMASTER")
        If gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYGROUPMASTER").Rows(i)
                    Chklist_Groupdesc.Items.Add(Trim(CStr(.Item("GROUPDESC"))))
                End With
            Next
        End If
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If Chklist_Groupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text = "" And txt_itemto.Text = "" Then
            MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 152
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        If Chklist_Groupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text = "" And txt_itemto.Text = "" Then
            MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 152
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call FillStore()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        chklist_groupdesc.Items.Clear()
        Chklist_SubGroup.Items.Clear()
        chklist_itemdetails.Items.Clear()
        TXT_FROM.Text = ""
        txt_itemto.Text = ""
        chk_deptwise.Checked = False
        chk_itemwise_month.Checked = True
        Call FillGroupdetails()
        cbo_Storelocation.Visible = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        chklist_itemdetails.Focus()
    End Sub

    Private Sub Chklist_Groupdesc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_groupdesc.DoubleClick
        Dim i, J As Integer
        Dim sqlstring, ssql As String
        ssql = ""
        sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER AS I "
        sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' and I.GROUPNAME IN ("

        For J = 0 To chklist_groupdesc.CheckedItems.Count - 1
            If J = chklist_groupdesc.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "', "
            End If
        Next
        If chklist_groupdesc.CheckedItems.Count > 0 Then
            sqlstring = sqlstring & ssql & ") ORDER BY ITEMCODE "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                chklist_itemdetails.Items.Clear()
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        chklist_itemdetails.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
                    End With
                Next i
            End If
        End If
    End Sub

    Private Sub Chklist_Groupdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_groupdesc.SelectedIndexChanged
        'Dim i, J As Integer
        'Dim sqlstring, ssql As String
        'ssql = ""
        'sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER AS I "
        'sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' and I.GROUPNAME IN ("

        'For J = 0 To chklist_groupdesc.CheckedItems.Count - 1
        '    If J = chklist_groupdesc.CheckedItems.Count - 1 Then
        '        ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "' "
        '    Else
        '        ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "', "
        '    End If
        'Next
        'If chklist_groupdesc.CheckedItems.Count > 0 Then
        '    sqlstring = sqlstring & ssql & ") ORDER BY ITEMCODE "
        '    gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
        '    If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
        '        chklist_itemdetails.Items.Clear()
        '        For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
        '            With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
        '                chklist_itemdetails.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
        '            End With
        '        Next i
        '    End If
        'End If
        Dim i, J As Integer
        Dim sqlstring, ssql As String
        ssql = ""
        sqlstring = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER "
        sqlstring = sqlstring & " WHERE ISNULL(FREEZE,'') <> 'Y' AND GROUPDESC IN ("

        For J = 0 To chklist_groupdesc.CheckedItems.Count - 1
            If J = chklist_groupdesc.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "', "
            End If
        Next
        If chklist_groupdesc.CheckedItems.Count > 0 Then
            sqlstring = sqlstring & ssql & ") ORDER BY SUBGROUPCODE "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                Chklist_SubGroup.Items.Clear()
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        Chklist_SubGroup.Items.Add(Trim(CStr(.Item("SUBGROUPDESC"))))
                    End With
                Next i
            End If
        End If
    End Sub

    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SelectAllGroup.CheckedChanged
        Dim i As Integer
        If chk_SelectAllGroup.Checked = True Then
            For i = 0 To chklist_groupdesc.Items.Count - 1
                chklist_groupdesc.SetItemChecked(i, True)
            Next
            Call Chklist_Groupdesc_SelectedIndexChanged(sender, e)
        Else
            For i = 0 To chklist_groupdesc.Items.Count - 1
                chklist_groupdesc.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllItem.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllItem.Checked = True Then
            For i = 0 To chklist_itemdetails.Items.Count - 1
                chklist_itemdetails.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_itemdetails.Items.Count - 1
                chklist_itemdetails.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub dtp_Fromdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fromdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Todate.Focus()
        End If
    End Sub

    Private Sub dtp_Todate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Todate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub frmMainStockPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillStore()
        chklist_groupdesc.Items.Clear()
        chklist_itemdetails.Items.Clear()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000

        chk_itemwise_month.Checked = True
        Call FillGroupdetails()
        chklist_itemdetails.Focus()
        cbo_Storelocation.Visible = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INVENTORY' AND MODULENAME LIKE ' %" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub frmMainStockPosition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(Cmd_Print, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.F Then
            Me.dtp_Fromdate.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            Me.dtp_Todate.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F3 Then
            Dim search As New frmListSearch
            search.listbox = chklist_store
            search.Text = "Store Search"
            search.ShowDialog(Me)

        ElseIf e.KeyCode = Keys.F2 Then
            Dim search As New frmListSearch
            search.listbox = chklist_groupdesc
            search.Text = "Group Search"
            search.ShowDialog(Me)

        ElseIf e.KeyCode = Keys.F1 Then
            Dim Advsearch As New frmSearch_Advanced
            Advsearch.chklistbox = chklist_itemdetails
            Advsearch.ShowDialog(Me)
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000

            If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Issue Register") = MsgBoxResult.No Then
                If chk_itemwise.Checked = True Then
                    Call Viewissuesummary_itemwise1()
                ElseIf chk_itemwise_month.Checked = True Then
                    Call Viewissuesummary_itemwise_month1()
                ElseIf chk_deptwise.Checked = True Then
                    Call Viewissuesummary_deptwise1()
                Else
                    Call Viewissuesummary1()
                End If
               
            Else
                If chk_itemwise.Checked = True Then
                    Call Viewissuesummary_itemwise()
                ElseIf chk_itemwise_month.Checked = True Then
                    Call Viewissuesummary_itemwise_month()
                ElseIf chk_deptwise.Checked = True Then
                    Call Viewissuesummary_deptwise()
                Else
                    Call Viewissuesummary()
                End If
            End If


        End If
    End Sub
    Public Sub Viewissuesummary()
        Try
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer
            Dim rViewer As New Viewer
            Dim r As New Rpt_IssueSummary

            Storecode = "" : Clsquantity = "" : I = 0
            sqlstring = " SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREDESC = '" & Trim(cbo_Storelocation.Text) & "'"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                'storemaster = Nothing
            Else
                sqlstring = " SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREcode = 'MNS'"
                gconnection.getDataSet(sqlstring, "STOREMASTER")

            End If
            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If


            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                Storecode = gdataset.Tables("STOREMASTER").Rows(0).Item("STORECODE")
                '---------------------- EXECUTE STORE PROCEDURE --------------------------'
                gconnection.openConnection()
                gcommand = New SqlCommand("CP_ISSUESUMMARY", gconnection.Myconn)
                gcommand.CommandType = CommandType.StoredProcedure
                gcommand.CommandTimeout = 1000000000
                gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = Storecode
                gcommand.Parameters.Add(New SqlParameter("@STARTDATE", SqlDbType.DateTime)).Value = Format(CDate(dtp_Fromdate.Value), "dd/MM/yyyy")
                gcommand.Parameters.Add(New SqlParameter("@ENDDATE", SqlDbType.DateTime)).Value = Format(CDate(dtp_Todate.Value), "dd/MM/yyyy")
                gcommand.ExecuteNonQuery()
                gconnection.closeConnection()
                '--------------------------------------------------------------------------'
            Else
                MessageBox.Show("Select the Store Loc.", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.UOM,'') AS UOM, "
            sqlstring = sqlstring & " ISNULL(I.ISSUEQTY,0) AS ISSUEQTY,ISNULL(I.ISSUERATE,0) AS ISSUERATE, ISNULL(I.ISSUEAMOUNT,0) AS ISSUEAMOUNT, I.GROUPNAME FROM ISSUESUMMARY I, INVENTORYITEMMASTER M"
            If chklist_itemdetails.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE I.ITEMCODE=M.ITEMCODE "
                'sqlstring = sqlstring & " and M.storecode='" & Storecode & "'"
                sqlstring = sqlstring & " AND I.ITEMCODE IN ("
                For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                    Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(I.ISSUEQTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " ORDER BY I.GROUPNAME "
            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " ,I.ITEMCODE   "
            Else
                sqlstring = sqlstring & " ,I.ITEMDESC "
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ''---------------------- EXECUTE STORE PROCEDURE --------------------------'
        'gconnection.openConnection()
        'gcommand = New SqlCommand("CP_STOCKSUMMARY", gconnection.Myconn)
        'gcommand.CommandType = CommandType.StoredProcedure
        ''gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = "MNS"
        'gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = GETMAINSTORE()
        ''gcommand.Parameters.Add(New SqlParameter("@STARTDATE", SqlDbType.DateTime)).Value = Format(dtp_Fromdate.Value, "dd-MMM-yyyy")
        ''gcommand.Parameters.Add(New SqlParameter("@ENDDATE", SqlDbType.DateTime)).Value = Format(dtp_Todate.Value, "dd-MMM-yyyy")
        'gcommand.ExecuteNonQuery()
        'gconnection.closeConnection()
        ''--------------------------------------------------------------------------'
        'sqlstring = " SELECT ISNULL(ITEMCODE,'') AS ITEMCODE FROM STOCKSUMMARY "
        'gconnection.getDataSet(sqlstring, "STOCKSUMMARY")
        'If gdataset.Tables("STOCKSUMMARY").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("STOCKSUMMARY").Rows.Count - 1
        '        Itemcode1 = Trim(gdataset.Tables("STOCKSUMMARY").Rows(0).Item("ITEMCODE"))
        ''        Clsquantity = ClosingQuantity(Itemcode1, "MNS")
        '        Clsquantity = ClosingQuantity(Itemcode1, GETMAINSTORE())
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSQTY = '" & Trim(Clsquantity) & "' WHERE ITEMCODE = '" & Trim(Itemcode1) & "'"
        '        If Boolupdate = False Then
        '            Update(0) = sqlstring
        '            Boolupdate = True
        '        Else
        '            ReDim Preserve Update(Update.Length)
        '            Update(Update.Length - 1) = sqlstring
        '        End If
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSRATE= (SELECT TOP 1 ISNULL(RATE,0) FROM STOCKISSUEDETAIL WHERE STOCKISSUEDETAIL.ITEMCODE='" & Trim(Itemcode1) & "' AND ISNULL(VOID, '') <>  'Y'  ORDER BY RATE DESC ) WHERE CLSQTY <> 0"
        '        ReDim Preserve Update(Update.Length)
        '        Update(Update.Length - 1) = sqlstring
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSVAL  = ISNULL(CLSQTY,0) * ISNULL(CLSRATE,0) WHERE ITEMCODE = '" & Trim(Itemcode1) & "' "
        '        ReDim Preserve Update(Update.Length)
        '        Update(Update.Length - 1) = sqlstring
        '    Next
        '    gconnection.MoreTrans1(Update)
        'End If
        'sqlstring = " SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(VALUATION,'') AS VALUATION, "
        'sqlstring = sqlstring & " ISNULL(OPQTY,0) AS OPQTY,ISNULL(OPRATE,0) AS OPRATE,ISNULL(OPVAL,0) AS OPVAL,ISNULL(RCVQTY,0) AS RCVQTY, "
        'sqlstring = sqlstring & " ISNULL(RCVRATE,0) AS RCVRATE,ISNULL(RCVVAL,0) AS RCVVAL,ISNULL(ISSQTY,0) AS ISSQTY, "
        'sqlstring = sqlstring & " ISNULL(ISSRATE,0) AS ISSRATE,ISNULL(ISSVAL,0) AS ISSVAL,ISNULL(CLSQTY,0) AS CLSQTY,ISNULL(CLSRATE,0) AS CLSRATE, "
        'sqlstring = sqlstring & " ISNULL(CLSVAL,0) AS CLSVAL FROM STOCKSUMMARY ORDER BY ITEMCODE,ITEMNAME"
        ''gconnection.getDataSet(sqlstring, "GRIDVIEW")
        ''gridviewstatus = "Mainstockposition"
        ''Dim griddesign As New GridDesign
        ''griddesign.Show()
        'Dim heading() As String = {"STOCK SUMMARY "}
        'Dim ObjMainstocksummary As New rptMainstocksummary
        'ObjMainstocksummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)

    End Sub
    Public Sub Viewissuesummary1()
        Try
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer
            
            Storecode = "" : Clsquantity = "" : I = 0
            sqlstring = " SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREDESC = '" & Trim(cbo_Storelocation.Text) & "'"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                'storemaster = Nothing
            Else
                sqlstring = " SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREcode = 'MNS'"
                gconnection.getDataSet(sqlstring, "STOREMASTER")

            End If
            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If


            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                Storecode = gdataset.Tables("STOREMASTER").Rows(0).Item("STORECODE")
                '---------------------- EXECUTE STORE PROCEDURE --------------------------'
                gconnection.openConnection()
                gcommand = New SqlCommand("CP_ISSUESUMMARY", gconnection.Myconn)
                gcommand.CommandType = CommandType.StoredProcedure
                gcommand.CommandTimeout = 1000000000
                gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = Storecode
                gcommand.Parameters.Add(New SqlParameter("@STARTDATE", SqlDbType.DateTime)).Value = Format(CDate(dtp_Fromdate.Value), "dd/MM/yyyy")
                gcommand.Parameters.Add(New SqlParameter("@ENDDATE", SqlDbType.DateTime)).Value = Format(CDate(dtp_Todate.Value), "dd/MM/yyyy")
                gcommand.ExecuteNonQuery()
                gconnection.closeConnection()
                '--------------------------------------------------------------------------'
            Else
                MessageBox.Show("Select the Store Loc.", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.UOM,'') AS UOM, "
            sqlstring = sqlstring & " ISNULL(I.ISSUEQTY,0) AS ISSUEQTY,ISNULL(I.ISSUERATE,0) AS ISSUERATE, ISNULL(I.ISSUEAMOUNT,0) AS ISSUEAMOUNT, I.GROUPNAME FROM ISSUESUMMARY I, INVENTORYITEMMASTER M"
            If chklist_itemdetails.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE I.ITEMCODE=M.ITEMCODE "
                'sqlstring = sqlstring & " and M.storecode='" & Storecode & "'"
                sqlstring = sqlstring & " AND I.ITEMCODE IN ("
                For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                    Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(I.ISSUEQTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " ORDER BY I.GROUPNAME "
            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " ,I.ITEMCODE   "
            Else
                sqlstring = sqlstring & " ,I.ITEMDESC "
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ''---------------------- EXECUTE STORE PROCEDURE --------------------------'
        'gconnection.openConnection()
        'gcommand = New SqlCommand("CP_STOCKSUMMARY", gconnection.Myconn)
        'gcommand.CommandType = CommandType.StoredProcedure
        ''gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = "MNS"
        'gcommand.Parameters.Add(New SqlParameter("@STORECODE", SqlDbType.VarChar)).Value = GETMAINSTORE()
        ''gcommand.Parameters.Add(New SqlParameter("@STARTDATE", SqlDbType.DateTime)).Value = Format(dtp_Fromdate.Value, "dd-MMM-yyyy")
        ''gcommand.Parameters.Add(New SqlParameter("@ENDDATE", SqlDbType.DateTime)).Value = Format(dtp_Todate.Value, "dd-MMM-yyyy")
        'gcommand.ExecuteNonQuery()
        'gconnection.closeConnection()
        ''--------------------------------------------------------------------------'
        'sqlstring = " SELECT ISNULL(ITEMCODE,'') AS ITEMCODE FROM STOCKSUMMARY "
        'gconnection.getDataSet(sqlstring, "STOCKSUMMARY")
        'If gdataset.Tables("STOCKSUMMARY").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("STOCKSUMMARY").Rows.Count - 1
        '        Itemcode1 = Trim(gdataset.Tables("STOCKSUMMARY").Rows(0).Item("ITEMCODE"))
        ''        Clsquantity = ClosingQuantity(Itemcode1, "MNS")
        '        Clsquantity = ClosingQuantity(Itemcode1, GETMAINSTORE())
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSQTY = '" & Trim(Clsquantity) & "' WHERE ITEMCODE = '" & Trim(Itemcode1) & "'"
        '        If Boolupdate = False Then
        '            Update(0) = sqlstring
        '            Boolupdate = True
        '        Else
        '            ReDim Preserve Update(Update.Length)
        '            Update(Update.Length - 1) = sqlstring
        '        End If
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSRATE= (SELECT TOP 1 ISNULL(RATE,0) FROM STOCKISSUEDETAIL WHERE STOCKISSUEDETAIL.ITEMCODE='" & Trim(Itemcode1) & "' AND ISNULL(VOID, '') <>  'Y'  ORDER BY RATE DESC ) WHERE CLSQTY <> 0"
        '        ReDim Preserve Update(Update.Length)
        '        Update(Update.Length - 1) = sqlstring
        '        sqlstring = " UPDATE STOCKSUMMARY SET CLSVAL  = ISNULL(CLSQTY,0) * ISNULL(CLSRATE,0) WHERE ITEMCODE = '" & Trim(Itemcode1) & "' "
        '        ReDim Preserve Update(Update.Length)
        '        Update(Update.Length - 1) = sqlstring
        '    Next
        '    gconnection.MoreTrans1(Update)
        'End If
        'sqlstring = " SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(VALUATION,'') AS VALUATION, "
        'sqlstring = sqlstring & " ISNULL(OPQTY,0) AS OPQTY,ISNULL(OPRATE,0) AS OPRATE,ISNULL(OPVAL,0) AS OPVAL,ISNULL(RCVQTY,0) AS RCVQTY, "
        'sqlstring = sqlstring & " ISNULL(RCVRATE,0) AS RCVRATE,ISNULL(RCVVAL,0) AS RCVVAL,ISNULL(ISSQTY,0) AS ISSQTY, "
        'sqlstring = sqlstring & " ISNULL(ISSRATE,0) AS ISSRATE,ISNULL(ISSVAL,0) AS ISSVAL,ISNULL(CLSQTY,0) AS CLSQTY,ISNULL(CLSRATE,0) AS CLSRATE, "
        'sqlstring = sqlstring & " ISNULL(CLSVAL,0) AS CLSVAL FROM STOCKSUMMARY ORDER BY ITEMCODE,ITEMNAME"
        ''gconnection.getDataSet(sqlstring, "GRIDVIEW")
        ''gridviewstatus = "Mainstockposition"
        ''Dim griddesign As New GridDesign
        ''griddesign.Show()
        'Dim heading() As String = {"STOCK SUMMARY "}
        'Dim ObjMainstocksummary As New rptMainstocksummary
        'ObjMainstocksummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)

    End Sub
    Public Sub Viewissuesummary_itemwise()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer
            Dim rViewer As New Viewer
            Dim cryviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
            cryviewer.ActiveViewIndex = 0
            cryviewer.DisplayGroupTree = False

            Dim r As New Rpt_Itemwise_Issue

            Clsquantity = "" : I = 0

            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  , s.docdate , isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname  ,"
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, isnull(rate,0) rate , sum(isnull(amount,0)) amount  from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, isnull(rate,0) rate , sum(isnull(amount,0)) amount  from stockissuedetail s "



            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else

                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " WHERE S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname ,docdate , s.itemcode , s.itemname ,rate"
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode , S.docdate "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ITEMWISE ISSUE SUMMARY(STORES)"}
            If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Issue Register") = MsgBoxResult.No Then
                Dim ObjStockIssuesummary As New rptIssueSummaryItemWise
                ObjStockIssuesummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
            Else
                gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
                If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "ISSUESUMMARY"
                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text4")
                    textobj1.Text = MyCompanyName
                    Dim TXTOBJ2 As TextObject
                    Dim TXTOBJ3 As TextObject
                    TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                    rViewer.Refresh()
                    rViewer.Show()
                Else
                    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewissuesummary_itemwise1()
        Try

            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer


            Clsquantity = "" : I = 0

            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  , s.docdate , isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname  ,"
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, isnull(rate,0) rate , sum(isnull(amount,0)) amount  from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, isnull(rate,0) rate , sum(isnull(amount,0)) amount  from stockissuedetail s "



            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else

                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " WHERE S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname ,docdate , s.itemcode , s.itemname ,rate"
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode , S.docdate "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ITEMWISE ISSUE SUMMARY(STORES)"}
            Dim ObjStockIssuesummary As New rptIssueSummaryItemWise
            ObjStockIssuesummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)



        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub cbo_Storelocation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            dtp_Fromdate.Focus()
        End If
    End Sub

    Private Sub chk_SelectAllStore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SelectAllStore.CheckedChanged
        Dim i As Integer
        If chk_SelectAllStore.Checked = True Then
            For i = 0 To chklist_store.Items.Count - 1
                chklist_store.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_store.Items.Count - 1
                chklist_store.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Public Sub Viewissuesummary_itemwise_month()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer
            Dim rViewer As New Viewer
            Dim r As New Rpt_Itemwise_monthly_issue

            Clsquantity = "" : I = 0

            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  ,  isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname  ,"
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, sum(isnull(amount,0)) amount  from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, sum(isnull(amount,0)) amount  from stockissuedetail s "
            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else
                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " WHERE S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.storelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname , s.itemcode , s.itemname "
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ITEMWISE ISSUE SUMMARY-MONTHLY(STORES)"}
            If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Issue Register") = MsgBoxResult.No Then
                Dim ObjStockIssuesummary As New rptIssueItemWiseMonth
                ObjStockIssuesummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
            Else
                gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
                If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "ISSUESUMMARY"

                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text4")
                    textobj1.Text = MyCompanyName

                    Dim TXTOBJ3 As TextObject
                    TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                    rViewer.Refresh()
                    rViewer.ShowInTaskbar = True
                    rViewer.Show()
                Else
                    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub



    Public Sub Viewissuesummary_itemwise_month1()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer


            Clsquantity = "" : I = 0

            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  ,  isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname  ,"
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, sum(isnull(amount,0)) amount  from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, sum(isnull(amount,0)) amount  from stockissuedetail s "
            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else
                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " WHERE S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname , s.itemcode , s.itemname "
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ITEMWISE ISSUE SUMMARY-MONTHLY(STORES)"}
            Dim ObjStockIssuesummary As New rptIssueItemWiseMonth
            ObjStockIssuesummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)


        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewissuesummary_deptwise()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer
            Dim rViewer As New Viewer
            Dim r As New Rpt_deptwise

            Clsquantity = "" : I = 0
            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  ,"
            sqlstring = sqlstring & " isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname, "
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, (sum(isnull(amount,0))/ sum(isnull(qty,0))) as rate, sum(isnull(amount,0)) amount from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, (sum(isnull(amount,0))/ sum(isnull(qty,0))) as rate, sum(isnull(amount,0)) amount from stockissuedetail s "

            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else

                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " where S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.STORELOCATIONCODE = '" & Trim(cbo_Storelocation.Text) & "' "
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname , s.itemcode , s.itemname "
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ISSUE SUMMARY ITEMWISE" & "[ " & Trim(cbo_Storelocation.Text) & " ]"}
            gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
            If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "ISSUESUMMARY"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text4")
                textobj1.Text = MyCompanyName
                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                rViewer.Show()
            Else
                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewissuesummary_deptwise1()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim Boolupdate As Boolean
            Dim I As Integer


            Clsquantity = "" : I = 0
            sqlstring = " select 	isnull(s.opstorelocationcode,'')  opstorelocationcode, isnull(s.opstorelocationname,'') opstorelocationname  ,"
            sqlstring = sqlstring & " isnull(s.itemcode,'') itemcode , isnull(s.itemname,'') itemname, "
            'sqlstring = sqlstring & " sum(isnull(qty,0)) qty, (sum(isnull(amount,0))/ sum(isnull(qty,0))) as rate, sum(isnull(amount,0)) amount from stockissuedetail s , inventoryitemmaster i"
            sqlstring = sqlstring & " sum(isnull(qty,0)) qty, (sum(isnull(amount,0))/ sum(isnull(qty,0))) as rate, sum(isnull(amount,0)) amount from stockissuedetail s "

            If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                sqlstring = sqlstring & " where S.ITEMCODE BETWEEN '"
                sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            Else

                If chklist_itemdetails.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " where S.ITEMCODE IN ("
                    For I = 0 To chklist_itemdetails.CheckedItems.Count - 1
                        Itemcode = Split(chklist_itemdetails.CheckedItems(I), "-->")
                        sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If

            If chklist_store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND s.opstorelocationcode IN ("
                For I = 0 To chklist_store.CheckedItems.Count - 1
                    Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                    sqlstring = sqlstring & "'" & Itemcode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            If CHK_ZEROQTY.Checked = False Then
                sqlstring = sqlstring & " AND ISNULL(s.QTY,0) <> 0    "
            End If
            sqlstring = sqlstring & " AND s.STORELOCATIONCODE = '" & Trim(cbo_Storelocation.Text) & "' "
            sqlstring = sqlstring & " AND s.docdate between '" & Format(CDate(dtp_Fromdate.Value), "dd-MMM-yyyy") & "' and '" & Format(CDate(dtp_Todate.Value), "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " group by opstorelocationcode , opstorelocationname , s.itemcode , s.itemname "
            sqlstring = sqlstring & " ORDER BY s.opstorelocationcode "

            If rdo_code.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMCODE   "
            ElseIf rdo_name.Checked = True Then
                sqlstring = sqlstring & " , S.ITEMNAME   "
            End If

            Dim heading() As String = {"ISSUE SUMMARY ITEMWISE" & "[ " & Trim(cbo_Storelocation.Text) & " ]"}
            gconnection.getDataSet(sqlstring, "ISSUEREGISTER")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub chk_deptwise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_deptwise.CheckedChanged
        If chk_deptwise.Checked = True Then
            chk_itemwise_month.Checked = False
            chk_itemwise.Checked = False
            cbo_Storelocation.Visible = True
        Else
            cbo_Storelocation.Visible = False
        End If

    End Sub

    Private Sub Cmd_ITEMFROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ITEMFROM.Click
        Try
            Dim vform As New List_Operation
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim I As Integer

            gSQLString = " SELECT  itemcode,itemname  FROM INVENTORYITEMMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "

            If chk_deptwise.Checked = True Then
                M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(cbo_Storelocation.Text) & "'"
            Else
                If chklist_store.CheckedItems.Count <> 0 Then
                    M_WhereCondition = M_WhereCondition & " AND storecode IN ("
                    For I = 0 To chklist_store.CheckedItems.Count - 1
                        Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                        M_WhereCondition = M_WhereCondition & "'" & Itemcode(1) & "', "
                    Next
                    M_WhereCondition = Mid(M_WhereCondition, 1, Len(M_WhereCondition) - 2)
                    M_WhereCondition = M_WhereCondition & ")"
                Else
                    MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
            'vform.Field = "ITEMCODE"
            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_FROM.Text = Trim(vform.keyfield & "")
                'Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
                Me.txt_itemto.Focus()
            Else
                Me.TXT_FROM.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error :Cmd_ITEMFROM_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FROM.KeyPress
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_FROM.Text) = "" Then
                    Call Cmd_ITEMFROM_Click(Cmd_ITEMFROM, e)
                Else
                    Call TXT_FROM_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROM.Validated
        Try
            Dim sqlstring, itemcode() As String
            Dim i As Integer
            If Trim(TXT_FROM.Text) <> "" Then
                sqlstring = "select ITEMCODE, ITEMNAME from inventoryitemmaster where ITEMCODE = '" & Trim(TXT_FROM.Text) & "'"
                If chk_deptwise.Checked = True Then
                    sqlstring = sqlstring & " AND storecode = '" & Trim(cbo_Storelocation.Text) & "'"
                Else
                    If chklist_store.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND storecode IN ("
                        For i = 0 To chklist_store.CheckedItems.Count - 1
                            itemcode = Split(chklist_store.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & itemcode(1) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    TXT_FROM.Text = Trim(UCase(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ITEMCODE")))
                    txt_itemto.Focus()
                Else
                    TXT_FROM.Text = ""
                    TXT_FROM.Focus()
                End If
            Else
                ' Call Cmd_ITEMFROM_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_itemto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_itemto.Click
        Try
            Dim vform As New List_Operation
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim I As Integer
            gSQLString = " SELECT  itemcode,itemname  FROM INVENTORYITEMMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "
            If chk_deptwise.Checked = True Then
                M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(cbo_Storelocation.Text) & "'"
            Else

                If chklist_store.CheckedItems.Count <> 0 Then
                    M_WhereCondition = M_WhereCondition & " AND storecode IN ("
                    For I = 0 To chklist_store.CheckedItems.Count - 1
                        Itemcode = Split(chklist_store.CheckedItems(I), "-->")
                        M_WhereCondition = M_WhereCondition & "'" & Itemcode(1) & "', "
                    Next
                    M_WhereCondition = Mid(M_WhereCondition, 1, Len(M_WhereCondition) - 2)
                    M_WhereCondition = M_WhereCondition & ")"
                Else
                    MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_itemto.Text = Trim(vform.keyfield & "")
                'Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
                Me.Cmd_Print.Focus()
            Else
                Me.txt_itemto.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : cmd_itemto_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_itemto.Validated
        Try
            Dim sqlstring, itemcode() As String
            Dim i As Integer
            If Trim(txt_itemto.Text) <> "" Then
                sqlstring = "select ITEMCODE, ITEMNAME from inventoryitemmaster where ITEMCODE = '" & Trim(txt_itemto.Text) & "'"
                If chk_deptwise.Checked = True Then
                    sqlstring = sqlstring & " AND storecode = '" & Trim(cbo_Storelocation.Text) & "'"
                Else
                    If chklist_store.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND storecode IN ("
                        For i = 0 To chklist_store.CheckedItems.Count - 1
                            itemcode = Split(chklist_store.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & itemcode(1) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Store Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    txt_itemto.Text = Trim(UCase(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ITEMCODE")))
                    Cmd_Print.Focus()
                Else
                    txt_itemto.Text = ""
                    txt_itemto.Focus()
                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemto.KeyPress
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_FROM.Text) = "" Then
                    Call cmd_itemto_Click(cmd_itemto, e)
                Else
                    Call txt_itemto_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_itemto.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call cmd_itemto_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_FROM.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call Cmd_ITEMFROM_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub chk_itemwise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_itemwise.CheckedChanged
        chk_deptwise.Checked = False
    End Sub

    Private Sub chk_itemwise_month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_itemwise_month.CheckedChanged
        chk_deptwise.Checked = False
    End Sub

    Private Sub Chklist_SubGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_SubGroup.SelectedIndexChanged
        Dim i, J As Integer
        Dim sqlstring, ssql, ssql1 As String
        ssql = ""
        sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER AS I "
        sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' and I.GROUPNAME IN ("

        For J = 0 To chklist_groupdesc.CheckedItems.Count - 1
            If J = chklist_groupdesc.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & chklist_groupdesc.CheckedItems(J) & "', "
            End If
        Next
        For J = 0 To Chklist_SubGroup.CheckedItems.Count - 1
            If J = Chklist_SubGroup.CheckedItems.Count - 1 Then
                ssql1 = ssql1 & " '" & Chklist_SubGroup.CheckedItems(J) & "' "
            Else
                ssql1 = ssql1 & " '" & Chklist_SubGroup.CheckedItems(J) & "', "
            End If
        Next
        If ssql1 = "" Then ssql1 = "' '"
        If chklist_groupdesc.CheckedItems.Count > 0 Then
            chklist_itemdetails.Items.Clear()
            sqlstring = sqlstring & ssql & ") AND SUBGROUPNAME IN (" & ssql1 & ") order by itemcode "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        chklist_itemdetails.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
                    End With
                Next i
            End If
        End If
    End Sub

    Private Sub Chk_SelectAllSubgroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllSubgroup.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllSubgroup.Checked = True Then
            For i = 0 To Chklist_SubGroup.Items.Count - 1
                Chklist_SubGroup.SetItemChecked(i, True)
            Next
            Call Chklist_SubGroup_SelectedIndexChanged(sender, e)
        Else
            For i = 0 To Chklist_SubGroup.Items.Count - 1
                Chklist_SubGroup.SetItemChecked(i, False)
            Next
            Chk_SelectAllItem.Checked = False
        End If
    End Sub
End Class
