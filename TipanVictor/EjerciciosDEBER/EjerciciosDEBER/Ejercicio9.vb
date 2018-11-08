Public Class Ejercicio9

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtPromedio.Text = (Val(txt1eraNota.Text) + Val(Txt2daNota.Text) + Val(Txt3eraNota.Text)) / 3
        If Val(txtPromedio.Text) > 7 Then
            txtMensaje.Text = "Promocionado"
        Else
            txtMensaje.Text = "suspenso"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1eraNota.Text = ""
        Txt2daNota.Text = ""
        Txt3eraNota.Text = ""
        txtPromedio.Text = ""
        txtMensaje.Text = ""
        txt1eraNota.Focus()
    End Sub
End Class