Imports System.IO
Imports System.Data.SqlClient
Public Class frmRateLiq
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
    Friend WithEvents lbl_GroupList As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Groupdesc As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Itemlist As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Itemdetails As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chklist_SubGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents Chk_SelectAllSubgroup As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CHK_All As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Target As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRateLiq))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_GroupList = New System.Windows.Forms.Label
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.Chklist_Groupdesc = New System.Windows.Forms.CheckedListBox
        Me.lbl_Itemlist = New System.Windows.Forms.Label
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox
        Me.Chklist_Itemdetails = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSubgroup = New System.Windows.Forms.CheckBox
        Me.Chklist_SubGroup = New System.Windows.Forms.CheckedListBox
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CHK_All = New System.Windows.Forms.CheckBox
        Me.Chk_Target = New System.Windows.Forms.CheckBox
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
        Me.lbl_Heading.Location = New System.Drawing.Point(256, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(368, 31)
        Me.lbl_Heading.TabIndex = 6
        Me.lbl_Heading.Text = "REPORT FOR RATE / TARGET"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_GroupList
        '
        Me.lbl_GroupList.BackColor = System.Drawing.Color.Maroon
        Me.lbl_GroupList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupList.ForeColor = System.Drawing.Color.White
        Me.lbl_GroupList.Location = New System.Drawing.Point(24, 88)
        Me.lbl_GroupList.Name = "lbl_GroupList"
        Me.lbl_GroupList.Size = New System.Drawing.Size(248, 24)
        Me.lbl_GroupList.TabIndex = 441
        Me.lbl_GroupList.Text = "SELECT GROUPCODE :"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(24, 64)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllGroup.TabIndex = 439
        Me.Chk_SelectAllGroup.Text = "SELECT ALL"
        '
        'Chklist_Groupdesc
        '
        Me.Chklist_Groupdesc.CheckOnClick = True
        Me.Chklist_Groupdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Groupdesc.Location = New System.Drawing.Point(24, 112)
        Me.Chklist_Groupdesc.Name = "Chklist_Groupdesc"
        Me.Chklist_Groupdesc.Size = New System.Drawing.Size(248, 256)
        Me.Chklist_Groupdesc.TabIndex = 440
        '
        'lbl_Itemlist
        '
        Me.lbl_Itemlist.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Itemlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemlist.ForeColor = System.Drawing.Color.White
        Me.lbl_Itemlist.Location = New System.Drawing.Point(616, 88)
        Me.lbl_Itemlist.Name = "lbl_Itemlist"
        Me.lbl_Itemlist.Size = New System.Drawing.Size(272, 24)
        Me.lbl_Itemlist.TabIndex = 444
        Me.lbl_Itemlist.Text = "SELECT ITEMCODE :"
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(616, 64)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllItem.TabIndex = 442
        Me.Chk_SelectAllItem.Text = "SELECT ALL"
        '
        'Chklist_Itemdetails
        '
        Me.Chklist_Itemdetails.CheckOnClick = True
        Me.Chklist_Itemdetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Itemdetails.Location = New System.Drawing.Point(616, 111)
        Me.Chklist_Itemdetails.Name = "Chklist_Itemdetails"
        Me.Chklist_Itemdetails.Size = New System.Drawing.Size(272, 256)
        Me.Chklist_Itemdetails.TabIndex = 443
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(312, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 447
        Me.Label1.Text = "SELECT SUBGROUP :"
        '
        'Chk_SelectAllSubgroup
        '
        Me.Chk_SelectAllSubgroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_SelectAllSubgroup.Location = New System.Drawing.Point(312, 65)
        Me.Chk_SelectAllSubgroup.Name = "Chk_SelectAllSubgroup"
        Me.Chk_SelectAllSubgroup.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllSubgroup.TabIndex = 445
        Me.Chk_SelectAllSubgroup.Text = "SELECT ALL"
        '
        'Chklist_SubGroup
        '
        Me.Chklist_SubGroup.CheckOnClick = True
        Me.Chklist_SubGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_SubGroup.Location = New System.Drawing.Point(312, 113)
        Me.Chklist_SubGroup.Name = "Chklist_SubGroup"
        Me.Chklist_SubGroup.Size = New System.Drawing.Size(264, 256)
        Me.Chklist_SubGroup.TabIndex = 446
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackColor = System.Drawing.Color.Transparent
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(96, 424)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 456
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
        Me.Label5.Location = New System.Drawing.Point(128, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 455
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(96, 424)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 454
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
        Me.Cmd_Print.Location = New System.Drawing.Point(472, 512)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 453
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(328, 512)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 450
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(624, 511)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 451
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(184, 512)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 449
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Location = New System.Drawing.Point(96, 496)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(712, 56)
        Me.frmbut.TabIndex = 452
        Me.frmbut.TabStop = False
        '
        'Timer1
        '
        '
        'CHK_All
        '
        Me.CHK_All.BackColor = System.Drawing.Color.Transparent
        Me.CHK_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CHK_All.Location = New System.Drawing.Point(784, 376)
        Me.CHK_All.Name = "CHK_All"
        Me.CHK_All.TabIndex = 457
        Me.CHK_All.Text = "ALL DATE"
        '
        'Chk_Target
        '
        Me.Chk_Target.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Target.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Chk_Target.Location = New System.Drawing.Point(32, 384)
        Me.Chk_Target.Name = "Chk_Target"
        Me.Chk_Target.Size = New System.Drawing.Size(192, 24)
        Me.Chk_Target.TabIndex = 458
        Me.Chk_Target.Text = "FOR TARGET REPORT"
        '
        'frmRateLiq
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(904, 638)
        Me.Controls.Add(Me.Chk_Target)
        Me.Controls.Add(Me.CHK_All)
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
        Me.Name = "frmRateLiq"
        Me.Text = "frmRateLiq"
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
    Private Sub frmRateLiq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If Chk_Target.Checked = False Then
                Call ViewSummary()
            Else
                Call ViewSummary1()
            End If
        End If
    End Sub
    Public Sub ViewSummary()
        Dim I As Integer
        Dim Itemcode() As String
        Dim heading() As String = {"REPORTS FOR RATE"}
        sqlstring = "SELECT * FROM VIEW_MRPRATE "
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
        If CHK_All.Checked = False Then
            sqlstring = sqlstring & " AND MODIFYDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' "
        Else
            sqlstring = sqlstring & " "
        End If
        sqlstring = sqlstring & " ORDER BY ITEMNAME,MODIFYDATE DESC"
        Call Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    End Sub
    Public Sub ViewSummary1()
        Dim I As Integer
        Dim Itemcode() As String
        Dim heading() As String = {"REPORTS FOR TARGET"}
        'sqlstring = " SELECT COMPANYCODE,COMPANYNAME,I.ITEMCODE,I.ITEMNAME,ISNULL(I.TARGETQTY,0) AS TARGET,ISNULL(SUM(G.QTY),0) AS CONSUM FROM INVENTORYITEMMASTER I LEFT OUTER JOIN GRN_DETAILS G ON  I.ITEMCODE= G.ITEMCODE  WHERE I.STORECODE = 'MNS' AND I.ITEMCODE= G.ITEMCODE AND ISNULL(VOIDITEM,'') <> 'Y' "
        sqlstring = " SELECT COMPANYCODE,COMPANYNAME,I.ITEMCODE,I.ITEMNAME,ISNULL(I.TARGETQTY,0) AS TARGET,ISNULL(SUM(G.QTY),0) AS CONSUM FROM INVENTORYITEMMASTER I LEFT OUTER JOIN GRN_DETAILS G ON  I.ITEMCODE= G.ITEMCODE  "
        sqlstring = sqlstring & " AND GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' "
        If Chklist_Itemdetails.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " WHERE I.ITEMCODE IN ("
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

        'sqlstring = sqlstring & " AND GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' "
        sqlstring = sqlstring & " AND I.STORECODE = 'MNS'  AND ISNULL(VOIDITEM,'') <> 'Y' "
        sqlstring = sqlstring & " GROUP BY I.ITEMCODE,I.ITEMNAME,ISNULL(I.TARGETQTY,0),COMPANYCODE,COMPANYNAME ORDER BY COMPANYNAME,I.ITEMNAME"
        Call Reportdetails1(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    End Sub
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine(Chr(18))
            Filewrite.WriteLine("{0,50}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(15) & StrDup(98, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ITEM                                Current                          Updated                   ")
            Filewrite.WriteLine("DESCRIPTION                ------------------------    -------------------------------------------")
            Filewrite.WriteLine("                           MRP     PRATE     SRATE     DATE              MRP     PRATE    SRATE ")
            pagesize = pagesize + 3
            Filewrite.WriteLine(StrDup(98, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeader1(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine(Chr(18))
            Filewrite.WriteLine("{0,50}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(15) & StrDup(98, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-10}{1,-25}{2,10}{3,15}{4,15}", "ITEMCODE", "ITEM NAME", "TARGET", "PURCH", "BALANCE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(98, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dbldocTotal, dblGroupTotal, dblGrandTotal As Double
        Dim ITEMCODE, DOCDETAILS, GROUPNAME As String
        Dim ITEMBOOL, DOCBOOL As Boolean
        Dim opval, issval, closeval, rcval, groupvalue As Double
        Dim Topval, Tissval, Tcloseval, Trcval, Tgroupvalue As Double
        Dim I, Count As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "STOCKSUMMARYREPORT")
            If gdataset.Tables("STOCKSUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("STOCKSUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(98, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If ITEMCODE <> Trim(CStr(dr("ITEMCODE"))) Then
                        Filewrite.Write("{0,20}{1,10}{2,10}{3,10}", Mid(Trim(CStr(dr("ITEMNAME"))), 1, 20), Mid(Format(Val(dr("MRP")), "0.00"), 1, 10), Mid(Format(Val(dr("PURCHASERATE")), "0.00"), 1, 10), Mid(Format(Val(dr("SALERATE")), "0.00"), 1, 10))
                        'Filewrite.Write("{0,20}{1,10}{2,10}{3,10}", Mid(Trim(CStr(dr("ITEMDESC"))), 1, 20), "", "", "")
                        ITEMCODE = Trim(CStr(dr("ITEMCODE")))
                        Count = 0
                    Else
                        Count = Count + 1
                    End If
                    If Count = 0 Then
                        Filewrite.WriteLine("{0,5}{1,11}{2,10}{3,10}{4,10}", "", Mid(Format((dr("MODIFYDATE")), "dd-MMM-yyyy"), 1, 11), Mid(Format(Val(dr("MRP1")), "0.00"), 1, 10), Mid(Format(Val(dr("PURCHASERATE1")), "0.00"), 1, 10), Mid(Format(Val(dr("SALERATE1")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    Else
                        Filewrite.WriteLine("{0,20}{1,10}{2,10}{3,10}{4,5}{5,11}{6,10}{7,10}{8,10}", "", "", "", "", "", Mid(Format((dr("MODIFYDATE")), "dd-MMM-yyyy"), 1, 11), Mid(Format(Val(dr("MRP1")), "0.00"), 1, 10), Mid(Format(Val(dr("PURCHASERATE1")), "0.00"), 1, 10), Mid(Format(Val(dr("SALERATE1")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next dr
                Filewrite.WriteLine()
                Filewrite.WriteLine(StrDup(98, "="))
                pagesize = pagesize + 1
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
    Public Function Reportdetails1(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dbldocTotal, dblGroupTotal, dblGrandTotal As Double
        Dim ITEMCODE, DOCDETAILS, GROUPNAME, Ccode As String
        Dim ITEMBOOL, DOCBOOL As Boolean
        Dim opval, issval, closeval, rcval, groupvalue As Double
        Dim Topval, Tissval, Tcloseval, Trcval, Tgroupvalue As Double
        Dim I, Count As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader1(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "STOCKSUMMARYREPORT")
            If gdataset.Tables("STOCKSUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("STOCKSUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(98, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader1(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Ccode <> dr("COMPANYCODE") Then
                        If Ccode <> "" Then
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                        End If
                        Filewrite.WriteLine(dr("COMPANYNAME"))
                        Filewrite.WriteLine(StrDup(Len(dr("COMPANYNAME")), "-"))
                        pagesize = pagesize + 2
                        Ccode = dr("COMPANYCODE")
                    End If
                    Filewrite.WriteLine("{0,-10}{1,-25}{2,10}{3,15}{4,15}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 8), Mid(Trim(CStr(dr("ITEMNAME"))), 1, 22), dr("TARGET"), dr("CONSUM"), dr("TARGET") - dr("CONSUM"))
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine()
                Filewrite.WriteLine(StrDup(98, "="))
                pagesize = pagesize + 1
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
End Class
