Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmUomRelation
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
    Friend WithEvents lbl_Itemuom As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Salerate As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUOMCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubUOM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtConvFactor As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUomRelation))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtConvFactor = New System.Windows.Forms.TextBox
        Me.lbl_Salerate = New System.Windows.Forms.Label
        Me.cmbSubUOM = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbUOMCode = New System.Windows.Forms.ComboBox
        Me.lbl_Itemuom = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(152, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(359, 28)
        Me.lbl_Heading.TabIndex = 20
        Me.lbl_Heading.Text = "SUB UOM CONVERTION FACTOR"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtConvFactor)
        Me.GroupBox1.Controls.Add(Me.lbl_Salerate)
        Me.GroupBox1.Controls.Add(Me.cmbSubUOM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbUOMCode)
        Me.GroupBox1.Controls.Add(Me.lbl_Itemuom)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 160)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'TxtConvFactor
        '
        Me.TxtConvFactor.BackColor = System.Drawing.Color.Wheat
        Me.TxtConvFactor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConvFactor.Location = New System.Drawing.Point(192, 106)
        Me.TxtConvFactor.MaxLength = 15
        Me.TxtConvFactor.Name = "TxtConvFactor"
        Me.TxtConvFactor.Size = New System.Drawing.Size(152, 26)
        Me.TxtConvFactor.TabIndex = 29
        Me.TxtConvFactor.Text = ""
        '
        'lbl_Salerate
        '
        Me.lbl_Salerate.AutoSize = True
        Me.lbl_Salerate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Salerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Salerate.Location = New System.Drawing.Point(15, 109)
        Me.lbl_Salerate.Name = "lbl_Salerate"
        Me.lbl_Salerate.Size = New System.Drawing.Size(165, 18)
        Me.lbl_Salerate.TabIndex = 30
        Me.lbl_Salerate.Text = "CONVERTION FACTOR :"
        '
        'cmbSubUOM
        '
        Me.cmbSubUOM.BackColor = System.Drawing.Color.Wheat
        Me.cmbSubUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubUOM.Location = New System.Drawing.Point(192, 64)
        Me.cmbSubUOM.Name = "cmbSubUOM"
        Me.cmbSubUOM.Size = New System.Drawing.Size(152, 27)
        Me.cmbSubUOM.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "SUBSEQUENT UOM:"
        '
        'cmbUOMCode
        '
        Me.cmbUOMCode.BackColor = System.Drawing.Color.Wheat
        Me.cmbUOMCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUOMCode.Location = New System.Drawing.Point(192, 24)
        Me.cmbUOMCode.Name = "cmbUOMCode"
        Me.cmbUOMCode.Size = New System.Drawing.Size(152, 27)
        Me.cmbUOMCode.TabIndex = 25
        '
        'lbl_Itemuom
        '
        Me.lbl_Itemuom.AutoSize = True
        Me.lbl_Itemuom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Itemuom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemuom.Location = New System.Drawing.Point(16, 28)
        Me.lbl_Itemuom.Name = "lbl_Itemuom"
        Me.lbl_Itemuom.Size = New System.Drawing.Size(85, 18)
        Me.lbl_Itemuom.TabIndex = 26
        Me.lbl_Itemuom.Text = "BASE UOM :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_View)
        Me.frmbut.Controls.Add(Me.Cmd_Add)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Location = New System.Drawing.Point(96, 232)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(472, 56)
        Me.frmbut.TabIndex = 37
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
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(240, 14)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 15
        Me.Cmd_View.Text = " View[F9]"
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(352, 14)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 16
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'FrmUomRelation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(672, 306)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Name = "FrmUomRelation"
        Me.Text = "FrmUomRelation"
        Me.GroupBox1.ResumeLayout(False)
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vseqno As Double
    Dim boolchk As Boolean
    Dim sqlstring As String
    Public baseuom, transuom As String

    Dim gconnection As New GlobalClass
    Private Sub FrmUomRelation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cmd_Clear_Click(sender, e)

        If baseuom <> "" And transuom <> "" Then
            cmbUOMCode.Text = baseuom
            cmbSubUOM.Text = transuom
        End If

    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        cmbUOMCode.Text = ""
        cmbSubUOM.Text = ""
        TxtConvFactor.Text = ""
        'Me.lbl_Freeze.Visible = False
        'Me.lbl_Freeze.Text = "Record Freezed  On "
        'Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        Call fillUOM()
        cmbUOMCode.Focus()
    End Sub
    Private Function fillUOM()
        Dim I As Integer
        sqlstring = "SELECT ISNULL(UOMCODE,'') AS UOMCODE,ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMaster where isnull(freeze,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "UOMMaster")
        If gdataset.Tables("UOMMaster").Rows.Count > 0 Then
            cmbUOMCode.Items.Clear()
            cmbSubUOM.Items.Clear()
            For I = 0 To gdataset.Tables("UOMMaster").Rows.Count - 1
                cmbUOMCode.Items.Add(gdataset.Tables("UOMMaster").Rows(I).Item("UOMDESC").ToString())
                cmbSubUOM.Items.Add(gdataset.Tables("UOMMaster").Rows(I).Item("UOMDESC").ToString())
            Next
            cmbUOMCode.SelectedIndex = 0
            cmbSubUOM.SelectedIndex = 0
        End If
    End Function
    Private Sub TxtConvFactor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConvFactor.KeyPress
        getPositiveNumeric(e)
        'getNumeric(e)
    End Sub

    Private Sub cmbUOMCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUOMCode.SelectedIndexChanged
        If cmbUOMCode.Text <> "" And cmbSubUOM.Text <> "" Then
            Dim dtl As New DataTable
            sqlstring = "select isnull(CONVVALUE,0)as CONVVALUE,ISNULL(Freeze,'') AS Freeze,ISNULL(VOIDDATETIME,'')AS VOIDDATETIME  from INVENTORY_TRANSCONVERSION where BASEUOM ='" & cmbUOMCode.Text & "' and TRANSUOM ='" & cmbSubUOM.Text & "' "
            dtl = gconnection.GetValues(sqlstring)
            If dtl.Rows.Count > 0 Then
                TxtConvFactor.Text = Val(dtl.Rows(0).Item("CONVVALUE").ToString())
                Me.Cmd_Add.Text = "Update[F7]"
                If dtl.Rows(0).Item("Freeze") = "Y" Then
                    'Me.lbl_Freeze.Visible = True
                    'Me.lbl_Freeze.Text = ""
                    'Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(dtl.Rows(0).Item("VOIDDATETIME")), "dd/MMM/yyyy")
                    'Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    'Me.lbl_Freeze.Visible = False
                    'Me.lbl_Freeze.Text = "Record Freezed  On "
                    'Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
            Else
                TxtConvFactor.Text = ""
                Cmd_Add.Text = "Add [F7]"
            End If
        End If
    End Sub
    Private Sub cmbSubUOM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubUOM.SelectedIndexChanged
        If cmbUOMCode.Text <> "" And cmbSubUOM.Text <> "" Then
            Dim dtl As New DataTable
            sqlstring = "select isnull(CONVVALUE,0)as CONVVALUE,ISNULL(Freeze,'') AS Freeze,ISNULL(VOIDDATETIME,'')AS VOIDDATETIME  from INVENTORY_TRANSCONVERSION where BASEUOM ='" & cmbUOMCode.Text & "' and TRANSUOM ='" & cmbSubUOM.Text & "' "
            dtl = gconnection.GetValues(sqlstring)
            If dtl.Rows.Count > 0 Then
                TxtConvFactor.Text = Val(dtl.Rows(0).Item("CONVVALUE").ToString())
                Me.Cmd_Add.Text = "Update[F7]"
                If dtl.Rows(0).Item("Freeze") = "Y" Then
                    'Me.lbl_Freeze.Visible = True
                    'Me.lbl_Freeze.Text = ""
                    'Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(dtl.Rows(0).Item("VOIDDATETIME")), "dd/MMM/yyyy")
                    'Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    'Me.lbl_Freeze.Visible = False
                    'Me.lbl_Freeze.Text = "Record Freezed  On "
                    'Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                'TxtConvFactor.Focus()
            Else
                'TxtConvFactor.Focus()
                TxtConvFactor.Text = ""
                Cmd_Add.Text = "Add [F7]"
            End If
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Cmd_Add.Text = "Add [F7]" Then
                sqlstring = "INSERT INTO INVENTORY_TRANSCONVERSION (BASEUOM ,TRANSUOM , CONVVALUE,freeze,ADDUSER ,ADDDATETIME ) VALUES ( "
                sqlstring = sqlstring & "'" & cmbUOMCode.Text & "',"
                sqlstring = sqlstring & "'" & cmbSubUOM.Text & "',"
                sqlstring = sqlstring & "" & Val(TxtConvFactor.Text) & ","
                sqlstring = sqlstring & "'N',"
                sqlstring = sqlstring & "'" & gUsername & "',"
                sqlstring = sqlstring & "GETDATE())"
                gconnection.dataOperation(1, sqlstring)
                Cmd_Clear_Click(sender, e)
            ElseIf Cmd_Add.Text = "Update[F7]" Then
                If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                    'If Me.lbl_Freeze.Visible = True Then
                    '    MessageBox.Show(" The Freezed Record Can Not Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    '    Exit Sub
                    '    boolchk = False
                    'End If
                End If
                sqlstring = "update INVENTORY_TRANSCONVERSION set CONVVALUE =" & Val(TxtConvFactor.Text) & " ,UPDATEUSER='" & gUsername & "',UPDATEDATETIME=GETDATE() where BASEUOM='" & cmbUOMCode.Text & "' and TRANSUOM='" & cmbSubUOM.Text & "'"
                gconnection.dataOperation(2, sqlstring)
                Cmd_Clear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURRED: " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub checkValidation()
        Try
            boolchk = False
            '''********** Check  Store Code Can't be blank *********************'''
            If Trim(cmbUOMCode.Text) = "" Then
                MessageBox.Show(" UOM Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbUOMCode.Focus()
                Exit Sub
            End If
            '''********** Check  Subsequent UOM Can't be blank *********************'''
            If Trim(cmbSubUOM.Text) = "" Then
                MessageBox.Show(" Subsequent UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbSubUOM.Focus()
                Exit Sub
            End If
            '''********** Check  Conversion factor Can't be blank *********************'''
            If Trim(TxtConvFactor.Text) = "" Then
                MessageBox.Show(" Conversion factor can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtConvFactor.Focus()
                Exit Sub
            End If
            If Val(Trim(TxtConvFactor.Text)) = 0 Then
                MessageBox.Show(" Conversion factor can't be Zero ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtConvFactor.Focus()
                Exit Sub
            End If

            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub cmbUOMCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUOMCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbSubUOM.Focus()
        End If
    End Sub
    Private Sub cmbSubUOM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSubUOM.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtConvFactor.Focus()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim rViewer As New Viewer
        Dim sqlstring, SSQL As String
        Dim r As New Rpt_UomConvertionFactor
        sqlstring = "SELECT * FROM INVENTORY_TRANSCONVERSION ORDER BY BASEUOM "
        gconnection.getDataSet(sqlstring, "inventorygroupmaster")
        If gdataset.Tables("inventorygroupmaster").Rows.Count > 0 Then
            'If chk_excel.Checked = True Then
            '    Dim exp As New exportexcel
            '    exp.Show()
            '    Call exp.export(sqlstring, "UOM CONVERTION FACTOR DETAILS ", "")
            'Else
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "INVENTORY_TRANSCONVERSION"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text21")
                textobj2.Text = gUsername
                rViewer.Show()
            'End If
        Else
            MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
        End If
    End Sub

    Private Sub FrmUomRelation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            End If
            If e.KeyCode = Keys.F8 Then
                'Call Cmd_Freeze_Click(Cmd_Freeze, e)
                'Exit Sub
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
        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class
