Public Class Comments
    Private Sub Comments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OsccdbDataSet.comments' table. You can move, or remove it, as needed.
        Me.CommentsTableAdapter.Fill(Me.OsccdbDataSet.comments)

    End Sub
End Class