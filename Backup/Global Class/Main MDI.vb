Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.IO
Public Class Main_MDI
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_GroupMaster As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_SubGroupMaster As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StoreMaster As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_ItemMaster As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_GRNCumPurchaseBill As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockTransfer As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockDamage As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Masters As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Transaction As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Reports As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Utility As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Calculator As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Notepad As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Window As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_HorizontalTile As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_VerticalTile As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Cascade As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_IssueRegister As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_IssueDetails As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_RatioChart As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockLedger As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockSummary As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockOfBar As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_MainStorePosition As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_PurchaseRegister As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Billmaterial As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Administrator As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Useradmin As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Billofmaterial As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockIssue As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StockAdjustment As System.Windows.Forms.MenuItem
    Friend WithEvents Submnu_Stocktransferregister As System.Windows.Forms.MenuItem
    Friend WithEvents Submnu_StockReturnregister As System.Windows.Forms.MenuItem
    Friend WithEvents Submnu_StockAdjustmentregister As System.Windows.Forms.MenuItem
    Friend WithEvents Stock_Summary As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Exception As System.Windows.Forms.MenuItem
    Friend WithEvents MnuAccPost As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main_MDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnu_Masters = New System.Windows.Forms.MenuItem
        Me.submnu_GroupMaster = New System.Windows.Forms.MenuItem
        Me.submnu_SubGroupMaster = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.submnu_StoreMaster = New System.Windows.Forms.MenuItem
        Me.submnu_ItemMaster = New System.Windows.Forms.MenuItem
        Me.submnu_Billmaterial = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.mnu_Transaction = New System.Windows.Forms.MenuItem
        Me.submnu_GRNCumPurchaseBill = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.submnu_Billofmaterial = New System.Windows.Forms.MenuItem
        Me.submnu_StockIssue = New System.Windows.Forms.MenuItem
        Me.submnu_StockTransfer = New System.Windows.Forms.MenuItem
        Me.submnu_StockDamage = New System.Windows.Forms.MenuItem
        Me.submnu_StockAdjustment = New System.Windows.Forms.MenuItem
        Me.MnuAccPost = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.mnu_Reports = New System.Windows.Forms.MenuItem
        Me.submnu_IssueRegister = New System.Windows.Forms.MenuItem
        Me.submnu_IssueDetails = New System.Windows.Forms.MenuItem
        Me.submnu_StockSummary = New System.Windows.Forms.MenuItem
        Me.submnu_RatioChart = New System.Windows.Forms.MenuItem
        Me.submnu_StockLedger = New System.Windows.Forms.MenuItem
        Me.Stock_Summary = New System.Windows.Forms.MenuItem
        Me.mnu_Exception = New System.Windows.Forms.MenuItem
        Me.submnu_StockOfBar = New System.Windows.Forms.MenuItem
        Me.submnu_MainStorePosition = New System.Windows.Forms.MenuItem
        Me.submnu_PurchaseRegister = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.Submnu_Stocktransferregister = New System.Windows.Forms.MenuItem
        Me.Submnu_StockReturnregister = New System.Windows.Forms.MenuItem
        Me.Submnu_StockAdjustmentregister = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.mnu_Utility = New System.Windows.Forms.MenuItem
        Me.submnu_Calculator = New System.Windows.Forms.MenuItem
        Me.submnu_Notepad = New System.Windows.Forms.MenuItem
        Me.mnu_Administrator = New System.Windows.Forms.MenuItem
        Me.submnu_Useradmin = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.mnu_Window = New System.Windows.Forms.MenuItem
        Me.submnu_HorizontalTile = New System.Windows.Forms.MenuItem
        Me.submnu_VerticalTile = New System.Windows.Forms.MenuItem
        Me.submnu_Cascade = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_Masters, Me.mnu_Transaction, Me.mnu_Reports, Me.mnu_Utility, Me.mnu_Administrator, Me.mnu_Window, Me.MenuItem6})
        '
        'mnu_Masters
        '
        Me.mnu_Masters.Index = 0
        Me.mnu_Masters.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_GroupMaster, Me.submnu_SubGroupMaster, Me.MenuItem4, Me.submnu_StoreMaster, Me.submnu_ItemMaster, Me.submnu_Billmaterial, Me.MenuItem25})
        Me.mnu_Masters.Text = "&Masters"
        '
        'submnu_GroupMaster
        '
        Me.submnu_GroupMaster.Index = 0
        Me.submnu_GroupMaster.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.submnu_GroupMaster.Text = "&Group Master"
        '
        'submnu_SubGroupMaster
        '
        Me.submnu_SubGroupMaster.Index = 1
        Me.submnu_SubGroupMaster.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.submnu_SubGroupMaster.Text = "Sub G&roup Master"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Sub Sub Group Master"
        '
        'submnu_StoreMaster
        '
        Me.submnu_StoreMaster.Index = 3
        Me.submnu_StoreMaster.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.submnu_StoreMaster.Text = "&Store Master"
        '
        'submnu_ItemMaster
        '
        Me.submnu_ItemMaster.Index = 4
        Me.submnu_ItemMaster.Shortcut = System.Windows.Forms.Shortcut.CtrlI
        Me.submnu_ItemMaster.Text = "&Item Master"
        '
        'submnu_Billmaterial
        '
        Me.submnu_Billmaterial.Index = 5
        Me.submnu_Billmaterial.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.submnu_Billmaterial.Text = "&Billing Terms"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "Company Master"
        '
        'mnu_Transaction
        '
        Me.mnu_Transaction.Index = 1
        Me.mnu_Transaction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_GRNCumPurchaseBill, Me.MenuItem11, Me.submnu_Billofmaterial, Me.submnu_StockIssue, Me.submnu_StockTransfer, Me.submnu_StockDamage, Me.submnu_StockAdjustment, Me.MnuAccPost, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem27, Me.MenuItem28})
        Me.mnu_Transaction.Text = "&Transactions"
        '
        'submnu_GRNCumPurchaseBill
        '
        Me.submnu_GRNCumPurchaseBill.Index = 0
        Me.submnu_GRNCumPurchaseBill.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.submnu_GRNCumPurchaseBill.Text = "GRN Cum &Purchase Bill"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Stock Indent"
        '
        'submnu_Billofmaterial
        '
        Me.submnu_Billofmaterial.Index = 2
        Me.submnu_Billofmaterial.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.submnu_Billofmaterial.Text = "&Bill Of Material [BOM]"
        Me.submnu_Billofmaterial.Visible = False
        '
        'submnu_StockIssue
        '
        Me.submnu_StockIssue.Index = 3
        Me.submnu_StockIssue.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.submnu_StockIssue.Text = "Stock  &Issue"
        '
        'submnu_StockTransfer
        '
        Me.submnu_StockTransfer.Index = 4
        Me.submnu_StockTransfer.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.submnu_StockTransfer.Text = "Stock &Transfer/Return"
        '
        'submnu_StockDamage
        '
        Me.submnu_StockDamage.Index = 5
        Me.submnu_StockDamage.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.submnu_StockDamage.Text = "Stock &Damage"
        Me.submnu_StockDamage.Visible = False
        '
        'submnu_StockAdjustment
        '
        Me.submnu_StockAdjustment.Index = 6
        Me.submnu_StockAdjustment.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.submnu_StockAdjustment.Text = "Stock &Adjustment"
        '
        'MnuAccPost
        '
        Me.MnuAccPost.Index = 7
        Me.MnuAccPost.Text = "Account Posting Inventory"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 8
        Me.MenuItem15.Text = "Account Posting Party"
        Me.MenuItem15.Visible = False
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 9
        Me.MenuItem16.Text = "Account Posting Transit Quarters"
        Me.MenuItem16.Visible = False
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 10
        Me.MenuItem17.Text = "Month Bill Posting"
        Me.MenuItem17.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 11
        Me.MenuItem18.Text = "BILL"
        Me.MenuItem18.Visible = False
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 12
        Me.MenuItem27.Text = "Uom Convertion Entry"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 13
        Me.MenuItem28.Text = "Pos Item Store Tagging"
        '
        'mnu_Reports
        '
        Me.mnu_Reports.Index = 2
        Me.mnu_Reports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_IssueRegister, Me.submnu_IssueDetails, Me.submnu_StockSummary, Me.submnu_RatioChart, Me.submnu_StockLedger, Me.Stock_Summary, Me.mnu_Exception, Me.submnu_StockOfBar, Me.submnu_MainStorePosition, Me.submnu_PurchaseRegister, Me.MenuItem10, Me.Submnu_Stocktransferregister, Me.Submnu_StockReturnregister, Me.Submnu_StockAdjustmentregister, Me.MenuItem13, Me.MenuItem12, Me.MenuItem14, Me.MenuItem8, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem24, Me.MenuItem26, Me.MenuItem29, Me.MenuItem30})
        Me.mnu_Reports.Text = "Re&ports"
        '
        'submnu_IssueRegister
        '
        Me.submnu_IssueRegister.Index = 0
        Me.submnu_IssueRegister.Text = "1.&Issue Register"
        '
        'submnu_IssueDetails
        '
        Me.submnu_IssueDetails.Index = 1
        Me.submnu_IssueDetails.Text = "2.Issue &Details"
        '
        'submnu_StockSummary
        '
        Me.submnu_StockSummary.Index = 2
        Me.submnu_StockSummary.Text = "3.Issue &Summary"
        '
        'submnu_RatioChart
        '
        Me.submnu_RatioChart.Index = 3
        Me.submnu_RatioChart.Text = "&Ratio Chart"
        Me.submnu_RatioChart.Visible = False
        '
        'submnu_StockLedger
        '
        Me.submnu_StockLedger.Index = 4
        Me.submnu_StockLedger.Text = "4.Stock &Ledger"
        '
        'Stock_Summary
        '
        Me.Stock_Summary.Index = 5
        Me.Stock_Summary.Text = "5.S&tock Summary"
        '
        'mnu_Exception
        '
        Me.mnu_Exception.Index = 6
        Me.mnu_Exception.Text = "6.&Exception Report"
        '
        'submnu_StockOfBar
        '
        Me.submnu_StockOfBar.Index = 7
        Me.submnu_StockOfBar.Text = "Stock Of &Bar"
        Me.submnu_StockOfBar.Visible = False
        '
        'submnu_MainStorePosition
        '
        Me.submnu_MainStorePosition.Index = 8
        Me.submnu_MainStorePosition.Text = "&Main Store Position"
        Me.submnu_MainStorePosition.Visible = False
        '
        'submnu_PurchaseRegister
        '
        Me.submnu_PurchaseRegister.Index = 9
        Me.submnu_PurchaseRegister.Text = "7.&Purchase Register"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "Purchase Register Recon"
        Me.MenuItem10.Visible = False
        '
        'Submnu_Stocktransferregister
        '
        Me.Submnu_Stocktransferregister.Index = 11
        Me.Submnu_Stocktransferregister.Text = "8.Stock &Transfer Register"
        '
        'Submnu_StockReturnregister
        '
        Me.Submnu_StockReturnregister.Index = 12
        Me.Submnu_StockReturnregister.Text = "9.Stock &Return Register"
        '
        'Submnu_StockAdjustmentregister
        '
        Me.Submnu_StockAdjustmentregister.Index = 13
        Me.Submnu_StockAdjustmentregister.Text = "10.Stock &Adjustment Register"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 14
        Me.MenuItem13.Text = "11.Indentwise Report"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 15
        Me.MenuItem12.Text = "12.Pending Register Report"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 16
        Me.MenuItem14.Text = "13.Consolidated Summary"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Text = "14.VAT Input Tax Report"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 18
        Me.MenuItem19.Text = "15.ABC Report Analysis"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 19
        Me.MenuItem20.Text = "16.ROL Summary"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 20
        Me.MenuItem21.Text = "17. Item Master Store Wise"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 21
        Me.MenuItem22.Text = "18.Daily Consumption Report"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 22
        Me.MenuItem24.Text = "19.MRP Rate"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 23
        Me.MenuItem26.Text = "20.FOC Report"
        '
        'mnu_Utility
        '
        Me.mnu_Utility.Index = 3
        Me.mnu_Utility.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_Calculator, Me.submnu_Notepad})
        Me.mnu_Utility.Text = "&Utility"
        '
        'submnu_Calculator
        '
        Me.submnu_Calculator.Index = 0
        Me.submnu_Calculator.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.submnu_Calculator.Text = "Calculator"
        '
        'submnu_Notepad
        '
        Me.submnu_Notepad.Index = 1
        Me.submnu_Notepad.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.submnu_Notepad.Text = "Note Pad"
        '
        'mnu_Administrator
        '
        Me.mnu_Administrator.Index = 4
        Me.mnu_Administrator.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_Useradmin, Me.MenuItem2, Me.MenuItem3, Me.MenuItem5, Me.MenuItem7, Me.MenuItem9, Me.MenuItem23})
        Me.mnu_Administrator.Text = "&Administrator"
        '
        'submnu_Useradmin
        '
        Me.submnu_Useradmin.Index = 0
        Me.submnu_Useradmin.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.submnu_Useradmin.Text = "User A&dmin"
        Me.submnu_Useradmin.Visible = False
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Select Company"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Inventory Update"
        Me.MenuItem3.Visible = False
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "Carry Forward"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "Sub Store Consumption - Manual Updation"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "Weighted Average"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Text = "Weighted Average for Item"
        Me.MenuItem23.Visible = False
        '
        'mnu_Window
        '
        Me.mnu_Window.Index = 5
        Me.mnu_Window.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_HorizontalTile, Me.submnu_VerticalTile, Me.submnu_Cascade})
        Me.mnu_Window.Text = "&Window"
        '
        'submnu_HorizontalTile
        '
        Me.submnu_HorizontalTile.Index = 0
        Me.submnu_HorizontalTile.Text = "&Horizontal Tile"
        '
        'submnu_VerticalTile
        '
        Me.submnu_VerticalTile.Index = 1
        Me.submnu_VerticalTile.Text = "&Vertical Tile"
        '
        'submnu_Cascade
        '
        Me.submnu_Cascade.Index = 2
        Me.submnu_Cascade.Text = "&Cascade"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        Me.MenuItem6.Text = "Exit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(968, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 24
        Me.MenuItem29.Text = "21. Excise Report"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 25
        Me.MenuItem30.Text = ""
        '
        'Main_MDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 575)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main_MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim pageno, pagesize As Integer
    Private Sub Main_MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIParentobj = Me
        AppPath = Application.StartupPath
        AppPath = Application.StartupPath
        If Dir(AppPath & "\Reports", FileAttribute.Directory) = "" Then
            MkDir(AppPath & "\Reports")
        End If
        '        Call Clearfiles()
        'Call nEWuPDATE()
        Call FillCompanyinfo()
        Call GetAccountcode()
        Call Activateuseradmin()
        If File.Exists(AppPath & "\" & SHORTNAME & "_LOGO.jpg") Then
            PictureBox1.Image = Image.FromFile(AppPath & "\" & SHORTNAME & "_LOGO.jpg")
        End If
        Me.IsMdiContainer = True
        'If SHORTNAME <> "HIN" Then
        '    MenuItem23.Visible = False
        'ElseIf SHORTNAME = "HIN" Then
        '    MenuItem23.Visible = True
        'End If
    End Sub

    Public Sub nEWuPDATE()

        Dim str As String
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_header' AND  COLUMN_NAME = 'TotGSTAmt') Begin alter table Grn_header add  TotGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_header' AND  COLUMN_NAME = 'TotSGSTAmt') Begin alter table Grn_header add  TotSGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_header' AND  COLUMN_NAME = 'TotCGSTAmt') Begin alter table Grn_header add  TotCGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_header' AND  COLUMN_NAME = 'TotIGSTAmt') Begin alter table Grn_header add  TotIGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")

        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_details' AND  COLUMN_NAME = 'GSTAmt') Begin alter table Grn_details add  GSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_details' AND  COLUMN_NAME = 'SGSTAmt') Begin alter table Grn_details add  SGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_details' AND  COLUMN_NAME = 'CGSTAmt') Begin alter table Grn_details add  CGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")
        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_details' AND  COLUMN_NAME = 'IGSTAmt') Begin alter table Grn_details add  IGSTAmt numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")

        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Grn_details' AND  COLUMN_NAME = 'TAXGROUPCODE') Begin alter table Grn_details add  TAXGROUPCODE VARCHAR(30) End"
        gconnection.dataOperation(6, str, "AddC")

        str = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'INVENTORYItemmaster' AND  COLUMN_NAME = 'TAXPER') Begin alter table INVENTORYItemmaster add  TAXPER  numeric(18,3) End"
        gconnection.dataOperation(6, str, "AddC")


        str = " UPDATE INVENTORYItemmaster SET TAXPER = (SELECT SUM(ISNULL(TAXPERCENTAGE,0)) FROM  ACCOUNTSTAXgroupmaster WHERE ISNULL(VOID,'N')<>'Y' "
        str = str & "AND INVENTORYItemmaster.TAXGROUPCODE=GROUPCODE )"
        gconnection.dataOperation(6, str, "item")


    End Sub

    Private Sub PRINTOPERATION()
        Dim x, docno, printline, sqlstring As String
        Dim I As Integer
        Dim booldocno As Boolean
        Dim total(10) As Double
        Dim dr As DataRow
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
    Public Sub Clearfiles()
        AppPath = Application.StartupPath
        Shell("CLEAR.BAT", AppWinStyle.Hide)
    End Sub
    Private Sub Activateuseradmin()
        Try
            Me.Text = Trim(gCompanyname) & "  " & gFinancalyearStart & "-" & gFinancialyearEnd
            AppPath = Application.StartupPath
            GetAccountcode()
            'mdi.ActiveForm.BackgroundImage=
            MDIParentobj = Me
            Dim totmenu As Integer
            totmenu = 0
            Call menublock()
            Dim i, j, k, ckhmn, ckhmn1 As Integer
            For i = 0 To MainMenu1.MenuItems.Count - 2
                ckhmn1 = MainMenu1.MenuItems(i).MenuItems.Count()
                If ckhmn1 <> 0 Then
                    For j = 0 To MainMenu1.MenuItems(i).MenuItems.Count() - 1
                        ckhmn = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count()
                        If ckhmn <> 0 Then
                            For k = 0 To MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                                totmenu = totmenu + 1
                            Next
                        Else
                            totmenu = totmenu + 1
                        End If
                    Next
                Else
                    totmenu = totmenu + 1
                End If
            Next
            gconnection.getDataSet("select count(*) from modulemaster Where PackageName='INVENTORY'", "chk")
            If gdataset.Tables("chk").Rows.Count <> totmenu Then
                gconnection.ExcuteStoreProcedure("delete from modulemaster Where PackageName='INVENTORY'")
                Call checkmenulist()
            End If
            If gUserCategory = "S" Or gUserCategory = "A" Then
                Call menuclear()
            Else
                Call relemenu()
            End If
        Catch ex As Exception
            MsgBox("Error Found While Loading! Bcoz " & ex.Message.ToString, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub
    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = True
            End If
        Next
    End Sub
    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = False
            End If
        Next
    End Sub
    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        ds = gconnection.getdata("select * from useradmin where username = '" & Trim(gUsername) & "' and MainGroup='INVENTORY'", "user")
        If ds.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To ds.Tables("user").Rows.Count - 1
                With ds.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = MainMenu1.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = MainMenu1.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','INVENTORY')"
                                ReDim Preserve vsql(vsql.Length)
                            Next
                        Else
                            vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','INVENTORY')"
                            ReDim Preserve vsql(vsql.Length)
                        End If
                    Next
                Else
                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','INVENTORY')"
                    ReDim Preserve vsql(vsql.Length)
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans_womsg(vsql)
        End If
    End Sub
    Private Sub GetAccountcode()
        Dim sqlstring As String
        sqlstring = "SELECT ISNULL(SDRSCODE,'') AS SDRSCODE,ISNULL(SCRSCODE,'') AS SCRSCODE FROM ACCOUNTSSETUP "
        gconnection.getDataSet(sqlstring, "ACCOUNTSSETUP")
        If gdataset.Tables("ACCOUNTSSETUP").Rows.Count > 0 Then
            gDebitors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SDRSCODE")))
            gCreditors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SCRSCODE")))
        Else
            gDebitors = ""
            gCreditors = ""
        End If
    End Sub
    Public Sub FillCompanyinfo()
        Dim sqlstring As String
        Try
            If Trim(gDatabase) <> "" Then
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster WHERE DATAFILE = '" & Trim(gDatabase) & "'"
            Else
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster "
            End If
            gconnection.getCompanyinfo(sqlstring, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                MyCompanyName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("CompanyName")))
                Address1 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add1")))
                Address2 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add2")))
                gCity = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("City")))
                gState = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("State")))
                gPincode = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Pincode")))
                gDatabase = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Datafile")))
                Me.Text = MyCompanyName & " [" & "INVENTORY" & " ]"
                If Mid(MyCompanyName, 1, 3) = "HIN" Then
                    PrintTaxheading1 = "C.F"
                    PrintTaxheading2 = "CHARGES"
                Else
                    PrintTaxheading1 = "SALES"
                    PrintTaxheading2 = "TAX"
                End If
            Else
                MessageBox.Show("Plz. Contact to your Computer Administrator ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub submnu_HorizontalTile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_HorizontalTile.Click
        GmoduleName = "Horizontal Tile"
        Me.LayoutMdi(MdiLayout.TileHorizontal)
        submnu_HorizontalTile.Checked = True
        submnu_VerticalTile.Checked = False
        submnu_Cascade.Checked = False
    End Sub

    Private Sub submnu_VerticalTile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_VerticalTile.Click
        GmoduleName = "Vertical Tile"
        Me.LayoutMdi(MdiLayout.TileVertical)
        submnu_HorizontalTile.Checked = False
        submnu_VerticalTile.Checked = True
        submnu_Cascade.Checked = False
    End Sub

    Private Sub submnu_Cascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Cascade.Click
        GmoduleName = "Cascade"
        Me.LayoutMdi(MdiLayout.Cascade)
        submnu_HorizontalTile.Checked = False
        submnu_VerticalTile.Checked = False
        submnu_Cascade.Checked = True
    End Sub

    Private Sub submnu_Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Calculator.Click
        GmoduleName = "Calculator"
        Shell(Environment.SystemDirectory & "\calc.exe", AppWinStyle.NormalFocus)
        submnu_Calculator.Checked = True
        submnu_Notepad.Checked = False
    End Sub

    Private Sub submnu_Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Notepad.Click
        GmoduleName = "Note Pad"
        Shell(Environment.SystemDirectory & "\notepad.exe", AppWinStyle.NormalFocus)
        submnu_Calculator.Checked = False
        submnu_Notepad.Checked = True
    End Sub

    Private Sub submnu_GroupMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_GroupMaster.Click
        Dim objGroupmaster As New Group_Master
        GmoduleName = "Group Master"
        If GroupMasterbool = False And submnu_GroupMaster.Checked = True Then
            objGroupmaster.FormBorderStyle = FormBorderStyle.FixedDialog
            objGroupmaster.MdiParent = Me
            objGroupmaster.Show()
            submnu_GroupMaster.Checked = True
        End If
        If submnu_GroupMaster.Checked = True Then
            Exit Sub
        End If
        objGroupmaster.FormBorderStyle = FormBorderStyle.FixedDialog
        objGroupmaster.MdiParent = Me
        objGroupmaster.Show()
        submnu_GroupMaster.Checked = True
    End Sub

    Private Sub submnu_SubGroupMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_SubGroupMaster.Click
        Dim objSubGroupmaster As New Sub_Group_Master
        GmoduleName = "Sub Group Master"
        If SubGroupMasterbool = False And submnu_SubGroupMaster.Checked = True Then
            objSubGroupmaster.FormBorderStyle = FormBorderStyle.FixedDialog
            objSubGroupmaster.MdiParent = Me
            objSubGroupmaster.Show()
            submnu_SubGroupMaster.Checked = True
        End If
        If submnu_SubGroupMaster.Checked = True Then
            Exit Sub
        End If
        objSubGroupmaster.FormBorderStyle = FormBorderStyle.FixedDialog
        objSubGroupmaster.MdiParent = Me
        objSubGroupmaster.Show()
        submnu_SubGroupMaster.Checked = True
    End Sub

    Private Sub submnu_StoreMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StoreMaster.Click
        Dim objStoreMaster As New Store_Master
        GmoduleName = "Store Master"
        If StoreMasterbool = False And submnu_StoreMaster.Checked = True Then
            objStoreMaster.FormBorderStyle = FormBorderStyle.FixedDialog
            objStoreMaster.MdiParent = Me
            objStoreMaster.Show()
            submnu_StoreMaster.Checked = True
        End If
        If submnu_StoreMaster.Checked = True Then
            Exit Sub
        End If
        objStoreMaster.FormBorderStyle = FormBorderStyle.FixedDialog
        objStoreMaster.MdiParent = Me
        objStoreMaster.Show()
        submnu_StoreMaster.Checked = True
    End Sub

    Private Sub submnu_ItemMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_ItemMaster.Click
        Dim objItemMaster As New Item_Master
        GmoduleName = "Item Master"
        If ItemMasterbool = False And submnu_ItemMaster.Checked = True Then
            objItemMaster.FormBorderStyle = FormBorderStyle.FixedDialog
            objItemMaster.MdiParent = Me
            objItemMaster.Show()
            submnu_ItemMaster.Checked = True
        End If
        If submnu_ItemMaster.Checked = True Then
            Exit Sub
        End If
        objItemMaster.FormBorderStyle = FormBorderStyle.FixedDialog
        objItemMaster.MdiParent = Me
        objItemMaster.Show()
        submnu_ItemMaster.Checked = True
    End Sub


    Private Sub submnu_Billmaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Billmaterial.Click
        Dim objBillingMaterial As New frm_BillingMaterial
        GmoduleName = "Billing Terms"
        If BillingMaterialbool = False And submnu_Billmaterial.Checked = True Then
            objBillingMaterial.FormBorderStyle = FormBorderStyle.FixedDialog
            objBillingMaterial.MdiParent = Me
            objBillingMaterial.Show()
            submnu_Billmaterial.Checked = True
        End If
        If submnu_Billmaterial.Checked = True Then
            Exit Sub
        End If
        objBillingMaterial.FormBorderStyle = FormBorderStyle.FixedDialog
        objBillingMaterial.MdiParent = Me
        objBillingMaterial.Show()
        submnu_Billmaterial.Checked = True
    End Sub

    Private Sub submnu_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub submnu_GRNCumPurchaseBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_GRNCumPurchaseBill.Click
        Dim objGRNCumPurchaseBill As New GRN_Cum_Purchase_Bill_CSC
        GmoduleName = "GRN Cum Purchase Bill"
        If GRNCumPurchaseBillTransbool = False And submnu_GRNCumPurchaseBill.Checked = True Then
            objGRNCumPurchaseBill.FormBorderStyle = FormBorderStyle.FixedDialog
            objGRNCumPurchaseBill.MdiParent = Me
            objGRNCumPurchaseBill.Show()
            submnu_GRNCumPurchaseBill.Checked = True
        End If
        If submnu_GRNCumPurchaseBill.Checked = True Then
            Exit Sub
        End If
        objGRNCumPurchaseBill.FormBorderStyle = FormBorderStyle.FixedDialog
        objGRNCumPurchaseBill.MdiParent = Me
        objGRNCumPurchaseBill.Show()
        submnu_GRNCumPurchaseBill.Checked = True
    End Sub
    Private Sub submnu_StockTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockTransfer.Click
        Dim objStockTransfer As New Stock_Transfer
        GmoduleName = "Stock Transfer/Return"
        If StockTransferTransbool = False And submnu_StockTransfer.Checked = True Then
            objStockTransfer.FormBorderStyle = FormBorderStyle.FixedDialog
            objStockTransfer.MdiParent = Me
            objStockTransfer.Show()
            submnu_StockTransfer.Checked = True
        End If
        If submnu_StockTransfer.Checked = True Then
            Exit Sub
        End If
        objStockTransfer.FormBorderStyle = FormBorderStyle.FixedDialog
        objStockTransfer.MdiParent = Me
        objStockTransfer.Show()
        submnu_StockTransfer.Checked = True
    End Sub

    Private Sub submnu_StockDamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockDamage.Click
        Dim objStockDamage As New Stock_Damage
        GmoduleName = "Stock Damage"
        If StockDamageTransbool = False And submnu_StockDamage.Checked = True Then
            objStockDamage.FormBorderStyle = FormBorderStyle.FixedDialog
            objStockDamage.MdiParent = Me
            objStockDamage.Show()
            submnu_StockDamage.Checked = True
        End If
        If submnu_StockDamage.Checked = True Then
            Exit Sub
        End If
        objStockDamage.FormBorderStyle = FormBorderStyle.FixedDialog
        objStockDamage.MdiParent = Me
        objStockDamage.Show()
        submnu_StockDamage.Checked = True
    End Sub

    Private Sub mnu_Masters_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_Masters.Select
        If GroupMasterbool = False Then
            submnu_GroupMaster.Checked = False
        End If
        If SubGroupMasterbool = False Then
            submnu_SubGroupMaster.Checked = False
        End If
        If StoreMasterbool = False Then
            submnu_StoreMaster.Checked = False
        End If
        If ItemMasterbool = False Then
            submnu_ItemMaster.Checked = False
        End If
        If BillingMaterialbool = False Then
            submnu_Billmaterial.Checked = False
        End If
    End Sub

    Private Sub mnu_Transaction_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_Transaction.Select
        If GRNCumPurchaseBillTransbool = False Then
            submnu_GRNCumPurchaseBill.Checked = False
        End If
        If StockIssueTransbool = False Then
            submnu_StockIssue.Checked = False
        End If
        If CockTailRatioTransbool = False Then
            submnu_Billmaterial.Checked = False
        End If
        If StockTransferTransbool = False Then
            submnu_StockTransfer.Checked = False
        End If
        If StockAdjustmentTransbool = False Then
            submnu_StockAdjustment.Checked = False
        End If
        If StockDamageTransbool = False Then
            submnu_StockDamage.Checked = False
        End If
        If CockTailRatioTransbool = False Then
            submnu_Billofmaterial.Checked = False
        End If
    End Sub

    Private Sub submnu_IssueRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_IssueRegister.Click
        'Dim objIssueregister As New frmIssueregister
        GmoduleName = "Issue Register"
        Dim objIssueregister As New Issue_Register
        objIssueregister.MdiParent = Me
        objIssueregister.Show()
    End Sub

    Private Sub submnu_IssueDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_IssueDetails.Click
        'Dim objIssueregister As New frmIssueregister
        GmoduleName = "Issue Details"
        Dim objIssuedetails As New Itemwise_Issue_details
        objIssuedetails.MdiParent = Me
        objIssuedetails.Show()
    End Sub

    Private Sub submnu_RatioChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_RatioChart.Click
        GmoduleName = "Ratio Chart"
        Dim objRatiochart As New frmCocktailratiochart
        objRatiochart.MdiParent = Me
        objRatiochart.Show()
    End Sub

    Private Sub submnu_StockLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockLedger.Click
        GmoduleName = "Stock Ledger"
        Dim objStockledgermainstock As New frmStockledgermainstock
        objStockledgermainstock.MdiParent = Me
        objStockledgermainstock.Show()
    End Sub

    Private Sub submnu_StockOfBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockOfBar.Click
        GmoduleName = "Stock Of Bar"
        Dim objBarstockposition As New frmBarstockposition
        objBarstockposition.MdiParent = Me
        objBarstockposition.Show()
    End Sub

    Private Sub submnu_StockSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockSummary.Click
        GmoduleName = "Stock Summary"
        'Dim objMainStockPosition As New frmMainStockPosition
        'objMainStockPosition.MdiParent = Me
        'objMainStockPosition.Show()
        Dim objmainstockposition As New frmmainstockposition
        objmainstockposition.MdiParent = Me
        objmainstockposition.Show()
    End Sub
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER,database FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = getserver.Tables(0).Rows(0).Item(0)
                gDatabase = getserver.Tables(0).Rows(0).Item(1)
            Else
                MessageBox.Show("Failed to connect to data source")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub

    Private Sub submnu_PurchaseRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_PurchaseRegister.Click
        GmoduleName = "Purchase Register"
        Dim objpurchaseregister As New frmPurchaseregister
        objpurchaseregister.MdiParent = Me
        objpurchaseregister.Show()
    End Sub

    Private Sub submnu_MainStorePosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_MainStorePosition.Click
        GmoduleName = "Main Store Position"
        Dim objMainstockposition As New frmmainstockposition
        objMainstockposition.MdiParent = Me
        objMainstockposition.Show()
    End Sub

    Private Sub Main_MDI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ''If e.KeyCode = Keys.F1 Then
        ''    Dim objmemberhelp As New Memberhelp1
        ''    objmemberhelp.MdiParent = Me
        ''    objmemberhelp.Show()
        ''End If
    End Sub

    Private Sub submnu_Useradmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Useradmin.Click
        Dim Uadmin As New UserAdmin
        If Me.DuplicateForm(Uadmin.Name) = False Then
            submnu_Useradmin.Checked = True
            Uadmin.MdiParent = Me
            Uadmin.Show()
        End If
    End Sub
    Private Function DuplicateForm(ByVal FormName As String) As Boolean
        DuplicateForm = False
        Dim i As Integer
        If Me.MdiChildren Is Nothing Then
            Exit Function
        End If
        For i = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(i).Name = FormName Then
                GmoduleName = FormName
                DuplicateForm = True
                Exit Function
            End If
        Next i
    End Function

    Private Sub submnu_StockAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockAdjustment.Click
        Dim objStockAdjustment As New Stock_Adjustment
        GmoduleName = "Stock Adjustment"
        If StockAdjustmentTransbool = False And submnu_StockAdjustment.Checked = True Then
            objStockAdjustment.FormBorderStyle = FormBorderStyle.FixedDialog
            objStockAdjustment.MdiParent = Me
            objStockAdjustment.Show()
            submnu_StockAdjustment.Checked = True
        End If
        If submnu_StockAdjustment.Checked = True Then
            Exit Sub
        End If
        objStockAdjustment.FormBorderStyle = FormBorderStyle.FixedDialog
        objStockAdjustment.MdiParent = Me
        objStockAdjustment.Show()
        submnu_StockAdjustment.Checked = True
    End Sub


    Private Sub submnu_StockIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StockIssue.Click
        Dim objStockIssue As New Stock_Issue_Indent
        GmoduleName = "Stock  Issue"
        If StockIssueTransbool = False And submnu_StockIssue.Checked = True Then
            objStockIssue.FormBorderStyle = FormBorderStyle.FixedDialog
            objStockIssue.MdiParent = Me
            objStockIssue.Show()
            submnu_StockIssue.Checked = True
        End If
        If submnu_StockIssue.Checked = True Then
            Exit Sub
        End If
        objStockIssue.FormBorderStyle = FormBorderStyle.FixedDialog
        objStockIssue.MdiParent = Me
        objStockIssue.Show()
        submnu_StockIssue.Checked = True
    End Sub

    Private Sub submnu_Billofmaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Billofmaterial.Click
        Dim objCockTailRatio As New Cock_Tail_Ratio
        GmoduleName = ""
        If CockTailRatioTransbool = False And submnu_Billofmaterial.Checked = True Then
            objCockTailRatio.FormBorderStyle = FormBorderStyle.FixedDialog
            objCockTailRatio.MdiParent = Me
            objCockTailRatio.Show()
            submnu_Billofmaterial.Checked = True
        End If
        If submnu_Billofmaterial.Checked = True Then
            Exit Sub
        End If
        objCockTailRatio.FormBorderStyle = FormBorderStyle.FixedDialog
        objCockTailRatio.MdiParent = Me
        objCockTailRatio.Show()
        submnu_Billofmaterial.Checked = True
    End Sub
    Private Sub mnu_Administrator_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_Administrator.Select
        If UserAdminbool = False Then
            submnu_Useradmin.Checked = False
        End If
    End Sub

    Private Sub Submnu_Stocktransferregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submnu_Stocktransferregister.Click
        GmoduleName = "Stock Transfer Register"
        Dim objStocktransferreport As New frmStocktransferreport
        objStocktransferreport.MdiParent = Me
        objStocktransferreport.Show()
    End Sub

    Private Sub Submnu_StockReturnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submnu_StockReturnregister.Click
        GmoduleName = "Stock Return Register"
        Dim objStockreturnreport As New frmStockreturnreport
        objStockreturnreport.MdiParent = Me
        objStockreturnreport.Show()
    End Sub

    Private Sub Submnu_StockAdjustmentregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submnu_StockAdjustmentregister.Click
        GmoduleName = "Stock Adjustment Register"
        Dim objStockadjustmentreport As New frmStockadjustmentreport
        objStockadjustmentreport.MdiParent = Me
        objStockadjustmentreport.Show()
    End Sub

    Private Sub Stock_Summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock_Summary.Click
        GmoduleName = "Stock Summary"
        Dim objStockSummary As New frmStockSummary
        objStockSummary.MdiParent = Me
        objStockSummary.Show()
    End Sub


    Private Sub mnu_Exception_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Exception.Click
        GmoduleName = "Exception Report"
        Dim objStockSummary As New frmStockSummary_excep
        objStockSummary.MdiParent = Me
        objStockSummary.Show()
    End Sub

    Private Sub MnuAccPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAccPost.Click
        GmoduleName = "Account Posting Inventory"
        Dim obj_accPost As New JournalRegister
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim vAns As Double
        vAns = MsgBox("Do you want to Quit from Inventory?", MsgBoxStyle.Question + MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1, Me.Text)
        If vAns = MsgBoxResult.OK Then
            gPrint = False
            PRINTOPERATION()
            End
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim objStoreMaster As New sub_Sub_Group_Master
        GmoduleName = "Sub Sub Group Master"
        If StoreMasterbool = False And submnu_StoreMaster.Checked = True Then
            objStoreMaster.FormBorderStyle = FormBorderStyle.FixedDialog
            objStoreMaster.MdiParent = Me
            objStoreMaster.Show()
            submnu_StoreMaster.Checked = True
        End If
        If submnu_StoreMaster.Checked = True Then
            Exit Sub
        End If
        objStoreMaster.FormBorderStyle = FormBorderStyle.FixedDialog
        objStoreMaster.MdiParent = Me
        objStoreMaster.Show()
        submnu_StoreMaster.Checked = True
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Main_MDI.ActiveForm.Close()
        Dim cmp As New CompanyList1
        cmp.Show()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If MsgBox("DO U Want to Update......", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton2, "Stock Update") = MsgBoxResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            Dim strsql As String
            strsql = "Exec CP_StockUpdate"
            gconnection.ExcuteStoreProcedure(strsql)
            Me.Cursor = Cursors.Default
        Else
            MsgBox("Update Cancelled Try Again......", MsgBoxStyle.OKOnly, "Stock Update")
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GmoduleName = "Carry Forward"
        Dim objYrclsupdation As New YearEndConversion
        objYrclsupdation.MdiParent = Me
        objYrclsupdation.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GmoduleName = "Sub Store Consumption - Manual Updation"
        Dim objfrmMANUALUPDATION As New frmMANUALUPDATION
        objfrmMANUALUPDATION.MdiParent = Me
        objfrmMANUALUPDATION.Show()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GmoduleName = "VAT Input Tax Report"
        Dim objYrclsupdation As New InputTax
        objYrclsupdation.MdiParent = Me
        objYrclsupdation.Show()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GmoduleName = "Weighted Average"
        Dim objfrmMANUALUPDATION As New frmstockissuerate
        objfrmMANUALUPDATION.MdiParent = Me
        objfrmMANUALUPDATION.Show()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GmoduleName = "Purchase Register Recon"
        Dim objpurchaseregister As New frmPurchaseregister_Recon
        objpurchaseregister.MdiParent = Me
        objpurchaseregister.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GmoduleName = "Indent"
        Dim objindentfrm As New StockIndent
        objindentfrm.MdiParent = Me
        objindentfrm.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GmoduleName = "Pending Indent Report"
        Dim objPendingIndentReport As New PendingIndent
        objPendingIndentReport.MdiParent = Me
        objPendingIndentReport.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        GmoduleName = "Indentwise Register"
        Dim objIndentwiseReport As New Indent_Register
        objIndentwiseReport.MdiParent = Me
        objIndentwiseReport.Show()
    End Sub

    Private Sub Main_MDI_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim vAns As Double
        vAns = MsgBox("Do you want to Quit from Inventory?", MsgBoxStyle.Question + MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1, Me.Text)
        If vAns = MsgBoxResult.OK Then
            End
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        GmoduleName = "Consolidated Summary"
        Dim objConsolidatedSummary As New frmConsolidatedLiquorSummary
        objConsolidatedSummary.MdiParent = Me
        objConsolidatedSummary.Show()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        GmoduleName = "Account Posting Party"
        Dim obj_accPost As New SJV_JournalRegister
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        GmoduleName = "Account Posting Transit Quarters"
        Dim obj_accPostG As New GJV_JournalRegister
        obj_accPostG.MdiParent = Me
        obj_accPostG.Show()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        GmoduleName = "Month Bill Posting"
        Dim obj_accPost As New MJV_JournalRegister
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        GmoduleName = "BILL"
        Dim obj_accPost As New MBILL
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        GmoduleName = "ABC Report Analysis"
        Dim obj_accPost As New ABC_Summary
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        GmoduleName = "Rol Summary"
        Dim obj_accPost As New frmrol_Summary
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        GmoduleName = "Item Master Printing Store Wise"
        Dim obj_accPost As New frmItemMaterPrinting
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        GmoduleName = "Daily Consumption Report"
        Dim obj_accPost As New dailyisueDetails
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        GmoduleName = "Weighted Average for Item"
        Dim obj_accPost As New frmWaitItemCode
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        GmoduleName = "MRP Rate"
        Dim obj_accPost As New frmRateLiq
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        GmoduleName = "Company Master"
        Dim obj_accPost As New InvCompanyMaster
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        GmoduleName = "FOC Report"
        Dim obj_accPost As New frmFOCReport
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        GmoduleName = "Uom Convertion Entry"
        Dim obj_accPost As New FrmUomRelation
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        GmoduleName = "Pos Item Store Tagging"
        Dim obj_accPost As New FrmPosItemStoreTag
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub

    Private Sub mnu_Transaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Transaction.Click

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        GmoduleName = "Excise Report"
        Dim obj_accPost As New frmExciseReport
        obj_accPost.MdiParent = Me
        obj_accPost.Show()
    End Sub
End Class
