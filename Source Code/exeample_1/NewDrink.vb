Public Class NewDrink
    Private Access As New DBControl

    Dim DrinkNameVariable As String
    Public DrinkSizeVariable As String = ""
    Dim DrinkPriceVariable As Integer

    Private Sub NewDrink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add table
        showDrinkTable()
    End Sub

    Public Sub RefreshGridNewDrink(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvAddDrink.DataSource = Access.DBDT
    End Sub


    Private Sub showDrinkTable()
        'Lists the drinks sorted by drink name'
        RefreshGridNewDrink("SELECT * FROM Drinks WHERE Inventory > 0 ORDER BY DrinkName")

        'Hide drink ID'
        dgvAddDrink.Columns(0).Visible = False

        'Displays the data grid to the user'
        dgvAddDrink.Show()
    End Sub

    Private Sub cancelDrink_Click(sender As Object, e As EventArgs) Handles cancelDrink.Click
        'Close the form if the user clicks cancel'
        Me.Close()
    End Sub

    Private Sub selectDrinkItem_Click(sender As Object, e As EventArgs) Handles selectDrinkItem.Click
        If DrinkSizeVariable = "" Then
            MsgBox("Select a size to continue")
        Else
            'Decide correct price accodring to size
            If DrinkSizeVariable = "Small" Then
                DrinkPriceVariable = dgvAddDrink.CurrentRow.Cells(2).Value
            ElseIf DrinkSizeVariable = "Medium" Then
                DrinkPriceVariable = dgvAddDrink.CurrentRow.Cells(3).Value
            ElseIf DrinkSizeVariable = "Large" Then
                DrinkPriceVariable = dgvAddDrink.CurrentRow.Cells(4).Value
            End If

            'Update primary form
            Form1.drinkID = dgvAddDrink.CurrentRow.Cells(0).Value
            Form1.DrinkName.Text = dgvAddDrink.CurrentRow.Cells(1).Value.ToString
            Form1.drinkSizeVariable = DrinkSizeVariable
            Form1.DrinkSize.Text = DrinkSize.Text
            Form1.drinkPriceVariable = DrinkPriceVariable
            Form1.DrinkPrice.Text = Form1.drinkPriceVariable
            Form1.DrinkPrice.Text = FormatNumber(Form1.DrinkPrice.Text, 2, , , TriState.True)

            'Close form
            Me.Close()
        End If

    End Sub

    Private Sub sizeButton_Click(sender As Object, e As EventArgs) Handles sizeButton.Click

        DrinkName.Text = dgvAddDrink.CurrentRow.Cells(1).Value.ToString
        SelectSize.Show()

    End Sub


End Class