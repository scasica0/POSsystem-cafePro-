<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditFoodProduct
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
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSubmit = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtInventory = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(95, 185)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(54, 35)
        Me.bttnCancel.TabIndex = 13
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Location = New System.Drawing.Point(7, 185)
        Me.bttnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(73, 35)
        Me.bttnSubmit.TabIndex = 12
        Me.bttnSubmit.Text = "Submit"
        Me.bttnSubmit.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(7, 121)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(51, 13)
        Me.lblAddress.TabIndex = 32
        Me.lblAddress.Text = "Inventory"
        '
        'txtInventory
        '
        Me.txtInventory.Location = New System.Drawing.Point(7, 136)
        Me.txtInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Size = New System.Drawing.Size(142, 20)
        Me.txtInventory.TabIndex = 6
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(7, 85)
        Me.lblEmpID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(34, 13)
        Me.lblEmpID.TabIndex = 30
        Me.lblEmpID.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(7, 99)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(142, 20)
        Me.txtPrice.TabIndex = 3
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(7, 47)
        Me.lblLname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(52, 13)
        Me.lblLname.TabIndex = 28
        Me.lblLname.Text = "Category:"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(7, 62)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(142, 20)
        Me.txtCategory.TabIndex = 2
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(7, 10)
        Me.lblFname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(38, 13)
        Me.lblFname.TabIndex = 26
        Me.lblFname.Text = "Name:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(7, 24)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(142, 20)
        Me.txtname.TabIndex = 1
        '
        'AddFoodProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(162, 242)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtInventory)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddFoodProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSubmit As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtInventory As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblLname As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents txtname As TextBox
End Class
