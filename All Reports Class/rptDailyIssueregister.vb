Imports System.Data.SqlClient
Imports System.io
Public Class rptDailyIssueregister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dbldocTotal, dblGroupTotal, dblGrandTotal, cQTY, cAMT As Double
        Dim STROEDESC, DOCDETAILS As String
        Dim STOREBOOL, DOCBOOL As Boolean
        Dim I As Integer
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
            gconnection.getDataSet(SQLSTRING, "ISSUEREGISTERREPORT")
            If gdataset.Tables("ISSUEREGISTERREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ISSUEREGISTERREPORT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If

                    Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 15))
                    Filewrite.Write("{0,-35}", Mid(Trim(CStr(dr("ITEMNAME"))), 1, 35))
                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("UOM"))), 1, 10))
                    Filewrite.Write("{0,-10}", Mid(Format(Val(dr("ISSQTY")), "0.000"), 1, 10))
                    Filewrite.Write("{0,-10}", Mid(Format(Val(dr("RETURNQTY")), "0.000"), 1, 10))
                    'Filewrite.Write("{0,-10}", Mid(Format(Val(dr("ISSQTY")), "0.000"), 1, 10) - Mid(Format(Val(dr("RETURNQTY")), "0.000"), 1, 10))
                    Filewrite.Write("{0,-10}", Mid(Format((dr("ISSQTY") - dr("RETURNQTY")), "0.000"), 1, 10))
                    cQTY = (dr("ISSQTY") - dr("RETURNQTY"))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 12))
                    'Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 15))
                    Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("RATE") * cQTY), "0.00"), 1, 15))
                    cAMT = Val(dr("RATE") * cQTY)
                    pagesize = pagesize + 1
                    'dblGrandTotal = dblGrandTotal + Format(Val(dr("AMOUNT")), "0.00")
                    dblGrandTotal = dblGrandTotal + Format(Val(cAMT), "0.00")
                Next dr
                Filewrite.WriteLine()
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-50}{1,-26}{2,-20}{3,12}{4,-5}", "", "GRAND TOTAL =====>", "", "", Format(Val(dblGrandTotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
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
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            'Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            'pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-15}{2,-15}{3,-10}{4,-10}{5,-10}", "ITEM CODE", "ITEMNAME", "", "UOM", "ISSUE", "RETURN")
            Filewrite.WriteLine("{0,-10}{1,12}{2,15}", "CONSUM", "RATE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-15}{2,-15}{3,-10}{4,-10}{5,-10}", "", "", "", "", "QTY", "QTY")
            Filewrite.WriteLine("{0,-10}{1,12}{2,15}", "QTY", "", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function Reportdetails_Run(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dbldocTotal, dblGroupTotal, dblGrandTotal, cQTY, cAMT, CIQty As Double
        Dim STROEDESC, DOCDETAILS, RunString As String
        Dim STOREBOOL, DOCBOOL As Boolean
        Dim I, k As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader_Run(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "ISSUEREGISTERREPORT")
            If gdataset.Tables("ISSUEREGISTERREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ISSUEREGISTERREPORT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader_Run(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    Filewrite.WriteLine("{0,-10}{1,-35}{2,10}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 10), Mid(Trim(CStr(dr("ITEMNAME"))), 1, 35), Mid(Format(Val(dr("OPQTY")), "0.000"), 1, 10))
                    pagesize = pagesize + 1
                    CIQty = dr("OPQTY")
                    Filewrite.WriteLine("Purchase")
                    pagesize = pagesize + 1
                    RunString = "SELECT * FROM Running_Item WHERE ITEMCODE = '" & Trim(dr("ITEMCODE")) & "' AND TYPE = 'P' AND GRNDATE BETWEEN '" & Format(FROMDATE, "dd-MMM-yyyy") & "' and '" & Format(TODATE, "dd-MMM-yyyy") & "' ORDER BY GRNDATE"
                    gconnection.getDataSet(RunString, "Run_Pur")
                    If gdataset.Tables("Run_Pur").Rows.Count > 0 Then
                        For k = 0 To gdataset.Tables("Run_Pur").Rows.Count - 1
                            Filewrite.WriteLine("{0,-25}{1,-17}{2,10}", Trim(Mid(gdataset.Tables("Run_Pur").Rows(k).Item("SUPPLIERNAME"), 1, 24)), Trim(Mid(gdataset.Tables("Run_Pur").Rows(k).Item("GRNDETAILS"), 1, 17)), Format(gdataset.Tables("Run_Pur").Rows(k).Item("QTY"), "0.00"))
                            pagesize = pagesize + 1
                            CIQty = CIQty + gdataset.Tables("Run_Pur").Rows(k).Item("QTY")
                        Next
                    Else
                        Filewrite.WriteLine("=")
                        pagesize = pagesize + 1
                    End If
                    Filewrite.WriteLine("Issue")
                    pagesize = pagesize + 1
                    RunString = "SELECT * FROM Running_Item WHERE ITEMCODE = '" & Trim(dr("ITEMCODE")) & "' AND TYPE = 'I' AND GRNDATE BETWEEN '" & Format(FROMDATE, "dd-MMM-yyyy") & "' and '" & Format(TODATE, "dd-MMM-yyyy") & "' ORDER BY GRNDATE"
                    gconnection.getDataSet(RunString, "Run_Pur")
                    If gdataset.Tables("Run_Pur").Rows.Count > 0 Then
                        For k = 0 To gdataset.Tables("Run_Pur").Rows.Count - 1
                            Filewrite.WriteLine("{0,-25}{1,-17}{2,10}", Trim(Mid(gdataset.Tables("Run_Pur").Rows(k).Item("SUPPLIERNAME"), 1, 24)), Trim(Mid(gdataset.Tables("Run_Pur").Rows(k).Item("GRNDETAILS"), 1, 17)), Format(gdataset.Tables("Run_Pur").Rows(k).Item("QTY"), "0.00"))
                            pagesize = pagesize + 1
                            CIQty = CIQty - gdataset.Tables("Run_Pur").Rows(k).Item("QTY")
                        Next
                    Else
                        Filewrite.WriteLine("=")
                        pagesize = pagesize + 1
                    End If
                    Filewrite.WriteLine(StrDup(80, "-"))
                    Filewrite.WriteLine("{0,-25}{1,-17}{2,10}", "Closing Bal ->", "", Format(CIQty, "0.00"))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(StrDup(80, "="))
                    pagesize = pagesize + 1
                    'Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 15))
                    'Filewrite.Write("{0,-35}", Mid(Trim(CStr(dr("ITEMNAME"))), 1, 35))
                    'Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("UOM"))), 1, 10))
                    'Filewrite.Write("{0,-10}", Mid(Format(Val(dr("ISSQTY")), "0.000"), 1, 10))
                    'Filewrite.Write("{0,-10}", Mid(Format(Val(dr("RETURNQTY")), "0.000"), 1, 10))
                    ''Filewrite.Write("{0,-10}", Mid(Format(Val(dr("ISSQTY")), "0.000"), 1, 10) - Mid(Format(Val(dr("RETURNQTY")), "0.000"), 1, 10))
                    'Filewrite.Write("{0,-10}", Mid(Format((dr("ISSQTY") - dr("RETURNQTY")), "0.000"), 1, 10))
                    'cQTY = (dr("ISSQTY") - dr("RETURNQTY"))
                    'Filewrite.Write("{0,12}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 12))
                    ''Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 15))
                    'Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("RATE") * cQTY), "0.00"), 1, 15))
                    'cAMT = Val(dr("RATE") * cQTY)
                    'pagesize = pagesize + 1
                    ''dblGrandTotal = dblGrandTotal + Format(Val(dr("AMOUNT")), "0.00")
                    'dblGrandTotal = dblGrandTotal + Format(Val(cAMT), "0.00")
                Next dr
                Filewrite.WriteLine()
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-50}{1,-26}{2,-20}{3,12}{4,-5}", "", "GRAND TOTAL =====>", "", "", Format(Val(dblGrandTotal), "0.00"))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(135, "="))
                'pagesize = pagesize + 1
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
    Private Function PrintHeader_Run(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            'Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            'pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            'Filewrite.Write("{0,-20}{1,-15}{2,-15}{3,-10}{4,-10}{5,-10}", "ITEM CODE", "ITEMNAME", "", "UOM", "ISSUE", "RETURN")
            'Filewrite.WriteLine("{0,-10}{1,12}{2,15}", "CONSUM", "RATE", "AMOUNT")
            'pagesize = pagesize + 1
            'Filewrite.Write("{0,-20}{1,-15}{2,-15}{3,-10}{4,-10}{5,-10}", "", "", "", "", "QTY", "QTY")
            'Filewrite.WriteLine("{0,-10}{1,12}{2,15}", "QTY", "", "")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine(StrDup(135, "-"))
            'pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
