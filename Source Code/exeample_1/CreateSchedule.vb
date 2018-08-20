Public Class CreateSchedule
    Private Access As New DBControl

    Private Sub CreateSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        morning2.Text = Nothing
        morning3.Text = Nothing
        noon2.Text = Nothing
        noon3.Text = Nothing
    End Sub

    Private Sub bttnSubmit_Click(sender As Object, e As EventArgs) Handles bttnSubmit.Click
        addSchedule()
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub addSchedule()

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


        ' Execute Insert Command '
        Access.ExecQuery("INSERT INTO Schedule (ScheduleDate,MorningShift,AfternoonShift)" &
                         "VALUES (@ScheduleDate,@MorningShift,@AfternoonShift); ")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Refresh the grid to show Schedule changes
        Form1.RefreshGrid("SELECT * FROM Schedule ORDER BY ID")

        'Close the form'
        Me.Close()

        ' Success '

        MsgBox("New Schedule was added successfully")

    End Sub

End Class