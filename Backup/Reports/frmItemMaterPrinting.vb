Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class frmItemMaterPrinting
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Billterms As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Cbo_StoreName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chklist_Subgroupdesc As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_SelectAllSubGroup As System.Windows.Forms.CheckBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemMaterPrinting))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.lbl_Billterms = New System.Windows.Forms.Label
        Me.lbl_Suppliercode = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_export = New System.Windows.Forms.Button
        Me.Cbo_StoreName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSubGroup = New System.Windows.Forms.CheckBox
        Me.chklist_Subgroupdesc = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.frmbut.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(96, 11)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(477, 31)
        Me.lbl_Heading.TabIndex = 109
        Me.lbl_Heading.Text = "ITEM MASTER PRINTING STORE WISE"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(624, 352)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(72, 26)
        Me.DateTimePicker1.TabIndex = 107
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(640, 400)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(40, 26)
        Me.DateTimePicker2.TabIndex = 106
        Me.DateTimePicker2.Visible = False
        '
        'lbl_Billterms
        '
        Me.lbl_Billterms.AutoSize = True
        Me.lbl_Billterms.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billterms.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billterms.Location = New System.Drawing.Point(624, 376)
        Me.lbl_Billterms.Name = "lbl_Billterms"
        Me.lbl_Billterms.Size = New System.Drawing.Size(84, 21)
        Me.lbl_Billterms.TabIndex = 99
        Me.lbl_Billterms.Text = "TO DATE :"
        Me.lbl_Billterms.Visible = False
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(632, 328)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(108, 21)
        Me.lbl_Suppliercode.TabIndex = 98
        Me.lbl_Suppliercode.Text = "FROM DATE :"
        Me.lbl_Suppliercode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Location = New System.Drawing.Point(664, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(8, 48)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(288, 376)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 117
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(160, 376)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 114
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(424, 376)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 115
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(32, 376)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 113
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.cmd_export)
        Me.frmbut.Location = New System.Drawing.Point(16, 360)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(664, 56)
        Me.frmbut.TabIndex = 116
        Me.frmbut.TabStop = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_export.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.White
        Me.cmd_export.Image = CType(resources.GetObject("cmd_export.Image"), System.Drawing.Image)
        Me.cmd_export.Location = New System.Drawing.Point(536, 16)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(104, 32)
        Me.cmd_export.TabIndex = 116
        Me.cmd_export.Text = "Expot[F12]"
        '
        'Cbo_StoreName
        '
        Me.Cbo_StoreName.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_StoreName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_StoreName.Items.AddRange(New Object() {"BAR1", "BAR2", "BAR3"})
        Me.Cbo_StoreName.Location = New System.Drawing.Point(16, 88)
        Me.Cbo_StoreName.Name = "Cbo_StoreName"
        Me.Cbo_StoreName.Size = New System.Drawing.Size(192, 27)
        Me.Cbo_StoreName.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "STORE NAME :"
        '
        'Chk_SelectAllSubGroup
        '
        Me.Chk_SelectAllSubGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSubGroup.Location = New System.Drawing.Point(235, 64)
        Me.Chk_SelectAllSubGroup.Name = "Chk_SelectAllSubGroup"
        Me.Chk_SelectAllSubGroup.Size = New System.Drawing.Size(128, 16)
        Me.Chk_SelectAllSubGroup.TabIndex = 454
        Me.Chk_SelectAllSubGroup.Text = "SELECT ALL"
        '
        'chklist_Subgroupdesc
        '
        Me.chklist_Subgroupdesc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklist_Subgroupdesc.Location = New System.Drawing.Point(0, 32)
        Me.chklist_Subgroupdesc.Name = "chklist_Subgroupdesc"
        Me.chklist_Subgroupdesc.Size = New System.Drawing.Size(408, 180)
        Me.chklist_Subgroupdesc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHOOSE YOUR SUBGROUP FILTRATION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.chklist_Subgroupdesc)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(232, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 221)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(8, 8)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(696, 344)
        Me.ssGrid.TabIndex = 455
        '
        'frmItemMaterPrinting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(688, 454)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.Chk_SelectAllSubGroup)
        Me.Controls.Add(Me.Cbo_StoreName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Billterms)
        Me.Controls.Add(Me.lbl_Suppliercode)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmItemMaterPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT [ ITEM MASTER STORE WISE]"
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim SQLSTRING As String
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dc As DataColumn
    Dim pageno As Integer
    Dim pagesize As Integer
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
    Private Sub FillStore()
        Dim i As Integer
        SQLSTRING = "SELECT DISTINCT ISNULL(STOREcode,'') + '- '+ ISNULL(STOREdesc,'') AS STOREdesc FROM STOREMASTER WHERE isnull(freeze,'') <> 'Y' "
        gconnection.getDataSet(SQLSTRING, "STOREMASTER")
        Cbo_StoreName.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                Cbo_StoreName.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREdesc"))
            Next i
        End If
    End Sub
    Private Sub FillGroupdetails()
        Dim i As Integer
        Dim sqlstring As String
        chklist_Subgroupdesc.Items.Clear()
        sqlstring = "SELECT ISNULL(SUBGROUPCODE,'') AS GROUPCODE,ISNULL(SUBGROUPDESC,'') AS GROUPDESC FROM INVENTORYSUBGROUPMASTER ORDER BY SUBGROUPCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYGROUPMASTER")
        If gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYGROUPMASTER").Rows(i)
                    chklist_Subgroupdesc.Items.Add(Trim(CStr(.Item("GROUPDESC"))))
                End With
            Next
        End If
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub frmItemMaterPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillStore()
        Call FillGroupdetails()
        ssGrid.Visible = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        chklist_Subgroupdesc.Items.Clear()
        ssGrid.Visible = False
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub Chk_SelectAllSubGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllSubGroup.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllSubGroup.Checked = True Then
            For i = 0 To chklist_Subgroupdesc.Items.Count - 1
                chklist_Subgroupdesc.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Subgroupdesc.Items.Count - 1
                chklist_Subgroupdesc.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub frmItemMaterPrinting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        ElseIf e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            Dim search As New frmListSearch
            search.listbox = chklist_Subgroupdesc
            search.Text = "Group Search"
            search.ShowDialog(Me)
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        Dim vAns As Double
        vAns = MsgBox("For Windows Yes, For Dos No", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Me.Text)
        If vAns = MsgBoxResult.Yes Then
            Call PRINTOPERATION_WINDOWS()
        Else
            Call PRINTOPERATION()
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Dim vAns As Double
        vAns = MsgBox("For Windows Yes, For Dos No", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, Me.Text)
        If vAns = MsgBoxResult.Yes Then
        Else
            Call PRINTOPERATION()
        End If
    End Sub

    Private Sub PRINTOPERATION()
        Dim x, docno, printline, Storecode() As String
        Dim Subcode As String
        Dim I, J As Integer
        Dim booldocno As Boolean
        Dim total(10) As Double
        Dim vsubheader() As String = {"DOC NO. : ", "DOC DATE : ", "MAIN STORE CODE : ", "MAIN STORE NAME : ", "TO STORE CODE  : ", "TO STORE NAME :"}
        Dim PAGEHEADING() As String = {"ITEM MASTER PRINTING"}
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Storecode = Split(Cbo_StoreName.Text, "-")
            If chklist_Subgroupdesc.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the SubGroup description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            SQLSTRING = "SELECT ITEMCODE,ITEMNAME,STOCKUOM,PURCHASERATE,SALERATE,SUBSUBGROUPCODE,SUBSUBGROUPNAME FROM INVENTORYITEMMASTER "
            SQLSTRING = SQLSTRING & " WHERE SUBSUBGROUPNAME IN ("
            For J = 0 To chklist_Subgroupdesc.CheckedItems.Count - 1
                If J = chklist_Subgroupdesc.CheckedItems.Count - 1 Then
                    SQLSTRING = SQLSTRING & " '" & chklist_Subgroupdesc.CheckedItems(J) & "' "
                Else
                    SQLSTRING = SQLSTRING & " '" & chklist_Subgroupdesc.CheckedItems(J) & "', "
                End If
            Next
            SQLSTRING = SQLSTRING & ")"
            SQLSTRING = SQLSTRING & " AND STORECODE = '" & Storecode(0) & "' ORDER BY SUBSUBGROUPNAME,ITEMCODE"
            gconnection.getDataSet(SQLSTRING, "INVENTORYSTOREMASTER")
            Call Print_Headers(PAGEHEADING)
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For Each dr In gdataset.Tables("INVENTORYSTOREMASTER").Rows
                If Subcode <> dr.Item("SUBSUBGROUPCODE") Then
                    Filewrite.WriteLine(StrDup(Len(dr.Item("SUBSUBGROUPNAME")), "-"))
                    Filewrite.WriteLine("{0,-40}", Mid(dr.Item("SUBSUBGROUPNAME"), 1, 40))
                    Filewrite.WriteLine(StrDup(Len(dr.Item("SUBSUBGROUPNAME")), "-"))
                    pagesize = pagesize + 3
                    Subcode = dr.Item("SUBSUBGROUPCODE")
                End If
                Filewrite.WriteLine("|{0,-15}|{1,-40}|{2,10}|{3,10}||{4,10}|", Mid(dr.Item("ITEMCODE"), 1, 15), Mid(dr.Item("ITEMNAME"), 1, 40), Mid(dr.Item("STOCKUOM"), 1, 10), Mid(Format(dr.Item("PURCHASERATE"), "0.000"), 1, 10), Mid(Format(dr.Item("SALERATE"), "0.000"), 1, 10))
                pagesize = pagesize + 1
                If pagesize > 58 Then
                    Filewrite.Write(StrDup(90, "-"))
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call Print_Headers(PAGEHEADING)
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                End If
            Next dr
            Filewrite.WriteLine(StrDup(90, "-"))
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
    Private Sub PRINTOPERATION_WINDOWS()
        Dim Storecode() As String
        Dim j, psize As Integer
        ssGrid.Visible = True
        ' Dim OBJstkLedger_Grid As New frmStkLedger_grid
        'OBJstkLedger_Grid.MdiParent = Me
        ssGrid.Show()
        ssGrid.ClearRange(-1, 6, -1, 6, True)

        Storecode = Split(Cbo_StoreName.Text, "-")
        If chklist_Subgroupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the SubGroup description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        SQLSTRING = "SELECT ITEMCODE,ITEMNAME,STOCKUOM,PURCHASERATE,SALERATE,SUBSUBGROUPCODE,SUBSUBGROUPNAME FROM INVENTORYITEMMASTER "
        SQLSTRING = SQLSTRING & " WHERE SUBSUBGROUPNAME IN ("
        For J = 0 To chklist_Subgroupdesc.CheckedItems.Count - 1
            If J = chklist_Subgroupdesc.CheckedItems.Count - 1 Then
                SQLSTRING = SQLSTRING & " '" & chklist_Subgroupdesc.CheckedItems(J) & "' "
            Else
                SQLSTRING = SQLSTRING & " '" & chklist_Subgroupdesc.CheckedItems(J) & "', "
            End If
        Next
        SQLSTRING = SQLSTRING & ")"
        SQLSTRING = SQLSTRING & " AND STORECODE = '" & Storecode(0) & "' ORDER BY SUBSUBGROUPNAME,ITEMCODE"
        gconnection.getDataSet(SQLSTRING, "INVENTORYITEMMASTER")
        psize = 5
        For j = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
            With ssGrid
                .Col = 1
                .Row = 1
                '.EditModePermanent = True
                .Text = "" & MyCompanyName
                'If STORECODE = "MNS" Then
                .Col = 1
                .Row = 3
                .Text = ""
                .RowsFrozen = 4
                .Col = 1
                .Row = psize
                .Text = gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")
                .Col = 2
                .Row = psize
                .Text = gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")
                .Col = 3
                .Row = psize
                .Text = gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")
                .Col = 4
                .Row = psize
                .Text = gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")
                .Col = 5
                .Row = psize
                .Text = gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("SALERATE")
                psize = psize + 1
            End With
        Next


        'Dim Rviwer As New Viewer
        'Dim r As Rpt_ItemMasterPrinting
        'If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
        '    Rviwer.ssql = SQLSTRING
        '    Rviwer.Report = r
        '    Rviwer.TableName = "INVENTORYITEMMASTER"
        '    'Dim textobj7 As TextObject
        '    'textobj7.Text = MyCompanyName
        '    'Dim TXTOBJ8 As TextObject
        '    'Dim TXTOBJ9 As TextObject
        '    'TXTOBJ8.Text = ""
        '    'TXTOBJ9.Text = ""
        '    Rviwer.Refresh()
        '    Rviwer.Show()
        'Else
        'MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OKOnly)
        'End If

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
            Filewrite.WriteLine(StrDup(90, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("|{0,-15}|{1,-40}|{2,10}|{3,10}||{4,10}|", "ITEMCODE", "ITEM DESCRIPTION", "UOM ", "PUR RATE", "SALE RATE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(90, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("STK" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".xls"
            ssGrid.ExportToExcel(VFilePath, "ITEMMASTER", AppPath & "\REPORTS\ITEM.log")
            Shell(strexcelpath & " " & VFilePath, AppWinStyle.MaximizedFocus)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Export")
        End Try
    End Sub
End Class
