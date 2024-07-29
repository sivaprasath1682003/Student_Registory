<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewstudentattendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewstudentattendance))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MorningprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfternoonprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EveningprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollcallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuattBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet14 = New user_password.sivaDataSet14()
        Me.StuattBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet11 = New user_password.sivaDataSet11()
        Me.Stu_attTableAdapter = New user_password.sivaDataSet11TableAdapters.stu_attTableAdapter()
        Me.SivaDataSet13 = New user_password.sivaDataSet13()
        Me.StuattBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stu_attTableAdapter1 = New user_password.sivaDataSet13TableAdapters.stu_attTableAdapter()
        Me.Stu_attTableAdapter2 = New user_password.sivaDataSet14TableAdapters.stu_attTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuattBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuattBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuattBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FROM DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "END DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 183)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(288, 247)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.MorningprayerDataGridViewTextBoxColumn, Me.MReasonDataGridViewTextBoxColumn, Me.AfternoonprayerDataGridViewTextBoxColumn, Me.AReasonDataGridViewTextBoxColumn, Me.EveningprayerDataGridViewTextBoxColumn, Me.EReasonDataGridViewTextBoxColumn, Me.RollcallDataGridViewTextBoxColumn, Me.RReasonDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StuattBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 343)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1116, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'MorningprayerDataGridViewTextBoxColumn
        '
        Me.MorningprayerDataGridViewTextBoxColumn.DataPropertyName = "Morningprayer"
        Me.MorningprayerDataGridViewTextBoxColumn.HeaderText = "Morningprayer"
        Me.MorningprayerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MorningprayerDataGridViewTextBoxColumn.Name = "MorningprayerDataGridViewTextBoxColumn"
        '
        'MReasonDataGridViewTextBoxColumn
        '
        Me.MReasonDataGridViewTextBoxColumn.DataPropertyName = "MReason"
        Me.MReasonDataGridViewTextBoxColumn.HeaderText = "MReason"
        Me.MReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MReasonDataGridViewTextBoxColumn.Name = "MReasonDataGridViewTextBoxColumn"
        '
        'AfternoonprayerDataGridViewTextBoxColumn
        '
        Me.AfternoonprayerDataGridViewTextBoxColumn.DataPropertyName = "Afternoonprayer"
        Me.AfternoonprayerDataGridViewTextBoxColumn.HeaderText = "Afternoonprayer"
        Me.AfternoonprayerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AfternoonprayerDataGridViewTextBoxColumn.Name = "AfternoonprayerDataGridViewTextBoxColumn"
        '
        'AReasonDataGridViewTextBoxColumn
        '
        Me.AReasonDataGridViewTextBoxColumn.DataPropertyName = "AReason"
        Me.AReasonDataGridViewTextBoxColumn.HeaderText = "AReason"
        Me.AReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AReasonDataGridViewTextBoxColumn.Name = "AReasonDataGridViewTextBoxColumn"
        '
        'EveningprayerDataGridViewTextBoxColumn
        '
        Me.EveningprayerDataGridViewTextBoxColumn.DataPropertyName = "Eveningprayer"
        Me.EveningprayerDataGridViewTextBoxColumn.HeaderText = "Eveningprayer"
        Me.EveningprayerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EveningprayerDataGridViewTextBoxColumn.Name = "EveningprayerDataGridViewTextBoxColumn"
        '
        'EReasonDataGridViewTextBoxColumn
        '
        Me.EReasonDataGridViewTextBoxColumn.DataPropertyName = "EReason"
        Me.EReasonDataGridViewTextBoxColumn.HeaderText = "EReason"
        Me.EReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EReasonDataGridViewTextBoxColumn.Name = "EReasonDataGridViewTextBoxColumn"
        '
        'RollcallDataGridViewTextBoxColumn
        '
        Me.RollcallDataGridViewTextBoxColumn.DataPropertyName = "Rollcall"
        Me.RollcallDataGridViewTextBoxColumn.HeaderText = "Rollcall"
        Me.RollcallDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RollcallDataGridViewTextBoxColumn.Name = "RollcallDataGridViewTextBoxColumn"
        '
        'RReasonDataGridViewTextBoxColumn
        '
        Me.RReasonDataGridViewTextBoxColumn.DataPropertyName = "RReason"
        Me.RReasonDataGridViewTextBoxColumn.HeaderText = "RReason"
        Me.RReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RReasonDataGridViewTextBoxColumn.Name = "RReasonDataGridViewTextBoxColumn"
        '
        'StuattBindingSource2
        '
        Me.StuattBindingSource2.DataMember = "stu_att"
        Me.StuattBindingSource2.DataSource = Me.SivaDataSet14
        '
        'SivaDataSet14
        '
        Me.SivaDataSet14.DataSetName = "sivaDataSet14"
        Me.SivaDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StuattBindingSource
        '
        Me.StuattBindingSource.DataMember = "stu_att"
        Me.StuattBindingSource.DataSource = Me.SivaDataSet11
        '
        'SivaDataSet11
        '
        Me.SivaDataSet11.DataSetName = "sivaDataSet11"
        Me.SivaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Stu_attTableAdapter
        '
        Me.Stu_attTableAdapter.ClearBeforeFill = True
        '
        'SivaDataSet13
        '
        Me.SivaDataSet13.DataSetName = "sivaDataSet13"
        Me.SivaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StuattBindingSource1
        '
        Me.StuattBindingSource1.DataMember = "stu_att"
        Me.StuattBindingSource1.DataSource = Me.SivaDataSet13
        '
        'Stu_attTableAdapter1
        '
        Me.Stu_attTableAdapter1.ClearBeforeFill = True
        '
        'Stu_attTableAdapter2
        '
        Me.Stu_attTableAdapter2.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(774, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter The Rollno: "
        '
        'viewstudentattendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "viewstudentattendance"
        Me.Text = "viewstudentattendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuattBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuattBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuattBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SivaDataSet11 As sivaDataSet11
    Friend WithEvents StuattBindingSource As BindingSource
    Friend WithEvents Stu_attTableAdapter As sivaDataSet11TableAdapters.stu_attTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MorningprayerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AfternoonprayerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EveningprayerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollcallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SivaDataSet13 As sivaDataSet13
    Friend WithEvents StuattBindingSource1 As BindingSource
    Friend WithEvents Stu_attTableAdapter1 As sivaDataSet13TableAdapters.stu_attTableAdapter
    Friend WithEvents SivaDataSet14 As sivaDataSet14
    Friend WithEvents StuattBindingSource2 As BindingSource
    Friend WithEvents Stu_attTableAdapter2 As sivaDataSet14TableAdapters.stu_attTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
