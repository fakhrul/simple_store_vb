﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_buy = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_price)
        Me.Panel1.Controls.Add(Me.lbl_size)
        Me.Panel1.Controls.Add(Me.lbl_type)
        Me.Panel1.Controls.Add(Me.lbl_brand)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.btn_buy)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 233)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 256)
        Me.Panel1.TabIndex = 0
        '
        'lbl_price
        '
        Me.lbl_price.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_price.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Green
        Me.lbl_price.Location = New System.Drawing.Point(0, 159)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(304, 35)
        Me.lbl_price.TabIndex = 5
        Me.lbl_price.Text = "Price"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_size
        '
        Me.lbl_size.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_size.Location = New System.Drawing.Point(0, 124)
        Me.lbl_size.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(304, 35)
        Me.lbl_size.TabIndex = 4
        Me.lbl_size.Text = "Size"
        Me.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_type
        '
        Me.lbl_type.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_type.Location = New System.Drawing.Point(0, 89)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(304, 35)
        Me.lbl_type.TabIndex = 3
        Me.lbl_type.Text = "Type"
        Me.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_brand
        '
        Me.lbl_brand.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_brand.Location = New System.Drawing.Point(0, 54)
        Me.lbl_brand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(304, 35)
        Me.lbl_brand.TabIndex = 2
        Me.lbl_brand.Text = "Brand"
        Me.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(304, 54)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_buy
        '
        Me.btn_buy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_buy.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buy.Location = New System.Drawing.Point(0, 198)
        Me.btn_buy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_buy.Name = "btn_buy"
        Me.btn_buy.Size = New System.Drawing.Size(304, 58)
        Me.btn_buy.TabIndex = 0
        Me.btn_buy.Text = "Buy"
        Me.btn_buy.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 233)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 233)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'uc_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "uc_product"
        Me.Size = New System.Drawing.Size(304, 489)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buy As Button
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
