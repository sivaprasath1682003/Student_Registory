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
        Me.components = New System.ComponentModel.Container
        Me.SEARCH = New System.Windows.Forms.Button
        Me.TextBoxrollno = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SivaDataSet5 = New user_password.sivaDataSet5
        Me.SivaDataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet6 = New user_password.sivaDataSet6
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_2TableAdapter = New user_password.sivaDataSet6TableAdapters.Table_2TableAdapter
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(430, 61)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(75, 23)
        Me.SEARCH.TabIndex = 0
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'TextBoxrollno
        '
        Me.TextBoxrollno.Location = New System.Drawing.Point(226, 64)
        Me.TextBoxrollno.Name = "TextBoxrollno"
        Me.TextBoxrollno.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxrollno.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.FineDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(701, 150)
        Me.DataGridView1.TabIndex = 2
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
        'SivaDataSet6
        '
        Me.SivaDataSet6.DataSetName = "sivaDataSet6"
        Me.SivaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table_2"
        Me.Table2BindingSource.DataSource = Me.SivaDataSet6
        '
        'Table_2TableAdapter
        '
        Me.Table_2TableAdapter.ClearBeforeFill = True
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "Rollno"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        '
        'FineDataGridViewTextBoxColumn
        '
        Me.FineDataGridViewTextBoxColumn.DataPropertyName = "Fine"
        Me.FineDataGridViewTextBoxColumn.HeaderText = "Fine"
        Me.FineDataGridViewTextBoxColumn.Name = "FineDataGridViewTextBoxColumn"
        '
        'studentremark_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 490)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxrollno)
        Me.Controls.Add(Me.SEARCH)
        Me.Name = "studentremark_search"
        Me.Text = "studentremark_search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
