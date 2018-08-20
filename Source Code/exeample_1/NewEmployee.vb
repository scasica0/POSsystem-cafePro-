Public Class NewEmployee
    Private Access As New DBControl

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        'Close the form if the user clicks cancel'
        Me.Close()
    End Sub

    Private Sub txtBox_Validate(sender As Object, e As EventArgs) Handles txtFname.TextChanged, txtLname.TextChanged, txtEmpID.TextChanged
        'Make sure the user enters information'
        If Not String.IsNullOrWhiteSpace(txtFname.Text) AndAlso String.IsNullOrWhiteSpace(txtLname.Text) AndAlso String.IsNullOrWhiteSpace(txtEmpID.Text) Then bttnSubmit.Enabled = True
    End Sub

    Private Sub addUser()
        ' Add Parameters '
        Access.addParam("@fname", txtFname.Text)
        Access.addParam("@lname", txtLname.Text)
        Access.addParam("@empID", txtEmpID.Text)
        Access.addParam("@manager", chkboxManager.Checked)
        Access.addParam("@address", txtAddress.Text)
        Access.addParam("@email", txtEmail.Text)
        Access.addParam("@phone", txtPhone.Text)
        Access.addParam("@city", txtCity.Text)
        Access.addParam("@state", txtState.Text)
        Access.addParam("@pay", txtPayRate.Text)
        Access.addParam("@zip", txtZip.Text)

        ' Execute Insert Command '
        Access.ExecQuery("INSERT INTO Employee (FirstName,LastName,EmployeeID,Manager,Address,Email,PhoneNumber,City,State,PayRate,Zip)" &
                         "VALUES (@fname,@lname,@empID,@manager,@address,@email,@phone,@city,@state,@pay,@zip); ")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox("All fields must be completed") : Exit Sub

        ' Success '
        MsgBox("Employee was added successfully")

        'Refresh grid to reflect added employee'
        Form1.RefreshGrid("SELECT * FROM Employee ORDER BY LastName")

        'Close add employee form'
        Me.Close()
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        'Execute adding user'
        addUser()
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub
End Class