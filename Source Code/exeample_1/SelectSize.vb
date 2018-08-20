Public Class SelectSize
    Private Access As New DBControl

    Private Sub small_Click(sender As Object, e As EventArgs) Handles small.Click
        NewDrink.DrinkSizeVariable = "Small"
        NewDrink.DrinkSize.Text = "Small"
        NewDrink.DrinkPrice.Text = NewDrink.dgvAddDrink.CurrentRow.Cells(2).Value
        NewDrink.DrinkPrice.Text = FormatNumber(NewDrink.DrinkPrice.Text, 2, , , TriState.True)
        Me.Close()
    End Sub

    Private Sub medium_Click(sender As Object, e As EventArgs) Handles medium.Click
        NewDrink.DrinkSizeVariable = "Medium"
        NewDrink.DrinkSize.Text = "Medium"
        NewDrink.DrinkPrice.Text = NewDrink.dgvAddDrink.CurrentRow.Cells(3).Value
        NewDrink.DrinkPrice.Text = FormatNumber(NewDrink.DrinkPrice.Text, 2, , , TriState.True)
        Me.Close()
    End Sub

    Private Sub Large_Click(sender As Object, e As EventArgs) Handles Large.Click
        NewDrink.DrinkSizeVariable = "Large"
        NewDrink.DrinkSize.Text = "Large"
        NewDrink.DrinkPrice.Text = NewDrink.dgvAddDrink.CurrentRow.Cells(4).Value
        NewDrink.DrinkPrice.Text = FormatNumber(NewDrink.DrinkPrice.Text, 2, , , TriState.True)
        Me.Close()
    End Sub


End Class