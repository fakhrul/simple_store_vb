Imports WindowsApp1

Public Class frm_mainmenu_p98822
    Private Sub brn_ProductList_Click(sender As Object, e As EventArgs) Handles brn_ProductList.Click
        Dim frm As New frm_productcatalog_p98822
        frm.MdiParent = Me
        AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub HandleBuyClick(sender As Object, e As BuyClickEventArgs)
        btn_Cart.Text = "Shopping Cart " & "(" & shoppingCart.Count.ToString & ")"
        If shoppingCart.Count = 0 Then
            btn_Cart.ForeColor = Color.Red
        Else
            btn_Cart.ForeColor = Color.Green

        End If

    End Sub

    Private Sub btn_OrderList_Click(sender As Object, e As EventArgs) Handles btn_OrderHistory.Click
        Dim frm As New frm_orderhistory_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_Profile_Click(sender As Object, e As EventArgs) Handles btn_Profile.Click
        Dim frm As New frm_profile_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub frm_mainmenu_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim frm As New frm_productcatalog_p98822
        'frm.MdiParent = Me
        'AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
        'frm.Dock = DockStyle.Fill
        'frm.Show()
    End Sub

    Private Sub btn_Cart_Click(sender As Object, e As EventArgs) Handles btn_Cart.Click
        Dim frm As New frm_cart_p98822
        frm.MdiParent = Me
        AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_stafProducts_Click(sender As Object, e As EventArgs) Handles btn_stafProducts.Click
        Dim frm As New frm_stafflist_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm As New frm_customerlist_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_orderList_Click_1(sender As Object, e As EventArgs) Handles btn_orderList.Click
        Dim frm As New frm_orderlist_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_staffList_Click(sender As Object, e As EventArgs) Handles btn_staffList.Click
        Dim frm As New frm_stafflist_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub
End Class
