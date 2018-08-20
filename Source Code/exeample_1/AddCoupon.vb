Public Class AddCoupon

    Dim discountPercent As Double
    Dim discount As Double

    Private Sub tenOff_Click(sender As Object, e As EventArgs) Handles tenOff.Click
        discountPercent = 0.1
        updatePayment()
    End Sub

    Private Sub twentyfiveOff_Click(sender As Object, e As EventArgs) Handles twentyfiveOff.Click
        discountPercent = 0.25
        updatePayment()
    End Sub

    Private Sub fiftyOff_Click(sender As Object, e As EventArgs) Handles fiftyOff.Click
        discountPercent = 0.5
        updatePayment()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        discountPercent = 0.0
        updatePayment()
    End Sub

    Public Sub updatePayment()
        Dim subtotal As Integer = Form1.foodPriceVariable + Form1.drinkPriceVariable
        subtotal = Convert.ToDouble(subtotal)
        discount = subtotal * discountPercent
        discount = Math.Round(discount, 2)
        subtotal = subtotal - discount
        Dim tax As Double = subtotal * 0.08
        Dim total As Double = subtotal + tax

        subtotal = Math.Round(subtotal, 2)
        total = Math.Round(total, 2)


        Form1.DiscountAmount.Text = discount
        Form1.DiscountAmount.Text = FormatNumber(Form1.DiscountAmount.Text, 2, , , TriState.True)
        Form1.SubtotalAmount.Text = subtotal
        Form1.SubtotalAmount.Text = FormatNumber(Form1.SubtotalAmount.Text, 2, , , TriState.True)
        Form1.TaxAmount.Text = tax
        Form1.TaxAmount.Text = FormatNumber(Form1.TaxAmount.Text, 2, , , TriState.True)
        Form1.TotalAmount.Text = total
        Form1.TotalAmount.Text = FormatNumber(Form1.TotalAmount.Text, 2, , , TriState.True)
        Me.Close()
    End Sub


End Class