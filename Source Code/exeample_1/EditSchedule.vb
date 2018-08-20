Public Class EditSchedule
    Private Access As New DBControl

    Public ScheduleID As Integer

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        EditSchedule()
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditSchedule()

        Dim tempMorning As String = "MANAGER: " + morningManager.Text + ", EMPLOYEE(S): " + morning1.Text
        Dim tempNoon As String = "MANAGER: " + noonManager.Text + ", EMPLOYEE(S): " + noon1.Text

        If Not morning2.Text = Nothing Then
            tempMorning += ("," + morning2.Text)
        End If

        If Not morning3.Text = Nothing Then
            tempMorning += ("," + morning3.Text)
        End If

        If Not noon2.Text = Nothing Then
            tempNoon += ("," + noon2.Text)
        End If

        If Not noon3.Text = Nothing Then
            tempNoon += ("," + noon3.Text)
        End If

        ' Add Parameters for the query '
        Access.addParam("@ScheduleDate", scheduleDate.Text)
        Access.addParam("@MorningShift", tempMorning)
        Access.addParam("@AfternoonShift", tempNoon)
        Access.addParam("@ID", ScheduleID)


        ' Execute Insert Command '
        Access.ExecQuery("UPDATE Schedule " & _
                          "SET ScheduleDate=@ScheduleDate, MorningShift=@MorningShift, AfternoonShift=@AfternoonShift WHERE ID=@ID")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Refresh the grid to show Schedule changes
        Form1.RefreshGrid("SELECT * FROM Schedule ORDER BY ID")

        'Close the form'
        Me.Close()

        ' Success '

        MsgBox("Schedule was Edited successfully")

    End Sub

End Class