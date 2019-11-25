Public Class BuyClickEventArgs
    Inherits System.EventArgs

    Public Property ProductId As Integer

    Public Sub New(ByVal id As Integer)
        ProductId = id
    End Sub

End Class
