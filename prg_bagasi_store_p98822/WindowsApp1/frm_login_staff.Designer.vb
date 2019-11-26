<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login_staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_signin_email = New System.Windows.Forms.TextBox()
        Me.txt_signin_password = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_signIn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
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
        Me.txt_signin_email.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_signin_email.MaxLength = 50
        Me.txt_signin_email.Name = "txt_signin_email"
        Me.txt_signin_email.Size = New System.Drawing.Size(324, 27)
        Me.txt_signin_email.TabIndex = 0
        Me.txt_signin_email.Text = "fakhrul"
        '
        'txt_signin_password
        '
        Me.txt_signin_password.Location = New System.Drawing.Point(177, 207)
        Me.txt_signin_password.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_signin_password.MaxLength = 50
        Me.txt_signin_password.Name = "txt_signin_password"
        Me.txt_signin_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_signin_password.Size = New System.Drawing.Size(324, 27)
        Me.txt_signin_password.TabIndex = 1
        Me.txt_signin_password.Text = "qwe123"
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
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(573, 475)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existing Customer"
        '
        'btn_signIn
        '
        Me.btn_signIn.Location = New System.Drawing.Point(337, 258)
        Me.btn_signIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_signIn.Name = "btn_signIn"
        Me.btn_signIn.Size = New System.Drawing.Size(167, 81)
        Me.btn_signIn.TabIndex = 2
        Me.btn_signIn.Text = "Sign In"
        Me.btn_signIn.UseVisualStyleBackColor = True
        '
        'frm_login_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_login_staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_signin_email As TextBox
    Friend WithEvents txt_signin_password As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_signIn As Button
End Class
