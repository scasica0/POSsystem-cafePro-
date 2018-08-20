Public Class UpdateEmployee
    Private Access As New DBControl

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        'Exit the edit form'
        Me.Close()
    End Sub

    Private Sub editUser()
        ' Add Parameters for the query '
        Access.addParam("@fname", txtFname.Text)
        Access.addParam("@lname", txtLname.Text)
        Access.addParam("@manager", chkboxManager.Checked)
        Access.addParam("@address", txtAddress.Text)
        Access.addParam("@email", txtEmail.Text)
        Access.addParam("@phone", txtPhone.Text)
        Access.addParam("@city", txtCity.Text)
        Access.addParam("@state", txtState.Text)
        Access.addParam("@pay", txtPayRate.Text)
        Access.addParam("@zip", txtZip.Text)
        Access.addParam("@empID", txtEmpID.Text)

        ' Execute UPDATE Command '
        Access.ExecQuery("UPDATE Employee " & _
                         "SET FirstName=@fname, LastName=@lname, Manager=@manager, Address=@address, Email=@email, PhoneNumber=@phone, City=@city, State=@state, PayRate=@pay, Zip=@zip " & _
                         "WHERE EmployeeID=@empID")


        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Success '
        MsgBox("Employee was edited successfully")

        'Close the edit form'
        Me.Close()

        'Refresh the grid to show employee changes
        Form1.RefreshGrid("SELECT * FROM Employee ORDER BY LastName")
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        ' Submit the changes and refresh the grid '
        editUser()
    End Sub

End Class