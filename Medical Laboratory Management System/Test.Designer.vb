<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTestName = New System.Windows.Forms.TextBox()
        Me.txtTestID = New System.Windows.Forms.TextBox()
        Me.cmbSampleUnit = New System.Windows.Forms.ComboBox()
        Me.CmbSampleType = New System.Windows.Forms.ComboBox()
        Me.CmbTestType = New System.Windows.Forms.ComboBox()
        Me.btnSava = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.GBTest = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMini = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GBTest.SuspendLayout()
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Test Name :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Test Type :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Sample Type :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Sample Unit :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Test ID :-"
        '
        'txtTestName
        '
        Me.txtTestName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestName.Location = New System.Drawing.Point(236, 153)
        Me.txtTestName.Name = "txtTestName"
        Me.txtTestName.Size = New System.Drawing.Size(287, 29)
        Me.txtTestName.TabIndex = 84
        '
        'txtTestID
        '
        Me.txtTestID.Enabled = False
        Me.txtTestID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestID.Location = New System.Drawing.Point(236, 100)
        Me.txtTestID.Name = "txtTestID"
        Me.txtTestID.Size = New System.Drawing.Size(287, 29)
        Me.txtTestID.TabIndex = 85
        '
        'cmbSampleUnit
        '
        Me.cmbSampleUnit.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSampleUnit.FormattingEnabled = True
        Me.cmbSampleUnit.Items.AddRange(New Object() {"-", "%", "fL", "g\dl", "L", "mg/dl", "mL", "uIU/mL", "uL"})
        Me.cmbSampleUnit.Location = New System.Drawing.Point(706, 95)
        Me.cmbSampleUnit.Name = "cmbSampleUnit"
        Me.cmbSampleUnit.Size = New System.Drawing.Size(295, 29)
        Me.cmbSampleUnit.TabIndex = 86
        '
        'CmbSampleType
        '
        Me.CmbSampleType.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSampleType.FormattingEnabled = True
        Me.CmbSampleType.Items.AddRange(New Object() {"Blood", "Serum", "Urian", "Stool"})
        Me.CmbSampleType.Location = New System.Drawing.Point(236, 258)
        Me.CmbSampleType.Name = "CmbSampleType"
        Me.CmbSampleType.Size = New System.Drawing.Size(287, 29)
        Me.CmbSampleType.TabIndex = 87
        '
        'CmbTestType
        '
        Me.CmbTestType.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTestType.FormattingEnabled = True
        Me.CmbTestType.Items.AddRange(New Object() {"URINE", "STOOOL", "HEMATOLOGY", "SEROLOGY", "BIOCHEMSTRY", "HORMONE", "TUMOR MARKERS", "DRUGS", "MICROBIOLOGY", "BODY FLUIDS", "BLOOD BANK"})
        Me.CmbTestType.Location = New System.Drawing.Point(236, 204)
        Me.CmbTestType.Name = "CmbTestType"
        Me.CmbTestType.Size = New System.Drawing.Size(287, 29)
        Me.CmbTestType.TabIndex = 88
        '
        'btnSava
        '
        Me.btnSava.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSava.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSava.ForeColor = System.Drawing.Color.White
        Me.btnSava.Location = New System.Drawing.Point(761, 538)
        Me.btnSava.Name = "btnSava"
        Me.btnSava.Size = New System.Drawing.Size(174, 47)
        Me.btnSava.TabIndex = 89
        Me.btnSava.Text = "Save"
        Me.btnSava.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(553, 538)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(174, 47)
        Me.btnSearch.TabIndex = 90
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(628, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Price :-"
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
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(706, 259)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(295, 29)
        Me.txtPrice.TabIndex = 104
        '
        'GBTest
        '
        Me.GBTest.Controls.Add(Me.Label4)
        Me.GBTest.Controls.Add(Me.Label3)
        Me.GBTest.Controls.Add(Me.txtMini)
        Me.GBTest.Controls.Add(Me.txtMax)
        Me.GBTest.Controls.Add(Me.Label5)
        Me.GBTest.Controls.Add(Me.Label8)
        Me.GBTest.Controls.Add(Me.Label7)
        Me.GBTest.Controls.Add(Me.txtPrice)
        Me.GBTest.Controls.Add(Me.Label1)
        Me.GBTest.Controls.Add(Me.Label2)
        Me.GBTest.Controls.Add(Me.txtTestName)
        Me.GBTest.Controls.Add(Me.Label6)
        Me.GBTest.Controls.Add(Me.txtTestID)
        Me.GBTest.Controls.Add(Me.cmbSampleUnit)
        Me.GBTest.Controls.Add(Me.CmbSampleType)
        Me.GBTest.Controls.Add(Me.CmbTestType)
        Me.GBTest.Enabled = False
        Me.GBTest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTest.Location = New System.Drawing.Point(16, 19)
        Me.GBTest.Name = "GBTest"
        Me.GBTest.Size = New System.Drawing.Size(1156, 500)
        Me.GBTest.TabIndex = 115
        Me.GBTest.TabStop = False
        Me.GBTest.Text = "Test Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(583, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Max Range :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Mini Range :-"
        '
        'txtMini
        '
        Me.txtMini.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMini.Location = New System.Drawing.Point(706, 153)
        Me.txtMini.Name = "txtMini"
        Me.txtMini.Size = New System.Drawing.Size(295, 29)
        Me.txtMini.TabIndex = 107
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(706, 207)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(295, 29)
        Me.txtMax.TabIndex = 106
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(961, 538)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(174, 47)
        Me.btnAdd.TabIndex = 107
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(155, 538)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 47)
        Me.btnCancel.TabIndex = 116
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GBTest)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSava)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Test"
        Me.Size = New System.Drawing.Size(1189, 613)
        Me.GBTest.ResumeLayout(False)
        Me.GBTest.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTestName As TextBox
    Friend WithEvents txtTestID As TextBox
    Friend WithEvents cmbSampleUnit As ComboBox
    Friend WithEvents CmbSampleType As ComboBox
    Friend WithEvents CmbTestType As ComboBox
    Friend WithEvents btnSava As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents GBTest As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Test_ID As DataGridViewTextBoxColumn
    Friend WithEvents Test_Name As DataGridViewTextBoxColumn
    Friend WithEvents Test_Type As DataGridViewTextBoxColumn
    Friend WithEvents Sample As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Normal_value As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMini As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
