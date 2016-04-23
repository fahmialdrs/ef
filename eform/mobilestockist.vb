Public Class mobilestockist
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        noform.Text = ""
        userid.Text = ""
        nama.Text = ""
        notelpon.Text = ""
        firmax3r.Value = 0
        o2max3r.Value = 0
        totalpcs.Text = ""
        totalset.Text = ""
        amountr.Text = ""
        transferrwallet = ""
        ordered.Text = ""
        proceeded.Text = ""
        finalcheck.Text = ""
        datainput.Text = ""
    End Sub

    Private Sub firmax3r_ValueChanged(sender As Object, e As EventArgs) Handles firmax3r.ValueChanged
        totalpcs.Text = firmax3r.Value + o2max3r.Value
        totalset.Text = totalpcs.Text / 2
        amountr.Text = totalset.Text * 1000000
    End Sub

    Private Sub o2max3r_ValueChanged(sender As Object, e As EventArgs) Handles o2max3r.ValueChanged
        totalpcs.Text = firmax3r.Value + o2max3r.Value
        totalset.Text = totalpcs.Text / 2
        amountr.Text = totalset.Text * 1000000
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub
End Class