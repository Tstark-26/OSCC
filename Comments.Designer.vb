<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comments
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OsccdbDataSet = New OSCC.osccdbDataSet()
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New OSCC.osccdbDataSetTableAdapters.commentsTableAdapter()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommenttitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentmessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsregnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentDataGridViewTextBoxColumn, Me.CommenttitleDataGridViewTextBoxColumn, Me.CommentmessageDataGridViewTextBoxColumn, Me.StudentsregnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CommentsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'OsccdbDataSet
        '
        Me.OsccdbDataSet.DataSetName = "osccdbDataSet"
        Me.OsccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommentsBindingSource
        '
        Me.CommentsBindingSource.DataMember = "comments"
        Me.CommentsBindingSource.DataSource = Me.OsccdbDataSet
        '
        'CommentsTableAdapter
        '
        Me.CommentsTableAdapter.ClearBeforeFill = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommenttitleDataGridViewTextBoxColumn
        '
        Me.CommenttitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommenttitleDataGridViewTextBoxColumn.DataPropertyName = "comment_title"
        Me.CommenttitleDataGridViewTextBoxColumn.HeaderText = "comment_title"
        Me.CommenttitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CommenttitleDataGridViewTextBoxColumn.Name = "CommenttitleDataGridViewTextBoxColumn"
        Me.CommenttitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentmessageDataGridViewTextBoxColumn
        '
        Me.CommentmessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommentmessageDataGridViewTextBoxColumn.DataPropertyName = "comment_message"
        Me.CommentmessageDataGridViewTextBoxColumn.HeaderText = "comment_message"
        Me.CommentmessageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CommentmessageDataGridViewTextBoxColumn.Name = "CommentmessageDataGridViewTextBoxColumn"
        Me.CommentmessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentsregnoDataGridViewTextBoxColumn
        '
        Me.StudentsregnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudentsregnoDataGridViewTextBoxColumn.DataPropertyName = "students_reg_no"
        Me.StudentsregnoDataGridViewTextBoxColumn.HeaderText = "students_reg_no"
        Me.StudentsregnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentsregnoDataGridViewTextBoxColumn.Name = "StudentsregnoDataGridViewTextBoxColumn"
        Me.StudentsregnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Comments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Comments"
        Me.Text = "Comments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OsccdbDataSet As osccdbDataSet
    Friend WithEvents CommentsBindingSource As BindingSource
    Friend WithEvents CommentsTableAdapter As osccdbDataSetTableAdapters.commentsTableAdapter
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommenttitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentmessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentsregnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
