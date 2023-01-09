Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmFOCReport
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
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chk_SelectAllSubgroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_SubGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Itemlist As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Itemdetails As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_GroupList As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Groupdesc As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_Date As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_Item As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFOCReport))
        Me.CHK_Date = New System.Windows.Forms.CheckBox
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chk_SelectAllSubgroup = New System.Windows.Forms.CheckBox
        Me.Chklist_SubGroup = New System.Windows.Forms.CheckedListBox
        Me.lbl_Itemlist = New System.Windows.Forms.Label
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox
        Me.Chklist_Itemdetails = New System.Windows.Forms.CheckedListBox
        Me.lbl_GroupList = New System.Windows.Forms.Label
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.Chklist_Groupdesc = New System.Windows.Forms.CheckedListBox
        Me.CHK_Item = New System.Windows.Forms.CheckBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHK_Date
        '
        Me.CHK_Date.BackColor = System.Drawing.Color.Transparent
        Me.CHK_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CHK_Date.Location = New System.Drawing.Point(456, 408)
        Me.CHK_Date.Name = "CHK_Date"
        Me.CHK_Date.Size = New System.Drawing.Size(144, 24)
        Me.CHK_Date.TabIndex = 476
        Me.CHK_Date.Text = "WITH DATE WISE"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackColor = System.Drawing.Color.Transparent
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(96, 438)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 475
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
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 574)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 474
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(336, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(228, 31)
        Me.lbl_Heading.TabIndex = 458
        Me.lbl_Heading.Text = "REPORT FOR FOC"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(96, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 473
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(424, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(544, 24)
        Me.dtp_Todate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Todate.TabIndex = 1
        Me.dtp_Todate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FROM DATE :"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(472, 526)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 472
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(328, 526)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 469
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(624, 525)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 470
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(184, 526)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 468
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Location = New System.Drawing.Point(96, 510)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(712, 56)
        Me.frmbut.TabIndex = 471
        Me.frmbut.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(312, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 467
        Me.Label1.Text = "SELECT SUBGROUP :"
        '
        'Timer1
        '
        '
        'Chk_SelectAllSubgroup
        '
        Me.Chk_SelectAllSubgroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSubgroup.Location = New System.Drawing.Point(312, 79)
        Me.Chk_SelectAllSubgroup.Name = "Chk_SelectAllSubgroup"
        Me.Chk_SelectAllSubgroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllSubgroup.TabIndex = 465
        Me.Chk_SelectAllSubgroup.Text = "SELECT ALL"
        '
        'Chklist_SubGroup
        '
        Me.Chklist_SubGroup.CheckOnClick = True
        Me.Chklist_SubGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_SubGroup.Location = New System.Drawing.Point(312, 127)
        Me.Chklist_SubGroup.Name = "Chklist_SubGroup"
        Me.Chklist_SubGroup.Size = New System.Drawing.Size(264, 256)
        Me.Chklist_SubGroup.TabIndex = 466
        '
        'lbl_Itemlist
        '
        Me.lbl_Itemlist.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Itemlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemlist.ForeColor = System.Drawing.Color.White
        Me.lbl_Itemlist.Location = New System.Drawing.Point(616, 102)
        Me.lbl_Itemlist.Name = "lbl_Itemlist"
        Me.lbl_Itemlist.Size = New System.Drawing.Size(272, 24)
        Me.lbl_Itemlist.TabIndex = 464
        Me.lbl_Itemlist.Text = "SELECT ITEMCODE :"
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(616, 78)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllItem.TabIndex = 462
        Me.Chk_SelectAllItem.Text = "SELECT ALL"
        '
        'Chklist_Itemdetails
        '
        Me.Chklist_Itemdetails.CheckOnClick = True
        Me.Chklist_Itemdetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Itemdetails.Location = New System.Drawing.Point(616, 125)
        Me.Chklist_Itemdetails.Name = "Chklist_Itemdetails"
        Me.Chklist_Itemdetails.Size = New System.Drawing.Size(272, 256)
        Me.Chklist_Itemdetails.TabIndex = 463
        '
        'lbl_GroupList
        '
        Me.lbl_GroupList.BackColor = System.Drawing.Color.Maroon
        Me.lbl_GroupList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupList.ForeColor = System.Drawing.Color.White
        Me.lbl_GroupList.Location = New System.Drawing.Point(24, 102)
        Me.lbl_GroupList.Name = "lbl_GroupList"
        Me.lbl_GroupList.Size = New System.Drawing.Size(248, 24)
        Me.lbl_GroupList.TabIndex = 461
        Me.lbl_GroupList.Text = "SELECT GROUPCODE :"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(24, 78)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllGroup.TabIndex = 459
        Me.Chk_SelectAllGroup.Text = "SELECT ALL"
        '
        'Chklist_Groupdesc
        '
        Me.Chklist_Groupdesc.CheckOnClick = True
        Me.Chklist_Groupdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Groupdesc.Location = New System.Drawing.Point(24, 126)
        Me.Chklist_Groupdesc.Name = "Chklist_Groupdesc"
        Me.Chklist_Groupdesc.Size = New System.Drawing.Size(248, 256)
        Me.Chklist_Groupdesc.TabIndex = 460
        '
        'CHK_Item
        '
        Me.CHK_Item.BackColor = System.Drawing.Color.Transparent
        Me.CHK_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CHK_Item.Location = New System.Drawing.Point(280, 408)
        Me.CHK_Item.Name = "CHK_Item"
        Me.CHK_Item.Size = New System.Drawing.Size(144, 24)
        Me.CHK_Item.TabIndex = 477
        Me.CHK_Item.Text = "ITEM WISE"
        '
        'frmFOCReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 622)
        Me.Controls.Add(Me.CHK_Item)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_SelectAllSubgroup)
        Me.Controls.Add(Me.Chklist_SubGroup)
        Me.Controls.Add(Me.lbl_Itemlist)
        Me.Controls.Add(Me.Chk_SelectAllItem)
        Me.Controls.Add(Me.Chklist_Itemdetails)
        Me.Controls.Add(Me.lbl_GroupList)
        Me.Controls.Add(Me.Chk_SelectAllGroup)
        Me.Controls.Add(Me.Chklist_Groupdesc)
        Me.Controls.Add(Me.CHK_Date)
        Me.Name = "frmFOCReport"
        Me.Text = "frmFOCReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Public pageno, pagesize As Integer
    Dim dr As DataRow
    Dim zeroval As Double
    Private Sub frmFOCReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Chklist_Groupdesc.Items.Clear()
        Chklist_Itemdetails.Items.Clear()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        Call FillGroupdetails()
        Chklist_Itemdetails.Focus()
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
    Private Sub FillItemdetails()
        Dim i As Integer
        Dim sqlstring As String
        Chklist_Itemdetails.Items.Clear()
        sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER where isnull(freeze,'') <> 'Y' ORDER BY ITEMCODE "
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
        sqlstring = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM INVENTORYGROUPMASTER where isnull(freeze,'') <> 'y' ORDER BY GROUPCODE  "
        gconnection.getDataSet(sqlstring, "INVENTORYGROUPMASTER")
        If gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYGROUPMASTER").Rows(i)
                    Chklist_Groupdesc.Items.Add(Trim(CStr(.Item("GROUPDESC"))))
                End With
            Next
        End If
    End Sub

    Private Sub Chklist_Groupdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_Groupdesc.SelectedIndexChanged
        Dim i, J As Integer
        Dim sqlstring, ssql As String
        ssql = ""
        sqlstring = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER "
        sqlstring = sqlstring & " WHERE ISNULL(FREEZE,'') <> 'Y' AND GROUPDESC IN ("

        For J = 0 To Chklist_Groupdesc.CheckedItems.Count - 1
            If J = Chklist_Groupdesc.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & Chklist_Groupdesc.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & Chklist_Groupdesc.CheckedItems(J) & "', "
            End If
        Next
        If Chklist_Groupdesc.CheckedItems.Count > 0 Then
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

    Private Sub Chklist_SubGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_SubGroup.SelectedIndexChanged
        Dim i, J As Integer
        Dim sqlstring, ssql, ssql1 As String
        ssql = ""
        sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER AS I "
        sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' and I.GROUPNAME IN ("

        For J = 0 To Chklist_Groupdesc.CheckedItems.Count - 1
            If J = Chklist_Groupdesc.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & Chklist_Groupdesc.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & Chklist_Groupdesc.CheckedItems(J) & "', "
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
        If Chklist_Groupdesc.CheckedItems.Count > 0 Then
            Chklist_Itemdetails.Items.Clear()
            sqlstring = sqlstring & ssql & ") AND SUBGROUPNAME IN (" & ssql1 & ") order by itemcode "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        Chklist_Itemdetails.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
                    End With
                Next i
            End If
        End If
    End Sub

    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllGroup.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllGroup.Checked = True Then
            For i = 0 To Chklist_Groupdesc.Items.Count - 1
                Chklist_Groupdesc.SetItemChecked(i, True)
            Next
            Call Chklist_Groupdesc_SelectedIndexChanged(sender, e)
        Else
            For i = 0 To Chklist_Groupdesc.Items.Count - 1
                Chklist_Groupdesc.SetItemChecked(i, False)
            Next
            Chk_SelectAllItem.Checked = False
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

    Private Sub Chk_SelectAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllItem.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllItem.Checked = True Then
            For i = 0 To Chklist_Itemdetails.Items.Count - 1
                Chklist_Itemdetails.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_Itemdetails.Items.Count - 1
                Chklist_Itemdetails.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        Chklist_Groupdesc.Items.Clear()
        Chklist_SubGroup.Items.Clear()
        Chklist_Itemdetails.Items.Clear()
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Chklist_Itemdetails.Focus()
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If Chklist_Groupdesc.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group description(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Chklist_Itemdetails.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 424
        grp_SalebillChecklist.Left = 96
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call ViewSummary()
        End If
    End Sub
    Public Sub ViewSummary()
        Dim I As Integer
        Dim Itemcode() As String
        Dim rViewer As New Viewer
        If CHK_Item.Checked = True And CHK_Date.Checked = False Then
            sqlstring = "SELECT COMPANYCODE,COMPANYNAME,ITEMCODE,ITEMNAME,SUM(QTY)AS QTY,RATE,SUM(VALUE) AS VALUE FROM VIEW_FOCREPORT "
        ElseIf CHK_Item.Checked = False And CHK_Date.Checked = True Then
            sqlstring = "SELECT * FROM VIEW_FOCREPORT "
        End If
        If Chklist_Itemdetails.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " WHERE ITEMCODE IN ("
            For I = 0 To Chklist_Itemdetails.CheckedItems.Count - 1
                Itemcode = Split(Chklist_Itemdetails.CheckedItems(I), "-->")
                sqlstring = sqlstring & "'" & Itemcode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ") "
        Else
            MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If CHK_Item.Checked = False And CHK_Date.Checked = True Then
            sqlstring = sqlstring & " AND GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' ORDER BY COMPANYNAME,GRNDATE,ITEMCODE"
        ElseIf CHK_Item.Checked = True And CHK_Date.Checked = False Then
            sqlstring = sqlstring & " AND GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' GROUP BY COMPANYCODE,COMPANYNAME,ITEMCODE,ITEMNAME,RATE ORDER BY COMPANYNAME,ITEMCODE"
        End If
        gconnection.getDataSet(sqlstring, "FOC")
        If gdataset.Tables("FOC").Rows.Count > 0 Then
            If CHK_Item.Checked = False And CHK_Date.Checked = True Then
                Dim r As New Rpt_FOC_Datewise
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VIEW_FOCREPORT"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim TXTOBJ2 As TextObject
                TXTOBJ2 = r.ReportDefinition.ReportObjects("Text16")
                TXTOBJ2.Text = " Prepared By : " & gUsername
                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                rViewer.Show()
            ElseIf CHK_Item.Checked = True And CHK_Date.Checked = False Then
                Dim r As New Rpt_FOC_Itemwise
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VIEW_FOCREPORT"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim TXTOBJ2 As TextObject
                TXTOBJ2 = r.ReportDefinition.ReportObjects("Text16")
                TXTOBJ2.Text = " Prepared By : " & gUsername
                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                rViewer.Show()
            End If
        Else
            MessageBox.Show("No Records Found", MyCompanyName, MessageBoxButtons.OK)
        End If
        'sqlstring = sqlstring & " ORDER BY ITEMNAME,MODIFYDATE DESC"
        'Call Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    End Sub

    Private Sub CHK_Item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_Item.CheckedChanged
        If CHK_Item.Checked = True Then
            CHK_Date.Checked = False
        End If
    End Sub

    Private Sub CHK_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_Date.CheckedChanged
        If CHK_Date.Checked = True Then
            CHK_Item.Checked = False
        End If
    End Sub
End Class
