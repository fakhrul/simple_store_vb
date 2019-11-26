Imports System.Data.OleDb

Public Class frm_login_customer_p98822
    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        If String.IsNullOrEmpty(txt_fullName.Text) Then
            MsgBox("Please fill in the full name")
            Return
        End If

        If String.IsNullOrEmpty(txt_email.Text) Then
            MsgBox("Please fill in the email")
            Return
        End If

        If String.IsNullOrEmpty(txt_address.Text) Then
            MsgBox("Please fill in the address")
            Return
        End If

        If String.IsNullOrEmpty(txt_phone.Text) Then
            MsgBox("Please fill in the phone")
            Return
        End If

        If String.IsNullOrEmpty(txt_password.Text) Then
            MsgBox("Please fill in the password")
            Return
        End If

        If String.IsNullOrEmpty(txt_password2.Text) Then
            MsgBox("Please fill in the confirm password")
            Return
        End If

        If txt_password2.Text <> txt_password.Text Then
            MsgBox("Your password and confirm password is different")
            Return
        End If

        Try
            If IsCustomerExist(txt_email.Text) Then
                Throw New Exception("Email is already exist")
            End If
            AddNewProduct()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub

    Private Function IsCustomerExist(text As String) As Boolean
        Dim count As Integer = 0
        Dim mysql As String = "select count(*) from tbl_customer_p98822 where fld_customer_email = '" & txt_signin_email.Text & "'"
        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                count = command.ExecuteScalar()

            Catch ex As Exception
            End Try
        End Using

        If count > 0 Then
            Return True
        End If
        Return False

    End Function

    Private Sub AddNewProduct()
        Dim mysql As String = "insert into tbl_customer_p98822 (FLD_customer_FULL_NAME, FLD_customer_email, FLD_customer_password, FLD_customer_address, FLD_customer_PHONE) values ('" &
            txt_fullName.Text & "','" &
            txt_email.Text & "','" &
            txt_password.Text & "','" &
            txt_address.Text & "','" &
            txt_phone.Text & "')"

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(mysql)
            command.Connection = connection

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Registration success! Please login to proceed.",, "Registration")
                PopulateLogin()
                ClearAllForm()

            Catch ex As Exception
                MsgBox("Exception: " & ex.Message)
            End Try
        End Using


    End Sub

    Private Sub PopulateLogin()
        txt_signin_email.Text = txt_email.Text
        txt_signin_password.Text = txt_password.Text
    End Sub

    Private Sub ClearAllForm()
        txt_fullName.Text = ""
        txt_email.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
        txt_password.Text = ""
        txt_password2.Text = ""

    End Sub

    Private Sub btn_signIn_Click(sender As Object, e As EventArgs) Handles btn_signIn.Click
        If String.IsNullOrEmpty(txt_signin_email.Text) Then
            MsgBox("Please fill in the email")
            Return
        End If

        If String.IsNullOrEmpty(txt_signin_password.Text) Then
            MsgBox("Please fill in the password")
            Return
        End If

        Try
            If IsCustomerExist(txt_signin_email.Text) Then
                If IsAuthenticateSuccess(txt_signin_email.Text, txt_signin_password.Text) Then
                    MsgBox("Login Success.")
                    DialogResult = DialogResult.OK
                Else
                    DialogResult = DialogResult.Cancel
                    MsgBox("Login Failed.")
                End If
            Else
                MsgBox("Email adress is not exist. Please register.")

            End If
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub

    Private Function IsAuthenticateSuccess(text1 As String, text2 As String) As Boolean

        Dim sql As String = "select * from tbl_customer_p98822 where fld_customer_email = '" & txt_signin_email.Text & "'"
        Dim isSuccess As Boolean = False

        Using connection As OleDbConnection = New OleDbConnection(myconnection)
            Dim command As OleDbCommand = New OleDbCommand(sql)
            command.Connection = connection

            Try
                connection.Open()
                Dim reader As OleDb.OleDbDataReader
                reader = command.ExecuteReader()

                If reader.Read() Then
                    Dim userFullName = reader.Item(1).ToString
                    Dim userEmail = reader.Item(2).ToString
                    Dim userPassword = reader.Item(3).ToString
                    If userPassword = txt_signin_password.Text Then
                        isSuccess = True
                        loggedUserName = userEmail
                        loggedFullName = userFullName
                        loggedId = reader.Item(0)
                        isLogIn = True
                        isCustomer = True
                    End If
                End If
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        Return isSuccess

    End Function
End Class