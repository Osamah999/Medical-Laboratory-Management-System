Imports System.Data
Imports System.Data.SqlClient
Public Class Test
    Dim isUpdate As Boolean = False
    Private Shared _instance As Test
    Public Shared ReadOnly Property Instance() As Test
        Get
            If _instance Is Nothing Then
                _instance = New Test()
            End If
            Return _instance
        End Get
    End Property
    Private Sub clearform()
        txtTestID.Text = String.Empty
        txtTestName.Text = String.Empty
        CmbTestType.Text = String.Empty
        CmbSampleType.Text = String.Empty
        cmbSampleUnit.Text = String.Empty
        txtMini.Text = String.Empty
        txtMax.Text = String.Empty
        txtPrice.Text = String.Empty
    End Sub
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        isUpdate = False
        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT * FROM Test"
        SearchForm.searchQuery = "SELECT * FROM [dbo].[Test] WHERE CONCAT(Test_ID,Test_Name,Test_Type,Sample_Type,Sample_Unit,Mini_value,Max_value,Price,Create_User,Create_Date)"
        SearchForm.ShowDialog()
        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            txtTestID.Text = SearchForm.DGVSearch.CurrentRow.Cells("Test_ID").Value
            txtTestName.Text = SearchForm.DGVSearch.CurrentRow.Cells("Test_Name").Value
            CmbTestType.Text = SearchForm.DGVSearch.CurrentRow.Cells("Test_Type").Value
            CmbSampleType.Text = SearchForm.DGVSearch.CurrentRow.Cells("Sample_Type").Value
            cmbSampleUnit.Text = SearchForm.DGVSearch.CurrentRow.Cells("Sample_Unit").Value
            txtMini.Text = SearchForm.DGVSearch.CurrentRow.Cells("Mini_value").Value
            txtMax.Text = SearchForm.DGVSearch.CurrentRow.Cells("Max_value").Value
            txtPrice.Text = SearchForm.DGVSearch.CurrentRow.Cells("Price").Value
            GBTest.Enabled = True
            isUpdate = True
        Else clearform()
            GBTest.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSava.Click
        Try
            If String.IsNullOrEmpty(txtTestID.Text) Then
                MessageBox.Show("Enter Test ID")
                Return
            End If
            Dim Test_ID As Integer = txtTestID.Text
            Dim Test_Name As String = txtTestName.Text
            Dim Test_Type As String = CmbTestType.Text
            Dim Sample_Type As String = CmbSampleType.Text
            Dim Sample_Unit As String = cmbSampleUnit.Text
            Dim Mini_value As String = txtMini.Text
            Dim Max_value As String = txtMax.Text
            Dim Price As Integer = txtPrice.Text


            If isUpdate = False Then

                Dim query As String = "INSERT INTO [dbo].[Test]
           ([Test_ID]
           ,[Test_Name]
           ,[Test_Type]
           ,[Sample_Type]
           ,[Sample_Unit]
           ,[Mini_value]
           ,[Max_value]
           ,[Price]
           ,[Create_User]
           ,[Create_Date])
            values(@Test_ID,@Test_Name,@Test_Type,@Sample_Type,@Sample_Unit,@Mini_value,@Max_value,@Price,@Create_User,getdate())"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Test_ID", Test_ID)
                        cmd.Parameters.AddWithValue("@Test_Name", Test_Name)
                        cmd.Parameters.AddWithValue("@Test_Type", Test_Type)
                        cmd.Parameters.AddWithValue("@Sample_Type", Sample_Type)
                        cmd.Parameters.AddWithValue("@Sample_Unit", Sample_Unit)
                        cmd.Parameters.AddWithValue("@Mini_value", Mini_value)
                        cmd.Parameters.AddWithValue("@Max_value", Max_value)
                        cmd.Parameters.AddWithValue("@Price", Price)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Successfully Saved")
                        isUpdate = True
                        GBTest.Enabled = False
                        clearform()
                    End Using
                End Using
            Else isUpdate = True
                Dim query As String = "Update [dbo].[Test]
   SET Test_Name = @Test_Name
      ,Test_Type = @Test_Type
      ,Sample_Type = @Sample_Type
      ,Sample_Unit = @Sample_Unit
      ,Mini_value = @Mini_value
      ,Max_value = @Max_value
      ,Price = @Price
      ,Create_User = @Create_User
      ,Create_Date = getdate()
 WHERE Test_ID = @Test_ID "
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Test_ID", Test_ID)
                        cmd.Parameters.AddWithValue("@Test_Name", Test_Name)
                        cmd.Parameters.AddWithValue("@Test_Type", Test_Type)
                        cmd.Parameters.AddWithValue("@Sample_Type", Sample_Type)
                        cmd.Parameters.AddWithValue("@Sample_Unit", Sample_Unit)
                        cmd.Parameters.AddWithValue("@Mini_value", Mini_value)
                        cmd.Parameters.AddWithValue("@Max_value", Max_value)
                        cmd.Parameters.AddWithValue("@Price", Price)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Successfully Updated")
                        GBTest.Enabled = False
                        isUpdate = True
                        clearform()
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            clearform()
            isUpdate = False
            GBTest.Enabled = True
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT isnull(Max(Test_ID),0)+1  FROM Test ", con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
            End Using
            txtTestID.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrEmpty(txtTestID.Text) Then
                MessageBox.Show("Enter Test ID")
                Return
            End If
            Dim query As String = "Delete From Test WHERE Test_ID = " + txtTestID.Text
            Using con As SqlConnection = New SqlConnection(Main.conection)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Deleted")
                    isUpdate = False
                    clearform()
                    GBTest.Enabled = False
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GBTest.Enabled = False
        clearform()
    End Sub
End Class
