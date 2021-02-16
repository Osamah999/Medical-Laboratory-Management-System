Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Public UserName As String
    Public UserType As String = "User"
    Public conection As String = "server=OSAMAH_PC\SQLEXPRESS;database=Medicallab ;user id =Sa;Password=12345678"
    Public sqlcon As New SqlConnection(conection)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Password As String = txtPassword.Text
        UserName = txtUserName.Text
        Dim radioValue As String
        If RBUser.Checked = True Then
            radioValue = "User"
        ElseIf RBAdmin.Checked = True Then
            radioValue = "Admin"
        Else
            MsgBox("Please select permission", MsgBoxStyle.Information, "Missing")
            Return
        End If
        Dim command As New SqlCommand("select * from User_Settings where User_Name = @User_Name  and Password = @Password and Permission = @permission", sqlcon)
        command.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = UserName
        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password
        command.Parameters.Add("@permission", SqlDbType.VarChar).Value = radioValue
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Please Enter Valid Data")
            Return
        Else
            If table.Rows(0)(3) = "User" Then
                Settings.Instance.btnAdd.Enabled = False
                Settings.Instance.btnsave.Enabled = True
                Settings.Instance.btndelete.Enabled = False
                Settings.Instance.btncancel.Enabled = True
                Settings.Instance.txtUserName.Enabled = False
                Settings.Instance.GroupBox1.Enabled = False
                Settings.Instance.RBUser.Checked = True
                Settings.Instance.RBAdmin.Checked = False
                UserType = "User"
                sqlcon.Open()
                Dim commands As New SqlCommand("SELECT User_ID,User_Name,Password,Permission FROM User_Settings where User_Name = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Permission = '" + radioValue + "' ", sqlcon)
                Dim adapters As New SqlDataAdapter(commands)
                Dim dataset As New DataSet()
                adapters.Fill(dataset, "User_Name")
                Settings.Instance.DGVSettings.DataSource = dataset.Tables("User_Name")
                sqlcon.Close()
            ElseIf table.Rows(0)(3) = "Admin" Then
                Settings.Instance.btnAdd.Enabled = True
                Settings.Instance.btnsave.Enabled = True
                Settings.Instance.btndelete.Enabled = True
                Settings.Instance.btncancel.Enabled = True
                Settings.Instance.txtUserName.Enabled = True
                Settings.Instance.GroupBox1.Enabled = True
                sqlcon.Open()
                UserType = "Admin"
                Dim commands As New SqlCommand("SELECT User_ID,User_Name,Password,Permission FROM User_Settings ", sqlcon)
                Dim adapters As New SqlDataAdapter(commands)
                Dim dataset As New DataSet()
                adapters.Fill(dataset, "User_Name")
                Settings.Instance.DGVSettings.DataSource = dataset.Tables("User_Name")
                sqlcon.Close()
            End If
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub
End Class