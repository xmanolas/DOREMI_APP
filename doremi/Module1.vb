Module Module1

    Public varTempStr, varTempStr2, varTempStr3, vartempsql, vartempsql2, varSuppliertemp, varCustomertemp As String
    Public vartempcuscode, vartempISBN, tempkinishquantity, fp As String
    Public categoryflag, tempswitch, tempswitch2, tempvalidkinishswitch, tempdate, passw, bookanal, telospolisis As Boolean
    Public varbooktemp, currec As Integer
    Public tempsmlbooks As Double
    Public apomod As New Boolean
    Public iuSelect As New classIU.SelectStringsFunctions
    Public iuDataAccess As New classIU.DataAccessFunctions
    Public iuTables As New classIU.DataTableFunctions
    Public iuGrid As New classIU.DataGridFunctions


    Public Sub pass()
        If passw = False Then
            Dim f As frmLogin
            f.Close()
        End If
    End Sub
End Module
