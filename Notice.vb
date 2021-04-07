Imports MySql.Data.MySqlClient
Public Class Notice
    Public DBconnection As New MySqlConnection
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles MessageTextBox.TextChanged

    End Sub

    Private Sub Notice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OsccdbDataSet.notice' table. You can move, or remove it, as needed.
        Me.NoticeTableAdapter.Fill(Me.OsccdbDataSet.notice)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strsql As String = "insert into notice values('" & Me.IDTextBox.Text & "', '" & Me.TitleTextBox.Text & "', '" & Me.MessageTextBox.Text & "')"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBconnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully Added.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()

    End Sub
End Class