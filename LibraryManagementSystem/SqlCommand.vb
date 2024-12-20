Friend Class SqlCommand
    Private query As String
    Private conn As Object

    Public Sub New(query As String, conn As Object)
        Me.query = query
        Me.conn = conn
    End Sub
End Class
