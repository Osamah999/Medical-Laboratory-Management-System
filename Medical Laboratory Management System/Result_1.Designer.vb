<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result_1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatient_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPatient_Name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpResult = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.DGVResult = New System.Windows.Forms.DataGridView()
        Me.Test_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sample_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mini_Range = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max_Range = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBResult = New System.Windows.Forms.GroupBox()
        Me.txtBill_No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.DGVResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1189, 613)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(17, 529)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(1157, 63)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Patient ID :-"
        '
        'txtPatient_ID
        '
        Me.txtPatient_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient_ID.Location = New System.Drawing.Point(253, 96)
        Me.txtPatient_ID.Name = "txtPatient_ID"
        Me.txtPatient_ID.Size = New System.Drawing.Size(403, 29)
        Me.txtPatient_ID.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(99, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 21)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Patient Name :-"
        '
        'txtPatient_Name
        '
        Me.txtPatient_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient_Name.Location = New System.Drawing.Point(253, 137)
        Me.txtPatient_Name.Name = "txtPatient_Name"
        Me.txtPatient_Name.Size = New System.Drawing.Size(403, 29)
        Me.txtPatient_Name.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(702, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 21)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Date :-"
        '
        'dtpResult
        '
        Me.dtpResult.CustomFormat = "dd/MM/yyyy"
        Me.dtpResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpResult.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResult.Location = New System.Drawing.Point(793, 56)
        Me.dtpResult.Name = "dtpResult"
        Me.dtpResult.Size = New System.Drawing.Size(200, 29)
        Me.dtpResult.TabIndex = 86
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(761, 538)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(174, 47)
        Me.btnSearch.TabIndex = 88
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(961, 538)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(174, 47)
        Me.btnPrint.TabIndex = 89
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(553, 538)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 47)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(682, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 21)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Gender :-"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(793, 99)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(200, 29)
        Me.txtGender.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(706, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Age :-"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(793, 143)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(200, 29)
        Me.txtAge.TabIndex = 94
        '
        'DGVResult
        '
        Me.DGVResult.AllowUserToAddRows = False
        Me.DGVResult.AllowUserToDeleteRows = False
        Me.DGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Test_ID, Me.Test_Name, Me.Result, Me.Sample_Unit, Me.State, Me.Mini_Range, Me.Max_Range})
        Me.DGVResult.Location = New System.Drawing.Point(213, 188)
        Me.DGVResult.Name = "DGVResult"
        Me.DGVResult.Size = New System.Drawing.Size(795, 309)
        Me.DGVResult.TabIndex = 95
        '
        'Test_ID
        '
        Me.Test_ID.HeaderText = "Test ID"
        Me.Test_ID.Name = "Test_ID"
        Me.Test_ID.Visible = False
        '
        'Test_Name
        '
        Me.Test_Name.HeaderText = "Test_Name"
        Me.Test_Name.Name = "Test_Name"
        Me.Test_Name.ReadOnly = True
        Me.Test_Name.Width = 200
        '
        'Result
        '
        Me.Result.HeaderText = "Result"
        Me.Result.Name = "Result"
        Me.Result.Width = 110
        '
        'Sample_Unit
        '
        Me.Sample_Unit.HeaderText = "Sample Unit"
        Me.Sample_Unit.Name = "Sample_Unit"
        Me.Sample_Unit.ReadOnly = True
        Me.Sample_Unit.Width = 110
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.Width = 110
        '
        'Mini_Range
        '
        Me.Mini_Range.HeaderText = "Mini Range"
        Me.Mini_Range.Name = "Mini_Range"
        Me.Mini_Range.ReadOnly = True
        Me.Mini_Range.Width = 110
        '
        'Max_Range
        '
        Me.Max_Range.HeaderText = "Max Range"
        Me.Max_Range.Name = "Max_Range"
        Me.Max_Range.ReadOnly = True
        Me.Max_Range.Width = 110
        '
        'GBResult
        '
        Me.GBResult.Controls.Add(Me.txtBill_No)
        Me.GBResult.Controls.Add(Me.Label2)
        Me.GBResult.Controls.Add(Me.Label5)
        Me.GBResult.Controls.Add(Me.DGVResult)
        Me.GBResult.Controls.Add(Me.txtPatient_ID)
        Me.GBResult.Controls.Add(Me.txtAge)
        Me.GBResult.Controls.Add(Me.Label9)
        Me.GBResult.Controls.Add(Me.Label6)
        Me.GBResult.Controls.Add(Me.txtPatient_Name)
        Me.GBResult.Controls.Add(Me.txtGender)
        Me.GBResult.Controls.Add(Me.Label10)
        Me.GBResult.Controls.Add(Me.Label8)
        Me.GBResult.Controls.Add(Me.dtpResult)
        Me.GBResult.Enabled = False
        Me.GBResult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GBResult.Location = New System.Drawing.Point(17, 13)
        Me.GBResult.Name = "GBResult"
        Me.GBResult.Size = New System.Drawing.Size(1158, 503)
        Me.GBResult.TabIndex = 97
        Me.GBResult.TabStop = False
        Me.GBResult.Text = "Result Details"
        '
        'txtBill_No
        '
        Me.txtBill_No.Enabled = False
        Me.txtBill_No.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBill_No.Location = New System.Drawing.Point(253, 53)
        Me.txtBill_No.Name = "txtBill_No"
        Me.txtBill_No.Size = New System.Drawing.Size(403, 29)
        Me.txtBill_No.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Bill No :-"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(351, 538)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 47)
        Me.btnCancel.TabIndex = 98
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Result_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GBResult)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Result_1"
        Me.Size = New System.Drawing.Size(1189, 613)
        CType(Me.DGVResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBResult.ResumeLayout(False)
        Me.GBResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatient_ID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPatient_Name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpResult As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents DGVResult As DataGridView
    Friend WithEvents GBResult As GroupBox
    Friend WithEvents txtBill_No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Test_ID As DataGridViewTextBoxColumn
    Friend WithEvents Test_Name As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
    Friend WithEvents Sample_Unit As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents Mini_Range As DataGridViewTextBoxColumn
    Friend WithEvents Max_Range As DataGridViewTextBoxColumn
End Class
