<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecord
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        SearchTxt = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        btnSave = New Button()
        CORB = New RadioButton()
        RBAvl = New RadioButton()
        Genre = New Label()
        Author = New Label()
        Label6 = New Label()
        Label5 = New Label()
        title = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        Close = New Button()
        BooksData = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(BooksData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel1.Controls.Add(SearchTxt)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(824, 52)
        Panel1.TabIndex = 2
        ' 
        ' SearchTxt
        ' 
        SearchTxt.Location = New Point(118, 8)
        SearchTxt.Name = "SearchTxt"
        SearchTxt.PlaceholderText = "Enter Book Title"
        SearchTxt.Size = New Size(691, 37)
        SearchTxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 0
        Label1.Text = "Search:"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(CORB)
        Panel2.Controls.Add(RBAvl)
        Panel2.Controls.Add(Genre)
        Panel2.Controls.Add(Author)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(title)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(849, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(402, 605)
        Panel2.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.DeepPink
        btnSave.Location = New Point(125, 498)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(172, 54)
        btnSave.TabIndex = 3
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' CORB
        ' 
        CORB.AutoSize = True
        CORB.Location = New Point(193, 437)
        CORB.Name = "CORB"
        CORB.Size = New Size(200, 34)
        CORB.TabIndex = 2
        CORB.TabStop = True
        CORB.Text = "Checked Out"
        CORB.UseVisualStyleBackColor = True
        ' 
        ' RBAvl
        ' 
        RBAvl.AutoSize = True
        RBAvl.Location = New Point(14, 437)
        RBAvl.Name = "RBAvl"
        RBAvl.Size = New Size(152, 34)
        RBAvl.TabIndex = 2
        RBAvl.TabStop = True
        RBAvl.Text = "Available"
        RBAvl.UseVisualStyleBackColor = True
        ' 
        ' Genre
        ' 
        Genre.AutoSize = True
        Genre.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Genre.ImageAlign = ContentAlignment.MiddleLeft
        Genre.Location = New Point(29, 297)
        Genre.Name = "Genre"
        Genre.Size = New Size(336, 28)
        Genre.TabIndex = 1
        Genre.Text = "___________________________"
        ' 
        ' Author
        ' 
        Author.AutoSize = True
        Author.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Author.ImageAlign = ContentAlignment.MiddleLeft
        Author.Location = New Point(29, 189)
        Author.Name = "Author"
        Author.Size = New Size(336, 28)
        Author.TabIndex = 1
        Author.Text = "___________________________"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(157, 377)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 30)
        Label6.TabIndex = 0
        Label6.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 30)
        Label5.TabIndex = 0
        Label5.Text = "Genre:"
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title.ImageAlign = ContentAlignment.MiddleLeft
        title.Location = New Point(29, 75)
        title.Name = "title"
        title.Size = New Size(336, 28)
        title.TabIndex = 1
        title.Text = "___________________________"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 30)
        Label4.TabIndex = 0
        Label4.Text = "Author:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 30)
        Label3.TabIndex = 0
        Label3.Text = "Title:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Close)
        Panel3.Location = New Point(849, 20)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 52)
        Panel3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Image = My.Resources.Resources.open_book
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(16, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 30)
        Label2.TabIndex = 1
        Label2.Text = "          Book Details"
        ' 
        ' Close
        ' 
        Close.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Close.FlatAppearance.BorderSize = 0
        Close.FlatStyle = FlatStyle.Flat
        Close.Image = My.Resources.Resources.close
        Close.Location = New Point(348, 10)
        Close.Name = "Close"
        Close.Size = New Size(38, 34)
        Close.TabIndex = 0
        Close.UseVisualStyleBackColor = False
        ' 
        ' BooksData
        ' 
        BooksData.BackgroundColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle1.Padding = New Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BooksData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        BooksData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle2.Padding = New Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        BooksData.DefaultCellStyle = DataGridViewCellStyle2
        BooksData.Location = New Point(13, 79)
        BooksData.Margin = New Padding(4)
        BooksData.Name = "BooksData"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        DataGridViewCellStyle3.Padding = New Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = Color.DeepPink
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        BooksData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        BooksData.RowHeadersWidth = 62
        BooksData.Size = New Size(823, 599)
        BooksData.TabIndex = 1
        ' 
        ' frmRecord
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        ClientSize = New Size(1263, 691)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BooksData)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frmRecord"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(BooksData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Close As Button
    Friend WithEvents title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RBAvl As RadioButton
    Friend WithEvents Genre As Label
    Friend WithEvents Author As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents CORB As RadioButton
    Friend WithEvents BooksData As DataGridView
End Class
