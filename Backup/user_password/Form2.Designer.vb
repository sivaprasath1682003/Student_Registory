<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentattentance
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentattentance))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox1rollno = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ComboBox9 = New System.Windows.Forms.ComboBox
        Me.insert = New System.Windows.Forms.Button
        Me.update = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MorningprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AfternoonprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EveningprayerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RollcallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentattendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet4 = New user_password.sivaDataSet4
        Me.StudentattendanceTableAdapter = New user_password.sivaDataSet4TableAdapters.studentattendanceTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentattendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT ATTENDANCE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rollno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Morningprayer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(817, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Afternoonprayer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 314)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Eveningprayer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(843, 322)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rollcall"
        '
        'TextBox1rollno
        '
        Me.TextBox1rollno.Location = New System.Drawing.Point(269, 98)
        Me.TextBox1rollno.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1rollno.Name = "TextBox1rollno"
        Me.TextBox1rollno.Size = New System.Drawing.Size(164, 27)
        Me.TextBox1rollno.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Present", "Absent"})
        Me.ComboBox1.Location = New System.Drawing.Point(269, 249)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox1.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Present", "Absent"})
        Me.ComboBox2.Location = New System.Drawing.Point(959, 249)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Present", "Absent"})
        Me.ComboBox3.Location = New System.Drawing.Point(269, 314)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Present", "Absent"})
        Me.ComboBox4.Location = New System.Drawing.Point(959, 314)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox4.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(269, 176)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(331, 27)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(494, 252)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "MReason"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Leave", "OD", "Suspend", "Others"})
        Me.ComboBox5.Location = New System.Drawing.Point(578, 246)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox5.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 390)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Present", "Absent"})
        Me.ComboBox6.Location = New System.Drawing.Point(269, 382)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox6.TabIndex = 16
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Leave", "OD", "Suspend", "Others"})
        Me.ComboBox7.Location = New System.Drawing.Point(1289, 246)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox7.TabIndex = 17
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"Leave", "OD", "Suspend", "Others"})
        Me.ComboBox8.Location = New System.Drawing.Point(578, 322)
        Me.ComboBox8.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox8.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1185, 252)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "AReason"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(495, 322)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "EReason"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1185, 322)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "RReason"
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"Leave", "OD", "Suspend", "Others"})
        Me.ComboBox9.Location = New System.Drawing.Point(1289, 319)
        Me.ComboBox9.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(199, 27)
        Me.ComboBox9.TabIndex = 22
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(522, 377)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(78, 34)
        Me.insert.TabIndex = 23
        Me.insert.Text = "INSERT"
        Me.insert.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(621, 377)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(86, 34)
        Me.update.TabIndex = 24
        Me.update.Text = "SEARCH"
        Me.update.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(838, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.MorningprayerDataGridViewTextBoxColumn, Me.MReasonDataGridViewTextBoxColumn, Me.AfternoonprayerDataGridViewTextBoxColumn, Me.AReasonDataGridViewTextBoxColumn, Me.EveningprayerDataGridViewTextBoxColumn, Me.EReasonDataGridViewTextBoxColumn, Me.RollcallDataGridViewTextBoxColumn, Me.RReasonDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentattendanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(230, 499)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1192, 334)
        Me.DataGridView1.TabIndex = 26
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'MorningprayerDataGridViewTextBoxColumn
        '
        Me.MorningprayerDataGridViewTextBoxColumn.DataPropertyName = "Morningprayer"
        Me.MorningprayerDataGridViewTextBoxColumn.HeaderText = "Morningprayer"
        Me.MorningprayerDataGridViewTextBoxColumn.Name = "MorningprayerDataGridViewTextBoxColumn"
        '
        'MReasonDataGridViewTextBoxColumn
        '
        Me.MReasonDataGridViewTextBoxColumn.DataPropertyName = "MReason"
        Me.MReasonDataGridViewTextBoxColumn.HeaderText = "MReason"
        Me.MReasonDataGridViewTextBoxColumn.Name = "MReasonDataGridViewTextBoxColumn"
        '
        'AfternoonprayerDataGridViewTextBoxColumn
        '
        Me.AfternoonprayerDataGridViewTextBoxColumn.DataPropertyName = "Afternoonprayer"
        Me.AfternoonprayerDataGridViewTextBoxColumn.HeaderText = "Afternoonprayer"
        Me.AfternoonprayerDataGridViewTextBoxColumn.Name = "AfternoonprayerDataGridViewTextBoxColumn"
        '
        'AReasonDataGridViewTextBoxColumn
        '
        Me.AReasonDataGridViewTextBoxColumn.DataPropertyName = "AReason"
        Me.AReasonDataGridViewTextBoxColumn.HeaderText = "AReason"
        Me.AReasonDataGridViewTextBoxColumn.Name = "AReasonDataGridViewTextBoxColumn"
        '
        'EveningprayerDataGridViewTextBoxColumn
        '
        Me.EveningprayerDataGridViewTextBoxColumn.DataPropertyName = "Eveningprayer"
        Me.EveningprayerDataGridViewTextBoxColumn.HeaderText = "Eveningprayer"
        Me.EveningprayerDataGridViewTextBoxColumn.Name = "EveningprayerDataGridViewTextBoxColumn"
        '
        'EReasonDataGridViewTextBoxColumn
        '
        Me.EReasonDataGridViewTextBoxColumn.DataPropertyName = "EReason"
        Me.EReasonDataGridViewTextBoxColumn.HeaderText = "EReason"
        Me.EReasonDataGridViewTextBoxColumn.Name = "EReasonDataGridViewTextBoxColumn"
        '
        'RollcallDataGridViewTextBoxColumn
        '
        Me.RollcallDataGridViewTextBoxColumn.DataPropertyName = "Rollcall"
        Me.RollcallDataGridViewTextBoxColumn.HeaderText = "Rollcall"
        Me.RollcallDataGridViewTextBoxColumn.Name = "RollcallDataGridViewTextBoxColumn"
        '
        'RReasonDataGridViewTextBoxColumn
        '
        Me.RReasonDataGridViewTextBoxColumn.DataPropertyName = "RReason"
        Me.RReasonDataGridViewTextBoxColumn.HeaderText = "RReason"
        Me.RReasonDataGridViewTextBoxColumn.Name = "RReasonDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'StudentattendanceBindingSource
        '
        Me.StudentattendanceBindingSource.DataMember = "studentattendance"
        Me.StudentattendanceBindingSource.DataSource = Me.SivaDataSet4
        '
        'SivaDataSet4
        '
        Me.SivaDataSet4.DataSetName = "sivaDataSet4"
        Me.SivaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentattendanceTableAdapter
        '
        Me.StudentattendanceTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(729, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 34)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "DELETE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'studentattentance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1rollno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "studentattentance"
        Me.Text = "studentattendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentattendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1rollno As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents insert As System.Windows.Forms.Button
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SivaDataSet4 As user_password.sivaDataSet4
    Friend WithEvents StudentattendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentattendanceTableAdapter As user_password.sivaDataSet4TableAdapters.studentattendanceTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MorningprayerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AfternoonprayerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EveningprayerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollcallDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
