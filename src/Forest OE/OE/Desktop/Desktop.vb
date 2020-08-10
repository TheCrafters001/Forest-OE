Imports ForestOEUtilities

Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time_lbl.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub shutdownMenuItem_Desktop_Click(sender As Object, e As EventArgs) Handles shutdownMenuItem_Desktop.Click
        ShutdownDialog.Show()
    End Sub
End Class