Imports System.Data.SqlClient
Imports System.Net

Public Class RegisterForm
    Dim conn As New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True")
    Private Function vld(ParamArray txt As TextBox()) As Boolean
        For Each t As TextBox In txt
            If String.IsNullOrEmpty(t.Text) Then
                MessageBox.Show("Please fill all the fields!")
                Return False
            End If
        Next
        Return True
    End Function

    Public Function InsertUpdateDelete(cmd As SqlCommand) As Boolean
        Try
            cmd.Connection = conn

            If conn.State = ConnectionState.Open Then
                conn.Close() ' ensure closed
            End If

            conn.Open()
            Dim rows As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            Return rows > 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
            Return False
        End Try
    End Function



    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If vld(txtName, txtEmail, txtAddress, txtPass, txtConfirmPassword) = False Then
            MessageBox.Show("Please fill all the fields!")
        ElseIf txtPass.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match!")
        Else
            conn.Open()
            Dim existEmail As New SqlCommand("SELECT COUNT(*) FROM USERS WHERE Email='" & txtEmail.Text & "'", conn)
            Dim count As Integer = Convert.ToInt32(existEmail.ExecuteScalar)
            If count > 0 Then
                MessageBox.Show("Email already exists! Please use a different email.")
            Else
                Dim userId As String = Guid.NewGuid().ToString()
                Dim gender As String = If(radioMale.Checked, "Male", "Female")
                ' Insert Command
                Dim insertCmd As New SqlCommand("
        INSERT INTO Users (UserId, UserName, Address, Gender, Phone, Email, Password)
        VALUES (@UserId, @UserName, @Address, @Gender, @Phone, @Email, @Password)
    ")

                insertCmd.Parameters.AddWithValue("@UserId", userId)
                insertCmd.Parameters.AddWithValue("@UserName", txtName.Text)
                insertCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                insertCmd.Parameters.AddWithValue("@Gender", gender)
                insertCmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                insertCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                insertCmd.Parameters.AddWithValue("@Password", txtPass.Text)

                ' Save to DB
                If InsertUpdateDelete(insertCmd) Then
                    MessageBox.Show("Saved Successfully!")
                Else
                    MessageBox.Show("Error saving data!")
                End If
                conn.Close()

                txtName.Clear()
                txtAddress.Clear()
                txtPhone.Clear()
                txtEmail.Clear()
                txtPass.Clear()
                radioMale.Checked = False
                radioFemale.Checked = False
                txtConfirmPassword.Clear()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtPass.Clear()
        radioMale.Checked = False
        radioFemale.Checked = False
        txtConfirmPassword.Clear()
    End Sub
End Class