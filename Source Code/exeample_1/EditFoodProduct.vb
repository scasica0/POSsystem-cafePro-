Public Class EditFoodProduct
    Private Access As New DBControl

    Public foodId As Integer

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
        Access.addParam("@ID", foodId)

        ' Execute UPDATE Command '
        Access.ExecQuery("UPDATE Food " & _
                          "SET FoodName=@FoodName, Category=@Category, Price=@Price, Inventory=@Inventory WHERE ID=@ID")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Success '
        MsgBox("Food Product was edited successfully")

        'Refresh the grid to show food product changes
        Form1.RefreshGrid("SELECT * FROM Food ORDER BY Category")

        'Refresh the OOS grid to show Food changes
        Form1.RefreshGridOOSFood("SELECT * FROM Food  WHERE Inventory=0 ORDER BY FoodName")

        'Close the edit form'
        Me.Close()


    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        ' Submit the changes and refresh the grid '
        editFood()
    End Sub

End Class