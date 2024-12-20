Imports MySql.Data.MySqlClient
Public Class frmRecord
    Dim connection As New MySqlConnection("server=127.0.0.1; port= 3306; userid=root;password='';database=test")

    Private Sub frmRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Define the query to select all books from the books table (replace 'books' with your actual table name)
        Dim query As String = "SELECT * FROM LibraryDB.book ;"  ' Assuming the table name is 'books'
        Dim adapter As New MySqlDataAdapter(query, connection)

        Dim books As New DataTable()

        Try
            ' Open connection and fill the DataTable with book records
            connection.Open()
            adapter.Fill(books)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed after the operation
            connection.Close()
        End Try

        ' Create a DataView to filter data
        Dim DV As New DataView(books)

        ' Apply the row filter if there is text in the SearchTxt box
        If String.IsNullOrEmpty(SearchTxt.Text) Then
            DV.RowFilter = String.Empty  ' Show all books if search text is empty
        Else
            ' Filter by title column, use LIKE for partial matching
            DV.RowFilter = String.Format("title LIKE '%{0}%'", SearchTxt.Text)
        End If

        ' Bind the filtered data to the DataGridView or whatever control you're using
        BooksData.DataSource = DV
    End Sub

    Private SelectedRowIndex As Integer = -1
    Private Sub BooksData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksData.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim row As DataGridViewRow = Me.BooksData.Rows(e.RowIndex)

            ' Display the data from the clicked row
            title.Text = row.Cells("title").Value.ToString()
            Author.Text = row.Cells("author").Value.ToString()  ' Display the author's name
            Genre.Text = row.Cells("genre").Value.ToString()  ' Display the genre name

            Dim status As String = row.Cells("status").Value.ToString()

            If status = "checked out" Then
                CORB.Checked = True
                RBAvl.Checked = False
            ElseIf status = "available" Then
                CORB.Checked = False
                RBAvl.Checked = True
            End If
        End If
        SelectedRowIndex = e.RowIndex
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Hide()
    End Sub

    Private Sub CORB_CheckedChanged(sender As Object, e As EventArgs) Handles CORB.CheckedChanged
        If CORB.Checked And SelectedRowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.BooksData.Rows(SelectedRowIndex)
            row.Cells("status").Value = "Checked Out"
        End If
    End Sub

    Private Sub RBAvl_CheckedChanged(sender As Object, e As EventArgs) Handles RBAvl.CheckedChanged
        If RBAvl.Checked And SelectedRowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.BooksData.Rows(SelectedRowIndex)
            row.Cells("status").Value = "Available"

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If SelectedRowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.BooksData.Rows(SelectedRowIndex)

            Dim newStatus As String = If(CORB.Checked, "Checked Out", "Available")

            ' Update the DataGridView
            row.Cells("status").Value = newStatus

            ' Update the database
            Dim bookTitle As String = row.Cells("title").Value.ToString() ' Assuming 'title' is unique or acts as an identifier

            Try
                ' Correctly handle the MySQL connection
                Using conn As New MySqlConnection("server=127.0.0.1;port=3306;userid=root;password=;database=test")
                    conn.Open()
                    Dim query As String = "UPDATE LibraryDB.Book SET status = @Status WHERE title = @Title"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Status", newStatus)
                        cmd.Parameters.AddWithValue("@Title", bookTitle)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Status updated successfully in the database!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a book to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class