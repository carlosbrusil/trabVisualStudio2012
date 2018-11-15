Public Class frm_Ejercicio20

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        txt3erNro.Text = ""
        LblMensaje.Text = ""
        txt1erNro.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(txt1erNro.Text) < 10 And Val(Txt2doNro.Text) < 10 And Val(txt3erNro.Text) < 10 Then
            LblMensaje.Text = "Los tres numeros son menores que 10"
        Else
            LblMensaje.Text = "No son menores a 10"
        End If
    End Sub

    Private Sub frm_Ejercicio20_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt1erNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1erNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt2doNro.Focus()
        End If
    End Sub

    Private Sub txt1erNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1erNro.TextChanged

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Txt2doNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt2doNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt3erNro.Focus()
        End If
    End Sub

    Private Sub Txt2doNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2doNro.TextChanged

    End Sub

    Private Sub txt3erNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3erNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GroupBox1.Focus()
        End If
    End Sub

    Private Sub txt3erNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3erNro.TextChanged

    End Sub
End Class