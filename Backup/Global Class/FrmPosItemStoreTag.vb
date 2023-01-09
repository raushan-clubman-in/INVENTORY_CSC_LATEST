Public Class FrmPosItemStoreTag
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
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPosItemStoreTag))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(192, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(234, 28)
        Me.lbl_Heading.TabIndex = 21
        Me.lbl_Heading.Text = "POS Item Store Tagging"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ssgrid)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 400)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(16, 24)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(464, 360)
        Me.ssgrid.TabIndex = 2
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_Add)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Location = New System.Drawing.Point(136, 472)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(368, 56)
        Me.frmbut.TabIndex = 38
        Me.frmbut.TabStop = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 14)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 17
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 14)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 14
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(246, 14)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 16
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'FrmPosItemStoreTag
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(688, 602)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Name = "FrmPosItemStoreTag"
        Me.Text = "FrmPosItemStoreTag"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Vconn As New GlobalClass
    Dim SQLSTRING As String
    Private Sub FrmPosItemStoreTag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        SQLSTRING = "SELECT ISNULL(P.POS,'') AS POS,ISNULL(P.ITEMCODE,'') AS ITEMCODE,ISNULL(K.STORECODE,'') AS STORECODE FROM POSMENULINK P LEFT OUTER JOIN POSITEMSTORELINK K ON K.POS = P.Pos AND K.ITEMCODE = P.ItemCode WHERE P.POS IN ('01','02','03','64','65','66') ORDER BY STORECODE,P.Pos,P.ItemCode"
        Vconn.getDataSet(SQLSTRING, "STORETAG")
        If gdataset.Tables("STORETAG").Rows.Count > 0 Then
            ssgrid.MaxRows = gdataset.Tables("STORETAG").Rows.Count + 10
            For i = 0 To gdataset.Tables("STORETAG").Rows.Count - 1
                j = i + 1
                With ssgrid
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("STORETAG").Rows(i).Item("POS")
                    .Col = 2
                    .Text = gdataset.Tables("STORETAG").Rows(i).Item("ITEMCODE")
                    .Col = 3
                    .Text = gdataset.Tables("STORETAG").Rows(i).Item("STORECODE")
                End With
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        With ssgrid
            If .ActiveCol = 3 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
        End With
        If e.keyCode = Keys.F7 Then
            Dim frmSrc As New frmSearch
            frmSrc.farPoint = ssgrid
            frmSrc.ShowDialog(Me)
        End If
    End Sub
    Private Sub FillMenu()
        Dim vform As New List_Operation
        Dim ssql As String
        gSQLString = "SELECT Storecode,Storedesc FROM StoreMaster "
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y' AND ISNULL(STORESTATUS,'') <> 'M'"
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y' AND ISNULL(STORESTATUS,'') <> 'M' "
        End If
        vform.Field = "Storecode,Storedesc"
        vform.vFormatstring = "Store Code     |Store Desc                     "
        vform.vCaption = "STORE CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield
            End With
        Else
            ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim i As Integer
        Dim itemcd, Storecode, PosCode, ssql As String
        If ssgrid.DataRowCnt <= 1 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        With ssgrid
            For i = 0 To ssgrid.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                PosCode = .Text
                .Col = 2
                itemcd = .Text
                .Col = 3
                Storecode = .Text
                If Trim(Storecode) <> "" Then
                    ssql = "Delete from POSITEMSTORELINK Where itemcode='" & itemcd & "' and Pos = '" & PosCode & "'"
                    Vconn.dataOperation(6, ssql, "DelItem")
                    ssql = "INSERT INTO POSITEMSTORELINK (POS,ITEMCODE,STORECODE) VALUES ('" & PosCode & "','" & itemcd & "','" & Storecode & "')"
                    Vconn.dataOperation(6, ssql, "InsItem")
                End If
            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        ssgrid.ClearRange(1, 1, ssgrid.DataColCnt, ssgrid.DataRowCnt, False)
        Call FrmPosItemStoreTag_Load(sender, e)
    End Sub
End Class
