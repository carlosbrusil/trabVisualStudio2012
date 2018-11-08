Public Class EjercicioDIEZ

    Private Sub txtNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(txtNro.Text) > 0 And Val(txtNro.Text) < 10 Then
                MsgBox("Numero de 1 digito")
                TxtMensaje.Text = "numero e 1 digito"
            Else
                If Val(txtNro.Text) > 9 And Val(txtNro.Text) < 100 Then
                    MsgBox("Numero de 2 digitos")
                    TxtMensaje.Text = "numero de 2 digitos"
                Else
                    MsgBox("numero debe ser solo de dos cifras vuela a ingresar")
                    TxtMensaje.Text = "error debe ser hasta 2 cifras - reintente"
                    txtNro.Focus()
                End If
            End If
        End If
    End Sub



    Private Sub txtNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNro.TextChanged

    End Sub
End Class