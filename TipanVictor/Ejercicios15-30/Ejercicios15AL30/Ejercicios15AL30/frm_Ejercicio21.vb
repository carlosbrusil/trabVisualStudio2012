Public Class frm_Ejercicio21

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        txt3erNro.Text = ""
        LblMensaje.Text = ""
        txt1erNro.Focus()
    End Sub
    Private Sub txt1erNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1erNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt2doNro.Focus()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Txt2doNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt2doNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt3erNro.Focus()
        End If
    End Sub
    Private Sub txt3erNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3erNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GroupBox1.Focus()
        End If
    End Sub

    Private Sub frm_Ejercicio21_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If Val(txt1erNro.Text) < 10 Or Val(Txt2doNro.Text) < 10 Or Val(txt3erNro.Text) < 10 Then
            MsgBox("Al menos alguno de los números es menor a 10 ", MsgBoxStyle.Information, "Observación")
            LblMensaje.Text = "**** AL MENOS UN NRO ES MENOR A 10 ****"
        Else
            MsgBox ("No hay numeros menor a 10",MsgBoxStyle.Information ,"Nota")
        End If
    End Sub
End Class