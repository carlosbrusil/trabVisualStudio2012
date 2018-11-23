Public Class frm_Ejercicio36

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim mensaje As String
        If Val(Me.txtNro.Text) > 99 Then
            mensaje = "El número es de 3 cifras"
        Else
            If Val(Me.txtNro.Text) > 9 Then
                mensaje = "El número es de 2 cifras"
            Else
                mensaje = "El número es de 1 cifra"
            End If

        End If
        TxtMensaje.Text = mensaje
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtNro.Text = ""
        Me.TxtMensaje.Text = ""
        Me.txtNro.Focus()
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub txtNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(txtNro.Text) < 1 Or Val(txtNro.Text) > 999 Then
                MsgBox("Numero debe ser de 1 a 3 cifras", MsgBoxStyle.Exclamation, "Error")
                Me.txtNro.Focus()
            Else
                Me.btnCalcular.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtNro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNro.LostFocus
        If Val(txtNro.Text) < 0 Or Val(txtNro.Text) > 999 Then
            MsgBox("Numero debe ser de 1 a 3 cifras", MsgBoxStyle.Exclamation, "Error")
            Me.txtNro.Focus()
        Else
            Me.btnCalcular.Enabled = True
        End If
    End Sub

    Private Sub txtNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNro.TextChanged

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class