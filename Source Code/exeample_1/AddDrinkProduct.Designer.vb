﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddDrinkProduct
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
        Me.txtMediumPrice = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtSmallPrice = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLargePrice = New System.Windows.Forms.TextBox()
        Me.Inventory = New System.Windows.Forms.Label()
        Me.txtInventory = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(140, 260)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(54, 35)
        Me.bttnCancel.TabIndex = 13
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Location = New System.Drawing.Point(52, 260)
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
        Me.lblAddress.Size = New System.Drawing.Size(74, 13)
        Me.lblAddress.TabIndex = 32
        Me.lblAddress.Text = "Medium Price:"
        '
        'txtMediumPrice
        '
        Me.txtMediumPrice.Location = New System.Drawing.Point(7, 136)
        Me.txtMediumPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMediumPrice.Name = "txtMediumPrice"
        Me.txtMediumPrice.Size = New System.Drawing.Size(235, 20)
        Me.txtMediumPrice.TabIndex = 6
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(7, 85)
        Me.lblEmpID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(62, 13)
        Me.lblEmpID.TabIndex = 30
        Me.lblEmpID.Text = "Small Price:"
        '
        'txtSmallPrice
        '
        Me.txtSmallPrice.Location = New System.Drawing.Point(7, 99)
        Me.txtSmallPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSmallPrice.Name = "txtSmallPrice"
        Me.txtSmallPrice.Size = New System.Drawing.Size(235, 20)
        Me.txtSmallPrice.TabIndex = 3
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(7, 47)
        Me.lblLname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(34, 13)
        Me.lblLname.TabIndex = 28
        Me.lblLname.Text = "Type:"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(7, 62)
        Me.txtType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(235, 20)
        Me.txtType.TabIndex = 2
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
        Me.txtname.Size = New System.Drawing.Size(235, 20)
        Me.txtname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Large Price:"
        '
        'txtLargePrice
        '
        Me.txtLargePrice.Location = New System.Drawing.Point(7, 175)
        Me.txtLargePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLargePrice.Name = "txtLargePrice"
        Me.txtLargePrice.Size = New System.Drawing.Size(235, 20)
        Me.txtLargePrice.TabIndex = 33
        '
        'Inventory
        '
        Me.Inventory.AutoSize = True
        Me.Inventory.Location = New System.Drawing.Point(7, 200)
        Me.Inventory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(54, 13)
        Me.Inventory.TabIndex = 36
        Me.Inventory.Text = "Inventory:"
        '
        'txtInventory
        '
        Me.txtInventory.Location = New System.Drawing.Point(7, 215)
        Me.txtInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Size = New System.Drawing.Size(235, 20)
        Me.txtInventory.TabIndex = 35
        '
        'AddDrinkProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(256, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Inventory)
        Me.Controls.Add(Me.txtInventory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLargePrice)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtMediumPrice)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.txtSmallPrice)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddDrinkProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSubmit As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtMediumPrice As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtSmallPrice As TextBox
    Friend WithEvents lblLname As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLargePrice As System.Windows.Forms.TextBox
    Friend WithEvents Inventory As System.Windows.Forms.Label
    Friend WithEvents txtInventory As System.Windows.Forms.TextBox
End Class
