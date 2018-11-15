Public Class frm_Ejercicio23

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtSueldo.Text = ""
        TxtAños.Text = ""
        txtPorcentaje.Text = ""
        TxtNuevoSueldo.Text = ""
        txtSueldo.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim porcentaje As Single
        If Val(txtSueldo.Text) < 500 And Val(TxtAños.Text) >= 10 Then
            porcentaje = 20
        Else
            If Val(txtSueldo.Text) < 500 And Val(TxtAños.Text) < 10 Then
                porcentaje = 5
            Else
                porcentaje = 0
            End If

        End If
        TxtNuevoSueldo.Text = Format(Val(txtSueldo.Text) + Val(txtSueldo.Text) * porcentaje / 100, "###,##0.00")
        txtPorcentaje.Text = Format(porcentaje, "#0.00")
        txtPorcentaje.Text = txtPorcentaje.Text + "%"
    End Sub

    Private Sub txtSueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtAños.Focus()
        End If
    End Sub

    Private Sub txtSueldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.TextChanged

    End Sub
End Class