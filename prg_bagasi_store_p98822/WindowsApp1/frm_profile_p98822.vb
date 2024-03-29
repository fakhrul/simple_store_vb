﻿Imports System.Data.OleDb
Imports WindowsApp1

Public Class frm_profile_p98822
    Dim selected_code As Integer

    Private Sub frm_productlist_p98822_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        Dim sql As String = "select * from tbl_customer_p98822 where fld_customer_id = " & loggedId
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
            If Not IsDBNull(dg_list(2, current_row).Value) Then
                txt_email.Text = dg_list(2, current_row).Value
            End If
            If Not IsDBNull(dg_list(5, current_row).Value) Then
                txt_phone.Text = dg_list(5, current_row).Value
            End If

            If Not IsDBNull(dg_list(4, current_row).Value) Then
                txt_address.Text = dg_list(4, current_row).Value
            End If

            If Not IsDBNull(dg_list(3, current_row).Value) Then
                txt_password.Text = dg_list(3, current_row).Value
            End If

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
        txt_name.Text = ""
        txt_email.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""
        txt_password.Text = ""

        btn_add.Text = "Save"

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs)
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
        Dim mysql As String = "update tbl_customer_p98822 set FLD_CUSTOMER_FULL_NAME = '" & txt_name.Text & "'," &
            "FLD_CUSTOMER_PASSWORD = '" & txt_password.Text & "'," &
            "FLD_CUSTOMER_ADDRESS = '" & txt_address.Text & "'," &
            "FLD_CUSTOMER_EMAIL = '" & txt_email.Text & "'," &
            "FLD_CUSTOMER_PHONE = '" & txt_phone.Text & "' " &
            "WHERE FLD_CUSTOMER_ID = " & txt_id.Text

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

    Private Sub AddNewProduct()
        Dim mysql As String = "insert into tbl_CUSTOMER_p98822 (FLD_CUSTOMER_FULL_NAME, FLD_CUSTOMER_PASSWORD, FLD_CUSTOMER_ADDRESS, FLD_CUSTOMER_EMAIL, FLD_CUSTOMER_PHONE) values ('" &
            txt_name.Text & "','" &
            txt_password.Text & "','" &
            txt_address.Text & "','" &
            txt_email.Text & "','" &
            txt_phone.Text & "')"

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


    Private Sub btn_delete_Click(sender As Object, e As EventArgs)
        Dim delete_confirmation = MsgBox("Are you sure you want to delete item " & txt_id.Text & "?", MsgBoxStyle.YesNo, "WARNING!")

        If delete_confirmation = MsgBoxResult.Yes Then
            run_command("delete from tbl_CUSTOMER_p98822 where fld_CUSTOMER_id = " & txt_id.Text & "")

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