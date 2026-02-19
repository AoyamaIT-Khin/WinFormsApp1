<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        expireDate = New DateTimePicker()
        manuDate = New DateTimePicker()
        txtPrice = New TextBox()
        txtRemark = New TextBox()
        txtBatch = New TextBox()
        txtQty = New TextBox()
        lblExpire = New Label()
        txtImported = New TextBox()
        lblRemark = New Label()
        lblManufacture = New Label()
        lblPrice = New Label()
        lblBatch = New Label()
        lblQty = New Label()
        lblImported = New Label()
        lblBrand = New Label()
        txtBrand = New TextBox()
        txtGeneric = New TextBox()
        lblGeneric = New Label()
        txtSerial = New TextBox()
        lblSerial = New Label()
        DataGridView1 = New DataGridView()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAdd = New Button()
        btnEdit = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        GroupBox1.Controls.Add(expireDate)
        GroupBox1.Controls.Add(manuDate)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtRemark)
        GroupBox1.Controls.Add(txtBatch)
        GroupBox1.Controls.Add(txtQty)
        GroupBox1.Controls.Add(lblExpire)
        GroupBox1.Controls.Add(txtImported)
        GroupBox1.Controls.Add(lblRemark)
        GroupBox1.Controls.Add(lblManufacture)
        GroupBox1.Controls.Add(lblPrice)
        GroupBox1.Controls.Add(lblBatch)
        GroupBox1.Controls.Add(lblQty)
        GroupBox1.Controls.Add(lblImported)
        GroupBox1.Controls.Add(lblBrand)
        GroupBox1.Controls.Add(txtBrand)
        GroupBox1.Controls.Add(txtGeneric)
        GroupBox1.Controls.Add(lblGeneric)
        GroupBox1.Controls.Add(txtSerial)
        GroupBox1.Controls.Add(lblSerial)
        GroupBox1.ForeColor = Color.DarkBlue
        GroupBox1.Location = New Point(2, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1366, 384)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "ItemDetail"
        ' 
        ' expireDate
        ' 
        expireDate.Location = New Point(780, 91)
        expireDate.Name = "expireDate"
        expireDate.Size = New Size(253, 27)
        expireDate.TabIndex = 17
        ' 
        ' manuDate
        ' 
        manuDate.Location = New Point(778, 41)
        manuDate.Name = "manuDate"
        manuDate.Size = New Size(255, 27)
        manuDate.TabIndex = 16
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(191, 332)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(333, 27)
        txtPrice.TabIndex = 8
        ' 
        ' txtRemark
        ' 
        txtRemark.Location = New Point(780, 128)
        txtRemark.Multiline = True
        txtRemark.Name = "txtRemark"
        txtRemark.Size = New Size(259, 81)
        txtRemark.TabIndex = 15
        ' 
        ' txtBatch
        ' 
        txtBatch.Location = New Point(191, 283)
        txtBatch.Name = "txtBatch"
        txtBatch.Size = New Size(333, 27)
        txtBatch.TabIndex = 7
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(191, 231)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(333, 27)
        txtQty.TabIndex = 6
        ' 
        ' lblExpire
        ' 
        lblExpire.AutoSize = True
        lblExpire.ForeColor = Color.Black
        lblExpire.Location = New Point(614, 90)
        lblExpire.Name = "lblExpire"
        lblExpire.Size = New Size(89, 22)
        lblExpire.TabIndex = 13
        lblExpire.Text = "Expire Date"
        ' 
        ' txtImported
        ' 
        txtImported.Location = New Point(191, 182)
        txtImported.Name = "txtImported"
        txtImported.Size = New Size(333, 27)
        txtImported.TabIndex = 5
        ' 
        ' lblRemark
        ' 
        lblRemark.AutoSize = True
        lblRemark.ForeColor = Color.Black
        lblRemark.Location = New Point(614, 137)
        lblRemark.Name = "lblRemark"
        lblRemark.Size = New Size(62, 22)
        lblRemark.TabIndex = 12
        lblRemark.Text = "Remark"
        ' 
        ' lblManufacture
        ' 
        lblManufacture.AutoSize = True
        lblManufacture.ForeColor = Color.Black
        lblManufacture.Location = New Point(614, 38)
        lblManufacture.Name = "lblManufacture"
        lblManufacture.Size = New Size(133, 22)
        lblManufacture.TabIndex = 10
        lblManufacture.Text = "Manufacture Date"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.ForeColor = Color.Black
        lblPrice.Location = New Point(51, 335)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(45, 22)
        lblPrice.TabIndex = 9
        lblPrice.Text = "Price"
        ' 
        ' lblBatch
        ' 
        lblBatch.AutoSize = True
        lblBatch.ForeColor = Color.Black
        lblBatch.Location = New Point(51, 286)
        lblBatch.Name = "lblBatch"
        lblBatch.Size = New Size(108, 22)
        lblBatch.TabIndex = 8
        lblBatch.Text = "Batch Number"
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.ForeColor = Color.Black
        lblQty.Location = New Point(51, 236)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(69, 22)
        lblQty.TabIndex = 7
        lblQty.Text = "Quantity"
        ' 
        ' lblImported
        ' 
        lblImported.AutoSize = True
        lblImported.ForeColor = Color.Black
        lblImported.Location = New Point(51, 182)
        lblImported.Name = "lblImported"
        lblImported.Size = New Size(90, 22)
        lblImported.TabIndex = 6
        lblImported.Text = "Imported ID"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.ForeColor = Color.Black
        lblBrand.Location = New Point(51, 137)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(94, 22)
        lblBrand.TabIndex = 5
        lblBrand.Text = "Brand Name"
        ' 
        ' txtBrand
        ' 
        txtBrand.Location = New Point(191, 128)
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(333, 27)
        txtBrand.TabIndex = 4
        ' 
        ' txtGeneric
        ' 
        txtGeneric.Location = New Point(191, 76)
        txtGeneric.Name = "txtGeneric"
        txtGeneric.Size = New Size(333, 27)
        txtGeneric.TabIndex = 3
        ' 
        ' lblGeneric
        ' 
        lblGeneric.AutoSize = True
        lblGeneric.ForeColor = Color.Black
        lblGeneric.Location = New Point(51, 85)
        lblGeneric.Name = "lblGeneric"
        lblGeneric.Size = New Size(106, 22)
        lblGeneric.TabIndex = 2
        lblGeneric.Text = "Generic Name"
        ' 
        ' txtSerial
        ' 
        txtSerial.Location = New Point(191, 29)
        txtSerial.Name = "txtSerial"
        txtSerial.Size = New Size(333, 27)
        txtSerial.TabIndex = 1
        ' 
        ' lblSerial
        ' 
        lblSerial.AutoSize = True
        lblSerial.ForeColor = Color.Black
        lblSerial.Location = New Point(51, 38)
        lblSerial.Name = "lblSerial"
        lblSerial.Size = New Size(107, 22)
        lblSerial.TabIndex = 0
        lblSerial.Text = "Serial Number"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 462)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1366, 268)
        DataGridView1.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 415)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(333, 27)
        txtSearch.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(375, 415)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 10
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(527, 415)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(655, 415)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(890, 413)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(1004, 413)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 14
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(770, 415)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1380, 763)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        Text = "CRUD Operation"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSerial As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtGeneric As TextBox
    Friend WithEvents lblGeneric As Label
    Friend WithEvents txtImported As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtBatch As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblBatch As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblImported As Label
    Friend WithEvents lblExpire As Label
    Friend WithEvents lblRemark As Label
    Friend WithEvents lblManufacture As Label
    Friend WithEvents txtExpire As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents manuDate As DateTimePicker
    Friend WithEvents expireDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblBrand As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents btnDelete As Button
End Class
