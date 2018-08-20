Imports System.Globalization

Public Class Form1

    'Dim NameOfVariable As DataType
    'DECLARATIONS
    Dim login As String = ""
    Dim currentDate As Date
    Dim manager As Boolean = False
    Dim currentUserName As String
    Public currentUserId As String
    Public clockedIn As Boolean = False


    Private Access As New DBControl

    'FORMLOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currDate As String = ""
        Dim dtfInfo As DateTimeFormatInfo
        Dim dtStyle As String = "ddd, dd MMMM yyyy"
        dtfInfo = DateTimeFormatInfo.InvariantInfo
        currDate = DateTime.Now.ToString(dtStyle, dtfInfo)
        lblCurrentDate0.Text = currDate
        lblCurrentDate1.Text = currDate

        'load out of stock items data
        showOOSTable()
        showOOSDrinksTable()

        'jump to login tab
        Tabs.SelectTab(0)

        'hides tab headers
        Tabs.Appearance = TabAppearance.FlatButtons
        Tabs.ItemSize = New Size(0, 1)
        Tabs.SizeMode = TabSizeMode.Fixed

        'hide nav buttons
        btnPersonalPage.Hide()
        btnTables.Hide()
        btnManager.Hide()
        btnExit0.Hide()
        bttnExit4.Hide()
    End Sub

    Private Function myZero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currTime As String = ""
        currTime &= myZero(DateTime.Now.Hour)
        If currTime > 12 Then
            currTime = currTime - 12
        End If
        currTime &= ":" & myZero(DateTime.Now.Minute)
        currTime &= ":" & myZero(DateTime.Now.Second)
        lbltime0.Text = currTime
        lbltime1.Text = currTime
        lbltime2.Text = currTime
        lbltime3.Text = currTime
        lblTimeLogin.Text = currTime
    End Sub

    '**************LOGIN TAB******************************************
    Function asteriskPrint(login)
        If (Len(login) = 0) Then
            lblLogin.Text = ""
        ElseIf (Len(login) = 1) Then
            lblLogin.Text = "*"
        ElseIf (Len(login) = 2) Then
            lblLogin.Text = "**"
        ElseIf (Len(login) = 3) Then
            lblLogin.Text = "***"
        ElseIf (Len(login) = 4) Then
            lblLogin.Text = "****"
            loginAttempt()

        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login += "1"
        asteriskPrint(login)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login += "2"
        asteriskPrint(login)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login += "3"
        asteriskPrint(login)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        login += "4"
        asteriskPrint(login)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login += "5"
        asteriskPrint(login)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login += "6"
        asteriskPrint(login)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        login += "7"
        asteriskPrint(login)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        login += "8"
        asteriskPrint(login)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        login += "9"
        asteriskPrint(login)
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        login += "0"
        asteriskPrint(login)
    End Sub

    'Clear CLICK
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        login = ""
        lblLogin.Text = login
        asteriskPrint(login)
    End Sub

    'OK CLICK
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        loginAttempt()
    End Sub

    Private Sub loginAttempt()
        Dim tempManager As String = ""
        Dim tempClockedIn As String = ""

        'Access database and match login to employee id
        Access.addParam("@id", login)
        currentUserId = Access.RetrieveQuery("SELECT EmployeeID FROM Employee WHERE EmployeeID = @id", "EmployeeID")

        Access.addParam("@id", login)
        tempManager = Access.RetrieveQuery("SELECT Manager FROM Employee WHERE EmployeeID = @id", "Manager")

        Access.addParam("@id", login)
        currentUserName = Access.RetrieveQuery("SELECT FirstName FROM Employee WHERE EmployeeID = @id", "FirstName")
        currentUserName += " "
        Access.addParam("@id", login)
        currentUserName += Access.RetrieveQuery("SELECT LastName FROM Employee WHERE EmployeeID = @id", "LastName")




        'if match
        If currentUserId = "" Then
            btnClear.PerformClick()
            MsgBox("Login Error, Please Try Again")

        Else
            showPersonalTable()
            Access.addParam("@id", login)
            tempClockedIn = Access.RetrieveQuery("SELECT ClockedIn FROM Employee WHERE EmployeeID = @id", "ClockedIn")

            If tempClockedIn = "True" Then
                clockedIn = True
            Else
                clockedIn = False
            End If

            EmployeeNameDisplay.Text = currentUserName

            'Check if Employee is a manager
            If tempManager = "True" Then
                manager = True
            End If

            If clockedIn = True Then

                btnClockIn.Hide()
                btnClockOut.Show()
                btnBreak.Show()

                If manager = True Then
                    btnPersonalPage.Show()
                    btnManager.Show()
                    btnTables.Show()
                    btnExit0.Show()
                    bttnExit4.Show()
                    lblEmpName.Show()
                    lblEmpName.Text = currentUserName
                    Tabs.SelectTab(5)
                Else
                    btnPersonalPage.Show()
                    btnTables.Show()
                    btnExit0.Show()
                    lblEmpName.Show()
                    lblEmpName.Text = currentUserName
                    Tabs.SelectTab(2)
                End If
            Else
                btnClockIn.Show()
                btnClockOut.Hide()
                btnBreak.Hide()
                Tabs.SelectTab(1)

            End If
        End If
    End Sub

    'EXIT BUTTON
    Private Sub btnExit0_Click(sender As Object, e As EventArgs) Handles btnExit0.Click
        Tabs.SelectTab(0)
        login = ""
        asteriskPrint(login)

        'hide nav buttons
        btnPersonalPage.Hide()
        btnManager.Hide()
        manager = False
        btnTables.Hide()
        btnExit0.Hide()
        bttnExit4.Hide()
        lblEmpName.Hide()
        btnClear.PerformClick()

        dgvData.Hide()
    End Sub

    '**************CLOCK IN TAB******************************************

    Public Sub RefreshGridPersonal(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvPersonal.DataSource = Access.DBDT
    End Sub

    Private Sub showPersonalTable()

        Access.addParam("@EmployeeID", currentUserId)

        RefreshGridPersonal("SELECT * FROM Hours WHERE EmployeeID=@EmployeeID ORDER BY CurrentDate")

        dgvPersonal.Columns(2).HeaderText = "Date"
        dgvPersonal.Columns(3).HeaderText = "Time In"
        dgvPersonal.Columns(4).HeaderText = "Time Out"
        dgvPersonal.Columns(5).HeaderText = "Total Hours"

        'Hide id, employeeid and clockedin
        dgvPersonal.Columns(0).Visible = False
        dgvPersonal.Columns(1).Visible = False
        dgvPersonal.Columns(6).Visible = False

        'Displays the data grid to the user'
        dgvPersonal.Show()
    End Sub


    Private Sub btnClockIn_Click(sender As Object, e As EventArgs) Handles btnClockIn.Click
        Dim tempBreak As String
        Dim break As Boolean

        Dim clockOutTimeString As String
        Dim clockOutTimeStringArray() As String
        Dim clockOutTimeHours As Double
        Dim clockOutTimeMinutes As Double
        Dim clockOutTimeTotal As Double

        Dim currTimeArray() As String
        Dim currTimeHours As Double
        Dim currTimeMinutes As Double
        Dim currTimeTotal As Double

        Dim returnTimeHours As String
        Dim returnTimeMinutes As String

        Dim currDate As String = ""
        Dim dtfInfo1 As DateTimeFormatInfo
        Dim dtStyle1 As String = "MM/d/yy"
        dtfInfo1 = DateTimeFormatInfo.InvariantInfo
        currDate = DateTime.Now.ToString(dtStyle1, dtfInfo1)

        Dim currTime As String = ""
        Dim dtfInfo2 As DateTimeFormatInfo
        Dim dtStyle2 As String = "HH:mm"
        dtfInfo2 = DateTimeFormatInfo.InvariantInfo
        currTime = DateTime.Now.ToString(dtStyle2, dtfInfo2)

        'check if on break
        Access.addParam("@EmployeeID", currentUserId)
        tempBreak = Access.RetrieveQuery("SELECT Break FROM Employee WHERE  (EmployeeID=@EmployeeID)", "Break")
        If tempBreak = "True" Then
        break = True
            Else
        break = False
        End If

        If break = True Then
            Access.addParam("@EmployeeID", currentUserId)
            clockOutTimeString = Access.RetrieveQuery("SELECT OutTime FROM Hours WHERE  (EmployeeID=@EmployeeID) AND (Break= True)", "OutTime")


            currTimeArray = Split(currTime, ":")
            currTimeHours = 60 * (Convert.ToDouble(currTimeArray(0))) ' in minutes
            currTimeMinutes = Convert.ToDouble(currTimeArray(1))
            currTimeTotal = currTimeHours + currTimeMinutes

            clockOutTimeStringArray = Split(clockOutTimeString, ":")
            clockOutTimeHours = 60 * (Convert.ToDouble(clockOutTimeStringArray(0))) ' in minutes
            clockOutTimeMinutes = Convert.ToDouble(clockOutTimeStringArray(1))
            clockOutTimeTotal = clockOutTimeHours + clockOutTimeMinutes

            'Check if employee took minimum 15 minute break
            If (currTimeTotal - clockOutTimeTotal) < 15 Then
                'employee can not clock in yet

                returnTimeHours = (Convert.ToInt32(clockOutTimeTotal) + 15) \ 60
                If returnTimeHours > 11 Then
                    returnTimeHours -= 12
                End If
                Convert.ToString(returnTimeHours)
                returnTimeMinutes = Convert.ToString((Convert.ToInt32(clockOutTimeTotal) + 15) Mod 60)
                MsgBox("Clock-in Error: Minimum break duration is 15 minutes. You must remain on a break until " + returnTimeHours + ":" + returnTimeMinutes + ".")
            Else
                'clock in employee
                btnClockOut.Show()
                btnBreak.Show()
                currentDate = Now
                'Remove break from records
                Access.addParam("@EmployeeID", currentUserId)
                Access.ExecQuery("UPDATE Hours " & _
                                "SET Break = False " & _
                                "WHERE (EmployeeID=@EmployeeID)")

                Access.addParam("@EmployeeID", currentUserId)
                Access.ExecQuery("UPDATE Employee " & _
                                "SET ClockedIn=False,Break=False  " & _
                                 "WHERE EmployeeID=@EmployeeID")

                ' Add Parameters for the query '
                Access.addParam("@EmployeeID", currentUserId)
                Access.addParam("@CurrentDate", currDate)
                Access.addParam("@InTime", currTime)
                Access.addParam("@OutTime", "None")
                Access.addParam("@HoursWorked", 0)
                Access.addParam("@ClockedIn", True)

                ' Execute Insert Command '
                Access.ExecQuery("INSERT INTO Hours (EmployeeID,CurrentDate,InTime,OutTime,HoursWorked,ClockedIn)" &
                                 "VALUES (@EmployeeID,@CurrentDate,@InTime,@OutTime,@HoursWorked,@ClockedIn); ")

                ' Report and abort on errors'
                If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


                Access.addParam("@EmployeeID", currentUserId)

                Access.ExecQuery("UPDATE Employee " & _
                         "SET ClockedIn= True " & _
                        "WHERE (EmployeeID=@EmployeeID)")


                ' Report and abort on errors'
                If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


                clockedIn = True
                MsgBox("Clock-In Successful")

                btnClockIn.Hide()
                btnPersonalPage.Show()
                btnTables.Show()
                btnExit0.Show()
                bttnExit4.Show()
                lblEmpName.Show()
                lblEmpName.Text = currentUserName
                showPersonalTable()

                If manager = True Then
                    btnManager.Show()
                    'Jump to Manager Screen
                    Tabs.SelectTab(5)
                Else
                    'Jump to Table Screen
                    btnManager.Hide()
                    Tabs.SelectTab(2)
                End If
            End If


        Else
            'Employee is not on Break
            'clock in employee

            btnClockOut.Show()
            btnBreak.Show()
            currentDate = Now

            ' Add Parameters for the query '
            Access.addParam("@EmployeeID", currentUserId)
            Access.addParam("@CurrentDate", currDate)
            Access.addParam("@InTime", currTime)
            Access.addParam("@OutTime", "None")
            Access.addParam("@HoursWorked", 0)
            Access.addParam("@ClockedIn", True)

            ' Execute Insert Command '
            Access.ExecQuery("INSERT INTO Hours (EmployeeID,CurrentDate,InTime,OutTime,HoursWorked,ClockedIn)" &
                             "VALUES (@EmployeeID,@CurrentDate,@InTime,@OutTime,@HoursWorked,@ClockedIn); ")

            ' Report and abort on errors'
            If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


            Access.addParam("@EmployeeID", currentUserId)

            Access.ExecQuery("UPDATE Employee " & _
                     "SET ClockedIn= True " & _
                    "WHERE (EmployeeID=@EmployeeID)")


            ' Report and abort on errors'
            If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


            clockedIn = True
            MsgBox("Clock-In Successful")

            btnClockIn.Hide()
            btnPersonalPage.Show()
            btnTables.Show()
            bttnExit4.Show()
            btnExit0.Show()
            lblEmpName.Show()
            lblEmpName.Text = currentUserName
            showPersonalTable()

            If manager = True Then
                btnManager.Show()
                'Jump to Manager Screen
                Tabs.SelectTab(5)
            Else
                'Jump to Table Screen
                btnManager.Hide()
                Tabs.SelectTab(2)
            End If
        End If

    End Sub


    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click
        'clock out employee

        Dim HoursWorked As Double

        Dim clockInTimeString As String
        Dim clockInTimeStringArray() As String
        Dim clockInTimeHours As Double
        Dim clockInTimeMinutes As Double


        Dim currTime As String = ""
        Dim dtfInfo3 As DateTimeFormatInfo
        Dim dtStyle3 As String = "HH:mm"
        dtfInfo3 = DateTimeFormatInfo.InvariantInfo
        currTime = DateTime.Now.ToString(dtStyle3, dtfInfo3)

        Dim currTimeArray() As String
        Dim currTimeHours As Double
        Dim currTimeMinutes As Double

        Access.addParam("@EmployeeID", currentUserId)

        clockInTimeString = Access.RetrieveQuery("SELECT InTime FROM Hours WHERE  (EmployeeID=@EmployeeID) AND (ClockedIn= True)", "InTime")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        'Calculate Hours Worked

        currTimeArray = Split(currTime, ":")
        currTimeHours = 60 * (Convert.ToDouble(currTimeArray(0))) ' in minutes
        currTimeMinutes = Convert.ToDouble(currTimeArray(1))

        clockInTimeStringArray = Split(clockInTimeString, ":")
        clockInTimeHours = 60 * (Convert.ToDouble(clockInTimeStringArray(0))) ' in minutes
        clockInTimeMinutes = Convert.ToDouble(clockInTimeStringArray(1))

        HoursWorked = (currTimeHours + currTimeMinutes) - (clockInTimeHours + clockInTimeMinutes)
        HoursWorked = HoursWorked / 60 ' In hours
        HoursWorked = Math.Round(HoursWorked, 3)

        Access.addParam("@OutTime", currTime)
        Access.addParam("@HoursWorked", HoursWorked)
        Access.addParam("@EmployeeID", currentUserId)

        ' Execute UPDATE Command '
        Access.ExecQuery("UPDATE Hours " & _
                         "SET OutTime=@OutTime,HoursWorked=@HoursWorked " & _
                         "WHERE (EmployeeID = @EmployeeID) AND (ClockedIn = True)")

        Access.addParam("@EmployeeID", login)

        Access.ExecQuery("UPDATE Hours " & _
                         "SET ClockedIn=False " & _
                         "WHERE (EmployeeID = @EmployeeID)")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub



        'Update employee clock in status
        Access.addParam("@EmployeeID", currentUserId)

        Access.ExecQuery("UPDATE Employee " & _
                        "SET ClockedIn = False " & _
                        "WHERE EmployeeID=@EmployeeID")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        clockedIn = False
        MsgBox("Clock-Out Successful")
        login = ""
        btnClockIn.Show()
        showPersonalTable()
        btnExit0.PerformClick()
        Tabs.SelectTab(0)
    End Sub

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        'put employee on break

        Dim HoursWorked As Double

        Dim clockInTimeString As String
        Dim clockInTimeStringArray() As String
        Dim clockInTimeHours As Double
        Dim clockInTimeMinutes As Double


        Dim currTime As String = ""
        Dim dtfInfo3 As DateTimeFormatInfo
        Dim dtStyle3 As String = "HH:mm"
        dtfInfo3 = DateTimeFormatInfo.InvariantInfo
        currTime = DateTime.Now.ToString(dtStyle3, dtfInfo3)

        Dim currTimeArray() As String
        Dim currTimeHours As Double
        Dim currTimeMinutes As Double

        Access.addParam("@EmployeeID", currentUserId)

        clockInTimeString = Access.RetrieveQuery("SELECT InTime FROM Hours WHERE  (EmployeeID=@EmployeeID) AND (ClockedIn=True)", "InTime")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        'Calculate Hours Worked

        currTimeArray = Split(currTime, ":")
        currTimeHours = 60 * (Convert.ToDouble(currTimeArray(0))) ' in minutes
        currTimeMinutes = Convert.ToDouble(currTimeArray(1))

        clockInTimeStringArray = Split(clockInTimeString, ":")
        clockInTimeHours = 60 * (Convert.ToDouble(clockInTimeStringArray(0))) ' in minutes
        clockInTimeMinutes = Convert.ToDouble(clockInTimeStringArray(1))

        HoursWorked = (currTimeHours + currTimeMinutes) - (clockInTimeHours + clockInTimeMinutes)
        HoursWorked = HoursWorked / 60 ' In hours
        HoursWorked = Math.Round(HoursWorked, 3)

        ' Execute UPDATE Command '
        Access.addParam("@OutTime", currTime)
        Access.addParam("@HoursWorked", HoursWorked)
        Access.addParam("@EmployeeID", currentUserId)


        Access.ExecQuery("UPDATE Hours " & _
                         "SET OutTime=@OutTime,HoursWorked=@HoursWorked,Break=True " & _
                         "WHERE (EmployeeID=@EmployeeID) AND (ClockedIn=True)")

        Access.addParam("@EmployeeID", currentUserId)
        Access.ExecQuery("UPDATE Hours " & _
                         "SET ClockedIn=False " & _
                         "WHERE (EmployeeID = @EmployeeID)")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Update employee clock in status
        Access.addParam("@EmployeeID", login)

        Access.ExecQuery("UPDATE Employee " & _
                        "SET ClockedIn=False,Break=True  " & _
                        "WHERE EmployeeID=@EmployeeID")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        clockedIn = False
        MsgBox("Break Successful")
        btnClockIn.Show()
        showPersonalTable()
        btnExit0.PerformClick()
        Tabs.SelectTab(0)
    End Sub


    'Exit Buttons
    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit1.Click
        login = ""
        asteriskPrint(login)
        btnExit0.PerformClick()
        Tabs.SelectTab(0)
    End Sub

    Private Sub bttnExit4_Click(sender As Object, e As EventArgs) Handles bttnExit4.Click
        login = ""
        asteriskPrint(login)
        btnExit0.PerformClick()
        Tabs.SelectTab(0)
    End Sub



    '**************TABLES TAB******************************************

    Public locationType As String = Nothing

    Public currentTable As Integer

    Public table1Occupied As Boolean = False
    Public table2Occupied As Boolean = False
    Public table3Occupied As Boolean = False
    Public table4Occupied As Boolean = False
    Public table5Occupied As Boolean = False
    Public table6Occupied As Boolean = False

    Public table1Served As Boolean = False
    Public table2Served As Boolean = False
    Public table3Served As Boolean = False
    Public table4Served As Boolean = False
    Public table5Served As Boolean = False
    Public table6Served As Boolean = False

    Public table1Progress As Boolean = False
    Public table2Progress As Boolean = False
    Public table3Progress As Boolean = False
    Public table4Progress As Boolean = False
    Public table5Progress As Boolean = False
    Public table6Progress As Boolean = False


    Private Sub btnTable1_DoubleClick(sender As Object, e As EventArgs) Handles btnTable1.Click
        currentTable = 1
        TableStatus.tableInProgress.Checked = table1Progress
        TableStatus.tableOccupied.Checked = table1Occupied
        TableStatus.tableServed.Checked = table1Served
        TableStatus.tableNumber.Text = currentTable
        TableStatus.Show()
    End Sub

    Private Sub btnTable2_DoubleClick(sender As Object, e As EventArgs) Handles btnTable2.Click
        currentTable = 2
        TableStatus.tableNumber.Text = currentTable
        TableStatus.tableInProgress.Checked = table2Progress
        TableStatus.tableOccupied.Checked = table2Occupied
        TableStatus.tableServed.Checked = table2Served
        TableStatus.Show()
    End Sub

    Private Sub btnTable3_DoubleClick(sender As Object, e As EventArgs) Handles btnTable3.Click
        currentTable = 3
        TableStatus.TableNumber.Text = currentTable
        TableStatus.tableInProgress.Checked = table3Progress
        TableStatus.tableOccupied.Checked = table3Occupied
        TableStatus.tableServed.Checked = table3Served
        TableStatus.Show()
    End Sub

    Private Sub btnTable4_DoubleClick(sender As Object, e As EventArgs) Handles btnTable4.Click
        currentTable = 4
        TableStatus.TableNumber.Text = currentTable
        TableStatus.tableInProgress.Checked = table4Progress
        TableStatus.tableOccupied.Checked = table4Occupied
        TableStatus.tableServed.Checked = table4Served
        TableStatus.Show()
    End Sub

    Private Sub btnTable5_DoubleClick(sender As Object, e As EventArgs) Handles btnTable5.Click
        currentTable = 1
        TableStatus.TableNumber.Text = currentTable
        TableStatus.tableInProgress.Checked = table5Progress
        TableStatus.tableOccupied.Checked = table5Occupied
        TableStatus.tableServed.Checked = table5Served
        TableStatus.Show()
    End Sub

    Private Sub btnTable6_DoubleClick(sender As Object, e As EventArgs) Handles btnTable6.Click
        currentTable = 6
        TableStatus.TableNumber.Text = currentTable
        TableStatus.tableInProgress.Checked = table6Progress
        TableStatus.tableOccupied.Checked = table6Occupied
        TableStatus.tableServed.Checked = table6Served
        TableStatus.Show()
    End Sub

    Private Sub TakeoutOrderButton_Click(sender As Object, e As EventArgs) Handles TakeoutOrderButton.Click
        'Takeout Order
        locationType = "Takeout Order"
        locationBox.Text = "Takeout Order"
        Tabs.SelectTab(3)
    End Sub

    '**************Ordering Tab******************************************

    Public foodID As Integer = Nothing
    Public drinkID As Integer = Nothing
    Public foodPriceVariable As Integer = Nothing
    Public drinkPriceVariable As Integer = Nothing
    Public drinkSizeVariable As String = ""

    Public Sub RefreshGridOOSFood(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvOOS.DataSource = Access.DBDT
    End Sub

    Public Sub RefreshGridOOSDrinks(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvOOSDrinks.DataSource = Access.DBDT
    End Sub

    Private Sub showOOSDrinksTable()
        'Lists the OOS Drinks'
        RefreshGridOOSDrinks("SELECT * FROM Drinks  WHERE Inventory=0 ORDER BY DrinkName")

        'Sets the headers to a readable format '
        dgvOOSDrinks.Columns(1).HeaderText = "Name"
        dgvOOS.Columns(2).HeaderText = "Category"

        'Displays only the name and category'
        dgvOOSDrinks.Columns(0).Visible = False

        For i As Integer = 0 To dgvOOS.ColumnCount
            dgvOOSDrinks.Columns(i).Visible = False
        Next

        dgvOOSDrinks.Columns(1).Visible = True
        dgvOOSDrinks.Columns(6).Visible = True

        'Displays the data grid to the user'
        dgvOOSDrinks.Show()
    End Sub

    Private Sub showOOSTable()
        'Lists the OOS Food'
        RefreshGridOOSFood("SELECT * FROM Food  WHERE Inventory=0 ORDER BY FoodName")

        'Sets the headers to a readable format '
        dgvOOS.Columns(1).HeaderText = "Name"
        dgvOOS.Columns(2).HeaderText = "Category"

        'Displays only the name and category'
        dgvOOS.Columns(0).Visible = False

        For i As Integer = 3 To dgvOOS.ColumnCount - 1
            dgvOOS.Columns(i).Visible = False
        Next

        'Displays the data grid to the user'
        dgvOOS.Show()
    End Sub

    'click location box
    Private Sub locationBox_MouseClick(sender As Object, e As MouseEventArgs) Handles locationBox.MouseClick, locationBox.Click
        'jump to table tab
        Tabs.SelectTab(2)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles DrinkName.TextChanged
        'DO NOT DELETE'
    End Sub

    Private Sub FoodName_TextChanged(sender As Object, e As EventArgs) Handles FoodName.TextChanged
        'DO NOT DELETE'
    End Sub

    Private Sub AddDrink_Click(sender As Object, e As EventArgs) Handles AddDrink.Click
        'create popup window to select drink
        NewDrink.Show()
    End Sub

    Private Sub AddFood_Click(sender As Object, e As EventArgs) Handles AddFood.Click
        'create popup window to select food
        NewFood.Show()
    End Sub

    Private Sub ProceedtoPayment_Click(sender As Object, e As EventArgs) Handles ProceedtoPayment.Click
        'no location 
        If locationBox.Text = "" Then
            MsgBox("Please select a TABLE to continue")
            Tabs.SelectTab(2)
        Else
            'transfer receipt info to payment page
            'drink
            DrinkNameFinal.Text = DrinkName.Text
            DrinkSizeFinal.Text = DrinkSize.Text
            DrinkPriceFinal.Text = DrinkPrice.Text
            'food
            FoodNameFinal.Text = FoodName.Text
            FoodTypeFinal.Text = FoodType.Text
            FoodPriceFinal.Text = FoodPrice.Text

            'calculate tax, subtotal and total
            Dim subtotal As Integer = foodPriceVariable + drinkPriceVariable
            subtotal = Convert.ToDouble(subtotal)
            Dim tax As Double = subtotal * 0.08
            Dim total As Double = subtotal + tax

            total = Math.Round(total, 2)

            DiscountAmount.Text = 0.0
            DiscountAmount.Text = FormatNumber(DiscountAmount.Text, 2, , , TriState.True)
            SubtotalAmount.Text = subtotal
            SubtotalAmount.Text = FormatNumber(SubtotalAmount.Text, 2, , , TriState.True)
            TaxAmount.Text = tax
            TaxAmount.Text = FormatNumber(TaxAmount.Text, 2, , , TriState.True)
            TotalAmount.Text = total
            TotalAmount.Text = FormatNumber(TotalAmount.Text, 2, , , TriState.True)

            LocationBox2.Text = locationType

            'jump to payment tab
            Tabs.SelectTab(4)
        End If


    End Sub

    '**************Payment Tab******************************************

    Private Sub CouponButton_Click(sender As Object, e As EventArgs) Handles CouponButton.Click
        'Display add coupon prompt
        AddCoupon.Show()
    End Sub


    Private Sub CashPayment_Click(sender As Object, e As EventArgs) Handles CashPayment.Click
        '"dummy" button - has no function because there is no hardware
        tenderType.Text = "Cash"
    End Sub
    Private Sub CardPayment_Click(sender As Object, e As EventArgs) Handles CardPayment.Click
        '"dummy" button - has no function because there is no hardware
        tenderType.Text = "Credit/Debit"
    End Sub


    Private Sub FinalizeOrder_Click(sender As Object, e As EventArgs) Handles FinalizeOrder.Click
        'make sure a tender was selected
        If tenderType.Text = "" Then
            MsgBox("Please select a PAYMENT METHOD  to continue")

        Else
            'update receipt in db
            createReceipt()
            updateInventory()

            'print confirmation
            MsgBox("Order was processed successfully")

            'reset values
            drinkID = Nothing
            drinkPriceVariable = Nothing
            drinkSizeVariable = ""
            DrinkNameFinal.Text = ""
            DrinkName.Text = ""
            DrinkSizeFinal.Text = ""
            DrinkSize.Text = ""
            DrinkPriceFinal.Text = ""
            DrinkPrice.Text = ""

            foodID = Nothing
            foodPriceVariable = Nothing
            FoodNameFinal.Text = ""
            FoodName.Text = ""
            FoodTypeFinal.Text = ""
            FoodType.Text = ""
            FoodPriceFinal.Text = ""
            FoodPrice.Text = ""

            locationBox.Text = ""
            LocationBox2.Text = ""
            tenderType.Text = ""
            DiscountAmount.Text = ""
            SubtotalAmount.Text = ""
            TaxAmount.Text = ""
            TotalAmount.Text = ""

            ClearButtonOccupiedSettings(currentTable)

            'Refresh the OOS grids to show Food/Drink changes
            RefreshGridOOSFood("SELECT * FROM Food  WHERE Inventory=0 ORDER BY FoodName")
            RefreshGridOOSDrinks("SELECT * FROM Drinks  WHERE Inventory=0 ORDER BY DrinkName")

            'return to tables tab
            Tabs.SelectTab(2)
        End If

    End Sub

    Private Sub ClearButtonOccupiedSettings(currTable)
        If currentTable = 1 Then
            btnTable1.BackColor = Color.PaleGreen
            table1Occupied = False
        ElseIf currentTable = 2 Then
            btnTable2.BackColor = Color.PaleGreen
            table2Occupied = False
        ElseIf currentTable = 3 Then
            btnTable3.BackColor = Color.PaleGreen
        ElseIf currentTable = 4 Then
            btnTable4.BackColor = Color.PaleGreen
        ElseIf currentTable = 5 Then
            btnTable5.BackColor = Color.PaleGreen
        ElseIf currentTable = 6 Then
            btnTable6.BackColor = Color.PaleGreen
        End If
    End Sub


    Private Sub updateInventory()
        ' Update inventory amounts depending on food or drink purchased
        Dim tempDrinkInventory As Integer
        Dim tempFoodInventory As Integer

        ' Update Drinks
        If drinkID = Nothing Then
            'do nothing
        Else
            Access.addParam("@ID", drinkID)
            tempDrinkInventory = Access.RetrieveQuery("SELECT Inventory FROM Drinks WHERE ID = @ID", "Inventory")
            tempDrinkInventory = Convert.ToInt32(tempDrinkInventory) - 1

            Access.addParam("@Inventory", tempDrinkInventory)
            Access.addParam("@ID", drinkID)
            ' Execute UPDATE Command '
            Access.ExecQuery("UPDATE Drinks " & _
                    "SET Inventory=@Inventory WHERE ID=@ID")

            ' Report and abort on errors'
            If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If

        'Update Food
        If foodID = Nothing Then
            'do nothing
        Else
            Access.addParam("@ID", foodID)
            tempFoodInventory = Access.RetrieveQuery("SELECT Inventory FROM Food WHERE ID = @ID", "Inventory")
            tempFoodInventory = Convert.ToInt32(tempFoodInventory) - 1
            Access.addParam("@Inventory", tempFoodInventory)
            Access.addParam("@ID", foodID)
            ' Execute UPDATE Command '
            Access.ExecQuery("UPDATE Food " & _
                    "SET Inventory=@Inventory WHERE ID=@ID")

            ' Report and abort on errors'
            If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
    End Sub

    Private Sub createReceipt()
        ' create new receipt in DB

        Dim currDate As String = ""
        Dim dtfInfo1 As DateTimeFormatInfo
        Dim dtStyle1 As String = "MM/d/yy"
        dtfInfo1 = DateTimeFormatInfo.InvariantInfo
        currDate = DateTime.Now.ToString(dtStyle1, dtfInfo1)

        Dim currTime As String = ""
        Dim dtfInfo2 As DateTimeFormatInfo
        Dim dtStyle2 As String = "HH:mm"
        dtfInfo2 = DateTimeFormatInfo.InvariantInfo
        currTime = DateTime.Now.ToString(dtStyle2, dtfInfo2)


        Dim foodReceiptName As String = FoodName.Text + " - " + FoodType.Text
        Dim drinkReceiptName As String = DrinkNameFinal.Text + " - " + DrinkSizeFinal.Text
        Dim totalAmountReceipt As String = FormatCurrency(TotalAmount.Text, 2, True, True, True)
        ' Add Parameters for the query '
        Access.addParam("@TransactionDate", currDate)
        Access.addParam("@TransactionTime", currTime)
        Access.addParam("@EmployeeID", currentUserId)
        Access.addParam("@Drink", drinkReceiptName)
        Access.addParam("@Food", foodReceiptName)
        Access.addParam("@Total", TotalAmount.Text)

        ' Execute Insert Command '
        Access.ExecQuery("INSERT INTO Receipts (TransactionDate,TransactionTime,EmployeeID,Drink,Food,Total)" &
                         "VALUES (@TransactionDate,@TransactionTime,@EmployeeID,@Drink,@Food,@Total); ")

        ' Report and abort on errors'
        If Not String.IsNullOrWhiteSpace(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
    End Sub


    '************MANAGER TAB******************************************
    Public Sub RefreshGrid(query As String)
        ' Run Query '
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill datagrid '
        dgvData.DataSource = Access.DBDT
    End Sub


    Private Sub editDrinks_Click(sender As Object, e As EventArgs) Handles editDrinks.Click
        'HIDE UNUSED BUTTONS
        bttnAddFood.Hide()
        bttnEditFood.Hide()
        bttnEditRecord.Hide()
        bttnAddEmp.Hide()
        bttnViewRecord.Hide()
        btn86Drink.Show()
        TotalButton.Hide()
        FilterToday.Hide()
        RemoveFilter.Hide()
        bttnEditSchedule.Hide()
        bttnAddSchedule.Hide()
        bttnViewSchedule.Hide()

        'OPEN EDIT DRINKS SCREEN
        showDrinkTable()

        'SHOW HIDDEN BUTTONS
        bttnAddDrink.Show()
        bttnEditDrink.Show()
        btn86Drink.Show()
    End Sub

    Private Sub editFood_Click(sender As Object, e As EventArgs) Handles editFood.Click
        'HIDE UNUSED BUTTONS
        bttnAddDrink.Hide()
        bttnEditDrink.Hide()
        bttnEditRecord.Hide()
        bttnAddEmp.Hide()
        bttnViewRecord.Hide()
        btn86Drink.Hide()
        TotalButton.Hide()
        FilterToday.Hide()
        RemoveFilter.Hide()
        bttnEditSchedule.Hide()
        bttnAddSchedule.Hide()
        bttnViewSchedule.Hide()

        'OPEN EDIT FOOD SCREEN
        showFoodTable()

        'SHOW HIDDEN BUTTONS
        bttnAddFood.Show()
        bttnEditFood.Show()
        btn86Food.Show()
    End Sub


    Private Sub editEmpl_Click(sender As Object, e As EventArgs) Handles editEmpl.Click
        'HIDE UNUSED BUTTONS
        bttnAddFood.Hide()
        bttnEditFood.Hide()
        bttnAddDrink.Hide()
        bttnEditDrink.Hide()
        btn86Drink.Hide()
        btn86Food.Hide()
        TotalButton.Hide()
        FilterToday.Hide()
        RemoveFilter.Hide()
        bttnEditSchedule.Hide()
        bttnAddSchedule.Hide()
        bttnViewSchedule.Hide()

        'Shows the table containing employee info'
        showEmployeeTable()

        'Show the button open form allowing editing of selected employee '
        bttnEditRecord.Show()
        bttnAddEmp.Show()
        bttnViewRecord.Show()
    End Sub

    Private Sub emplHours_Click(sender As Object, e As EventArgs) Handles emplHours.Click
        'HIDE UNUSED BUTTONS
        bttnAddFood.Hide()
        bttnEditFood.Hide()
        bttnAddDrink.Hide()
        bttnEditDrink.Hide()
        bttnEditRecord.Hide()
        bttnAddEmp.Hide()
        bttnViewRecord.Hide()
        btn86Drink.Hide()
        btn86Food.Hide()
        TotalButton.Hide()
        FilterToday.Hide()
        RemoveFilter.Hide()
        bttnEditSchedule.Hide()
        bttnAddSchedule.Hide()
        bttnViewSchedule.Hide()

        'DISPLAY EMPLOYEE HOURS
        showHoursTable()
    End Sub

    Private Sub reports_Click(sender As Object, e As EventArgs) Handles reports.Click
        'HIDE UNUSED BUTTONS
        bttnAddFood.Hide()
        bttnEditFood.Hide()
        bttnAddDrink.Hide()
        bttnEditDrink.Hide()
        bttnEditRecord.Hide()
        bttnAddEmp.Hide()
        bttnViewRecord.Hide()
        btn86Drink.Hide()
        btn86Food.Hide()
        bttnEditSchedule.Hide()
        bttnAddSchedule.Hide()
        bttnViewSchedule.Hide()

        'OPEN REPORTS
        showReportsTable()

        'Show relevant buttons for reports
        TotalButton.Show()
        FilterToday.Show()
        RemoveFilter.Show()


    End Sub


    Private Sub schedule_Click(sender As Object, e As EventArgs) Handles schedule.Click
        'HIDE UNUSED BUTTONS
        bttnAddFood.Hide()
        bttnEditFood.Hide()
        bttnAddDrink.Hide()
        bttnEditDrink.Hide()
        bttnEditRecord.Hide()
        bttnAddEmp.Hide()
        bttnViewRecord.Hide()
        btn86Drink.Hide()
        btn86Food.Hide()
        TotalButton.Hide()
        FilterToday.Hide()
        RemoveFilter.Hide()

        'show employee schedule
        showScheduleTable()

        'Show relevant buttons for reports
        bttnEditSchedule.Show()
        bttnAddSchedule.Show()
        bttnViewSchedule.Show()

    End Sub

    Private Sub showDrinkTable()
        'Lists the drinks sorted by drink name'
        RefreshGrid("SELECT * FROM Drinks ORDER BY DrinkName")

        'Hide drink ID'
        dgvData.Columns(0).Visible = False
        dgvData.Columns(1).HeaderText = "Drink"
        dgvData.Columns(2).HeaderText = "Small Price ($)"
        dgvData.Columns(3).HeaderText = "Medium Price ($)"
        dgvData.Columns(4).HeaderText = "Large Price ($)"

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub

    Private Sub showFoodTable()
        'Lists the drinks sorted by drink name'
        RefreshGrid("SELECT * FROM Food ORDER BY Category")

        'Hide food id
        dgvData.Columns(0).Visible = False

        dgvData.Columns(1).HeaderText = "Food Type"
        dgvData.Columns(2).HeaderText = "Category"
        dgvData.Columns(3).HeaderText = "Price ($)"
        dgvData.Columns(4).HeaderText = "Inventory"

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub


    Private Sub showEmployeeTable()
        'Lists the employees sorted by last name'
        RefreshGrid("SELECT * FROM Employee ORDER BY LastName")

        'Sets the headers to a readable format '
        dgvData.Columns(0).HeaderText = "First Name"
        dgvData.Columns(1).HeaderText = "Last Name"

        'Displays only first name and last name of employees in the data grid'
        For i As Integer = 3 To dgvData.ColumnCount - 1
            dgvData.Columns(i).Visible = False
        Next

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub

    Private Sub showHoursTable()
        'Lists the time logs'
        RefreshGrid("SELECT * FROM Hours ORDER BY CurrentDate")


        'Hide id
        dgvData.Columns(6).Visible = False

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub


    Private Sub showReportsTable()

        'Lists the receipts'
        RefreshGrid("SELECT * FROM Receipts ORDER BY ID")
        dgvData.Columns(1).HeaderText = "Date"
        dgvData.Columns(2).HeaderText = "Time"
        dgvData.Columns(3).HeaderText = "Employee"
        dgvData.Columns(6).HeaderText = "Total ($)"


        'Hide id
        dgvData.Columns(0).Visible = False

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub

    Private Sub showScheduleTable()
        'Lists the drinks sorted by drink name'
        RefreshGrid("SELECT * FROM Schedule ORDER BY ID")
        dgvData.Columns(1).HeaderText = "Date"
        dgvData.Columns(2).HeaderText = "Morning Shift"
        dgvData.Columns(3).HeaderText = "Afternoon Shift"

        'Hide  id
        dgvData.Columns(0).Visible = False

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub

    Private Sub bttnAddFood_Click(sender As Object, e As EventArgs) Handles bttnAddFood.Click
        'ADD FOOD BUTTON
        AddFoodProduct.Show()
    End Sub

    Private Sub bttnEditFood_Click(sender As Object, e As EventArgs) Handles bttnEditFood.Click
        'EDIT FOOD BUTTON
        ' Grabs the values from the selected row and puts them into the update form '
        EditFoodProduct.foodId = dgvData.CurrentRow.Cells(0).Value
        EditFoodProduct.txtname.Text = dgvData.CurrentRow.Cells(1).Value
        EditFoodProduct.txtCategory.Text = dgvData.CurrentRow.Cells(2).Value
        EditFoodProduct.txtPrice.Text = dgvData.CurrentRow.Cells(3).Value
        EditFoodProduct.txtInventory.Text = dgvData.CurrentRow.Cells(4).Value

        EditFoodProduct.Show()
    End Sub

    Private Sub bttnAddDrink_Click(sender As Object, e As EventArgs) Handles bttnAddDrink.Click
        'ADD DRINK BUTTON
        AddDrinkProduct.Show()
    End Sub

    Private Sub bttnEditDrink_Click(sender As Object, e As EventArgs) Handles bttnEditDrink.Click
        'EDIT DRINK BUTTON

        ' Grabs the values from the selected row and puts them into the update form '
        EditDrinkProduct.drinkId = dgvData.CurrentRow.Cells(0).Value.ToString
        EditDrinkProduct.txtname.Text = dgvData.CurrentRow.Cells(1).Value
        EditDrinkProduct.txtSmallPrice.Text = dgvData.CurrentRow.Cells(2).Value
        EditDrinkProduct.txtMediumPrice.Text = dgvData.CurrentRow.Cells(3).Value
        EditDrinkProduct.txtLargePrice.Text = dgvData.CurrentRow.Cells(4).Value
        EditDrinkProduct.txtInventory.Text = dgvData.CurrentRow.Cells(5).Value
        EditDrinkProduct.txtType.Text = dgvData.CurrentRow.Cells(6).Value
        EditDrinkProduct.Show()
    End Sub

    Private Sub bttnViewRecord_Click(sender As Object, e As EventArgs) Handles bttnViewRecord.Click
        'VIEW EMPLOYEE
        ViewEmployee.txtFname.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        ViewEmployee.txtLname.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        ViewEmployee.txtEmpID.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        ViewEmployee.chkboxManager.Checked = dgvData.CurrentRow.Cells(3).Value
        ViewEmployee.txtAddress.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        ViewEmployee.txtEmail.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        ViewEmployee.txtPhone.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        ViewEmployee.txtCity.Text = dgvData.CurrentRow.Cells(7).Value.ToString
        ViewEmployee.txtState.Text = dgvData.CurrentRow.Cells(8).Value.ToString
        ViewEmployee.txtPayRate.Text = dgvData.CurrentRow.Cells(9).Value.ToString
        ViewEmployee.txtZip.Text = dgvData.CurrentRow.Cells(10).Value.ToString
        ViewEmployee.Show()
    End Sub


    Private Sub bttnEditRecord_Click(sender As Object, e As EventArgs) Handles bttnEditRecord.Click
        'EDIT EMPLOYEE
        ' Grabs the values from the selected row and puts them into the update form '

        UpdateEmployee.txtFname.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        UpdateEmployee.txtLname.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        UpdateEmployee.txtEmpID.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        UpdateEmployee.chkboxManager.Checked = dgvData.CurrentRow.Cells(3).Value
        UpdateEmployee.txtAddress.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        UpdateEmployee.txtEmail.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        UpdateEmployee.txtPhone.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        UpdateEmployee.txtCity.Text = dgvData.CurrentRow.Cells(7).Value.ToString
        UpdateEmployee.txtState.Text = dgvData.CurrentRow.Cells(8).Value.ToString
        UpdateEmployee.txtPayRate.Text = dgvData.CurrentRow.Cells(9).Value.ToString
        UpdateEmployee.txtZip.Text = dgvData.CurrentRow.Cells(10).Value.ToString
        UpdateEmployee.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs)
        'EDIT EMPLOYEE
        ' Grabs the values from the selected row and puts them into the update form '

        UpdateEmployee.txtFname.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        UpdateEmployee.txtLname.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        UpdateEmployee.txtEmpID.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        UpdateEmployee.chkboxManager.Checked = dgvData.CurrentRow.Cells(3).Value
        UpdateEmployee.txtAddress.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        UpdateEmployee.txtEmail.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        UpdateEmployee.txtPhone.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        UpdateEmployee.txtCity.Text = dgvData.CurrentRow.Cells(7).Value.ToString
        UpdateEmployee.txtState.Text = dgvData.CurrentRow.Cells(8).Value.ToString
        UpdateEmployee.txtPayRate.Text = dgvData.CurrentRow.Cells(9).Value.ToString
        UpdateEmployee.txtZip.Text = dgvData.CurrentRow.Cells(10).Value.ToString
        UpdateEmployee.Show()
    End Sub

    Private Sub btnPersonalPage_Click(sender As Object, e As EventArgs) Handles btnPersonalPage.Click
        Tabs.SelectTab(1)
    End Sub

    Private Sub btnTables_Click(sender As Object, e As EventArgs) Handles btnTables.Click
        Tabs.SelectTab(2)
    End Sub

    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click
        Tabs.SelectTab(5)
    End Sub

    Private Sub bttnAddEmp_Click(sender As Object, e As EventArgs) Handles bttnAddEmp.Click
        'Show form for adding new employee
        NewEmployee.Show()
    End Sub

    Private Sub btn86Drink_Click(sender As Object, e As EventArgs) Handles btn86Drink.Click
        Dim drinkId As Integer = dgvData.CurrentRow.Cells(0).Value
        Access.addParam("@Inventory", 0)
        Access.addParam("@ID", drinkId)

        Access.ExecQuery("UPDATE Drinks " &
                "SET Inventory=@Inventory WHERE ID=@ID")

        'Refresh the grid to show drink product changes
        RefreshGrid("SELECT * FROM Drinks ORDER BY Type")

        'Refresh the OOS grid to show Drink changes
        RefreshGridOOSDrinks("SELECT * FROM Drinks  WHERE Inventory=0 ORDER BY DrinkName")
    End Sub

    Private Sub btn86Food_Click(sender As Object, e As EventArgs) Handles btn86Food.Click
        Dim foodId As Integer = dgvData.CurrentRow.Cells(0).Value
        Access.addParam("@Inventory", 0)
        Access.addParam("@ID", foodId)

        Access.ExecQuery("UPDATE Food " &
                "SET Inventory=@Inventory WHERE ID=@ID")

        'Refresh the grid to show drink product changes
        RefreshGrid("SELECT * FROM Food ORDER BY Category")

        'Refresh the OOS grid to show Drink changes
        RefreshGridOOSFood("SELECT * FROM Food  WHERE Inventory=0 ORDER BY FoodName")
    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim currDate As String = ""
        Dim dtfInfo1 As DateTimeFormatInfo
        Dim dtStyle1 As String = "MM/d/yy"
        dtfInfo1 = DateTimeFormatInfo.InvariantInfo
        currDate = DateTime.Now.ToString(dtStyle1, dtfInfo1)

        Access.addParam("@TransactionDate", currDate)
        Dim TodaysTotal As String = Access.RetrieveQuery("SELECT sum(Total) AS TodaysTotal FROM Receipts WHERE TransactionDate = @TransactionDate", "TodaysTotal")
        TodaysTotal = FormatCurrency(TodaysTotal, , , TriState.True, TriState.True)
        MsgBox("Total Payments for today (" + currDate + ") : " + TodaysTotal)

    End Sub

    Private Sub FilterToday_Click(sender As Object, e As EventArgs) Handles FilterToday.Click
        Dim currDate As String = ""
        Dim dtfInfo1 As DateTimeFormatInfo
        Dim dtStyle1 As String = "MM/d/yy"
        dtfInfo1 = DateTimeFormatInfo.InvariantInfo
        currDate = DateTime.Now.ToString(dtStyle1, dtfInfo1)

        Access.addParam("@TransactionDate", currDate)
        'Lists the receipts'
        RefreshGrid("SELECT * FROM Receipts WHERE TransactionDate=@TransactionDate ORDER BY ID")
        dgvData.Columns(1).HeaderText = "Date"
        dgvData.Columns(2).HeaderText = "Time"
        dgvData.Columns(3).HeaderText = "Employee"
        dgvData.Columns(6).HeaderText = "Total ($)"


        'Hide id
        dgvData.Columns(0).Visible = False

        'Displays the data grid to the user'
        dgvData.Show()
    End Sub


    Private Sub RemoveFilter_Click(sender As Object, e As EventArgs) Handles RemoveFilter.Click
        showReportsTable()
    End Sub

    Private Sub bttnAddSchedule_Click(sender As Object, e As EventArgs) Handles bttnAddSchedule.Click
        CreateSchedule.Show()
    End Sub

    Private Sub bttnEditSchedule_Click(sender As Object, e As EventArgs) Handles bttnEditSchedule.Click

        EditSchedule.morning2.Text = Nothing
        EditSchedule.morning3.Text = Nothing
        EditSchedule.noon2.Text = Nothing
        EditSchedule.noon3.Text = Nothing

        Dim index As Integer
        Dim tempMorningData As String
        Dim tempMorningArray() As String

        Dim tempNoonData As String
        Dim tempNoonArray() As String

        ' Grabs the values from the selected row'
        EditSchedule.ScheduleID = dgvData.CurrentRow.Cells(0).Value
        EditSchedule.scheduleDate.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        tempMorningData = dgvData.CurrentRow.Cells(2).Value.ToString
        tempNoonData = dgvData.CurrentRow.Cells(3).Value.ToString

        tempMorningData = Trim(tempMorningData)
        tempMorningArray = Split(tempMorningData, ",")
        'keep Managers name only
        'keep Employees name only
        tempMorningArray(0) = Microsoft.VisualBasic.Right(tempMorningArray(0), tempMorningArray(0).Length - 9)
        tempMorningArray(1) = Microsoft.VisualBasic.Right(tempMorningArray(1), tempMorningArray(1).Length - 14)

        tempNoonData = Trim(tempNoonData)
        tempNoonArray = Split(tempNoonData, ",")
        'keep Managers name only
        tempNoonArray(0) = Microsoft.VisualBasic.Right(tempNoonArray(0), tempNoonArray(0).Length - 9)
        'keep Employees name only
        tempNoonArray(1) = Microsoft.VisualBasic.Right(tempNoonArray(1), tempNoonArray(1).Length - 14)

        For index = 0 To tempMorningArray.GetUpperBound(0)
            If index = 0 Then
                EditSchedule.morningManager.Text = tempMorningArray(index)
            End If

            If index = 1 Then
                EditSchedule.morning1.Text = tempMorningArray(index)
            End If

            If index = 2 Then
                EditSchedule.morning2.Text = tempMorningArray(index)
            End If

            If index = 3 Then
                EditSchedule.morning3.Text = tempMorningArray(index)
            End If
        Next

        For index = 0 To tempNoonArray.GetUpperBound(0)
            If index = 0 Then
                EditSchedule.noonManager.Text = tempNoonArray(index)
            End If

            If index = 1 Then
                EditSchedule.noon1.Text = tempNoonArray(index)
            End If

            If index = 2 Then
                EditSchedule.noon2.Text = tempNoonArray(index)
            End If

            If index = 3 Then
                EditSchedule.noon3.Text = tempNoonArray(index)
            End If

        Next

        EditSchedule.Show()
    End Sub

    Private Sub bttnViewSchedule_Click(sender As Object, e As EventArgs) Handles bttnViewSchedule.Click
        ViewSchedule.morning2.Text = Nothing
        ViewSchedule.morning3.Text = Nothing
        ViewSchedule.noon2.Text = Nothing
        ViewSchedule.noon3.Text = Nothing

        Dim index As Integer
        Dim tempMorningData As String
        Dim tempMorningArray() As String

        Dim tempNoonData As String
        Dim tempNoonArray() As String

        ' Grabs the values from the selected row'
        ViewSchedule.scheduleDate.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        tempMorningData = dgvData.CurrentRow.Cells(2).Value.ToString
        tempNoonData = dgvData.CurrentRow.Cells(3).Value.ToString

        tempMorningData = Trim(tempMorningData)
        tempMorningArray = Split(tempMorningData, ",")
        'keep Managers name only
        'keep Employees name only
        tempMorningArray(0) = Microsoft.VisualBasic.Right(tempMorningArray(0), tempMorningArray(0).Length - 9)
        tempMorningArray(1) = Microsoft.VisualBasic.Right(tempMorningArray(1), tempMorningArray(1).Length - 14)

        tempNoonData = Trim(tempNoonData)
        tempNoonArray = Split(tempNoonData, ",")
        'keep Managers name only
        tempNoonArray(0) = Microsoft.VisualBasic.Right(tempNoonArray(0), tempNoonArray(0).Length - 9)
        'keep Employees name only
        tempNoonArray(1) = Microsoft.VisualBasic.Right(tempNoonArray(1), tempNoonArray(1).Length - 14)

        For index = 0 To tempMorningArray.GetUpperBound(0)
            If index = 0 Then
                ViewSchedule.morningManager.Text = tempMorningArray(index)
            End If

            If index = 1 Then
                ViewSchedule.morning1.Text = tempMorningArray(index)
            End If

            If index = 2 Then
                ViewSchedule.morning2.Text = tempMorningArray(index)
            End If

            If index = 3 Then
                ViewSchedule.morning3.Text = tempMorningArray(index)
            End If
        Next

        For index = 0 To tempNoonArray.GetUpperBound(0)
            If index = 0 Then
                ViewSchedule.noonManager.Text = tempNoonArray(index)
            End If

            If index = 1 Then
                ViewSchedule.noon1.Text = tempNoonArray(index)
            End If

            If index = 2 Then
                ViewSchedule.noon2.Text = tempNoonArray(index)
            End If

            If index = 3 Then
                ViewSchedule.noon3.Text = tempNoonArray(index)
            End If

        Next
        ViewSchedule.Show()
    End Sub



End Class