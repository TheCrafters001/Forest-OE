Public Class Setup_Page1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setup_Page2.Show()
        Me.Close()
    End Sub

    Private Sub Setup_Page1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Forest_OS_Startup, AudioPlayMode.Background)
    End Sub
End Class