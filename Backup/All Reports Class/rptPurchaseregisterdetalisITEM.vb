Imports System.Data.SqlClient
Imports System.io
Public Class rptPurchaseregisterdetalisITEM
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblGrandTotal, dblBasicTotal, dblVATTotal, dblOtherTotal, dblDiscountTotal, dblGrandQTY, Total, GTotal, GrandTotal As Double
        Dim grpQty, grpTotal As Double
        Dim SUPPLIERNAME, GRNDETAILS, I_CODE, iname As String
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
                        If I_CODE <> "" Then
                            dblGrandQTY = dblGrandQTY + grpQty
                            dblGrandTotal = dblGrandTotal + grpTotal
                            GrandTotal = GrandTotal + GTotal
                            Filewrite.WriteLine(StrDup(154, "-"))
                            Filewrite.WriteLine("{0,-20}{1,-12}{2,-25}{3,-10}{4,10}{5,10}{6,15}{7,10}{8,10}{9,15}", "GROUP TOTAL =====>", "", "", "", Format(Val(grpQty), "0.000"), "", Format(Val(grpTotal), "0.00"), "", "", Format(GTotal, "0.00"))
                            Filewrite.WriteLine(StrDup(154, "-"))
                            pagesize = pagesize + 3
                            grpQty = 0 : grpTotal = 0 : GTotal = 0
                        End If
                        Filewrite.WriteLine("{0,-40}", Mid(Trim(CStr(dr("ITEMCODE"))) & "=>" & Trim(CStr(dr("ITEMNAME"))), 1, 40))
                        Filewrite.WriteLine()
                        pagesize = pagesize + 2
                        I_CODE = Trim(CStr(dr("ITEMCODE")))
                        iname = Trim(CStr(dr("itemname")))
                    End If
                    Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("GRNDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("GRNDETAILS"))), 1, 20))
                    Filewrite.Write("{0,-25}", Mid(Trim(CStr(dr("SUPPLIERNAME"))), 1, 25))
                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("UOM"))), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("QTY")), "0.000"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("RATE")), "0.000"), 1, 10))
                    Filewrite.Write("{0,15}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("VATAMOUNT")), "0.000"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("DISCOUNT")), "0.000"), 1, 10))
                    Total = Val(dr("AMOUNT")) + Val(dr("VATAMOUNT")) - Val(dr("DISCOUNT"))
                    Filewrite.WriteLine("{0,15}", Mid(Format(Val(Total), "0.00"), 1, 10))
                    pagesize = pagesize + 1
                    grpQty = grpQty + Format(Val(dr("QTY")), "0.00")
                    grpTotal = grpTotal + Format(Val(dr("AMOUNT")), "0.00")
                    GTotal = GTotal + Total
                    'Total = 0
                    Slno = Slno + 1
                Next dr
                dblGrandQTY = dblGrandQTY + grpQty
                dblGrandTotal = dblGrandTotal + grpTotal
                GrandTotal = GrandTotal + GTotal
                Filewrite.WriteLine(StrDup(154, "-"))
                Filewrite.WriteLine("{0,-20}{1,-12}{2,-25}{3,-10}{4,10}{5,10}{6,15}{7,10}{8,10}{9,15}", "GROUP TOTAL =====>", "", "", "", Format(Val(grpQty), "0.000"), "", Format(Val(grpTotal), "0.00"), "", "", Format(GTotal, "0.00"))
                Filewrite.WriteLine(StrDup(154, "-"))
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(140, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-12}{2,-25}{3,-10}{4,10}{5,10}{6,15}{7,10}{8,10}{9,15}", "GRAND TOTAL =====>", "", "", "", Format(Val(dblGrandQTY), "0.000"), "", Format(Val(dblGrandTotal), "0.00"), "", "", Format(GrandTotal, "0.00"))
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
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 36), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,62}{1,-10}", " ", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(154, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-12}{1,-20}{2,-25}{3,-10}{4,10}{5,10}{6,15}{7,10}{8,10}{9,15}", "GRN DATE", "GRN NO.", "SUPPLIERNAME", "UOM", "QTY", "RATE", "AMOUNT", "VAT", "DISCOUNT", "TOTAL")
            'Filewrite.Write("{0,-5}{1,-18}{2,-12}{3,-9}{4,-25}{5,10}", "SLNO.", "GRN NO.", "GRN", "SUPPLIER", "SUPPLIER", "BASIC")
            'Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,15} {4,10} ", "VAT", "OTHER", "DISCOUNT", "BILL", "BILL")
            'pagesize = pagesize + 1
            'Filewrite.Write("{0,-5}{1,-18}{2,-12}{3,-9}{4,-25}{5,10}", "", "", "DATE", "CODE", "NAME", "AMOUNT")
            'Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,15} {4,10} ", "AMOUNT", "CHARGE", "AMOUNT", "No", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(154, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
