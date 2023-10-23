Public Class Monthly_Inventory

    Public Property trd_date As Date
    Public Property item_code As String
    Public Property item_name As String
    Public Property fund_classification As String
    Public Property supplier As String

    Public Property begQty As Integer
    Public Property begPrince As Decimal
    Public Property begTotalCost As Decimal
    Public Property balTotalCost As Decimal

    Public Property recQty As Integer
    Public Property recPrice As Decimal
    Public Property recTotalCost As Decimal

    Public Property pullQty As Integer
    Public Property pullPrice As Decimal
    Public Property pullTotalPrice As Decimal

    Public Property soldQty As Integer
    Public Property soldPrice As Decimal
    Public Property soldTotalCost As Decimal

    Public Property endQty As Integer
    Public Property endPrice As Decimal
    Public Property endTotalCost As Decimal

End Class
