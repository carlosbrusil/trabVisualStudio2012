Public Class Ejercicio3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        Txt3erNro.Text = ""
        Txt4toNro.Text = ""
        txt1erNro.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtSuma.Text = Val(txt1erNro.Text) + Val(Txt2doNro.Text)
        TxtMultiplicacion.Text = Val(Txt3erNro.Text) * Val(Txt4toNro.Text)
    End Sub

    Private Sub TxtSuma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSuma.TextChanged

    End Sub
End Class