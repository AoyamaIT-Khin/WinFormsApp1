Imports System.Data.SqlClient
Imports Windows.Win32.System
Public Class Form2
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'first check the validity durind update'
        If vld(txtSerial, txtGeneric, txtBrand, txtImported, txtQty, txtBatch, txtPrice, txtRemark) = False Then
            MsgBox("Complete the form first", MsgBoxStyle.Critical)
        Else
            'check the duplicate entry'
            conn.Open()
            Dim exitSerial As New SqlCommand("SELECT COUNT(*) FROM ItemDetail WHERE SerialNumber='" & txtSerial.Text & "'", conn)
            Dim count As Integer = Convert.ToInt32(exitSerial.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Duplicate entry! Serial Number already exists.")
            Else
                Dim insertCmd As String = "INSERT INTO ItemDetail (SerialNumber, GenericName, BrandName, ImportedId, Qty, BatchNumber, Price, ManufactureDate, ExpireDate, Remark) VALUES ('" & txtSerial.Text & "','" & txtGeneric.Text & "','" & txtBrand.Text & "','" & txtImported.Text & "','" & txtQty.Text & "','" & txtBatch.Text & "','" & txtPrice.Text & "','" & manuDate.Value.ToLocalTime & "','" & expireDate.Value.ToLocalTime & "','" & txtRemark.Text & "')"
                'Dim inst As New SqlCommand("INSERT INTO ItemDetail (SerialNumber, GenericName, BrandName, ImportedId, Qty, BatchNumber, Price, ManufactureDate, ExpireDate, Remark) VALUES ('" & txtSerial.Text & "','" & txtGeneric.Text & "','" & txtBrand.Text & "','" & txtImported.Text & "','" & txtQty.Text & "','" & txtBatch.Text & "','" & txtPrice.Text & "','" & manuDate.Value.ToLocalTime & "','" & expireDate.Value.ToLocalTime & "','" & txtRemark.Text & "')", conn)
                InsertUpdateDelete(insertCmd)
                MessageBox.Show("Saved Successfully!")
                conn.Close()
                filterdata("")
            End If
        End If
        txtSerial.Clear()
        txtGeneric.Clear()
        txtBrand.Clear()
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
        Dim searchquery As String = "SELECT * FROM ItemDetail WHERE CONCAT(SerialNumber, GenericName, BrandName) like '%" & valuetosearch & "%'"
        Dim cmd As New SqlCommand(searchquery, conn)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If vld(txtSerial, txtGeneric, txtImported, txtQty, txtBatch, txtPrice) = False Then
            MsgBox("Complete the form first", MsgBoxStyle.Critical)
        Else
            'check for data item avaliability'
            conn.Open()
            Dim cmd As New SqlCommand("select SerialNumber from ItemDetail where serialNumber=@serialNumber", conn)
            cmd.Parameters.AddWithValue("@serialNumber", txtSerial.Text)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                Dim updateCmd As String = "UPDATE ItemDetail SET GenericName='" & txtGeneric.Text & "', ImportedId='" & txtImported.Text & "', Qty='" & txtQty.Text & "', BatchNumber='" & txtBatch.Text & "', Price='" & txtPrice.Text & "', ManufactureDate='" & manuDate.Value.ToLocalTime & "', ExpireDate='" & expireDate.Value.ToLocalTime & "', Remark='" & txtRemark.Text & "' WHERE SerialNumber='" & txtSerial.Text & "'"
                'Dim updateCmd As New SqlCommand("UPDATE ItemDetail SET GenericName=@GenericName, ImportedId=@ImportedId, Qty=@Qty, BatchNumber=@BatchNumber, Price=@Price, ManufactureDate=@ManufactureDate, ExpireDate=@ExpireDate, Remark=@Remark WHERE SerialNumber=@SerialNumber", conn)
                InsertUpdateDelete(updateCmd)
                MessageBox.Show("Updated Successfully!")
                'now clear form controls'
                txtSerial.Clear()
                txtGeneric.Clear()
                txtBrand.Clear()
                txtImported.Clear()
                txtQty.Clear()
                txtBatch.Clear()
                txtPrice.Clear()
                txtRemark.Clear()
            Else
                MessageBox.Show("Data not found! Please check the Serial Number.")
                reader.Close()
                conn.Close()
                Return
            End If
            conn.Close()
            filterdata("")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtSerial.Text = selectedRow.Cells(0).Value.ToString()
        txtGeneric.Text = selectedRow.Cells(1).Value.ToString()
        txtBrand.Text = selectedRow.Cells(2).Value.ToString()
        txtImported.Text = selectedRow.Cells(3).Value.ToString()
        txtQty.Text = selectedRow.Cells(4).Value.ToString()
        txtBatch.Text = selectedRow.Cells(5).Value.ToString()
        txtPrice.Text = selectedRow.Cells(6).Value.ToString()
        manuDate.Value = Convert.ToDateTime(selectedRow.Cells(7).Value)
        expireDate.Value = Convert.ToDateTime(selectedRow.Cells(8).Value)
        txtRemark.Text = selectedRow.Cells(9).Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filterdata(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        filterdata(txtSearch.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'check the data availability'
        If vld(txtSerial) = False Then
            MsgBox("Please enter the Serial Number to delete the record.", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Are you sure you want to delete this record?") Then
            Dim deletesql As String = "DELETE FROM ItemDetail WHERE SerialNumber='" & txtSerial.Text & "'"
            If InsertUpdateDelete(deletesql) Then
                MessageBox.Show("Deleted Successfully!")
                filterdata("")
                'clear form controls'
                txtSerial.Clear()
                txtGeneric.Clear()
                txtBrand.Clear()
                txtImported.Clear()
                txtQty.Clear()
                txtBatch.Clear()
                txtPrice.Clear()
                txtRemark.Clear()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Controls.Clear()
        InitializeComponent()
        Form2_Load(sender, e)
        Refresh()
    End Sub
End Class