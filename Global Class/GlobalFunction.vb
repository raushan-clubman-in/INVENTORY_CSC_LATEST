Imports System.Text.RegularExpressions
Imports System.IO
Module GlobalFunction
    Dim regexp As Regex
    Dim gconnection As New GlobalClass
    Public boolexp As Boolean = False
    Public boolexp1 As Boolean = False
    Public boolexp2 As Boolean = False


    Public Function check_VendorType(ByVal Vendor As String) As Boolean
        Dim sqlstring As String
        Dim dt
        sqlstring = " select * from accountssubledgermaster where sltype='supplier' and slcode='" & Vendor & "' and VENDORTYPE like '%com%'"
        gconnection.getDataSet(sqlstring, "spl")
        If gdataset.Tables("spl").Rows.Count > 0 Then
            dt = True
        Else
            dt = False
        End If
        Return dt

    End Function

    '*******************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Numeric
    'Function Name:getNumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*******************************************************************
    Public Sub getNumeric(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    Public Sub getPositiveNumeric(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.Handled) <> 46 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ' MsgBox("Only numeric values are allowed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Mobile No.")
            End If
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getAlphanumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getAlphanumeric(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    Public Sub Blank(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        If Asc(b.KeyChar) > 0 And Asc(b.KeyChar) < 225 Then
            b.Handled = True
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Charater
    'Function Name:getCharater
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getCharater(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getEmail
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getEmail(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp1 As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            boolexp1 = True
            txtbox.ForeColor = Color.Black
        Else
            MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp1 = False
            Exit Sub
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPincode
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPincode(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\d{5}(-\d{4})?$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Pincode field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPhoneno
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPhoneno(ByVal txtbox As System.Windows.Forms.TextBox)
        If regexp.IsMatch(txtbox.Text, "^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Phoneno field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If
    End Sub
    '************************************************************
    'Purpose: To Clear all the textBox control,within a group Box
    'Function Name: clearPanel
    'Input Type: panel 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub clearform(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next ctrl
    End Sub


    Public Sub clearform1(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls

            If TypeOf ctrl Is TextBox Then
                ctrl.Text = 0
            End If


            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next ctrl
    End Sub
    '************************************************************
    'Purpose: To Open the text file
    'Function Name: OpenTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub OpenTextFile(ByVal VOutputfile As String)
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            If Dir(AppPath & "\Wordpad.exe") <> "" Then
                Shell(AppPath & "\Wordpad.exe " & AppPath & "\Reports\" & VOutputfile & ".txt", vbMaximizedFocus)
            Else
                MessageBox.Show("Wordpad.Exe Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: PrintTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub PrintTextFile(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(Trim(VOutputfile & "")) <> "" Then
            VOutputfile = Mid(VOutputfile, 1, VOutputfile.Length - 4)
            Filewrite = File.AppendText(VOutputfile & ".bat")
            If computername = "" Or Printername = "" Then
                Filewrite.WriteLine("Type " & VOutputfile & ".txt >> prn")
            Else
                Filewrite.WriteLine("Type " & VOutputfile & ".txt > \\" & computername & "\" & Printername)
            End If
            Filewrite.Close()
            Call Shell(VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: Checkdaterangevalidate
    'Input Type: Startingdate,Endingdate 
    'Return Type:Boolean
    'Author:Prasant
    'Date:30/08/2006
    '************************************************************
    Public Function Checkdaterangevalidate(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Enddate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If
        If DateDiff(DateInterval.Day, Startdate, Enddate) < 0 Then
            MessageBox.Show("From Date cannot be greater than To Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If
        If CDate(Startdate) >= CDate(Startdate) And CDate(Enddate) <= CDate(Enddate) Then
            chkdatevalidate = True
        Else
            MsgBox("Date should be within Financial Year", MsgBoxStyle.Critical)
            chkdatevalidate = False
            Exit Function
        End If
        Return chkdatevalidate
    End Function
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: Checkdatevalidate
    'Input Type: Startingdate 
    'Return Type:Boolean
    'Author:Prasant
    'Date:30/08/2006
    '************************************************************
    Public Function Checkdatevalidate(ByVal Startdate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Startdate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            'Exit Function
        End If
        If FyearDateCheck(Startdate) = False Then
            chkdatevalidate = False
            MessageBox.Show("Date should be within the Financial year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            'Exit Function
        End If
        'If (DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)) < 0) Or (DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate) < 0) Then
        '    MsgBox(DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)))
        '    MsgBox(DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate))
        '    MessageBox.Show("Date should be within the Financial year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    chkdatevalidate = False
        '    Exit Function
        'End If
        Return chkdatevalidate
    End Function
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: PrintTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Shuvendu
    'Date:30/08/2006
    '************************************************************
    Public Function FyearDateCheck(ByVal Vdate As String) As Boolean
        FyearDateCheck = True
        Dim StartDate As String
        Dim EndDate As String
        StartDate = "01-APR-" & gFinancalyearStart
        EndDate = "31-MAR-" & gFinancialyearEnd
        If CDate(Vdate) >= CDate(StartDate) And CDate(Vdate) <= CDate(EndDate) Then
            FyearDateCheck = True
        Else
            FyearDateCheck = False
        End If
    End Function
    Public Function CalAverageRate_new(ByVal ITEMCODE As String, ByVal FROMDATE As Date, ByVal STORECODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Clquantity, Clamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'  AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        '''********************************* FETCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(isnull(AMOUNT,0)),0)+ISNULL(SUM(isnull(TAXAMOUNT,0)),0)+ISNULL(SUM(isnull(OTHCHARGE,0)),0)-ISNULL(SUM(isnull(DISCOUNT,0)),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y' AND GRNDATE<='" & Format(FROMDATE, "dd/MMM/yyyy") & "'   AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS1")
        If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS1").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        Clsquantity = (Val(Opquantity) + Val(Grnquantity))


        '------------------------------------------
        'itemmaster
        sqlstring = " SELECT ISNULL(SUM(ISNULL(OPSTOCK,0)),0) AS OPSTOCK , ISNULL(SUM(ISNULL(OPVALUE,0)),0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE ='" & Trim(ITEMCODE) & "'  AND STORECODE ='" & Trim(STORECODE) & "' "
        gconnection.getDataSet(sqlstring, "INVENTORYITEM_CLS")
        If gdataset.Tables("INVENTORYITEM_CLS").Rows.Count > 0 Then
            Clquantity = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPSTOCK")), "0.000")
            Clamount = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Clquantity = 0
            Clamount = 0
        End If
        'grndetails
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) AS QTY, ISNULL(SUM(isnull(AMOUNT,0)),0)+ISNULL(SUM(isnull(TAXAMOUNT,0)),0)+ISNULL(SUM(isnull(OTHCHARGE,0)),0)-ISNULL(SUM(isnull(DISCOUNT,0)),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "'  AND ISNULL(VOIDITEM,'') <> 'Y'  and storecode='" & Trim(STORECODE) & "' and grndate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "GRN_DETAILS_CLS")
        If gdataset.Tables("GRN_DETAILS_cls").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKISSUE DETAILS +
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND opstorelocationcode='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockIssueDetails")
        If gdataset.Tables("StockIssueDetails").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKISSUE DETAILS -
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND storelocationcode='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockIssueDetails1")
        If gdataset.Tables("StockIssueDetails1").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKTRANS +
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY , ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKTRANSFERDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND  TOSTORECODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockTransfer")
        If gdataset.Tables("StockTransfer").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKTRANS -
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY , ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKTRANSFERDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND  FROMSTORECODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockTransfer1")
        If gdataset.Tables("StockTransfer1").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKADJUSTMENT
        sqlstring = " SELECT ISNULL(SUM(ISNULL(ADJUSTEDSTOCK,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKADJUSTDETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND STORELOCATIONCODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockAdjust")
        If gdataset.Tables("StockAdjust").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'SUBSTORECONSUMPTION
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM SUBSTORECONSUMPTIONDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND STORELOCATIONCODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "SubstoreConsumption")
        If gdataset.Tables("SubstoreConsumption").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("AMOUNT")), "0.00")
        End If
        '------------------------------------------

        If Clquantity > 0 Then
            Calrate = Val(Clamount) / Val(Clquantity)
        Else
            If Clsquantity = 0 Then
                sqlstring = "SELECT ISNULL(PURCHASERATE,0) PURCHASERATE FROM INVENTORYITEMMASTER WHERE storecode='mns' and ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("PURCHASERATE")), "0.00")
                End If
            Else
                Calrate = (Val(Opamount) + Val(Grnamount)) / (Val(Clsquantity))
            End If
        End If

        Return Calrate
    End Function

    Public Function CalAverageRate_new_Updated(ByVal ITEMCODE As String, ByVal FROMDATE As Date, ByVal STORECODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Clquantity, Clamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        Dim Count As Integer
        Dim UpOpQty, UpOpVal, UpGrnQty, UpGrnVal, UpIssQty, UpIssVal, UpTrnQty, UpTrnVal, UpAdjQty, UpAdjVal, UpComQty, UpComVal As Double
        Dim UpOpRate, UpGrnRate, UpIssRate, UpTrnRate, UpAdjRate, UpComRate As Double
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'  AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        '''********************************* FETCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(isnull(AMOUNT,0)),0)+ISNULL(SUM(isnull(TAXAMOUNT,0)),0)+ISNULL(SUM(isnull(OTHCHARGE,0)),0)-ISNULL(SUM(isnull(DISCOUNT,0)),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y' AND GRNDATE<='" & Format(FROMDATE, "dd/MMM/yyyy") & "'   AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS1")
        If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS1").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        Clsquantity = (Val(Opquantity) + Val(Grnquantity))


        '------------------------------------------
        'itemmaster
        sqlstring = " SELECT ISNULL(SUM(ISNULL(OPSTOCK,0)),0) AS OPSTOCK , ISNULL(SUM(ISNULL(OPVALUE,0)),0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE ='" & Trim(ITEMCODE) & "'  AND STORECODE ='" & Trim(STORECODE) & "' "
        gconnection.getDataSet(sqlstring, "INVENTORYITEM_CLS")
        If gdataset.Tables("INVENTORYITEM_CLS").Rows.Count > 0 Then
            Clquantity = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPSTOCK")), "0.000")
            Clamount = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPVALUE")), "0.00")
            UpOpQty = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPSTOCK")), "0.000")
            UpOpVal = Format(Val(gdataset.Tables("INVENTORYITEM_CLS").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Clquantity = 0
            Clamount = 0
        End If
        'grndetails
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) AS QTY, ISNULL(SUM(isnull(AMOUNT,0)),0)+ISNULL(SUM(isnull(TAXAMOUNT,0)),0)+ISNULL(SUM(isnull(OTHCHARGE,0)),0)-ISNULL(SUM(isnull(DISCOUNT,0)),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "'  AND ISNULL(VOIDITEM,'') <> 'Y'  and storecode='" & Trim(STORECODE) & "' and grndate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "GRN_DETAILS_CLS")
        If gdataset.Tables("GRN_DETAILS_cls").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("AMOUNT")), "0.00")
            UpGrnQty = Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("QTY")), "0.000")
            UpGrnVal = Format(Val(gdataset.Tables("GRN_DETAILS_cls").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKISSUE DETAILS +
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND opstorelocationcode='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockIssueDetails")
        If gdataset.Tables("StockIssueDetails").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("AMOUNT")), "0.00")
            UpIssQty = UpIssQty + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("QTY")), "0.000")
            UpIssVal = UpIssVal + Format(Val(gdataset.Tables("StockIssueDetails").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKISSUE DETAILS -
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND storelocationcode='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockIssueDetails1")
        If gdataset.Tables("StockIssueDetails1").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("AMOUNT")), "0.00")
            UpIssQty = UpIssQty + Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("QTY")), "0.000")
            UpIssVal = UpIssVal + Format(Val(gdataset.Tables("StockIssueDetails1").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKTRANS +
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY , ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKTRANSFERDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND  TOSTORECODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockTransfer")
        If gdataset.Tables("StockTransfer").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("AMOUNT")), "0.00")
            UpTrnQty = UpTrnQty + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("QTY")), "0.000")
            UpTrnVal = UpTrnVal + Format(Val(gdataset.Tables("StockTransfer").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKTRANS -
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY , ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKTRANSFERDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND  FROMSTORECODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockTransfer1")
        If gdataset.Tables("StockTransfer1").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("AMOUNT")), "0.00")
            UpTrnQty = UpTrnQty + Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("QTY")), "0.000")
            UpTrnVal = UpTrnVal + Format(Val(gdataset.Tables("StockTransfer1").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'STOCKADJUSTMENT
        sqlstring = " SELECT ISNULL(SUM(ISNULL(ADJUSTEDSTOCK,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM STOCKADJUSTDETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND STORELOCATIONCODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "StockAdjust")
        If gdataset.Tables("StockAdjust").Rows.Count > 0 Then
            Clquantity = Clquantity + Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount + Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("AMOUNT")), "0.00")
            UpAdjQty = Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("QTY")), "0.000")
            UpAdjVal = Format(Val(gdataset.Tables("StockAdjust").Rows(0).Item("AMOUNT")), "0.00")
        End If

        'SUBSTORECONSUMPTION
        sqlstring = " SELECT ISNULL(SUM(ISNULL(QTY,0)),0) QTY, ISNULL(SUM(ISNULL(AMOUNT,0)),0) AMOUNT FROM SUBSTORECONSUMPTIONDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'') <> 'Y' AND STORELOCATIONCODE='" & Trim(STORECODE) & "' and docdate<='" & Format(FROMDATE, "dd/MMM/yyyy") & "' "
        gconnection.getDataSet(sqlstring, "SubstoreConsumption")
        If gdataset.Tables("SubstoreConsumption").Rows.Count > 0 Then
            Clquantity = Clquantity - Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("QTY")), "0.000")
            Clamount = Clamount - Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("AMOUNT")), "0.00")
            UpComQty = Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("QTY")), "0.000")
            UpComVal = Format(Val(gdataset.Tables("SubstoreConsumption").Rows(0).Item("AMOUNT")), "0.00")
        End If
        '------------------------------------------

        If Clquantity > 0 Then
            Calrate = Val(Clamount) / Val(Clquantity)
        Else
            If Clsquantity = 0 Then
                sqlstring = "SELECT ISNULL(PURCHASERATE,0) PURCHASERATE FROM INVENTORYITEMMASTER WHERE storecode='mns' and ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("PURCHASERATE")), "0.00")
                End If
            Else
                Calrate = (Val(Opamount) + Val(Grnamount)) / (Val(Clsquantity))
            End If
        End If

        UpOpRate = Format((UpOpVal / UpOpQty), "0.00")
        UpGrnRate = Format((UpGrnVal / UpGrnQty), "0.00")
        UpIssRate = Format((UpIssVal / UpIssQty), "0.00")
        UpTrnRate = Format((UpTrnVal / UpTrnQty), "0.00")
        UpAdjRate = Format((UpAdjVal / UpAdjQty), "0.00")
        UpComRate = Format((UpComVal / UpComQty), "0.00")
        Count = 0
        If UpOpRate > 0 Then
            Count = Count + 1
        Else
            UpOpRate = 0
        End If
        If UpGrnRate > 0 Then
            Count = Count + 1
        Else
            UpGrnRate = 0
        End If
        If UpIssRate > 0 Then
            Count = Count + 1
        Else
            UpIssRate = 0
        End If
        If UpTrnRate > 0 Then
            Count = Count + 1
        Else
            UpTrnRate = 0
        End If
        If UpAdjRate > 0 Then
            Count = Count + 1
        Else
            UpAdjRate = 0
        End If
        If UpComRate > 0 Then
            Count = Count + 1
        Else
            UpComRate = 0
        End If
        Calrate = Val((UpOpRate + UpGrnRate + UpIssRate + UpTrnRate + UpAdjRate + UpComRate) / Count)

        Return Calrate
    End Function

    Public Function CalAverageRate(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'" ' AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        '''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        '' ********************************* CALCULATE CLOSING BALANCE *********************************'''
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        If Clsquantity = 0 Then
            If Grnquantity <> 0 Then
                Calrate = Val(Grnamount) / Val(Grnquantity)
                'Else
                '    Calrate = 0
                'End If
                'TO CORRECT THE PROBLEM IN CALCULATING WEIGHTED AVERAGE RATE
            ElseIf Issuequantity <> 0 Then
                sqlstring = "SELECT TOP 1 ISNULL(RATE,0) RATE FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("RATE")), "0.00")
                End If
            Else
                sqlstring = "SELECT ISNULL(PURCHASERATE,0) PURCHASERATE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("PURCHASERATE")), "0.00")
                End If
            End If
            '***********************************************(
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        Return Calrate
    End Function
    Public Function CalAverageQuantity(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        ''''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        ''' ********************************* CALCULATE CLOSING BALANCE *********************************'''
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        If Clsquantity = 0 Then
            Calrate = Val(Grnamount) / Val(Grnquantity)
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        Return Clsquantity
    End Function
    Public Function ClosingQuantity_New(ByVal ITEMCODE As String, ByVal STORECODE As String, ByVal GrnDate As Date) As Double
        Try
            Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty, ConsumedQty As Double
            Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty, PURCHASERATE As Double
            Dim sqlstring As String
            Dim i As Integer
            '''*************************************** CALCULATION OF CLOSING QUANTITY FOR A PARTICULAR ITEM ***********************'''
            sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                If Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORESTATUS")) = "M" Then
                    ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
                    sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y' AND STORECODE = '" & Trim(STORECODE) & "'"
                    gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                    If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                        OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
                    Else
                        OpQty = 0
                    End If
                    ''''********************************* FETCH FROM GRN_DETAILS ********************************************'''
                    sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND GRNDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOIDITEM,'') <>'Y'"
                    gconnection.getDataSet(sqlstring, "GRN_DETAILS1")
                    If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
                        GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")), "0.000")
                    Else
                        GrnQty = 0
                    End If
                Else
                    sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y' AND STORECODE='" & Trim(STORECODE) & "'"
                    gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                    If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                        OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
                    Else
                        OpQty = 0
                    End If
                End If

                ''''********************************* FROM STOCK RETURN *****************************************'''
                'sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
                'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND ISNULL(DOCTYPE,'')  = 'RET' AND ISNULL(VOID,'')<>'Y'"
                'gconnection.getDataSet(sqlstring, "STOCKRETURNDETAILS")
                'If gdataset.Tables("STOCKRETURNDETAILS").Rows.Count > 0 Then
                '    ReturnQty = Format(Val(gdataset.Tables("STOCKRETURNDETAILS").Rows(0).Item("QTY")), "0.000")
                'Else
                '    ReturnQty = 0
                'End If
                '==========================      
                MainstockQty = GrnQty + OpQty
            End If

            ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
            sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL1")
            If gdataset.Tables("STOCKISSUEDETAIL1").Rows.Count > 0 Then
                IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL1").Rows(0).Item("QTY")), "0.000")
            Else
                IssueFromQty = 0
            End If
            sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL1")
            If gdataset.Tables("STOCKISSUEDETAIL1").Rows.Count > 0 Then
                IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL1").Rows(0).Item("QTY")), "0.000")
            Else
                IssueToQty = 0
            End If
            IssueQty = IssueToQty - IssueFromQty
            ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
            sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS1")
            If gdataset.Tables("STOCKADJUSTDETAILS1").Rows.Count > 0 Then
                AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS1").Rows(0).Item("QTY")), "0.000")
            Else
                AdjustQty = 0
            End If
            '''********************************* FROM STOCK TRANSFER *****************************************'''
            sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
            If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
                TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
            Else
                TransFromQty = 0
            End If
            sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
            If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
                TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
            Else
                TransToQty = 0
            End If
            TransQty = TransToQty - TransFromQty
            sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM SUBSTORECONSUMPTIONDETAIL "
            sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND DOCDATE<='" & Format(GrnDate, "dd MMM yyyy") & "'  AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "STORECONSUMPTIONDETAILS")
            If gdataset.Tables("STORECONSUMPTIONDETAILS").Rows.Count > 0 Then
                ConsumedQty = Format(Val(gdataset.Tables("STORECONSUMPTIONDETAILS").Rows(0).Item("QTY")), "0.000")
            Else
                ConsumedQty = 0
            End If
            ''' ********************************* CALCULATE CLOSING QUANTITY *********************************'''
            sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER1")
            If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                If Trim(gdataset.Tables("STOREMASTER1").Rows(i).Item("STORESTATUS")) = "M" Then
                    ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty)
                Else
                    ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty - Val(ConsumedQty))
                End If
            End If
            'ClsQty = Format((Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty) - Val(ConsumedQty), "0.000")
            '''********************************** COMPLETE CALCULATION QUANTITY ******************************'''
            Return ClsQty
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    'Public Function ClosingQuantity(ByVal ITEMCODE As String, ByVal STORECODE As String) As Double
    '    Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty As Double
    '    Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty As Double
    '    Dim sqlstring As String
    '    Dim i As Integer
    '    '''*************************************** CALCULATION OF CLOSING QUANTITY FOR A PARTICULAR ITEM ***********************'''
    '    sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
    '    gconnection.getDataSet(sqlstring, "STOREMASTER")
    '    If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
    '        If Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORESTATUS")) = "M" Then
    '            ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
    '            sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
    '            gconnection.getDataSet(sqlstring, "INVENTORYITEM")
    '            If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
    '                OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
    '            Else
    '                OpQty = 0
    '            End If
    '            ''''********************************* FETCH FROM GRN_DETAILS ********************************************'''
    '            sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
    '            gconnection.getDataSet(sqlstring, "GRN_DETAILS")
    '            If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
    '                GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
    '            Else
    '                GrnQty = 0
    '            End If
    '        End If
    '        ''''********************************* FROM STOCK RETURN *****************************************'''
    '        'sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
    '        'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND ISNULL(DOCTYPE,'')  = 'RET' AND ISNULL(VOID,'')<>'Y'"
    '        'gconnection.getDataSet(sqlstring, "STOCKRETURNDETAILS")
    '        'If gdataset.Tables("STOCKRETURNDETAILS").Rows.Count > 0 Then
    '        '    ReturnQty = Format(Val(gdataset.Tables("STOCKRETURNDETAILS").Rows(0).Item("QTY")), "0.000")
    '        'Else
    '        '    ReturnQty = 0
    '        'End If
    '        '==========================      
    '        MainstockQty = GrnQty + OpQty
    '    End If

    '    ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
    '    sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
    '    sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
    '    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
    '    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
    '        IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
    '    Else
    '        IssueFromQty = 0
    '    End If
    '    sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
    '    sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
    '    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
    '    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
    '        IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
    '    Else
    '        IssueToQty = 0
    '    End If
    '    IssueQty = IssueToQty - IssueFromQty
    '    ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
    '    sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
    '    sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
    '    gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS")
    '    If gdataset.Tables("STOCKADJUSTDETAILS").Rows.Count > 0 Then
    '        AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS").Rows(0).Item("QTY")), "0.000")
    '    Else
    '        AdjustQty = 0
    '    End If
    '    '''********************************* FROM STOCK TRANSFER *****************************************'''
    '    sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
    '    sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
    '    gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS")
    '    If gdataset.Tables("STOCKTRANSDETAILS").Rows.Count > 0 Then
    '        TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS").Rows(0).Item("QTY")), "0.000")
    '    Else
    '        TransFromQty = 0
    '    End If
    '    sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
    '    sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
    '    gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
    '    If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
    '        TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
    '    Else
    '        TransToQty = 0
    '    End If
    '    TransQty = TransToQty - TransFromQty
    '    ''' ********************************* CALCULATE CLOSING QUANTITY *********************************'''
    '    sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
    '    gconnection.getDataSet(sqlstring, "STOREMASTER")
    '    If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
    '        If Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORESTATUS")) = "M" Then
    '            ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty)
    '        Else
    '            ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty)
    '        End If
    '    End If

    '    '''********************************** COMPLETE CALCULATION QUANTITY ******************************'''
    '    Return ClsQty
    'End Function

    Public Function ClosingQuantity(ByVal ITEMCODE As String, ByVal STORECODE As String) As Double
        Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty As Double
        Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty, ConsumedQty As Double
        Dim sqlstring As String
        Dim i As Integer
        sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y' AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
        Else
            OpQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'  AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            GrnQty = 0
        End If
        MainstockQty = GrnQty + OpQty
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueFromQty = 0
        End If

        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueToQty = 0
        End If
        IssueQty = IssueToQty - IssueFromQty

        ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS")
        If gdataset.Tables("STOCKADJUSTDETAILS").Rows.Count > 0 Then
            AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            AdjustQty = 0
        End If
        '''********************************* FROM STOCK TRANSFER *****************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS")
        If gdataset.Tables("STOCKTRANSDETAILS").Rows.Count > 0 Then
            TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            TransFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
        If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
            TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
        Else
            TransToQty = 0
        End If
        TransQty = TransToQty - TransFromQty
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM SUBSTORECONSUMPTIONDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STORECONSUMPTIONDETAILS")
        If gdataset.Tables("STORECONSUMPTIONDETAILS").Rows.Count > 0 Then
            ConsumedQty = Format(Val(gdataset.Tables("STORECONSUMPTIONDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            ConsumedQty = 0
        End If
        ClsQty = Format((Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty) - Val(ConsumedQty), "0.000")

        Return ClsQty
    End Function
    Public Function ClosingQuantityup(ByVal ITEMCODE As String, ByVal STORECODE As String) As Double
        Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty As Double
        Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty, ConsumedQty As Double
        Dim sqlstring As String
        Dim i As Integer
        sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y' AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
        Else
            OpQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'  AND STORECODE='" & Trim(STORECODE) & "'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            GrnQty = 0
        End If
        MainstockQty = GrnQty + OpQty
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueFromQty = 0
        End If

        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueToQty = 0
        End If
        IssueQty = IssueToQty - IssueFromQty

        ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS")
        If gdataset.Tables("STOCKADJUSTDETAILS").Rows.Count > 0 Then
            AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            AdjustQty = 0
        End If
        '''********************************* FROM STOCK TRANSFER *****************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS")
        If gdataset.Tables("STOCKTRANSDETAILS").Rows.Count > 0 Then
            TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            TransFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
        If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
            TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
        Else
            TransToQty = 0
        End If
        TransQty = TransToQty - TransFromQty
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM SUBSTORECONSUMPTIONDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STORECONSUMPTIONDETAILS")
        If gdataset.Tables("STORECONSUMPTIONDETAILS").Rows.Count > 0 Then
            ConsumedQty = Format(Val(gdataset.Tables("STORECONSUMPTIONDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            ConsumedQty = 0
        End If
        ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty) - Val(ConsumedQty)
        sqlstring = "update inventoryitemmaster set clstock= " & ClsQty
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(FREEZE,'')<>'Y'"
        gconnection.ExcuteStoreProcedure(sqlstring)

        Return ClsQty
    End Function

    Public Function GetPassword(ByVal vUser As String) As String
        Dim Vdesc, vPass As String
        Dim vAsc, Loopindex As Long
        Vdesc = ""
        For Loopindex = 1 To Len(vUser)
            Vdesc = Mid(vUser, Loopindex, 1)
            vAsc = Asc(Vdesc) + 150
            vPass = Trim(vPass) & Chr(vAsc)
        Next Loopindex
        Return vPass
    End Function
    Public Function ExportTo(ByVal ssgrid As AxFPSpreadADO.AxfpSpread)
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            X = ssgrid.ExportRangeToTextFile(0, 0, ssgrid.Col2, ssgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With ssgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function Itemvalidate(ByVal SSGRID As AxFPSpreadADO.AxfpSpread, ByVal ITEMCODE As String, ByVal COLPOS As Integer) As Boolean
        Try
            Dim Loopindex, Counter As Integer
            Itemvalidate = False
            Counter = 0 : Loopindex = 1
            For Loopindex = 1 To SSGRID.DataRowCnt
                SSGRID.Col = COLPOS
                SSGRID.Row = Loopindex
                If Trim(SSGRID.Text) = Trim(ITEMCODE) Then
                    Counter = Counter + 1
                End If
                If Counter >= 2 Then
                    SSGRID.Col = COLPOS
                    SSGRID.Row = SSGRID.ActiveRow
                    MessageBox.Show("Duplicate item please check", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    SSGRID.ClearRange(1, SSGRID.ActiveRow, 15, SSGRID.ActiveRow, True)
                    Itemvalidate = True
                End If
            Next Loopindex
        Catch ex As Exception
        End Try
    End Function

    Public Function GetMainStore() As String
        Try
            Dim SQLSTRING, MnStore As String
            SQLSTRING = "SELECT STORECODE FROM STOREMASTER WHERE STORESTATUS='M'"
            gconnection.getDataSet(SQLSTRING, "MAINSTORE")
            If gdataset.Tables("MAINSTORE").Rows.Count > 0 Then
                MnStore = Trim(gdataset.Tables("MAINSTORE").Rows(0).Item("STORECODE"))
            Else
                MnStore = ""
            End If
            Return MnStore
        Catch EX As Exception
            MsgBox(EX.Message)
            Exit Function
        End Try
    End Function

    Public Function UpdateGST(ByVal Type As String, ByVal DocNo As String, ByVal DocDate As Date)
        Dim sqlstring As String
        sqlstring = " exec iNV_PO_GRN_GST_UPDATE '" & Type & "','" & DocNo & "','" & DocDate.ToString("dd/MMM/yyyy") & "'  "
        gconnection.dataOperation(6, sqlstring, )
        'gconnection.ExcuteStoreProcedure(sqlstring)
    End Function

    Public Function TaxType(ByVal Type As String, ByVal DocNo As String, ByVal DocDate As Date) As String
        Dim TTYPE As String = "VAT"
        Dim sqlstring As String

        Call UpdateGST(Type, Trim(DocNo), Format(CDate(DocDate), "dd/MMM/yyyy"))

        If GSTSTARTdATE > DocDate Then
            TTYPE = "VAT"
        End If
        If Type = "GRN" Then
            sqlstring = " SELECT 'GST' AS TYPE FROM  GRN_HEADER WHERE Grndetails='" + DocNo + "' AND  ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)<>0 AND  ISNULL(TotCGSTAmt,0)<>0 AND ISNULL(TotIGSTAmt,0)=0)"
            gconnection.getDataSet(sqlstring, "GRN_HEADER")
            If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_INV_GRNBILL WHERE GRNDETAILS='" + DocNo + "' AND GSTINNO='' "
                gconnection.getDataSet(sqlstring, "GRN_HEADER")
                If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                    TTYPE = "TAXL"
                Else
                    TTYPE = "GST"
                End If
            End If
            sqlstring = " SELECT 'IGST' AS TYPE FROM  GRN_HEADER WHERE Grndetails='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)<>0)"
            gconnection.getDataSet(sqlstring, "GRN_HEADER")
            If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_INV_GRNBILL WHERE GRNDETAILS='" + DocNo + "' AND GSTINNO='' "
                gconnection.getDataSet(sqlstring, "GRN_HEADER")
                If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                    TTYPE = "TAXL"
                Else
                    TTYPE = "IGST"
                End If

            End If
            sqlstring = " SELECT 'VAT' AS TYPE FROM  GRN_HEADER WHERE Grndetails='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)=0)"
            gconnection.getDataSet(sqlstring, "GRN_HEADER")
            If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                TTYPE = "VAT"
            End If

            sqlstring = "select * from GRN_HEADER where  Grndetails IN ( SELECT Grndetails FROM GRN_DETAILS WHERE Grndetails='" + DocNo + "'  AND TAXGROUPCODE like '%gst%') AND VATamount=0 "
            gconnection.getDataSet(sqlstring, "GRN_HEADER")
            If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
                TTYPE = "GST"
            End If
            'ElseIf Type = "PO" Then
            '    sqlstring = " SELECT 'GST' AS TYPE FROM  PO_HDR WHERE PONO='" + DocNo + "' AND  ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)<>0 AND  ISNULL(TotCGSTAmt,0)<>0 AND ISNULL(TotIGSTAmt,0)=0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then

            '        sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_POBILL WHERE PONO='" + DocNo + "' AND GSTINNO='' "
            '        gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '        If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '            TTYPE = "TAXL"
            '        Else
            '            TTYPE = "GST"
            '        End If

            '    End If
            '    sqlstring = " SELECT 'IGST' AS TYPE FROM  PO_HDR WHERE PONO='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)<>0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_POBILL WHERE PONO='" + DocNo + "' AND GSTINNO='' "
            '        gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '        If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '            TTYPE = "TAXL"
            '        Else
            '            TTYPE = "IGST"
            '        End If

            '    End If
            '    sqlstring = " SELECT 'VAT' AS TYPE FROM  PO_HDR WHERE PONO='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)=0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        TTYPE = "VAT"
            '    End If

            '    sqlstring = "select * from VW_POBILL where  PONO='" + DocNo + "'  AND taxcode like '%gst%' AND vatamt=0 "
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        TTYPE = "GST"
            '    End If

            'ElseIf Type = "PRN" Then
            '    sqlstring = " SELECT 'GST' AS TYPE FROM  PRN_HEADER WHERE Prndetails='" + DocNo + "' AND  ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)<>0 AND  ISNULL(TotCGSTAmt,0)<>0 AND ISNULL(TotIGSTAmt,0)=0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_INV_PRNBILL WHERE PRNDETAILS='" + DocNo + "' AND GSTINNO='' "
            '        gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '        If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '            TTYPE = "TAXL"
            '        Else
            '            TTYPE = "GST"
            '        End If
            '    End If
            '    sqlstring = " SELECT 'IGST' AS TYPE FROM  PRN_HEADER WHERE Prndetails='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)<>0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        sqlstring = " SELECT 'IGST' AS TYPE FROM  VW_INV_PRNBILL WHERE PRNDETAILS='" + DocNo + "' AND GSTINNO='' "
            '        gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '        If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '            TTYPE = "TAXL"
            '        Else
            '            TTYPE = "IGST"
            '        End If

            '    End If
            '    sqlstring = " SELECT 'VAT' AS TYPE FROM  PRN_HEADER WHERE Prndetails='" + DocNo + "' AND ISNULL(TotGSTAmt,0)<>0 AND ( ISNULL(TotSGSTAmt,0)=0 AND  ISNULL(TotCGSTAmt,0)=0 AND ISNULL(TotIGSTAmt,0)=0)"
            '    gconnection.getDataSet(sqlstring, "GRN_HEADER")
            '    If gdataset.Tables("GRN_HEADER").Rows.Count > 0 Then
            '        TTYPE = "VAT"
            '    End If
        End If

        Return TTYPE
        ' sqlstring = " exec iNV_PO_GRN_GST_UPDATE '" & Type & "','" & DocNo & "','" & DocDate.ToString("dd/MMM/yyyy") & "'  "
        'gconnection.dataOperation(6, sqlstring, )
        'gconnection.ExcuteStoreProcedure(sqlstring)
    End Function
End Module
