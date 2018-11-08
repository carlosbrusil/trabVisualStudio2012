Public Class Ejercicio6

    Private Sub txtSueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(txtSueldo.Text) > 3000 Then
                MsgBox("Debe pagar impuestos")
                lblMensaje.Visible = True
                TxtMensaje.Visible = True
                TxtMensaje.Text = "DEBE PAGAR IMPUESTOS"
            Else
                lblMensaje.Visible = False
                TxtMensaje.Visible = False
                TxtMensaje.Text = ""
            End If
            Button1.Focus()

        End If
    End Sub

    Private Sub txtSueldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtSueldo.Text = ""
        TxtMensaje.Visible = False
        lblMensaje.Visible = False
        txtSueldo.Focus()

    End Sub
End Class