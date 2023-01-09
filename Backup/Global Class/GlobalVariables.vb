Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Module GlobalVariables
    Public boolyec As Boolean
    Public GSTSTARTdATE As Date = "01 JUL 2017"
    Public stryecmsg As String
    Public MDIParentobj As Object
    Public gIssueregister As Boolean
    Public gridviewstatus As String
    Public gSQLString As String
    Public M_Groupby As String
    Public M_WhereCondition As String
    Public strexcelpath As String
    Public gUsername As String
    Public ggusername As String
    Public ggpassword As String
    Public ggproductkey As String
    Public DefaultGRN As String = "NA"
    Public sst As Boolean
    Public sstore As String
    Public chkClsQty As Boolean = False
    Public chkStorecode As String
    Public gPrint As Boolean
    Public gDosPrint As Boolean
    Public AppPath As String
    Public gCompanyname As String
    Public gCompanyAddress(10) As String
    Public gDatabase As String
    Public gDivCode As String
    Public gDivName As String
    Public gSeasion As String
    Public gUserCategory As String
    Public wemp1, wemp2, wemp3 As String
    Public Reportsql As String
    Public VFilePath As String
    Public printfile As String
    Public tables As String
    Public Gheader As String
    Public gserver As String
    Public SHORTNAME As String
    Public gdataset As New DataSet
    Public gdreader As SqlDataReader
    Public gadapter As SqlDataAdapter
    Public gcommand As SqlCommand
    Public gfstream As FileStream
    Public gtrans As SqlTransaction
    Public GroupMasterbool As Boolean
    Public SubGroupMasterbool As Boolean
    Public StoreMasterbool As Boolean
    Public ItemMasterbool As Boolean
    Public TenderMasterbool As Boolean
    Public UOMRelationMasterbool As Boolean
    Public BillingMaterialbool As Boolean
    Public PurchaseOrderbool As Boolean
    Public IndentOrderbool As Boolean
    Public UserAdminbool As Boolean
    Public GRNCumPurchaseBillTransbool As Boolean
    Public StockIssueTransbool As Boolean
    Public CockTailRatioTransbool As Boolean
    Public StockTransferTransbool As Boolean
    Public StockAdjustmentTransbool As Boolean
    Public StockDamageTransbool As Boolean
    Public vOutfile, vheader, vLine As String
    Public gFinancalyearStart As String
    Public gFinancialyearEnd As String
    Public Filewrite As StreamWriter
    Public kotentrybool As Boolean
    Public finalbillbool As Boolean
    Public manualbillbool As Boolean
    Public cashreceiptbool As Boolean
    Public Printername As String = "EpsonCom"
    Public computername As String = "debasish"
    Public search As String
    Public MyCompanyName As String
    Public Address1 As String
    Public Address2 As String
    Public gCity As String
    Public gState As String
    Public gPincode As String
    Public chkdatevalidate As Boolean
    Public PrintTaxheading1 As String
    Public PrintTaxheading2 As String
    Public gCreditors As String
    Public gDebitors As String
    Public GmoduleName As String

    Public PoNumber As String
    Public ShowCompany As Boolean
End Module
