Public Class Form3
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LstSelectBox.Items.Add(ListBoxSelectedGame.SelectedItem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LstSelectBox.Items.Remove(ListBoxSelectedGame.SelectedItem)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim firsName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim strSelectedGames As String = ""

        strSelectedGames = ListBoxSelectedGame.SelectedItem

        MessageBox.Show("Hello " & firsName & " " & lastName & " your email is " & email & "& you would like to play " & strSelectedGames)
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
    End Sub
End Class
