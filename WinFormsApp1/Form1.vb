Imports System.Data.SqlClient

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim conn As New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True")
        conn.Open()
        Dim logincmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p", conn)
        logincmd.Parameters.AddWithValue("@u", txtUsername.Text)
        logincmd.Parameters.AddWithValue("@p", txtPassword.Text)
        Dim count As Integer = Convert.ToInt64(logincmd.ExecuteScalar)
        conn.Close()
        If count > 0 Then
            MessageBox.Show("Login Successful!")
        Else
            MessageBox.Show("Login Failed! Invalid username or password.")
        End If
    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not showPassword.Checked
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class