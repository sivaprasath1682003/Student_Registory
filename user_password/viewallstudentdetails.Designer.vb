<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewallstudentdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewallstudentdetails))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MothernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FathernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentmobilenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankaccountnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SportsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtracurricularactivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentcontactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.StudentdetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SivaDataSet9 = New user_password.sivaDataSet9()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StudentdetailTableAdapter = New user_password.sivaDataSet9TableAdapters.studentdetailTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(688, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn, Me.DataOfBirthDataGridViewTextBoxColumn, Me.BloodgroupDataGridViewTextBoxColumn, Me.MothernameDataGridViewTextBoxColumn, Me.FathernameDataGridViewTextBoxColumn, Me.ParentmobilenumberDataGridViewTextBoxColumn, Me.CommunityDataGridViewTextBoxColumn, Me.AadharnumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BankaccountnumberDataGridViewTextBoxColumn, Me.SportsDataGridViewTextBoxColumn, Me.EventDataGridViewTextBoxColumn, Me.ExtracurricularactivityDataGridViewTextBoxColumn, Me.StudentcontactDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.StudentdetailBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 429)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1875, 186)
        Me.DataGridView1.TabIndex = 1
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
        'MajorDataGridViewTextBoxColumn
        '
        Me.MajorDataGridViewTextBoxColumn.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MajorDataGridViewTextBoxColumn.Name = "MajorDataGridViewTextBoxColumn"
        Me.MajorDataGridViewTextBoxColumn.Width = 125
        '
        'DataOfBirthDataGridViewTextBoxColumn
        '
        Me.DataOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DataOfBirth"
        Me.DataOfBirthDataGridViewTextBoxColumn.HeaderText = "DataOfBirth"
        Me.DataOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataOfBirthDataGridViewTextBoxColumn.Name = "DataOfBirthDataGridViewTextBoxColumn"
        Me.DataOfBirthDataGridViewTextBoxColumn.Width = 125
        '
        'BloodgroupDataGridViewTextBoxColumn
        '
        Me.BloodgroupDataGridViewTextBoxColumn.DataPropertyName = "Bloodgroup"
        Me.BloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup"
        Me.BloodgroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BloodgroupDataGridViewTextBoxColumn.Name = "BloodgroupDataGridViewTextBoxColumn"
        Me.BloodgroupDataGridViewTextBoxColumn.Width = 125
        '
        'MothernameDataGridViewTextBoxColumn
        '
        Me.MothernameDataGridViewTextBoxColumn.DataPropertyName = "Mothername"
        Me.MothernameDataGridViewTextBoxColumn.HeaderText = "Mothername"
        Me.MothernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MothernameDataGridViewTextBoxColumn.Name = "MothernameDataGridViewTextBoxColumn"
        Me.MothernameDataGridViewTextBoxColumn.Width = 125
        '
        'FathernameDataGridViewTextBoxColumn
        '
        Me.FathernameDataGridViewTextBoxColumn.DataPropertyName = "Fathername"
        Me.FathernameDataGridViewTextBoxColumn.HeaderText = "Fathername"
        Me.FathernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FathernameDataGridViewTextBoxColumn.Name = "FathernameDataGridViewTextBoxColumn"
        Me.FathernameDataGridViewTextBoxColumn.Width = 125
        '
        'ParentmobilenumberDataGridViewTextBoxColumn
        '
        Me.ParentmobilenumberDataGridViewTextBoxColumn.DataPropertyName = "Parentmobilenumber"
        Me.ParentmobilenumberDataGridViewTextBoxColumn.HeaderText = "Parentmobilenumber"
        Me.ParentmobilenumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ParentmobilenumberDataGridViewTextBoxColumn.Name = "ParentmobilenumberDataGridViewTextBoxColumn"
        Me.ParentmobilenumberDataGridViewTextBoxColumn.Width = 125
        '
        'CommunityDataGridViewTextBoxColumn
        '
        Me.CommunityDataGridViewTextBoxColumn.DataPropertyName = "Community"
        Me.CommunityDataGridViewTextBoxColumn.HeaderText = "Community"
        Me.CommunityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CommunityDataGridViewTextBoxColumn.Name = "CommunityDataGridViewTextBoxColumn"
        Me.CommunityDataGridViewTextBoxColumn.Width = 125
        '
        'AadharnumberDataGridViewTextBoxColumn
        '
        Me.AadharnumberDataGridViewTextBoxColumn.DataPropertyName = "Aadharnumber"
        Me.AadharnumberDataGridViewTextBoxColumn.HeaderText = "Aadharnumber"
        Me.AadharnumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AadharnumberDataGridViewTextBoxColumn.Name = "AadharnumberDataGridViewTextBoxColumn"
        Me.AadharnumberDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'BankaccountnumberDataGridViewTextBoxColumn
        '
        Me.BankaccountnumberDataGridViewTextBoxColumn.DataPropertyName = "Bankaccountnumber"
        Me.BankaccountnumberDataGridViewTextBoxColumn.HeaderText = "Bankaccountnumber"
        Me.BankaccountnumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BankaccountnumberDataGridViewTextBoxColumn.Name = "BankaccountnumberDataGridViewTextBoxColumn"
        Me.BankaccountnumberDataGridViewTextBoxColumn.Width = 125
        '
        'SportsDataGridViewTextBoxColumn
        '
        Me.SportsDataGridViewTextBoxColumn.DataPropertyName = "Sports"
        Me.SportsDataGridViewTextBoxColumn.HeaderText = "Sports"
        Me.SportsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SportsDataGridViewTextBoxColumn.Name = "SportsDataGridViewTextBoxColumn"
        Me.SportsDataGridViewTextBoxColumn.Width = 125
        '
        'EventDataGridViewTextBoxColumn
        '
        Me.EventDataGridViewTextBoxColumn.DataPropertyName = "Event"
        Me.EventDataGridViewTextBoxColumn.HeaderText = "Event"
        Me.EventDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EventDataGridViewTextBoxColumn.Name = "EventDataGridViewTextBoxColumn"
        Me.EventDataGridViewTextBoxColumn.Width = 125
        '
        'ExtracurricularactivityDataGridViewTextBoxColumn
        '
        Me.ExtracurricularactivityDataGridViewTextBoxColumn.DataPropertyName = "Extracurricularactivity"
        Me.ExtracurricularactivityDataGridViewTextBoxColumn.HeaderText = "Extracurricularactivity"
        Me.ExtracurricularactivityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtracurricularactivityDataGridViewTextBoxColumn.Name = "ExtracurricularactivityDataGridViewTextBoxColumn"
        Me.ExtracurricularactivityDataGridViewTextBoxColumn.Width = 125
        '
        'StudentcontactDataGridViewTextBoxColumn
        '
        Me.StudentcontactDataGridViewTextBoxColumn.DataPropertyName = "studentcontact"
        Me.StudentcontactDataGridViewTextBoxColumn.HeaderText = "studentcontact"
        Me.StudentcontactDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentcontactDataGridViewTextBoxColumn.Name = "StudentcontactDataGridViewTextBoxColumn"
        Me.StudentcontactDataGridViewTextBoxColumn.Width = 125
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "photo"
        Me.PhotoDataGridViewImageColumn.MinimumWidth = 6
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.Width = 125
        '
        'StudentdetailBindingSource
        '
        Me.StudentdetailBindingSource.DataMember = "studentdetail"
        Me.StudentdetailBindingSource.DataSource = Me.SivaDataSet9
        '
        'SivaDataSet9
        '
        Me.SivaDataSet9.DataSetName = "sivaDataSet9"
        Me.SivaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 22)
        Me.TextBox1.TabIndex = 2
        '
        'StudentdetailTableAdapter
        '
        Me.StudentdetailTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ENTER STUDENT MAJOR"
        '
        'viewallstudentdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "viewallstudentdetails"
        Me.Text = "viewallstudentdetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SivaDataSet9 As sivaDataSet9
    Friend WithEvents StudentdetailBindingSource As BindingSource
    Friend WithEvents StudentdetailTableAdapter As sivaDataSet9TableAdapters.studentdetailTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodgroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MothernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FathernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParentmobilenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommunityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AadharnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankaccountnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SportsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtracurricularactivityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentcontactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
End Class
