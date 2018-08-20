Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class DBControl
    ' Create our database connection '
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         "Data Source=POS.accdb;")

    ' Prepare DB command '
    Private DBCmd As OleDbCommand

    ' DB Data '
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' Query Parameters '
    Public Params As New List(Of OleDbParameter)

    ' Query Statistics '
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""

        Try
            ' Open a connection '
            DBCon.Open()

            ' Create DB Command '
            DBCmd = New OleDbCommand(Query, DBCon)

            ' Load params into db command '
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' Clear params list '
            Params.Clear()

            ' Execute command and fill data set '
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)


        Catch ex As Exception
            Exception = ex.Message
        End Try

        'Close DB Connetion
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    Function RetrieveQuery(Query As String, Field As String)
        Dim result As String = ""

        RecordCount = 0

        ' Open a connection '
        DBCon.Open()

        ' Create DB Command '
        DBCmd = New OleDbCommand(Query, DBCon)

        ' Load params into db command '
        Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

        ' Clear params list '
        Params.Clear()


        DBCmd.CommandType = CommandType.Text
        Dim dataReader As OleDbDataReader = DBCmd.ExecuteReader()

        While dataReader.Read()
            result = dataReader(Field).ToString()
        End While

        'Close DB Connetion
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

        Return result
    End Function

    ' Include query and command parameters '
    Public Sub addParam(Name As String, Value As Object)
        Dim newParameter As New OleDbParameter(Name, Value)
        Params.Add(newParameter)
    End Sub
End Class
