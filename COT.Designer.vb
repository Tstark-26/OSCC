<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsccdbDataSet = New OSCC.osccdbDataSet()
        Me.NoticeTableAdapter = New OSCC.osccdbDataSetTableAdapters.noticeTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.NoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Post on the Notceboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Populate Students Comments"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(749, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(23, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(229, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Assign Lecturer Units"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(23, 214)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(229, 42)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Units Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(23, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(229, 40)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Lecturer Details"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 69)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "College Of Technology"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 100)
        Me.Panel1.TabIndex = 7
        '
        'COT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(851, 408)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "COT"
        Me.Text = "College Of Technology"
        CType(Me.NoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OsccdbDataSet As osccdbDataSet
    Friend WithEvents NoticeBindingSource As BindingSource
    Friend WithEvents NoticeTableAdapter As osccdbDataSetTableAdapters.noticeTableAdapter
    Friend WithEvents Panel1 As Panel
End Class
