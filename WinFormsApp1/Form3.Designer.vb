<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSubmit = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        lblEmail = New Label()
        txtEmail = New TextBox()
        ListBoxSelectedGame = New ListBox()
        LstSelectBox = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(164, 290)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(243, 45)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(268, 27)
        txtFirstName.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(94, 48)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(76, 20)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "FirstName"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(243, 118)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(268, 27)
        txtLastName.TabIndex = 3
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(95, 113)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(75, 20)
        lblLastName.TabIndex = 4
        lblLastName.Text = "LastName"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(95, 190)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(243, 195)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(267, 27)
        txtEmail.TabIndex = 6
        ' 
        ' ListBoxSelectedGame
        ' 
        ListBoxSelectedGame.FormattingEnabled = True
        ListBoxSelectedGame.Items.AddRange(New Object() {"FootBall", "Tennis", "BasketBall"})
        ListBoxSelectedGame.Location = New Point(618, 118)
        ListBoxSelectedGame.Name = "ListBoxSelectedGame"
        ListBoxSelectedGame.Size = New Size(150, 104)
        ListBoxSelectedGame.TabIndex = 7
        ' 
        ' LstSelectBox
        ' 
        LstSelectBox.FormattingEnabled = True
        LstSelectBox.Location = New Point(909, 113)
        LstSelectBox.Name = "LstSelectBox"
        LstSelectBox.Size = New Size(150, 104)
        LstSelectBox.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(656, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 9
        Label1.Text = "Select Games"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(913, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 10
        Label2.Text = "Selected Games"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(788, 129)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = ">>"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(788, 186)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "<<"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1139, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LstSelectBox)
        Controls.Add(ListBoxSelectedGame)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ListBoxSelectedGame As ListBox
    Friend WithEvents LstSelectBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
