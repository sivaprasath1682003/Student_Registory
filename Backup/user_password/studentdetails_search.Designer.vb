<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentdetails_search
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
        Me.SivaDataSet1 = New user_password.sivaDataSet1
        Me.SivaDataSet = New user_password.sivaDataSet
        Me.StudentdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEARCH = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.UPDATE = New System.Windows.Forms.Button
        Me.TextBoxaddress = New System.Windows.Forms.TextBox
        Me.ComboBoxstudentcontact = New System.Windows.Forms.ComboBox
        Me.ComboBoxextra = New System.Windows.Forms.ComboBox
        Me.ComboBoxevent = New System.Windows.Forms.ComboBox
        Me.StudentdetailsTableAdapter = New user_password.sivaDataSet1TableAdapters.studentdetailsTableAdapter
        Me.ComboBoxsports = New System.Windows.Forms.ComboBox
        Me.TextBoxbankaccount = New System.Windows.Forms.TextBox
        Me.ComboBoxcommunity = New System.Windows.Forms.ComboBox
        Me.ComboBoxbloodgroup = New System.Windows.Forms.ComboBox
        Me.ComboBoxMajor = New System.Windows.Forms.ComboBox
        Me.TextBoxaadhar = New System.Windows.Forms.TextBox
        Me.TextBoxmobilenumber = New System.Windows.Forms.TextBox
        Me.TextBoxmothername = New System.Windows.Forms.TextBox
        Me.TextBoxfathername = New System.Windows.Forms.TextBox
        Me.TextBoxname = New System.Windows.Forms.TextBox
        Me.TextBoxRollno = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.Label3name = New System.Windows.Forms.Label
        Me.Label2rollno = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxdate = New System.Windows.Forms.TextBox
        CType(Me.SivaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SivaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SivaDataSet1
        '
        Me.SivaDataSet1.DataSetName = "sivaDataSet1"
        Me.SivaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SivaDataSet
        '
        Me.SivaDataSet.DataSetName = "sivaDataSet"
        Me.SivaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentdetailsBindingSource
        '
        Me.StudentdetailsBindingSource.DataMember = "studentdetails"
        Me.StudentdetailsBindingSource.DataSource = Me.SivaDataSet1
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(1294, 101)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(92, 29)
        Me.SEARCH.TabIndex = 81
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1294, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(1294, 152)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(108, 35)
        Me.UPDATE.TabIndex = 77
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'TextBoxaddress
        '
        Me.TextBoxaddress.Location = New System.Drawing.Point(593, 292)
        Me.TextBoxaddress.Multiline = True
        Me.TextBoxaddress.Name = "TextBoxaddress"
        Me.TextBoxaddress.Size = New System.Drawing.Size(196, 60)
        Me.TextBoxaddress.TabIndex = 75
        '
        'ComboBoxstudentcontact
        '
        Me.ComboBoxstudentcontact.FormattingEnabled = True
        Me.ComboBoxstudentcontact.Items.AddRange(New Object() {"GOOD", "SASTIFACTORY", "BAD", "VERY GOOD"})
        Me.ComboBoxstudentcontact.Location = New System.Drawing.Point(1405, 19)
        Me.ComboBoxstudentcontact.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxstudentcontact.Name = "ComboBoxstudentcontact"
        Me.ComboBoxstudentcontact.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxstudentcontact.TabIndex = 74
        '
        'ComboBoxextra
        '
        Me.ComboBoxextra.FormattingEnabled = True
        Me.ComboBoxextra.Items.AddRange(New Object() {"FINE ARTS CLUB", "NCC", "NSS", "YRC", "VAP"})
        Me.ComboBoxextra.Location = New System.Drawing.Point(1023, 308)
        Me.ComboBoxextra.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxextra.Name = "ComboBoxextra"
        Me.ComboBoxextra.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxextra.TabIndex = 73
        '
        'ComboBoxevent
        '
        Me.ComboBoxevent.FormattingEnabled = True
        Me.ComboBoxevent.Items.AddRange(New Object() {"GYMNATICS", "KARATHA", "SILLAMBAM", "YOGA", "NO EVENT"})
        Me.ComboBoxevent.Location = New System.Drawing.Point(1023, 226)
        Me.ComboBoxevent.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxevent.Name = "ComboBoxevent"
        Me.ComboBoxevent.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxevent.TabIndex = 72
        '
        'StudentdetailsTableAdapter
        '
        Me.StudentdetailsTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxsports
        '
        Me.ComboBoxsports.FormattingEnabled = True
        Me.ComboBoxsports.Items.AddRange(New Object() {"ATHELATICS", "BALL BADMITON", "BASKET BALL", "CRICKET", "CAROM BOARD", "CHESS", "FOOT BALL", "HOCKEY", "HAND BALL", "KABBADI", "KHO-KHO", "VOLLEY BALL", "NO SPORTS", ""})
        Me.ComboBoxsports.Location = New System.Drawing.Point(1023, 90)
        Me.ComboBoxsports.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxsports.Name = "ComboBoxsports"
        Me.ComboBoxsports.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxsports.TabIndex = 71
        '
        'TextBoxbankaccount
        '
        Me.TextBoxbankaccount.Location = New System.Drawing.Point(1023, 165)
        Me.TextBoxbankaccount.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxbankaccount.Name = "TextBoxbankaccount"
        Me.TextBoxbankaccount.Size = New System.Drawing.Size(196, 20)
        Me.TextBoxbankaccount.TabIndex = 70
        '
        'ComboBoxcommunity
        '
        Me.ComboBoxcommunity.AutoCompleteCustomSource.AddRange(New String() {"DNC", "BC", "OBC", "SC", "ST", "MBC"})
        Me.ComboBoxcommunity.FormattingEnabled = True
        Me.ComboBoxcommunity.Items.AddRange(New Object() {"BC", "MBC", "DNC", "OBC", "SC", "ST", "GENERAL"})
        Me.ComboBoxcommunity.Location = New System.Drawing.Point(593, 234)
        Me.ComboBoxcommunity.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxcommunity.Name = "ComboBoxcommunity"
        Me.ComboBoxcommunity.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxcommunity.TabIndex = 69
        '
        'ComboBoxbloodgroup
        '
        Me.ComboBoxbloodgroup.FormattingEnabled = True
        Me.ComboBoxbloodgroup.Items.AddRange(New Object() {"B+ve", "B-ve", "O+ve", "O-ve", "A+ve", "A-ve", "AB+ve", "AB-ve", ""})
        Me.ComboBoxbloodgroup.Location = New System.Drawing.Point(137, 325)
        Me.ComboBoxbloodgroup.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxbloodgroup.Name = "ComboBoxbloodgroup"
        Me.ComboBoxbloodgroup.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxbloodgroup.TabIndex = 67
        '
        'ComboBoxMajor
        '
        Me.ComboBoxMajor.AutoCompleteCustomSource.AddRange(New String() {"B.A  ECONOMICS", "B.A  HISTORY", "B.A TAMIL", "B.A ENGLISH", "B.COM", "B.SC  CHEMISTRY", "B.SC  PHYSICS", "B.SC  MATHS", "B.SC  ZOOLOGY", "B.SC BOTANY", "B.SC  COMPUTER SCIENCE", "B.COM(CA)"})
        Me.ComboBoxMajor.FormattingEnabled = True
        Me.ComboBoxMajor.Items.AddRange(New Object() {"BA  ECONOMICS", "BA  HISTORY", "BA  TAMIL", "BA  ENGLISH", "B.COM", "B.Sc MATHEMATICS", "B.Sc CHEMISTRY", "B.Sc PHYSICS", "B.Sc BOTANY", "B.Sc ZOOLOGY", "B.Sc COMPUTER SCIENCE", "B.COM (CA)"})
        Me.ComboBoxMajor.Location = New System.Drawing.Point(137, 152)
        Me.ComboBoxMajor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ComboBoxMajor.Name = "ComboBoxMajor"
        Me.ComboBoxMajor.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxMajor.TabIndex = 66
        '
        'TextBoxaadhar
        '
        Me.TextBoxaadhar.Location = New System.Drawing.Point(1023, 19)
        Me.TextBoxaadhar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxaadhar.Name = "TextBoxaadhar"
        Me.TextBoxaadhar.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxaadhar.TabIndex = 65
        '
        'TextBoxmobilenumber
        '
        Me.TextBoxmobilenumber.Location = New System.Drawing.Point(597, 157)
        Me.TextBoxmobilenumber.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxmobilenumber.Name = "TextBoxmobilenumber"
        Me.TextBoxmobilenumber.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxmobilenumber.TabIndex = 64
        '
        'TextBoxmothername
        '
        Me.TextBoxmothername.Location = New System.Drawing.Point(593, 16)
        Me.TextBoxmothername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxmothername.Name = "TextBoxmothername"
        Me.TextBoxmothername.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxmothername.TabIndex = 63
        '
        'TextBoxfathername
        '
        Me.TextBoxfathername.Location = New System.Drawing.Point(593, 93)
        Me.TextBoxfathername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxfathername.Name = "TextBoxfathername"
        Me.TextBoxfathername.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxfathername.TabIndex = 62
        '
        'TextBoxname
        '
        Me.TextBoxname.Location = New System.Drawing.Point(137, 85)
        Me.TextBoxname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxname.Name = "TextBoxname"
        Me.TextBoxname.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxname.TabIndex = 61
        '
        'TextBoxRollno
        '
        Me.TextBoxRollno.Location = New System.Drawing.Point(137, 19)
        Me.TextBoxRollno.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxRollno.Name = "TextBoxRollno"
        Me.TextBoxRollno.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxRollno.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1247, 27)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Student Contact :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(797, 316)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Extra-Curricular Activity :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(946, 237)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Event :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(942, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "sports :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(823, 168)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Bank Account Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(489, 311)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(871, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Aadhar Number :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(464, 237)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Community :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Parent Mobile Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Mother Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Father Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 328)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Blood Group :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Data Of Birth :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(61, 157)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 46
        Me.label2.Text = "Major :"
        '
        'Label3name
        '
        Me.Label3name.AutoSize = True
        Me.Label3name.Location = New System.Drawing.Point(65, 85)
        Me.Label3name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3name.Name = "Label3name"
        Me.Label3name.Size = New System.Drawing.Size(41, 13)
        Me.Label3name.TabIndex = 45
        Me.Label3name.Text = "Name :"
        '
        'Label2rollno
        '
        Me.Label2rollno.AutoSize = True
        Me.Label2rollno.Location = New System.Drawing.Point(60, 27)
        Me.Label2rollno.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2rollno.Name = "Label2rollno"
        Me.Label2rollno.Size = New System.Drawing.Size(43, 13)
        Me.Label2rollno.TabIndex = 44
        Me.Label2rollno.Text = "Rollno :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(670, -50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "STUDENT DETAILS"
        '
        'TextBoxdate
        '
        Me.TextBoxdate.Location = New System.Drawing.Point(137, 237)
        Me.TextBoxdate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBoxdate.Name = "TextBoxdate"
        Me.TextBoxdate.Size = New System.Drawing.Size(199, 20)
        Me.TextBoxdate.TabIndex = 82
        '
        'studentdetails_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1540, 535)
        Me.Controls.Add(Me.TextBoxdate)
        Me.Controls.Add(Me.SEARCH)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.TextBoxaddress)
        Me.Controls.Add(Me.ComboBoxstudentcontact)
        Me.Controls.Add(Me.ComboBoxextra)
        Me.Controls.Add(Me.ComboBoxevent)
        Me.Controls.Add(Me.ComboBoxsports)
        Me.Controls.Add(Me.TextBoxbankaccount)
        Me.Controls.Add(Me.ComboBoxcommunity)
        Me.Controls.Add(Me.ComboBoxbloodgroup)
        Me.Controls.Add(Me.ComboBoxMajor)
        Me.Controls.Add(Me.TextBoxaadhar)
        Me.Controls.Add(Me.TextBoxmobilenumber)
        Me.Controls.Add(Me.TextBoxmothername)
        Me.Controls.Add(Me.TextBoxfathername)
        Me.Controls.Add(Me.TextBoxname)
        Me.Controls.Add(Me.TextBoxRollno)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label3name)
        Me.Controls.Add(Me.Label2rollno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "studentdetails_search"
        Me.Text = "studentdetails_search"
        CType(Me.SivaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SivaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SivaDataSet1 As user_password.sivaDataSet1
    Friend WithEvents SivaDataSet As user_password.sivaDataSet
    Friend WithEvents StudentdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEARCH As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents UPDATE As System.Windows.Forms.Button
    Friend WithEvents TextBoxaddress As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxstudentcontact As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxextra As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxevent As System.Windows.Forms.ComboBox
    Friend WithEvents StudentdetailsTableAdapter As user_password.sivaDataSet1TableAdapters.studentdetailsTableAdapter
    Friend WithEvents ComboBoxsports As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxbankaccount As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxcommunity As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxbloodgroup As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMajor As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxaadhar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxmobilenumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxmothername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxfathername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRollno As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Label3name As System.Windows.Forms.Label
    Friend WithEvents Label2rollno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxdate As System.Windows.Forms.TextBox
End Class
