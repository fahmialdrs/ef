Public Class finance
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        adminmenu.Show()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class