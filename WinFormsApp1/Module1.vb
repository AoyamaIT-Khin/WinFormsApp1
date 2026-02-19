Imports System.Data.SqlClient

Module Module1
    Dim conn As New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True")

    Public Sub Connect()
        If conn.State = ConnectionState.Closed Then
        End If
        End
    End Sub
    Public Function InsertUpdateDelete(query As String) As Boolean
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        Dim rows As Integer = cmd.ExecuteNonQuery()
        conn.Close()

        If rows > 0 Then
            Return True    ' Delete/Insert/Update happened
        Else
            Return False   ' No row affected
        End If
    End Function


    Public Function IsConfirm(ByVal message As String) As Boolean
        'function for confirm the action of the user'
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function QueryAsDataTable(query As String) As DataTable
        'function for datatable to show the data in datagridview'
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(query, conn)
        da.Fill(dt)
        Return dt
    End Function
End Module
