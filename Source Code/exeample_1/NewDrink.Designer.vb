<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDrink
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
        Me.dgvAddDrink = New System.Windows.Forms.DataGridView()
        Me.selectDrinkItem = New System.Windows.Forms.Button()
        Me.cancelDrink = New System.Windows.Forms.Button()
        Me.sizeButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.DrinkPrice = New System.Windows.Forms.TextBox()
        Me.DrinkSize = New System.Windows.Forms.TextBox()
        Me.DrinkName = New System.Windows.Forms.TextBox()
        CType(Me.dgvAddDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAddDrink
        '
        Me.dgvAddDrink.AllowUserToAddRows = False
        Me.dgvAddDrink.AllowUserToDeleteRows = False
        Me.dgvAddDrink.AllowUserToResizeColumns = False
        Me.dgvAddDrink.AllowUserToResizeRows = False
        Me.dgvAddDrink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvAddDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAddDrink.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvAddDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddDrink.Location = New System.Drawing.Point(12, 26)
        Me.dgvAddDrink.Name = "dgvAddDrink"
        Me.dgvAddDrink.ReadOnly = True
        Me.dgvAddDrink.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAddDrink.Size = New System.Drawing.Size(605, 370)
        Me.dgvAddDrink.TabIndex = 51
        Me.dgvAddDrink.Visible = False
        '
        'selectDrinkItem
        '
        Me.selectDrinkItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectDrinkItem.Location = New System.Drawing.Point(236, 486)
        Me.selectDrinkItem.Name = "selectDrinkItem"
        Me.selectDrinkItem.Size = New System.Drawing.Size(163, 111)
        Me.selectDrinkItem.TabIndex = 52
        Me.selectDrinkItem.Text = "Save"
        Me.selectDrinkItem.UseVisualStyleBackColor = True
        '
        'cancelDrink
        '
        Me.cancelDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelDrink.Location = New System.Drawing.Point(440, 486)
        Me.cancelDrink.Name = "cancelDrink"
        Me.cancelDrink.Size = New System.Drawing.Size(163, 111)
        Me.cancelDrink.TabIndex = 53
        Me.cancelDrink.Text = "Cancel"
        Me.cancelDrink.UseVisualStyleBackColor = True
        '
        'sizeButton
        '
        Me.sizeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeButton.Location = New System.Drawing.Point(31, 486)
        Me.sizeButton.Name = "sizeButton"
        Me.sizeButton.Size = New System.Drawing.Size(163, 111)
        Me.sizeButton.TabIndex = 54
        Me.sizeButton.Text = "Select Size"
        Me.sizeButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.label22)
        Me.GroupBox1.Controls.Add(Me.label20)
        Me.GroupBox1.Controls.Add(Me.label21)
        Me.GroupBox1.Controls.Add(Me.DrinkPrice)
        Me.GroupBox1.Controls.Add(Me.DrinkSize)
        Me.GroupBox1.Controls.Add(Me.DrinkName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 402)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 78)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drink"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox1.Location = New System.Drawing.Point(377, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 26)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "$"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(373, 16)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(44, 20)
        Me.label22.TabIndex = 8
        Me.label22.Text = "Price"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(238, 16)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(40, 20)
        Me.label20.TabIndex = 7
        Me.label20.Text = "Size"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(48, 16)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(51, 20)
        Me.label21.TabIndex = 6
        Me.label21.Text = "Name"
        '
        'DrinkPrice
        '
        Me.DrinkPrice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DrinkPrice.Enabled = False
        Me.DrinkPrice.HideSelection = False
        Me.DrinkPrice.Location = New System.Drawing.Point(392, 39)
        Me.DrinkPrice.Name = "DrinkPrice"
        Me.DrinkPrice.Size = New System.Drawing.Size(100, 26)
        Me.DrinkPrice.TabIndex = 5
        '
        'DrinkSize
        '
        Me.DrinkSize.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DrinkSize.Enabled = False
        Me.DrinkSize.HideSelection = False
        Me.DrinkSize.Location = New System.Drawing.Point(242, 39)
        Me.DrinkSize.Name = "DrinkSize"
        Me.DrinkSize.Size = New System.Drawing.Size(99, 26)
        Me.DrinkSize.TabIndex = 4
        '
        'DrinkName
        '
        Me.DrinkName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DrinkName.Enabled = False
        Me.DrinkName.HideSelection = False
        Me.DrinkName.Location = New System.Drawing.Point(52, 39)
        Me.DrinkName.Name = "DrinkName"
        Me.DrinkName.Size = New System.Drawing.Size(174, 26)
        Me.DrinkName.TabIndex = 2
        '
        'NewDrink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 609)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sizeButton)
        Me.Controls.Add(Me.cancelDrink)
        Me.Controls.Add(Me.selectDrinkItem)
        Me.Controls.Add(Me.dgvAddDrink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewDrink"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dgvAddDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAddDrink As System.Windows.Forms.DataGridView
    Friend WithEvents selectDrinkItem As System.Windows.Forms.Button
    Friend WithEvents cancelDrink As System.Windows.Forms.Button
    Friend WithEvents sizeButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label22 As System.Windows.Forms.Label
    Friend WithEvents label20 As System.Windows.Forms.Label
    Friend WithEvents label21 As System.Windows.Forms.Label
    Friend WithEvents DrinkPrice As System.Windows.Forms.TextBox
    Friend WithEvents DrinkSize As System.Windows.Forms.TextBox
    Friend WithEvents DrinkName As System.Windows.Forms.TextBox
End Class
