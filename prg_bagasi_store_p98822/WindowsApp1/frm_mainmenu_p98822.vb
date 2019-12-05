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
        Dim frm As New frm_productcatalog_p98822
        frm.MdiParent = Me
        AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_Cart_Click(sender As Object, e As EventArgs) Handles btn_Cart.Click
        Dim frm As New frm_shoppingcart_p98822
        frm.MdiParent = Me
        AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
        AddHandler frm.ClearCart, AddressOf Me.HandleClearCart
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub HandleClearCart(sender As Object, e As EventArgs)
        btn_Cart.Text = "Shopping Cart " & "(" & shoppingCart.Count.ToString & ")"
        If shoppingCart.Count = 0 Then
            btn_Cart.ForeColor = Color.Red
        Else
            btn_Cart.ForeColor = Color.Green

        End If
    End Sub

    Private Sub btn_stafProducts_Click(sender As Object, e As EventArgs) Handles btn_stafProducts.Click
        Dim frm As New frm_productlist_p98822
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

    Private Sub btn_brand_Click(sender As Object, e As EventArgs) Handles btn_brand.Click
        Dim frm As New frm_brandList_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_luggageType_Click(sender As Object, e As EventArgs) Handles btn_luggageType.Click
        Dim frm As New frm_luggateTypeList_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_sizes_Click(sender As Object, e As EventArgs) Handles btn_sizes.Click
        Dim frm As New frm_sizeList_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_orderStatus_Click(sender As Object, e As EventArgs) Handles btn_orderStatus.Click
        Dim frm As New frm_orderStatusList_p98822
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Dim loginForm As New frm_login_customer_p98822

        If btn_customer.Text = "Customer Logout" Then
            isLogIn = False
            btn_staff.Enabled = True
            btn_customer.Enabled = True
            grp_Customer.Enabled = False
            lbl_loginInfo.Text = "Hi there, please login to purhcase!"
            btn_customer.Text = "Customer Login"
            Dim frm As New frm_productcatalog_p98822
            frm.MdiParent = Me
            AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
            frm.Dock = DockStyle.Fill
            frm.Show()
        Else
            If loginForm.ShowDialog() = DialogResult.OK Then
                lbl_loginInfo.Text = "Hi " & loggedFullName & " !. Now you can browse our Products Catalog and continue shopping. Good Day !!! "
                grp_Customer.Enabled = True
                btn_customer.Text = "Customer Logout"
                btn_staff.Enabled = False

                Dim frm As New frm_productcatalog_p98822
                frm.MdiParent = Me
                AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If

        End If


    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        Dim loginForm As New frm_login_staff

        If btn_staff.Text = "Staff Logout" Then
            isLogIn = False
            btn_staff.Enabled = True
            btn_customer.Enabled = True
            grp_Customer.Enabled = False
            grp_Staff.Enabled = False
            grp_Setting.Enabled = False

            lbl_loginInfo.Text = "Hi there, please login to purhcase!"
            btn_staff.Text = "Staff Login"

            Dim frm As New frm_productcatalog_p98822
            frm.MdiParent = Me
            AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
            frm.Dock = DockStyle.Fill
            frm.Show()
        Else
            If loginForm.ShowDialog() = DialogResult.OK Then
                lbl_loginInfo.Text = "Welcome " & loggedFullName & " !. Your are the staff here. Now you can manage this shop !!! "
                grp_Customer.Enabled = False
                grp_Staff.Enabled = True
                grp_Setting.Enabled = True
                btn_staff.Text = "Staff Logout"
                btn_customer.Enabled = False

                Dim frm As New frm_productcatalog_p98822
                frm.MdiParent = Me
                AddHandler frm.BuyClick, AddressOf Me.HandleBuyClick
                frm.Dock = DockStyle.Fill
                frm.Show()
            End If

        End If


    End Sub
End Class
