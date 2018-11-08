Public Class Ejercicio5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtCantidad.Text = ""
        txtPrecio.Text = ""
        TxtValorPagar.Text = ""
        txtPrecio.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtValorPagar.Text = Val(TxtCantidad.Text) * Val(txtPrecio.Text)
    End Sub
End Class