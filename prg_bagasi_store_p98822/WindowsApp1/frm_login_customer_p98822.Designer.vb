<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_customer_p98822
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_signin_email = New System.Windows.Forms.TextBox()
        Me.txt_signin_password = New System.Windows.Forms.TextBox()
        Me.txt_password2 = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_fullName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_signIn = New System.Windows.Forms.Button()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txt_signin_email
        '
        Me.txt_signin_email.Location = New System.Drawing.Point(177, 158)
        Me.txt_signin_email.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_signin_email.MaxLength = 50
        Me.txt_signin_email.Name = "txt_signin_email"
        Me.txt_signin_email.Size = New System.Drawing.Size(324, 27)
        Me.txt_signin_email.TabIndex = 0
        Me.txt_signin_email.Text = "fakhrulazran@gmail.com"
        '
        'txt_signin_password
        '
        Me.txt_signin_password.Location = New System.Drawing.Point(177, 207)
        Me.txt_signin_password.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_signin_password.MaxLength = 50
        Me.txt_signin_password.Name = "txt_signin_password"
        Me.txt_signin_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_signin_password.Size = New System.Drawing.Size(324, 27)
        Me.txt_signin_password.TabIndex = 1
        Me.txt_signin_password.Text = "qwe123"
        '
        'txt_password2
        '
        Me.txt_password2.Location = New System.Drawing.Point(195, 443)
        Me.txt_password2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_password2.MaxLength = 50
        Me.txt_password2.Name = "txt_password2"
        Me.txt_password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password2.Size = New System.Drawing.Size(324, 27)
        Me.txt_password2.TabIndex = 5
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(195, 94)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(324, 27)
        Me.txt_email.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 447)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_signIn)
        Me.GroupBox1.Controls.Add(Me.txt_signin_email)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_signin_password)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(573, 611)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existing Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Register)
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_phone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_fullName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_password2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(603, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(585, 611)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Customer"
        '
        'txt_fullName
        '
        Me.txt_fullName.Location = New System.Drawing.Point(195, 47)
        Me.txt_fullName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_fullName.MaxLength = 50
        Me.txt_fullName.Name = "txt_fullName"
        Me.txt_fullName.Size = New System.Drawing.Size(324, 27)
        Me.txt_fullName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Full Name"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(195, 136)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_address.MaxLength = 250
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(324, 162)
        Me.txt_address.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(195, 310)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_phone.MaxLength = 10
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(324, 27)
        Me.txt_phone.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 315)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(195, 401)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_password.MaxLength = 50
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(324, 27)
        Me.txt_password.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 405)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Password"
        '
        'btn_signIn
        '
        Me.btn_signIn.Location = New System.Drawing.Point(337, 258)
        Me.btn_signIn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn_signIn.Name = "btn_signIn"
        Me.btn_signIn.Size = New System.Drawing.Size(167, 81)
        Me.btn_signIn.TabIndex = 2
        Me.btn_signIn.Text = "Sign In"
        Me.btn_signIn.UseVisualStyleBackColor = True
        '
        'btn_Register
        '
        Me.btn_Register.Location = New System.Drawing.Point(355, 507)
        Me.btn_Register.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(167, 81)
        Me.btn_Register.TabIndex = 6
        Me.btn_Register.Text = "Register"
        Me.btn_Register.UseVisualStyleBackColor = True
        '
        'frm_login_customer_p98822
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 646)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frm_login_customer_p98822"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_signin_email As TextBox
    Friend WithEvents txt_signin_password As TextBox
    Friend WithEvents txt_password2 As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_signIn As Button
    Friend WithEvents btn_Register As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_fullName As TextBox
    Friend WithEvents Label5 As Label
End Class
