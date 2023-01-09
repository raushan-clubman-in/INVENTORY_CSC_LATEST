Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class PendingIndent
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Dim pageno As Integer
    Dim pagesize As Integer
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
    Friend WithEvents grp_PENDING As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_name As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_indent As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chklst_Supplier As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Storelocation As System.Windows.Forms.Label
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PendingIndent))
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
        Me.grp_PENDING = New System.Windows.Forms.GroupBox
        Me.rdo_name = New System.Windows.Forms.RadioButton
        Me.rdo_indent = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSupplier = New System.Windows.Forms.CheckBox
        Me.chklst_Supplier = New System.Windows.Forms.CheckedListBox
        Me.lbl_Storelocation = New System.Windows.Forms.Label
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_PENDING.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(312, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(371, 31)
        Me.lbl_Heading.TabIndex = 9
        Me.lbl_Heading.Text = "PENDING REGISTER DETAILS"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 24)
        Me.Label4.TabIndex = 429
        Me.Label4.Text = "STORE SELECTION :"
        '
        'Chk_SelectAllStore
        '
        Me.Chk_SelectAllStore.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllStore.Location = New System.Drawing.Point(248, 72)
        Me.Chk_SelectAllStore.Name = "Chk_SelectAllStore"
        Me.Chk_SelectAllStore.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllStore.TabIndex = 428
        Me.Chk_SelectAllStore.Text = "SELECT ALL "
        '
        'chklst_Store
        '
        Me.chklst_Store.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklst_Store.Location = New System.Drawing.Point(248, 120)
        Me.chklst_Store.Name = "chklst_Store"
        Me.chklst_Store.Size = New System.Drawing.Size(392, 361)
        Me.chklst_Store.TabIndex = 427
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(144, 664)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 21)
        Me.Label5.TabIndex = 442
        Me.Label5.Text = "Press F3 to Search Store / Press ENTER key to navigate"
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
        Me.Cmd_Print.Location = New System.Drawing.Point(552, 616)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(728, 616)
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
        Me.Cmd_Clear.Location = New System.Drawing.Point(200, 616)
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
        Me.Timer1.Interval = 20
        '
        'grp_PENDING
        '
        Me.grp_PENDING.BackColor = System.Drawing.Color.Transparent
        Me.grp_PENDING.Controls.Add(Me.rdo_name)
        Me.grp_PENDING.Controls.Add(Me.rdo_indent)
        Me.grp_PENDING.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_PENDING.Location = New System.Drawing.Point(704, 488)
        Me.grp_PENDING.Name = "grp_PENDING"
        Me.grp_PENDING.Size = New System.Drawing.Size(232, 40)
        Me.grp_PENDING.TabIndex = 452
        Me.grp_PENDING.TabStop = False
        '
        'rdo_name
        '
        Me.rdo_name.Location = New System.Drawing.Point(104, 16)
        Me.rdo_name.Name = "rdo_name"
        Me.rdo_name.Size = New System.Drawing.Size(128, 16)
        Me.rdo_name.TabIndex = 1
        Me.rdo_name.Text = "PurchaseOrder"
        '
        'rdo_indent
        '
        Me.rdo_indent.Checked = True
        Me.rdo_indent.Location = New System.Drawing.Point(16, 16)
        Me.rdo_indent.Name = "rdo_indent"
        Me.rdo_indent.Size = New System.Drawing.Size(88, 16)
        Me.rdo_indent.TabIndex = 0
        Me.rdo_indent.TabStop = True
        Me.rdo_indent.Text = "INDENT"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(672, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 24)
        Me.Label2.TabIndex = 455
        Me.Label2.Text = "SUPPLIER SELECTION :"
        '
        'Chk_SelectAllSupplier
        '
        Me.Chk_SelectAllSupplier.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSupplier.Location = New System.Drawing.Point(672, 72)
        Me.Chk_SelectAllSupplier.Name = "Chk_SelectAllSupplier"
        Me.Chk_SelectAllSupplier.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllSupplier.TabIndex = 454
        Me.Chk_SelectAllSupplier.Text = "SELECT ALL "
        '
        'chklst_Supplier
        '
        Me.chklst_Supplier.CheckOnClick = True
        Me.chklst_Supplier.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklst_Supplier.Location = New System.Drawing.Point(672, 120)
        Me.chklst_Supplier.Name = "chklst_Supplier"
        Me.chklst_Supplier.Size = New System.Drawing.Size(288, 361)
        Me.chklst_Supplier.TabIndex = 453
        '
        'lbl_Storelocation
        '
        Me.lbl_Storelocation.AutoSize = True
        Me.lbl_Storelocation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Storelocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Storelocation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Storelocation.Location = New System.Drawing.Point(341, 496)
        Me.lbl_Storelocation.Name = "lbl_Storelocation"
        Me.lbl_Storelocation.Size = New System.Drawing.Size(134, 18)
        Me.lbl_Storelocation.TabIndex = 457
        Me.lbl_Storelocation.Text = "STORE LOCATION :"
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbo_Storelocation.ItemHeight = 19
        Me.cbo_Storelocation.Location = New System.Drawing.Point(493, 496)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(158, 27)
        Me.cbo_Storelocation.TabIndex = 456
        '
        'PendingIndent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Storelocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chk_SelectAllSupplier)
        Me.Controls.Add(Me.chklst_Supplier)
        Me.Controls.Add(Me.grp_PENDING)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chk_SelectAllStore)
        Me.Controls.Add(Me.chklst_Store)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "PendingIndent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTS [PENDING INDENT DETAILS ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_PENDING.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim Sqlstring As String
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If chklst_Store.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Store Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        gPrint = False
        grp_SalebillChecklist.Top = 528
        grp_SalebillChecklist.Left = 160
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
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
            Call Print_Indent()
        End If
    End Sub

    Private Sub ViewIssuedetails()
        Try
            Dim sqlstring, STORENAME(), Itemcode() As String
            Dim i As Integer
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

                sqlstring = sqlstring & " AND DOCDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & " ORDER BY GROUPDESC,ITEMCODE,ITEMNAME,LOCATIONNAME"
                'gconnection.getDataSet(sqlstring, "GRIDVIEW")
                'gridviewstatus = "Issuedetailsreport"
                'Dim griddesign As New GridDesign
                'griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
                'griddesign.MdiParent = MDIParentobj
                'Me.Close()
                'griddesign.Show()
                Dim WITHRATE As Boolean
                Dim heading() As String = {"ISSUE DETAILS REPORT"}
                Dim ObjStockIssuedetailsReport As New rptStockIssuedetails
                ObjStockIssuedetailsReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value, WITHRATE)
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

        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gDosPrint = False
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
        Me.Timer1.Interval = 100
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

    Private Sub Itemwise_Issue_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillStorename()
        Call Fillsuppliername()
        Call FillStore()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    '''******************************  To fill POS details from SupplierName  *******************************'''
    Private Sub FillStorename()
        Dim i As Integer
        chklst_Store.Items.Clear()
        Sqlstring = "SELECT isnull(STOREDESC,'') AS STOREDESC  FROM STOREMASTER ORDER BY STOREDESC"
        gconnection.getDataSet(Sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                With gdataset.Tables("STOREMASTER").Rows(i)
                    chklst_Store.Items.Add(Trim(.Item("STOREDESC")))
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
        chklst_Supplier.Items.Clear()
        Call FillStorename()
        Call FillStore()
        Call Fillsuppliername()
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

    Private Sub Print_Indent()
        Dim str, MTYPE(), tspilt(), Itemcode(), SUPPLIERNAME() As String
        Dim i As Integer
        Dim rViewer As New Viewer
        Dim r As New Rpt_Pending_Indent
        Dim Heading(0) As String
        Dim sqlstring, SSQL As String

        If rdo_indent.Checked = True Then
            sqlstring = " SELECT Indent_no , Indent_date, storelocationname, Itemcode, Itemname , qty , amount "
            sqlstring = sqlstring & "from Inv_view_Pending_Indent where rtrim(indent_no) not in "
            sqlstring = sqlstring & " ( select rtrim(ISNULL(indentno,'')) from stockissueheader where void <> 'Y') "
            sqlstring = sqlstring & " and void <> 'Y'"
            If chklst_Store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND ISNULL(Storelocationname,'') IN ("
                For i = 0 To chklst_Store.CheckedItems.Count - 1
                    If i = 0 Then
                        sqlstring = sqlstring & "'" & chklst_Store.CheckedItems(i)
                    Else
                        sqlstring = sqlstring & "','" & chklst_Store.CheckedItems(i)
                    End If
                Next
                sqlstring = sqlstring & "') "
            Else
                MessageBox.Show("Select the Store Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            sqlstring = sqlstring & "  AND ISNULL(fromstorecode,'') ='" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"
            sqlstring = sqlstring & " AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"

            gconnection.getDataSet(sqlstring, "Inv_view_Pending_Indent")
            If gdataset.Tables("Inv_view_Pending_Indent").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "Inv_view_Pending_Indent"

                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text3")
                textobj1.Text = MyCompanyName

                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                rViewer.Refresh()
                rViewer.Show()
            Else
                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
            End If
        Else
            Dim SViewer As New Viewer
            Dim S As New Rpt_Pending_Purchase
            ''sqlstring = "DROP VIEW PENDING"

            '   sqlstring = " CREATE VIEW PENDING AS "
            sqlstring = sqlstring & " SELECT pono,podate,podepartment,povendorcode,itemcode,ITEMNAME,quantity,rate,amount,vatamt,discamt, VENDORNAME"
            sqlstring = sqlstring & " from INV_PENDING_PURCHASE WHERE  "
            ' sqlstring = sqlstring & " "
            '  sqlstring = sqlstring & " "

            If chklst_Supplier.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & "   povendorcode IN ("
                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If chklst_Store.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND ISNULL(podepartment,'') IN ("
                For i = 0 To chklst_Store.CheckedItems.Count - 1
                    If i = 0 Then
                        sqlstring = sqlstring & "'" & chklst_Store.CheckedItems(i)
                    Else
                        sqlstring = sqlstring & "','" & chklst_Store.CheckedItems(i)
                    End If
                Next
                sqlstring = sqlstring & "') "
            Else
                MessageBox.Show("Select the Store Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '  sqlstring = sqlstring & " ISNULL(fromstorecode,'') ='" & Trim(Mid(cbo_Storelocation.Text, 1, 3)) & "'"
            sqlstring = sqlstring & " AND CAST(Convert(varchar(11),podate,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"

            gconnection.getDataSet(sqlstring, "Inv_view_Pending_Pur")
            If gdataset.Tables("Inv_view_Pending_Pur").Rows.Count > 0 Then
                SViewer.ssql = sqlstring
                SViewer.Report = S
                SViewer.TableName = "Inv_view_Pending_Pur"

                Dim textobj1 As TextObject
                textobj1 = S.ReportDefinition.ReportObjects("Text3")
                textobj1.Text = MyCompanyName
                'Dim TXTOBJ2 As TextObject
                'TXTOBJ2 = r.ReportDefinition.ReportObjects("Text16")
                'TXTOBJ2.Text = " Prepared By : " & gUsername
                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = S.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                SViewer.Refresh()
                SViewer.Show()
            Else
                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
            End If

        End If
    End Sub
    Private Sub Fillsuppliername()
        Dim i As Integer
        chklst_Supplier.Items.Clear()
        Sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE IN (SELECT ACCODE FROM ACCOUNTSGLACCOUNTMASTER WHERE ISNULL(acCODE,'')='" & Trim(gCreditors) & "')  AND ISNULL(FREeZEFLAG,'') <> 'Y' ORDER BY SLCODE"
        gconnection.getDataSet(sqlstring, "SUBLEDGERMASTER")
        If gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1
                With gdataset.Tables("SUBLEDGERMASTER").Rows(i)
                    chklst_Supplier.Items.Add(Trim(.Item("SLCODE")) & "-->" & Trim(.Item("SLNAME")))
                End With
            Next i
        Else
            Sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE IN (SELECT ACCODE FROM ACCOUNTSGLACCOUNTMASTER WHERE ISNULL(acCODE,'')='" & Trim(gCreditors) & "')  AND ISNULL(FREeZEFLAG,'') <> 'Y' ORDER BY SLCODE"
            gconnection.getDataSet(Sqlstring, "SUBLEDGERMASTER")
            If gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1
                    With gdataset.Tables("SUBLEDGERMASTER").Rows(i)
                        chklst_Supplier.Items.Add(Trim(.Item("SLCODE")) & "-->" & Trim(.Item("SLNAME")))
                    End With
                Next i

            End If
            End If
    End Sub
    Private Sub Chk_SelectAllSupplier_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllSupplier.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllSupplier.Checked = True Then
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklst_Supplier.Focus()
        End If
    End Sub

    Private Sub chklst_Supplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chklst_Supplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' opt_Purchasedetails.Focus()
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
End Class
