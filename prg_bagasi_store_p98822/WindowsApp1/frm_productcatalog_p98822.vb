Imports System.Data.OleDb
Imports WindowsApp1

Public Class frm_productcatalog_p98822
    Public Event BuyClick(ByVal sender As Object, ByVal e As BuyClickEventArgs)

    Protected Overridable Sub OnBuyClick(ByVal e As BuyClickEventArgs)
        RaiseEvent BuyClick(Me, e)
    End Sub

    Private Sub frm_productlist_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            RefreshBrandOptions()
            RefreshSizeOptions()
            RefreshTypeOptions()
            RefreshDefaultProducts()
            cmb_order.SelectedIndex = 0
        Catch ex As DivideByZeroException
            MessageBox.Show(String.Format("Exception caught: {0}", ex))
        End Try

    End Sub

    Private Sub RefreshDefaultProducts()

        Dim sql As String = "select P.fld_product_id, P.fld_product_name, P.fld_price,  B.fld_brand_name from tbl_product_p98822 as P, tbl_brand_p98822 as B where P.fld_brand = B.fld_brand_id"

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(sql)
            command.Connection = connection

            Try
                connection.Open()
                Dim reader As OleDb.OleDbDataReader
                reader = command.ExecuteReader()
                While reader.Read()
                    Dim uc As New uc_product()
                    uc.ProductId = reader.Item(0)
                    uc.ProductName = reader.Item(1).ToString
                    uc.Price = "RM " + reader.Item(2).ToString
                    uc.Brand = "Brand : " + reader.Item(3).ToString
                    uc.IsBuy = True
                    Try
                        uc.PictureImage = Image.FromFile("pictures/" & reader.Item(0) & ".jpg")
                    Catch ex As Exception
                        uc.PictureImage = Image.FromFile("pictures/nophoto.jpg")

                    End Try
                    AddHandler uc.BuyClick, AddressOf Me.HandleBuyClick

                    FlowLayoutPanel1.Controls.Add(uc)
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using


    End Sub

    Private Sub RefreshTypeOptions()

        Try
            Dim mysql As String = "select * from tbl_type_p98822"

            Using connection As OleDbConnection = New OleDbConnection(myconnection)
                Dim mydata As New DataTable
                Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                reader.Fill(mydata)

                Dim row As DataRow
                row = mydata.NewRow()
                row(0) = 0
                row(1) = "-- ALL --"
                mydata.Rows.InsertAt(row, 0)

                cmb_type.DataSource = mydata
                cmb_type.DisplayMember = "fld_type_name"
                cmb_type.ValueMember = "fld_type_id"

            End Using


        Catch ex As Exception
        End Try


    End Sub

    Private Sub RefreshSizeOptions()
        Try
            Dim mysql As String = "select * from tbl_size_p98822"

            Using connection As OleDbConnection = New OleDbConnection(myconnection)
                Dim data As New DataTable
                Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                reader.Fill(data)

                Dim row As DataRow
                row = data.NewRow()
                row(0) = 0
                row(1) = "-- ALL --"
                data.Rows.InsertAt(row, 0)

                cmb_size.DataSource = data
                cmb_size.DisplayMember = "fld_size_name"
                cmb_size.ValueMember = "fld_size_id"

            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RefreshBrandOptions()
        Try
            Dim mysql As String = "select fld_brand_id, fld_brand_name from tbl_brand_p98822"

            Using connection As OleDbConnection = New OleDbConnection(myconnection)
                Dim mydata As New DataTable
                Dim reader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                reader.Fill(mydata)

                Dim row As DataRow
                row = mydata.NewRow()
                row(0) = 0
                row(1) = "-- ALL --"
                mydata.Rows.InsertAt(row, 0)

                cmb_brand.DataSource = mydata
                cmb_brand.DisplayMember = "fld_brand_name"
                cmb_brand.ValueMember = "fld_brand_id"

            End Using


        Catch ex As Exception
        End Try


    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click

        RefreshDefaultProducts()


    End Sub

    Private Sub HandleBuyClick(sender As Object, e As BuyClickEventArgs)
        shoppingCart.Add(e.ProductId)
        OnBuyClick(e)
    End Sub

    'Private Function GetBrandById(v As Object) As String
    '    Dim cnn As OleDb.OleDbConnection
    '    Dim cmd As OleDb.OleDbCommand
    '    Dim sql As String
    '    Dim reader As OleDb.OleDbDataReader
    '    Dim brandName As String
    '    brandName = ""
    '    sql = "select * from tbl_brand_p98822 where fld_brand_id =" + v

    '    cnn = New OleDb.OleDbConnection(myconnection)
    '    Try
    '        cnn.Open()
    '        cmd = New OleDb.OleDbCommand(sql, cnn)
    '        reader = cmd.ExecuteReader()
    '        reader.Read()
    '        brandName = reader.Item(1).ToString()
    '        reader.Close()
    '        cmd.Dispose()
    '        cnn.Close()
    '    Catch ex As Exception
    '        MsgBox("Can not open connection ! ")
    '    End Try
    '    Return brandName
    'End Function
End Class