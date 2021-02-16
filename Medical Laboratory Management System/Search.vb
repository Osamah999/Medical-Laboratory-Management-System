Imports System.Data
Imports System.Data.SqlClient
Public Class Search
    Public dt As New DataTable
    Public sqlselect As String = "SELECT * FROM Patient"
    Public searchQuery As String = "SELECT * FROM Test"
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim sqlAdp As SqlDataAdapter
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter(sqlselect, con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
            End Using
            DGVSearch.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FilterData(valuetoSearch As String)
        Dim SearchText As String = searchQuery & " Like '%" & TextBox2.Text & "%'"
        Using con As SqlConnection = New SqlConnection(Main.conection)
            Dim command As New SqlCommand(SearchText, con)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVSearch.DataSource = table
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        DGVSearch.DataSource = Nothing
        Me.Close()
    End Sub

    Private Sub btnresult_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close()
    End Sub

    Private Sub DGVSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSearch.CellContentClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        FilterData(TextBox2.Text)
    End Sub
End Class