Public Class frm_orderhistory_p98822
    Private Sub frm_orderhistory_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub


    Private Sub RefreshGrid()

        Dim sql As String = "select O.fld_order_id As Id, O.fld_order_code AS OrderCode, O.fld_order_datetime AS OrderDate, O.fld_order_customer_id as CustomerId, C.fld_customer_full_name as CustomerName, " &
            "O.fld_order_staff_id AS StaffId, S.fld_staff_full_name As StaffName, O.fld_order_status AS StatusId, ST.fld_order_status_name as Status, O.fld_order_remarks AS Remarks " &
            "from tbl_order_p98822 as O, tbl_customer_p98822 as C, tbl_staff_p98822 AS S, tbl_order_status_p98822 AS ST where O.fld_order_customer_id = C.fld_customer_id AND O.fld_order_staff_id = S.FLD_STAFF_ID AND O.FLD_ORDER_STATUS = ST.FLD_ORDER_STATUS_ID AND C.fld_customer_id =" & loggedId


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
End Class