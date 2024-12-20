<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BooksData = New DataGridView()
        Panel1 = New Panel()
        CBStatus = New ComboBox()
        SearchTxt = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel5 = New Panel()
        btnDelete = New Button()
        btnAdd = New Button()
        TxtYear = New TextBox()
        Label6 = New Label()
        TxtAuthor = New TextBox()
        TxtGenre = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TxtTitle = New TextBox()
        Label3 = New Label()
        CType(BooksData, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' BooksData
        ' 
        BooksData.BackgroundColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle4.Padding = New Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        BooksData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        BooksData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle5.Padding = New Padding(2)
        DataGridViewCellStyle5.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        BooksData.DefaultCellStyle = DataGridViewCellStyle5
        BooksData.Location = New Point(24, 65)
        BooksData.Margin = New Padding(4)
        BooksData.Name = "BooksData"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle6.Padding = New Padding(2)
        DataGridViewCellStyle6.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        BooksData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        BooksData.RowHeadersWidth = 62
        BooksData.Size = New Size(834, 730)
        BooksData.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel1.Controls.Add(CBStatus)
        Panel1.Controls.Add(SearchTxt)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(BooksData)
        Panel1.Location = New Point(26, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(889, 822)
        Panel1.TabIndex = 3
        ' 
        ' CBStatus
        ' 
        CBStatus.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        CBStatus.FormattingEnabled = True
        CBStatus.Location = New Point(648, 16)
        CBStatus.Name = "CBStatus"
        CBStatus.Size = New Size(210, 38)
        CBStatus.TabIndex = 5
        ' 
        ' SearchTxt
        ' 
        SearchTxt.Location = New Point(129, 16)
        SearchTxt.Name = "SearchTxt"
        SearchTxt.PlaceholderText = "Enter Book Title"
        SearchTxt.Size = New Size(504, 37)
        SearchTxt.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 3
        Label1.Text = "Search:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(939, 26)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(536, 66)
        Panel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Image = My.Resources.Resources.open_book
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(16, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 30)
        Label2.TabIndex = 5
        Label2.Text = "          Book Details"
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(2, 65)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(133, 195)
        Panel4.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Location = New Point(0, 65)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(536, 757)
        Panel3.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(btnDelete)
        Panel5.Controls.Add(btnAdd)
        Panel5.Controls.Add(TxtYear)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(TxtAuthor)
        Panel5.Controls.Add(TxtGenre)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(TxtTitle)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(939, 91)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(536, 757)
        Panel5.TabIndex = 5
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.DeepPink
        btnDelete.Location = New Point(180, 569)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(177, 63)
        btnDelete.TabIndex = 4
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.MediumAquamarine
        btnAdd.Location = New Point(190, 490)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(146, 63)
        btnAdd.TabIndex = 4
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' TxtYear
        ' 
        TxtYear.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        TxtYear.Location = New Point(40, 402)
        TxtYear.Name = "TxtYear"
        TxtYear.PlaceholderText = "ex. 2005"
        TxtYear.Size = New Size(448, 37)
        TxtYear.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 30)
        Label6.TabIndex = 0
        Label6.Text = "Year:"
        ' 
        ' TxtAuthor
        ' 
        TxtAuthor.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        TxtAuthor.Location = New Point(40, 189)
        TxtAuthor.Name = "TxtAuthor"
        TxtAuthor.PlaceholderText = "ex. Rick Riordan"
        TxtAuthor.Size = New Size(448, 37)
        TxtAuthor.TabIndex = 1
        ' 
        ' TxtGenre
        ' 
        TxtGenre.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        TxtGenre.Location = New Point(40, 296)
        TxtGenre.Name = "TxtGenre"
        TxtGenre.PlaceholderText = "ex. Fantasy"
        TxtGenre.Size = New Size(448, 37)
        TxtGenre.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 30)
        Label4.TabIndex = 0
        Label4.Text = "Author:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 30)
        Label5.TabIndex = 0
        Label5.Text = "Genre:"
        ' 
        ' TxtTitle
        ' 
        TxtTitle.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        TxtTitle.Location = New Point(40, 83)
        TxtTitle.Name = "TxtTitle"
        TxtTitle.PlaceholderText = "ex. Percy Jackson"
        TxtTitle.Size = New Size(448, 37)
        TxtTitle.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 30)
        Label3.TabIndex = 0
        Label3.Text = "Title:"
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        ClientSize = New Size(1501, 879)
        Controls.Add(Panel5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frmInventory"
        Text = "Form5"
        CType(BooksData, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BooksData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
End Class
