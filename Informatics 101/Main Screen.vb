Public Class MainScreen
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        frmBack.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'frmAlg.Show()
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'frmRec.Show()
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        frmSub.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
