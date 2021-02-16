<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bills
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatient_ID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTprice = New System.Windows.Forms.TextBox()
        Me.DGVBills = New System.Windows.Forms.DataGridView()
        Me.Test_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mini_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtPatient_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBill_No = New System.Windows.Forms.TextBox()
        Me.btnAddTest = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GBBills = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBBills.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1189, 613)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(17, 529)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(1157, 63)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(761, 538)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 47)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(553, 538)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(174, 47)
        Me.btnSearch.TabIndex = 65
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Patient ID :-"
        '
        'txtPatient_ID
        '
        Me.txtPatient_ID.Enabled = False
        Me.txtPatient_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient_ID.Location = New System.Drawing.Point(203, 130)
        Me.txtPatient_ID.Name = "txtPatient_ID"
        Me.txtPatient_ID.Size = New System.Drawing.Size(360, 29)
        Me.txtPatient_ID.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 21)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Total Price :-"
        '
        'txtTprice
        '
        Me.txtTprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTprice.Location = New System.Drawing.Point(203, 245)
        Me.txtTprice.Name = "txtTprice"
        Me.txtTprice.Size = New System.Drawing.Size(227, 29)
        Me.txtTprice.TabIndex = 77
        '
        'DGVBills
        '
        Me.DGVBills.AllowUserToAddRows = False
        Me.DGVBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Test_ID, Me.Test_Name, Me.Price, Me.Mini_value, Me.Max_value, Me.Delete})
        Me.DGVBills.Location = New System.Drawing.Point(600, 75)
        Me.DGVBills.Name = "DGVBills"
        Me.DGVBills.ReadOnly = True
        Me.DGVBills.Size = New System.Drawing.Size(540, 316)
        Me.DGVBills.TabIndex = 80
        '
        'Test_ID
        '
        Me.Test_ID.Frozen = True
        Me.Test_ID.HeaderText = "Test ID"
        Me.Test_ID.Name = "Test_ID"
        Me.Test_ID.ReadOnly = True
        '
        'Test_Name
        '
        Me.Test_Name.HeaderText = "Test Name"
        Me.Test_Name.Name = "Test_Name"
        Me.Test_Name.ReadOnly = True
        Me.Test_Name.Width = 200
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Mini_value
        '
        Me.Mini_value.HeaderText = "Mini value"
        Me.Mini_value.Name = "Mini_value"
        Me.Mini_value.ReadOnly = True
        Me.Mini_value.Visible = False
        '
        'Max_value
        '
        Me.Max_value.HeaderText = "Max value"
        Me.Max_value.Name = "Max_value"
        Me.Max_value.ReadOnly = True
        Me.Max_value.Visible = False
        '
        'Delete
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle2
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'txtPatient_Name
        '
        Me.txtPatient_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient_Name.Location = New System.Drawing.Point(203, 186)
        Me.txtPatient_Name.Name = "txtPatient_Name"
        Me.txtPatient_Name.Size = New System.Drawing.Size(360, 29)
        Me.txtPatient_Name.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 21)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Patient Name :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Date :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Bill No :-"
        '
        'txtBill_No
        '
        Me.txtBill_No.Enabled = False
        Me.txtBill_No.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBill_No.Location = New System.Drawing.Point(203, 75)
        Me.txtBill_No.Name = "txtBill_No"
        Me.txtBill_No.Size = New System.Drawing.Size(360, 29)
        Me.txtBill_No.TabIndex = 90
        '
        'btnAddTest
        '
        Me.btnAddTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnAddTest.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTest.ForeColor = System.Drawing.Color.White
        Me.btnAddTest.Location = New System.Drawing.Point(666, 426)
        Me.btnAddTest.Name = "btnAddTest"
        Me.btnAddTest.Size = New System.Drawing.Size(174, 47)
        Me.btnAddTest.TabIndex = 91
        Me.btnAddTest.Text = "Add Test"
        Me.btnAddTest.UseVisualStyleBackColor = False
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnAddPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.White
        Me.btnAddPatient.Location = New System.Drawing.Point(875, 426)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(174, 47)
        Me.btnAddPatient.TabIndex = 92
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(961, 538)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(174, 47)
        Me.btnAdd.TabIndex = 93
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(351, 538)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(174, 47)
        Me.btnDelete.TabIndex = 94
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(155, 538)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 47)
        Me.btnCancel.TabIndex = 95
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GBBills
        '
        Me.GBBills.Controls.Add(Me.dtpDate)
        Me.GBBills.Controls.Add(Me.Label6)
        Me.GBBills.Controls.Add(Me.Label5)
        Me.GBBills.Controls.Add(Me.txtPatient_ID)
        Me.GBBills.Controls.Add(Me.txtTprice)
        Me.GBBills.Controls.Add(Me.btnAddPatient)
        Me.GBBills.Controls.Add(Me.DGVBills)
        Me.GBBills.Controls.Add(Me.btnAddTest)
        Me.GBBills.Controls.Add(Me.txtPatient_Name)
        Me.GBBills.Controls.Add(Me.txtBill_No)
        Me.GBBills.Controls.Add(Me.Label9)
        Me.GBBills.Controls.Add(Me.Label2)
        Me.GBBills.Controls.Add(Me.Label1)
        Me.GBBills.Enabled = False
        Me.GBBills.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GBBills.Location = New System.Drawing.Point(17, 18)
        Me.GBBills.Name = "GBBills"
        Me.GBBills.Size = New System.Drawing.Size(1158, 503)
        Me.GBBills.TabIndex = 96
        Me.GBBills.TabStop = False
        Me.GBBills.Text = "Bills Details"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(203, 310)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 29)
        Me.dtpDate.TabIndex = 93
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GBBills)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Bills"
        Me.Size = New System.Drawing.Size(1189, 613)
        CType(Me.DGVBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBBills.ResumeLayout(False)
        Me.GBBills.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatient_ID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTprice As TextBox
    Friend WithEvents DGVBills As DataGridView
    Friend WithEvents txtPatient_Name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBill_No As TextBox
    Friend WithEvents btnAddTest As Button
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GBBills As GroupBox
    Friend WithEvents Test_ID As DataGridViewTextBoxColumn
    Friend WithEvents Test_Name As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Mini_value As DataGridViewTextBoxColumn
    Friend WithEvents Max_value As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents dtpDate As DateTimePicker
End Class
