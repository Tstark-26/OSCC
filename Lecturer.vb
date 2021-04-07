Public Class Lecturer
    Private Sub Lecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OsccdbDataSet.lecturer' table. You can move, or remove it, as needed.
        Me.LecturerTableAdapter.Fill(Me.OsccdbDataSet.lecturer)

    End Sub
End Class