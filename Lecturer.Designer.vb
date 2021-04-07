<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lecturer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OsccdbDataSet = New OSCC.osccdbDataSet()
        Me.LecturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturerTableAdapter = New OSCC.osccdbDataSetTableAdapters.lecturerTableAdapter()
        Me.LectureridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerphonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LectureremailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Post"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(257, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Lecturer Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Lecturer Email Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter Lecturer Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Enter Lecturer Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(257, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(257, 272)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(201, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(257, 168)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(201, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1230, 100)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(634, 69)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "LECTURER DETAILS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LectureridDataGridViewTextBoxColumn, Me.LecturernameDataGridViewTextBoxColumn, Me.LecturerphonenoDataGridViewTextBoxColumn, Me.LectureremailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LecturerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(476, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(735, 174)
        Me.DataGridView1.TabIndex = 1
        '
        'OsccdbDataSet
        '
        Me.OsccdbDataSet.DataSetName = "osccdbDataSet"
        Me.OsccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturerBindingSource
        '
        Me.LecturerBindingSource.DataMember = "lecturer"
        Me.LecturerBindingSource.DataSource = Me.OsccdbDataSet
        '
        'LecturerTableAdapter
        '
        Me.LecturerTableAdapter.ClearBeforeFill = True
        '
        'LectureridDataGridViewTextBoxColumn
        '
        Me.LectureridDataGridViewTextBoxColumn.DataPropertyName = "lecturer_id"
        Me.LectureridDataGridViewTextBoxColumn.HeaderText = "lecturer_id"
        Me.LectureridDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LectureridDataGridViewTextBoxColumn.Name = "LectureridDataGridViewTextBoxColumn"
        Me.LectureridDataGridViewTextBoxColumn.ReadOnly = True
        Me.LectureridDataGridViewTextBoxColumn.Width = 125
        '
        'LecturernameDataGridViewTextBoxColumn
        '
        Me.LecturernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LecturernameDataGridViewTextBoxColumn.DataPropertyName = "lecturer_name"
        Me.LecturernameDataGridViewTextBoxColumn.HeaderText = "lecturer_name"
        Me.LecturernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LecturernameDataGridViewTextBoxColumn.Name = "LecturernameDataGridViewTextBoxColumn"
        Me.LecturernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LecturerphonenoDataGridViewTextBoxColumn
        '
        Me.LecturerphonenoDataGridViewTextBoxColumn.DataPropertyName = "lecturer_phone_no"
        Me.LecturerphonenoDataGridViewTextBoxColumn.HeaderText = "lecturer_phone_no"
        Me.LecturerphonenoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LecturerphonenoDataGridViewTextBoxColumn.Name = "LecturerphonenoDataGridViewTextBoxColumn"
        Me.LecturerphonenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LecturerphonenoDataGridViewTextBoxColumn.Width = 125
        '
        'LectureremailDataGridViewTextBoxColumn
        '
        Me.LectureremailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LectureremailDataGridViewTextBoxColumn.DataPropertyName = "lecturer_email"
        Me.LectureremailDataGridViewTextBoxColumn.HeaderText = "lecturer_email"
        Me.LectureremailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LectureremailDataGridViewTextBoxColumn.Name = "LectureremailDataGridViewTextBoxColumn"
        Me.LectureremailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(544, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 31)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Lecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 409)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Lecturer"
        Me.Text = "Lecturer Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents OsccdbDataSet As osccdbDataSet
    Friend WithEvents LecturerBindingSource As BindingSource
    Friend WithEvents LecturerTableAdapter As osccdbDataSetTableAdapters.lecturerTableAdapter
    Friend WithEvents LectureridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerphonenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LectureremailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
