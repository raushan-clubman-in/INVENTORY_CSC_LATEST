Public Class frmMANUALUPDATION
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
    Friend WithEvents lbl_KOTdate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_FROMdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_TOdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmd_UPDATE As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_POS As System.Windows.Forms.TextBox
    Friend WithEvents PBAR As System.Windows.Forms.ProgressBar
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMANUALUPDATION))
        Me.dtp_FROMdate = New System.Windows.Forms.DateTimePicker
        Me.dtp_TOdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_KOTdate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmd_UPDATE = New System.Windows.Forms.Button
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_POS = New System.Windows.Forms.TextBox
        Me.PBAR = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'dtp_FROMdate
        '
        Me.dtp_FROMdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FROMdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FROMdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FROMdate.Location = New System.Drawing.Point(200, 16)
        Me.dtp_FROMdate.Name = "dtp_FROMdate"
        Me.dtp_FROMdate.Size = New System.Drawing.Size(136, 26)
        Me.dtp_FROMdate.TabIndex = 5
        '
        'dtp_TOdate
        '
        Me.dtp_TOdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_TOdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TOdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_TOdate.Location = New System.Drawing.Point(200, 56)
        Me.dtp_TOdate.Name = "dtp_TOdate"
        Me.dtp_TOdate.Size = New System.Drawing.Size(136, 26)
        Me.dtp_TOdate.TabIndex = 6
        '
        'lbl_KOTdate
        '
        Me.lbl_KOTdate.AutoSize = True
        Me.lbl_KOTdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KOTdate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_KOTdate.Location = New System.Drawing.Point(16, 16)
        Me.lbl_KOTdate.Name = "lbl_KOTdate"
        Me.lbl_KOTdate.Size = New System.Drawing.Size(160, 25)
        Me.lbl_KOTdate.TabIndex = 41
        Me.lbl_KOTdate.Text = "FROM DATE   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "TO DATE     :"
        '
        'Cmd_UPDATE
        '
        Me.Cmd_UPDATE.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_UPDATE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_UPDATE.ForeColor = System.Drawing.Color.White
        Me.Cmd_UPDATE.Image = CType(resources.GetObject("Cmd_UPDATE.Image"), System.Drawing.Image)
        Me.Cmd_UPDATE.Location = New System.Drawing.Point(72, 184)
        Me.Cmd_UPDATE.Name = "Cmd_UPDATE"
        Me.Cmd_UPDATE.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_UPDATE.TabIndex = 8
        Me.Cmd_UPDATE.Text = "UPDATE"
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.ForeColor = System.Drawing.Color.White
        Me.cmd_exit.Image = CType(resources.GetObject("cmd_exit.Image"), System.Drawing.Image)
        Me.cmd_exit.Location = New System.Drawing.Point(200, 184)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_exit.TabIndex = 9
        Me.cmd_exit.Text = "EXIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 353
        Me.Label2.Text = "POS CODE    :"
        '
        'txt_POS
        '
        Me.txt_POS.BackColor = System.Drawing.Color.Wheat
        Me.txt_POS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_POS.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POS.Location = New System.Drawing.Point(200, 96)
        Me.txt_POS.MaxLength = 50
        Me.txt_POS.Name = "txt_POS"
        Me.txt_POS.Size = New System.Drawing.Size(136, 29)
        Me.txt_POS.TabIndex = 7
        Me.txt_POS.Text = ""
        '
        'PBAR
        '
        Me.PBAR.Location = New System.Drawing.Point(16, 144)
        Me.PBAR.Name = "PBAR"
        Me.PBAR.Size = New System.Drawing.Size(344, 24)
        Me.PBAR.Step = 1
        Me.PBAR.TabIndex = 358
        '
        'frmMANUALUPDATION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(376, 232)
        Me.Controls.Add(Me.PBAR)
        Me.Controls.Add(Me.txt_POS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_KOTdate)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.Cmd_UPDATE)
        Me.Controls.Add(Me.dtp_TOdate)
        Me.Controls.Add(Me.dtp_FROMdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMANUALUPDATION"
        Me.Text = "MANUAL STOCK UPDATION FROM POS"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Private Sub Cmd_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_UPDATE.Click
        If UCase(Mid(MyCompanyName, 1, 5)) = "INTER" Then
            Call ic()
        Else
            'Call other()
            CSC_Updation()
        End If
    End Sub
    Private Sub other()
        Dim SQLSTRING As String
        Dim POSLOCATION As String
        Dim POSITEMCODE, POSITEMUOM, INSERT(0) As String
        Dim AVGRATE, AVGQUANTITY, dblCalqty As Double
        Dim I, J, K As Integer
        POSLOCATION = Trim(txt_POS.Text)
        SQLSTRING = "SELECT KOTNO,KOTDETAILS,KOTDATE,ITEMCODE,ITEMDESC,UOM,QTY,RATE,AMOUNT,DELFLAG,"
        SQLSTRING = SQLSTRING & "ADDUSERID,ADDDATETIME,UPDUSERID,UPDDATETIME FROM KOT_DET "
        SQLSTRING = SQLSTRING & "WHERE ISNULL(KOTSTATUS,'N')='N' AND ISNULL(DELFLAG,'')<>'Y' AND POSCODE='" & POSLOCATION & "' "
        SQLSTRING = SQLSTRING & "AND CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(UOM,'') <> '' ORDER BY ITEMCODE"
        gconnection.getDataSet(SQLSTRING, "KOTDETAILS")
        If gdataset.Tables.Contains("KOTDETAILS") Then
            If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                SQLSTRING = "DELETE SUBSTORECONSUMPTIONDETAIL WHERE CAST(CONVERT(VARCHAR(11),DOCDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND STORELOCATIONCODE='" & (txt_POS.Text) & "'"
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SQLSTRING
                PBAR.Maximum = gdataset.Tables("KOTDETAILS").Rows.Count
                PBAR.Value = 0
                For I = 0 To gdataset.Tables("KOTDETAILS").Rows.Count - 1
                    SQLSTRING = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' AND ISNULL(FREEZE,'') <> 'Y'"
                    gconnection.getDataSet(SQLSTRING, "STOREMASTER1")
                    If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                        POSITEMCODE = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ITEMCODE"))
                        POSITEMUOM = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("UOM"))
                        SQLSTRING = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                        SQLSTRING = SQLSTRING & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y' GROUP BY GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID"
                        gconnection.getDataSet(SQLSTRING, "BOM")
                        If gdataset.Tables("BOM").Rows.Count > 0 Then

                            For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(POSLOCATION) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                'AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "")) ', Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORECODE")))
                                'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                SQLSTRING = SQLSTRING & AVGRATE & ","
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                'SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                'SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = SQLSTRING
                            Next K
                        Else
                            SQLSTRING = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                            SQLSTRING = SQLSTRING & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,1 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            SQLSTRING = SQLSTRING & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            SQLSTRING = SQLSTRING & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.SALEUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(SQLSTRING, "DIRECT_STOCK")
                            If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                                SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(POSLOCATION) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "',"
                                dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                SQLSTRING = SQLSTRING & dblCalqty & ","
                                'AVGRATE = CalAverageRate(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))
                                AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "")) ', Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORECODE")))
                                'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                SQLSTRING = SQLSTRING & AVGRATE & ","
                                SQLSTRING = SQLSTRING & dblCalqty * AVGRATE & ","
                                'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("UPDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = SQLSTRING
                            End If
                        End If
                    End If
                    PBAR.Value = PBAR.Value + 1
                Next
                gconnection.MoreTrans(INSERT)
            Else
                MsgBox("DATA NOT AVAILABLE FOR THE PARTICULAR DATE RANGE AND POS LOCATION", MsgBoxStyle.Critical)
            End If
        Else
            Exit Sub
        End If
        PBAR.Value = 0
    End Sub
    Private Sub ic()
        Dim clsqty As Double
        Dim SQLSTRING As String
        Dim POSLOCATION As String
        Dim POSITEMCODE, POSITEMUOM, INSERT(0) As String
        Dim AVGRATE, AVGQUANTITY, dblCalqty As Double
        Dim I, J, K As Integer
        POSLOCATION = Trim(txt_POS.Text)
        SQLSTRING = "SELECT KOTNO,KOTDETAILS,KOTDATE,ITEMCODE,ITEMDESC,UOM,QTY,RATE,AMOUNT,DELFLAG,"
        SQLSTRING = SQLSTRING & "ADDUSERID,ADDDATETIME,UPDUSERID,UPDDATETIME FROM KOT_DET "
        SQLSTRING = SQLSTRING & "WHERE ISNULL(KOTSTATUS,'N')='N' AND ISNULL(DELFLAG,'')<>'Y' AND POSCODE='" & POSLOCATION & "' "
        SQLSTRING = SQLSTRING & "AND CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(UOM,'') <> '' ORDER BY ITEMCODE"
        gconnection.getDataSet(SQLSTRING, "KOTDETAILS")
        If gdataset.Tables.Contains("KOTDETAILS") Then
            If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                SQLSTRING = "DELETE FROM SUBSTORECONSUMPTIONDETAIL WHERE CAST(CONVERT(VARCHAR(11),DOCDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND STORELOCATIONCODE='" & (txt_POS.Text) & "'"
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SQLSTRING
                gconnection.MoreTrans_womsg(INSERT)
                ReDim Preserve INSERT(INSERT(0))
                PBAR.Maximum = gdataset.Tables("KOTDETAILS").Rows.Count
                PBAR.Value = 0
                For I = 0 To gdataset.Tables("KOTDETAILS").Rows.Count - 1
                    SQLSTRING = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' --AND ISNULL(FREEZE,'') <> 'Y'"
                    gconnection.getDataSet(SQLSTRING, "STOREMASTER1")
                    If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                        POSITEMCODE = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ITEMCODE"))
                        POSITEMUOM = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("UOM"))
                        SQLSTRING = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                        SQLSTRING = SQLSTRING & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y' GROUP BY GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID"
                        gconnection.getDataSet(SQLSTRING, "BOM")
                        If gdataset.Tables("BOM").Rows.Count > 0 Then

                            For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                clsqty = ClosingQuantityup(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(txt_POS.Text))
                                If clsqty > dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) Then
                                    SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                    SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                    SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                    SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(POSLOCATION) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                    dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                    'AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                    AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "")) ', Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORECODE")))
                                    'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                    SQLSTRING = SQLSTRING & AVGRATE & ","
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                    'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                    SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                    'SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                    'SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                    SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                    SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                    ReDim Preserve INSERT(INSERT.Length)
                                    INSERT(INSERT.Length - 1) = SQLSTRING
                                    gconnection.MoreTrans_womsg(INSERT)
                                    ReDim Preserve INSERT(INSERT(0))
                                    Exit For
                                End If
                            Next K
                        Else
                            SQLSTRING = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                            SQLSTRING = SQLSTRING & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,1 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            SQLSTRING = SQLSTRING & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            SQLSTRING = SQLSTRING & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.SALEUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(SQLSTRING, "DIRECT_STOCK")
                            If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                                SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(POSLOCATION) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "',"
                                dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                SQLSTRING = SQLSTRING & dblCalqty & ","
                                'AVGRATE = CalAverageRate(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))
                                AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "")) ', Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORECODE")))
                                'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                SQLSTRING = SQLSTRING & AVGRATE & ","
                                SQLSTRING = SQLSTRING & dblCalqty * AVGRATE & ","
                                'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("UPDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = SQLSTRING
                                gconnection.MoreTrans_womsg(INSERT)
                                ReDim Preserve INSERT(INSERT(0))
                            End If
                        End If
                    End If
                    PBAR.Value = PBAR.Value + 1
                Next
                MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'gconnection.MoreTrans(INSERT)
            Else
                MsgBox("DATA NOT AVAILABLE FOR THE PARTICULAR DATE RANGE AND POS LOCATION", MsgBoxStyle.Critical)
            End If
        Else
            Exit Sub
        End If
        PBAR.Value = 0
    End Sub
    Private Sub CSC_Updation()
        Dim SQLSTRING As String
        Dim POSLOCATION As String
        Dim POSITEMCODE, POSITEMUOM, INSERT(0) As String
        Dim AVGRATE, AVGQUANTITY, dblCalqty, PL As Double
        Dim I, J, K As Integer
        Dim clsqty As Double

        POSLOCATION = Trim(txt_POS.Text)
        'SQLSTRING = "SELECT STORECODE FROM POSITEMSTORELINK WHERE POS='" & Trim(POSLOCATION) & "'"
        'gconnection.getDataSet(SQLSTRING, "SUBSTORE")
        'If gdataset.Tables("SUBSTORE").Rows.Count > 0 Then

        'Call CALC_WEIGHTED(Trim(gdataset.Tables("SUBSTORE").Rows(0).Item("STORECODE") & ""))
        'Else
        'Call CALC_WEIGHTED()
        'End If

        SQLSTRING = "SELECT KOTNO,KOTDETAILS,KOTDATE,ITEMCODE,ITEMDESC,UOM,QTY,RATE,AMOUNT,DELFLAG,"
        SQLSTRING = SQLSTRING & "ADDUSERID,ADDDATETIME,UPDUSERID,UPDDATETIME FROM KOT_DET "
        SQLSTRING = SQLSTRING & "WHERE ISNULL(KOTSTATUS,'N') in ('N','B') AND ISNULL(DELFLAG,'')<>'Y' AND POSCODE IN (SELECT POS FROM POSITEMSTORELINK WHERE STORECODE='" & POSLOCATION & "' GROUP BY POS)"
        ''SQLSTRING = SQLSTRING & "AND CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(UOM,'') <> '' AND ITEMCODE IN ('613','613A','613SN','613DR','444')  ORDER BY ITEMCODE,KOTDATE"
        SQLSTRING = SQLSTRING & "AND CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(UOM,'') <> '' ORDER BY ITEMCODE,KOTDATE"
        gconnection.getDataSet(SQLSTRING, "KOTDETAILS")
        If gdataset.Tables.Contains("KOTDETAILS") Then
            If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                'SQLSTRING = "DELETE SUBSTORECONSUMPTIONDETAIL WHERE CAST(CONVERT(VARCHAR(11),DOCDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND STORELOCATIONCODE='" & (txt_POS.Text) & "'  AND Itemcode IN ('613','10670') "
                SQLSTRING = "DELETE SUBSTORECONSUMPTIONDETAIL WHERE CAST(CONVERT(VARCHAR(11),DOCDATE,6) AS DATETIME) BETWEEN '" & Format(dtp_FROMdate.Value, "dd-MMM-yyyy") & "' AND '" & Format(dtp_TOdate.Value, "dd-MMM-yyyy") & "' AND STORELOCATIONCODE='" & (txt_POS.Text) & "'   "
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SQLSTRING
                PBAR.Maximum = gdataset.Tables("KOTDETAILS").Rows.Count
                PBAR.Value = 0
                For I = 0 To gdataset.Tables("KOTDETAILS").Rows.Count - 1
                    SQLSTRING = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' AND ISNULL(FREEZE,'') <> 'Y'"
                    gconnection.getDataSet(SQLSTRING, "STOREMASTER1")
                    If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                        POSITEMCODE = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ITEMCODE"))
                        POSITEMUOM = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("UOM"))
                        dblCalqty = Val(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))

                        Dim SUBSTORECODE As String

                        SQLSTRING = "SELECT STORECODE FROM POSITEMSTORELINK WHERE POS='" & Trim(POSLOCATION) & "' AND ITEMCODE='" & POSITEMCODE & "'"
                        gconnection.getDataSet(SQLSTRING, "SUBSTORE")
                        If gdataset.Tables("SUBSTORE").Rows.Count > 0 Then
                            SUBSTORECODE = Trim(gdataset.Tables("SUBSTORE").Rows(0).Item("STORECODE") & "")
                        Else
                            SUBSTORECODE = POSLOCATION
                        End If

                        If POSITEMCODE = "01ZRU13P" Or POSITEMCODE = "01RU13P" Then
                            PL = 0
                        End If
                      
                        SQLSTRING = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID,Isnull(CockTail,'N') As CockTail FROM BOM_DET WHERE"
                        SQLSTRING = SQLSTRING & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y' GROUP BY GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID,Isnull(CockTail,'N')"
                        gconnection.getDataSet(SQLSTRING, "BOM")
                        If gdataset.Tables("BOM").Rows.Count > 0 Then
                            If UCase(Trim(POSITEMUOM)) <> "BOT" Then
                                For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                    If Trim(gdataset.Tables("BOM").Rows(K).Item("CockTail") & "") <> "Y" And gdataset.Tables("BOM").Rows.Count = 1 Then
                                        clsqty = ClosingQuantity(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(SUBSTORECODE))
                                        SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                        SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                        SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                        SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                        dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                        AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                        SQLSTRING = SQLSTRING & AVGRATE & ","
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                        'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                        SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                        SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                        SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                        ReDim Preserve INSERT(INSERT.Length)
                                        INSERT(INSERT.Length - 1) = SQLSTRING
                                        gconnection.MoreTrans_womsg(INSERT)
                                        ReDim Preserve INSERT(INSERT(0))

                                    ElseIf Trim(gdataset.Tables("BOM").Rows(K).Item("CockTail") & "") <> "Y" And gdataset.Tables("BOM").Rows.Count > 1 Then
                                        clsqty = ClosingQuantity(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(SUBSTORECODE))
                                        If clsqty > dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) Then
                                            SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                            SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                            SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                            SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                            SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                            dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                            SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                            AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                            SQLSTRING = SQLSTRING & AVGRATE & ","
                                            SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                            'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                            SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                            SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                            SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                            SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                            SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                            ReDim Preserve INSERT(INSERT.Length)
                                            INSERT(INSERT.Length - 1) = SQLSTRING
                                            gconnection.MoreTrans_womsg(INSERT)
                                            ReDim Preserve INSERT(INSERT(0))
                                            Exit For
                                        Else
                                            If gdataset.Tables("BOM").Rows.Count <> K + 1 Then
                                                GoTo ContinueK
                                            Else
                                                clsqty = ClosingQuantity(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(SUBSTORECODE))
                                                SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                                SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                                SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                                SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                                SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                                dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                                AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                                SQLSTRING = SQLSTRING & AVGRATE & ","
                                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                                'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                                SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                                SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                                SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                                ReDim Preserve INSERT(INSERT.Length)
                                                INSERT(INSERT.Length - 1) = SQLSTRING
                                                gconnection.MoreTrans_womsg(INSERT)
                                                ReDim Preserve INSERT(INSERT(0))
                                                Exit For
                                            End If
                                        End If
                                    Else
                                        clsqty = ClosingQuantity(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(SUBSTORECODE))
                                        SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                        SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                        SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                        SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                        dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                        AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                        SQLSTRING = SQLSTRING & AVGRATE & ","
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                        'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                        SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                        SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                        SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                        SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                        SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                                        ReDim Preserve INSERT(INSERT.Length)
                                        INSERT(INSERT.Length - 1) = SQLSTRING
                                        gconnection.MoreTrans_womsg(INSERT)
                                        ReDim Preserve INSERT(INSERT(0))
                                    End If
