Public Class frm_orderItem_p98822
    Private _orderId As Integer
    Public Property OrderId As Integer
        Get
            Return _orderId
        End Get
        Set(ByVal value As Integer)
            _orderId = value
        End Set
    End Property



    Private Sub frm_orderItem_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCartList()
    End Sub

    Private Sub RefreshCartList()
        Try
            Dim totalPrice As Integer = 0
            FlowLayoutPanel1.Controls.Clear()

            Dim shoppedItem = GetAllProductByOrderId()

            For Each productId In shoppedItem
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

                        uc.btn_buy.Visible = False

                        FlowLayoutPanel1.Controls.Add(uc)
                    End If
                    reader.Close()
                    cmd.Dispose()
                    cnn.Close()
                Catch ex As Exception
                    MsgBox("Can not open connection ! ")
                End Try


            Next


        Catch ex As DivideByZeroException
            MessageBox.Show(String.Format("Exception caught: {0}", ex))
        End Try
    End Sub

    Private Function GetAllProductByOrderId() As Object
        Dim SQL As String = "select * FROM tbl_order_product_p98822 WHERE fld_order_id = " & OrderId

        Dim output As New ArrayList()

        ' Set the connection string in the Solutions Explorer/Properties/Settings object (double-click)
        Using cn = New OleDb.OleDbConnection(myconnection)
            Using cmd = New OleDb.OleDbCommand(SQL, cn)
                cn.Open()

                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()
                        output.Add(dr("fld_product_id"))
                    End While
                Catch e As Exception
                    MsgBox(e.Message)
                End Try
            End Using
        End Using

        Return output
    End Function
End Class