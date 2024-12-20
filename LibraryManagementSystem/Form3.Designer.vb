<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.CHAPTER1_LOGO__porpol_1
        PictureBox1.Location = New Point(50, -46)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(596, 461)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(699, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(683, 340)
        Label1.TabIndex = 1
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(228), CByte(195), CByte(209))
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(51, 426)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1408, 422)
        Panel1.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label6.Location = New Point(567, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(246, 23)
        Label6.TabIndex = 2
        Label6.Text = "Database Administrator"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label4.Location = New Point(173, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(211, 23)
        Label4.TabIndex = 2
        Label4.Text = "Front-End Developer"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label5.Location = New Point(515, 323)
        Label5.Name = "Label5"
        Label5.Size = New Size(347, 28)
        Label5.TabIndex = 2
        Label5.Text = "Keana Clarisse E. Consebido"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label3.Location = New Point(124, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(306, 28)
        Label3.TabIndex = 2
        Label3.Text = "Angela Nicole N. Galang"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(252, 47)
        Label2.TabIndex = 1
        Label2.Text = "Developers:"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(577, 95)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(224, 220)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.gela
        PictureBox2.Location = New Point(163, 95)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(224, 220)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1019, 95)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(224, 220)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label7.Location = New Point(957, 323)
        Label7.Name = "Label7"
        Label7.Size = New Size(355, 28)
        Label7.TabIndex = 2
        Label7.Text = "Ma. Yzabelle B. Macalindong"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        Label8.Location = New Point(1033, 351)
        Label8.Name = "Label8"
        Label8.Size = New Size(210, 23)
        Label8.TabIndex = 2
        Label8.Text = "Back-End Developer"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        ClientSize = New Size(1501, 879)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frmAbout"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
