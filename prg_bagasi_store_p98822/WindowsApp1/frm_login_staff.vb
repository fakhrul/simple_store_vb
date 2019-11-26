Imports System.Data.OleDb

Public Class frm_login_staff

    Private Function IsCustomerExist(text As String) As Boolean
        Dim count As Integer = 0
        Dim mysql As String = "select count(*) from tbl_staff_p98822 where fld_staff_user_name = '" & txt_signin_email.Text & "'"
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



    Private Sub btn_signIn_Click(sender As Object, e As EventArgs) Handles btn_signIn.Click
        If String.IsNullOrEmpty(txt_signin_email.Text) Then
            MsgBox("Please fill in the user name")
            Return
        End If

        If String.IsNullOrEmpty(txt_signin_password.Text) Then
            MsgBox("Please fill in the password")
            Return
        End If

        Try
            If IsCustomerExist(txt_signin_email.Text) Then
                If IsAuthenticateSuccess(txt_signin_email.Text, txt_signin_password.Text) Then
                    DialogResult = DialogResult.OK
                Else
                    DialogResult = DialogResult.Cancel
                    MsgBox("Login Failed.")
                End If
            Else
                MsgBox("User name is not exist. Please register.")

            End If
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub

    Private Function IsAuthenticateSuccess(text1 As String, text2 As String) As Boolean

        Dim sql As String = "select * from tbl_staff_p98822 where fld_staff_user_name= '" & txt_signin_email.Text & "'"
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
                    Dim userEmail = reader.Item(4).ToString
                    Dim userName = reader.Item(3).ToString
                    Dim userPassword = reader.Item(5).ToString
                    If userPassword = txt_signin_password.Text Then
                        isSuccess = True
                        loggedUserName = userName
                        loggedEmail = userEmail
                        loggedFullName = userFullName
                        loggedId = reader.Item(0)
                        isLogIn = True
                        isCustomer = False
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