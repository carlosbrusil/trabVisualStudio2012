Public Class frm_Ejercicio15

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim porcentaje As Single
        porcentaje = Val(TxtPregCorrectas.Text) * 100.0 / Val(txtNroPreguntas.Text)
        Select Case porcentaje
            Case Is >= 90.0 : TxtNivel.Text = "Nivel maximo"
            Case 75 To 89.99 : TxtNivel.Text = "Nivel medio"
            Case 50 To 74.99 : TxtNivel.Text = "Nivel regular"
            Case Is < 50 : TxtNivel.Text = "Fuera de Nivel"
        End Select
        Me.TxtPorcentaje.Text = Format(porcentaje, "##0.00")
        Me.TxtPorcentaje.Text = Me.TxtPorcentaje.Text + "%"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TxtNivel.Text = ""
        Me.txtNroPreguntas.Text = ""
        Me.TxtPorcentaje.Text = ""
        Me.TxtPregCorrectas.Text = ""
        Me.txtNroPreguntas.Focus()
    End Sub

    Private Sub frm_Ejercicio15_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtPregCorrectas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregCorrectas.TextChanged
        If Val(TxtPregCorrectas.Text) < 0 Or Val(TxtPregCorrectas.Text) > Val(txtNroPreguntas.Text) Then
            MsgBox("valor debe ser entre 0 y Nro de Preguntas ", MsgBoxStyle.Information, "error")
            Me.TxtPregCorrectas.SelectionStart = 0
            Me.TxtPregCorrectas.SelectionLength = Len(Me.TxtPregCorrectas.Text)
            Me.TxtPregCorrectas.Text = Me.TxtPregCorrectas.SelectedText
            Me.TxtPregCorrectas.Focus()
        End If
    End Sub
End Class
