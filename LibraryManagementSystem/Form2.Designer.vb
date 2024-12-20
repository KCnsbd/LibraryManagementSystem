<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Panel1 = New Panel()
        Label2 = New Label()
        TotalBooks = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        booksAvl = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        booksBrw = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        borrow = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(borrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TotalBooks)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(518, 469)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(446, 333)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label2.Location = New Point(64, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(319, 68)
        Label2.TabIndex = 0
        Label2.Text = "worlds that fit on" & vbCrLf & "the palm of your hand"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TotalBooks
        ' 
        TotalBooks.AutoSize = True
        TotalBooks.Font = New Font("Century Gothic", 63F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalBooks.ForeColor = Color.DeepPink
        TotalBooks.Location = New Point(112, 75)
        TotalBooks.Name = "TotalBooks"
        TotalBooks.Size = New Size(216, 151)
        TotalBooks.TabIndex = 0
        TotalBooks.Text = "##"
        TotalBooks.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label1.Location = New Point(150, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 34)
        Label1.TabIndex = 0
        Label1.Text = "Home to"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(booksAvl)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(44, 484)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(446, 301)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label3.Location = New Point(52, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(334, 68)
        Label3.TabIndex = 0
        Label3.Text = "Books" & vbCrLf & "Available in the System"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' booksAvl
        ' 
        booksAvl.AutoSize = True
        booksAvl.Font = New Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        booksAvl.ForeColor = Color.MediumVioletRed
        booksAvl.Location = New Point(137, 77)
        booksAvl.Name = "booksAvl"
        booksAvl.Size = New Size(163, 112)
        booksAvl.TabIndex = 0
        booksAvl.Text = "##"
        booksAvl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label8.Location = New Point(151, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 34)
        Label8.TabIndex = 0
        Label8.Text = "Currently"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(booksBrw)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(998, 484)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(446, 301)
        Panel3.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label5.Location = New Point(127, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 68)
        Label5.TabIndex = 0
        Label5.Text = "Books" & vbCrLf & "Checked Out"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' booksBrw
        ' 
        booksBrw.AutoSize = True
        booksBrw.Font = New Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        booksBrw.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        booksBrw.Location = New Point(146, 77)
        booksBrw.Name = "booksBrw"
        booksBrw.Size = New Size(163, 112)
        booksBrw.TabIndex = 0
        booksBrw.Text = "##"
        booksBrw.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label7.Location = New Point(158, 36)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 34)
        Label7.TabIndex = 0
        Label7.Text = "Currently"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.books1
        PictureBox1.Location = New Point(44, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(920, 378)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' borrow
        ' 
        borrow.Image = CType(resources.GetObject("borrow.Image"), Image)
        borrow.Location = New Point(984, 149)
        borrow.Name = "borrow"
        borrow.Size = New Size(323, 129)
        borrow.SizeMode = PictureBoxSizeMode.Zoom
        borrow.TabIndex = 2
        borrow.TabStop = False
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        ClientSize = New Size(1501, 879)
        Controls.Add(borrow)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frmHome"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(borrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalBooks As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents booksAvl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents booksBrw As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents borrow As PictureBox
End Class
