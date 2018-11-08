Public Class Ejercicio4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtSuma.Text = Val(txt1erNro.Text) + Val(Txt2doNro.Text) + Val(Txt3erNro.Text) + Val(Txt4toNro.Text)
        TxtPromedio.Text = Val(TxtSuma.Text) / 4
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        Txt3erNro.Text = ""
        Txt4toNro.Text = ""
        txt1erNro.Focus()
    End Sub
End Class