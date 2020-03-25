Public Class Form1

    Private Sub cmdHallo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHallo.Click
        lblAnzeige.Text = "Hallo"
    End Sub

    Private Sub cmdEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnde.Click
        Me.Close()
    End Sub

    Private Sub btnAndy_Click(sender As Object, e As EventArgs) Handles btnAndy.Click
        lblAnzeige.Text = "Mein Name ist Andy :-) Hallo"
    End Sub
End Class
