Public Class uc_product
    Private _productId As Integer
    Public Event BuyClick(ByVal sender As Object, ByVal e As BuyClickEventArgs)
    Private _isBuy As Boolean
    Private _customerName As String
    Public Property CustomerName() As String
        Get
            Return _customerName
        End Get
        Set(ByVal value As String)
            _customerName = value
        End Set
    End Property

    Public Property IsBuy() As Boolean
        Get
            Return _isBuy
        End Get
        Set(ByVal value As Boolean)
            _isBuy = value
        End Set
    End Property

    Public Property ProductId As Integer
        Get
            Return _productId
        End Get
        Set(ByVal value As Integer)
            _productId = value
        End Set
    End Property

    Protected Overridable Sub OnBuyClick(ByVal e As BuyClickEventArgs)
        RaiseEvent BuyClick(Me, e)
    End Sub

    Public Property ProductName As String
        Get
            Return lbl_name.Text
        End Get
        Set(ByVal value As String)
            lbl_name.Text = value
        End Set
    End Property

    Public Property PictureImage As Image
        Get
            Return PictureBox1.BackgroundImage
        End Get
        Set(ByVal value As Image)
            PictureBox1.BackgroundImage = value
        End Set
    End Property


    Public Property Brand As String
        Get
            Return lbl_brand.Text
        End Get
        Set(ByVal value As String)
            lbl_brand.Text = value
        End Set
    End Property

    Public Property LuggageType As String
        Get
            Return lbl_type.Text
        End Get
        Set(ByVal value As String)
            lbl_type.Text = value
        End Set
    End Property

    Public Property LuggageSize As String
        Get
            Return lbl_size.Text
        End Get
        Set(ByVal value As String)
            lbl_size.Text = value
        End Set
    End Property

    Public Property Price As String
        Get
            Return lbl_price.Text
        End Get
        Set(ByVal value As String)
            lbl_price.Text = value
        End Set
    End Property

    Private Sub btn_buy_Click(sender As Object, e As EventArgs) Handles btn_buy.Click
        If isLogIn Then
            If isCustomer = False Then
                MsgBox("Please login as customer to purchase.")
            Else
                OnBuyClick(New BuyClickEventArgs(ProductId))
            End If
        Else
            MsgBox("Please login to purchase.")

        End If
    End Sub

    Private Sub uc_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsBuy Then
            btn_buy.Text = "Buy"
        Else
            btn_buy.Text = "Remove"
        End If

    End Sub
End Class
