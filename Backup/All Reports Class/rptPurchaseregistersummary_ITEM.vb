Imports System.Data.SqlClient
Imports System.io
Public Class rptPurchaseregistersummary_ITEM
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblGrandTotal, dblBasicTotal, dblVATTotal, dblOtherTotal, dblDiscountTotal, dblQty As Double
        Dim SUPPLIERNAME, GRNDETAILS, I_CODE As String
        Dim SUPPLIERNAMEBOOL, GRNBOOL As Boolean
        Dim Slno As Integer
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Slno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PURCHASEREGISTERSUMMARYREPORT")
            If gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(140, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If I_CODE <> Trim(CStr(dr("ITEMCODE"))) Then
                        Filewrite.Write("{0,-5}", Slno)
                        Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 18))
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("ITEMNAME"))), 1, 20))
                        Filewrite.Write("{0,9}", Mid(Trim(CStr(dr("QTY"))), 1, 9))
                        Filewrite.Write("{0,10}", Mid(Format(dr("RATE"), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("OTHCHARGE")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("DISCOUNT")) + Val(dr("OVERALLDISCOUNT")), "0.00"), 1, 10))
                        Filewrite.WriteLine("{0,15}", Mid(Format((Val(dr("AMOUNT")) + Val(dr("TAXAMOUNT")) + Val(dr("OTHCHARGE"))) - (Val(dr("DISCOUNT")) + Val(dr("OVERALLDISCOUNT"))), "0.00"), 1, 15))
                        pagesize = pagesize + 1
                        dblQty = dblQty + Format(Val(dr("QTY")), "0.00")
                        dblBasicTotal = dblBasicTotal + Format(Val(dr("AMOUNT")), "0.00")
                        dblVATTotal = dblVATTotal + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblOtherTotal = dblOtherTotal + Format(Val(dr("OTHCHARGE")), "0.00")
                        dblDiscountTotal = dblDiscountTotal + Format(Val(dr("DISCOUNT")) + Val(dr("OVERALLDISCOUNT")), "0.00")
                        dblGrandTotal = dblGrandTotal + Format((Val(dr("AMOUNT")) + Val(dr("TAXAMOUNT")) + Val(dr("OTHCHARGE"))) - (Val(dr("DISCOUNT")) + Val(dr("OVERALLDISCOUNT"))), "0.00")
                        I_CODE = CStr(dr("ITEMCODE"))
                        Slno = Slno + 1
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(140, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-18}{1,-17}{2,-9}{3,-8}{4,12}", "GRAND TOTAL =====>", "", Format(Val(dblQty), "0.00"), "", Format(Val(dblBasicTotal), "0.00"))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,15} {4,15}", Format(Val(dblVATTotal), "0.00"), Format(Val(dblOtherTotal), "0.00"), Format(Val(dblDiscountTotal), "0.00"), Format(Val(dblGrandTotal), "0.00"), "")
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(140, "="))
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space((134 - Len(Trim(MyCompanyName))) / 2) & Chr(27) & "E" & Trim(MyCompanyName) & Chr(27) & "F")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-30}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 36), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,62}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(154, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-5}{1,-10}{2,-20}{3,9}{4,10}{5,10}", "SLNO.", "ITEMCODE", "ITEMNAME", "QTY", "RATE", "BASIC")
            Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,15} {4,10} ", "VAT", "OTHER", "DISCOUNT", "TOTAL", "")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-5}{1,-18}{2,-12}{3,-9}{4,-10}{5,10}", "", "", "", "", "", "AMOUNT")
            Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,15} {4,10} ", "AMOUNT", "CHARGE", "AMOUNT", "AMOUNT", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(154, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
