Imports System.Data.SqlClient
Imports Windows.Win32.System
Public Class Form2
    Dim conn As New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn.Open()
        Dim cmd As New SqlCommand("INSERT INTO ItemDetail (SerialNumber, GenericName, ImportedId, Qty, BatchNumber, Price, ManufactureDate, ExpireDate, Remark) VALUES ('" & txtSerial.Text & "','" & txtGeneric.Text & "','" & txtImported.Text & "','" & txtQty.Text & "','" & txtBatch.Text & "','" & txtPrice.Text & "','" & manuDate.Value.ToLocalTime & "','" & expireDate.Value.ToLocalTime & "','" & txtRemark.Text & "')", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Saved Successfully!")
        txtSerial.Clear()
        txtGeneric.Clear()
        txtImported.Clear()
        txtQty.Clear()
        txtBatch.Clear()
        txtPrice.Clear()
        txtRemark.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSerial.Clear()
        txtGeneric.Clear()
        txtImported.Clear()
        txtQty.Clear()
        txtBatch.Clear()
        txtPrice.Clear()
        txtRemark.Clear()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterdata("")
    End Sub

    Public Sub filterdata(valuetosearch As String)
        Dim searchquery As String = "SELECT * FROM ItemDetail WHERE SerialNumber like '%" & valuetosearch & "%'"
        Dim cmd As New SqlCommand(searchquery, conn)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class