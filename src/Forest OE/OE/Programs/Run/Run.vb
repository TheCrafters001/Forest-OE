Imports System.Windows.Forms
Imports ForestOEUtilities

Public Class Run

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ComboBox1.Text = ComboBox1.Text.ToLower
        If ComboBox1.Text = "ver" Then
            About.Show()

        ElseIf ComboBox1.Text = "explorer" Then
            Explorer.Show()
        ElseIf ComboBox1.Text = "osset" Then
            Settings.Show()
        ElseIf ComboBox1.Text = "delaccount" Then
            DeleteAccount.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
