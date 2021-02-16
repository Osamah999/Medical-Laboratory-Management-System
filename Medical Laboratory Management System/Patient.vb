Imports System.Data
Imports System.Data.SqlClient
Public Class Patient
    Dim isUpdate As Boolean = False
    Private Shared _instance As Patient
    Public Shared ReadOnly Property Instance() As Patient
        Get
            If _instance Is Nothing Then
                _instance = New Patient()
            End If
            Return _instance
        End Get
    End Property

    Private Sub clearform()
        txtPatientID.Text = String.Empty
        txtpatientName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtphoneNO.Text = String.Empty
        txtAge.Text = String.Empty
        cmbGender.Text = String.Empty
        cmbMaritalStatus.Text = String.Empty
        cmbBloodGroup.Text = String.Empty

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtPatientID.Text) Then
                MessageBox.Show("Enter Patient ID")
                Return
            End If
            Dim Patient_ID As Integer = txtPatientID.Text
            Dim Patient_Name As String = txtpatientName.Text
            Dim Address As String = txtAddress.Text
            Dim Phone_No As String = txtphoneNO.Text
            Dim Gender As String = cmbGender.Text
            Dim Age As Integer = txtAge.Text
            Dim Marital_Status As String = cmbMaritalStatus.Text
            Dim Blood_Group As String = cmbBloodGroup.Text

            If isUpdate = False Then

                Dim query As String = " INSERT INTO [dbo].[Patient]
           ([Patient_ID]
           ,[Patient_Name]
           ,[Address]
           ,[Phone_No]
           ,[Gender]
           ,[Age]
           ,[Marital_Status]
           ,[Blood_Group]
           ,[Create_User]
           ,[Create_Date])
            values (@Patient_ID,@Patient_Name,@Address,@Phone_No,@Gender,@Age,@Marital_Status,@Blood_Group,@Create_User,getdate())"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                        cmd.Parameters.AddWithValue("@Patient_Name", Patient_Name)
                        cmd.Parameters.AddWithValue("@Address", Address)
                        cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                        cmd.Parameters.AddWithValue("@Gender", Gender)
                        cmd.Parameters.AddWithValue("@Age", Age)
                        cmd.Parameters.AddWithValue("@Marital_Status", Marital_Status)
                        cmd.Parameters.AddWithValue("@Blood_Group", Blood_Group)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Successfully Saved")
                        isUpdate = True
                        clearform()
                        GBPatientdata.Enabled = False
                    End Using

                End Using
            Else isUpdate = True
                Dim query As String = " UPDATE [dbo].[Patient]
   SET Patient_Name = @Patient_Name
      ,Address = @Address
      ,Phone_No = @Phone_No
      ,Gender = @Gender
      ,Age = @Age
      ,Marital_Status = @Marital_Status
      ,Blood_Group = @Blood_Group
      ,Create_User = @Create_User
      ,Create_Date = getdate()
   WHERE Patient_ID = @Patient_ID"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID)
                        cmd.Parameters.AddWithValue("@Patient_Name", Patient_Name)
                        cmd.Parameters.AddWithValue("@Address", Address)
                        cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                        cmd.Parameters.AddWithValue("@Gender", Gender)
                        cmd.Parameters.AddWithValue("@Age", Age)
                        cmd.Parameters.AddWithValue("@Marital_Status", Marital_Status)
                        cmd.Parameters.AddWithValue("@Blood_Group", Blood_Group)
                        cmd.Parameters.AddWithValue("@Create_User", Main.User_Name)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Successfully Updated")
                        isUpdate = True
                        clearform()
                        GBPatientdata.Enabled = False
                    End Using

                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrEmpty(txtPatientID.Text) Then
                MessageBox.Show("Enter Patient ID")
                Return
            End If
            Dim query As String = "Delete From Patient WHERE Patient_ID = " + txtPatientID.Text
            Using con As SqlConnection = New SqlConnection(Main.conection)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Deleted")
                    isUpdate = False
                    clearform()
                    GBPatientdata.Enabled = False
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        isUpdate = False
        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT * FROM Patient"
        SearchForm.searchQuery = "SELECT * FROM [dbo].[Patient] WHERE CONCAT(Patient_ID,Patient_Name,Address,Phone_No,Gender,Age,Marital_Status,Blood_Group,Create_User,Create_Date)"
        SearchForm.ShowDialog()
        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            txtPatientID.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_ID").Value
            txtpatientName.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_Name").Value
            txtAddress.Text = SearchForm.DGVSearch.CurrentRow.Cells("Address").Value
            txtphoneNO.Text = SearchForm.DGVSearch.CurrentRow.Cells("Phone_No").Value
            cmbGender.Text = SearchForm.DGVSearch.CurrentRow.Cells("Gender").Value
            txtAge.Text = SearchForm.DGVSearch.CurrentRow.Cells("Age").Value
            cmbMaritalStatus.Text = SearchForm.DGVSearch.CurrentRow.Cells("Marital_Status").Value
            cmbBloodGroup.Text = SearchForm.DGVSearch.CurrentRow.Cells("Blood_Group").Value
            GBPatientdata.Enabled = True
            isUpdate = True
        Else clearform()
            GBPatientdata.Enabled = False
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            clearform()
            isUpdate = False
            GBPatientdata.Enabled = True
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT isnull(Max(Patient_ID),0)+1  FROM Patient ", con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
            End Using
            txtPatientID.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GBPatientdata.Enabled = False
        clearform()
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
