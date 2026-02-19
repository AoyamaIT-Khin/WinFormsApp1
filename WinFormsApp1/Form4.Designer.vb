<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblAddress = New Label()
        lblGender = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtAddress = New TextBox()
        radioMale = New RadioButton()
        radioFemale = New RadioButton()
        Label2 = New Label()
        lblPassword = New Label()
        lblConfirmPassword = New Label()
        txtPhone = New TextBox()
        txtPass = New TextBox()
        txtConfirmPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(122, 53)
        lblName.Name = "lblName"
        lblName.Size = New Size(51, 19)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(122, 120)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 19)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(122, 245)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(68, 19)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGender.Location = New Point(122, 181)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(65, 19)
        lblGender.TabIndex = 3
        lblGender.Text = "Gender"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(298, 49)
        txtName.Name = "txtName"
        txtName.Size = New Size(315, 27)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(298, 116)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(315, 27)
        txtEmail.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(303, 241)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(315, 81)
        txtAddress.TabIndex = 6
        ' 
        ' radioMale
        ' 
        radioMale.AutoSize = True
        radioMale.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radioMale.Location = New Point(303, 177)
        radioMale.Name = "radioMale"
        radioMale.Size = New Size(68, 23)
        radioMale.TabIndex = 7
        radioMale.TabStop = True
        radioMale.Text = "Male"
        radioMale.UseVisualStyleBackColor = True
        ' 
        ' radioFemale
        ' 
        radioFemale.AutoSize = True
        radioFemale.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radioFemale.Location = New Point(420, 177)
        radioFemale.Name = "radioFemale"
        radioFemale.Size = New Size(85, 23)
        radioFemale.TabIndex = 8
        radioFemale.TabStop = True
        radioFemale.Text = "Female"
        radioFemale.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(122, 369)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 19)
        Label2.TabIndex = 10
        Label2.Text = "Phone"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(122, 449)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(81, 19)
        lblPassword.TabIndex = 11
        lblPassword.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmPassword.Location = New Point(122, 526)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(148, 19)
        lblConfirmPassword.TabIndex = 12
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(303, 365)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(310, 27)
        txtPhone.TabIndex = 13
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(303, 441)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(310, 27)
        txtPass.TabIndex = 14
        txtPass.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(303, 522)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(310, 27)
        txtConfirmPassword.TabIndex = 15
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(314, 671)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 16
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(454, 671)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1168, 800)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPass)
        Controls.Add(txtPhone)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblPassword)
        Controls.Add(Label2)
        Controls.Add(radioFemale)
        Controls.Add(radioMale)
        Controls.Add(txtAddress)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGender)
        Controls.Add(lblAddress)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "RegisterForm"
        Text = "Register Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
End Class
