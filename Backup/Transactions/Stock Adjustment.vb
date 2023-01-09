Imports System.Data.SqlClient
Public Class Stock_Adjustment
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Docno As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Docnohelp As System.Windows.Forms.Button
    Friend WithEvents dtp_Docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Storelocation As System.Windows.Forms.Label
    Friend WithEvents lbl_Docdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Docno As System.Windows.Forms.Label
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents txt_Totalqty As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Totalamount As System.Windows.Forms.Label
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Stockinhand As System.Windows.Forms.Label
    Friend WithEvents lbl_Physicalstock As System.Windows.Forms.Label
    Friend WithEvents txt_Physicalstock As System.Windows.Forms.TextBox
    Friend WithEvents txt_Storecode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Help As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Stock_Adjustment))
        Me.txt_Docno = New System.Windows.Forms.TextBox
        Me.cmd_Docnohelp = New System.Windows.Forms.Button
        Me.dtp_Docdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Storelocation = New System.Windows.Forms.Label
        Me.lbl_Docdate = New System.Windows.Forms.Label
        Me.lbl_Docno = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.txt_Storecode = New System.Windows.Forms.TextBox
        Me.lbl_Stockinhand = New System.Windows.Forms.Label
        Me.txt_Totalqty = New System.Windows.Forms.TextBox
        Me.lbl_Totalamount = New System.Windows.Forms.Label
        Me.txt_Totalamount = New System.Windows.Forms.TextBox
        Me.lbl_Physicalstock = New System.Windows.Forms.Label
        Me.txt_Physicalstock = New System.Windows.Forms.TextBox
        Me.lbl_Help = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Docno
        '
        Me.txt_Docno.AccessibleDescription = resources.GetString("txt_Docno.AccessibleDescription")
        Me.txt_Docno.AccessibleName = resources.GetString("txt_Docno.AccessibleName")
        Me.txt_Docno.Anchor = CType(resources.GetObject("txt_Docno.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Docno.AutoSize = CType(resources.GetObject("txt_Docno.AutoSize"), Boolean)
        Me.txt_Docno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Docno.BackgroundImage = CType(resources.GetObject("txt_Docno.BackgroundImage"), System.Drawing.Image)
        Me.txt_Docno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Docno.Dock = CType(resources.GetObject("txt_Docno.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Docno.Enabled = CType(resources.GetObject("txt_Docno.Enabled"), Boolean)
        Me.txt_Docno.Font = CType(resources.GetObject("txt_Docno.Font"), System.Drawing.Font)
        Me.txt_Docno.ImeMode = CType(resources.GetObject("txt_Docno.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Docno.Location = CType(resources.GetObject("txt_Docno.Location"), System.Drawing.Point)
        Me.txt_Docno.MaxLength = CType(resources.GetObject("txt_Docno.MaxLength"), Integer)
        Me.txt_Docno.Multiline = CType(resources.GetObject("txt_Docno.Multiline"), Boolean)
        Me.txt_Docno.Name = "txt_Docno"
        Me.txt_Docno.PasswordChar = CType(resources.GetObject("txt_Docno.PasswordChar"), Char)
        Me.txt_Docno.RightToLeft = CType(resources.GetObject("txt_Docno.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Docno.ScrollBars = CType(resources.GetObject("txt_Docno.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Docno.Size = CType(resources.GetObject("txt_Docno.Size"), System.Drawing.Size)
        Me.txt_Docno.TabIndex = CType(resources.GetObject("txt_Docno.TabIndex"), Integer)
        Me.txt_Docno.Text = resources.GetString("txt_Docno.Text")
        Me.txt_Docno.TextAlign = CType(resources.GetObject("txt_Docno.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Docno.Visible = CType(resources.GetObject("txt_Docno.Visible"), Boolean)
        Me.txt_Docno.WordWrap = CType(resources.GetObject("txt_Docno.WordWrap"), Boolean)
        '
        'cmd_Docnohelp
        '
        Me.cmd_Docnohelp.AccessibleDescription = resources.GetString("cmd_Docnohelp.AccessibleDescription")
        Me.cmd_Docnohelp.AccessibleName = resources.GetString("cmd_Docnohelp.AccessibleName")
        Me.cmd_Docnohelp.Anchor = CType(resources.GetObject("cmd_Docnohelp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmd_Docnohelp.BackgroundImage = CType(resources.GetObject("cmd_Docnohelp.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Docnohelp.Dock = CType(resources.GetObject("cmd_Docnohelp.Dock"), System.Windows.Forms.DockStyle)
        Me.cmd_Docnohelp.Enabled = CType(resources.GetObject("cmd_Docnohelp.Enabled"), Boolean)
        Me.cmd_Docnohelp.FlatStyle = CType(resources.GetObject("cmd_Docnohelp.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmd_Docnohelp.Font = CType(resources.GetObject("cmd_Docnohelp.Font"), System.Drawing.Font)
        Me.cmd_Docnohelp.Image = CType(resources.GetObject("cmd_Docnohelp.Image"), System.Drawing.Image)
        Me.cmd_Docnohelp.ImageAlign = CType(resources.GetObject("cmd_Docnohelp.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmd_Docnohelp.ImageIndex = CType(resources.GetObject("cmd_Docnohelp.ImageIndex"), Integer)
        Me.cmd_Docnohelp.ImeMode = CType(resources.GetObject("cmd_Docnohelp.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmd_Docnohelp.Location = CType(resources.GetObject("cmd_Docnohelp.Location"), System.Drawing.Point)
        Me.cmd_Docnohelp.Name = "cmd_Docnohelp"
        Me.cmd_Docnohelp.RightToLeft = CType(resources.GetObject("cmd_Docnohelp.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmd_Docnohelp.Size = CType(resources.GetObject("cmd_Docnohelp.Size"), System.Drawing.Size)
        Me.cmd_Docnohelp.TabIndex = CType(resources.GetObject("cmd_Docnohelp.TabIndex"), Integer)
        Me.cmd_Docnohelp.Text = resources.GetString("cmd_Docnohelp.Text")
        Me.cmd_Docnohelp.TextAlign = CType(resources.GetObject("cmd_Docnohelp.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmd_Docnohelp.Visible = CType(resources.GetObject("cmd_Docnohelp.Visible"), Boolean)
        '
        'dtp_Docdate
        '
        Me.dtp_Docdate.AccessibleDescription = resources.GetString("dtp_Docdate.AccessibleDescription")
        Me.dtp_Docdate.AccessibleName = resources.GetString("dtp_Docdate.AccessibleName")
        Me.dtp_Docdate.Anchor = CType(resources.GetObject("dtp_Docdate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dtp_Docdate.BackgroundImage = CType(resources.GetObject("dtp_Docdate.BackgroundImage"), System.Drawing.Image)
        Me.dtp_Docdate.CalendarFont = CType(resources.GetObject("dtp_Docdate.CalendarFont"), System.Drawing.Font)
        Me.dtp_Docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Docdate.Dock = CType(resources.GetObject("dtp_Docdate.Dock"), System.Windows.Forms.DockStyle)
        Me.dtp_Docdate.DropDownAlign = CType(resources.GetObject("dtp_Docdate.DropDownAlign"), System.Windows.Forms.LeftRightAlignment)
        Me.dtp_Docdate.Enabled = CType(resources.GetObject("dtp_Docdate.Enabled"), Boolean)
        Me.dtp_Docdate.Font = CType(resources.GetObject("dtp_Docdate.Font"), System.Drawing.Font)
        Me.dtp_Docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Docdate.ImeMode = CType(resources.GetObject("dtp_Docdate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dtp_Docdate.Location = CType(resources.GetObject("dtp_Docdate.Location"), System.Drawing.Point)
        Me.dtp_Docdate.Name = "dtp_Docdate"
        Me.dtp_Docdate.RightToLeft = CType(resources.GetObject("dtp_Docdate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dtp_Docdate.Size = CType(resources.GetObject("dtp_Docdate.Size"), System.Drawing.Size)
        Me.dtp_Docdate.TabIndex = CType(resources.GetObject("dtp_Docdate.TabIndex"), Integer)
        Me.dtp_Docdate.Visible = CType(resources.GetObject("dtp_Docdate.Visible"), Boolean)
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AccessibleDescription = resources.GetString("lbl_Heading.AccessibleDescription")
        Me.lbl_Heading.AccessibleName = resources.GetString("lbl_Heading.AccessibleName")
        Me.lbl_Heading.Anchor = CType(resources.GetObject("lbl_Heading.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Heading.AutoSize = CType(resources.GetObject("lbl_Heading.AutoSize"), Boolean)
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Dock = CType(resources.GetObject("lbl_Heading.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Heading.Enabled = CType(resources.GetObject("lbl_Heading.Enabled"), Boolean)
        Me.lbl_Heading.Font = CType(resources.GetObject("lbl_Heading.Font"), System.Drawing.Font)
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Image = CType(resources.GetObject("lbl_Heading.Image"), System.Drawing.Image)
        Me.lbl_Heading.ImageAlign = CType(resources.GetObject("lbl_Heading.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Heading.ImageIndex = CType(resources.GetObject("lbl_Heading.ImageIndex"), Integer)
        Me.lbl_Heading.ImeMode = CType(resources.GetObject("lbl_Heading.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Heading.Location = CType(resources.GetObject("lbl_Heading.Location"), System.Drawing.Point)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.RightToLeft = CType(resources.GetObject("lbl_Heading.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Heading.Size = CType(resources.GetObject("lbl_Heading.Size"), System.Drawing.Size)
        Me.lbl_Heading.TabIndex = CType(resources.GetObject("lbl_Heading.TabIndex"), Integer)
        Me.lbl_Heading.Text = resources.GetString("lbl_Heading.Text")
        Me.lbl_Heading.TextAlign = CType(resources.GetObject("lbl_Heading.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Heading.Visible = CType(resources.GetObject("lbl_Heading.Visible"), Boolean)
        '
        'lbl_Storelocation
        '
        Me.lbl_Storelocation.AccessibleDescription = resources.GetString("lbl_Storelocation.AccessibleDescription")
        Me.lbl_Storelocation.AccessibleName = resources.GetString("lbl_Storelocation.AccessibleName")
        Me.lbl_Storelocation.Anchor = CType(resources.GetObject("lbl_Storelocation.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Storelocation.AutoSize = CType(resources.GetObject("lbl_Storelocation.AutoSize"), Boolean)
        Me.lbl_Storelocation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Storelocation.Dock = CType(resources.GetObject("lbl_Storelocation.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Storelocation.Enabled = CType(resources.GetObject("lbl_Storelocation.Enabled"), Boolean)
        Me.lbl_Storelocation.Font = CType(resources.GetObject("lbl_Storelocation.Font"), System.Drawing.Font)
        Me.lbl_Storelocation.Image = CType(resources.GetObject("lbl_Storelocation.Image"), System.Drawing.Image)
        Me.lbl_Storelocation.ImageAlign = CType(resources.GetObject("lbl_Storelocation.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Storelocation.ImageIndex = CType(resources.GetObject("lbl_Storelocation.ImageIndex"), Integer)
        Me.lbl_Storelocation.ImeMode = CType(resources.GetObject("lbl_Storelocation.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Storelocation.Location = CType(resources.GetObject("lbl_Storelocation.Location"), System.Drawing.Point)
        Me.lbl_Storelocation.Name = "lbl_Storelocation"
        Me.lbl_Storelocation.RightToLeft = CType(resources.GetObject("lbl_Storelocation.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Storelocation.Size = CType(resources.GetObject("lbl_Storelocation.Size"), System.Drawing.Size)
        Me.lbl_Storelocation.TabIndex = CType(resources.GetObject("lbl_Storelocation.TabIndex"), Integer)
        Me.lbl_Storelocation.Text = resources.GetString("lbl_Storelocation.Text")
        Me.lbl_Storelocation.TextAlign = CType(resources.GetObject("lbl_Storelocation.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Storelocation.Visible = CType(resources.GetObject("lbl_Storelocation.Visible"), Boolean)
        '
        'lbl_Docdate
        '
        Me.lbl_Docdate.AccessibleDescription = resources.GetString("lbl_Docdate.AccessibleDescription")
        Me.lbl_Docdate.AccessibleName = resources.GetString("lbl_Docdate.AccessibleName")
        Me.lbl_Docdate.Anchor = CType(resources.GetObject("lbl_Docdate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Docdate.AutoSize = CType(resources.GetObject("lbl_Docdate.AutoSize"), Boolean)
        Me.lbl_Docdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docdate.Dock = CType(resources.GetObject("lbl_Docdate.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Docdate.Enabled = CType(resources.GetObject("lbl_Docdate.Enabled"), Boolean)
        Me.lbl_Docdate.Font = CType(resources.GetObject("lbl_Docdate.Font"), System.Drawing.Font)
        Me.lbl_Docdate.Image = CType(resources.GetObject("lbl_Docdate.Image"), System.Drawing.Image)
        Me.lbl_Docdate.ImageAlign = CType(resources.GetObject("lbl_Docdate.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Docdate.ImageIndex = CType(resources.GetObject("lbl_Docdate.ImageIndex"), Integer)
        Me.lbl_Docdate.ImeMode = CType(resources.GetObject("lbl_Docdate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Docdate.Location = CType(resources.GetObject("lbl_Docdate.Location"), System.Drawing.Point)
        Me.lbl_Docdate.Name = "lbl_Docdate"
        Me.lbl_Docdate.RightToLeft = CType(resources.GetObject("lbl_Docdate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Docdate.Size = CType(resources.GetObject("lbl_Docdate.Size"), System.Drawing.Size)
        Me.lbl_Docdate.TabIndex = CType(resources.GetObject("lbl_Docdate.TabIndex"), Integer)
        Me.lbl_Docdate.Text = resources.GetString("lbl_Docdate.Text")
        Me.lbl_Docdate.TextAlign = CType(resources.GetObject("lbl_Docdate.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Docdate.Visible = CType(resources.GetObject("lbl_Docdate.Visible"), Boolean)
        '
        'lbl_Docno
        '
        Me.lbl_Docno.AccessibleDescription = resources.GetString("lbl_Docno.AccessibleDescription")
        Me.lbl_Docno.AccessibleName = resources.GetString("lbl_Docno.AccessibleName")
        Me.lbl_Docno.Anchor = CType(resources.GetObject("lbl_Docno.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Docno.AutoSize = CType(resources.GetObject("lbl_Docno.AutoSize"), Boolean)
        Me.lbl_Docno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docno.Dock = CType(resources.GetObject("lbl_Docno.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Docno.Enabled = CType(resources.GetObject("lbl_Docno.Enabled"), Boolean)
        Me.lbl_Docno.Font = CType(resources.GetObject("lbl_Docno.Font"), System.Drawing.Font)
        Me.lbl_Docno.Image = CType(resources.GetObject("lbl_Docno.Image"), System.Drawing.Image)
        Me.lbl_Docno.ImageAlign = CType(resources.GetObject("lbl_Docno.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Docno.ImageIndex = CType(resources.GetObject("lbl_Docno.ImageIndex"), Integer)
        Me.lbl_Docno.ImeMode = CType(resources.GetObject("lbl_Docno.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Docno.Location = CType(resources.GetObject("lbl_Docno.Location"), System.Drawing.Point)
        Me.lbl_Docno.Name = "lbl_Docno"
        Me.lbl_Docno.RightToLeft = CType(resources.GetObject("lbl_Docno.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Docno.Size = CType(resources.GetObject("lbl_Docno.Size"), System.Drawing.Size)
        Me.lbl_Docno.TabIndex = CType(resources.GetObject("lbl_Docno.TabIndex"), Integer)
        Me.lbl_Docno.Text = resources.GetString("lbl_Docno.Text")
        Me.lbl_Docno.TextAlign = CType(resources.GetObject("lbl_Docno.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Docno.Visible = CType(resources.GetObject("lbl_Docno.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.lbl_Docdate)
        Me.GroupBox1.Controls.Add(Me.lbl_Docno)
        Me.GroupBox1.Controls.Add(Me.lbl_Storelocation)
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.AccessibleDescription = resources.GetString("cbo_Storelocation.AccessibleDescription")
        Me.cbo_Storelocation.AccessibleName = resources.GetString("cbo_Storelocation.AccessibleName")
        Me.cbo_Storelocation.Anchor = CType(resources.GetObject("cbo_Storelocation.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cbo_Storelocation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Storelocation.BackgroundImage = CType(resources.GetObject("cbo_Storelocation.BackgroundImage"), System.Drawing.Image)
        Me.cbo_Storelocation.Dock = CType(resources.GetObject("cbo_Storelocation.Dock"), System.Windows.Forms.DockStyle)
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Enabled = CType(resources.GetObject("cbo_Storelocation.Enabled"), Boolean)
        Me.cbo_Storelocation.Font = CType(resources.GetObject("cbo_Storelocation.Font"), System.Drawing.Font)
        Me.cbo_Storelocation.ImeMode = CType(resources.GetObject("cbo_Storelocation.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cbo_Storelocation.IntegralHeight = CType(resources.GetObject("cbo_Storelocation.IntegralHeight"), Boolean)
        Me.cbo_Storelocation.ItemHeight = CType(resources.GetObject("cbo_Storelocation.ItemHeight"), Integer)
        Me.cbo_Storelocation.Location = CType(resources.GetObject("cbo_Storelocation.Location"), System.Drawing.Point)
        Me.cbo_Storelocation.MaxDropDownItems = CType(resources.GetObject("cbo_Storelocation.MaxDropDownItems"), Integer)
        Me.cbo_Storelocation.MaxLength = CType(resources.GetObject("cbo_Storelocation.MaxLength"), Integer)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.RightToLeft = CType(resources.GetObject("cbo_Storelocation.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cbo_Storelocation.Size = CType(resources.GetObject("cbo_Storelocation.Size"), System.Drawing.Size)
        Me.cbo_Storelocation.TabIndex = CType(resources.GetObject("cbo_Storelocation.TabIndex"), Integer)
        Me.cbo_Storelocation.Text = resources.GetString("cbo_Storelocation.Text")
        Me.cbo_Storelocation.Visible = CType(resources.GetObject("cbo_Storelocation.Visible"), Boolean)
        '
        'ssgrid
        '
        Me.ssgrid.AccessibleDescription = resources.GetString("ssgrid.AccessibleDescription")
        Me.ssgrid.AccessibleName = resources.GetString("ssgrid.AccessibleName")
        Me.ssgrid.Anchor = CType(resources.GetObject("ssgrid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ssgrid.BackgroundImage = CType(resources.GetObject("ssgrid.BackgroundImage"), System.Drawing.Image)
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Dock = CType(resources.GetObject("ssgrid.Dock"), System.Windows.Forms.DockStyle)
        Me.ssgrid.ImeMode = CType(resources.GetObject("ssgrid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ssgrid.Location = CType(resources.GetObject("ssgrid.Location"), System.Drawing.Point)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.RightToLeft = CType(resources.GetObject("ssgrid.RightToLeft"), Boolean)
        Me.ssgrid.Size = CType(resources.GetObject("ssgrid.Size"), System.Drawing.Size)
        Me.ssgrid.TabIndex = CType(resources.GetObject("ssgrid.TabIndex"), Integer)
        Me.ssgrid.Visible = CType(resources.GetObject("ssgrid.Visible"), Boolean)
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.AccessibleDescription = resources.GetString("Cmd_Clear.AccessibleDescription")
        Me.Cmd_Clear.AccessibleName = resources.GetString("Cmd_Clear.AccessibleName")
        Me.Cmd_Clear.Anchor = CType(resources.GetObject("Cmd_Clear.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.BackgroundImage = CType(resources.GetObject("Cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Clear.Dock = CType(resources.GetObject("Cmd_Clear.Dock"), System.Windows.Forms.DockStyle)
        Me.Cmd_Clear.Enabled = CType(resources.GetObject("Cmd_Clear.Enabled"), Boolean)
        Me.Cmd_Clear.FlatStyle = CType(resources.GetObject("Cmd_Clear.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Cmd_Clear.Font = CType(resources.GetObject("Cmd_Clear.Font"), System.Drawing.Font)
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.ImageAlign = CType(resources.GetObject("Cmd_Clear.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Clear.ImageIndex = CType(resources.GetObject("Cmd_Clear.ImageIndex"), Integer)
        Me.Cmd_Clear.ImeMode = CType(resources.GetObject("Cmd_Clear.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cmd_Clear.Location = CType(resources.GetObject("Cmd_Clear.Location"), System.Drawing.Point)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.RightToLeft = CType(resources.GetObject("Cmd_Clear.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cmd_Clear.Size = CType(resources.GetObject("Cmd_Clear.Size"), System.Drawing.Size)
        Me.Cmd_Clear.TabIndex = CType(resources.GetObject("Cmd_Clear.TabIndex"), Integer)
        Me.Cmd_Clear.Text = resources.GetString("Cmd_Clear.Text")
        Me.Cmd_Clear.TextAlign = CType(resources.GetObject("Cmd_Clear.TextAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Clear.Visible = CType(resources.GetObject("Cmd_Clear.Visible"), Boolean)
        '
        'Cmd_View
        '
        Me.Cmd_View.AccessibleDescription = resources.GetString("Cmd_View.AccessibleDescription")
        Me.Cmd_View.AccessibleName = resources.GetString("Cmd_View.AccessibleName")
        Me.Cmd_View.Anchor = CType(resources.GetObject("Cmd_View.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.BackgroundImage = CType(resources.GetObject("Cmd_View.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_View.Dock = CType(resources.GetObject("Cmd_View.Dock"), System.Windows.Forms.DockStyle)
        Me.Cmd_View.Enabled = CType(resources.GetObject("Cmd_View.Enabled"), Boolean)
        Me.Cmd_View.FlatStyle = CType(resources.GetObject("Cmd_View.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Cmd_View.Font = CType(resources.GetObject("Cmd_View.Font"), System.Drawing.Font)
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.ImageAlign = CType(resources.GetObject("Cmd_View.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_View.ImageIndex = CType(resources.GetObject("Cmd_View.ImageIndex"), Integer)
        Me.Cmd_View.ImeMode = CType(resources.GetObject("Cmd_View.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cmd_View.Location = CType(resources.GetObject("Cmd_View.Location"), System.Drawing.Point)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.RightToLeft = CType(resources.GetObject("Cmd_View.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cmd_View.Size = CType(resources.GetObject("Cmd_View.Size"), System.Drawing.Size)
        Me.Cmd_View.TabIndex = CType(resources.GetObject("Cmd_View.TabIndex"), Integer)
        Me.Cmd_View.Text = resources.GetString("Cmd_View.Text")
        Me.Cmd_View.TextAlign = CType(resources.GetObject("Cmd_View.TextAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_View.Visible = CType(resources.GetObject("Cmd_View.Visible"), Boolean)
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.AccessibleDescription = resources.GetString("Cmd_Freeze.AccessibleDescription")
        Me.Cmd_Freeze.AccessibleName = resources.GetString("Cmd_Freeze.AccessibleName")
        Me.Cmd_Freeze.Anchor = CType(resources.GetObject("Cmd_Freeze.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.BackgroundImage = CType(resources.GetObject("Cmd_Freeze.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Freeze.Dock = CType(resources.GetObject("Cmd_Freeze.Dock"), System.Windows.Forms.DockStyle)
        Me.Cmd_Freeze.Enabled = CType(resources.GetObject("Cmd_Freeze.Enabled"), Boolean)
        Me.Cmd_Freeze.FlatStyle = CType(resources.GetObject("Cmd_Freeze.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Cmd_Freeze.Font = CType(resources.GetObject("Cmd_Freeze.Font"), System.Drawing.Font)
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.ImageAlign = CType(resources.GetObject("Cmd_Freeze.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Freeze.ImageIndex = CType(resources.GetObject("Cmd_Freeze.ImageIndex"), Integer)
        Me.Cmd_Freeze.ImeMode = CType(resources.GetObject("Cmd_Freeze.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cmd_Freeze.Location = CType(resources.GetObject("Cmd_Freeze.Location"), System.Drawing.Point)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.RightToLeft = CType(resources.GetObject("Cmd_Freeze.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cmd_Freeze.Size = CType(resources.GetObject("Cmd_Freeze.Size"), System.Drawing.Size)
        Me.Cmd_Freeze.TabIndex = CType(resources.GetObject("Cmd_Freeze.TabIndex"), Integer)
        Me.Cmd_Freeze.Text = resources.GetString("Cmd_Freeze.Text")
        Me.Cmd_Freeze.TextAlign = CType(resources.GetObject("Cmd_Freeze.TextAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Freeze.Visible = CType(resources.GetObject("Cmd_Freeze.Visible"), Boolean)
        '
        'Cmd_Add
        '
        Me.Cmd_Add.AccessibleDescription = resources.GetString("Cmd_Add.AccessibleDescription")
        Me.Cmd_Add.AccessibleName = resources.GetString("Cmd_Add.AccessibleName")
        Me.Cmd_Add.Anchor = CType(resources.GetObject("Cmd_Add.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.BackgroundImage = CType(resources.GetObject("Cmd_Add.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Add.Dock = CType(resources.GetObject("Cmd_Add.Dock"), System.Windows.Forms.DockStyle)
        Me.Cmd_Add.Enabled = CType(resources.GetObject("Cmd_Add.Enabled"), Boolean)
        Me.Cmd_Add.FlatStyle = CType(resources.GetObject("Cmd_Add.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Cmd_Add.Font = CType(resources.GetObject("Cmd_Add.Font"), System.Drawing.Font)
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.ImageAlign = CType(resources.GetObject("Cmd_Add.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Add.ImageIndex = CType(resources.GetObject("Cmd_Add.ImageIndex"), Integer)
        Me.Cmd_Add.ImeMode = CType(resources.GetObject("Cmd_Add.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cmd_Add.Location = CType(resources.GetObject("Cmd_Add.Location"), System.Drawing.Point)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.RightToLeft = CType(resources.GetObject("Cmd_Add.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cmd_Add.Size = CType(resources.GetObject("Cmd_Add.Size"), System.Drawing.Size)
        Me.Cmd_Add.TabIndex = CType(resources.GetObject("Cmd_Add.TabIndex"), Integer)
        Me.Cmd_Add.Text = resources.GetString("Cmd_Add.Text")
        Me.Cmd_Add.TextAlign = CType(resources.GetObject("Cmd_Add.TextAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Add.Visible = CType(resources.GetObject("Cmd_Add.Visible"), Boolean)
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.AccessibleDescription = resources.GetString("Cmd_Exit.AccessibleDescription")
        Me.Cmd_Exit.AccessibleName = resources.GetString("Cmd_Exit.AccessibleName")
        Me.Cmd_Exit.Anchor = CType(resources.GetObject("Cmd_Exit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.BackgroundImage = CType(resources.GetObject("Cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Exit.Dock = CType(resources.GetObject("Cmd_Exit.Dock"), System.Windows.Forms.DockStyle)
        Me.Cmd_Exit.Enabled = CType(resources.GetObject("Cmd_Exit.Enabled"), Boolean)
        Me.Cmd_Exit.FlatStyle = CType(resources.GetObject("Cmd_Exit.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Cmd_Exit.Font = CType(resources.GetObject("Cmd_Exit.Font"), System.Drawing.Font)
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.ImageAlign = CType(resources.GetObject("Cmd_Exit.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Exit.ImageIndex = CType(resources.GetObject("Cmd_Exit.ImageIndex"), Integer)
        Me.Cmd_Exit.ImeMode = CType(resources.GetObject("Cmd_Exit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cmd_Exit.Location = CType(resources.GetObject("Cmd_Exit.Location"), System.Drawing.Point)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = CType(resources.GetObject("Cmd_Exit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cmd_Exit.Size = CType(resources.GetObject("Cmd_Exit.Size"), System.Drawing.Size)
        Me.Cmd_Exit.TabIndex = CType(resources.GetObject("Cmd_Exit.TabIndex"), Integer)
        Me.Cmd_Exit.Text = resources.GetString("Cmd_Exit.Text")
        Me.Cmd_Exit.TextAlign = CType(resources.GetObject("Cmd_Exit.TextAlign"), System.Drawing.ContentAlignment)
        Me.Cmd_Exit.Visible = CType(resources.GetObject("Cmd_Exit.Visible"), Boolean)
        '
        'frmbut
        '
        Me.frmbut.AccessibleDescription = resources.GetString("frmbut.AccessibleDescription")
        Me.frmbut.AccessibleName = resources.GetString("frmbut.AccessibleName")
        Me.frmbut.Anchor = CType(resources.GetObject("frmbut.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.BackgroundImage = CType(resources.GetObject("frmbut.BackgroundImage"), System.Drawing.Image)
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Dock = CType(resources.GetObject("frmbut.Dock"), System.Windows.Forms.DockStyle)
        Me.frmbut.Enabled = CType(resources.GetObject("frmbut.Enabled"), Boolean)
        Me.frmbut.Font = CType(resources.GetObject("frmbut.Font"), System.Drawing.Font)
        Me.frmbut.ImeMode = CType(resources.GetObject("frmbut.ImeMode"), System.Windows.Forms.ImeMode)
        Me.frmbut.Location = CType(resources.GetObject("frmbut.Location"), System.Drawing.Point)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.RightToLeft = CType(resources.GetObject("frmbut.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.frmbut.Size = CType(resources.GetObject("frmbut.Size"), System.Drawing.Size)
        Me.frmbut.TabIndex = CType(resources.GetObject("frmbut.TabIndex"), Integer)
        Me.frmbut.TabStop = False
        Me.frmbut.Text = resources.GetString("frmbut.Text")
        Me.frmbut.Visible = CType(resources.GetObject("frmbut.Visible"), Boolean)
        '
        'cmd_Print
        '
        Me.cmd_Print.AccessibleDescription = resources.GetString("cmd_Print.AccessibleDescription")
        Me.cmd_Print.AccessibleName = resources.GetString("cmd_Print.AccessibleName")
        Me.cmd_Print.Anchor = CType(resources.GetObject("cmd_Print.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Print.BackgroundImage = CType(resources.GetObject("cmd_Print.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Print.Dock = CType(resources.GetObject("cmd_Print.Dock"), System.Windows.Forms.DockStyle)
        Me.cmd_Print.Enabled = CType(resources.GetObject("cmd_Print.Enabled"), Boolean)
        Me.cmd_Print.FlatStyle = CType(resources.GetObject("cmd_Print.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmd_Print.Font = CType(resources.GetObject("cmd_Print.Font"), System.Drawing.Font)
        Me.cmd_Print.ForeColor = System.Drawing.Color.White
        Me.cmd_Print.Image = CType(resources.GetObject("cmd_Print.Image"), System.Drawing.Image)
        Me.cmd_Print.ImageAlign = CType(resources.GetObject("cmd_Print.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmd_Print.ImageIndex = CType(resources.GetObject("cmd_Print.ImageIndex"), Integer)
        Me.cmd_Print.ImeMode = CType(resources.GetObject("cmd_Print.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmd_Print.Location = CType(resources.GetObject("cmd_Print.Location"), System.Drawing.Point)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.RightToLeft = CType(resources.GetObject("cmd_Print.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmd_Print.Size = CType(resources.GetObject("cmd_Print.Size"), System.Drawing.Size)
        Me.cmd_Print.TabIndex = CType(resources.GetObject("cmd_Print.TabIndex"), Integer)
        Me.cmd_Print.Text = resources.GetString("cmd_Print.Text")
        Me.cmd_Print.TextAlign = CType(resources.GetObject("cmd_Print.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmd_Print.Visible = CType(resources.GetObject("cmd_Print.Visible"), Boolean)
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AccessibleDescription = resources.GetString("lbl_Freeze.AccessibleDescription")
        Me.lbl_Freeze.AccessibleName = resources.GetString("lbl_Freeze.AccessibleName")
        Me.lbl_Freeze.Anchor = CType(resources.GetObject("lbl_Freeze.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Freeze.AutoSize = CType(resources.GetObject("lbl_Freeze.AutoSize"), Boolean)
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Dock = CType(resources.GetObject("lbl_Freeze.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Freeze.Enabled = CType(resources.GetObject("lbl_Freeze.Enabled"), Boolean)
        Me.lbl_Freeze.Font = CType(resources.GetObject("lbl_Freeze.Font"), System.Drawing.Font)
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Image = CType(resources.GetObject("lbl_Freeze.Image"), System.Drawing.Image)
        Me.lbl_Freeze.ImageAlign = CType(resources.GetObject("lbl_Freeze.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Freeze.ImageIndex = CType(resources.GetObject("lbl_Freeze.ImageIndex"), Integer)
        Me.lbl_Freeze.ImeMode = CType(resources.GetObject("lbl_Freeze.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Freeze.Location = CType(resources.GetObject("lbl_Freeze.Location"), System.Drawing.Point)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.RightToLeft = CType(resources.GetObject("lbl_Freeze.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Freeze.Size = CType(resources.GetObject("lbl_Freeze.Size"), System.Drawing.Size)
        Me.lbl_Freeze.TabIndex = CType(resources.GetObject("lbl_Freeze.TabIndex"), Integer)
        Me.lbl_Freeze.Text = resources.GetString("lbl_Freeze.Text")
        Me.lbl_Freeze.TextAlign = CType(resources.GetObject("lbl_Freeze.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Freeze.Visible = CType(resources.GetObject("lbl_Freeze.Visible"), Boolean)
        '
        'txt_Remarks
        '
        Me.txt_Remarks.AccessibleDescription = resources.GetString("txt_Remarks.AccessibleDescription")
        Me.txt_Remarks.AccessibleName = resources.GetString("txt_Remarks.AccessibleName")
        Me.txt_Remarks.Anchor = CType(resources.GetObject("txt_Remarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.AutoSize = CType(resources.GetObject("txt_Remarks.AutoSize"), Boolean)
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.BackgroundImage = CType(resources.GetObject("txt_Remarks.BackgroundImage"), System.Drawing.Image)
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Dock = CType(resources.GetObject("txt_Remarks.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Remarks.Enabled = CType(resources.GetObject("txt_Remarks.Enabled"), Boolean)
        Me.txt_Remarks.Font = CType(resources.GetObject("txt_Remarks.Font"), System.Drawing.Font)
        Me.txt_Remarks.ImeMode = CType(resources.GetObject("txt_Remarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Remarks.Location = CType(resources.GetObject("txt_Remarks.Location"), System.Drawing.Point)
        Me.txt_Remarks.MaxLength = CType(resources.GetObject("txt_Remarks.MaxLength"), Integer)
        Me.txt_Remarks.Multiline = CType(resources.GetObject("txt_Remarks.Multiline"), Boolean)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.PasswordChar = CType(resources.GetObject("txt_Remarks.PasswordChar"), Char)
        Me.txt_Remarks.RightToLeft = CType(resources.GetObject("txt_Remarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Remarks.ScrollBars = CType(resources.GetObject("txt_Remarks.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Remarks.Size = CType(resources.GetObject("txt_Remarks.Size"), System.Drawing.Size)
        Me.txt_Remarks.TabIndex = CType(resources.GetObject("txt_Remarks.TabIndex"), Integer)
        Me.txt_Remarks.Text = resources.GetString("txt_Remarks.Text")
        Me.txt_Remarks.TextAlign = CType(resources.GetObject("txt_Remarks.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Remarks.Visible = CType(resources.GetObject("txt_Remarks.Visible"), Boolean)
        Me.txt_Remarks.WordWrap = CType(resources.GetObject("txt_Remarks.WordWrap"), Boolean)
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AccessibleDescription = resources.GetString("lbl_Remarks.AccessibleDescription")
        Me.lbl_Remarks.AccessibleName = resources.GetString("lbl_Remarks.AccessibleName")
        Me.lbl_Remarks.Anchor = CType(resources.GetObject("lbl_Remarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Remarks.AutoSize = CType(resources.GetObject("lbl_Remarks.AutoSize"), Boolean)
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Dock = CType(resources.GetObject("lbl_Remarks.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Remarks.Enabled = CType(resources.GetObject("lbl_Remarks.Enabled"), Boolean)
        Me.lbl_Remarks.Font = CType(resources.GetObject("lbl_Remarks.Font"), System.Drawing.Font)
        Me.lbl_Remarks.Image = CType(resources.GetObject("lbl_Remarks.Image"), System.Drawing.Image)
        Me.lbl_Remarks.ImageAlign = CType(resources.GetObject("lbl_Remarks.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Remarks.ImageIndex = CType(resources.GetObject("lbl_Remarks.ImageIndex"), Integer)
        Me.lbl_Remarks.ImeMode = CType(resources.GetObject("lbl_Remarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Remarks.Location = CType(resources.GetObject("lbl_Remarks.Location"), System.Drawing.Point)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.RightToLeft = CType(resources.GetObject("lbl_Remarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Remarks.Size = CType(resources.GetObject("lbl_Remarks.Size"), System.Drawing.Size)
        Me.lbl_Remarks.TabIndex = CType(resources.GetObject("lbl_Remarks.TabIndex"), Integer)
        Me.lbl_Remarks.Text = resources.GetString("lbl_Remarks.Text")
        Me.lbl_Remarks.TextAlign = CType(resources.GetObject("lbl_Remarks.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Remarks.Visible = CType(resources.GetObject("lbl_Remarks.Visible"), Boolean)
        '
        'txt_Storecode
        '
        Me.txt_Storecode.AccessibleDescription = resources.GetString("txt_Storecode.AccessibleDescription")
        Me.txt_Storecode.AccessibleName = resources.GetString("txt_Storecode.AccessibleName")
        Me.txt_Storecode.Anchor = CType(resources.GetObject("txt_Storecode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Storecode.AutoSize = CType(resources.GetObject("txt_Storecode.AutoSize"), Boolean)
        Me.txt_Storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Storecode.BackgroundImage = CType(resources.GetObject("txt_Storecode.BackgroundImage"), System.Drawing.Image)
        Me.txt_Storecode.Dock = CType(resources.GetObject("txt_Storecode.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Storecode.Enabled = CType(resources.GetObject("txt_Storecode.Enabled"), Boolean)
        Me.txt_Storecode.Font = CType(resources.GetObject("txt_Storecode.Font"), System.Drawing.Font)
        Me.txt_Storecode.ImeMode = CType(resources.GetObject("txt_Storecode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Storecode.Location = CType(resources.GetObject("txt_Storecode.Location"), System.Drawing.Point)
        Me.txt_Storecode.MaxLength = CType(resources.GetObject("txt_Storecode.MaxLength"), Integer)
        Me.txt_Storecode.Multiline = CType(resources.GetObject("txt_Storecode.Multiline"), Boolean)
        Me.txt_Storecode.Name = "txt_Storecode"
        Me.txt_Storecode.PasswordChar = CType(resources.GetObject("txt_Storecode.PasswordChar"), Char)
        Me.txt_Storecode.RightToLeft = CType(resources.GetObject("txt_Storecode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Storecode.ScrollBars = CType(resources.GetObject("txt_Storecode.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Storecode.Size = CType(resources.GetObject("txt_Storecode.Size"), System.Drawing.Size)
        Me.txt_Storecode.TabIndex = CType(resources.GetObject("txt_Storecode.TabIndex"), Integer)
        Me.txt_Storecode.Text = resources.GetString("txt_Storecode.Text")
        Me.txt_Storecode.TextAlign = CType(resources.GetObject("txt_Storecode.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Storecode.Visible = CType(resources.GetObject("txt_Storecode.Visible"), Boolean)
        Me.txt_Storecode.WordWrap = CType(resources.GetObject("txt_Storecode.WordWrap"), Boolean)
        '
        'lbl_Stockinhand
        '
        Me.lbl_Stockinhand.AccessibleDescription = resources.GetString("lbl_Stockinhand.AccessibleDescription")
        Me.lbl_Stockinhand.AccessibleName = resources.GetString("lbl_Stockinhand.AccessibleName")
        Me.lbl_Stockinhand.Anchor = CType(resources.GetObject("lbl_Stockinhand.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Stockinhand.AutoSize = CType(resources.GetObject("lbl_Stockinhand.AutoSize"), Boolean)
        Me.lbl_Stockinhand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stockinhand.Dock = CType(resources.GetObject("lbl_Stockinhand.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Stockinhand.Enabled = CType(resources.GetObject("lbl_Stockinhand.Enabled"), Boolean)
        Me.lbl_Stockinhand.Font = CType(resources.GetObject("lbl_Stockinhand.Font"), System.Drawing.Font)
        Me.lbl_Stockinhand.Image = CType(resources.GetObject("lbl_Stockinhand.Image"), System.Drawing.Image)
        Me.lbl_Stockinhand.ImageAlign = CType(resources.GetObject("lbl_Stockinhand.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Stockinhand.ImageIndex = CType(resources.GetObject("lbl_Stockinhand.ImageIndex"), Integer)
        Me.lbl_Stockinhand.ImeMode = CType(resources.GetObject("lbl_Stockinhand.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Stockinhand.Location = CType(resources.GetObject("lbl_Stockinhand.Location"), System.Drawing.Point)
        Me.lbl_Stockinhand.Name = "lbl_Stockinhand"
        Me.lbl_Stockinhand.RightToLeft = CType(resources.GetObject("lbl_Stockinhand.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Stockinhand.Size = CType(resources.GetObject("lbl_Stockinhand.Size"), System.Drawing.Size)
        Me.lbl_Stockinhand.TabIndex = CType(resources.GetObject("lbl_Stockinhand.TabIndex"), Integer)
        Me.lbl_Stockinhand.Text = resources.GetString("lbl_Stockinhand.Text")
        Me.lbl_Stockinhand.TextAlign = CType(resources.GetObject("lbl_Stockinhand.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Stockinhand.Visible = CType(resources.GetObject("lbl_Stockinhand.Visible"), Boolean)
        '
        'txt_Totalqty
        '
        Me.txt_Totalqty.AccessibleDescription = resources.GetString("txt_Totalqty.AccessibleDescription")
        Me.txt_Totalqty.AccessibleName = resources.GetString("txt_Totalqty.AccessibleName")
        Me.txt_Totalqty.Anchor = CType(resources.GetObject("txt_Totalqty.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Totalqty.AutoSize = CType(resources.GetObject("txt_Totalqty.AutoSize"), Boolean)
        Me.txt_Totalqty.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalqty.BackgroundImage = CType(resources.GetObject("txt_Totalqty.BackgroundImage"), System.Drawing.Image)
        Me.txt_Totalqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalqty.Dock = CType(resources.GetObject("txt_Totalqty.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Totalqty.Enabled = CType(resources.GetObject("txt_Totalqty.Enabled"), Boolean)
        Me.txt_Totalqty.Font = CType(resources.GetObject("txt_Totalqty.Font"), System.Drawing.Font)
        Me.txt_Totalqty.ImeMode = CType(resources.GetObject("txt_Totalqty.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Totalqty.Location = CType(resources.GetObject("txt_Totalqty.Location"), System.Drawing.Point)
        Me.txt_Totalqty.MaxLength = CType(resources.GetObject("txt_Totalqty.MaxLength"), Integer)
        Me.txt_Totalqty.Multiline = CType(resources.GetObject("txt_Totalqty.Multiline"), Boolean)
        Me.txt_Totalqty.Name = "txt_Totalqty"
        Me.txt_Totalqty.PasswordChar = CType(resources.GetObject("txt_Totalqty.PasswordChar"), Char)
        Me.txt_Totalqty.RightToLeft = CType(resources.GetObject("txt_Totalqty.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Totalqty.ScrollBars = CType(resources.GetObject("txt_Totalqty.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Totalqty.Size = CType(resources.GetObject("txt_Totalqty.Size"), System.Drawing.Size)
        Me.txt_Totalqty.TabIndex = CType(resources.GetObject("txt_Totalqty.TabIndex"), Integer)
        Me.txt_Totalqty.Text = resources.GetString("txt_Totalqty.Text")
        Me.txt_Totalqty.TextAlign = CType(resources.GetObject("txt_Totalqty.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Totalqty.Visible = CType(resources.GetObject("txt_Totalqty.Visible"), Boolean)
        Me.txt_Totalqty.WordWrap = CType(resources.GetObject("txt_Totalqty.WordWrap"), Boolean)
        '
        'lbl_Totalamount
        '
        Me.lbl_Totalamount.AccessibleDescription = resources.GetString("lbl_Totalamount.AccessibleDescription")
        Me.lbl_Totalamount.AccessibleName = resources.GetString("lbl_Totalamount.AccessibleName")
        Me.lbl_Totalamount.Anchor = CType(resources.GetObject("lbl_Totalamount.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Totalamount.AutoSize = CType(resources.GetObject("lbl_Totalamount.AutoSize"), Boolean)
        Me.lbl_Totalamount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalamount.Dock = CType(resources.GetObject("lbl_Totalamount.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Totalamount.Enabled = CType(resources.GetObject("lbl_Totalamount.Enabled"), Boolean)
        Me.lbl_Totalamount.Font = CType(resources.GetObject("lbl_Totalamount.Font"), System.Drawing.Font)
        Me.lbl_Totalamount.Image = CType(resources.GetObject("lbl_Totalamount.Image"), System.Drawing.Image)
        Me.lbl_Totalamount.ImageAlign = CType(resources.GetObject("lbl_Totalamount.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Totalamount.ImageIndex = CType(resources.GetObject("lbl_Totalamount.ImageIndex"), Integer)
        Me.lbl_Totalamount.ImeMode = CType(resources.GetObject("lbl_Totalamount.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Totalamount.Location = CType(resources.GetObject("lbl_Totalamount.Location"), System.Drawing.Point)
        Me.lbl_Totalamount.Name = "lbl_Totalamount"
        Me.lbl_Totalamount.RightToLeft = CType(resources.GetObject("lbl_Totalamount.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Totalamount.Size = CType(resources.GetObject("lbl_Totalamount.Size"), System.Drawing.Size)
        Me.lbl_Totalamount.TabIndex = CType(resources.GetObject("lbl_Totalamount.TabIndex"), Integer)
        Me.lbl_Totalamount.Text = resources.GetString("lbl_Totalamount.Text")
        Me.lbl_Totalamount.TextAlign = CType(resources.GetObject("lbl_Totalamount.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Totalamount.Visible = CType(resources.GetObject("lbl_Totalamount.Visible"), Boolean)
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.AccessibleDescription = resources.GetString("txt_Totalamount.AccessibleDescription")
        Me.txt_Totalamount.AccessibleName = resources.GetString("txt_Totalamount.AccessibleName")
        Me.txt_Totalamount.Anchor = CType(resources.GetObject("txt_Totalamount.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Totalamount.AutoSize = CType(resources.GetObject("txt_Totalamount.AutoSize"), Boolean)
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.BackgroundImage = CType(resources.GetObject("txt_Totalamount.BackgroundImage"), System.Drawing.Image)
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Dock = CType(resources.GetObject("txt_Totalamount.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Totalamount.Enabled = CType(resources.GetObject("txt_Totalamount.Enabled"), Boolean)
        Me.txt_Totalamount.Font = CType(resources.GetObject("txt_Totalamount.Font"), System.Drawing.Font)
        Me.txt_Totalamount.ImeMode = CType(resources.GetObject("txt_Totalamount.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Totalamount.Location = CType(resources.GetObject("txt_Totalamount.Location"), System.Drawing.Point)
        Me.txt_Totalamount.MaxLength = CType(resources.GetObject("txt_Totalamount.MaxLength"), Integer)
        Me.txt_Totalamount.Multiline = CType(resources.GetObject("txt_Totalamount.Multiline"), Boolean)
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.PasswordChar = CType(resources.GetObject("txt_Totalamount.PasswordChar"), Char)
        Me.txt_Totalamount.RightToLeft = CType(resources.GetObject("txt_Totalamount.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Totalamount.ScrollBars = CType(resources.GetObject("txt_Totalamount.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Totalamount.Size = CType(resources.GetObject("txt_Totalamount.Size"), System.Drawing.Size)
        Me.txt_Totalamount.TabIndex = CType(resources.GetObject("txt_Totalamount.TabIndex"), Integer)
        Me.txt_Totalamount.Text = resources.GetString("txt_Totalamount.Text")
        Me.txt_Totalamount.TextAlign = CType(resources.GetObject("txt_Totalamount.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Totalamount.Visible = CType(resources.GetObject("txt_Totalamount.Visible"), Boolean)
        Me.txt_Totalamount.WordWrap = CType(resources.GetObject("txt_Totalamount.WordWrap"), Boolean)
        '
        'lbl_Physicalstock
        '
        Me.lbl_Physicalstock.AccessibleDescription = resources.GetString("lbl_Physicalstock.AccessibleDescription")
        Me.lbl_Physicalstock.AccessibleName = resources.GetString("lbl_Physicalstock.AccessibleName")
        Me.lbl_Physicalstock.Anchor = CType(resources.GetObject("lbl_Physicalstock.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Physicalstock.AutoSize = CType(resources.GetObject("lbl_Physicalstock.AutoSize"), Boolean)
        Me.lbl_Physicalstock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Physicalstock.Dock = CType(resources.GetObject("lbl_Physicalstock.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Physicalstock.Enabled = CType(resources.GetObject("lbl_Physicalstock.Enabled"), Boolean)
        Me.lbl_Physicalstock.Font = CType(resources.GetObject("lbl_Physicalstock.Font"), System.Drawing.Font)
        Me.lbl_Physicalstock.Image = CType(resources.GetObject("lbl_Physicalstock.Image"), System.Drawing.Image)
        Me.lbl_Physicalstock.ImageAlign = CType(resources.GetObject("lbl_Physicalstock.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Physicalstock.ImageIndex = CType(resources.GetObject("lbl_Physicalstock.ImageIndex"), Integer)
        Me.lbl_Physicalstock.ImeMode = CType(resources.GetObject("lbl_Physicalstock.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Physicalstock.Location = CType(resources.GetObject("lbl_Physicalstock.Location"), System.Drawing.Point)
        Me.lbl_Physicalstock.Name = "lbl_Physicalstock"
        Me.lbl_Physicalstock.RightToLeft = CType(resources.GetObject("lbl_Physicalstock.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Physicalstock.Size = CType(resources.GetObject("lbl_Physicalstock.Size"), System.Drawing.Size)
        Me.lbl_Physicalstock.TabIndex = CType(resources.GetObject("lbl_Physicalstock.TabIndex"), Integer)
        Me.lbl_Physicalstock.Text = resources.GetString("lbl_Physicalstock.Text")
        Me.lbl_Physicalstock.TextAlign = CType(resources.GetObject("lbl_Physicalstock.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Physicalstock.Visible = CType(resources.GetObject("lbl_Physicalstock.Visible"), Boolean)
        '
        'txt_Physicalstock
        '
        Me.txt_Physicalstock.AccessibleDescription = resources.GetString("txt_Physicalstock.AccessibleDescription")
        Me.txt_Physicalstock.AccessibleName = resources.GetString("txt_Physicalstock.AccessibleName")
        Me.txt_Physicalstock.Anchor = CType(resources.GetObject("txt_Physicalstock.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_Physicalstock.AutoSize = CType(resources.GetObject("txt_Physicalstock.AutoSize"), Boolean)
        Me.txt_Physicalstock.BackColor = System.Drawing.Color.Wheat
        Me.txt_Physicalstock.BackgroundImage = CType(resources.GetObject("txt_Physicalstock.BackgroundImage"), System.Drawing.Image)
        Me.txt_Physicalstock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Physicalstock.Dock = CType(resources.GetObject("txt_Physicalstock.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_Physicalstock.Enabled = CType(resources.GetObject("txt_Physicalstock.Enabled"), Boolean)
        Me.txt_Physicalstock.Font = CType(resources.GetObject("txt_Physicalstock.Font"), System.Drawing.Font)
        Me.txt_Physicalstock.ImeMode = CType(resources.GetObject("txt_Physicalstock.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_Physicalstock.Location = CType(resources.GetObject("txt_Physicalstock.Location"), System.Drawing.Point)
        Me.txt_Physicalstock.MaxLength = CType(resources.GetObject("txt_Physicalstock.MaxLength"), Integer)
        Me.txt_Physicalstock.Multiline = CType(resources.GetObject("txt_Physicalstock.Multiline"), Boolean)
        Me.txt_Physicalstock.Name = "txt_Physicalstock"
        Me.txt_Physicalstock.PasswordChar = CType(resources.GetObject("txt_Physicalstock.PasswordChar"), Char)
        Me.txt_Physicalstock.RightToLeft = CType(resources.GetObject("txt_Physicalstock.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_Physicalstock.ScrollBars = CType(resources.GetObject("txt_Physicalstock.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_Physicalstock.Size = CType(resources.GetObject("txt_Physicalstock.Size"), System.Drawing.Size)
        Me.txt_Physicalstock.TabIndex = CType(resources.GetObject("txt_Physicalstock.TabIndex"), Integer)
        Me.txt_Physicalstock.Text = resources.GetString("txt_Physicalstock.Text")
        Me.txt_Physicalstock.TextAlign = CType(resources.GetObject("txt_Physicalstock.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txt_Physicalstock.Visible = CType(resources.GetObject("txt_Physicalstock.Visible"), Boolean)
        Me.txt_Physicalstock.WordWrap = CType(resources.GetObject("txt_Physicalstock.WordWrap"), Boolean)
        '
        'lbl_Help
        '
        Me.lbl_Help.AccessibleDescription = resources.GetString("lbl_Help.AccessibleDescription")
        Me.lbl_Help.AccessibleName = resources.GetString("lbl_Help.AccessibleName")
        Me.lbl_Help.Anchor = CType(resources.GetObject("lbl_Help.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lbl_Help.AutoSize = CType(resources.GetObject("lbl_Help.AutoSize"), Boolean)
        Me.lbl_Help.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Help.Dock = CType(resources.GetObject("lbl_Help.Dock"), System.Windows.Forms.DockStyle)
        Me.lbl_Help.Enabled = CType(resources.GetObject("lbl_Help.Enabled"), Boolean)
        Me.lbl_Help.Font = CType(resources.GetObject("lbl_Help.Font"), System.Drawing.Font)
        Me.lbl_Help.ForeColor = System.Drawing.Color.Red
        Me.lbl_Help.Image = CType(resources.GetObject("lbl_Help.Image"), System.Drawing.Image)
        Me.lbl_Help.ImageAlign = CType(resources.GetObject("lbl_Help.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Help.ImageIndex = CType(resources.GetObject("lbl_Help.ImageIndex"), Integer)
        Me.lbl_Help.ImeMode = CType(resources.GetObject("lbl_Help.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lbl_Help.Location = CType(resources.GetObject("lbl_Help.Location"), System.Drawing.Point)
        Me.lbl_Help.Name = "lbl_Help"
        Me.lbl_Help.RightToLeft = CType(resources.GetObject("lbl_Help.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lbl_Help.Size = CType(resources.GetObject("lbl_Help.Size"), System.Drawing.Size)
        Me.lbl_Help.TabIndex = CType(resources.GetObject("lbl_Help.TabIndex"), Integer)
        Me.lbl_Help.Text = resources.GetString("lbl_Help.Text")
        Me.lbl_Help.TextAlign = CType(resources.GetObject("lbl_Help.TextAlign"), System.Drawing.ContentAlignment)
        Me.lbl_Help.Visible = CType(resources.GetObject("lbl_Help.Visible"), Boolean)
        '
        'Stock_Adjustment
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.lbl_Help)
        Me.Controls.Add(Me.txt_Docno)
        Me.Controls.Add(Me.lbl_Physicalstock)
        Me.Controls.Add(Me.txt_Physicalstock)
        Me.Controls.Add(Me.lbl_Stockinhand)
        Me.Controls.Add(Me.txt_Totalqty)
        Me.Controls.Add(Me.lbl_Totalamount)
        Me.Controls.Add(Me.txt_Totalamount)
        Me.Controls.Add(Me.txt_Storecode)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.cmd_Docnohelp)
        Me.Controls.Add(Me.dtp_Docdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Stock_Adjustment"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim TotalCount As Integer
    Dim gconnection As New GlobalClass
    Dim sqlstring, financalyear As String
    Dim vsearch, vitem, accountcode, STORECODE As String
    Dim docno, transferdocno, doctype, docno1() As String
    Private Sub Stock_Adjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            StockAdjustmentTransbool = True
            Call FillStore()
            txt_Totalqty.ReadOnly = True
            txt_Storecode.ReadOnly = True
            txt_Totalamount.ReadOnly = True
            txt_Physicalstock.ReadOnly = True
            cbo_Storelocation.Enabled = True
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            dtp_Docdate.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            Call clearform(Me)
            Call FillStore() '''-->Fill Store Desc
            Me.lbl_Freeze.Visible = False
            Me.lbl_Freeze.Text = "Record Void  On "
            ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_Freeze.Text = "Void [F8]"
            Me.Cmd_Freeze.Enabled = True
            Cmd_Add.Text = "Add [F7]"
            ssgrid.SetActiveCell(1, 1)
            txt_Physicalstock.ReadOnly = True
            cbo_Storelocation.Enabled = True
            txt_Totalamount.ReadOnly = True
            txt_Storecode.ReadOnly = True
            txt_Totalqty.ReadOnly = True
            txt_Docno.ReadOnly = False
            txt_Docno.Enabled = True
            dtp_Docdate.Value = Format(Now, "dd/MM/yyyy")
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            dtp_Docdate.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim Adjustedamt, Stockqty, Physicalstock, dblval, Avgquantity, Avgrate As Double
            Dim Sqlstring, Insert(0) As String
            Dim i As Integer
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            Me.txt_Physicalstock.Text = 0
            Me.txt_Totalamount.Text = 0
            Me.txt_Totalqty.Text = 0
            For i = 1 To ssgrid.DataRowCnt
                Me.ssgrid.Row = i
                Me.ssgrid.Col = 4
                Stockqty = Val(Me.ssgrid.Text)
                Me.txt_Totalqty.Text = Format(Val(Me.txt_Totalqty.Text) + Val(Stockqty), "0.000")
                Me.ssgrid.Col = 5
                Physicalstock = Val(Me.ssgrid.Text)
                Me.txt_Physicalstock.Text = Format(Val(Me.txt_Physicalstock.Text) + Val(Physicalstock), "0.000")
                Me.ssgrid.Col = 6
                Adjustedamt = Val(Me.ssgrid.Text)
                Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(Adjustedamt), "0.00")
            Next i
            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            '''*********************************************************** Case-1 : Add [F7] *******************************************'''
            '''*********************************************************** INSERT INTO STOCKADJUSTHEADER *******************************'''
            If Cmd_Add.Text = "Add [F7]" Then
                docno1 = Split(Trim(txt_Docno.Text), "/")
                Sqlstring = "INSERT INTO STOCKADJUSTHEADER(Docno,Docdetails,Docdate,Storelocationcode,Storelocationdesc, "
                Sqlstring = Sqlstring & " Adjustedstock, Stockinhand, Physicalstock,Remarks,Void,Adduser,Adddate,Updateuser,Updatetime,TTYPE)"
                Sqlstring = Sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "',"
                Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy ") & "',"
                Sqlstring = Sqlstring & " '" & Trim(txt_Storecode.Text) & "','" & Trim(cbo_Storelocation.Text) & "', "
                Sqlstring = Sqlstring & " " & Format(Val(txt_Totalamount.Text), "0.00") & " ," & Format(Val(txt_Totalqty.Text), "0.00") & ","
                Sqlstring = Sqlstring & " " & Format(Val(txt_Physicalstock.Text), "0.00") & ",'" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,"
                Sqlstring = Sqlstring & " 'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                Sqlstring = Sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','A')"
                Insert(0) = Sqlstring
                '''******************************************************** INSERT INTO STOCKADJUSTDETAILS *******************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    Avgquantity = CalAverageQuantity(Trim(ssgrid.Text))
                    Sqlstring = "INSERT INTO STOCKADJUSTDETAILS(Docno,Docdetails,DocDate,Storelocationcode,Storelocationdesc,"
                    Sqlstring = Sqlstring & " Itemcode,Itemname,Uom,Stockinhand,Physicalstock,Adjustedstock,Rate,Amount,"
                    Sqlstring = Sqlstring & " Dblamount,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,Adddate,Updateuser,Updatetime,TTYPE)"
                    Sqlstring = Sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "',"
                    Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_Storecode.Text) & "','" & Trim(cbo_Storelocation.Text) & "', "
                    ssgrid.Col = 1
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 2
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 6
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 7
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 9
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 12
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 13
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    Sqlstring = Sqlstring & " 'N'," & Format(Val(Avgquantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    Sqlstring = Sqlstring & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','A')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstring
                    ''****************************************** UPDATE Opening Stock ***************************************
                    'If Trim(cbo_Storelocation.Text) = "BAR-1" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 9
                    '    sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue - " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Storelocation.Text) = "BAR-2" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 9
                    '    sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue - " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Storelocation.Text) = "BAR-3" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 9
                    '    sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue - " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'ElseIf Trim(cbo_Storelocation.Text) = "MAIN STORE" Then
                    '    sqlstring = "UPDATE OpeningStock SET "
                    '    .Col = 9
                    '    sqlstring = sqlstring & " doublevalue = doublevalue - " & Format(Val(.Text), "0.000") & ","
                    '    sqlstring = sqlstring & " mainclstock =  ((doublevalue - " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                    '    sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                    '    sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                    '    .Col = 1
                    '    sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    'End If
                Next i
                gconnection.MoreTrans(Insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
                '''********************************************************** UPDATE STOCKADJUSTHEADER *********************************************************'''
                docno1 = Split(Trim(txt_Docno.Text), "/")
                Sqlstring = "UPDATE STOCKADJUSTHEADER SET Docdate='" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy ") & "', "
                Sqlstring = Sqlstring & " Storelocationcode='" & Trim(txt_Storecode.Text) & "',"
                Sqlstring = Sqlstring & " Storelocationdesc='" & Trim(cbo_Storelocation.Text) & "',"
                Sqlstring = Sqlstring & " Adjustedstock=" & Format(Val(txt_Totalamount.Text), "0.00") & ","
                Sqlstring = Sqlstring & " Stockinhand=" & Format(Val(txt_Totalqty.Text), "0.00") & ","
                Sqlstring = Sqlstring & " Physicalstock=" & Format(Val(txt_Physicalstock.Text), "0.00") & ","
                Sqlstring = Sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,"
                Sqlstring = Sqlstring & " Void='N',updateuser='" & Trim(gUsername) & "',"
                Sqlstring = Sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                Sqlstring = Sqlstring & " WHERE Docdetails='" & Trim(txt_Docno.Text) & "' "
                Insert(0) = Sqlstring
                '''********************************************************* DELETE FROM Stockadjustdetails *****************************************************'''
                Sqlstring = "DELETE FROM STOCKADJUSTDETAILS WHERE Docdetails='" & Trim(txt_Docno.Text) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstring
                '''******************************************************** INSERT INTO STOCKADJUSTDETAILS *******************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    Avgquantity = CalAverageQuantity(Trim(ssgrid.Text))
                    Sqlstring = "INSERT INTO STOCKADJUSTDETAILS(Docno,Docdetails,DocDate,Storelocationcode,Storelocationdesc,"
                    Sqlstring = Sqlstring & " Itemcode,Itemname,Uom,Stockinhand,Physicalstock,Adjustedstock,Rate,Amount,"
                    Sqlstring = Sqlstring & " Dblamount,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,Adddate,Updateuser,Updatetime,TTYPE)"
                    Sqlstring = Sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "',"
                    Sqlstring = Sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(txt_Storecode.Text) & "','" & Trim(cbo_Storelocation.Text) & "', "
                    ssgrid.Col = 1
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 2
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 6
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 7
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 9
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    Sqlstring = Sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 12
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 13
                    Sqlstring = Sqlstring & " '" & Trim(ssgrid.Text) & "',"
                    Sqlstring = Sqlstring & " 'N'," & Format(Val(Avgquantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    Sqlstring = Sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','A')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstring
                Next i
                '''****************************************** UPDATE Opening Stock ***************************************
                'If Trim(cbo_Storelocation.Text) = "BAR-1" Then
                '    Sqlstring = "UPDATE OpeningStock SET "
                '    .Col = 9
                '    Sqlstring = Sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & ","
                '    Sqlstring = Sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '    .Col = 1
                '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '    ReDim Preserve Insert(Insert.Length)
                '    Insert(Insert.Length - 1) = Sqlstring
                'ElseIf Trim(cbo_Storelocation.Text) = "BAR-2" Then
                '    Sqlstring = "UPDATE OpeningStock SET "
                '    .Col = 9
                '    Sqlstring = Sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & ","
                '    Sqlstring = Sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '    .Col = 1
                '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '    ReDim Preserve Insert(Insert.Length)
                '    Insert(Insert.Length - 1) = Sqlstring
                'ElseIf Trim(cbo_Storelocation.Text) = "BAR-3" Then
                '    Sqlstring = "UPDATE OpeningStock SET "
                '    .Col = 9
                '    Sqlstring = Sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & ","
                '    Sqlstring = Sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '    .Col = 1
                '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '    ReDim Preserve Insert(Insert.Length)
                '    Insert(Insert.Length - 1) = Sqlstring
                'ElseIf Trim(cbo_Storelocation.Text) = "MAIN STORE" Then
                '    Sqlstring = "UPDATE OpeningStock SET "
                '    .Col = 9
                '    Sqlstring = Sqlstring & " doublevalue = doublevalue + " & Format(Val(.Text), "0.000") & ","
                '    Sqlstring = Sqlstring & " mainclstock =  ((doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '    Sqlstring = Sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '    Sqlstring = Sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '    .Col = 1
                '    Sqlstring = Sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '    ReDim Preserve Insert(Insert.Length)
                '    Insert(Insert.Length - 1) = Sqlstring
                'End If
                gconnection.MoreTrans(Insert)
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call cmd_Print_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Dim i As Integer
            Dim insert(0) As String
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Then
                '''***************************************** Void the DOCNO in stockadjustheader **************************'''
                sqlstring = "UPDATE  STOCKADJUSTHEADER "
                sqlstring = sqlstring & " SET Void= 'Y',"
                sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & " ',"
                sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                insert(0) = sqlstring
                '''***************************************** Void the DOCNO in stockadjustheader Complete **********************************'''
                '''***************************************** Void the DOCNO in stockadjustdetail **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "UPDATE  STOCKADJUSTDETAILS "
                        sqlstring = sqlstring & " SET Void= 'Y',"
                        sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & " ',"
                        sqlstring = sqlstring & " Updatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        sqlstring = sqlstring & " WHERE Docdetails = '" & Trim(txt_Docno.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring
                    End With
                Next i
                ''''***************************************** Void the DOCNO is stockadjustdetail Complete **********************************'''
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        .Row = i
                '        .Col = 1
                '        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
                '        Dim opquantity, opamount, grnquantity, grnamount, calquantity As Double
                '        Dim issuequantity, issueamount As Double
                '        Dim calrate, clsquantity As Double
                '        ''''********************************* From Opening Stock *********************************'''
                '        sqlstring = "SELECT opstock,opvalue FROM inventoryitemmaster WHERE Itemcode='" & Trim(.Text) & "'"
                '        gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                '        If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                '            opquantity = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opstock") & ""), "0.000")
                '            opamount = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opvalue") & ""), "0.00")
                '        Else
                '            opquantity = 0
                '            opamount = 0
                '        End If
                '        ''''********************************* From Grn_details *********************************'''
                '        sqlstring = "SELECT SUM(qty) AS QTY ,SUM(AMOUNT) AS AMOUNT FROM grn_details WHERE Itemcode='" & Trim(.Text) & "' AND Voiditem='N'"
                '        gconnection.getDataSet(sqlstring, "grn_details")
                '        If gdataset.Tables("grn_details").Rows.Count > 0 Then
                '            grnquantity = Format(Val(gdataset.Tables("grn_details").Rows(0).Item("QTY") & ""), "0.000")
                '            grnamount = Format(Val(gdataset.Tables("grn_details").Rows(0).Item("RATE") & ""), "0.00")
                '        Else
                '            grnquantity = 0
                '            grnamount = 0
                '        End If
                '        calquantity = Val(opquantity) + Val(grnquantity)
                '        If calquantity = 0 Then
                '            calrate = 0
                '        Else
                '            calrate = (Val(opamount) + Val(grnamount)) / Val(calquantity)
                '        End If
                '        ''''********************************* From Stockissuedetail *********************************'''
                '        sqlstring = "SELECT SUM(qty) AS QTY ,SUM(AMOUNT) AS AMOUNT FROM stockissuedetail WHERE Itemcode='" & Trim(.Text) & "' AND Void='N'"
                '        gconnection.getDataSet(sqlstring, "stockissuedetail")
                '        If gdataset.Tables("stockissuedetail").Rows.Count > 0 Then
                '            issuequantity = Format(Val(gdataset.Tables("stockissuedetail").Rows(0).Item("Qty") & ""), "0.000")
                '            issueamount = Format(Val(gdataset.Tables("stockissuedetail").Rows(0).Item("AMOUNT") & ""), "0.000")
                '        Else
                '            issuequantity = 0
                '            issueamount = 0
                '        End If
                '        ''' ********************************* To Find Out Closing Balance ***************************'''
                '        calquantity = (Val(opquantity) + Val(grnquantity) - Val(issuequantity))
                '        If calquantity = 0 Then
                '            calrate = 0
                '        Else
                '            calrate = (Val(opamount) + Val(grnamount) - Val(issueamount)) / (Val(calquantity))
                '        End If
                '        clsquantity = (Val(opquantity) + Val(grnquantity) - Val(issuequantity))
                '        '''******************************************
                '        '''****************************************** COMPLETE CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ****************'''
                '        ''****************************************** UPDATE Opening Stock ***************************************
                '        If Trim(cbo_Storelocation.Text) = "BAR-1" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 9
                '            sqlstring = sqlstring & " bar1doublevalue = bar1doublevalue + " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar1clstock =  ((bar1doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Storelocation.Text) = "BAR-2" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 9
                '            sqlstring = sqlstring & " bar2doublevalue = bar2doublevalue + " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar2clstock =  ((bar2doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Storelocation.Text) = "BAR-3" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 9
                '            sqlstring = sqlstring & " bar3doublevalue = bar3doublevalue + " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " bar3clstock =  ((bar3doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        ElseIf Trim(cbo_Storelocation.Text) = "MAIN STORE" Then
                '            sqlstring = "UPDATE OpeningStock SET "
                '            .Col = 9
                '            sqlstring = sqlstring & " doublevalue = doublevalue + " & Format(Val(.Text), "0.000") & ","
                '            sqlstring = sqlstring & " mainclstock =  ((doublevalue + " & Format(Val(.Text), "0.000") & ") / highratio) ,"
                '            sqlstring = sqlstring & " avgrate=  " & Format(Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " avgvalue= " & Format(Val(clsquantity) * Val(calrate), "0.00") & ","
                '            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                '            .Col = 1
                '            sqlstring = sqlstring & "WHERE Itemcode='" & Trim(.Text) & "' "
                '            ReDim Preserve insert(insert.Length)
                '            insert(insert.Length - 1) = sqlstring
                '        End If
                '        '    '''****************************************** UPDATE Complete *********************************************
                '    End With
                'Next i
                gconnection.MoreTrans(insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            gPrint = False
            Dim i As Integer
            Dim objStockadjustmentreport As New rptStockadjustmentreport
            Call checkValidation() '''--> Check Validation
            If boolchk = False Then Exit Sub
            Dim sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
            sqlstring = sqlstring & " ISNULL(H.STORELOCATIONDESC,'') AS STORELOCATIONDESC,ISNULL(D.ITEMCODE,'') AS ITEMCODE, ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM, "
            sqlstring = sqlstring & " ISNULL(D.STOCKINHAND,0) AS STOCKINHAND, ISNULL(D.PHYSICALSTOCK,0) AS PHYSICALSTOCK, ISNULL(D.ADJUSTEDSTOCK,0) AS ADJUSTEDSTOCK,ISNULL(D.RATE,0) AS RATE, "
            sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT FROM STOCKADJUSTHEADER AS H INNER JOIN "
            sqlstring = sqlstring & " STOCKADJUSTDETAILS AS D ON D.DOCDETAILS = H.DOCDETAILS"
            sqlstring = sqlstring & " WHERE H.DOCDETAILS='" & Trim(txt_Docno.Text) & "'"
            sqlstring = sqlstring & " ORDER BY DOCDETAILS,DOCDATE"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "STOCKINHAND", "PHYSICALSTOCK", "ADJUSTEDSTOCK", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ADJUSTMENT"}
            Dim colsize() As Integer = {15, 30, 12, 16, 16, 16, 10, 10}
            objStockadjustmentreport.ReportDetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_Docnohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Docnohelp.Click
        Try
            gSQLString = "SELECT ISNULL(DOCDETAILS,'') AS DOCDETAILS,DOCDATE FROM STOCKADJUSTHEADER"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK ADJUSTMENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_Docno.Text = Trim(vform.keyfield & "")
                Call txt_Docno_Validated(txt_Docno, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Adjustment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F10 Then
                Call cmd_Print_Click(cmd_Print, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_Docno.Text = ""
                txt_Docno.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                Call Cmd_Exit_Click(Cmd_Exit, e)
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.S Then
                Me.cbo_Storelocation.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim Issuerate, Highratio, Dblamount As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim Avgrate, Clsquantity As Double
        Dim focusbool As Boolean
        Dim i, j As Integer
        search = Nothing
        Try
            If e.keyCode = Keys.Enter Then
                i = ssgrid.ActiveRow
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                        Else
                            Itemcode = Trim(ssgrid.Text)
                            ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                            '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                            sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,"
                            sqlstring = sqlstring & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,ISNULL(CONVVALUE,0) AS HIGHRATIO,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
                            If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
                                ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
                                'Clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), Trim(txt_Storecode.Text))
                                Clsquantity = ClosingQuantity_New(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), Trim(txt_Storecode.Text), dtp_Docdate.Value)
                                ssgrid.SetText(4, i, Format(Val(Clsquantity), "0.000"))
                                sqlstring = " SELECT STORECODE FROM STOREMASTER WHERE STOREDESC = '" & Trim(cbo_Storelocation.Text) & "' "
                                gconnection.getDataSet(sqlstring, "STORECD")
                                If gdataset.Tables("STORECD").Rows.Count > 0 Then
                                    STORECODE = gdataset.Tables("STORECD").Rows(j).Item("STORECODE")
                                End If
                                'Avgrate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                'Avgrate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, STORECODE)
                                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                                    Avgrate = CalAverageRate_new_Updated(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, STORECODE)
                                Else
                                    Avgrate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), dtp_Docdate.Text, STORECODE)
                                End If
                                ssgrid.SetText(7, i, Format(Val(Avgrate), "0.00"))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(11, i, Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(13, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("SUBGROUPCODE")))
                                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                ssgrid.Focus()
                            Else
                                MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    Else
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    ssgrid.Col = 2
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                        Else
                            Itemdesc = Trim(ssgrid.Text)
                            ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                            '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                            sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,"
                            sqlstring = sqlstring & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,ISNULL(CONVVALUE,0) AS HIGHRATIO,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
                            sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I WHERE I.ITEMNAME ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
                            If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
                                ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
                                Clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")), Trim(txt_Storecode.Text))
                                ssgrid.SetText(4, i, Format(Val(Clsquantity), "0.00"))
                                Avgrate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(7, i, Format(Val(Avgrate), "0.00"))
                                ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
                                ssgrid.SetText(11, i, Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")))
                                ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("GROUPCODE")))
                                ssgrid.SetText(13, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("SUBGROUPCODE")))
                                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                ssgrid.Focus()
                            Else
                                MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 3 Then
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 4 Then
                    'ssgrid.Col = 4
                    'ssgrid.Row = i
                    'If ssgrid.Lock = False Then
                    '    If Val(ssgrid.Text) = 0 Then
                    '        ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                    '    Else
                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    '    End If
                    'End If
                ElseIf ssgrid.ActiveCol = 5 Then
                    ssgrid.Col = 5
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        'If Val(ssgrid.Text) = 0 Then
                        '    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                        'Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False
                        ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        'End If
                    End If
                ElseIf ssgrid.ActiveCol = 6 Then
                    ssgrid.Col = 6
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        'If Val(ssgrid.Text) = 0 Then
                        '    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                        'Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False
                        ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        'End If
                    Else
                        ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    End If
                ElseIf ssgrid.ActiveCol = 7 Then
                    ssgrid.Col = 7
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 8 Then
                    ssgrid.Col = 8
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 9 Then
                    ssgrid.Col = 9
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 10 Then
                    ssgrid.Col = 10
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 11 Then
                    ssgrid.Col = 11
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 12 Then
                    ssgrid.Col = 12
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 13 Then
                    ssgrid.Col = 13
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            ssgrid.SetActiveCell(12, ssgrid.ActiveRow)
                        Else
                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                        End If
                    End If
                End If
            ElseIf e.keyCode = Keys.F4 Then
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 1
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call FillMenu()
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    ssgrid.Col = 2
                    ssgrid.Row = ssgrid.ActiveRow
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 2
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call FillMenuItem()
                    End If
                End If
            ElseIf e.keyCode = Keys.F3 Then
                ssgrid.Col = ssgrid.ActiveCol
                ssgrid.Row = ssgrid.ActiveRow
                If ssgrid.Lock = False Then
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.ClearRange(1, ssgrid.ActiveRow, 11, ssgrid.ActiveRow, True)
                    ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
                    Call Calculate()
                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    ssgrid.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub FillMenu()
        Try
            Dim vform As New List_Operation
            Dim Clsquantity, Avgrate As Double
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,ISNULL(I.STOCKUOM,'') AS STOCKUOM,"
            gSQLString = gSQLString & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,ISNULL(CONVVALUE,0) AS HIGHRATIO,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
            gSQLString = gSQLString & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I"
            If Trim(search) = " " Then
                M_WhereCondition = " WHERE I.STORECODE = '" & Trim(txt_Storecode.Text) & "' "
            Else
                M_WhereCondition = " WHERE I.STORECODE = '" & Trim(txt_Storecode.Text) & "' AND I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'')<>'Y'"
            End If
            vform.Field = "ITEMNAME,ITEMCODE"
            vform.vFormatstring = "   ITEMCODE |                       ITEMNAME            | CLSTOCK   | CLVALUE    |STOCKUOM   |   CONVUOM   | HIGHRATIO | "
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 4
            vform.Keypos3 = 5
            vform.keypos4 = 6
            vform.Keypos5 = 7
            vform.Keypos6 = 8

            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Call GridUOM(ssgrid.ActiveRow)
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield2)
                Clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_Storecode.Text))
                ssgrid.Col = 4
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(Clsquantity), "0.00")
                'Avgrate = CalAverageRate(Trim(vform.keyfield))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, STORECODE)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, STORECODE)
                End If
                ssgrid.Col = 7
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield3)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield4), "0.00")
                ssgrid.Col = 12
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield5)
                ssgrid.Col = 13
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                ssgrid.Focus()
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenuItem()
        Try
            Dim vform As New List_Operation
            Dim Clsquantity, Avgrate As Double
            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM,"
            gSQLString = gSQLString & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,ISNULL(CONVVALUE,0) AS HIGHRATIO,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
            gSQLString = gSQLString & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I"
            If Trim(search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMNAME LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'')<>'Y'"
            End If
            vform.Field = "ITEMNAME,ITEMCODE"
            vform.vFormatstring = "                         ITEMNAME                    |  ITEMCODE  |     STOCKUOM   |   CONVUOM   | HIGHRATIO | GROUPCODE | SUBGROUPCODE |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.Keypos3 = 3
            vform.keypos4 = 4
            vform.Keypos5 = 5
            vform.Keypos6 = 6
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Call GridUOM(ssgrid.ActiveRow)
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield2)
                Clsquantity = ClosingQuantity(Trim(vform.keyfield1), Trim(txt_Storecode.Text))
                ssgrid.Col = 4
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(Clsquantity), "0.00")
                'Avgrate = CalAverageRate(Trim(vform.keyfield1))
                If SHORTNAME = "HIN" Or SHORTNAME = "IC" Then
                    Avgrate = CalAverageRate_new_Updated(Trim(vform.keyfield), dtp_Docdate.Text, STORECODE)
                Else
                    Avgrate = CalAverageRate_new(Trim(vform.keyfield), dtp_Docdate.Text, STORECODE)
                End If
                ssgrid.Col = 7
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield3)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield4), "0.00")
                ssgrid.Col = 12
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield5)
                ssgrid.Col = 13
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                ssgrid.Focus()
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Calculate()
        Try
            Dim ValStockhand, ValPhysicalstock, ValAdjustedstock As Double
            Dim ValHighratio, ValItemamount, ValDblamount, ValRate As Double
            Dim i As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
                i = ssgrid.ActiveRow
                ssgrid.Col = 4
                ssgrid.Row = i
                ValStockhand = Val(ssgrid.Text)
                ssgrid.Col = 5
                ssgrid.Row = i
                ValPhysicalstock = Val(ssgrid.Text)
                ssgrid.Col = 7
                ssgrid.Row = i
                ValRate = Val(ssgrid.Text)
                ssgrid.Col = 11
                ssgrid.Row = i
                ValHighratio = Val(ssgrid.Text)
                ValAdjustedstock = Val(ValPhysicalstock) - Val(ValStockhand)
                ValItemamount = Format(Val(ValAdjustedstock) * Val(ValRate), "0.00")
                ValDblamount = Format(Val(ValAdjustedstock) * Val(ValHighratio), "0.00")
                If Val(ValItemamount) = 0 Then
                    ssgrid.SetText(6, i, "")
                    ssgrid.SetText(8, i, "")
                    ssgrid.SetText(9, i, "")
                Else
                    ssgrid.SetText(6, i, Format(Val(ValAdjustedstock), "0.000"))
                    ssgrid.SetText(8, i, Format(Val(ValItemamount), "0.00"))
                    ssgrid.SetText(9, i, Format(Val(ValDblamount), "0.00"))
                End If
                ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                Me.txt_Physicalstock.Text = 0
                Me.txt_Totalamount.Text = 0
                Me.txt_Totalqty.Text = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 4
                    ValStockhand = Val(ssgrid.Text)
                    Me.txt_Totalqty.Text = Format(Val(Me.txt_Totalqty.Text) + Val(ValStockhand), "0.000")
                    ssgrid.Col = 5
                    ValPhysicalstock = Val(ssgrid.Text)
                    Me.txt_Physicalstock.Text = Format(Val(Me.txt_Physicalstock.Text) + Val(ValPhysicalstock), "0.000")
                    ssgrid.Col = 6
                    ValAdjustedstock = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(ValAdjustedstock), "0.000")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub dtp_Docdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Docdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cbo_Storelocation.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Storelocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_Storelocation.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ssgrid.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Remarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Remarks.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillStore()
        Try
            Dim i As Integer
            'sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC,ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE   ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC,ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            cbo_Storelocation.Items.Clear()
            cbo_Storelocation.Sorted = True
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                    cbo_Storelocation.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Public Sub checkValidation()
        Try
            Dim i, j As Integer
            Dim itemcode As String
            boolchk = False
            '''********** Check  Store Location Can't be blank *********************'''
            If Trim(cbo_Storelocation.Text) = "" Then
                MessageBox.Show(" Store Location field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Storelocation.Focus()
                Exit Sub
            End If
            '''********** Check  Total Quantity Can't be blank *********************'''
            'If Val(txt_Totalqty.Text) = 0 Then
            '    MessageBox.Show(" Total Quantity can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txt_Totalqty.Focus()
            '    Exit Sub
            'End If
            ''''********** Check  Physical Stock Can't be blank *********************'''
            'If Val(txt_Physicalstock.Text) = 0 Then
            '    MessageBox.Show(" Physical Stock can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txt_Physicalstock.Focus()
            '    Exit Sub
            'End If
            '''********** Check  Totalamount Can't be blank *********************'''
            If Val(txt_Totalamount.Text) = 0 Then
                MessageBox.Show(" Totalamount can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Totalamount.Focus()
                Exit Sub
            End If
            '''********** Check  DOC No. Can't be blank *********************'''
            If Trim(txt_Docno.Text) = "" Then
                MessageBox.Show(" DOC No. field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Docno.Focus()
                Exit Sub
            End If
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("ItemCode can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(1, i)
                    Exit Sub
                End If
                ssgrid.Col = 2
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Itemdesc can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(2, i)
                    Exit Sub
                End If
                ssgrid.Col = 3
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(3, i)
                    Exit Sub
                End If
                'ssgrid.Col = 4
                'If Val(ssgrid.Text) = 0 Then
                '    MessageBox.Show("Stock in hand can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(4, i)
                '    Exit Sub
                'End If
                'ssgrid.Col = 5
                'If Val(ssgrid.Text) = 0 Then
                '    MessageBox.Show("Physical stock can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '    ssgrid.SetActiveCell(5, i)
                '    Exit Sub
                'End If
                ssgrid.Col = 6
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Adjusted stock can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(6, i)
                    Exit Sub
                End If
                ssgrid.Col = 7
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(7, i)
                    Exit Sub
                End If
                ssgrid.Col = 8
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(8, i)
                    Exit Sub
                End If
                ssgrid.Col = 9
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("dblamount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(9, i)
                    Exit Sub
                End If
                'ssgrid.Col = 10
                'If Trim(ssgrid.Text) = "" Then
                'MessageBox.Show("dblconv can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                'ssgrid.SetActiveCell(10, i)
                'Exit Sub
                'End If
                ssgrid.Col = 11
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("High Ratio can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(11, i)
                    Exit Sub
                End If
                ssgrid.Col = 12
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(10, i)
                    Exit Sub
                End If
                ssgrid.Col = 13
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Sub Group Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(11, i)
                    Exit Sub
                End If
            Next i
            ''''****************************************** Check if that specified quantity is avaliable or not *************************************************'''
            'With ssgrid
            '    For i = 1 To .DataRowCnt
            '        .Row = i
            '        .Col = 1
            '        itemcode = Trim(.Text)
            '        If Trim(cbo_Storelocation.Text) = "BAR-1" Then
            '            sqlstring = "SELECT bar1clstock,bar1doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar1clstock")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar1doublevalue")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        ElseIf Trim(cbo_Storelocation.Text) = "BAR-2" Then
            '            sqlstring = "SELECT bar2clstock,bar2doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar2clstock")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar2doublevalue")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        ElseIf Trim(cbo_Storelocation.Text) = "BAR-3" Then
            '            sqlstring = "SELECT bar3clstock,bar3doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar3clstock")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("bar3doublevalue")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        ElseIf Trim(cbo_Storelocation.Text) = "MAIN STORE" Then
            '            sqlstring = "SELECT mainclstock,doublevalue FROM openingstock WHERE itemcode='" & itemcode & "'"
            '            gconnection.getDataSet(sqlstring, "openingstock")
            '            If gdataset.Tables("openingstock").Rows.Count > 0 Then
            '                .Col = 4
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("mainclstock")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '                .Col = 7
            '                If Val(gdataset.Tables("openingstock").Rows(j).Item("doublevalue")) <= Val(.Text) Then
            '                    MessageBox.Show("Specified quantity is not available" & vbCrLf & " for itemcode " & itemcode, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '                    .SetActiveCell(4, i)
            '                    .Text = ""
            '                    .Focus()
            '                    Exit Sub
            '                End If
            '            End If
            '        End If
            '    Next i
            'End With
            ''''******************************** First validation *******************************************'''
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Totalamount.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Totalqty.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalqty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Totalqty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Physicalstock.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Physicalstock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Physicalstock.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_Remarks.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Docno.Validated
        Dim vString, sqlstring, Stritemcode, remarks As String
        Dim Clsquantity As Double
        Dim dt As New DataTable
        Dim j, i As Integer
        If Trim(txt_Docno.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(DOCNO,'') AS DOCNO,ISNULL(DOCDETAILS,'') AS DOCDETAILS,DOCDATE,ISNULL(STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
                sqlstring = sqlstring & " ISNULL(STORELOCATIONDESC,'') AS STORELOCATIONDESC,ISNULL(ADJUSTEDSTOCK,0) AS ADJUSTEDAMOUNT,ISNULL(STOCKINHAND,0) AS STOCKINHAND,"
                sqlstring = sqlstring & " ISNULL(PHYSICALSTOCK,0) AS PHYSICALSTOCK,ISNULL(REMARKS,'') AS REMARKS,ISNULL(VOID,'') AS VOID,ISNULL(ADDUSER,'') AS ADDUSER,"
                sqlstring = sqlstring & " ADDDATE,ISNULL(UPDATEUSER,'') AS UPDATEUSER,UPDATETIME FROM STOCKADJUSTHEADER "
                sqlstring = sqlstring & " WHERE DOCNO='" & Trim(txt_Docno.Text) & "'OR DOCDETAILS='" & Trim(txt_Docno.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKADJUSTHEADER")
                '''************************************************* SELECT RECORD FROM STOCKADJUSTHEADER *********************************************''''                
                If gdataset.Tables("STOCKADJUSTHEADER").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    txt_Docno.Text = Trim(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("DOCDETAILS"))
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_Storecode.Text = Trim(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    cbo_Storelocation.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_Storelocation.Enabled = False
                    cbo_Storelocation.Text = Trim(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("STORELOCATIONDESC"))
                    cbo_Storelocation.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("ADJUSTEDAMOUNT")), "0.00")
                    txt_Totalqty.Text = Format(Val(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("STOCKINHAND")), "0.000")
                    txt_Physicalstock.Text = Format(Val(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("PHYSICALSTOCK")), "0.000")

                    remarks = Trim(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("REMARKS") & "")
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("stockadjustheader").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Void  On " & Format(CDate(gdataset.Tables("STOCKADJUSTHEADER").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Void  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKADJUSTEDDETAILS *********************************************''''                
                    sqlstring = "SELECT ISNULL(D.DOCDETAILS,'') AS DOCDETAILS,D.DOCDATE AS DOCDATE,ISNULL(D.STORELOCATIONCODE,'') AS STORELOCATIONCODE,  "
                    sqlstring = sqlstring & " ISNULL(D.STORELOCATIONDESC,'') AS STORELOCATIONDESC,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMNAME,'') AS ITEMNAME,"
                    sqlstring = sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.STOCKINHAND,0) AS STOCKINHAND,ISNULL(D.PHYSICALSTOCK,0) AS PHYSICALSTOCK,"
                    sqlstring = sqlstring & " ISNULL(D.ADJUSTEDSTOCK,0) AS ADJUSTEDSTOCK,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,"
                    sqlstring = sqlstring & " ISNULL(D.DBLAMOUNT,0) AS DBLAMOUNT,ISNULL(D.DBLCONV,'') AS DBLCONV,ISNULL(D.HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(D.GROUPCODE,'') AS GROUPCODE,ISNULL(D.SUBGROUPCODE,'') AS SUBGROUPCODE FROM STOCKADJUSTDETAILS AS D WHERE  ISNULL(D.DOCDETAILS,'')='" & Trim(txt_Docno.Text) & "'"
                    gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS1")
                    If gdataset.Tables("STOCKADJUSTDETAILS1").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("STOCKADJUSTDETAILS1").Rows.Count
                            Call GridUOM(i)
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("ITEMCODE")))
                            Stritemcode = Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("STOCKINHAND")))
                            ssgrid.SetText(5, i, Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("PHYSICALSTOCK")))
                            ssgrid.SetText(6, i, Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("ADJUSTEDSTOCK")))
                            ssgrid.SetText(14, i, Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("STOCKINHAND")), "0.000"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(8, i, Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("DBLAMOUNT")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("DBLCONV")))
                            ssgrid.SetText(11, i, Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(12, i, Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(13, i, Trim(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(j).Item("SUBGROUPCODE")))
                            Clsquantity = ClosingQuantity(Stritemcode, Trim(txt_Storecode.Text))
                            ssgrid.SetText(15, i, Format(Val(Clsquantity), "0.00"))
                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    TotalCount = gdataset.Tables("STOCKADJUSTDETAILS1").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub GridUOM(ByVal i As Integer)
        Try
            Dim j As Integer
            sqlstring = "SELECT UOMdesc FROM UOMMaster WHERE freeze='N'"
            gconnection.getDataSet(sqlstring, "UOMMaster1")
            If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
                For j = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMaster1").Rows(j).Item("UOMdesc"))
                    ssgrid.Text = Trim(gdataset.Tables("UOMMaster1").Rows(j).Item("UOMdesc"))
                Next j
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub autogenerate()
        Try
            Dim sqlstring, financalyear As String
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            If cbo_Storelocation.Text = "MAIN STORE" Then
                docno = "MAIN"
            Else
                docno = doctype
            End If
            sqlstring = "SELECT MAX(Cast(SUBSTRING(DOCNO,1,6) As Numeric)) FROM STOCKADJUSTHEADER"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_Docno.Text = docno & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_Docno.Text = docno & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_Docno.Text = docno & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cbo_Storelocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Storelocation.SelectedIndexChanged
        Try
            If Cmd_Add.Text = "Add [F7]" Then
                Dim i As Integer
                '''******************************* Fill Corresponding Storecode *****************************************'''
                sqlstring = "SELECT ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE STOREDESC ='" & Trim(cbo_Storelocation.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOREMASTER")
                If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                    txt_Storecode.Text = Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORECODE"))
                    txt_Storecode.ReadOnly = True
                    STORECODE = Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORECODE"))
                End If
                '''******************************* End Store Code *****************************************'''
                If cbo_Storelocation.Text = "MAIN STORE" Then
                    Call autogenerate()
                Else
                    doctype = Trim(txt_Storecode.Text)
                    Call autogenerate()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Docno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmd_Docnohelp.Enabled = True Then
                    search = Trim(txt_Docno.Text)
                    Call cmd_Docnohelp_Click(cmd_Docnohelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Docno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_Docno.Text) = "" Then
                    Call cmd_Docnohelp_Click(cmd_Docnohelp, e)
                Else
                    txt_Docno_Validated(txt_Docno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Adjustment_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            StockAdjustmentTransbool = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim Issuerate, Highratio, Dblamount As Double
        Dim ItemQty, ItemAmount, ItemRate As Double
        Dim Avgrate, Clsquantity As Double
        Dim focusbool As Boolean
        Dim i, j As Integer
        search = Nothing
        'Try
        '    i = ssgrid.ActiveRow
        '    If ssgrid.ActiveCol = 4 Then
        '        ssgrid.Col = 4
        '        ssgrid.Row = i
        '        If ssgrid.Lock = False Then
        '            If Val(ssgrid.Text) = 0 Then
        '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
        '            Else
        '                ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
        '            End If
        '        End If
        '    ElseIf ssgrid.ActiveCol = 5 Then
        '        ssgrid.Col = 5
        '        ssgrid.Row = i
        '        If ssgrid.Lock = False Then
        '            If Val(ssgrid.Text) = 0 Then
        '                ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
        '            Else
        '                Call Calculate() '''--> Calculate total amount
        '                ssgrid.Row = ssgrid.ActiveRow + 1
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
        '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
        '            End If
        '        End If
        '    ElseIf ssgrid.ActiveCol = 6 Then
        '        ssgrid.Col = 6
        '        ssgrid.Row = ssgrid.ActiveRow
        '        If ssgrid.Lock = False Then
        '            If Val(ssgrid.Text) = 0 Then
        '                ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
        '            Else
        '                Call Calculate() '''--> Calculate total amount
        '                ssgrid.Row = ssgrid.ActiveRow + 1
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
        '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
        '            End If
        '        Else
        '            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
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
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        Try
            gPrint = True
            Dim i As Integer
            Dim objStockadjustmentreport As New rptStockadjustmentreport
            Call checkValidation() '''--> Check Validation
            If boolchk = False Then Exit Sub
            Dim sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
            sqlstring = sqlstring & " ISNULL(H.STORELOCATIONDESC,'') AS STORELOCATIONDESC,ISNULL(D.ITEMCODE,'') AS ITEMCODE, ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM, "
            sqlstring = sqlstring & " ISNULL(D.STOCKINHAND,0) AS STOCKINHAND, ISNULL(D.PHYSICALSTOCK,0) AS PHYSICALSTOCK, ISNULL(D.ADJUSTEDSTOCK,0) AS ADJUSTEDSTOCK,ISNULL(D.RATE,0) AS RATE, "
            sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT FROM STOCKADJUSTHEADER AS H INNER JOIN "
            sqlstring = sqlstring & " STOCKADJUSTDETAILS AS D ON D.DOCDETAILS = H.DOCDETAILS"
            sqlstring = sqlstring & " WHERE H.DOCDETAILS='" & Trim(txt_Docno.Text) & "'"
            sqlstring = sqlstring & " ORDER BY DOCDETAILS,DOCDATE"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "STOCKINHAND", "PHYSICALSTOCK", "ADJUSTEDSTOCK", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ADJUSTMENT"}
            Dim colsize() As Integer = {15, 30, 12, 16, 16, 16, 10, 10}
            objStockadjustmentreport.ReportDetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub
End Class
