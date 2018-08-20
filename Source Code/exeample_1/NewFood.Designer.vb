<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFood
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
        Me.dgvAddFood = New System.Windows.Forms.DataGridView()
        Me.selectFoodItem = New System.Windows.Forms.Button()
        Me.cancelFoodItem = New System.Windows.Forms.Button()
        CType(Me.dgvAddFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAddFood
        '
        Me.dgvAddFood.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvAddFood.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvAddFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddFood.Location = New System.Drawing.Point(12, 12)
        Me.dgvAddFood.Name = "dgvAddFood"
        Me.dgvAddFood.ReadOnly = True
        Me.dgvAddFood.Size = New System.Drawing.Size(597, 422)
        Me.dgvAddFood.TabIndex = 0
        '
        'selectFoodItem
        '
        Me.selectFoodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectFoodItem.Location = New System.Drawing.Point(50, 440)
        Me.selectFoodItem.Name = "selectFoodItem"
        Me.selectFoodItem.Size = New System.Drawing.Size(213, 74)
        Me.selectFoodItem.TabIndex = 1
        Me.selectFoodItem.Text = "Select"
        Me.selectFoodItem.UseVisualStyleBackColor = True
        '
        'cancelFoodItem
        '
        Me.cancelFoodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelFoodItem.Location = New System.Drawing.Point(343, 440)
        Me.cancelFoodItem.Name = "cancelFoodItem"
        Me.cancelFoodItem.Size = New System.Drawing.Size(212, 74)
        Me.cancelFoodItem.TabIndex = 2
        Me.cancelFoodItem.Text = "Cancel"
        Me.cancelFoodItem.UseVisualStyleBackColor = True
        '
        'NewFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(621, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancelFoodItem)
        Me.Controls.Add(Me.selectFoodItem)
        Me.Controls.Add(Me.dgvAddFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dgvAddFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAddFood As System.Windows.Forms.DataGridView
    Friend WithEvents selectFoodItem As System.Windows.Forms.Button
    Friend WithEvents cancelFoodItem As System.Windows.Forms.Button
End Class
