Public Class AddDrinkProduct
    Private Access As New DBControl

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        'Exit the edit form'
        Me.Close()
    End Sub

    Private Sub editDrink()
        ' Add Parameters for the query '
        Access.addParam("@DrinkName", txtname.Text)
        Access.addParam("@Type", txtType.Text)
        Access.addParam("@SmallPrice", txtSmallPrice.Text)
        Access.addParam("@MediumPrice", txtMediumPrice.Text)
        Access.addParam("@LargePrice", txtLargePrice.Text)
        Access.addParam("@Inventory", txtInventory.Text)

        ' Execute Insert Command '
        Access.ExecQuery("INSERT INTO Drinks (DrinkName,Type,SmallPrice,MediumPrice,LargePrice,Inventory)" &
                         "VALUES (@DrinkName,@Type,@SmallPrice,@MediumPrice,@LargePrice,@Inventory); ")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Success '
        MsgBox("Drink Product was added successfully")

        'Close the edit form'
        Me.Close()

        'Refresh the grid to show Drink changes
        Form1.RefreshGrid("SELECT * FROM Drinks ORDER BY Type")

        'Refresh the OOS grid to show Drink changes
        Form1.RefreshGridOOSDrinks("SELECT * FROM Drinks  WHERE Inventory=0 ORDER BY DrinkName")
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        ' Submit the changes and refresh the grid '
        editDrink()
    End Sub

End Class