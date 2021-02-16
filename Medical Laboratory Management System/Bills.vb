Imports System.Data
Imports System.Data.SqlClient
Public Class Bills
    Dim isUpdate As Boolean = False
    Private Shared _instance As Bills
    Public Shared ReadOnly Property Instance() As Bills
        Get
            If _instance Is Nothing Then
                _instance = New Bills()
            End If
            Return _instance
        End Get
    End Property
    Private Sub clearform()
        txtBill_No.Text = String.Empty
        txtPatient_ID.Text = String.Empty
        txtPatient_Name.Text = String.Empty
        txtTprice.Text = String.Empty
        DGVBills.Rows.Clear()

    End Sub
    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        clearform()
        isUpdate = False
        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID "
        SearchForm.searchQuery = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID And  CONCAT(Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Bills.Create_User,Bills.Create_Date)"
        SearchForm.ShowDialog()
        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            txtBill_No.Text = SearchForm.DGVSearch.CurrentRow.Cells("Bill_No").Value
            dtpDate.Text = SearchForm.DGVSearch.CurrentRow.Cells("Bill_Date").Value
            txtPatient_ID.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_ID").Value
            txtPatient_Name.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_Name").Value
            'txtTprice.Text = SearchForm.DGVSearch.CurrentRow.Cells("Total_Price").Value
            GBBills.Enabled = True
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT Patient_Name  FROM Patient WHERE Patient_ID = " + txtPatient_ID.Text, con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
                txtPatient_Name.Text = dt.Rows(0).Item(0)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT Order_Detail.*,Test.Test_Name  FROM Order_Detail,Test WHERE Test.Test_ID = Order_Detail.Test_ID AND Bill_No = " + txtBill_No.Text, con)
                con.Close() 'connection close here , that is disconnected from data source
                dt = New DataTable
                sqlAdp.Fill(dt)
                Dim sum As Double = 0
                For i = 0 To dt.Rows.Count - 1
                    Dim Test_ID As String = dt.Rows(i).Item("Test_ID")
                    Dim Test_Name As String = dt.Rows(i).Item("Test_Name")
                    Dim Price As String = dt.Rows(i).Item("Price")
                    ' Dim Sample_Unit As String = dt.Rows(i).Item("Sample_Unit")
                    Dim Mini_value As String = dt.Rows(i).Item("Mini_value")
                    Dim Max_value As String = dt.Rows(i).Item("Max_value")
                    DGVBills.Rows.Add(New String() {Test_ID, Test_Name, Price, Mini_value, Max_value})
                    sum += DGVBills.Rows(i).Cells(2).Value
                Next
                txtTprice.Text = sum.ToString()
            End Using
            isUpdate = True
        Else clearform()
            GBBills.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            clearform()
            GBBills.Enabled = True
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT isnull(Max(Bill_No),0)+1  FROM Bills ", con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
            End Using
            txtBill_No.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click

        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT * FROM Patient"
        SearchForm.searchQuery = "SELECT * FROM [dbo].[Patient] WHERE CONCAT(Patient_ID,Patient_Name,Address,Phone_No,Gender,Age,Marital_Status,Blood_Group,Create_User,Create_Date)"
        SearchForm.ShowDialog()
        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            txtPatient_ID.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_ID").Value
            txtPatient_Name.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_Name").Value

        End If
    End Sub

    Private Sub btnAddTest_Click(sender As Object, e As EventArgs) Handles btnAddTest.Click
        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT * FROM Test"
        SearchForm.searchQuery = "SELECT * FROM [dbo].[Test] WHERE CONCAT(Test_ID,Test_Name,Test_Type,Sample_Type,Sample_Unit,Mini_value,Max_value,Price)"
        SearchForm.ShowDialog()

        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            Dim Test_ID As String = SearchForm.DGVSearch.CurrentRow.Cells("Test_ID").Value
            Dim Test_Name As String = SearchForm.DGVSearch.CurrentRow.Cells("Test_Name").Value
            Dim Price As String = SearchForm.DGVSearch.CurrentRow.Cells("Price").Value
            ' Dim Sample_Unit As String = SearchForm.DGVSearch.CurrentRow.Cells("Sample_Unit").Value
            Dim Mini_value As String = SearchForm.DGVSearch.CurrentRow.Cells("Mini_value").Value
            Dim Max_value As String = SearchForm.DGVSearch.CurrentRow.Cells("Max_value").Value
            DGVBills.Rows.Add(New String() {Test_ID, Test_Name, Price, Mini_value, Max_value})

        End If
        Dim sum As Double = 0
        For i = 0 To DGVBills.RowCount - 1
            sum += DGVBills.Rows(i).Cells(2).Value
        Next

        txtTprice.Text = sum.ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtBill_No.Text) Then
                MessageBox.Show("Enter Bill No")
                Return
            End If
            Dim Bill_No As Integer = txtBill_No.Text
            Dim Bill_Date As String = dtpDate.Value
            Dim Patient_ID As String = txtPatient_ID.Text
            Dim Total_Price As String = txtTprice.Text


            If isUpdate = False Then
                Dim query As String = " INSERT INTO [dbo].[Bills]
           ([Bill_No]
           ,[Bill_Date]
           ,[Patient_ID]
           ,[Total_Price]
           ,[Create_User]
           ,[Create_Date])
            values (@Bill_No,@Bill_Date,@Patient_ID,@Total_Price,@Create_User,getdate())"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Bill_No", Bill_No)
                        cmd.Parameters.AddWithValue("@Bill_Date", Bill_Date)
                        cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                        cmd.Parameters.AddWithValue("@Total_Price", Total_Price)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using

                    For i = 0 To DGVBills.RowCount - 1
                        query = "INSERT INTO [dbo].[Order_Detail]
           ([Bill_No]
           ,[Test_ID]           
           ,[Price]           
           ,[Mini_value]
           ,[Max_value]
           ,[Patient_ID]
           ,[Create_User]
           ,[Create_Date])
           VALUES(@Bill_No,@Test_ID,@Price,@Mini_value,@Max_value,@Patient_ID,@Create_User,getdate())"
                        Using cmd As SqlCommand = New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@Bill_No", Bill_No)
                            cmd.Parameters.AddWithValue("@Test_ID", DGVBills.Rows(i).Cells("Test_ID").Value)
                            cmd.Parameters.AddWithValue("@Price", DGVBills.Rows(i).Cells("Price").Value)
                            cmd.Parameters.AddWithValue("@Mini_value", DGVBills.Rows(i).Cells("Mini_value").Value)
                            cmd.Parameters.AddWithValue("@Max_value", DGVBills.Rows(i).Cells("Max_value").Value)
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                            cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    Next
                    MessageBox.Show("Successfully Saved")
                    isUpdate = True
                    clearform()
                    GBBills.Enabled = False
                End Using

            Else isUpdate = True
                Dim query As String = "Update [dbo].[Bills]
            SET Bill_Date = Bill_Date
             ,Patient_ID = Patient_ID
             ,Total_Price = Total_Price
             ,Create_User = Create_User
             ,Create_Date = getdate()
            WHERE Bill_No = Bill_No"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Bill_No", Bill_No)
                        cmd.Parameters.AddWithValue("@Bill_Date", Bill_Date)
                        cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                        cmd.Parameters.AddWithValue("@Total_Price", Total_Price)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                    query = "Delete From Order_Detail WHERE Bill_No = " + txtBill_No.Text
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                    For i = 0 To DGVBills.RowCount - 1
                        query = "INSERT INTO [dbo].[Order_Detail]
           ([Bill_No]
           ,[Test_ID]           
           ,[Price]           
           ,[Mini_value]
           ,[Max_value]
           ,[Patient_ID]
           ,[Create_User]
           ,[Create_Date])
           VALUES(@Bill_No,@Test_ID,@Price,@Mini_value,@Max_value,@Patient_ID,@Create_User,getdate())"
                        Using cmd As SqlCommand = New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@Bill_No", Bill_No)
                            cmd.Parameters.AddWithValue("@Test_ID", DGVBills.Rows(i).Cells("Test_ID").Value)
                            cmd.Parameters.AddWithValue("@Price", DGVBills.Rows(i).Cells("Price").Value)
                            cmd.Parameters.AddWithValue("@Mini_value", DGVBills.Rows(i).Cells("Mini_value").Value)
                            cmd.Parameters.AddWithValue("@Max_value", DGVBills.Rows(i).Cells("Max_value").Value)
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                            cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    Next
                    MessageBox.Show("Successfully Updated")
                    isUpdate = True
                    clearform()
                    GBBills.Enabled = False
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrEmpty(txtBill_No.Text) Then
                MessageBox.Show("Enter Bill No")
                Return
            End If
            Dim query As String = "Delete From Order_Detail WHERE Bill_No = " + txtBill_No.Text + " Delete From Bills WHERE Bill_No = " + txtBill_No.Text
            Using con As SqlConnection = New SqlConnection(Main.conection)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Deleted")
                    isUpdate = False
                    clearform()
                    GBBills.Enabled = False
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GBBills.Enabled = False
        clearform()
    End Sub

    Private Sub DGVBills_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBills.CellContentClick
        If DGVBills.Columns("Delete").Index = e.ColumnIndex And e.RowIndex >= 0 Then
            DGVBills.Rows.Remove(DGVBills.CurrentRow)
        End If
    End Sub
End Class
