Imports System.Data
Imports System.Data.SqlClient
Public Class Main
    Public conection As String = "server=OSAMAH_PC\SQLEXPRESS;database=Medicallab ;user id =Sa;Password=12345678"
    Public sqlcon As New SqlConnection(conection)
    Public User_Name As String = "OSAMAH"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpatient.Click
        If Not Panel4.Controls.Contains(Patient.Instance) Then
            Panel4.Controls.Add(Patient.Instance)
            Patient.Instance.Dock = DockStyle.Fill
            Patient.Instance.BringToFront()
            Patient.Instance.Visible = True
        End If
        Patient.Instance.BringToFront()
        Patient.Instance.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btntest.Click
        If Not Panel4.Controls.Contains(Test.Instance) Then
            Panel4.Controls.Add(Test.Instance)
            Test.Instance.Dock = DockStyle.Fill
            Test.Instance.BringToFront()
            Test.Instance.Visible = True
        End If
        Test.Instance.BringToFront()
        Test.Instance.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnresult.Click
        If Not Panel4.Controls.Contains(Result_1.Instance) Then
            Panel4.Controls.Add(Result_1.Instance)
            Result_1.Instance.Dock = DockStyle.Fill
            Result_1.Instance.BringToFront()
            Result_1.Instance.Visible = True
        End If
        Result_1.Instance.BringToFront()
        Result_1.Instance.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnuser_settings.Click
        If Not Panel4.Controls.Contains(Settings.Instance) Then
            Panel4.Controls.Add(Settings.Instance)
            Settings.Instance.Dock = DockStyle.Fill
            Settings.Instance.BringToFront()
            Settings.Instance.Visible = True
        End If
        Settings.Instance.BringToFront()
        Settings.Instance.Visible = True
    End Sub

    Private Sub btnanalysis_Click(sender As Object, e As EventArgs) Handles btnanalysis.Click
        If Not Panel4.Controls.Contains(Bills.Instance) Then
            Panel4.Controls.Add(Bills.Instance)
            Bills.Instance.Dock = DockStyle.Fill
            Bills.Instance.BringToFront()
            Bills.Instance.Visible = True
        End If
        Bills.Instance.BringToFront()
        Bills.Instance.Visible = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Login.Show()
        Settings.Instance.txtUserID.Text = String.Empty
        Settings.Instance.txtUserName.Text = String.Empty
        Settings.Instance.txtPassword.Text = String.Empty

    End Sub
End Class