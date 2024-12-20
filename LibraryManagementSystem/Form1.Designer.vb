<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel1 = New Panel()
        btnAbout = New Button()
        btnInventory = New Button()
        btnRecord = New Button()
        btnHome = New Button()
        PictureBox1 = New PictureBox()
        PageTitle = New Label()
        MainPanel = New Panel()
        btnClose = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(147), CByte(52), CByte(105))
        Panel1.Controls.Add(btnAbout)
        Panel1.Controls.Add(btnInventory)
        Panel1.Controls.Add(btnRecord)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(353, 1082)
        Panel1.TabIndex = 0
        ' 
        ' btnAbout
        ' 
        btnAbout.FlatAppearance.BorderSize = 0
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbout.ForeColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), Image)
        btnAbout.Location = New Point(0, 745)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(353, 83)
        btnAbout.TabIndex = 1
        btnAbout.Text = "     About us"
        btnAbout.TextAlign = ContentAlignment.MiddleLeft
        btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnInventory
        ' 
        btnInventory.FlatAppearance.BorderSize = 0
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventory.ForeColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), Image)
        btnInventory.Location = New Point(0, 625)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(353, 83)
        btnInventory.TabIndex = 1
        btnInventory.Text = "     Inventory"
        btnInventory.TextAlign = ContentAlignment.MiddleLeft
        btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInventory.UseVisualStyleBackColor = True
        ' 
        ' btnRecord
        ' 
        btnRecord.BackColor = Color.MediumVioletRed
        btnRecord.FlatAppearance.BorderSize = 0
        btnRecord.FlatStyle = FlatStyle.Flat
        btnRecord.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecord.ForeColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnRecord.Image = CType(resources.GetObject("btnRecord.Image"), Image)
        btnRecord.Location = New Point(0, 321)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(353, 117)
        btnRecord.TabIndex = 1
        btnRecord.Text = "     Record"
        btnRecord.TextAlign = ContentAlignment.MiddleLeft
        btnRecord.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRecord.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        btnHome.Image = My.Resources.Resources.dashboard
        btnHome.Location = New Point(0, 505)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(353, 83)
        btnHome.TabIndex = 1
        btnHome.Text = "     Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.CHAPTER1_LOGO__pink_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(325, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PageTitle
        ' 
        PageTitle.AutoSize = True
        PageTitle.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PageTitle.ForeColor = Color.FromArgb(CByte(87), CByte(63), CByte(76))
        PageTitle.Location = New Point(399, 42)
        PageTitle.Name = "PageTitle"
        PageTitle.Size = New Size(248, 85)
        PageTitle.TabIndex = 1
        PageTitle.Text = "HOME"
        ' 
        ' MainPanel
        ' 
        MainPanel.Location = New Point(387, 167)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1501, 879)
        MainPanel.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Image = My.Resources.Resources.close
        btnClose.Location = New Point(1780, 42)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(73, 60)
        btnClose.TabIndex = 3
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(251))
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnClose)
        Controls.Add(MainPanel)
        Controls.Add(PageTitle)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        Text = "LIBRARY MANAGEMENT SYSTEM"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents PageTitle As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnClose As Button

End Class
