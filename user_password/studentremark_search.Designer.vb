<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentremark_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentremark_search))
        Me.SEARCH = New System.Windows.Forms.Button()
        Me.TextBoxrollno = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet6 = New user_password.sivaDataSet6()
        Me.SivaDataSet5 = New user_password.sivaDataSet5()
        Me.SivaDataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_2TableAdapter = New user_password.sivaDataSet6TableAdapters.Table_2TableAdapter()
        Me.SivaDataSet8 = New user_password.sivaDataSet8()
        Me.StudentremarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentremarkTableAdapter = New user_password.sivaDataSet8TableAdapters.studentremarkTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SivaDataSet12 = New user_password.sivaDataSet12()
        Me.SturemarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stu_remarksTableAdapter = New user_password.sivaDataSet12TableAdapters.stu_remarksTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentremarkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturemarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(573, 75)
        Me.SEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(100, 28)
        Me.SEARCH.TabIndex = 0
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'TextBoxrollno
        '
        Me.TextBoxrollno.Location = New System.Drawing.Point(301, 79)
        Me.TextBoxrollno.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxrollno.Name = "TextBoxrollno"
        Me.TextBoxrollno.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxrollno.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.FineDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SturemarksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 174)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(801, 185)
        Me.DataGridView1.TabIndex = 2
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        Me.RollnoDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 125
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.Width = 125
        '
        'FineDataGridViewTextBoxColumn
        '
        Me.FineDataGridViewTextBoxColumn.DataPropertyName = "Fine"
        Me.FineDataGridViewTextBoxColumn.HeaderText = "Fine"
        Me.FineDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FineDataGridViewTextBoxColumn.Name = "FineDataGridViewTextBoxColumn"
        Me.FineDataGridViewTextBoxColumn.Width = 125
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table_2"
        Me.Table2BindingSource.DataSource = Me.SivaDataSet6
        '
        'SivaDataSet6
        '
        Me.SivaDataSet6.DataSetName = "sivaDataSet6"
        Me.SivaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SivaDataSet5
        '
        Me.SivaDataSet5.DataSetName = "sivaDataSet5"
        Me.SivaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SivaDataSet5BindingSource
        '
        Me.SivaDataSet5BindingSource.DataSource = Me.SivaDataSet5
        Me.SivaDataSet5BindingSource.Position = 0
        '
        'Table_2TableAdapter
        '
        Me.Table_2TableAdapter.ClearBeforeFill = True
        '
        'SivaDataSet8
        '
        Me.SivaDataSet8.DataSetName = "sivaDataSet8"
        Me.SivaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentremarkBindingSource
        '
        Me.StudentremarkBindingSource.DataMember = "studentremark"
        Me.StudentremarkBindingSource.DataSource = Me.SivaDataSet8
        '
        'StudentremarkTableAdapter
        '
        Me.StudentremarkTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(779, 75)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 28)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SivaDataSet12
        '
        Me.SivaDataSet12.DataSetName = "sivaDataSet12"
        Me.SivaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SturemarksBindingSource
        '
        Me.SturemarksBindingSource.DataMember = "stu_remarks"
        Me.SturemarksBindingSource.DataSource = Me.SivaDataSet12
        '
        'Stu_remarksTableAdapter
        '
        Me.Stu_remarksTableAdapter.ClearBeforeFill = True
        '
        'studentremark_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxrollno)
        Me.Controls.Add(Me.SEARCH)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "studentremark_search"
        Me.Text = "studentremark_search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentremarkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturemarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SEARCH As System.Windows.Forms.Button
    Friend WithEvents TextBoxrollno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SivaDataSet5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SivaDataSet5 As user_password.sivaDataSet5
    Friend WithEvents SivaDataSet6 As user_password.sivaDataSet6
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_2TableAdapter As user_password.sivaDataSet6TableAdapters.Table_2TableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SivaDataSet8 As sivaDataSet8
    Friend WithEvents StudentremarkBindingSource As BindingSource
    Friend WithEvents StudentremarkTableAdapter As sivaDataSet8TableAdapters.studentremarkTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents SivaDataSet12 As sivaDataSet12
    Friend WithEvents SturemarksBindingSource As BindingSource
    Friend WithEvents Stu_remarksTableAdapter As sivaDataSet12TableAdapters.stu_remarksTableAdapter
End Class
