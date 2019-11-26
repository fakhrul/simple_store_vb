Imports System.Data.OleDb
Imports WindowsApp1

Public Class frm_shoppingcart_p98822
    Public Event BuyClick(ByVal sender As Object, ByVal e As BuyClickEventArgs)

    Protected Overridable Sub OnBuyClick(ByVal e As BuyClickEventArgs)
        RaiseEvent BuyClick(Me, e)
    End Sub


    Private Sub frm_cart_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCartList()
    End Sub

    Private Sub RefreshCartList()
        Try
            Dim totalPrice As Integer = 0
            FlowLayoutPanel1.Controls.Clear()
            For Each productId In shoppingCart
                Dim cnn As OleDb.OleDbConnection
                Dim cmd As OleDb.OleDbCommand
                Dim sql As String
                Dim reader As OleDb.OleDbDataReader

                sql = "select P.fld_product_id, P.fld_product_name, P.fld_price,  B.fld_brand_name from tbl_product_p98822 as P, tbl_brand_p98822 as B where P.fld_brand = B.fld_brand_id and P.fld_product_id = " & productId

                cnn = New OleDb.OleDbConnection(myconnection)
                Try
                    cnn.Open()
                    cmd = New OleDb.OleDbCommand(sql, cnn)
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    If reader.HasRows Then
                        Dim uc As New uc_product()
                        uc.ProductId = reader.Item(0)
                        uc.ProductName = reader.Item(1).ToString
                        uc.Price = "RM " + reader.Item(2).ToString
                        totalPrice = totalPrice + reader.Item(2)
                        uc.Brand = "Brand : " + reader.Item(3).ToString
                        uc.IsBuy = False
                        Try
                            uc.PictureImage = Image.FromFile("pictures/" & reader.Item(0) & ".jpg")
                        Catch ex As Exception
                            uc.PictureImage = Image.FromFile("pictures/nophoto.jpg")

                        End Try
                        AddHandler uc.BuyClick, AddressOf Me.HandleBuyClick

                        FlowLayoutPanel1.Controls.Add(uc)
                    End If
                    reader.Close()
                    cmd.Dispose()
                    cnn.Close()
                Catch ex As Exception
                    MsgBox("Can not open connection ! ")
                End Try


            Next
            If shoppingCart.Count = 0 Then
                lbl_totalItem.ForeColor = Color.Red
                lbl_totalItem.Text = "Your shopping cart is empty!. Please click Product Catalogs to shop."
                btn_CheckOut.Visible = False
            Else
                lbl_totalItem.ForeColor = Color.Green
                lbl_totalItem.Text = "Your total item is " & shoppingCart.Count & ", and total price is RM " & totalPrice.ToString()
                btn_CheckOut.Visible = True
            End If

        Catch ex As DivideByZeroException
            MessageBox.Show(String.Format("Exception caught: {0}", ex))
        End Try
    End Sub

    Private Sub HandleBuyClick(sender As Object, e As BuyClickEventArgs)
        Dim product As Integer = e.ProductId
        Dim indexToRemove As Integer = -1

        For i = 0 To shoppingCart.Count - 1
            If shoppingCart(i) = product Then
                indexToRemove = i
                Exit For
            End If
        Next
        If indexToRemove >= 0 Then
            shoppingCart.RemoveAt(indexToRemove)
        End If
        RefreshCartList()
        OnBuyClick(e)
    End Sub

    Private Sub btn_CheckOut_Click(sender As Object, e As EventArgs) Handles btn_CheckOut.Click
        Dim confirmation = MsgBox("Are you sure you want to checkout this?", MsgBoxStyle.YesNo, "Checkout")

        If confirmation = MsgBoxResult.Yes Then
            Try
                InsertOrder()
                InsertOrderItem()
                Beep()
                MsgBox("Thank you !!! " & Environment.NewLine & Environment.NewLine & "Your order had been succesfully checkout. " & Environment.NewLine & Environment.NewLine & "Please make a payment and notify the store via email at buy@bagasi.com and attach the payment proof. " & Environment.NewLine & Environment.NewLine & "You can view your order status and history at the My Previous Order menu. " & Environment.NewLine & Environment.NewLine & "The order will be cancel if there is no proof of payment within 3 days.")
            Catch ex As Exception
                MsgBox("Exception: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub InsertOrder()
        Dim mysql As String = "insert into tbl_order_p98822 (FLD_order_code, FLD_order_customer_id, FLD_order_datetime, FLD_order_status, FLD_order_staff_id) values ('" &
                 DateTime.Now.ToString("yyMMddHHmmss") & "'," &
                 loggedId & ",'" &
                 DateTime.Now.ToString("dd/MM/yyyy") & "'," &
                 "1,1" & ")"

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

    Private Sub InsertOrderItem()

    End Sub
End Class