Imports System.Data
Imports System.Data.SqlClient
Public Class Settings
    Dim isupdate As Boolean = False
    Public conection As String = "server=OSAMAH_PC\SQLEXPRESS;database=Medicallab ;user id =Sa;Password=12345678"
    Public sqlcon As New SqlConnection(conection)
    Private Shared _instance As Settings
    Public Shared ReadOnly Property Instance() As Settings
        Get
            If _instance Is Nothing Then
                _instance = New Settings()
            End If
            Return _instance
        End Get
    End Property
    Private Sub clearform()
        txtUserID.Text = String.Empty
        txtUserName.Text = String.Empty
        txtPassword.Text = String.Empty
    End Sub
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGVSettings_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSettings.CellDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DGVSettings.Rows(index)
            txtUserID.Text = selectedRow.Cells(0).Value.ToString()
            txtUserName.Text = selectedRow.Cells(1).Value.ToString()
            txtPassword.Text = selectedRow.Cells(2).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Try
            If String.IsNullOrEmpty(txtUserID.Text) Then
                MessageBox.Show("Enter User ID")
                Return
            End If
            Dim User_ID As String = txtUserID.Text
            Dim User_Name As String = txtUserName.Text
            Dim Password As String = txtPassword.Text
            Dim radiovalue As String
            If RBUser.Checked = True Then
                radiovalue = "User"
            ElseIf RBAdmin.Checked = True Then
                radiovalue = "Admin"
            Else
                MsgBox("Please select permission", MsgBoxStyle.Information, "Missing")
                Return

            End If
            Dim query1 As String = "If exists(SELECT * FROM User_Settings WHERE User_ID =" + txtUserID.Text + ")

                           Update [dbo].[User_Settings]
              SET [User_Name] = @User_Name
                 ,[Password] = @Password
                 ,[Permission] = @radiovalue
            WHERE [User_ID] = @User_ID
           else 
              INSERT INTO [dbo].[User_Settings]
                             ([User_ID]
                             ,[User_Name]
                             ,[Password]
                             ,[Permission])
                            VALUES
                             (@User_ID,@User_Name,@Password,@radiovalue)"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                Using cmd As SqlCommand = New SqlCommand(query1, con)
                    cmd.Parameters.AddWithValue("@User_ID", User_ID)
                    cmd.Parameters.AddWithValue("@User_Name", User_Name)
                    cmd.Parameters.AddWithValue("@Password", Password)
                    cmd.Parameters.AddWithValue("@radiovalue", radiovalue)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Saved")
                    isupdate = True
                    load_table()
                    clearform()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Try
            clearform()
            isUpdate = False
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT isnull(Max(User_ID),0)+1  FROM User_settings ", con)
                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
            End Using
            txtUserID.Text = dt.Rows(0).Item(0)
            load_table()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrEmpty(txtUserID.Text) Then
                MessageBox.Show("Enter User ID")
                Return
            End If
            Dim query As String = "Delete From User_Settings WHERE User_ID = " + txtUserID.Text
            Using con As SqlConnection = New SqlConnection(Main.conection)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Deleted")
                    isupdate = False
                    clearform()
                    load_table()
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clearform()
    End Sub
    Public Sub load_table()
        Dim Query As String = "Select * from User_Settings"
        If Login.UserType = "User" Then

            Query = "select * from User_Settings where User_ID = '" + txtUserID.Text + "' and Permission ='User' "
        End If
        Using con As SqlConnection = New SqlConnection(Main.conection)
            Using cmd As SqlCommand = New SqlCommand(Query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DGVSettings.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
