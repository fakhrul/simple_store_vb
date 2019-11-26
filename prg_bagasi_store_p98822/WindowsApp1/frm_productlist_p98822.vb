Imports System.Data.OleDb
Imports WindowsApp1

Public Class frm_productlist_p98822
    Dim selected_code As Integer

    Private Sub frm_productlist_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshBrand()
        RefreshSize()
        RefreshType()
        RefreshGrid()
    End Sub

    Private Sub RefreshBrand()
        cmb_brand.DataSource = run_select("select * from TBL_BRAND_P98822")
        cmb_brand.DisplayMember = "fld_brand_name"
        cmb_brand.ValueMember = "fld_brand_id"
    End Sub
    Private Sub RefreshSize()
        cmb_size.DataSource = run_select("select * from TBL_SIZE_P98822")
        cmb_size.DisplayMember = "fld_size_name"
        cmb_size.ValueMember = "fld_size_id"
    End Sub
    Private Sub RefreshType()
        cmb_type.DataSource = run_select("select * from TBL_TYPE_P98822")
        cmb_type.DisplayMember = "fld_type_name"
        cmb_type.ValueMember = "fld_type_id"
    End Sub

    Private Sub RefreshGrid()

        Dim sql As String = "select P.fld_product_id As Id, P.fld_product_name AS Name, P.fld_price AS Price, B.fld_brand_id AS BrandId, B.fld_brand_name AS BrandName, " &
            "P.fld_size AS SizeId, S.fld_size_name As SizeName, P.fld_type AS TypeId, T.fld_type_name AS TypeName, P.fld_description, P.fld_weight, P.fld_fabric " &
            "from tbl_product_p98822 as P, tbl_brand_p98822 as B, tbl_size_p98822 AS S, tbl_type_p98822 AS T where P.fld_brand = B.fld_brand_id AND P.fld_size = S.FLD_SIZE_ID AND P.FLD_TYPE = T.FLD_TYPE_ID"


        dg_list.DataSource = run_select(sql)
    End Sub


    Public Function run_select(mysql As String) As DataTable
        Dim mydata As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Try
            myreader.Fill(mydata)
        Catch ex As Exception

        End Try


        Return mydata

    End Function

    Private Sub dg_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_list.CellClick

        Try
            Dim current_row As Integer = dg_list.CurrentRow.Index
            selected_code = dg_list(0, current_row).Value
            txt_id.Text = selected_code
            If Not IsDBNull(dg_list(1, current_row).Value) Then
                txt_name.Text = dg_list(1, current_row).Value
            End If
            If Not IsDBNull(dg_list(10, current_row).Value) Then
                txt_weight.Text = dg_list(10, current_row).Value
            End If
            If Not IsDBNull(dg_list(11, current_row).Value) Then
                txt_fabric.Text = dg_list(11, current_row).Value
            End If

            If Not IsDBNull(dg_list(9, current_row).Value) Then
                txt_description.Text = dg_list(9, current_row).Value
            End If

            If Not IsDBNull(dg_list(2, current_row).Value) Then
                txt_price.Text = dg_list(2, current_row).Value
            End If

            cmb_brand.SelectedValue = dg_list(3, current_row).Value
            cmb_size.SelectedValue = dg_list(5, current_row).Value
            cmb_type.SelectedValue = dg_list(7, current_row).Value

            txt_picture.Text = ""

            Dim fullPath As String = AppDomain.CurrentDomain.BaseDirectory & "\pictures\" & selected_code & ".jpg"
            If IO.File.Exists(fullPath) Then

                Dim tempFile As String = AppDomain.CurrentDomain.BaseDirectory & "\pictures\temp_for_display.jpg"
                System.IO.File.Copy(fullPath, tempFile, True)

                Using fs As New IO.FileStream(tempFile, IO.FileMode.Open, IO.FileAccess.Read)
                    pic_product.BackgroundImage = Image.FromStream(fs)
                End Using
            Else
                If pic_product.BackgroundImage IsNot Nothing Then
                    pic_product.BackgroundImage.Dispose()
                    pic_product.BackgroundImage = Nothing
                End If
            End If

            btn_add.Text = "Update"
            btn_delete.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        ClearForm()

    End Sub

    Private Sub ClearForm()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_weight.Text = ""
        txt_fabric.Text = ""
        txt_description.Text = ""
        txt_price.Text = ""
        cmb_brand.SelectedIndex = 0
        cmb_size.SelectedIndex = 0
        cmb_type.SelectedIndex = 0

        If pic_product.BackgroundImage IsNot Nothing Then
            pic_product.BackgroundImage.Dispose()
            pic_product.BackgroundImage = Nothing
        End If

        txt_picture.Text = ""

        btn_add.Text = "Save"
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        RefreshGrid()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Not String.IsNullOrEmpty(txt_name.Text) Then
            If btn_add.Text = "Save" Then
                AddNewProduct()
            Else
                UpdateProduct()
            End If
        End If
    End Sub

    Private Sub UpdateProduct()
        Dim mysql As String = "update tbl_product_p98822 set FLD_PRODUCT_NAME = '" & txt_name.Text & "'," &
            "FLD_PRICE = '" & txt_price.Text & "'," &
            "FLD_BRAND = " & cmb_brand.SelectedValue & "," &
            "FLD_SIZE = " & cmb_size.SelectedValue & "," &
            "FLD_TYPE = " & cmb_type.SelectedValue & "," &
            "FLD_DESCRIPTION = '" & txt_description.Text & "'," &
            "FLD_WEIGHT = '" & txt_weight.Text & "'," &
            "FLD_FABRIC = '" & txt_fabric.Text & "' " &
            "WHERE FLD_PRODUCT_ID = " & txt_id.Text

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Update database is successful!",, "SUCCESS")
                RefreshGrid()
            Catch ex As Exception
                MsgBox("Exception: " & ex.Message)
            End Try
        End Using

        Try
            If Not String.IsNullOrEmpty(txt_picture.Text) Then
                Dim fullPath As String = AppDomain.CurrentDomain.BaseDirectory & "pictures\" & txt_id.Text & ".jpg"
                If IO.File.Exists(fullPath) Then
                    IO.File.Delete(fullPath)
                End If

                System.IO.File.Copy(txt_picture.Text, fullPath, True)
                txt_picture.Text = ""

            End If

        Catch ex As Exception
            Beep()
            MsgBox("Exception updating file: " & ex.Message)
        End Try




    End Sub

    Private Sub AddNewProduct()
        Dim mysql As String = "insert into tbl_product_p98822 (FLD_PRODUCT_NAME, FLD_PRICE, FLD_BRAND, FLD_SIZE, FLD_TYPE, FLD_DESCRIPTION, FLD_WEIGHT, FLD_FABRIC) values ('" &
            txt_name.Text & "','" &
            txt_price.Text & "'," &
            cmb_brand.SelectedValue & "," &
            cmb_size.SelectedValue & "," &
            cmb_type.SelectedValue & ",'" &
            txt_description.Text & "','" &
            txt_weight.Text & "','" &
            txt_fabric.Text & "')"

        Dim query2 As String = "Select @@Identity"

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                command.ExecuteNonQuery()
                command.CommandText = query2
                Dim id = command.ExecuteScalar()
                If Not String.IsNullOrEmpty(txt_picture.Text) Then
                    My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & id & ".jpg")
                End If

                MsgBox("Update database is successful!",, "SUCCESS")
                RefreshGrid()
            Catch ex As Exception
                MsgBox("Exception: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""

        fd.Title = "Open File Dialog"
        'fd.InitialDirectory = "C:\"
        fd.Filter = "Image files (*.jpg)|*.jpg"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If

        txt_picture.Text = strFileName

        If Not String.IsNullOrEmpty(strFileName) Then

            Dim fullPath As String = strFileName
            Dim tempFile As String = AppDomain.CurrentDomain.BaseDirectory & "\pictures\temp_for_display.jpg"
            System.IO.File.Copy(fullPath, tempFile, True)

            Using fs As New IO.FileStream(tempFile, IO.FileMode.Open, IO.FileAccess.Read)
                pic_product.BackgroundImage = Image.FromStream(fs)
            End Using

        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you want to delete item " & txt_id.Text & "?", MsgBoxStyle.YesNo, "WARNING!")

        If delete_confirmation = MsgBoxResult.Yes Then
            run_command("delete from tbl_product_p98822 where fld_product_id = " & txt_id.Text & "")

            Beep()
            MsgBox("The item'" & txt_id.Text & "' has been deleted successfully.")

            RefreshGrid()
            ClearForm()
        End If

    End Sub

    Public Sub run_command(mysql As String)

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Exception: " & ex.Message)
            End Try
        End Using

    End Sub

End Class