Imports System.Data
Imports System.Data.SqlClient
Public Class Result_1
    Dim isUpdate As Boolean = False
    Private Shared _instance As Result_1
    Public Shared ReadOnly Property Instance() As Result_1
        Get
            If _instance Is Nothing Then
                _instance = New Result_1()
            End If
            Return _instance
        End Get
    End Property
    Private Sub clearform()
        txtBill_No.Text = String.Empty
        txtPatient_ID.Text = String.Empty
        txtPatient_Name.Text = String.Empty
        txtGender.Text = String.Empty
        txtAge.Text = String.Empty
        DGVResult.Rows.Clear()
    End Sub
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        clearform()
        isUpdate = False
        Dim SearchForm As New Search()
        SearchForm.sqlselect = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID "
        SearchForm.searchQuery = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID And  CONCAT(Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Bills.Create_User,Bills.Create_Date)"
        SearchForm.ShowDialog()
        If SearchForm.DGVSearch.DataSource IsNot Nothing Then

            txtBill_No.Text = SearchForm.DGVSearch.CurrentRow.Cells("Bill_No").Value
            txtPatient_ID.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_ID").Value
            txtPatient_Name.Text = SearchForm.DGVSearch.CurrentRow.Cells("Patient_Name").Value
            GBResult.Enabled = True
            Dim sqlAdp As SqlDataAdapter
            Dim dt As New DataTable
            Using con As SqlConnection = New SqlConnection(Main.conection)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT * FROM Patient WHERE Patient_ID = " + txtPatient_ID.Text, con)

                con.Close() 'connection close here , that is disconnected from data source

                sqlAdp.Fill(dt)
                txtPatient_Name.Text = dt.Rows(0).Item(1)
                txtGender.Text = dt.Rows(0).Item(4)
                txtAge.Text = dt.Rows(0).Item(5)
                con.Open()
                sqlAdp = New SqlDataAdapter("SELECT Order_Detail.*,Test.* FROM Order_Detail,Test WHERE Test.Test_ID = Order_Detail.Test_ID AND Bill_No = " + txtBill_No.Text, con)
                con.Close() 'connection close here , that is disconnected from data source
                dt = New DataTable
                sqlAdp.Fill(dt)
                Dim sum As Double = 0
                For i = 0 To dt.Rows.Count - 1
                    Dim Test_ID As String = dt.Rows(i).Item("Test_ID")
                    Dim Test_Name As String = dt.Rows(i).Item("Test_Name")
                    Dim Result As String = ""
                    If (dt.Rows(i).Item("Result") IsNot DBNull.Value) Then
                        Result = dt.Rows(i).Item("Result")
                    End If
                    Dim Sample_Unit As String = dt.Rows(i).Item("Sample_Unit")
                    Dim State As String = ""
                    If (dt.Rows(i).Item("State") IsNot DBNull.Value) Then
                        State = dt.Rows(i).Item("State")
                    End If
                    Dim Mini_value As String = dt.Rows(i).Item("Mini_value")
                    Dim Max_value As String = dt.Rows(i).Item("Max_value")
                    DGVResult.Rows.Add(New String() {Test_ID, Test_Name, Result, Sample_Unit, State, Mini_value, Max_value})
                Next
            End Using
            isUpdate = True
        Else clearform()
            GBResult.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        GBResult.Enabled = False
        clearform()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtBill_No.Text) Then
                MessageBox.Show("Enter Bill No")
                Return
            End If
            For i = 0 To DGVResult.RowCount - 1
                Dim query As String = "Update [dbo].[Order_Detail]
            SET Result = @Result
             ,[State] = @State
            WHERE Bill_No = @Bill_No and Test_ID = @Test_ID"
                Using con As SqlConnection = New SqlConnection(Main.conection)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Result", DGVResult.Rows(i).Cells("Result").Value)
                        cmd.Parameters.AddWithValue("@State", DGVResult.Rows(i).Cells("State").Value)
                        cmd.Parameters.AddWithValue("@Bill_No", Convert.ToInt32(txtBill_No.Text))
                        cmd.Parameters.AddWithValue("@Test_ID", Convert.ToInt32(DGVResult.Rows(i).Cells("Test_ID").Value))
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next
            MessageBox.Show("Successfully Saved")
            clearform()
            GBResult.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGVResult_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVResult.CellEndEdit
        'e.RowIndex
        Try
            Dim row As DataGridViewRow = DGVResult.Rows(e.RowIndex)
            If (e.ColumnIndex = row.Cells("Result").ColumnIndex) And Not String.IsNullOrEmpty(row.Cells("Result").Value) Then
                'For Each row As DataGridViewRow In DGVResult.Rows
                If (Convert.ToInt32(row.Cells("Result").Value)) < (Convert.ToInt32(row.Cells("Mini_Range").Value)) Then
                    DGVResult.CurrentRow.Cells("State").Value = "Low"
                    DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange
                    ' this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                ElseIf ((Convert.ToInt32(row.Cells("Result").Value)) >= (Convert.ToInt32(row.Cells("Mini_Range").Value)) And (Convert.ToInt32(row.Cells("Result").Value)) <= (Convert.ToInt32(row.Cells("Max_Range").Value))) Then
                    DGVResult.CurrentRow.Cells("State").Value = "Normal"
                    DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Green
                ElseIf (Convert.ToInt32(row.Cells("Result").Value)) > (Convert.ToInt32(row.Cells("Max_Range").Value)) Then
                    DGVResult.CurrentRow.Cells("State").Value = "High"
                    DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                End If
            End If
        Catch ex As Exception
        End Try
        'Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim strSelectionfrm As String = "{Bills.Bill_No}=" & txtBill_No.Text
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New CrystalReport2
        rptdoc.SetDatabaseLogon("sa", "12345678")
        'String strSelectionfrm = "{tblLeaveApp.Date_App}='" & ndLeaApprDt & "'"
        If Not String.IsNullOrEmpty(txtBill_No.Text) Then
            rptdoc.RecordSelectionFormula = strSelectionfrm
        End If
        ' rptdoc.DiscardSavedData
        Report.CrystalReportViewer1.ReportSource = rptdoc
            Report.ShowDialog()
            Report.Dispose()

    End Sub

End Class
