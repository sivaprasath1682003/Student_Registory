<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewstudentleaveentry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SivaDataSet15 = New user_password.sivaDataSet15()
        Me.StudentleaveentryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentleaveentryTableAdapter = New user_password.sivaDataSet15TableAdapters.studentleaveentryTableAdapter()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavingdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturningdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberofdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewreturningdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveissuesbyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentleaveentryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter The Rollno: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 200)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.LeavingdateDataGridViewTextBoxColumn, Me.ReturningdateDataGridViewTextBoxColumn, Me.NumberofdaysDataGridViewTextBoxColumn, Me.NewreturningdateDataGridViewTextBoxColumn, Me.LeaveissuesbyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentleaveentryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(74, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1273, 141)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SivaDataSet15
        '
        Me.SivaDataSet15.DataSetName = "sivaDataSet15"
        Me.SivaDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentleaveentryBindingSource
        '
        Me.StudentleaveentryBindingSource.DataMember = "studentleaveentry"
        Me.StudentleaveentryBindingSource.DataSource = Me.SivaDataSet15
        '
        'StudentleaveentryTableAdapter
        '
        Me.StudentleaveentryTableAdapter.ClearBeforeFill = True
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'MajorDataGridViewTextBoxColumn
        '
        Me.MajorDataGridViewTextBoxColumn.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MajorDataGridViewTextBoxColumn.Name = "MajorDataGridViewTextBoxColumn"
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        '
        'LeavingdateDataGridViewTextBoxColumn
        '
        Me.LeavingdateDataGridViewTextBoxColumn.DataPropertyName = "Leavingdate"
        Me.LeavingdateDataGridViewTextBoxColumn.HeaderText = "Leavingdate"
        Me.LeavingdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeavingdateDataGridViewTextBoxColumn.Name = "LeavingdateDataGridViewTextBoxColumn"
        '
        'ReturningdateDataGridViewTextBoxColumn
        '
        Me.ReturningdateDataGridViewTextBoxColumn.DataPropertyName = "Returningdate"
        Me.ReturningdateDataGridViewTextBoxColumn.HeaderText = "Returningdate"
        Me.ReturningdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReturningdateDataGridViewTextBoxColumn.Name = "ReturningdateDataGridViewTextBoxColumn"
        '
        'NumberofdaysDataGridViewTextBoxColumn
        '
        Me.NumberofdaysDataGridViewTextBoxColumn.DataPropertyName = "numberofdays"
        Me.NumberofdaysDataGridViewTextBoxColumn.HeaderText = "numberofdays"
        Me.NumberofdaysDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumberofdaysDataGridViewTextBoxColumn.Name = "NumberofdaysDataGridViewTextBoxColumn"
        '
        'NewreturningdateDataGridViewTextBoxColumn
        '
        Me.NewreturningdateDataGridViewTextBoxColumn.DataPropertyName = "Newreturningdate"
        Me.NewreturningdateDataGridViewTextBoxColumn.HeaderText = "Newreturningdate"
        Me.NewreturningdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NewreturningdateDataGridViewTextBoxColumn.Name = "NewreturningdateDataGridViewTextBoxColumn"
        '
        'LeaveissuesbyDataGridViewTextBoxColumn
        '
        Me.LeaveissuesbyDataGridViewTextBoxColumn.DataPropertyName = "Leaveissuesby"
        Me.LeaveissuesbyDataGridViewTextBoxColumn.HeaderText = "Leaveissuesby"
        Me.LeaveissuesbyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeaveissuesbyDataGridViewTextBoxColumn.Name = "LeaveissuesbyDataGridViewTextBoxColumn"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(717, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'viewstudentleaveentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 793)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewstudentleaveentry"
        Me.Text = "viewstudentleaveentry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentleaveentryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SivaDataSet15 As sivaDataSet15
    Friend WithEvents StudentleaveentryBindingSource As BindingSource
    Friend WithEvents StudentleaveentryTableAdapter As sivaDataSet15TableAdapters.studentleaveentryTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavingdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturningdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberofdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewreturningdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveissuesbyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
