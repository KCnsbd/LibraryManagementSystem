Imports MySql.Data.MySqlClient

Public Class frmInventory
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBStatus.Items.Add("All")
        CBStatus.Items.Add("Available")
        CBStatus.Items.Add("Checked Out")

        CBStatus.SelectedIndex = 0

        Dim conn As New MySqlConnection("server=127.0.0.1; port= 3306; userid=root;password='';database=test")
        Dim SDA As New MySqlDataAdapter()
        Dim dbDataSet As New DataTable()
        Dim bSource As New BindingSource()

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM LibraryDB.book;"
            Dim command As New MySqlCommand(query, conn)

            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            BooksData.DataSource = bSource

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        Dim connectionString As String = "server=127.0.0.1; port=3306; userid=root; password=''; database=test"
        Dim connection As New MySqlConnection(connectionString)


        Dim query As String = "SELECT * FROM LibraryDB.book ;"
        Dim adapter As New MySqlDataAdapter(query, connection)

        Dim books As New DataTable()

        Try

            connection.Open()
            adapter.Fill(books)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            connection.Close()
        End Try

        Dim DV As New DataView(books)

        If String.IsNullOrEmpty(SearchTxt.Text) Then
            DV.RowFilter = String.Empty
        Else
            DV.RowFilter = String.Format("title LIKE '%{0}%'", SearchTxt.Text)
        End If

        BooksData.DataSource = DV
    End Sub

    Private SelectedRowIndex As Integer = -1
    Private Sub BooksData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksData.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim row As DataGridViewRow = Me.BooksData.Rows(e.RowIndex)

            ' Display the data from the clicked row
            TxtTitle.Text = row.Cells("title").Value.ToString()
            TxtAuthor.Text = row.Cells("author").Value.ToString()
            TxtGenre.Text = row.Cells("genre").Value.ToString()
            TxtYear.Text = row.Cells("year").Value.ToString()

        End If
        SelectedRowIndex = e.RowIndex
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Ensure a row is selected
        If SelectedRowIndex < 0 Then
            MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected row
        Dim row As DataGridViewRow = Me.BooksData.Rows(SelectedRowIndex)

        ' Get the book's title as an identifier
        Dim bookTitle As String = row.Cells("title").Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the book '{bookTitle}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' Delete the record from the database
        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3306; userid=root; password=''; database=test")
                conn.Open()
                Dim query As String = "DELETE FROM LibraryDB.book WHERE title = @Title"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Title", bookTitle)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Remove the row from the DataGridView
            BooksData.Rows.RemoveAt(SelectedRowIndex)
            SelectedRowIndex = -1

            MessageBox.Show("Book deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(TxtTitle.Text) OrElse
       String.IsNullOrWhiteSpace(TxtAuthor.Text) OrElse
       String.IsNullOrWhiteSpace(TxtGenre.Text) OrElse
       String.IsNullOrWhiteSpace(TxtYear.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Gather input data
        Dim title As String = TxtTitle.Text.Trim()
        Dim author As String = TxtAuthor.Text.Trim()
        Dim genre As String = TxtGenre.Text.Trim()
        Dim year As Integer
        If Not Integer.TryParse(TxtYear.Text.Trim(), year) Then
            MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert into the database
        Try
            Using conn As New MySqlConnection("server=127.0.0.1; port=3306; userid=root; password=''; database=test")
                conn.Open()
                Dim query As String = "INSERT INTO LibraryDB.book (title, author, genre, year, status) VALUES (@Title, @Author, @Genre, @Year, 'available')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Title", title)
                    cmd.Parameters.AddWithValue("@Author", author)
                    cmd.Parameters.AddWithValue("@Genre", genre)
                    cmd.Parameters.AddWithValue("@Year", year)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book added successfully!", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear input fields
            TxtTitle.Clear()
            TxtAuthor.Clear()
            TxtGenre.Clear()
            TxtYear.Clear()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub CBStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatus.SelectedIndexChanged
        ' Get the selected status
        Dim selectedStatus As String = CBStatus.SelectedItem.ToString()

        ' Filter the DataGridView
        Dim connectionString As String = "server=127.0.0.1; port=3306; userid=root; password=''; database=test"
        Dim connection As New MySqlConnection(connectionString)

        ' Construct the query based on the selected filter
        Dim query As String
        If selectedStatus = "All" Then
            query = "SELECT * FROM LibraryDB.book;" ' No filter, get all records
        Else
            query = "SELECT * FROM LibraryDB.book WHERE status = @Status;"
        End If

        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim books As New DataTable()

        Try
            connection.Open()
            If selectedStatus <> "All" Then
                ' Add the filter parameter
                adapter.SelectCommand.Parameters.AddWithValue("@Status", selectedStatus)
            End If
            adapter.Fill(books)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        BooksData.DataSource = books
    End Sub

End Class