Public Class frmAlg
    Dim enunt As Boolean = False


    Private Sub lbxShowDir_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbxShowDir.SelectedValueChanged
        'afiseaza codul problemei selectate
        If lbxShowDir.SelectedIndex <> -1 Then
            rtbShowCode.Text = My.Computer.FileSystem.ReadAllText(lblShowDir.Text &
             "\" & lbxShowDir.SelectedItem.ToString & "\" & lbxShowDir.SelectedItem.ToString & ".txt")
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs)
        'executa problema selectata
        If lbxShowDir.SelectedIndex <> -1 Then
            Process.Start(lblShowDir.Text & "\" & lbxShowDir.SelectedItem.ToString &
             "\" & lbxShowDir.SelectedItem.ToString & ".exe")
        End If
    End Sub

    Private Sub frmAlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDir()
    End Sub
    Private Sub ShowDir()
        'gaseste fisierele, le citeste si le afiseaza numele in textbox

        lblShowDir.Text = Application.StartupPath & "\resurse\1. Probleme algoritmica"

        'cauta si afiseaza numele tuturor fisierelor din directorul "resurse"
        Dim di As New IO.DirectoryInfo(lblShowDir.Text)
        Dim drl As IO.DirectoryInfo() = di.GetDirectories()
        Dim dra As IO.DirectoryInfo

        lbxShowDir.Items.Clear()

        For Each dra In drl
            lbxShowDir.Items.Add(dra)
        Next
        rtbShowCode.Text = ""
    End Sub

    Private Sub TeoriePentruDoritoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeoriePentruDoritoriToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\resurse\Misc\Backtracking.pdf")
    End Sub

    Private Sub back4_Click(sender As Object, e As EventArgs) Handles back4.Click
        MainScreen.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub btnEn_Click(sender As Object, e As EventArgs) Handles btnEn.Click
        enunt = True
        'rtbShowCode.Text = My.Computer.FileSystem.ReadAllText(lblShowDir.Text &
        '"\" & lbxShowDir.SelectedItem.ToString & "\" & lbxShowDir.SelectedItem.ToString & " enunt.txt")
    End Sub

    Private Sub teorieBack_Click(sender As Object, e As EventArgs) Handles teorieAlg.Click
        Process.Start(Application.StartupPath & "\resurse\HTML\Algoritmica.html")
    End Sub
End Class