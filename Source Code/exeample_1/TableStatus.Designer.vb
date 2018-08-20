<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableStatus
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableNumber = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tableServed = New System.Windows.Forms.CheckBox()
        Me.tableOccupied = New System.Windows.Forms.CheckBox()
        Me.tableInProgress = New System.Windows.Forms.CheckBox()
        Me.selectTable = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(192, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableNumber
        '
        Me.TableNumber.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableNumber.Enabled = False
        Me.TableNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableNumber.Location = New System.Drawing.Point(82, 12)
        Me.TableNumber.Name = "TableNumber"
        Me.TableNumber.ReadOnly = True
        Me.TableNumber.Size = New System.Drawing.Size(49, 24)
        Me.TableNumber.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(64, 24)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "Table:"
        '
        'tableServed
        '
        Me.tableServed.AutoSize = True
        Me.tableServed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableServed.Location = New System.Drawing.Point(7, 84)
        Me.tableServed.Name = "tableServed"
        Me.tableServed.Size = New System.Drawing.Size(89, 28)
        Me.tableServed.TabIndex = 4
        Me.tableServed.Text = "Served"
        Me.tableServed.UseVisualStyleBackColor = True
        '
        'tableOccupied
        '
        Me.tableOccupied.AutoSize = True
        Me.tableOccupied.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableOccupied.Location = New System.Drawing.Point(7, 34)
        Me.tableOccupied.Name = "tableOccupied"
        Me.tableOccupied.Size = New System.Drawing.Size(112, 28)
        Me.tableOccupied.TabIndex = 5
        Me.tableOccupied.Text = "Occupied"
        Me.tableOccupied.UseVisualStyleBackColor = True
        '
        'tableInProgress
        '
        Me.tableInProgress.AutoSize = True
        Me.tableInProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableInProgress.Location = New System.Drawing.Point(7, 34)
        Me.tableInProgress.Name = "tableInProgress"
        Me.tableInProgress.Size = New System.Drawing.Size(124, 28)
        Me.tableInProgress.TabIndex = 6
        Me.tableInProgress.Text = "In Progress"
        Me.tableInProgress.UseVisualStyleBackColor = True
        '
        'selectTable
        '
        Me.selectTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectTable.Location = New System.Drawing.Point(19, 223)
        Me.selectTable.Name = "selectTable"
        Me.selectTable.Size = New System.Drawing.Size(95, 31)
        Me.selectTable.TabIndex = 17
        Me.selectTable.Text = "Select"
        Me.selectTable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tableOccupied)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 135)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tableInProgress)
        Me.GroupBox2.Controls.Add(Me.tableServed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(156, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 135)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order"
        '
        'TableStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(312, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableNumber)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.selectTable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TableStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tableServed As System.Windows.Forms.CheckBox
    Friend WithEvents tableOccupied As System.Windows.Forms.CheckBox
    Friend WithEvents tableInProgress As System.Windows.Forms.CheckBox
    Friend WithEvents selectTable As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
