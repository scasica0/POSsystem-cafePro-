<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateEmployee
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
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSubmit = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkboxManager = New System.Windows.Forms.CheckBox()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(207, 157)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 47
        Me.lblPhone.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(207, 172)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(93, 20)
        Me.txtPhone.TabIndex = 11
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(293, 196)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(54, 35)
        Me.bttnCancel.TabIndex = 13
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSubmit
        '
        Me.bttnSubmit.Location = New System.Drawing.Point(207, 196)
        Me.bttnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSubmit.Name = "bttnSubmit"
        Me.bttnSubmit.Size = New System.Drawing.Size(73, 35)
        Me.bttnSubmit.TabIndex = 12
        Me.bttnSubmit.Text = "Submit"
        Me.bttnSubmit.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(207, 122)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 43
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(207, 136)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 10
        '
        'chkboxManager
        '
        Me.chkboxManager.AutoSize = True
        Me.chkboxManager.Location = New System.Drawing.Point(7, 137)
        Me.chkboxManager.Margin = New System.Windows.Forms.Padding(2)
        Me.chkboxManager.Name = "chkboxManager"
        Me.chkboxManager.Size = New System.Drawing.Size(68, 17)
        Me.chkboxManager.TabIndex = 4
        Me.chkboxManager.Text = "Manager"
        Me.chkboxManager.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(7, 176)
        Me.lblPay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(54, 13)
        Me.lblPay.TabIndex = 40
        Me.lblPay.Text = "Pay Rate:"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(7, 191)
        Me.txtPayRate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(72, 20)
        Me.txtPayRate.TabIndex = 5
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(256, 85)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(25, 13)
        Me.lblZip.TabIndex = 38
        Me.lblZip.Text = "Zip:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(256, 99)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(93, 20)
        Me.txtZip.TabIndex = 9
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(204, 85)
        Me.lblState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 36
        Me.lblState.Text = "State:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(207, 99)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(34, 20)
        Me.txtState.TabIndex = 8
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(204, 47)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 34
        Me.lblCity.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.Location = New System.Drawing.Point(207, 62)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(142, 20)
        Me.txtCity.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(204, 10)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 32
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(207, 24)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 6
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(7, 85)
        Me.lblEmpID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblEmpID.TabIndex = 30
        Me.lblEmpID.Text = "Employee ID:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(7, 99)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpID.TabIndex = 3
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(7, 47)
        Me.lblLname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(61, 13)
        Me.lblLname.TabIndex = 28
        Me.lblLname.Text = "Last Name:"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(7, 62)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(142, 20)
        Me.txtLname.TabIndex = 2
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(7, 10)
        Me.lblFname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(60, 13)
        Me.lblFname.TabIndex = 26
        Me.lblFname.Text = "First Name:"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(7, 24)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(142, 20)
        Me.txtFname.TabIndex = 1
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(361, 242)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnSubmit)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.chkboxManager)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtFname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UpdateEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSubmit As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkboxManager As CheckBox
    Friend WithEvents lblPay As Label
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents lblLname As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents txtFname As TextBox
End Class
