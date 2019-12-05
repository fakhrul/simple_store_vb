Imports System.Data.OleDb
Imports WindowsApp1

Public Class frm_orderlist_p98822
    Dim selected_code As Integer

    Private Sub frm_productlist_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshStaff()
        RefreshStatus()
        RefreshGrid()
    End Sub

    Private Sub RefreshStaff()
        cmb_staff.DataSource = run_select("select * from TBL_STAFF_P98822")
        cmb_staff.DisplayMember = "fld_STAFF_FULL_name"
        cmb_staff.ValueMember = "fld_STAFF_id"
    End Sub
    Private Sub RefreshStatus()
        cmb_status.DataSource = run_select("select * from TBL_ORDER_STATUS_P98822")
        cmb_status.DisplayMember = "fld_ORDER_STATUS_name"
        cmb_status.ValueMember = "fld_ORDER_STATUS_id"
    End Sub

    Private Sub RefreshGrid()

        Dim sql As String = "select O.fld_order_id As Id, O.fld_order_code AS OrderCode, O.fld_order_datetime AS OrderDate, O.fld_order_customer_id as CustomerId, C.fld_customer_full_name as CustomerName, " &
            "O.fld_order_staff_id AS StaffId, S.fld_staff_full_name As StaffName, O.fld_order_status AS StatusId, ST.fld_order_status_name as Status, O.fld_order_remarks AS Remarks " &
            "from tbl_order_p98822 as O, tbl_customer_p98822 as C, tbl_staff_p98822 AS S, tbl_order_status_p98822 AS ST where O.fld_order_customer_id = C.fld_customer_id AND O.fld_order_staff_id = S.FLD_STAFF_ID AND O.FLD_ORDER_STATUS = ST.FLD_ORDER_STATUS_ID"


        dg_list.DataSource = run_select(sql)
    End Sub


    Public Function run_select(mysql As String) As DataTable
        Dim mydata As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Try
            myreader.Fill(mydata)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return mydata

    End Function

    Private Sub dg_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_list.CellClick

        Try
            Dim current_row As Integer = dg_list.CurrentRow.Index
            selected_code = dg_list(0, current_row).Value
            txt_id.Text = selected_code
            If Not IsDBNull(dg_list(1, current_row).Value) Then
                txt_code.Text = dg_list(1, current_row).Value
            End If
            If Not IsDBNull(dg_list(2, current_row).Value) Then
                txt_date.Text = dg_list(2, current_row).Value
            End If

            If Not IsDBNull(dg_list(9, current_row).Value) Then
                txt_remarks.Text = dg_list(9, current_row).Value
            End If

            txt_full_name.Text = dg_list(4, current_row).Value

            cmb_staff.SelectedValue = dg_list(5, current_row).Value
            cmb_status.SelectedValue = dg_list(7, current_row).Value


            btn_add.Text = "Update"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs)

        ClearForm()

    End Sub

    Private Sub ClearForm()
        txt_id.Text = ""
        txt_code.Text = ""
        txt_date.Text = ""

        txt_remarks.Text = ""
        txt_full_name.Text = ""

        cmb_staff.SelectedIndex = 0
        cmb_status.SelectedIndex = 0


        btn_add.Text = "Save"

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        RefreshGrid()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Not String.IsNullOrEmpty(txt_code.Text) Then

            UpdateProduct()

        End If
    End Sub

    Private Sub UpdateProduct()
        Dim mysql As String = "update tbl_order_p98822 set FLD_ORDER_STAFF_ID = " & cmb_staff.SelectedValue & ", " &
           "FLD_ORDER_STATUS = " & cmb_status.SelectedValue & ", " &
           "FLD_ORDER_REMARKS= '" & txt_remarks.Text & "' " &
            "WHERE FLD_ORDER_ID = " & txt_id.Text

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


    End Sub


    Private Sub btn_browse_Click(sender As Object, e As EventArgs)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""

        fd.Title = "Open File Dialog"
        'fd.InitialDirectory = "C:\"
        fd.Filter = "Image files (*.jpg)|*.jpg"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If


    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs)
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

    Private Sub btn_OrderItem_Click(sender As Object, e As EventArgs) Handles btn_OrderItem.Click

        Try

            Dim selected_code = Integer.Parse(txt_id.Text)

            Dim orderItemForm As New frm_orderItem_p98822
            orderItemForm.OrderId = selected_code
            orderItemForm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        If String.IsNullOrEmpty(txt_id.Text) Then
            btn_OrderItem.Visible = False
        Else
            btn_OrderItem.Visible = True
        End If
    End Sub

    Private Sub dg_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_list.CellDoubleClick
        Try
            Dim current_row As Integer = dg_list.CurrentRow.Index
            Dim selected_code = dg_list(0, current_row).Value

            Dim orderItemForm As New frm_orderItem_p98822
            orderItemForm.OrderId = selected_code
            orderItemForm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class