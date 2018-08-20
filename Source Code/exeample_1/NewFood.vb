Public Class NewFood
    Private Access As New DBControl
    Dim currentTable As Integer

    Public Sub RefreshGridNewFood(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvAddFood.DataSource = Access.DBDT
    End Sub

    Private Sub NewFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add table
        showFoodTable()
    End Sub

    Private Sub showFoodTable()
        'Lists the drinks sorted by drink name'
        RefreshGridNewFood("SELECT * FROM Food WHERE Inventory > 0 ORDER BY Category")

        'Hide food id
        dgvAddFood.Columns(0).Visible = False

        'Displays the data grid to the user'
        dgvAddFood.Show()
    End Sub

    Private Sub cancelFoodItem_Click(sender As Object, e As EventArgs) Handles cancelFoodItem.Click
        'Close the form if the user clicks cancel'
        Me.Close()
    End Sub

    Private Sub selectFoodItem_Click(sender As Object, e As EventArgs) Handles selectFoodItem.Click
        Access.addParam("@food", dgvAddFood.CurrentRow.Cells(2).Value.ToString)
        Access.addParam("@price", dgvAddFood.CurrentRow.Cells(3).Value)
        Access.addParam("@table", currentTable.ToString)
        Access.addParam("@server", Form1.currentUserId)

        Access.ExecQuery("INSERT INTO OpenTickets (Product,Price,Table,Server)" &
                         "VALUES (1,2,3,4); ")

        Form1.foodID = dgvAddFood.CurrentRow.Cells(0).Value
        Form1.FoodName.Text = dgvAddFood.CurrentRow.Cells(2).Value.ToString
        Form1.FoodType.Text = dgvAddFood.CurrentRow.Cells(1).Value.ToString
        Form1.FoodPrice.Text = dgvAddFood.CurrentRow.Cells(3).Value.ToString
        Form1.FoodPrice.Text = FormatNumber(Form1.FoodPrice.Text, 2, , , TriState.True)

        Form1.foodPriceVariable = dgvAddFood.CurrentRow.Cells(3).Value
        Me.Close()
    End Sub

    Public Sub getTable(tableNum As Integer)
        currentTable = tableNum
    End Sub

End Class