ContinueK:                      Next K
                            Else
                                For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                    'clsqty = ClosingQuantity(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE")), Trim(SUBSTORECODE))
                                    SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                    SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                    SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                    SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                    dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                    AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                    'AVGRATE = CalAverageRate_new_Updated(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""), Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy"), Trim(SUBSTORECODE & "")) ', Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORECODE")))
                                    '''AVGRATE = Weighted_Rate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE")), Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""), txt_POS.Text)
                                    'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                    SQLSTRING = SQLSTRING & AVGRATE & ","
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                    'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                    SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                    SQLSTRING = SQLSTRING & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                    SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                    'SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                    'SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                    SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                                    SQLSTRING = SQLSTRING & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"

                                    ReDim Preserve INSERT(INSERT.Length)
                                    INSERT(INSERT.Length - 1) = SQLSTRING
                                    gconnection.MoreTrans_womsg(INSERT)
                                    ReDim Preserve INSERT(INSERT(0))
                                Next K
                            End If
                        Else
                            SQLSTRING = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                            SQLSTRING = SQLSTRING & " ISNULL(I.DOUBLEUOM,'') AS CONVUOM,1 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                            SQLSTRING = SQLSTRING & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                            SQLSTRING = SQLSTRING & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.SALEUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y' AND I.STORECODE='" & SUBSTORECODE & "'"
                            gconnection.getDataSet(SQLSTRING, "DIRECT_STOCK")
                            If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then

                                SQLSTRING = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                SQLSTRING = SQLSTRING & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                SQLSTRING = SQLSTRING & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTNO")) & "','" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDETAILS")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(SUBSTORECODE) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(STORELOCATION(SUBSTORECODE)) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "',"
                                dblCalqty = Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("QTY"))
                                SQLSTRING = SQLSTRING & dblCalqty & ","
                                '''''AVGRATE = CalAverageRatenew(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))

                                'AVGRATE = CalAverageRate_new_Updated(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""), Format(CDate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE"))), "dd-MMM-yyyy"), Trim(SUBSTORECODE & "")) ', Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORECODE")))

                                '''AVGRATE = Weighted_Rate(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("KOTDATE")), Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""), txt_POS.Text)

                                ''''AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "")) ', Trim(gdataset.Tables("STOREMASTER1").Rows(0).Item("STORECODE")))
                                'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                SQLSTRING = SQLSTRING & AVGRATE & ","
                                SQLSTRING = SQLSTRING & dblCalqty * AVGRATE & ","
                                'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                SQLSTRING = SQLSTRING & dblCalqty * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("DELFLAG")) & "'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                SQLSTRING = SQLSTRING & " '" & Trim(Trim(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDUSERID"))) & "','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("ADDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "',"
                                SQLSTRING = SQLSTRING & " ' ','" & Format(gdataset.Tables("KOTDETAILS").Rows(I).Item("UPDDATETIME"), "dd-MMM-yyyy hh:mm:ss") & "')"
                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = SQLSTRING
                                gconnection.MoreTrans_womsg(INSERT)
                                ReDim Preserve INSERT(INSERT(0))
                            End If
                        End If
                    End If
                    PBAR.Value = PBAR.Value + 1
                Next
                MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'gconnection.MoreTrans(INSERT)
            Else
                MsgBox("DATA NOT AVAILABLE FOR THE PARTICULAR DATE RANGE AND POS LOCATION", MsgBoxStyle.Critical)
            End If
        Else
            Exit Sub
        End If
        PBAR.Value = 0
    End Sub
    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
    Public Function STORELOCATION(ByVal STORECODE As String) As String
        Dim sqlstring, STRLOCATION As String
        sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & STORECODE & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            STRLOCATION = (gdataset.Tables("STOREMASTER").Rows(0).Item("STOREDESC") & "")
        End If
        Return STRLOCATION
    End Function

    Private Sub dtp_FROMdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FROMdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                dtp_TOdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grn Date Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub dtp_TOdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_TOdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Cmd_UPDATE.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grn Date Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class
