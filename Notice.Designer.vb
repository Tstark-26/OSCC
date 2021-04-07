<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notice
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
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoticeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoticetitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoticemessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsccdbDataSet = New OSCC.osccdbDataSet()
        Me.NoticeTableAdapter = New OSCC.osccdbDataSetTableAdapters.noticeTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(155, 133)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(283, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 110)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Post To Noticeboard"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(338, 481)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Delete Notice"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 481)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 44)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Post Notice"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Location = New System.Drawing.Point(155, 266)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(283, 172)
        Me.MessageTextBox.TabIndex = 10
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(155, 197)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(283, 22)
        Me.TitleTextBox.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoticeidDataGridViewTextBoxColumn, Me.NoticetitleDataGridViewTextBoxColumn, Me.NoticemessageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NoticeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(541, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(518, 305)
        Me.DataGridView1.TabIndex = 12
        '
        'NoticeidDataGridViewTextBoxColumn
        '
        Me.NoticeidDataGridViewTextBoxColumn.DataPropertyName = "notice_id"
        Me.NoticeidDataGridViewTextBoxColumn.HeaderText = "notice_id"
        Me.NoticeidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoticeidDataGridViewTextBoxColumn.Name = "NoticeidDataGridViewTextBoxColumn"
        Me.NoticeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoticeidDataGridViewTextBoxColumn.Width = 125
        '
        'NoticetitleDataGridViewTextBoxColumn
        '
        Me.NoticetitleDataGridViewTextBoxColumn.DataPropertyName = "notice_title"
        Me.NoticetitleDataGridViewTextBoxColumn.HeaderText = "notice_title"
        Me.NoticetitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoticetitleDataGridViewTextBoxColumn.Name = "NoticetitleDataGridViewTextBoxColumn"
        Me.NoticetitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoticetitleDataGridViewTextBoxColumn.Width = 125
        '
        'NoticemessageDataGridViewTextBoxColumn
        '
        Me.NoticemessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoticemessageDataGridViewTextBoxColumn.DataPropertyName = "notice_message"
        Me.NoticemessageDataGridViewTextBoxColumn.HeaderText = "notice_message"
        Me.NoticemessageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoticemessageDataGridViewTextBoxColumn.Name = "NoticemessageDataGridViewTextBoxColumn"
        Me.NoticemessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoticeBindingSource
        '
        Me.NoticeBindingSource.DataMember = "notice"
        Me.NoticeBindingSource.DataSource = Me.OsccdbDataSet
        '
        'OsccdbDataSet
        '
        Me.OsccdbDataSet.DataSetName = "osccdbDataSet"
        Me.OsccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NoticeTableAdapter
        '
        Me.NoticeTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Notice Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Notice ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Notice Message:"
        '
        'Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 528)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Notice"
        Me.Text = "Notice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MessageTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OsccdbDataSet As osccdbDataSet
    Friend WithEvents NoticeBindingSource As BindingSource
    Friend WithEvents NoticeTableAdapter As osccdbDataSetTableAdapters.noticeTableAdapter
    Friend WithEvents NoticeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoticetitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoticemessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
