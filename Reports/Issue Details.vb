Imports CrystalDecisions.CrystalReports.Engine
Public Class Itemwise_Issue_details
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllStore As System.Windows.Forms.CheckBox
    Friend WithEvents chklst_Store As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChkRATE As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Storelocation As System.Windows.Forms.Label
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chklist_groupdesc As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Itemlist As System.Windows.Forms.Label
    Friend WithEvents chklist_itemdetails As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_itemto As System.Windows.Forms.Button
    Friend WithEvents txt_itemto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROM As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ITEMFROM As System.Windows.Forms.Button
    Friend WithEvents Lbl_SubledgerCode As System.Windows.Forms.Label
    Friend WithEvents CHK_ABC As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllSubgroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_SubGroup As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Itemwise_Issue_details))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_SelectAllStore = New System.Windows.Forms.CheckBox
        Me.chklst_Store = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkRATE = New System.Windows.Forms.CheckBox
        Me.lbl_Storelocation = New System.Windows.Forms.Label
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chklist_groupdesc = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox
        Me.lbl_Itemlist = New System.Windows.Forms.Label
        Me.chklist_itemdetails = New System.Windows.Forms.CheckedListBox
        Me.Chk_item = New System.Windows.Forms.CheckBox
        Me.cmd_itemto = New System.Windows.Forms.Button
        Me.txt_itemto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_FROM = New System.Windows.Forms.TextBox
        Me.Cmd_ITEMFROM = New System.Windows.Forms.Button
        Me.Lbl_SubledgerCode = New System.Windows.Forms.Label
        Me.CHK_ABC = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSubgroup = New System.Windows.Forms.CheckBox
        Me.Chklist_SubGroup = New System.Windows.Forms.CheckedListBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(392, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(195, 31)
        Me.lbl_Heading.TabIndex = 9
        Me.lbl_Heading.Text = "ISSUE DETAILS"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 24)
        Me.Label4.TabIndex = 429
        Me.Label4.Text = "STORE SELECTION :"
        '
        'Chk_SelectAllStore
        '
        Me.Chk_SelectAllStore.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllStore.Location = New System.Drawing.Point(40, 72)
        Me.Chk_SelectAllStore.Name = "Chk_SelectAllStore"
        Me.Chk_SelectAllStore.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllStore.TabIndex = 428
        Me.Chk_SelectAllStore.Text = "SELECT ALL "
        '
        'chklst_Store
        '
        Me.chklst_Store.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklst_Store.Location = New System.Drawing.Point(40, 120)
        Me.chklst_Store.Name = "chklst_Store"
        Me.chklst_Store.Size = New System.Drawing.Size(272, 361)
        Me.chklst_Store.TabIndex = 427
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(96, 664)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(795, 21)
        Me.Label5.TabIndex = 442
        Me.Label5.Text = "Press F1 for Advance Search Of Item/Press F3 to Search Store/Press F2 to GroupSea" & _
        "rch / Press ENTER key to navigate"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(160, 528)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 440
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(160, 528)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 441
        Me.GroupBox3.TabStop = False
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(184, 24)
        Me.dtp_Fromdate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Fromdate.TabIndex = 0
        Me.dtp_Fromdate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(400, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(504, 24)
        Me.dtp_Todate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Todate.TabIndex = 1
        Me.dtp_Todate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(56, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(528, 616)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 437
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(376, 616)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 436
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(672, 616)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 438
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(232, 616)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 435
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Location = New System.Drawing.Point(160, 600)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(712, 56)
        Me.frmbut.TabIndex = 439
        Me.frmbut.TabStop = False
        '
        'Timer1
        '
        '
        'ChkRATE
        '
        Me.ChkRATE.BackgroundImage = CType(resources.GetObject("ChkRATE.BackgroundImage"), System.Drawing.Image)
        Me.ChkRATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ChkRATE.Location = New System.Drawing.Point(880, 576)
        Me.ChkRATE.Name = "ChkRATE"
        Me.ChkRATE.TabIndex = 443
        Me.ChkRATE.Text = "WITH RATE "
        '
        'lbl_Storelocation
        '
        Me.lbl_Storelocation.AutoSize = True
        Me.lbl_Storelocation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Storelocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Storelocation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Storelocation.Location = New System.Drawing.Point(544, 496)
        Me.lbl_Storelocation.Name = "lbl_Storelocation"
        Me.lbl_Storelocation.Size = New System.Drawing.Size(134, 18)
        Me.lbl_Storelocation.TabIndex = 445
        Me.lbl_Storelocation.Text = "STORE LOCATION :"
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbo_Storelocation.ItemHeight = 19
        Me.cbo_Storelocation.Location = New System.Drawing.Point(696, 496)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(158, 27)
        Me.cbo_Storelocation.TabIndex = 444
        '
        'chk_SelectAllGroup
        '
        Me.chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.chk_SelectAllGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_SelectAllGroup.Location = New System.Drawing.Point(352, 80)
        Me.chk_SelectAllGroup.Name = "chk_SelectAllGroup"
        Me.chk_SelectAllGroup.Size = New System.Drawing.Size(128, 16)
        Me.chk_SelectAllGroup.TabIndex = 457
        Me.chk_SelectAllGroup.Text = "SELECT ALL"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(352, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 24)
        Me.Label2.TabIndex = 456
        Me.Label2.Text = "SELECT GROUPCODE :"
        '
        'chklist_groupdesc
        '
        Me.chklist_groupdesc.CheckOnClick = True
        Me.chklist_groupdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_groupdesc.Location = New System.Drawing.Point(352, 120)
        Me.chklist_groupdesc.Name = "chklist_groupdesc"
        Me.chklist_groupdesc.Size = New System.Drawing.Size(304, 130)
        Me.chklist_groupdesc.TabIndex = 455
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(688, 80)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(128, 16)
        Me.Chk_SelectAllItem.TabIndex = 460
        Me.Chk_SelectAllItem.Text = "SELECT ALL"
        '
        'lbl_Itemlist
        '
        Me.lbl_Itemlist.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Itemlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemlist.ForeColor = System.Drawing.Color.White
        Me.lbl_Itemlist.Location = New System.Drawing.Point(688, 96)
        Me.lbl_Itemlist.Name = "lbl_Itemlist"
        Me.lbl_Itemlist.Size = New System.Drawing.Size(248, 24)
        Me.lbl_Itemlist.TabIndex = 459
        Me.lbl_Itemlist.Text = "SELECT ITEMCODE :"
        '
        'chklist_itemdetails
        '
        Me.chklist_itemdetails.CheckOnClick = True
        Me.chklist_itemdetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_itemdetails.Location = New System.Drawing.Point(688, 120)
        Me.chklist_itemdetails.Name = "chklist_itemdetails"
        Me.chklist_itemdetails.Size = New System.Drawing.Size(248, 361)
        Me.chklist_itemdetails.TabIndex = 458
        '
        'Chk_item
        '
        Me.Chk_item.BackgroundImage = CType(resources.GetObject("Chk_item.BackgroundImage"), System.Drawing.Image)
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_item.Location = New System.Drawing.Point(880, 544)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(96, 24)
        Me.Chk_item.TabIndex = 461
        Me.Chk_item.Text = "ITEM WISE"
        '
        'cmd_itemto
        '
        Me.cmd_itemto.Image = CType(resources.GetObject("cmd_itemto.Image"), System.Drawing.Image)
        Me.cmd_itemto.Location = New System.Drawing.Point(400, 496)
        Me.cmd_itemto.Name = "cmd_itemto"
        Me.cmd_itemto.Size = New System.Drawing.Size(23, 26)
        Me.cmd_itemto.TabIndex = 481
        '
        'txt_itemto
        '
        Me.txt_itemto.BackColor = System.Drawing.Color.Wheat
        Me.txt_itemto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemto.Location = New System.Drawing.Point(304, 496)
        Me.txt_itemto.MaxLength = 20
        Me.txt_itemto.Name = "txt_itemto"
        Me.txt_itemto.Size = New System.Drawing.Size(96, 26)
        Me.txt_itemto.TabIndex = 480
        Me.txt_itemto.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 18)
        Me.Label3.TabIndex = 479
        Me.Label3.Text = "TO:"
        '
        'TXT_FROM
        '
        Me.TXT_FROM.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROM.Location = New System.Drawing.Point(128, 496)
        Me.TXT_FROM.MaxLength = 20
        Me.TXT_FROM.Name = "TXT_FROM"
        Me.TXT_FROM.Size = New System.Drawing.Size(96, 26)
        Me.TXT_FROM.TabIndex = 477
        Me.TXT_FROM.Text = ""
        '
        'Cmd_ITEMFROM
        '
        Me.Cmd_ITEMFROM.Image = CType(resources.GetObject("Cmd_ITEMFROM.Image"), System.Drawing.Image)
        Me.Cmd_ITEMFROM.Location = New System.Drawing.Point(224, 496)
        Me.Cmd_ITEMFROM.Name = "Cmd_ITEMFROM"
        Me.Cmd_ITEMFROM.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ITEMFROM.TabIndex = 478
        '
        'Lbl_SubledgerCode
        '
        Me.Lbl_SubledgerCode.AutoSize = True
        Me.Lbl_SubledgerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SubledgerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SubledgerCode.Location = New System.Drawing.Point(24, 504)
        Me.Lbl_SubledgerCode.Name = "Lbl_SubledgerCode"
        Me.Lbl_SubledgerCode.Size = New System.Drawing.Size(90, 18)
        Me.Lbl_SubledgerCode.TabIndex = 476
        Me.Lbl_SubledgerCode.Text = "ITEM  FROM:"
        '
        'CHK_ABC
        '
        Me.CHK_ABC.BackColor = System.Drawing.Color.Transparent
        Me.CHK_ABC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CHK_ABC.Location = New System.Drawing.Point(880, 600)
        Me.CHK_ABC.Name = "CHK_ABC"
        Me.CHK_ABC.Size = New System.Drawing.Size(104, 40)
        Me.CHK_ABC.TabIndex = 484
        Me.CHK_ABC.Text = "ABC-ISSUEWISE"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(354, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 24)
        Me.Label8.TabIndex = 487
        Me.Label8.Text = "SELECT SUBGROUP :"
        '
        'Chk_SelectAllSubgroup
        '
        Me.Chk_SelectAllSubgroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSubgroup.Location = New System.Drawing.Point(354, 251)
        Me.Chk_SelectAllSubgroup.Name = "Chk_SelectAllSubgroup"
        Me.Chk_SelectAllSubgroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllSubgroup.TabIndex = 485
        Me.Chk_SelectAllSubgroup.Text = "SELECT ALL"
        '
        'Chklist_SubGroup
        '
        Me.Chklist_SubGroup.CheckOnClick = True
        Me.Chklist_SubGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_SubGroup.Location = New System.Drawing.Point(354, 304)
        Me.Chklist_SubGroup.Name = "Chklist_SubGroup"
        Me.Chklist_SubGroup.Size = New System.Drawing.Size(302, 172)
        Me.Chklist_SubGroup.TabIndex = 486
        '
        'Itemwise_Issue_details
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chk_SelectAllSubgroup)
        Me.Controls.Add(Me.Chklist_SubGroup)
        Me.Controls.Add(Me.CHK_ABC)
        Me.Controls.Add(Me.cmd_itemto)
        Me.Controls.Add(Me.txt_itemto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_FROM)
        Me.Controls.Add(Me.Lbl_SubledgerCode)
        Me.Controls.Add(Me.lbl_Storelocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Cmd_ITEMFROM)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.Chk_SelectAllItem)
        Me.Controls.Add(Me.lbl_Itemlist)
        Me.Controls.Add(Me.chklist_itemdetails)
        Me.Controls.Add(Me.chk_SelectAllGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chklist_groupdesc)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.ChkRATE)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chk_SelectAllStore)
        Me.Controls.Add(Me.chklst_Store)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Itemwise_Issue_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTS [ITEM WISE ISSUE DETAILS ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim gconnection As New GlobalClass
    Dim Sqlstring As String
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If chklist_groupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ''If chklist_itemdetails.CheckedItems.Count = 0 Then
        ''    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    Exit Sub
        ''End If

        If chklst_Store.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Store Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 528
        grp_SalebillChecklist.Left = 160
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Issue Details") = MsgBoxResult.Yes Then
                Call ViewIssuedetails()
            Else
                Call ViewIssuedetails1()
            End If

        End If
    End Sub

    Private Sub ViewIssuedetails()
        Try
            Dim sqlstring, STORENAME() As String
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim i As Integer
            If Chk_item.Checked = False And CHK_ABC.Checked = False Then

                '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
                sqlstring = " SELECT * FROM ISSUEDETAILS"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                'ADDED ON 26122009
                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "

                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                'ADDED ON 26122009
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                'rgc 300110
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                'sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(cbo_Storelocation.Text) & "' "

                sqlstring = sqlstring & " ORDER BY LOCATIONNAME,GROUPDESC,ITEMCODE,ITEMNAME"

                Dim WITHRATE As Boolean
                Dim heading() As String = {"ISSUE DETAILS REPORT"}
                If ChkRATE.Checked = True Then
                    WITHRATE = True
                Else
                    WITHRATE = False
                End If
                If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Issue Details") = MsgBoxResult.Yes Then
                    Dim rViewer As New Viewer
                    Dim r As New Rpt_IssueDetails
                    gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
                    If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                        rViewer.ssql = sqlstring
                        rViewer.Report = r
                        rViewer.TableName = "ISSUEREGISTER"

                        Dim textobj1 As TextObject
                        textobj1 = r.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName
                        Dim TXTOBJ2 As TextObject
                        TXTOBJ2 = r.ReportDefinition.ReportObjects("Text16")
                        TXTOBJ2.Text = " Prepared By : " & gUsername
                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                        rViewer.Show()
                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
                    End If
                Else
                    Dim ObjStockIssuedetailsReport As New rptStockIssuedetails
                    ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)
                    'ObjStockIssuedetailsReport.Reportdetails_withoutGroup(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)
                End If
                '------------ITEMWISE REPORT-------------------------

            ElseIf Chk_item.Checked = True And CHK_ABC.Checked = False Then

                '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
                sqlstring = " SELECT ITEMCODE,groupdesc,LOCATIONNAME,ITEMNAME,UOM,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT FROM ISSUEDETAILS"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                'ADDED ON 26122009

                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                'ADDED ON 26122009
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                sqlstring = sqlstring & " GROUP BY ITEMCODE,ITEMNAME,UOM,GROUPDESC,LOCATIONNAME ORDER BY ITEMCODE"
                Dim heading() As String = {"ISSUE DETAILS REPORT"}
                Dim withrate As Boolean
                If ChkRATE.Checked = True Then
                    WITHRATE = True
                Else
                    WITHRATE = False
                End If
                If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Issue Details") = MsgBoxResult.Yes Then
                    Dim sViewer As New Viewer
                    Dim s As New Rpt_IssueDetails_item
                    gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
                    If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                        sViewer.ssql = sqlstring
                        sViewer.Report = s
                        sViewer.TableName = "ISSUEREGISTER"

                        Dim textobj1 As TextObject
                        textobj1 = s.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName
                        Dim TXTOBJ2 As TextObject
                        TXTOBJ2 = s.ReportDefinition.ReportObjects("Text16")
                        TXTOBJ2.Text = " Prepared By : " & gUsername
                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = s.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                        sViewer.Show()
                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
                    End If
                Else
                    Dim ObjStockIssuedetailsReport As New rptStockIssuedetails
                    ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)

                End If
            Else
                Dim sViewer As New Viewer
                Dim s As New Rpt_IssueDetails_item_ABC
                '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
                sqlstring = " SELECT ITEMCODE,ITEMNAME,UOM,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT,ABC FROM ISSUEDETAILS_ABC"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                'ADDED ON 26122009

                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                'ADDED ON 26122009
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                sqlstring = sqlstring & " GROUP BY ABC,ITEMCODE,ITEMNAME,UOM ORDER BY ABC"

                If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Issue Details") = MsgBoxResult.Yes Then

                    gconnection.getDataSet(sqlstring, "ISSUEREGISTER")
                    If gdataset.Tables("ISSUEREGISTER").Rows.Count > 0 Then
                        sViewer.ssql = sqlstring
                        sViewer.Report = s
                        sViewer.TableName = "ISSUEREGISTER_ABC"

                        Dim textobj1 As TextObject
                        textobj1 = s.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName

                        Dim TXTOBJ2 As TextObject
                        TXTOBJ2 = s.ReportDefinition.ReportObjects("Text16")
                        TXTOBJ2.Text = Trim(Mid(cbo_Storelocation.Text, 5, 12))

                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = s.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

                        sViewer.Show()
                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
                    End If
                Else
                    Dim heading() As String = {" ABC-WISE ISSUE DETAILS REPORT"}
                    Dim ObjStockIssuedetailsReport As New rptAbcIssueregister
                    ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
                End If
            End If
            '------------ITEMWISE REPORT-------------------------
            '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub ViewIssuedetails1()
        Try
            Dim sqlstring, STORENAME() As String
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim i As Integer
            If Chk_item.Checked = False And CHK_ABC.Checked = False Then

                '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
                sqlstring = " SELECT * FROM ISSUEDETAILS"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                'ADDED ON 26122009
                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "

                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                'ADDED ON 26122009
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                'rgc 300110
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                'sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(cbo_Storelocation.Text) & "' "

                sqlstring = sqlstring & " ORDER BY LOCATIONNAME,GROUPDESC,ITEMCODE,ITEMNAME"

                Dim WITHRATE As Boolean
                Dim heading() As String = {"ISSUE DETAILS REPORT"}
                If ChkRATE.Checked = True Then
                    WITHRATE = True
                Else
                    WITHRATE = False
                End If

                Dim ObjStockIssuedetailsReport As New rptStockIssuedetails
                ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)
                'ObjStockIssuedetailsReport.Reportdetails_withoutGroup(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)

                '------------ITEMWISE REPORT-------------------------

            ElseIf Chk_item.Checked = True And CHK_ABC.Checked = False Then

                '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
                sqlstring = " SELECT ITEMCODE,groupdesc,LOCATIONNAME,ITEMNAME,UOM,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT FROM ISSUEDETAILS"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                'ADDED ON 26122009

                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                'ADDED ON 26122009
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                sqlstring = sqlstring & " GROUP BY ITEMCODE,ITEMNAME,UOM,GROUPDESC,LOCATIONNAME ORDER BY ITEMCODE"
                Dim heading() As String = {"ISSUE DETAILS REPORT"}
                Dim withrate As Boolean
                If ChkRATE.Checked = True Then
                    WITHRATE = True
                Else
                    WITHRATE = False
                End If
                Dim ObjStockIssuedetailsReport As New rptStockIssuedetails
                ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)
            Else
                sqlstring = " SELECT ITEMCODE,ITEMNAME,UOM,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT,ABC FROM ISSUEDETAILS_ABC"
                If chklst_Store.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE LOCATIONNAME IN ("
                    For i = 0 To chklst_Store.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Trim(chklst_Store.CheckedItems(i)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Store Loc.(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                If chklist_itemdetails.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                    ' sqlstring = sqlstring & " WHERE I.ITEMCODE=s.ITEMCODE "
                    sqlstring = sqlstring & " AND ITEMCODE BETWEEN '"
                    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                Else
                    If chklist_itemdetails.CheckedItems.Count <> 0 Then
                        sqlstring = sqlstring & " AND ITEMCODE IN ("
                        For i = 0 To chklist_itemdetails.CheckedItems.Count - 1
                            Itemcode = Split(chklist_itemdetails.CheckedItems(i), "-->")
                            sqlstring = sqlstring & "'" & Itemcode(0) & "', "
                        Next
                        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                        sqlstring = sqlstring & ")"
                    Else
                        MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                End If
                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "  AND FROMSTORENAME = '" & Trim(Mid(cbo_Storelocation.Text, 5, 12)) & "' "
                sqlstring = sqlstring & " GROUP BY ABC,ITEMCODE,ITEMNAME,UOM ORDER BY ABC"

                Dim heading() As String = {" ABC-WISE ISSUE DETAILS REPORT"}
                Dim ObjStockIssuedetailsReport As New rptAbcIssueregister
                ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
            End If
            '------------ITEMWISE REPORT-------------------------
            '''****************************** $ ISSUE REGISTER [PCS ] $ *************************************'''
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub Itemwise_Issue_details_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
            search.listbox = chklst_Store
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

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click

        If chklist_groupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ''If chklist_itemdetails.CheckedItems.Count = 0 Then
        ''    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    Exit Sub
        ''End If
        If chklst_Store.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Store Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 528
        grp_SalebillChecklist.Left = 160
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
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

    Private Sub FillItemdetails()
        Dim i As Integer
        Dim sqlstring As String
        chklist_itemdetails.Items.Clear()
        sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER ORDER BY ITEMCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYITEMMASTER").Rows(i)
                    chklist_itemdetails.Items.Add(Trim(CStr(.Item("ITEMCODE"))) & "-->" & Trim(CStr(.Item("ITEMNAME"))))
                End With
            Next
        End If
    End Sub

    Private Sub FillGroupdetails()
        Dim i As Integer
        Dim sqlstring As String
        chklist_groupdesc.Items.Clear()
        sqlstring = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM INVENTORYGROUPMASTER ORDER BY GROUPCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYGROUPMASTER")
        If gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYGROUPMASTER").Rows(i)
                    chklist_groupdesc.Items.Add(Trim(CStr(.Item("GROUPDESC"))))
                End With
            Next
        End If
    End Sub

    Private Sub Itemwise_Issue_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillStorename()
        Call FillStore()
        chklist_groupdesc.Items.Clear()
        chklist_itemdetails.Items.Clear()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub FillStore()
        Dim i As Integer
        Sqlstring = "SELECT DISTINCT ISNULL(STOREcode,'') + '- '+ ISNULL(STOREdesc,'') AS STOREdesc FROM STOREMASTER WHERE isnull(storestatus,'') = 'M' and isnull(freeze,'') <> 'Y' ORDER BY STOREdesc ASC"
        gconnection.getDataSet(Sqlstring, "STOREMASTER")
        cbo_Storelocation.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                cbo_Storelocation.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREdesc"))
            Next i
        End If
    End Sub
    '''******************************  To fill POS details from SupplierName  *******************************'''
    Private Sub FillStorename()
        Dim i As Integer
        chklst_Store.Items.Clear()
        Sqlstring = "SELECT DISTINCT ISNULL(OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME  FROM STOCKISSUEHEADER ORDER BY OPSTORELOCATIONNAME"
        gconnection.getDataSet(Sqlstring, "STOCKISSUEHEADER")
        If gdataset.Tables("STOCKISSUEHEADER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("STOCKISSUEHEADER").Rows.Count - 1
                With gdataset.Tables("STOCKISSUEHEADER").Rows(i)
                    chklst_Store.Items.Add(Trim(.Item("OPSTORELOCATIONNAME")))
                End With
            Next i
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

    Private Sub Cmd_Clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        chklst_Store.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_SelectAllStore.Checked = False
        Call FillStorename()
        'ADDED ON 26122009
        TXT_FROM.Text = ""
        txt_itemto.Text = ""
        chklist_groupdesc.Items.Clear()
        Chklist_SubGroup.Items.Clear()
        chklist_itemdetails.Items.Clear()
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        dtp_Fromdate.Focus()
    End Sub

    Private Sub Chk_SelectAllStore_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllStore.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllStore.Checked = True Then
            For i = 0 To chklst_Store.Items.Count - 1
                chklst_Store.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklst_Store.Items.Count - 1
                chklst_Store.SetItemChecked(i, False)
            Next
        End If
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

    Private Sub Chk_SelectAllStore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllStore.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklst_Store.Focus()
        End If
    End Sub

    Private Sub chklst_Store_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chklst_Store.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Fromdate.Focus()
        End If
    End Sub

    Private Sub cbo_Storelocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Storelocation.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Fromdate.Focus()
        End If
    End Sub

    Private Sub Cmd_ITEMFROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ITEMFROM.Click
        Try
            Dim vform As New List_Operation
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim I As Integer
            gSQLString = " SELECT  itemcode,itemname  FROM INVENTORYITEMMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "
            M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"
            'select ITEMCODE, ITEMNAME from inventoryitemmaster AS INV ,STOREMASTER AS STO  where  INV.STORECODE= STO.STORECODE 
            '  AND STO.storeDESC = 'GODOWN'
            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_FROM.Text = Trim(vform.keyfield & "")
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
                sqlstring = sqlstring & " AND storecode = '" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"

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
            M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"

            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_itemto.Text = Trim(vform.keyfield & "")
                Me.dtp_Fromdate.Focus()
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
                sqlstring = sqlstring & " AND storecode = '" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"
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
                If Trim(txt_itemto.Text) = "" Then
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
