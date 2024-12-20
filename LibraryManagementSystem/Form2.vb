Imports MySql.Data.MySqlClient
Public Class frmHome
    Dim connection As New MySqlConnection("server=127.0.0.1; port= 3306; userid=root;password='';database=test")

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT COUNT(*) FROM LibraryDB.book"

        Dim command As New MySqlCommand(query, connection)

        Try
            connection.Open()
            Dim total As Integer = Convert.ToInt32(command.ExecuteScalar())
            TotalBooks.Text = total.ToString()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Dim queryAvl As String = "SELECT COUNT(*) FROM LibraryDB.book WHERE status = 'available';"

        Dim commandAvl As New MySqlCommand(queryAvl, connection)

        Try
            connection.Open()
            Dim total As Integer = Convert.ToInt32(commandAvl.ExecuteScalar())
            booksAvl.Text = total.ToString()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Dim queryBrw As String = "SELECT COUNT(*) FROM LibraryDB.book WHERE status = 'checked out';"

        Dim commandBrw As New MySqlCommand(queryBrw, connection)

        Try
            connection.Open()
            Dim total As Integer = Convert.ToInt32(commandBrw.ExecuteScalar())
            booksBrw.Text = total.ToString()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub borrow_Click(sender As Object, e As EventArgs) Handles borrow.Click
        frmRecord.Show()
    End Sub
End Class