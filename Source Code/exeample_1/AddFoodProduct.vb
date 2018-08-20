Public Class AddFoodProduct
    Private Access As New DBControl

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        'Exit the edit form'
        Me.Close()
    End Sub

    Private Sub editFood()
        ' Add Parameters for the query '
        Access.addParam("@FoodName", txtname.Text)
        Access.addParam("@Category", txtCategory.Text)
        Access.addParam("@Price", txtPrice.Text)
        Access.addParam("@Inventory", txtInventory.Text)

        ' Execute Insert Command '
        Access.ExecQuery("INSERT INTO Food (FoodName,Category,Price,Inventory)" &
                         "VALUES (@FoodName,@Category,@Price,@Inventory); ")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Success '
        MsgBox("Food Product was added successfully")

        'Close the edit form'
        Me.Close()

        'Refresh the grid to show Food changes
        Form1.RefreshGrid("SELECT * FROM Food ORDER BY Category")

        'Refresh the OOS grid to show Food changes
        Form1.RefreshGridOOSFood("SELECT * FROM Food  WHERE Inventory=0 ORDER BY FoodName")
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        ' Submit the changes and refresh the grid '
        editFood()
    End Sub

End Class