Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PageTitle.Text = "HOME"
        btnHome.BackColor = Color.FromArgb(248, 244, 251)
        btnHome.ForeColor = Color.MediumVioletRed

        Me.MainPanel.Controls.Clear()
        Dim FrmHome_vrb As New frmHome() With {
        .Dock = DockStyle.Fill,
        .TopLevel = False,
        .TopMost = True
}
        FrmHome_vrb.FormBorderStyle = FormBorderStyle.None
        Me.MainPanel.Controls.Add(FrmHome_vrb)
        FrmHome_vrb.Show()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        PageTitle.Text = "HOME"
        btnHome.BackColor = Color.FromArgb(248, 244, 251)
        btnHome.ForeColor = Color.MediumVioletRed

        btnAbout.BackColor = Color.FromArgb(147, 52, 105)
        btnAbout.ForeColor = Color.FromArgb(248, 244, 251)

        btnInventory.BackColor = Color.FromArgb(147, 52, 105)
        btnInventory.ForeColor = Color.FromArgb(248, 244, 251)

        Me.MainPanel.Controls.Clear()
        Dim FrmHome_vrb As New frmHome() With {
        .Dock = DockStyle.Fill,
        .TopLevel = False,
        .TopMost = True
}
        FrmHome_vrb.FormBorderStyle = FormBorderStyle.None
        Me.MainPanel.Controls.Add(FrmHome_vrb)
        FrmHome_vrb.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        PageTitle.Text = "ABOUT US"
        btnAbout.BackColor = Color.FromArgb(248, 244, 251)
        btnAbout.ForeColor = Color.MediumVioletRed

        btnHome.BackColor = Color.FromArgb(147, 52, 105)
        btnHome.ForeColor = Color.FromArgb(248, 244, 251)

        btnInventory.BackColor = Color.FromArgb(147, 52, 105)
        btnInventory.ForeColor = Color.FromArgb(248, 244, 251)

        Me.MainPanel.Controls.Clear()
        Dim FrmAbout_vrb As New frmAbout() With {
        .Dock = DockStyle.Fill,
        .TopLevel = False,
        .TopMost = True
}
        FrmAbout_vrb.FormBorderStyle = FormBorderStyle.None
        Me.MainPanel.Controls.Add(FrmAbout_vrb)
        FrmAbout_vrb.Show()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        frmRecord.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        PageTitle.Text = "INVENTORY"
        btnInventory.BackColor = Color.FromArgb(248, 244, 251)
        btnInventory.ForeColor = Color.MediumVioletRed

        btnHome.BackColor = Color.FromArgb(147, 52, 105)
        btnHome.ForeColor = Color.FromArgb(248, 244, 251)

        btnAbout.BackColor = Color.FromArgb(147, 52, 105)
        btnAbout.ForeColor = Color.FromArgb(248, 244, 251)

        Me.MainPanel.Controls.Clear()
        Dim FrmInventory_vrb As New frmInventory() With {
        .Dock = DockStyle.Fill,
        .TopLevel = False,
        .TopMost = True
}
        FrmInventory_vrb.FormBorderStyle = FormBorderStyle.None
        Me.MainPanel.Controls.Add(FrmInventory_vrb)
        FrmInventory_vrb.Show()
    End Sub
End Class
