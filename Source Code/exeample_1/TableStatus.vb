Public Class TableStatus

    'FORMLOAD
    Private Sub TableStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tableInProgress_CheckedChanged(sender As Object, e As EventArgs) Handles tableInProgress.CheckStateChanged
        If tableInProgress.Checked = False Then
            If Form1.currentTable = 1 Then
                Form1.table1Progress = False
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Progress = False
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Progress = False
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Progress = False
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Progress = False
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Progress = False
            End If
        Else
            If Form1.currentTable = 1 Then
                Form1.table1Progress = True
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Progress = True
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Progress = True
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Progress = True
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Progress = True
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Progress = True
            End If
        End If

    End Sub

    Private Sub tableServed_CheckedChanged(sender As Object, e As EventArgs) Handles tableServed.CheckedChanged
        If tableServed.Checked = False Then
            If Form1.currentTable = 1 Then
                Form1.table1Served = False
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Served = False
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Served = False
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Served = False
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Served = False
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Served = False
            End If
        Else
            If Form1.currentTable = 1 Then
                Form1.table1Served = True
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Served = True
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Served = True
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Served = True
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Served = True
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Served = True
            End If
        End If
    End Sub

    Private Sub tableOccupied_CheckedChanged(sender As Object, e As EventArgs) Handles tableOccupied.CheckStateChanged
        If tableOccupied.Checked = False Then
            If Form1.currentTable = 1 Then
                Form1.table1Occupied = False
                Form1.btnTable1.BackColor = Color.PaleGreen
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Occupied = False
                Form1.btnTable2.BackColor = Color.PaleGreen
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Occupied = False
                Form1.btnTable3.BackColor = Color.PaleGreen
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Occupied = False
                Form1.btnTable4.BackColor = Color.PaleGreen
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Occupied = False
                Form1.btnTable5.BackColor = Color.PaleGreen
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Occupied = False
                Form1.btnTable6.BackColor = Color.PaleGreen
            End If
        Else
            If Form1.currentTable = 1 Then
                Form1.table1Occupied = True
                Form1.btnTable1.BackColor = Color.Salmon
            ElseIf Form1.currentTable = 2 Then
                Form1.table2Occupied = True
                Form1.btnTable2.BackColor = Color.Salmon
            ElseIf Form1.currentTable = 3 Then
                Form1.table3Occupied = True
                Form1.btnTable3.BackColor = Color.Salmon
            ElseIf Form1.currentTable = 4 Then
                Form1.table4Occupied = True
                Form1.btnTable4.BackColor = Color.Salmon
            ElseIf Form1.currentTable = 5 Then
                Form1.table5Occupied = True
                Form1.btnTable5.BackColor = Color.Salmon
            ElseIf Form1.currentTable = 6 Then
                Form1.table6Occupied = True
                Form1.btnTable6.BackColor = Color.Salmon
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub selectTable_Click(sender As Object, e As EventArgs) Handles selectTable.Click
        If Form1.currentTable = 1 Then
            Form1.locationType = "Table 1"
            Form1.locationBox.Text = "Table 1"
        ElseIf Form1.currentTable = 2 Then
            Form1.locationType = "Table 2"
            Form1.locationBox.Text = "Table 2"
        ElseIf Form1.currentTable = 3 Then
            Form1.locationType = "Table 3"
            Form1.locationBox.Text = "Table 3"
        ElseIf Form1.currentTable = 4 Then
            Form1.locationType = "Table 4"
            Form1.locationBox.Text = "Table 4"
        ElseIf Form1.currentTable = 5 Then
            Form1.locationType = "Table 5"
            Form1.locationBox.Text = "Table 5"
        ElseIf Form1.currentTable = 6 Then
            Form1.locationType = "Table 6"
            Form1.locationBox.Text = "Table 6"
        End If

        NewFood.getTable(Form1.currentTable)
        Form1.Tabs.SelectTab(3)
        Me.Close()
    End Sub
End Class