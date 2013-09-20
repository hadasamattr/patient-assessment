Public Class Form1
    Dim blnBSI As Boolean = False
    Dim bsiSceneSafety As Boolean = False
    Dim blnMOI As Boolean = False
    Dim intNumberPatients As Integer = 1
    Dim blnAddlResources As Boolean = False

    Private Sub btnMedical_Click(sender As Object, e As EventArgs) Handles btnMedical.Click
        Medical.Show()
    End Sub

    Private Sub btnTrauma_Click(sender As Object, e As EventArgs) Handles btnTrauma.Click
        Trauma.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub KillYourselfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillYourselfToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MedicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalToolStripMenuItem.Click
        Medical.Show()
    End Sub

    Private Sub TraumaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraumaToolStripMenuItem.Click
        Trauma.Show()
    End Sub

    Private Sub PonyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PonyToolStripMenuItem.Click
        Me.BackgroundImage = (My.Resources.mlp)
    End Sub

    Private Sub YourMomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YourMomToolStripMenuItem.Click
        Me.BackgroundImage = (My.Resources.Your_Mom)
    End Sub

    Private Sub GoatseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoatseToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://goo.gl/7juUP")
    End Sub

    Private Sub TitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://goo.gl/AUSov")
    End Sub

    Private Sub GtfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GtfoToolStripMenuItem1.Click
        Me.BackgroundImage = (My.Resources.GFYWAC)
    End Sub

    Private Sub ThereAreNoBreaksOnTheRapeTrainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThereAreNoBreaksOnTheRapeTrainToolStripMenuItem.Click
        Me.BackgroundImage = (My.Resources.tanbotrt)
    End Sub
End Class
