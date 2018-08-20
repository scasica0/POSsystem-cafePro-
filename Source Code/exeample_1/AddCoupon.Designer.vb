<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCoupon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCoupon))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tenOff = New System.Windows.Forms.Button()
        Me.fiftyOff = New System.Windows.Forms.Button()
        Me.twentyfiveOff = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.exitButton)
        Me.GroupBox1.Controls.Add(Me.tenOff)
        Me.GroupBox1.Controls.Add(Me.fiftyOff)
        Me.GroupBox1.Controls.Add(Me.twentyfiveOff)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 265)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Coupon"
        '
        'tenOff
        '
        Me.tenOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenOff.Location = New System.Drawing.Point(28, 55)
        Me.tenOff.Name = "tenOff"
        Me.tenOff.Size = New System.Drawing.Size(115, 80)
        Me.tenOff.TabIndex = 3
        Me.tenOff.Text = "10% off"
        Me.tenOff.UseVisualStyleBackColor = True
        '
        'fiftyOff
        '
        Me.fiftyOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiftyOff.Location = New System.Drawing.Point(270, 55)
        Me.fiftyOff.Name = "fiftyOff"
        Me.fiftyOff.Size = New System.Drawing.Size(115, 80)
        Me.fiftyOff.TabIndex = 2
        Me.fiftyOff.Text = "50% off"
        Me.fiftyOff.UseVisualStyleBackColor = True
        '
        'twentyfiveOff
        '
        Me.twentyfiveOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twentyfiveOff.Location = New System.Drawing.Point(149, 55)
        Me.twentyfiveOff.Name = "twentyfiveOff"
        Me.twentyfiveOff.Size = New System.Drawing.Size(115, 80)
        Me.twentyfiveOff.TabIndex = 1
        Me.twentyfiveOff.Text = "25% off"
        Me.twentyfiveOff.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(138, 166)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(141, 80)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Cancel"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'AddCoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(435, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddCoupon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tenOff As System.Windows.Forms.Button
    Friend WithEvents fiftyOff As System.Windows.Forms.Button
    Friend WithEvents twentyfiveOff As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
