Public Class frm_Ejercicio22

    Private Sub txtCoordenadaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoordenadaX.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCoordenadaY.Focus()
        End If
    End Sub


    Private Sub txtCoordenadaX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoordenadaX.TextChanged

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim x, y As Single
        x = Val(txtCoordenadaX.Text)
        y = Val(TxtCoordenadaY.Text)
        If (x > 0) And (y > 0) Then
            LblMensaje.Text = "*** Se encuentra en el PRIMER cuadrante ***"
        Else
            If (x < 0) And (y > 0) Then
                LblMensaje.Text = "*** Se encuentra en el SEGUNDO cuadrante ***"
            Else
                If (x < 0) And (y < 0) Then
                    LblMensaje.Text = "*** Se encuentra en el TERCER cuadrante ***"
                Else
                    LblMensaje.Text = "*** Se encuentra en el CUARTO cuadrante ***"
                End If
            End If

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frm_Ejercicio22_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtCoordenadaX.Text = ""
        TxtCoordenadaY.Text = ""
        LblMensaje.Text = ""
        txtCoordenadaX.Focus()
    End Sub
End Class