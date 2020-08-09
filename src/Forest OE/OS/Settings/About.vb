Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub
End Class