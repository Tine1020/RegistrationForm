<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        passtxt = New TextBox()
        addtxt = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        signbtn = New Button()
        Label1 = New Label()
        nametxt = New TextBox()
        emailtxt = New TextBox()
        SuspendLayout()
        ' 
        ' passtxt
        ' 
        passtxt.Location = New Point(328, 215)
        passtxt.Name = "passtxt"
        passtxt.Size = New Size(226, 23)
        passtxt.TabIndex = 17
        ' 
        ' addtxt
        ' 
        addtxt.Location = New Point(320, 175)
        addtxt.Name = "addtxt"
        addtxt.Size = New Size(234, 23)
        addtxt.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(246, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 15
        Label4.Text = "PASSWORD:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(246, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 14
        Label3.Text = "ADDRESS:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(246, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 13
        Label2.Text = "FULLNAME:"
        ' 
        ' signbtn
        ' 
        signbtn.BackColor = SystemColors.MenuHighlight
        signbtn.BackgroundImageLayout = ImageLayout.Center
        signbtn.FlatStyle = FlatStyle.Popup
        signbtn.Font = New Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        signbtn.Location = New Point(344, 315)
        signbtn.Name = "signbtn"
        signbtn.Size = New Size(151, 37)
        signbtn.TabIndex = 12
        signbtn.Text = "REGISTER"
        signbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(246, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 11
        Label1.Text = "EMAIL:"
        ' 
        ' nametxt
        ' 
        nametxt.Location = New Point(320, 136)
        nametxt.Name = "nametxt"
        nametxt.Size = New Size(234, 23)
        nametxt.TabIndex = 10
        ' 
        ' emailtxt
        ' 
        emailtxt.Location = New Point(304, 98)
        emailtxt.Name = "emailtxt"
        emailtxt.Size = New Size(250, 23)
        emailtxt.TabIndex = 9
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(passtxt)
        Controls.Add(addtxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(signbtn)
        Controls.Add(Label1)
        Controls.Add(nametxt)
        Controls.Add(emailtxt)
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents passtxt As TextBox
    Friend WithEvents addtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents signbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nametxt As TextBox
    Friend WithEvents emailtxt As TextBox
End Class
