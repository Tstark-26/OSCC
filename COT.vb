Imports MySql.Data.MySqlClient
Public Class COT
    Public DBconnection As New MySqlConnection

    Private Sub COT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OsccdbDataSet.notice' table. You can move, or remove it, as needed.
        Me.NoticeTableAdapter.Fill(Me.OsccdbDataSet.notice)

    End Sub

    Public Sub Connect_to_DB() 'creating a database connection procedure'
        Dim DBConnectionstring As String = "server=localhost; uid=root; pwd=6582; Database=OSCCdb;"
        With DBconnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionstring
                .Open()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error")
                Call Disconnect_to_DB()
            End Try
        End With
    End Sub

    Public Sub Disconnect_to_DB() 'creating a database disconnection procedure'
        With DBconnection
            .Close()
            .Dispose()
        End With
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Comments.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Notice.Show()

    End Sub
End Class
