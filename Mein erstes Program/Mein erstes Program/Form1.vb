Public Class Form1

    Private Sub cmdHallo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHallo.Click
        lblAnzeige.Text = "Hallo"
    End Sub

    Private Sub cmdEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnde.Click
        Me.Close()
    End Sub
End Class
