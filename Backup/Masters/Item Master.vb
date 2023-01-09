Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Item_Master
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ReorderLevel As System.Windows.Forms.Label
    Friend WithEvents lbl_SaleRate As System.Windows.Forms.Label
    Friend WithEvents lbl_MaxQty As System.Windows.Forms.Label
    Friend WithEvents lbl_PurchaseRate As System.Windows.Forms.Label
    Friend WithEvents lbl_MinQty As System.Windows.Forms.Label
    Friend WithEvents txt_ReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents txt_MinQty As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaxQty As System.Windows.Forms.TextBox
    Friend WithEvents txt_PurchaseRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaleRate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Valutaion As System.Windows.Forms.Label
    Friend WithEvents cbo_Valuation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_ReceivingUOM As System.Windows.Forms.Label
    Friend WithEvents lbl_SaleUOM As System.Windows.Forms.Label
    Friend WithEvents txt_Conversion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ConvValue As System.Windows.Forms.Label
    Friend WithEvents lbl_DoubleUnit As System.Windows.Forms.Label
    Friend WithEvents txt_OpeningStock As System.Windows.Forms.TextBox
    Friend WithEvents lbl_OpeningStock As System.Windows.Forms.Label
    Friend WithEvents lbl_LeadTime As System.Windows.Forms.Label
    Friend WithEvents txt_LeadTime As System.Windows.Forms.TextBox
    Friend WithEvents cbo_DoubleUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SubSubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubSubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubSubGroupCode As System.Windows.Forms.Button
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_GroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_GroupCode As System.Windows.Forms.Button
    Friend WithEvents lbl_SubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubGroupCode As System.Windows.Forms.Button
    Friend WithEvents txt_GroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubSubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Alias As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ItemCode As System.Windows.Forms.Button
    Friend WithEvents txt_ItemName As System.Windows.Forms.TextBox
    Friend WithEvents txt_ItemCode As System.Windows.Forms.TextBox
    Friend WithEvents cbo_SaleUOM As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_ReceivingUOM As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_StockUOM As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_StockUOM As System.Windows.Forms.Label
    Friend WithEvents lbl_Alias As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemName As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_OpeningAmount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_OpeningAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_CATEGORY As System.Windows.Forms.TextBox
    Friend WithEvents lbl_storecode As System.Windows.Forms.Label
    Friend WithEvents txt_Storecode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Storecode As System.Windows.Forms.Button
    Friend WithEvents txt_StoreDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_ClstK As System.Windows.Forms.Label
    Friend WithEvents lbl_Clval As System.Windows.Forms.Label
    Friend WithEvents lbl_Clvalue As System.Windows.Forms.Label
    Friend WithEvents lbl_Clstock As System.Windows.Forms.Label
    Friend WithEvents txt_avgRate As System.Windows.Forms.Label
    Friend WithEvents Cbo_ABC_category As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents txt_MRP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_CompanyDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_CompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_CompanyCode As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Targetqty As System.Windows.Forms.TextBox
    Friend WithEvents Btn_PosTag As System.Windows.Forms.Button
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Btn_UpdBOM As System.Windows.Forms.Button
    Friend WithEvents Grp_PosTag As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_TagClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Item_Master))
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_CompanyDesc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_CompanyCode = New System.Windows.Forms.TextBox
        Me.cmd_CompanyCode = New System.Windows.Forms.Button
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_ReorderLevel = New System.Windows.Forms.Label
        Me.lbl_SaleRate = New System.Windows.Forms.Label
        Me.lbl_MaxQty = New System.Windows.Forms.Label
        Me.lbl_PurchaseRate = New System.Windows.Forms.Label
        Me.lbl_MinQty = New System.Windows.Forms.Label
        Me.txt_ReorderLevel = New System.Windows.Forms.TextBox
        Me.txt_MinQty = New System.Windows.Forms.TextBox
        Me.txt_MaxQty = New System.Windows.Forms.TextBox
        Me.txt_PurchaseRate = New System.Windows.Forms.TextBox
        Me.txt_SaleRate = New System.Windows.Forms.TextBox
        Me.lbl_Valutaion = New System.Windows.Forms.Label
        Me.cbo_Valuation = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_ReceivingUOM = New System.Windows.Forms.Label
        Me.lbl_SaleUOM = New System.Windows.Forms.Label
        Me.txt_Conversion = New System.Windows.Forms.TextBox
        Me.lbl_ConvValue = New System.Windows.Forms.Label
        Me.lbl_DoubleUnit = New System.Windows.Forms.Label
        Me.txt_OpeningStock = New System.Windows.Forms.TextBox
        Me.lbl_OpeningStock = New System.Windows.Forms.Label
        Me.lbl_LeadTime = New System.Windows.Forms.Label
        Me.txt_LeadTime = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txt_Targetqty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_MRP = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cbo_DoubleUnit = New System.Windows.Forms.ComboBox
        Me.lbl_SubSubGroupCode = New System.Windows.Forms.Label
        Me.txt_SubSubGroupCode = New System.Windows.Forms.TextBox
        Me.cmd_SubSubGroupCode = New System.Windows.Forms.Button
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.txt_GroupCode = New System.Windows.Forms.TextBox
        Me.cmd_GroupCode = New System.Windows.Forms.Button
        Me.lbl_SubGroupCode = New System.Windows.Forms.Label
        Me.txt_SubGroupCode = New System.Windows.Forms.TextBox
        Me.cmd_SubGroupCode = New System.Windows.Forms.Button
        Me.txt_GroupDesc = New System.Windows.Forms.TextBox
        Me.txt_SubSubGroupDesc = New System.Windows.Forms.TextBox
        Me.txt_Alias = New System.Windows.Forms.TextBox
        Me.Cmd_ItemCode = New System.Windows.Forms.Button
        Me.txt_ItemName = New System.Windows.Forms.TextBox
        Me.txt_ItemCode = New System.Windows.Forms.TextBox
        Me.cbo_SaleUOM = New System.Windows.Forms.ComboBox
        Me.cbo_ReceivingUOM = New System.Windows.Forms.ComboBox
        Me.cbo_StockUOM = New System.Windows.Forms.ComboBox
        Me.lbl_StockUOM = New System.Windows.Forms.Label
        Me.lbl_Alias = New System.Windows.Forms.Label
        Me.lbl_ItemName = New System.Windows.Forms.Label
        Me.lbl_ItemCode = New System.Windows.Forms.Label
        Me.txt_SubGroupDesc = New System.Windows.Forms.TextBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_PosTag = New System.Windows.Forms.Button
        Me.txt_OpeningAmount = New System.Windows.Forms.TextBox
        Me.lbl_OpeningAmount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_storecode = New System.Windows.Forms.Label
        Me.txt_Storecode = New System.Windows.Forms.TextBox
        Me.Cmd_Storecode = New System.Windows.Forms.Button
        Me.txt_StoreDesc = New System.Windows.Forms.TextBox
        Me.lbl_ClstK = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_Clval = New System.Windows.Forms.Label
        Me.lbl_Clvalue = New System.Windows.Forms.Label
        Me.lbl_Clstock = New System.Windows.Forms.Label
        Me.txt_avgRate = New System.Windows.Forms.Label
        Me.Cbo_ABC_category = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.Grp_PosTag = New System.Windows.Forms.GroupBox
        Me.Btn_TagClose = New System.Windows.Forms.Button
        Me.Btn_UpdBOM = New System.Windows.Forms.Button
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Grp_PosTag.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(344, 596)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Freeze.TabIndex = 61
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_CATEGORY)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 192)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "CATEGORY :"
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.White
        Me.TXT_CATEGORY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(176, 120)
        Me.TXT_CATEGORY.MaxLength = 15
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(168, 26)
        Me.TXT_CATEGORY.TabIndex = 31
        Me.TXT_CATEGORY.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_CompanyDesc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_CompanyCode)
        Me.GroupBox2.Controls.Add(Me.cmd_CompanyCode)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 192)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'txt_CompanyDesc
        '
        Me.txt_CompanyDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_CompanyDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CompanyDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CompanyDesc.Location = New System.Drawing.Point(320, 116)
        Me.txt_CompanyDesc.MaxLength = 15
        Me.txt_CompanyDesc.Name = "txt_CompanyDesc"
        Me.txt_CompanyDesc.Size = New System.Drawing.Size(176, 26)
        Me.txt_CompanyDesc.TabIndex = 38
        Me.txt_CompanyDesc.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "COMPANY CODE :"
        '
        'txt_CompanyCode
        '
        Me.txt_CompanyCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_CompanyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CompanyCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CompanyCode.Location = New System.Drawing.Point(184, 116)
        Me.txt_CompanyCode.MaxLength = 15
        Me.txt_CompanyCode.Name = "txt_CompanyCode"
        Me.txt_CompanyCode.Size = New System.Drawing.Size(112, 26)
        Me.txt_CompanyCode.TabIndex = 35
        Me.txt_CompanyCode.Text = ""
        '
        'cmd_CompanyCode
        '
        Me.cmd_CompanyCode.Image = CType(resources.GetObject("cmd_CompanyCode.Image"), System.Drawing.Image)
        Me.cmd_CompanyCode.Location = New System.Drawing.Point(296, 116)
        Me.cmd_CompanyCode.Name = "cmd_CompanyCode"
        Me.cmd_CompanyCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_CompanyCode.TabIndex = 37
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(384, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(193, 31)
        Me.lbl_Heading.TabIndex = 25
        Me.lbl_Heading.Text = "ITEM  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ReorderLevel
        '
        Me.lbl_ReorderLevel.AutoSize = True
        Me.lbl_ReorderLevel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReorderLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReorderLevel.Location = New System.Drawing.Point(56, 272)
        Me.lbl_ReorderLevel.Name = "lbl_ReorderLevel"
        Me.lbl_ReorderLevel.Size = New System.Drawing.Size(133, 18)
        Me.lbl_ReorderLevel.TabIndex = 42
        Me.lbl_ReorderLevel.Text = "RE-ORDER LEVEL :"
        '
        'lbl_SaleRate
        '
        Me.lbl_SaleRate.AutoSize = True
        Me.lbl_SaleRate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SaleRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaleRate.Location = New System.Drawing.Point(525, 299)
        Me.lbl_SaleRate.Name = "lbl_SaleRate"
        Me.lbl_SaleRate.Size = New System.Drawing.Size(88, 18)
        Me.lbl_SaleRate.TabIndex = 49
        Me.lbl_SaleRate.Text = "SALE RATE :"
        '
        'lbl_MaxQty
        '
        Me.lbl_MaxQty.AutoSize = True
        Me.lbl_MaxQty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MaxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MaxQty.Location = New System.Drawing.Point(66, 328)
        Me.lbl_MaxQty.Name = "lbl_MaxQty"
        Me.lbl_MaxQty.Size = New System.Drawing.Size(116, 18)
        Me.lbl_MaxQty.TabIndex = 45
        Me.lbl_MaxQty.Text = "MAX QUANTITY :"
        '
        'lbl_PurchaseRate
        '
        Me.lbl_PurchaseRate.AutoSize = True
        Me.lbl_PurchaseRate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PurchaseRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurchaseRate.Location = New System.Drawing.Point(484, 267)
        Me.lbl_PurchaseRate.Name = "lbl_PurchaseRate"
        Me.lbl_PurchaseRate.Size = New System.Drawing.Size(129, 18)
        Me.lbl_PurchaseRate.TabIndex = 48
        Me.lbl_PurchaseRate.Text = "PURCHASE RATE :"
        '
        'lbl_MinQty
        '
        Me.lbl_MinQty.AutoSize = True
        Me.lbl_MinQty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MinQty.Location = New System.Drawing.Point(72, 298)
        Me.lbl_MinQty.Name = "lbl_MinQty"
        Me.lbl_MinQty.Size = New System.Drawing.Size(111, 18)
        Me.lbl_MinQty.TabIndex = 43
        Me.lbl_MinQty.Text = "MIN QUANTITY :"
        '
        'txt_ReorderLevel
        '
        Me.txt_ReorderLevel.BackColor = System.Drawing.Color.White
        Me.txt_ReorderLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ReorderLevel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ReorderLevel.Location = New System.Drawing.Point(224, 264)
        Me.txt_ReorderLevel.MaxLength = 15
        Me.txt_ReorderLevel.Name = "txt_ReorderLevel"
        Me.txt_ReorderLevel.Size = New System.Drawing.Size(168, 26)
        Me.txt_ReorderLevel.TabIndex = 6
        Me.txt_ReorderLevel.Text = ""
        Me.txt_ReorderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MinQty
        '
        Me.txt_MinQty.BackColor = System.Drawing.Color.White
        Me.txt_MinQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MinQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MinQty.Location = New System.Drawing.Point(224, 294)
        Me.txt_MinQty.MaxLength = 15
        Me.txt_MinQty.Name = "txt_MinQty"
        Me.txt_MinQty.Size = New System.Drawing.Size(168, 26)
        Me.txt_MinQty.TabIndex = 7
        Me.txt_MinQty.Text = ""
        Me.txt_MinQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MaxQty
        '
        Me.txt_MaxQty.BackColor = System.Drawing.Color.White
        Me.txt_MaxQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MaxQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaxQty.Location = New System.Drawing.Point(224, 328)
        Me.txt_MaxQty.MaxLength = 15
        Me.txt_MaxQty.Name = "txt_MaxQty"
        Me.txt_MaxQty.Size = New System.Drawing.Size(168, 26)
        Me.txt_MaxQty.TabIndex = 8
        Me.txt_MaxQty.Text = ""
        Me.txt_MaxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_PurchaseRate
        '
        Me.txt_PurchaseRate.BackColor = System.Drawing.Color.Wheat
        Me.txt_PurchaseRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PurchaseRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PurchaseRate.Location = New System.Drawing.Point(648, 264)
        Me.txt_PurchaseRate.MaxLength = 15
        Me.txt_PurchaseRate.Name = "txt_PurchaseRate"
        Me.txt_PurchaseRate.Size = New System.Drawing.Size(184, 26)
        Me.txt_PurchaseRate.TabIndex = 10
        Me.txt_PurchaseRate.Text = ""
        Me.txt_PurchaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SaleRate
        '
        Me.txt_SaleRate.BackColor = System.Drawing.Color.White
        Me.txt_SaleRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SaleRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaleRate.Location = New System.Drawing.Point(648, 296)
        Me.txt_SaleRate.MaxLength = 15
        Me.txt_SaleRate.Name = "txt_SaleRate"
        Me.txt_SaleRate.Size = New System.Drawing.Size(184, 26)
        Me.txt_SaleRate.TabIndex = 11
        Me.txt_SaleRate.Text = ""
        Me.txt_SaleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Valutaion
        '
        Me.lbl_Valutaion.AutoSize = True
        Me.lbl_Valutaion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Valutaion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Valutaion.Location = New System.Drawing.Point(521, 264)
        Me.lbl_Valutaion.Name = "lbl_Valutaion"
        Me.lbl_Valutaion.Size = New System.Drawing.Size(91, 18)
        Me.lbl_Valutaion.TabIndex = 47
        Me.lbl_Valutaion.Text = "VALUATION :"
        Me.lbl_Valutaion.Visible = False
        '
        'cbo_Valuation
        '
        Me.cbo_Valuation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Valuation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Valuation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Valuation.Items.AddRange(New Object() {"NONE", "AVERAGE"})
        Me.cbo_Valuation.Location = New System.Drawing.Point(648, 264)
        Me.cbo_Valuation.Name = "cbo_Valuation"
        Me.cbo_Valuation.Size = New System.Drawing.Size(184, 27)
        Me.cbo_Valuation.TabIndex = 9
        Me.cbo_Valuation.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Location = New System.Drawing.Point(48, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 120)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'lbl_ReceivingUOM
        '
        Me.lbl_ReceivingUOM.AutoSize = True
        Me.lbl_ReceivingUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReceivingUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReceivingUOM.Location = New System.Drawing.Point(60, 466)
        Me.lbl_ReceivingUOM.Name = "lbl_ReceivingUOM"
        Me.lbl_ReceivingUOM.Size = New System.Drawing.Size(113, 18)
        Me.lbl_ReceivingUOM.TabIndex = 52
        Me.lbl_ReceivingUOM.Text = "RECEIVIN UOM :"
        '
        'lbl_SaleUOM
        '
        Me.lbl_SaleUOM.AutoSize = True
        Me.lbl_SaleUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SaleUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaleUOM.Location = New System.Drawing.Point(92, 508)
        Me.lbl_SaleUOM.Name = "lbl_SaleUOM"
        Me.lbl_SaleUOM.Size = New System.Drawing.Size(83, 18)
        Me.lbl_SaleUOM.TabIndex = 53
        Me.lbl_SaleUOM.Text = "SALE UOM :"
        '
        'txt_Conversion
        '
        Me.txt_Conversion.BackColor = System.Drawing.Color.Wheat
        Me.txt_Conversion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Conversion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Conversion.Location = New System.Drawing.Point(648, 417)
        Me.txt_Conversion.MaxLength = 15
        Me.txt_Conversion.Name = "txt_Conversion"
        Me.txt_Conversion.Size = New System.Drawing.Size(184, 26)
        Me.txt_Conversion.TabIndex = 17
        Me.txt_Conversion.Text = "1.00"
        Me.txt_Conversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_ConvValue
        '
        Me.lbl_ConvValue.AutoSize = True
        Me.lbl_ConvValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ConvValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConvValue.Location = New System.Drawing.Point(504, 421)
        Me.lbl_ConvValue.Name = "lbl_ConvValue"
        Me.lbl_ConvValue.Size = New System.Drawing.Size(101, 18)
        Me.lbl_ConvValue.TabIndex = 58
        Me.lbl_ConvValue.Text = "CONV VALUE :"
        '
        'lbl_DoubleUnit
        '
        Me.lbl_DoubleUnit.AutoSize = True
        Me.lbl_DoubleUnit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DoubleUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DoubleUnit.Location = New System.Drawing.Point(504, 390)
        Me.lbl_DoubleUnit.Name = "lbl_DoubleUnit"
        Me.lbl_DoubleUnit.Size = New System.Drawing.Size(105, 18)
        Me.lbl_DoubleUnit.TabIndex = 57
        Me.lbl_DoubleUnit.Text = "DOUBLE UNIT :"
        '
        'txt_OpeningStock
        '
        Me.txt_OpeningStock.BackColor = System.Drawing.Color.Wheat
        Me.txt_OpeningStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OpeningStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OpeningStock.Location = New System.Drawing.Point(648, 450)
        Me.txt_OpeningStock.MaxLength = 15
        Me.txt_OpeningStock.Name = "txt_OpeningStock"
        Me.txt_OpeningStock.Size = New System.Drawing.Size(184, 26)
        Me.txt_OpeningStock.TabIndex = 18
        Me.txt_OpeningStock.Text = ""
        Me.txt_OpeningStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_OpeningStock
        '
        Me.lbl_OpeningStock.AutoSize = True
        Me.lbl_OpeningStock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OpeningStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OpeningStock.Location = New System.Drawing.Point(480, 458)
        Me.lbl_OpeningStock.Name = "lbl_OpeningStock"
        Me.lbl_OpeningStock.Size = New System.Drawing.Size(127, 18)
        Me.lbl_OpeningStock.TabIndex = 59
        Me.lbl_OpeningStock.Text = "OPENING STOCK :"
        '
        'lbl_LeadTime
        '
        Me.lbl_LeadTime.AutoSize = True
        Me.lbl_LeadTime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LeadTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LeadTime.Location = New System.Drawing.Point(88, 540)
        Me.lbl_LeadTime.Name = "lbl_LeadTime"
        Me.lbl_LeadTime.Size = New System.Drawing.Size(85, 18)
        Me.lbl_LeadTime.TabIndex = 54
        Me.lbl_LeadTime.Text = "LEAD TIME :"
        Me.lbl_LeadTime.Visible = False
        '
        'txt_LeadTime
        '
        Me.txt_LeadTime.BackColor = System.Drawing.Color.White
        Me.txt_LeadTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LeadTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LeadTime.Location = New System.Drawing.Point(224, 536)
        Me.txt_LeadTime.MaxLength = 15
        Me.txt_LeadTime.Name = "txt_LeadTime"
        Me.txt_LeadTime.Size = New System.Drawing.Size(88, 26)
        Me.txt_LeadTime.TabIndex = 15
        Me.txt_LeadTime.Text = ""
        Me.txt_LeadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_LeadTime.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Location = New System.Drawing.Point(440, 248)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(512, 120)
        Me.GroupBox6.TabIndex = 46
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.txt_Targetqty)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txt_MRP)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Location = New System.Drawing.Point(48, 368)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(384, 224)
        Me.GroupBox7.TabIndex = 50
        Me.GroupBox7.TabStop = False
        '
        'txt_Targetqty
        '
        Me.txt_Targetqty.BackColor = System.Drawing.Color.White
        Me.txt_Targetqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Targetqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Targetqty.Location = New System.Drawing.Point(176, 194)
        Me.txt_Targetqty.MaxLength = 15
        Me.txt_Targetqty.Name = "txt_Targetqty"
        Me.txt_Targetqty.Size = New System.Drawing.Size(88, 26)
        Me.txt_Targetqty.TabIndex = 56
        Me.txt_Targetqty.Text = ""
        Me.txt_Targetqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "TARGET QTY :"
        '
        'txt_MRP
        '
        Me.txt_MRP.BackColor = System.Drawing.Color.White
        Me.txt_MRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MRP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MRP.Location = New System.Drawing.Point(176, 16)
        Me.txt_MRP.MaxLength = 15
        Me.txt_MRP.Name = "txt_MRP"
        Me.txt_MRP.Size = New System.Drawing.Size(168, 26)
        Me.txt_MRP.TabIndex = 50
        Me.txt_MRP.Text = ""
        Me.txt_MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "MRP :"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.cbo_DoubleUnit)
        Me.GroupBox9.Location = New System.Drawing.Point(440, 368)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(512, 224)
        Me.GroupBox9.TabIndex = 56
        Me.GroupBox9.TabStop = False
        '
        'cbo_DoubleUnit
        '
        Me.cbo_DoubleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_DoubleUnit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_DoubleUnit.Location = New System.Drawing.Point(208, 16)
        Me.cbo_DoubleUnit.Name = "cbo_DoubleUnit"
        Me.cbo_DoubleUnit.Size = New System.Drawing.Size(184, 27)
        Me.cbo_DoubleUnit.TabIndex = 16
        '
        'lbl_SubSubGroupCode
        '
        Me.lbl_SubSubGroupCode.AutoSize = True
        Me.lbl_SubSubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubSubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubSubGroupCode.Location = New System.Drawing.Point(440, 133)
        Me.lbl_SubSubGroupCode.Name = "lbl_SubSubGroupCode"
        Me.lbl_SubSubGroupCode.Size = New System.Drawing.Size(170, 18)
        Me.lbl_SubSubGroupCode.TabIndex = 38
        Me.lbl_SubSubGroupCode.Text = "SUB SUB GROUP CODE :"
        '
        'txt_SubSubGroupCode
        '
        Me.txt_SubSubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupCode.Location = New System.Drawing.Point(624, 133)
        Me.txt_SubSubGroupCode.MaxLength = 15
        Me.txt_SubSubGroupCode.Name = "txt_SubSubGroupCode"
        Me.txt_SubSubGroupCode.Size = New System.Drawing.Size(112, 26)
        Me.txt_SubSubGroupCode.TabIndex = 5
        Me.txt_SubSubGroupCode.Text = ""
        '
        'cmd_SubSubGroupCode
        '
        Me.cmd_SubSubGroupCode.Image = CType(resources.GetObject("cmd_SubSubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubSubGroupCode.Location = New System.Drawing.Point(736, 133)
        Me.cmd_SubSubGroupCode.Name = "cmd_SubSubGroupCode"
        Me.cmd_SubSubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubSubGroupCode.TabIndex = 39
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(503, 71)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(106, 18)
        Me.lbl_GroupCode.TabIndex = 32
        Me.lbl_GroupCode.Text = "GROUP CODE :"
        '
        'txt_GroupCode
        '
        Me.txt_GroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupCode.Location = New System.Drawing.Point(624, 71)
        Me.txt_GroupCode.MaxLength = 15
        Me.txt_GroupCode.Name = "txt_GroupCode"
        Me.txt_GroupCode.Size = New System.Drawing.Size(112, 26)
        Me.txt_GroupCode.TabIndex = 3
        Me.txt_GroupCode.Text = ""
        '
        'cmd_GroupCode
        '
        Me.cmd_GroupCode.Image = CType(resources.GetObject("cmd_GroupCode.Image"), System.Drawing.Image)
        Me.cmd_GroupCode.Location = New System.Drawing.Point(736, 71)
        Me.cmd_GroupCode.Name = "cmd_GroupCode"
        Me.cmd_GroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_GroupCode.TabIndex = 33
        '
        'lbl_SubGroupCode
        '
        Me.lbl_SubGroupCode.AutoSize = True
        Me.lbl_SubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubGroupCode.Location = New System.Drawing.Point(471, 102)
        Me.lbl_SubGroupCode.Name = "lbl_SubGroupCode"
        Me.lbl_SubGroupCode.Size = New System.Drawing.Size(138, 18)
        Me.lbl_SubGroupCode.TabIndex = 35
        Me.lbl_SubGroupCode.Text = "SUB GROUP CODE :"
        '
        'txt_SubGroupCode
        '
        Me.txt_SubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupCode.Location = New System.Drawing.Point(624, 102)
        Me.txt_SubGroupCode.MaxLength = 15
        Me.txt_SubGroupCode.Name = "txt_SubGroupCode"
        Me.txt_SubGroupCode.Size = New System.Drawing.Size(112, 26)
        Me.txt_SubGroupCode.TabIndex = 4
        Me.txt_SubGroupCode.Text = ""
        '
        'cmd_SubGroupCode
        '
        Me.cmd_SubGroupCode.Image = CType(resources.GetObject("cmd_SubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubGroupCode.Location = New System.Drawing.Point(736, 102)
        Me.cmd_SubGroupCode.Name = "cmd_SubGroupCode"
        Me.cmd_SubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubGroupCode.TabIndex = 36
        '
        'txt_GroupDesc
        '
        Me.txt_GroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupDesc.Location = New System.Drawing.Point(760, 71)
        Me.txt_GroupDesc.MaxLength = 15
        Me.txt_GroupDesc.Name = "txt_GroupDesc"
        Me.txt_GroupDesc.Size = New System.Drawing.Size(176, 26)
        Me.txt_GroupDesc.TabIndex = 34
        Me.txt_GroupDesc.Text = ""
        '
        'txt_SubSubGroupDesc
        '
        Me.txt_SubSubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupDesc.Location = New System.Drawing.Point(760, 133)
        Me.txt_SubSubGroupDesc.MaxLength = 15
        Me.txt_SubSubGroupDesc.Name = "txt_SubSubGroupDesc"
        Me.txt_SubSubGroupDesc.Size = New System.Drawing.Size(176, 26)
        Me.txt_SubSubGroupDesc.TabIndex = 40
        Me.txt_SubSubGroupDesc.Text = ""
        '
        'txt_Alias
        '
        Me.txt_Alias.BackColor = System.Drawing.Color.White
        Me.txt_Alias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Alias.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Alias.Location = New System.Drawing.Point(224, 200)
        Me.txt_Alias.MaxLength = 50
        Me.txt_Alias.Name = "txt_Alias"
        Me.txt_Alias.Size = New System.Drawing.Size(168, 26)
        Me.txt_Alias.TabIndex = 2
        Me.txt_Alias.Text = ""
        '
        'Cmd_ItemCode
        '
        Me.Cmd_ItemCode.Image = CType(resources.GetObject("Cmd_ItemCode.Image"), System.Drawing.Image)
        Me.Cmd_ItemCode.Location = New System.Drawing.Point(368, 100)
        Me.Cmd_ItemCode.Name = "Cmd_ItemCode"
        Me.Cmd_ItemCode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ItemCode.TabIndex = 28
        '
        'txt_ItemName
        '
        Me.txt_ItemName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ItemName.Location = New System.Drawing.Point(224, 136)
        Me.txt_ItemName.MaxLength = 50
        Me.txt_ItemName.Name = "txt_ItemName"
        Me.txt_ItemName.Size = New System.Drawing.Size(200, 26)
        Me.txt_ItemName.TabIndex = 1
        Me.txt_ItemName.Text = ""
        '
        'txt_ItemCode
        '
        Me.txt_ItemCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ItemCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ItemCode.Location = New System.Drawing.Point(224, 100)
        Me.txt_ItemCode.MaxLength = 15
        Me.txt_ItemCode.Name = "txt_ItemCode"
        Me.txt_ItemCode.Size = New System.Drawing.Size(144, 26)
        Me.txt_ItemCode.TabIndex = 1
        Me.txt_ItemCode.Text = ""
        '
        'cbo_SaleUOM
        '
        Me.cbo_SaleUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_SaleUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SaleUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SaleUOM.Location = New System.Drawing.Point(224, 504)
        Me.cbo_SaleUOM.Name = "cbo_SaleUOM"
        Me.cbo_SaleUOM.Size = New System.Drawing.Size(168, 27)
        Me.cbo_SaleUOM.TabIndex = 14
        '
        'cbo_ReceivingUOM
        '
        Me.cbo_ReceivingUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_ReceivingUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ReceivingUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ReceivingUOM.Location = New System.Drawing.Point(224, 464)
        Me.cbo_ReceivingUOM.Name = "cbo_ReceivingUOM"
        Me.cbo_ReceivingUOM.Size = New System.Drawing.Size(168, 27)
        Me.cbo_ReceivingUOM.TabIndex = 13
        '
        'cbo_StockUOM
        '
        Me.cbo_StockUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_StockUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_StockUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_StockUOM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_StockUOM.Location = New System.Drawing.Point(224, 424)
        Me.cbo_StockUOM.Name = "cbo_StockUOM"
        Me.cbo_StockUOM.Size = New System.Drawing.Size(168, 27)
        Me.cbo_StockUOM.Sorted = True
        Me.cbo_StockUOM.TabIndex = 12
        '
        'lbl_StockUOM
        '
        Me.lbl_StockUOM.AutoSize = True
        Me.lbl_StockUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StockUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockUOM.Location = New System.Drawing.Point(80, 427)
        Me.lbl_StockUOM.Name = "lbl_StockUOM"
        Me.lbl_StockUOM.Size = New System.Drawing.Size(95, 18)
        Me.lbl_StockUOM.TabIndex = 51
        Me.lbl_StockUOM.Text = "STOCK UOM :"
        '
        'lbl_Alias
        '
        Me.lbl_Alias.AutoSize = True
        Me.lbl_Alias.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Alias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Alias.Location = New System.Drawing.Point(149, 203)
        Me.lbl_Alias.Name = "lbl_Alias"
        Me.lbl_Alias.Size = New System.Drawing.Size(52, 18)
        Me.lbl_Alias.TabIndex = 30
        Me.lbl_Alias.Text = "ALIAS :"
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemName.Location = New System.Drawing.Point(105, 140)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(89, 18)
        Me.lbl_ItemName.TabIndex = 29
        Me.lbl_ItemName.Text = "ITEM NAME :"
        '
        'lbl_ItemCode
        '
        Me.lbl_ItemCode.AutoSize = True
        Me.lbl_ItemCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemCode.Location = New System.Drawing.Point(107, 106)
        Me.lbl_ItemCode.Name = "lbl_ItemCode"
        Me.lbl_ItemCode.Size = New System.Drawing.Size(89, 18)
        Me.lbl_ItemCode.TabIndex = 27
        Me.lbl_ItemCode.Text = "ITEM CODE :"
        '
        'txt_SubGroupDesc
        '
        Me.txt_SubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupDesc.Location = New System.Drawing.Point(760, 102)
        Me.txt_SubGroupDesc.MaxLength = 15
        Me.txt_SubGroupDesc.Name = "txt_SubGroupDesc"
        Me.txt_SubGroupDesc.Size = New System.Drawing.Size(176, 26)
        Me.txt_SubGroupDesc.TabIndex = 37
        Me.txt_SubGroupDesc.Text = ""
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(80, 632)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 21
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(448, 632)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 23
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(320, 632)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 22
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(200, 632)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 20
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(688, 632)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 24
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Btn_PosTag)
        Me.GroupBox4.Location = New System.Drawing.Point(64, 624)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(872, 50)
        Me.GroupBox4.TabIndex = 62
        Me.GroupBox4.TabStop = False
        '
        'Btn_PosTag
        '
        Me.Btn_PosTag.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_PosTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_PosTag.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PosTag.ForeColor = System.Drawing.Color.White
        Me.Btn_PosTag.Image = CType(resources.GetObject("Btn_PosTag.Image"), System.Drawing.Image)
        Me.Btn_PosTag.Location = New System.Drawing.Point(736, 9)
        Me.Btn_PosTag.Name = "Btn_PosTag"
        Me.Btn_PosTag.Size = New System.Drawing.Size(104, 32)
        Me.Btn_PosTag.TabIndex = 25
        Me.Btn_PosTag.Text = "Pos Tagging"
        '
        'txt_OpeningAmount
        '
        Me.txt_OpeningAmount.BackColor = System.Drawing.Color.Wheat
        Me.txt_OpeningAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OpeningAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OpeningAmount.Location = New System.Drawing.Point(648, 489)
        Me.txt_OpeningAmount.MaxLength = 15
        Me.txt_OpeningAmount.Name = "txt_OpeningAmount"
        Me.txt_OpeningAmount.Size = New System.Drawing.Size(184, 26)
        Me.txt_OpeningAmount.TabIndex = 19
        Me.txt_OpeningAmount.Text = ""
        Me.txt_OpeningAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_OpeningAmount
        '
        Me.lbl_OpeningAmount.AutoSize = True
        Me.lbl_OpeningAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OpeningAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OpeningAmount.Location = New System.Drawing.Point(467, 493)
        Me.lbl_OpeningAmount.Name = "lbl_OpeningAmount"
        Me.lbl_OpeningAmount.Size = New System.Drawing.Size(139, 18)
        Me.lbl_OpeningAmount.TabIndex = 60
        Me.lbl_OpeningAmount.Text = "OPENING AMOUNT :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 541)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "[IN DAYS]"
        Me.Label1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(264, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 21)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'lbl_storecode
        '
        Me.lbl_storecode.AutoSize = True
        Me.lbl_storecode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_storecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_storecode.Location = New System.Drawing.Point(96, 74)
        Me.lbl_storecode.Name = "lbl_storecode"
        Me.lbl_storecode.Size = New System.Drawing.Size(103, 18)
        Me.lbl_storecode.TabIndex = 426
        Me.lbl_storecode.Text = "STORE CODE :"
        '
        'txt_Storecode
        '
        Me.txt_Storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Storecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Storecode.Location = New System.Drawing.Point(224, 69)
        Me.txt_Storecode.MaxLength = 15
        Me.txt_Storecode.Name = "txt_Storecode"
        Me.txt_Storecode.Size = New System.Drawing.Size(48, 26)
        Me.txt_Storecode.TabIndex = 0
        Me.txt_Storecode.Text = ""
        '
        'Cmd_Storecode
        '
        Me.Cmd_Storecode.BackColor = System.Drawing.Color.Bisque
        Me.Cmd_Storecode.Image = CType(resources.GetObject("Cmd_Storecode.Image"), System.Drawing.Image)
        Me.Cmd_Storecode.Location = New System.Drawing.Point(273, 68)
        Me.Cmd_Storecode.Name = "Cmd_Storecode"
        Me.Cmd_Storecode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_Storecode.TabIndex = 427
        '
        'txt_StoreDesc
        '
        Me.txt_StoreDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_StoreDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_StoreDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StoreDesc.Location = New System.Drawing.Point(297, 69)
        Me.txt_StoreDesc.MaxLength = 50
        Me.txt_StoreDesc.Name = "txt_StoreDesc"
        Me.txt_StoreDesc.Size = New System.Drawing.Size(128, 26)
        Me.txt_StoreDesc.TabIndex = 425
        Me.txt_StoreDesc.Text = ""
        '
        'lbl_ClstK
        '
        Me.lbl_ClstK.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClstK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ClstK.ForeColor = System.Drawing.Color.Black
        Me.lbl_ClstK.Location = New System.Drawing.Point(480, 524)
        Me.lbl_ClstK.Name = "lbl_ClstK"
        Me.lbl_ClstK.Size = New System.Drawing.Size(152, 24)
        Me.lbl_ClstK.TabIndex = 428
        Me.lbl_ClstK.Text = "CLOSING STOCK :"
        Me.lbl_ClstK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(492, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 429
        Me.Label3.Text = "AVERAGE RATE :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Clval
        '
        Me.lbl_Clval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clval.ForeColor = System.Drawing.Color.Black
        Me.lbl_Clval.Location = New System.Drawing.Point(482, 556)
        Me.lbl_Clval.Name = "lbl_Clval"
        Me.lbl_Clval.Size = New System.Drawing.Size(152, 24)
        Me.lbl_Clval.TabIndex = 431
        Me.lbl_Clval.Text = "CLOSING VALUE :"
        Me.lbl_Clval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Clvalue
        '
        Me.lbl_Clvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Clvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clvalue.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Clvalue.Location = New System.Drawing.Point(648, 556)
        Me.lbl_Clvalue.Name = "lbl_Clvalue"
        Me.lbl_Clvalue.Size = New System.Drawing.Size(184, 24)
        Me.lbl_Clvalue.TabIndex = 433
        Me.lbl_Clvalue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clstock
        '
        Me.lbl_Clstock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Clstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clstock.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Clstock.Location = New System.Drawing.Point(648, 524)
        Me.lbl_Clstock.Name = "lbl_Clstock"
        Me.lbl_Clstock.Size = New System.Drawing.Size(184, 24)
        Me.lbl_Clstock.TabIndex = 432
        Me.lbl_Clstock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_avgRate
        '
        Me.txt_avgRate.BackColor = System.Drawing.Color.Transparent
        Me.txt_avgRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_avgRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_avgRate.ForeColor = System.Drawing.Color.Blue
        Me.txt_avgRate.Location = New System.Drawing.Point(648, 328)
        Me.txt_avgRate.Name = "txt_avgRate"
        Me.txt_avgRate.Size = New System.Drawing.Size(184, 24)
        Me.txt_avgRate.TabIndex = 434
        Me.txt_avgRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cbo_ABC_category
        '
        Me.Cbo_ABC_category.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_ABC_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_ABC_category.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_ABC_category.Items.AddRange(New Object() {"", "A", "B", "C"})
        Me.Cbo_ABC_category.Location = New System.Drawing.Point(624, 195)
        Me.Cbo_ABC_category.Name = "Cbo_ABC_category"
        Me.Cbo_ABC_category.Size = New System.Drawing.Size(72, 27)
        Me.Cbo_ABC_category.TabIndex = 436
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 435
        Me.Label6.Text = "ABC  CATEGORY :"
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.Location = New System.Drawing.Point(568, 632)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 437
        Me.cmd_Print.Text = " Print[F10]"
        '
        'Grp_PosTag
        '
        Me.Grp_PosTag.Controls.Add(Me.Btn_TagClose)
        Me.Grp_PosTag.Controls.Add(Me.Btn_UpdBOM)
        Me.Grp_PosTag.Controls.Add(Me.ssgrid)
        Me.Grp_PosTag.Location = New System.Drawing.Point(696, 256)
        Me.Grp_PosTag.Name = "Grp_PosTag"
        Me.Grp_PosTag.Size = New System.Drawing.Size(256, 336)
        Me.Grp_PosTag.TabIndex = 438
        Me.Grp_PosTag.TabStop = False
        '
        'Btn_TagClose
        '
        Me.Btn_TagClose.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_TagClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_TagClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_TagClose.ForeColor = System.Drawing.Color.White
        Me.Btn_TagClose.Image = CType(resources.GetObject("Btn_TagClose.Image"), System.Drawing.Image)
        Me.Btn_TagClose.Location = New System.Drawing.Point(133, 296)
        Me.Btn_TagClose.Name = "Btn_TagClose"
        Me.Btn_TagClose.Size = New System.Drawing.Size(104, 32)
        Me.Btn_TagClose.TabIndex = 27
        Me.Btn_TagClose.Text = "Close"
        '
        'Btn_UpdBOM
        '
        Me.Btn_UpdBOM.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_UpdBOM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_UpdBOM.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdBOM.ForeColor = System.Drawing.Color.White
        Me.Btn_UpdBOM.Image = CType(resources.GetObject("Btn_UpdBOM.Image"), System.Drawing.Image)
        Me.Btn_UpdBOM.Location = New System.Drawing.Point(21, 296)
        Me.Btn_UpdBOM.Name = "Btn_UpdBOM"
        Me.Btn_UpdBOM.Size = New System.Drawing.Size(104, 32)
        Me.Btn_UpdBOM.TabIndex = 26
        Me.Btn_UpdBOM.Text = "Update"
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 8)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(240, 280)
        Me.ssgrid.TabIndex = 3
        '
        'Item_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.Controls.Add(Me.Grp_PosTag)
        Me.Controls.Add(Me.cmd_Print)
        Me.Controls.Add(Me.Cbo_ABC_category)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_PurchaseRate)
        Me.Controls.Add(Me.lbl_PurchaseRate)
        Me.Controls.Add(Me.lbl_storecode)
        Me.Controls.Add(Me.txt_Storecode)
        Me.Controls.Add(Me.txt_StoreDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_OpeningAmount)
        Me.Controls.Add(Me.lbl_OpeningAmount)
        Me.Controls.Add(Me.lbl_StockUOM)
        Me.Controls.Add(Me.lbl_Alias)
        Me.Controls.Add(Me.lbl_ItemName)
        Me.Controls.Add(Me.lbl_ItemCode)
        Me.Controls.Add(Me.txt_Alias)
        Me.Controls.Add(Me.txt_ItemName)
        Me.Controls.Add(Me.txt_ItemCode)
        Me.Controls.Add(Me.txt_SubSubGroupDesc)
        Me.Controls.Add(Me.txt_SubGroupDesc)
        Me.Controls.Add(Me.txt_GroupDesc)
        Me.Controls.Add(Me.lbl_SubSubGroupCode)
        Me.Controls.Add(Me.txt_SubSubGroupCode)
        Me.Controls.Add(Me.lbl_GroupCode)
        Me.Controls.Add(Me.txt_GroupCode)
        Me.Controls.Add(Me.lbl_SubGroupCode)
        Me.Controls.Add(Me.txt_SubGroupCode)
        Me.Controls.Add(Me.txt_OpeningStock)
        Me.Controls.Add(Me.lbl_OpeningStock)
        Me.Controls.Add(Me.lbl_DoubleUnit)
        Me.Controls.Add(Me.lbl_ReceivingUOM)
        Me.Controls.Add(Me.lbl_SaleUOM)
        Me.Controls.Add(Me.lbl_Valutaion)
        Me.Controls.Add(Me.txt_SaleRate)
        Me.Controls.Add(Me.txt_MaxQty)
        Me.Controls.Add(Me.txt_MinQty)
        Me.Controls.Add(Me.txt_ReorderLevel)
        Me.Controls.Add(Me.lbl_MinQty)
        Me.Controls.Add(Me.lbl_MaxQty)
        Me.Controls.Add(Me.lbl_SaleRate)
        Me.Controls.Add(Me.lbl_ReorderLevel)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_LeadTime)
        Me.Controls.Add(Me.txt_LeadTime)
        Me.Controls.Add(Me.lbl_ConvValue)
        Me.Controls.Add(Me.txt_Conversion)
        Me.Controls.Add(Me.txt_avgRate)
        Me.Controls.Add(Me.lbl_Clvalue)
        Me.Controls.Add(Me.lbl_Clstock)
        Me.Controls.Add(Me.lbl_Clval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_ClstK)
        Me.Controls.Add(Me.Cmd_Storecode)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.cbo_SaleUOM)
        Me.Controls.Add(Me.cbo_ReceivingUOM)
        Me.Controls.Add(Me.cbo_StockUOM)
        Me.Controls.Add(Me.Cmd_ItemCode)
        Me.Controls.Add(Me.cmd_SubSubGroupCode)
        Me.Controls.Add(Me.cmd_SubGroupCode)
        Me.Controls.Add(Me.cbo_Valuation)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.cmd_GroupCode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Item_Master"
        Me.Opacity = 0.5
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Grp_PosTag.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vardoublevalue As Double
    Dim gconnection As New GlobalClass

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL, ABCcategory As String
        Dim varpurchrate, varsalerate, avgrate, varmrp As Double
        Dim Insert(0), Update(0) As String

        If Trim(Cbo_ABC_category.Text) = "" Then
            ABCcategory = "A"
        Else
            ABCcategory = Cbo_ABC_category.Text
        End If

        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Val(txt_OpeningStock.Text) = 0 Then
                'avgrate = 0
                avgrate = Val(txt_PurchaseRate.Text)
            Else
                avgrate = Val(txt_OpeningAmount.Text) / Val(txt_OpeningStock.Text)
            End If
            '''************************************* For Inventory Item Master **********************************''''
            strSQL = "INSERT INTO inventoryitemmaster (itemcode,itemname,alias,groupcode,groupname,subgroupcode,subgroupname,"
            strSQL = strSQL & "subsubgroupcode,subsubgroupname,CompanyCode,CompanyName,reorderlevel,minqty,maxqty,valuation,purchaserate,salerate,stockuom,"
            strSQL = strSQL & "receiveuom,saleuom,leadtime,doubleuom,opstock,opvalue,convvalue,Freeze,Adduser,Adddate,CATEGORY,ABC,STORECODE,MRP,TargetQty) "
            strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Replace(Trim(txt_ItemName.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_Alias.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(txt_GroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_SubGroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_SubSubGroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_SubSubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_CompanyCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_CompanyDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " " & Val(txt_ReorderLevel.Text) & " ,"
            strSQL = strSQL & " " & Val(txt_MinQty.Text) & " ,"
            strSQL = strSQL & " " & Val(txt_MaxQty.Text) & " ,"
            strSQL = strSQL & " '" & Trim(cbo_Valuation.Text) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & " ,"
            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(cbo_ReceivingUOM.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(cbo_SaleUOM.Text) & "' ,"
            strSQL = strSQL & " " & Math.Round(Val(txt_LeadTime.Text)) & " ,"
            strSQL = strSQL & " '" & IIf(Trim(cbo_DoubleUnit.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_DoubleUnit.Text)) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.000") & " ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningAmount.Text), "0.00") & " ,"
            strSQL = strSQL & " " & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " ,"
            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(TXT_CATEGORY.Text) & "',"

            strSQL = strSQL & " '" & Trim(ABCcategory) & "' ,"
            strSQL = strSQL & "'" & Trim(txt_Storecode.Text) & "'," & Val(txt_MRP.Text) & "," & Val(txt_Targetqty.Text) & " )"

            'Dim MAINSTORE, QUERY As String
            'QUERY = "SELECT STORECODE FROM STOREMASTER WHERE STORESTATUS='M'"
            'gconnection.getDataSet(QUERY, "MAINSTORE")
            'If gdataset.Tables("MAINSTORE").Rows.Count > 0 Then
            '    MAINSTORE = Trim(gdataset.Tables("MAINSTORE").Rows(0).Item("STORECODE") & "")
            'End If
            'strSQL = strSQL & "'" & MAINSTORE & "' )"

            Insert(0) = strSQL
            '''************************************* For OpeningStock **********************************''''
            strSQL = "INSERT INTO openingstock(Itemcode,ItemName,mainOpstock,mainclstock,bar1opstock,bar1clstock,"
            strSQL = strSQL & " bar2opstock,bar2clstock,bar3opstock,bar3clstock,convuom,stockuom,doublevalue,bar1doublevalue, "
            strSQL = strSQL & " bar2doublevalue,bar3doublevalue,lowratio,highratio,avgrate,avgvalue,Adduser,Adddate)"
            strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.000") & "  ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.00") & " ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " '" & IIf(Trim(cbo_DoubleUnit.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_DoubleUnit.Text)) & "' , "
            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' , "
            strSQL = strSQL & " " & Val(vardoublevalue) & " , "
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 1 ,"
            strSQL = strSQL & " " & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " , "
            strSQL = strSQL & " " & Val(avgrate) & " , "
            strSQL = strSQL & " " & Format(Val(txt_OpeningAmount.Text), "0.00") & " , "
            strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL
            '''************************************* For InventoryRateHistory **********************************''''
            strSQL = "INSERT INTO inventoryratehistory (itemcode,itemname,modifydate,purchaserate,salerate,MRP,adduser,adddate)"
            strSQL = strSQL & " VALUES( '" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
            strSQL = strSQL & " '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & ","
            strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & "," & Format(Val(txt_MRP.Text), "0.00") & ","
            strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL
            gconnection.MoreTrans(Insert)
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Freezed Record Can't Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub
            '''************************************* For Inventory Item Master **********************************''''
            strSQL = "UPDATE inventoryitemmaster SET "
            strSQL = strSQL & " itemname='" & Replace(Trim(txt_ItemName.Text), "'", "") & "' ,"
            strSQL = strSQL & " STORECODE = '" & Trim(txt_Storecode.Text) & "' ,"
            strSQL = strSQL & " alias='" & Trim(txt_Alias.Text) & "' ,"
            strSQL = strSQL & " groupcode='" & Trim(txt_GroupCode.Text) & "' ,"
            strSQL = strSQL & " groupname='" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " subgroupcode='" & Trim(txt_SubGroupCode.Text) & "' ,"
            strSQL = strSQL & " subgroupname='" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " subsubgroupcode='" & Trim(txt_SubSubGroupCode.Text) & "' ,"
            strSQL = strSQL & " subsubgroupname='" & Replace(Trim(txt_SubSubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " CompanyCode='" & Trim(txt_CompanyCode.Text) & "' ,"
            strSQL = strSQL & " CompanyName='" & Replace(Trim(txt_CompanyDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " reorderlevel=" & Val(txt_ReorderLevel.Text) & " ,"
            strSQL = strSQL & " minqty=" & Val(txt_MinQty.Text) & " ,"
            strSQL = strSQL & " abc='" & Trim(ABCcategory) & "' ,"
            strSQL = strSQL & " maxqty=" & Val(txt_MaxQty.Text) & " ,"
            strSQL = strSQL & " valuation='" & Trim(cbo_Valuation.Text) & "' ,"
            strSQL = strSQL & " purchaserate=" & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & " salerate=" & Format(Val(txt_SaleRate.Text), "0.00") & " ,"
            strSQL = strSQL & " MRP=" & Format(Val(txt_MRP.Text), "0.00") & " ,"
            strSQL = strSQL & " TargetQty=" & Format(Val(txt_Targetqty.Text), "0.00") & " ,"
            strSQL = strSQL & " stockuom='" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " receiveuom='" & Trim(cbo_ReceivingUOM.Text) & "' ,"
            strSQL = strSQL & " saleuom='" & Trim(cbo_SaleUOM.Text) & "' ,"
            strSQL = strSQL & " leadtime=" & Math.Round(Val(txt_LeadTime.Text)) & " ,"
            strSQL = strSQL & " doubleuom='" & Trim(cbo_DoubleUnit.Text) & "' ,"
            strSQL = strSQL & " opstock=" & Format(Val(txt_OpeningStock.Text), "0.000") & " ,"
            strSQL = strSQL & " opvalue=" & Format(Val(txt_OpeningAmount.Text), "0.00") & " ,"
            strSQL = strSQL & " convvalue=" & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " ,"
            strSQL = strSQL & " Freeze='N',Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',"
            strSQL = strSQL & " CATEGORY = '" & Trim(TXT_CATEGORY.Text) & "'"
            strSQL = strSQL & " WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            strSQL = strSQL & " AND storecode='" & Trim(txt_Storecode.Text) & "'"
            Update(0) = strSQL
            '''************************************* For OpeningStock **********************************''''
            If Val(txt_OpeningStock.Text) = 0 Then
                'avgrate = 0
                avgrate = Val(txt_PurchaseRate.Text)
            Else
                avgrate = Val(txt_OpeningAmount.Text) / Val(txt_OpeningStock.Text)
            End If

            sqlstring = "SELECT * FROM openingstock WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "opstock")
            If gdataset.Tables("opstock").Rows.Count > 0 Then
                strSQL = "UPDATE openingstock SET "
                strSQL = strSQL & " ItemName='" & Trim(txt_ItemName.Text) & "' ,"
                strSQL = strSQL & " convuom='" & Trim(cbo_DoubleUnit.Text) & "' , "
                strSQL = strSQL & " stockuom='" & Trim(cbo_StockUOM.Text) & "' , "
                strSQL = strSQL & " doublevalue=" & Format(Val(vardoublevalue), "0.00") & " , "
                strSQL = strSQL & " lowratio= 1 ,"
                strSQL = strSQL & " highratio=" & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " , "
                strSQL = strSQL & " avgrate=" & Val(avgrate) & " , "
                strSQL = strSQL & " avgvalue=" & Format(Val(txt_OpeningAmount.Text), "0.00") & " , "
                strSQL = strSQL & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "'"
                strSQL = strSQL & " WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = strSQL
            Else
                strSQL = "INSERT INTO openingstock(Itemcode,ItemName,mainOpstock,mainclstock,bar1opstock,bar1clstock,"
                strSQL = strSQL & " bar2opstock,bar2clstock,bar3opstock,bar3clstock,convuom,stockuom,doublevalue,bar1doublevalue, "
                strSQL = strSQL & " bar2doublevalue,bar3doublevalue,lowratio,highratio,avgrate,avgvalue,Adduser,Adddate)"
                strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
                strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.000") & "  ,"
                strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.00") & " ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " '" & IIf(Trim(cbo_DoubleUnit.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_DoubleUnit.Text)) & "' , "
                strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' , "
                strSQL = strSQL & " " & Val(vardoublevalue) & " , "
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 0 ,"
                strSQL = strSQL & " 1 ,"
                strSQL = strSQL & " " & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " , "
                strSQL = strSQL & " " & Val(avgrate) & " , "
                strSQL = strSQL & " " & Format(Val(txt_OpeningAmount.Text), "0.00") & " , "
                strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = strSQL

            End If
            '''*************************************                         
            sqlstring = "SELECT ISNULL(MRP,0) AS MRP,* FROM inventoryratehistory WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' ORDER BY MODIFYDATE DESC "
            gconnection.getDataSet(sqlstring, "inventoryratehistory")
            If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
                varpurchrate = Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("purchaserate"))
                varsalerate = Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("salerate"))
                varmrp = Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("MRP"))
            End If
            '''*************************************
            '''************************************* For InventoryRateHistory **********************************''''
            If Val(txt_PurchaseRate.Text) <> Val(varpurchrate) Or Val(txt_SaleRate.Text) <> Val(varsalerate) Or Val(txt_MRP.Text) <> Val(varmrp) Then
                strSQL = "INSERT INTO inventoryratehistory (itemcode,itemname,modifydate,purchaserate,salerate,MRP,adduser,adddate)"
                strSQL = strSQL & " VALUES( '" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
                strSQL = strSQL & " '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' ,"
                strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & ","
                strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & "," & Format(Val(txt_MRP.Text), "0.00") & ","
                strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = strSQL
            End If

            If txt_Storecode.Text = "MNS" Then
                strSQL = " update  inventoryitemmaster set alias='" & Trim(txt_Alias.Text) & "'  where itemcode='" & Trim(txt_ItemCode.Text) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = strSQL
            End If

            gconnection.MoreTrans(Update)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
            End If

    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Storecode Can't be blank *********************''
        If Trim(txt_Storecode.Text) = "" Then
            MessageBox.Show(" Store Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Storecode.Focus()
            Exit Sub
        End If
        '''********** Check  Storedesc Can't be blank *********************''
        If Trim(txt_StoreDesc.Text) = "" Then
            MessageBox.Show(" Store Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Storecode.Focus()
            Exit Sub
        End If
        '''********** Check  ItemCode Can't be blank *********************'''
        If Trim(txt_ItemCode.Text) = "" Then
            MessageBox.Show(" Item Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_ItemCode.Focus()
            Exit Sub
        End If
        '''********** Check  ItemName Can't be blank *********************'''
        If Trim(txt_ItemName.Text) = "" Then
            MessageBox.Show(" Item Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_ItemName.Focus()
            Exit Sub
        End If
        If Trim(TXT_CATEGORY.Text) = "" Then
            MessageBox.Show(" Category can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_CATEGORY.Focus()
            Exit Sub
        End If
        '''********** Check  GroupCode Can't be blank *********************''
        If Trim(txt_GroupCode.Text) = "" Then
            MessageBox.Show(" Group Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  GroupDesc Can't be blank *********************'''
        If Trim(txt_GroupDesc.Text) = "" Then
            MessageBox.Show(" Group Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupDesc.Focus()
            Exit Sub
        End If
        '''********** Check  CompanyCode Can't be blank *********************''
        If Trim(txt_CompanyCode.Text) = "" Then
            MessageBox.Show(" Comapny Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CompanyCode.Focus()
            Exit Sub
        End If
        '''********** Check  CompanyDesc Can't be blank *********************'''
        If Trim(txt_CompanyDesc.Text) = "" Then
            MessageBox.Show(" Company Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CompanyDesc.Focus()
            Exit Sub
        End If
        '''********** Check  SubGroupCode Can't be blank *********************'''
        If Trim(txt_SubGroupCode.Text) = "" Then
            MessageBox.Show(" SubGroup Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubGroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  SubGroupDesc Can't be blank *********************'''
        If Trim(txt_SubGroupDesc.Text) = "" Then
            MessageBox.Show(" SubGroup Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubGroupDesc.Focus()
            Exit Sub
        End If
        '''********** Check  SubSubGroupCode Can't be blank *********************'''
        If Trim(txt_SubSubGroupCode.Text) = "" Then
            MessageBox.Show(" SubSubGroup Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubSubGroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  SubSubGroupDesc Can't be blank *********************'''
        If Trim(txt_SubSubGroupDesc.Text) = "" Then
            MessageBox.Show(" SubSubGroup Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubSubGroupDesc.Focus()
            Exit Sub
        End If
        '''********** Check  Valuation Can't be blank *********************'''
        'If Trim(cbo_Valuation.Text) = "" Then
        '    MessageBox.Show(" Valuation can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cbo_Valuation.Focus()
        '    Exit Sub
        'End If
        '''********** Check  PurchaseRate Can't be blank *********************'''
        If Val(txt_PurchaseRate.Text) = 0 Then
            MessageBox.Show(" Purchase Rate can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_PurchaseRate.Focus()
            Exit Sub
        End If
        '''********** Check  SaleRate Can't be blank *********************'''
        'If Val(txt_SaleRate.Text) = 0 Then
        '    MessageBox.Show(" Sale Rate can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_SaleRate.Focus()
        '    Exit Sub
        'End If
        'If Val(txt_SaleRate.Text) > 0 Then
        '    'If Val(txt_SaleRate.Text) <= Val(txt_PurchaseRate.Text) Then
        '    'MessageBox.Show(" Purchase Rate can't be greater then Sale rate ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    MessageBox.Show(" Sale rate can't be zero or blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_SaleRate.Focus()
        '    Exit Sub
        '    'End If
        'End If
        '''********** Check  StockUOM Can't be blank *********************'''
        If Trim(cbo_StockUOM.Text) = "" Then
            MessageBox.Show(" Stock UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_StockUOM.Focus()
            Exit Sub
        End If
        '''********** Check  ReceivingUOM Can't be blank *********************'''
        If Trim(cbo_ReceivingUOM.Text) = "" Then
            MessageBox.Show(" Receiving UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_ReceivingUOM.Focus()
            Exit Sub
        End If
        '''********** Check  SaleUOM Can't be blank *********************'''
        If Trim(cbo_SaleUOM.Text) = "" Then
            MessageBox.Show(" Sale UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_SaleUOM.Focus()
            Exit Sub
        End If
        '''********** Check  DoubleUnit Can't be blank *********************'''
        'If Trim(cbo_DoubleUnit.Text) = "" Then
        '    MessageBox.Show(" Double Unit can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cbo_DoubleUnit.Focus()
        '    Exit Sub
        'End If
        ''''********** Check  Conversion Can't be blank *********************'''
        'If Trim(txt_Conversion.Text) = "" Then
        '    MessageBox.Show(" Conversion Value can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_Conversion.Focus()
        '    Exit Sub
        'End If
        ''''********** Check  OpeningStock Can't be blank *********************'''
        'If Trim(txt_OpeningStock.Text) = "" Then
        '    MessageBox.Show(" Opening Stock can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_OpeningStock.Focus()
        '    Exit Sub
        'End If
        '''************ Calculate doublevalue ********************************'''
        vardoublevalue = IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) * IIf(Format(Val(txt_OpeningStock.Text), "0.000") = 0, 1, Val(txt_OpeningStock.Text))
        boolchk = True
    End Sub

    Private Sub Item_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim STR As String
        STR = " UPDATE INVENTORYItemmaster SET TAXPER = (SELECT SUM(ISNULL(TAXPERCENTAGE,0)) FROM  ACCOUNTSTAXgroupmaster WHERE ISNULL(VOID,'N')<>'Y' "
        STR = STR & "AND INVENTORYItemmaster.TAXGROUPCODE=GROUPCODE ) "
        gconnection.dataOperation(6, STR, "item")

        txt_ItemCode.Enabled = True
        txt_ItemCode.ReadOnly = False
        txt_ItemName.ReadOnly = False
        txt_OpeningAmount.ReadOnly = False
        txt_OpeningStock.ReadOnly = False
        txt_GroupCode.ReadOnly = False
        txt_SubGroupCode.ReadOnly = False
        txt_SubSubGroupCode.ReadOnly = False
        Grp_PosTag.Visible = False
        ItemMasterbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call FillUOM()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INV' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
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
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Call FillUOM()
        Cbo_ABC_category.Text = ""
        TXT_CATEGORY.Text = ""
        txt_Storecode.Text = ""
        txt_StoreDesc.Text = ""
        txt_CompanyCode.Text = ""
        txt_CompanyDesc.Text = ""

        ssgrid.ClearRange(1, 1, -1, -1, True)
        ssgrid.SetActiveCell(1, 1)
        Grp_PosTag.Visible = False

        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Clstock.Text = ""
        Me.lbl_Clvalue.Text = ""
        Me.txt_avgRate.Text = ""
        Me.txt_MRP.Text = ""
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_ItemCode.Enabled = True
        txt_GroupCode.ReadOnly = False
        txt_SubGroupCode.ReadOnly = False
        txt_SubSubGroupCode.ReadOnly = False
        txt_ItemCode.ReadOnly = False
        txt_ItemName.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_ItemCode.Focus()
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  inventoryitemmaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE itemcode = '" & Trim(txt_ItemCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "inventoryitemmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  inventoryitemmaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE itemcode = '" & Trim(txt_ItemCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "inventoryitemmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " From inventoryitemmaster "
        Gheader = "INVENTORY ITEM MASTER"
        If txt_Storecode.Text <> "" Then
            SST = True
            SSTORE = txt_Storecode.Text
        End If
        FrReport.SsGridReport.SetText(2, 1, "ITEMCODE")
        FrReport.SsGridReport.SetText(3, 1, 7)
        FrReport.SsGridReport.SetText(2, 2, "ITEMNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "ALIAS")
        FrReport.SsGridReport.SetText(3, 3, 7)
        FrReport.SsGridReport.SetText(2, 4, "CATEGORY")
        FrReport.SsGridReport.SetText(3, 4, 10)
        FrReport.SsGridReport.SetText(2, 5, "GROUPCODE")
        FrReport.SsGridReport.SetText(3, 5, 5)
        FrReport.SsGridReport.SetText(2, 6, "GROUPNAME")
        FrReport.SsGridReport.SetText(3, 6, 15)
        FrReport.SsGridReport.SetText(2, 7, "SUBGROUPCODE")
        FrReport.SsGridReport.SetText(3, 7, 5)
        FrReport.SsGridReport.SetText(2, 8, "SUBGROUPNAME")
        FrReport.SsGridReport.SetText(3, 8, 15)
        FrReport.SsGridReport.SetText(2, 9, "SUBSUBGROUPCODE")
        FrReport.SsGridReport.SetText(3, 9, 5)
        FrReport.SsGridReport.SetText(2, 10, "SUBSUBGROUPNAME")
        FrReport.SsGridReport.SetText(3, 10, 15)
        FrReport.SsGridReport.SetText(2, 11, "REORDERLEVEL")
        FrReport.SsGridReport.SetText(3, 11, 4)
        FrReport.SsGridReport.SetText(2, 12, "MINQTY")
        FrReport.SsGridReport.SetText(3, 12, 4)
        FrReport.SsGridReport.SetText(2, 13, "MAXQTY")
        FrReport.SsGridReport.SetText(3, 13, 4)
        FrReport.SsGridReport.SetText(2, 14, "PURCHASERATE")
        FrReport.SsGridReport.SetText(3, 14, 4)
        FrReport.SsGridReport.SetText(2, 15, "SALERATE")
        FrReport.SsGridReport.SetText(3, 15, 4)
        FrReport.SsGridReport.SetText(2, 16, "STOCKUOM")
        FrReport.SsGridReport.SetText(3, 16, 6)
        FrReport.SsGridReport.SetText(2, 17, "DOUBLEUOM")
        FrReport.SsGridReport.SetText(3, 17, 6)
        FrReport.SsGridReport.SetText(2, 18, "OPSTOCK")
        FrReport.SsGridReport.SetText(3, 18, 5)
        FrReport.SsGridReport.SetText(2, 19, "OPVALUE")
        FrReport.SsGridReport.SetText(3, 19, 5)
        FrReport.SsGridReport.SetText(2, 20, "CONVVALUE")
        FrReport.SsGridReport.SetText(3, 20, 5)
        FrReport.SsGridReport.SetText(2, 21, "VALUATION")
        FrReport.SsGridReport.SetText(3, 21, 10)
        FrReport.SsGridReport.SetText(2, 22, "FREEZE")
        FrReport.SsGridReport.SetText(3, 22, 6)
        FrReport.SsGridReport.SetText(2, 23, "CLSTOCK")
        FrReport.SsGridReport.SetText(3, 23, 6)
        FrReport.SsGridReport.SetText(2, 24, "STORECODE")
        FrReport.SsGridReport.SetText(3, 24, 6)
        FrReport.Show()
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub txt_ItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ItemCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_ItemCode.Text) = "" Then
                Call Cmd_ItemCode_Click(sender, e)
            Else
                txt_ItemCode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_ItemName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ItemName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Alias.Focus()
        End If
    End Sub
    Private Sub txt_Alias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Alias.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            TXT_CATEGORY.Focus()
        End If
    End Sub

    Private Sub txt_GroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_GroupCode.Text) = "" Then
                Call cmd_GroupCode_Click(cmd_GroupCode, e)
            Else
                txt_GroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_GroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_SubGroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubGroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_SubGroupCode.Text) = "" Then
                Call cmd_SubGroupCode_Click(sender, e)
            Else
                txt_SubGroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_SubGroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubGroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SubSubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubSubGroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_SubSubGroupCode.Text) = "" Then
                Call cmd_SubSubGroupCode_Click(sender, e)
            Else
                txt_SubSubGroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubSubGroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            'txt_ReorderLevel.Focus()
            txt_CompanyCode.Focus()
        End If
    End Sub

    Private Sub txt_ReorderLevel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ReorderLevel.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MinQty.Focus()
        End If
    End Sub

    Private Sub txt_MinQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MinQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MaxQty.Focus()
        End If
    End Sub

    Private Sub txt_MaxQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MaxQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PurchaseRate.Focus()
        End If
    End Sub

    Private Sub cbo_Valuation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Valuation.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PurchaseRate.Focus()
        End If
    End Sub

    Private Sub txt_PurchaseRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PurchaseRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SaleRate.Focus()
        End If
    End Sub

    Private Sub txt_SaleRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SaleRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MRP.Focus()
        End If
    End Sub

    Private Sub cbo_StockUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_StockUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_ReceivingUOM.Focus()
        End If
    End Sub

    Private Sub cbo_ReceivingUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_ReceivingUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_SaleUOM.Focus()
        End If
    End Sub

    Private Sub cbo_SaleUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_SaleUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningStock.Focus()
        End If
    End Sub

    Private Sub cbo_DoubleUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_DoubleUnit.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Conversion.Focus()
        End If
    End Sub
    Private Sub txt_Conversion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Conversion.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningStock.Focus()
        End If
    End Sub
    Private Sub txt_OpeningStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_OpeningStock.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningAmount.Focus()
        End If
    End Sub

    Private Sub txt_LeadTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LeadTime.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_DoubleUnit.Focus()
        End If
    End Sub
    Private Sub txt_OpeningAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_OpeningAmount.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub FillUOM()
        Dim i As Integer
        sqlstring = "SELECT distinct(uomdesc) FROM UOMMaster order by uomdesc asc"
        gconnection.getDataSet(sqlstring, "UOMMaster1")
        cbo_StockUOM.Items.Clear()
        cbo_ReceivingUOM.Items.Clear()
        cbo_SaleUOM.Items.Clear()
        cbo_DoubleUnit.Items.Clear()
        If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                cbo_StockUOM.Items.Add(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMdesc"))
                cbo_ReceivingUOM.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMdesc")))
                cbo_SaleUOM.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMdesc")))
                cbo_DoubleUnit.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMdesc")))
            Next i
        End If
    End Sub
    Private Sub Item_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ItemMasterbool = False
    End Sub
    Private Sub Cmd_ItemCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ItemCode.Click
        gSQLString = "SELECT DISTINCT(itemcode),itemname  FROM inventoryitemmaster"
        M_WhereCondition = " "
        Dim vform As New List_Operation
        vform.Field = "ITEMNAME,ITEMCODE"
        vform.vFormatstring = "          ITEM CODE            |                        ITEM DESCRIPTION                             "
        vform.vCaption = "INVENTORY ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ItemCode.Text = Trim(vform.keyfield & "")
            Call txt_ItemCode_Validated(txt_ItemCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_GroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_GroupCode.Click
        gSQLString = "SELECT Groupcode,Groupdesc FROM inventorygroupmaster"
        M_WhereCondition = " WHERE freeze='N' "
        Dim vform As New List_Operation
        vform.Field = "GROUPDESC,GROUPCODE"
        vform.vFormatstring = "            GROUP CODE                  |                  GROUP DESCRIPTION                             "
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

    Private Sub cmd_SubGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SubGroupCode.Click
        gSQLString = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER"
        M_WhereCondition = " WHERE GROUPCODE='" & Trim(txt_GroupCode.Text) & "'  AND ISNULL(FREEZE,'') <> 'Y' "
        Dim vform As New List_Operation
        vform.Field = "SUBGROUPDESC,SUBGROUPCODE"
        vform.vFormatstring = "         SUB GROUP CODE            |               SUB GROUP DESCRIPTION                             "
        vform.vCaption = "SUBGROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SubGroupCode.Text = Trim(vform.keyfield & "")
            Call txt_SubGroupCode_Validated(txt_SubGroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_SubSubGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SubSubGroupCode.Click
        gSQLString = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER"
        M_WhereCondition = " WHERE GROUPCODE='" & Trim(txt_GroupCode.Text) & "' AND ISNULL(FREEZE,'') <> 'Y' "
        Dim vform As New List_Operation
        vform.Field = "SUBGROUPCODE,SUBGROUPDESC"
        vform.vFormatstring = "         SUB SUB GROUP CODE            |               SUB SUB GROUP DESCRIPTION                             "
        vform.vCaption = "SUBSUBGROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SubSubGroupCode.Text = Trim(vform.keyfield & "")
            Call txt_SubSubGroupCode_Validated(txt_SubSubGroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_ItemCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ItemCode.Validated
        Try
            Dim itemflag As Boolean
            If Trim(txt_ItemCode.Text) <> "" Then
                sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode = '" & Trim(txt_Storecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "inventoryitem1")
                If gdataset.Tables("inventoryitem1").Rows.Count <= 0 And txt_Storecode.Text = "" Then
                    sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode <> '" & Trim(txt_Storecode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "inventoryitem2")
                    If gdataset.Tables("inventoryitem2").Rows.Count > 0 Then
                        itemflag = False
                    End If
                Else
                    itemflag = True
                End If
                If itemflag = False Then
                    sqlstring = "SELECT ISNULL(MRP,0) AS MRP,* FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
                Else
                    sqlstring = "SELECT ISNULL(MRP,0) AS MRP,* FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode = '" & Trim(txt_Storecode.Text) & "'"

                End If
                gconnection.getDataSet(sqlstring, "inventoryitemmaster")

                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    'If itemflag = False Then
                    txt_Storecode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("storecode"))
                    'End If
                    sqlstring = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & Trim(txt_Storecode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "STOREMASTER")
                    If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                        txt_StoreDesc.Text = Trim(gdataset.Tables("STOREmaster").Rows(0).Item("storeDESC"))
                    End If
                    txt_ItemCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemcode"))
                    txt_ItemName.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemname"))
                    txt_Alias.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("alias") & "")
                    txt_GroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("groupcode") & "")
                    txt_GroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("groupname") & "")
                    txt_SubGroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subgroupcode") & "")
                    txt_SubGroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subgroupname") & "")
                    txt_SubSubGroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subsubgroupcode") & "")
                    txt_SubSubGroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subsubgroupname") & "")
                    txt_CompanyCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("companycode") & "")
                    txt_CompanyDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("companyname") & "")
                    txt_ReorderLevel.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("reorderlevel") & ""), "0.00")
                    txt_MinQty.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("minqty") & ""), "0.00")
                    txt_MaxQty.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("maxqty") & ""), "0.00")
                    cbo_Valuation.DropDownStyle = ComboBoxStyle.DropDown
                    Cbo_ABC_category.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ABC") & "")
                    cbo_Valuation.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("valuation") & "")
                    cbo_Valuation.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_PurchaseRate.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("purchaserate") & ""), "0.00")
                    txt_SaleRate.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("salerate") & ""), "0.00")
                    txt_MRP.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("MRP") & ""), "0.00")
                    cbo_StockUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_StockUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("stockuom") & "")
                    cbo_StockUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_ReceivingUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_ReceivingUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("receiveuom") & "")
                    cbo_ReceivingUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_SaleUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_SaleUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("saleuom") & "")
                    cbo_SaleUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_DoubleUnit.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_DoubleUnit.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("doubleuom") & "")
                    cbo_DoubleUnit.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Conversion.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("convvalue") & ""), "0.00")
                    'If itemflag = True Then
                    txt_OpeningStock.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opstock") & ""), "0.000")
                    txt_OpeningAmount.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opvalue") & ""), "0.00")
                    'Else
                    'txt_OpeningStock.Text = 0
                    'txt_OpeningAmount.Text = 0
                    'End If
                    If Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clstock") & ""), "0.000") <> "0.000" Then
                        lbl_Clstock.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clstock") & ""), "0.000")
                        lbl_Clvalue.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clvalue") & ""), "0.00")
                    End If
                    txt_avgRate.Text = Format(CalAverageRate_new(txt_ItemCode.Text, Format(Now.Date, "dd/MM/yyyy"), txt_Storecode.Text), "0.00")

                    txt_LeadTime.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("leadtime") & "")
                    TXT_CATEGORY.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("CATEGORY") & "")
                    txt_ItemName.Focus()
                    txt_ItemCode.ReadOnly = True
                    txt_OpeningAmount.ReadOnly = False
                    txt_OpeningStock.ReadOnly = False
                    If gdataset.Tables("inventoryitemmaster").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("inventoryitemmaster").Rows(0).Item("AddDate")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Freeze[F8]"
                    End If
                    'If itemflag = False Then
                    Me.Cmd_Add.Text = "Update[F7]"
                    'Else
                    '    Me.Cmd_Add.Text = "Add [F7]"
                    'End If
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Add.Text = "Add [F7]"
                    txt_ItemCode.ReadOnly = False
                    txt_ItemName.Focus()
                End If
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
            Else
                txt_ItemCode.Text = ""
                txt_ItemName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub


    Private Sub txt_GroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GroupCode.Validated
        If Trim(txt_GroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorygroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND freeze='N'"
            gconnection.getDataSet(sqlstring, "inventorygroupmaster")
            If gdataset.Tables("inventorygroupmaster").Rows.Count > 0 Then
                txt_GroupCode.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupcode"))
                txt_GroupDesc.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupdesc"))
                txt_SubGroupCode.Focus()
                txt_GroupDesc.ReadOnly = True
            Else
                txt_GroupCode.Text = ""
                txt_GroupDesc.ReadOnly = False
                txt_GroupCode.Focus()
            End If
        Else
            txt_GroupCode.Text = ""
            txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_SubGroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                txt_SubSubGroupCode.Focus()
                txt_SubGroupDesc.ReadOnly = True
            Else
                txt_SubGroupCode.Text = ""
                txt_SubGroupCode.Focus()
            End If
        Else
            txt_SubGroupCode.Text = ""
            'txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_ItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ItemCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_ItemCode.Enabled = True Then
                search = Trim(txt_Storecode.Text)
                Call Cmd_Storecode_Click(Cmd_Storecode, e)
            End If
        End If
    End Sub

    Private Sub txt_GroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_GroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_GroupCode.Enabled = True Then
                search = Trim(txt_GroupCode.Text)
                Call cmd_GroupCode_Click(cmd_GroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubGroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SubGroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_SubGroupCode.Enabled = True Then
                search = Trim(txt_SubGroupCode.Text)
                Call cmd_SubGroupCode_Click(cmd_SubGroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SubSubGroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_SubSubGroupCode.Enabled = True Then
                search = Trim(txt_SubSubGroupCode.Text)
                Call cmd_SubSubGroupCode_Click(cmd_SubSubGroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubSubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubSubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubSubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubSubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                'txt_ReorderLevel.Focus()
                txt_CompanyCode.Focus()
                txt_SubSubGroupDesc.ReadOnly = True
            Else
                txt_SubSubGroupCode.Text = ""
                txt_SubSubGroupDesc.ReadOnly = False
                txt_SubSubGroupCode.Focus()
            End If
        Else
            txt_SubSubGroupCode.Text = ""
            'txt_ReorderLevel.Focus()
            txt_CompanyCode.Focus()
        End If
    End Sub

    Private Sub Item_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub

    Private Sub txt_PurchaseRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PurchaseRate.LostFocus
        txt_PurchaseRate.Text = Format(Val(txt_PurchaseRate.Text), "0.00")
    End Sub

    Private Sub txt_SaleRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SaleRate.LostFocus
        txt_SaleRate.Text = Format(Val(txt_SaleRate.Text), "0.00")
    End Sub

    Private Sub txt_Conversion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Conversion.LostFocus
        txt_Conversion.Text = Format(Val(txt_Conversion.Text), "0.00")
    End Sub
    Private Sub txt_ReorderLevel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ReorderLevel.LostFocus
        txt_ReorderLevel.Text = Format(Val(txt_ReorderLevel.Text), "0.00")
    End Sub
    Private Sub txt_MaxQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MaxQty.LostFocus
        txt_MaxQty.Text = Format(Val(txt_MaxQty.Text), "0.00")
    End Sub
    Private Sub txt_MinQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MinQty.LostFocus
        txt_MinQty.Text = Format(Val(txt_MinQty.Text), "0.00")
    End Sub
    Private Sub txt_OpeningStock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningStock.LostFocus
        txt_OpeningStock.Text = Format(Val(txt_OpeningStock.Text), "0.000")
    End Sub
    Private Sub txt_OpeningAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningAmount.LostFocus
        txt_OpeningAmount.Text = Format(Val(txt_OpeningAmount.Text), "0.00")
    End Sub
    Private Sub txt_OpeningStock_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningStock.TextChanged
        If Val(txt_PurchaseRate.Text) <> 0 Then
            txt_OpeningAmount.Text = Format(Val(txt_PurchaseRate.Text) * Val(txt_OpeningStock.Text), "0.000")
        End If
    End Sub
    Private Sub TXT_CATEGORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CATEGORY.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_GroupCode.Focus()
        End If
    End Sub


    Private Sub Cmd_Storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Storecode.Click
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
            txt_Storecode.Text = Trim(vform.keyfield & "")
            txt_StoreDesc.Text = Trim(vform.keyfield1 & "")
            txt_ItemCode.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Storecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Storecode.Validated
        Try
            If Trim(txt_Storecode.Text) <> "" Then
                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "storemaster")
                If gdataset.Tables("storemaster").Rows.Count > 0 Then
                    txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                    txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                    txt_ItemCode.Focus()
                End If
                If Trim(txt_ItemCode.Text) <> "" Then
                    sqlstring = "SELECT * FROM INVENTORYITEMMASTER WHERE storecode='" & Trim(txt_Storecode.Text) & "' AND ITEMCODE='" & Trim(txt_ItemCode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "ITEM1master")
                    If gdataset.Tables("ITEM1master").Rows.Count > 0 Then
                    Else
                        Me.Cmd_Add.Text = "Add [F7]"
                    End If
                End If
            End If
        Catch
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Storecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Storecode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_Storecode.Enabled = True Then
                search = Trim(txt_GroupCode.Text)
                Call Cmd_Storecode_Click(Cmd_Storecode, e)
            End If
        End If
    End Sub

    Private Sub txt_Storecode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Storecode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Storecode.Text) = "" Then
                Call Cmd_Storecode_Click(sender, e)
            Else
                Call txt_Storecode_Validated(txt_Storecode.Text, e)
            End If
        End If
    End Sub

    Private Sub txt_MaxQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MaxQty.TextChanged

    End Sub

    Private Sub cbo_StockUOM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_StockUOM.SelectedIndexChanged
        cbo_ReceivingUOM.Text = cbo_StockUOM.Text
        cbo_SaleUOM.Text = cbo_StockUOM.Text
        cbo_DoubleUnit.Text = cbo_StockUOM.Text
    End Sub

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        Dim rViewer As New Viewer
        Dim sqlstring, SSQL As String
        Dim r As New Rpt_ItemMaster
        sqlstring = "SELECT * FROM inventoryitemmaster WHERE storecode = '" & Trim(txt_Storecode.Text) & "' order by  itemcode"
        gconnection.getDataSet(sqlstring, "inventoryitem1")


        rViewer.ssql = sqlstring
        rViewer.Report = r
        rViewer.TableName = "inventoryitemmaster"

        Dim textobj1 As TextObject
        textobj1 = r.ReportDefinition.ReportObjects("Text13")
        textobj1.Text = MyCompanyName
        
        rViewer.Show()

    End Sub

    Private Sub txt_Storecode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Storecode.TextChanged

    End Sub

    Private Sub txt_MRP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MRP.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_StockUOM.Focus()
        End If
    End Sub

    Private Sub cmd_CompanyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CompanyCode.Click
        gSQLString = "SELECT CompanyCode,CompanyName FROM InventoryCompanyMaster"
        M_WhereCondition = " WHERE freeze='N' "
        Dim vform As New List_Operation
        vform.Field = "COMPANYNAME,COMPANYCODE"
        vform.vFormatstring = "            COMPANY CODE                  |                  COMPANY NAME                             "
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
        If Trim(txt_GroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorycompanymaster WHERE CompanyCode='" & Trim(txt_CompanyCode.Text) & "' AND freeze='N'"
            gconnection.getDataSet(sqlstring, "inventorycompanymaster")
            If gdataset.Tables("inventorycompanymaster").Rows.Count > 0 Then
                txt_CompanyCode.Text = Trim(gdataset.Tables("inventorycompanymaster").Rows(0).Item("companycode"))
                txt_CompanyDesc.Text = Trim(gdataset.Tables("inventorycompanymaster").Rows(0).Item("companyname"))
                'Cbo_ABC_category.Focus()
                txt_ReorderLevel.Focus()
                txt_CompanyDesc.ReadOnly = True
            Else
                txt_CompanyCode.Text = ""
                txt_CompanyDesc.ReadOnly = False
                txt_CompanyCode.Focus()
            End If
        Else
            txt_CompanyCode.Text = ""
            'Cbo_ABC_category.Focus()
            txt_ReorderLevel.Focus()
        End If
    End Sub

    Private Sub txt_CompanyCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CompanyCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_CompanyCode.Enabled = True Then
                search = Trim(txt_CompanyCode.Text)
                Call cmd_CompanyCode_Click(cmd_CompanyCode, e)
            End If
        End If
    End Sub

    Private Sub txt_CompanyCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CompanyCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_CompanyCode.Text) = "" Then
                Call cmd_CompanyCode_Click(cmd_CompanyCode, e)
            Else
                txt_CompanyCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_CompanyDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CompanyDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            'Cbo_ABC_category.Focus()
            txt_ReorderLevel.Focus()
        End If
    End Sub

    Private Sub txt_Targetqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Targetqty.KeyPress
        getNumeric(e)
    End Sub

    Private Sub Btn_PosTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PosTag.Click
        Dim i As Integer
        Try
            sqlstring = "SELECT STORESTATUS FROM STOREMASTER WHERE STORECODE = '" & Trim(txt_Storecode.Text) & "'"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                If gdataset.Tables("STOREMASTER").Rows(0).Item(0) = "M" And Trim(txt_ItemCode.Text) <> "" Then
                    Grp_PosTag.Visible = True
                    sqlstring = "SELECT DISTINCT ITEMCODE,ISNULL(COCKTAIL,'N') AS COCKTAIL FROM BOM_DET WHERE  GITEMCODE = '" & Trim(txt_ItemCode.Text) & "' ORDER BY ITEMCODE"
                    gconnection.getDataSet(sqlstring, "TAGITEM")
                    If gdataset.Tables("TAGITEM").Rows.Count > 0 Then
                        ssgrid.ClearRange(1, 1, -1, -1, True)
                        For i = 0 To gdataset.Tables("TAGITEM").Rows.Count - 1
                            With ssgrid
                                .Col = 1
                                .Row = i + 1
                                .Text = gdataset.Tables("TAGITEM").Rows(i).Item("ITEMCODE")
                                .Col = 2
                                .Row = i + 1
                                If gdataset.Tables("TAGITEM").Rows(i).Item("COCKTAIL") = "Y" Then
                                    .Text = 1
                                Else
                                    .Text = 0
                                End If
                            End With
                        Next
                    End If
                    ssgrid.SetActiveCell(1, 1)
                Else
                    ssgrid.ClearRange(1, 1, -1, -1, True)
                    ssgrid.SetActiveCell(1, 1)
                    Grp_PosTag.Visible = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        With ssgrid
            If .ActiveCol = 1 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
        End With
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
    Private Sub FillMenu()
        Dim vform As New List_Operation
        Dim ssql As String
        gSQLString = "SELECT ITEMCODE,ITEMDESC FROM ITEMMASTER "
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y' "
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "
        End If
        vform.Field = "Itemcode,Itemdesc"
        vform.vFormatstring = "Item Code     |Item Desc                     "
        vform.vCaption = "Item HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield
            End With
        Else
            ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            Exit Sub
        End If
    End Sub

    Private Sub Btn_UpdBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UpdBOM.Click
        Dim i, j As Integer
        Dim ICode, CFlag, BaseUOm, TransUOm, kotstatus As String
        Dim ConVal As Decimal
        Dim Insert(0) As String
        Try
            Insert(0) = "DELETE FROM BOM_DET WHERE GITEMCODE = '" & Trim(txt_ItemCode.Text) & "'  And ItemUOm Not Like '%BOT%'"
            With ssgrid
                For i = 1 To .DataRowCnt
                    .Col = 1
                    .Row = i
                    ICode = Trim(.Text)
                    .Col = 2
                    .Row = i
                    kotstatus = .Text
                    If Val(kotstatus) = 0 Then
                        CFlag = "N"
                    Else
                        CFlag = "Y"
                    End If
                    sqlstring = "SELECT Itemcode,UOM FROM RATEMASTER WHERE ITEMCODE = '" & Trim(ICode) & "' AND ISNULL(ENDINGDATE,'') = '' And Isnull(Freeze,'') <> 'Y' and uom not like '%BOT%'"
                    gconnection.getDataSet(sqlstring, "RateM")
                    If gdataset.Tables("RateM").Rows.Count > 0 Then
                        ''sqlstring = "DELETE FROM BOM_DET WHERE ITEMCODE = '" & ICode & "' AND GITEMCODE = '" & Trim(txt_ItemCode.Text) & "'"
                        ''ReDim Preserve Insert(Insert.Length)
                        ''Insert(Insert.Length - 1) = sqlstring
                        sqlstring = "DELETE FROM BOM_HDR WHERE ITEMCODE = '" & ICode & "' And ItemUOm Not Like '%BOT%'"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                        For j = 0 To gdataset.Tables("RateM").Rows.Count - 1
                            BaseUOm = Trim(gdataset.Tables("RateM").Rows(j).Item("UOM"))
                            TransUOm = Trim(cbo_StockUOM.Text)
                            sqlstring = "SELECT * FROM INVENTORY_TRANSCONVERSION WHERE BASEUOM = '" & Trim(BaseUOm) & "' AND TRANSUOM = '" & Trim(TransUOm) & "'"
                            gconnection.getDataSet(sqlstring, "InvTrans")
                            If gdataset.Tables("InvTrans").Rows.Count > 0 Then
                                ConVal = gdataset.Tables("InvTrans").Rows(0).Item("CONVVALUE")
                                sqlstring = "INSERT INTO BOM_DET (ITEMCODE,ITEMUOM,GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID,ADDUSER,ADDDATE,COCKTAIL) VALUES ("
                                sqlstring = sqlstring & "'" & ICode & "','" & BaseUOm & "','" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "','" & Trim(TransUOm) & "'," & ConVal & ",0,0,0,0,'" & Trim(txt_GroupCode.Text) & "','" & Trim(txt_SubGroupCode.Text) & "','N','" & gUsername & "','" & Format(Now.Date, "dd-MMM-yyyy") & "','" & CFlag & "')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                                sqlstring = "INSERT INTO BOM_HDR (ITEMCODE,ITEMNAME,ITEMUOM,VOID,ADDUSER,ADDDATE) VALUES( "
                                sqlstring = sqlstring & "'" & ICode & "','','" & BaseUOm & "','N','" & gUsername & "','" & Format(Now.Date, "dd-MMM-yyyy") & "')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            Else
                                MessageBox.Show("No Tagging Found in Uom Convertion Entry with " & BaseUOm & "->" & TransUOm & ", Plz Check")
                                Exit Sub
                            End If
                        Next
                        sqlstring = "UPDATE BOM_det SET ITEMNAME = I.ITEMDESC FROM ITEMMASTER I,BOM_DET B WHERE I.ITEMCODE = B.ITEMCODE AND B.ITEMCODE = '" & ICode & "'"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                        sqlstring = "UPDATE BOM_HDR SET ITEMNAME = I.ITEMDESC FROM ITEMMASTER I,BOM_HDR B WHERE I.ITEMCODE = B.ITEMCODE AND B.ITEMCODE ='" & ICode & "'"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                    Else
                        MessageBox.Show("No Sale Item Found in Rate Master with Itemcode " & ICode & ", Plz Check")
                        Exit Sub
                    End If
                Next
            End With
            gconnection.MoreTrans(Insert)
            ssgrid.ClearRange(1, 1, -1, -1, True)
            ssgrid.SetActiveCell(1, 1)
            Grp_PosTag.Visible = False

        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub Btn_TagClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_TagClose.Click
        Grp_PosTag.Visible = False
    End Sub
End Class