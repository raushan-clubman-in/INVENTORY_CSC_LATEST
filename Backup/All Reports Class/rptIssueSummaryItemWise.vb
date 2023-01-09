Imports System.Data.SqlClient
Imports System.io
Public Class rptIssueSummaryItemWise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dbldocTotal, dblGroupTotal, dblGrandTotal As Double
        Dim opqty, groupvalue As Double
        Dim GROUPNAME, groupcode As String
        Dim GQTY, GVALUE As Double
        Dim TGROUPQty, Tgroupvalue As Double
        Dim ITEMCODE, DOCDETAILS As String
        Dim ITEMBOOL, DOCBOOL As Boolean
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            TGROUPQty = 0
            Tgroupvalue = 0
            GQTY = 0
            GVALUE = 0
            Tgroupvalue = 0
            'Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "ISSUESUMMARYREPORT")
            If gdataset.Tables("ISSUESUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                groupcode = Trim(gdataset.Tables("ISSUESUMMARYREPORT").Rows(0).Item("opstorelocationcode"))
                GROUPNAME = Trim(gdataset.Tables("ISSUESUMMARYREPORT").Rows(0).Item("opstorelocationname"))
                Filewrite.WriteLine()
                Filewrite.WriteLine(groupcode & "->" & GROUPNAME)
                Filewrite.WriteLine()
                pagesize = pagesize + 3
                For Each dr In gdataset.Tables("ISSUESUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(92, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If GROUPNAME <> Trim(CStr(dr("opstorelocationname"))) Then
                        GROUPNAME = Trim(CStr(dr("opstorelocationname")))
                        groupcode = Trim(CStr(dr("opstorelocationcode")))

                        Filewrite.WriteLine(StrDup(92, "."))
                        Filewrite.WriteLine("{0,44}{1,12}{2,24}{3,12}", " TOTAL =======>        ", Format(GQTY, "0.000"), "", Format(GVALUE, "0.00"))
                        TGROUPQty = TGROUPQty + GQTY
                        Tgroupvalue = Tgroupvalue + GVALUE
                        Filewrite.WriteLine(StrDup(92, "."))
                        Filewrite.WriteLine()
                        GVALUE = 0
                        GQTY = 0
                        Filewrite.WriteLine()
                        'Filewrite.WriteLine(Chr(15) & GROUPNAME)
                        Filewrite.WriteLine(Chr(15) & groupcode & "->" & GROUPNAME)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 7
                    End If
                    If ITEMCODE <> Trim(CStr(dr("ITEMCODE"))) Then
                        Filewrite.Write("{0,-12}", Mid(Trim(Format((dr("DOCDATE")), "dd/MM/yyyy")), 1, 12))
                        Filewrite.Write("{0,-8}", Mid(Trim(CStr(dr("ITEMCODE"))), 1, 8))
                        Filewrite.Write("{0,-24}", Mid(Trim(CStr(dr("ITEMNAME"))), 1, 23))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("QTY")), "0.000"), 1, 12))
                        GQTY = GQTY + Val(dr("QTY"))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 12))
                        Filewrite.Write("{0,12}", "")
                        Filewrite.WriteLine("{0,12}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 12))
                        GVALUE = GVALUE + Val(dr("AMOUNT"))
                        dblGrandTotal = dblGrandTotal + Format(Val(dr("AMOUNT")), "0.00")
                        'TGROUPQty = TGROUPQty + Val(dr("QTY"))
                        'Tgroupvalue = Tgroupvalue + Val(dr("AMOUNT"))
                        pagesize = pagesize + 1
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(92, "."))
                Filewrite.WriteLine("{0,44}{1,12}{2,24}{3,12}", " TOTAL =======>        ", Format(GQTY, "0.000"), "", Format(GVALUE, "0.00"))
                TGROUPQty = TGROUPQty + GQTY
                Tgroupvalue = Tgroupvalue + GVALUE
                Filewrite.WriteLine(StrDup(92, "."))
                Filewrite.WriteLine()
                Filewrite.WriteLine(StrDup(92, "="))
                pagesize = pagesize + 1

                Filewrite.WriteLine("{0,44}{1,12}{2,24}{3,12}", "GRAND TOTAL =======>        ", Format(TGROUPQty, "0.000"), "", Format(Tgroupvalue, "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(92, "="))
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
            Filewrite.WriteLine(Chr(18))
            Filewrite.WriteLine("{0,60}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
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
            'Filewrite.WriteLine(Chr(15))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(92, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-12}{1,-8}{2,-24}{3,12}{4,12}{5,12}{6,12}", "DOC", "ITEM", "ITEM", "ISSUE", "RATE", "", "ISSUE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-12}{1,-8}{2,-24}{3,12}{4,12}{5,12}{6,12}", "DATE", "CODE", "DESCRIPTION", "QTY", "", "", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(92, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
