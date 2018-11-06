Public Class Ejercicio1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtAREA.Text = Val(txtLADO.Text) * Val(txtLADO.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtLADO.Text = ""
        TxtAREA.Text = ""
        txtLADO.Focus()
    End Sub
End Class
