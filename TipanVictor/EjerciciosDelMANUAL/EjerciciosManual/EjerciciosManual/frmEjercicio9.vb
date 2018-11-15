Public Class frmEjercicio9

    Private Sub frmEjercicio9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpiar()
    End Sub
    Sub limpiar()
        Me.txtAlumno.Text = ""
        Me.txtCurso.Text = ""
        Me.txtNota1.Text = ""
        Me.TxtNota2.Text = ""
        Me.LblCualidad.Text = ""
        Me.lblObs.Text = ""
        Me.lblPromedio.Text = ""
        Me.lblPuntos.Text = ""
        Me.LblCualidad.Text = ""
        Me.txtAlumno.Focus()
    End Sub

    Private Sub btnOtroAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtroAlumno.Click
        Call limpiar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnObtener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObtener.Click
        Me.lblPromedio.Text = CStr((Val(Me.txtNota1.Text) + Val(Me.TxtNota2.Text)) / 2)
        If Val(Me.lblPromedio.Text) >= 10.5 Then
            Me.lblObs.Text = "Aprobado(a)"
            Me.lblPuntos.Text = "Le faltan " + CStr(20 - Val(Me.lblPromedio.Text)) + " puntos para llegar a 20"
        Else
            Me.lblObs.Text = "Desaprobado (a)"
            Me.lblPuntos.Text = "Le faltan " + CStr(11 - Val(Me.lblPromedio.Text)) + " puntos para aprobar"
        End If
        Select Case Val(Me.lblPromedio.Text)
            Case 0 To 5 : Me.LblCualidad.Text = "pesimo"
            Case 5.1 To 10.4 : Me.LblCualidad.Text = "malo"
            Case 10.5 To 14.4 : Me.LblCualidad.Text = "regular"
            Case 14.5 To 17.4 : Me.LblCualidad.Text = "Bueno"
            Case 17.5 To 20 : Me.LblCualidad.Text = "Excelente"
        End Select
    End Sub

    Private Sub txtNota1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNota1.GotFocus
        Me.txtNota1.SelectionStart = 0
        Me.txtNota1.SelectionLength = Len(Me.txtNota1.Text)

    End Sub

    Private Sub txtNota1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNota1.LostFocus
        If Not IsNumeric(Me.txtNota1.Text) Or Val(Me.txtNota1.Text) < 0 Or Val(Me.txtNota1.Text) > 20 Then
            MsgBox("deben ser valores entre 1 y 20 ", MsgBoxStyle.Information, "cuidado")
            Me.txtNota1.Focus()
        End If
    End Sub

    Private Sub txtNota1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNota1.TextChanged

    End Sub

    Private Sub TxtNota2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNota2.GotFocus
        Me.TxtNota2.SelectionStart = 0
        Me.TxtNota2.SelectionLength = Len(Me.TxtNota2.Text)
    End Sub

    Private Sub TxtNota2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNota2.LostFocus
        If Not IsNumeric(Me.TxtNota2.Text) Or Val(Me.TxtNota2.Text) < 0 Or Val(Me.TxtNota2.Text) > 20 Then
            MsgBox("deben ser valores entre 1 y 20 ", MsgBoxStyle.Information, "cuidado")
            Me.TxtNota2.Focus()
        End If
    End Sub

    Private Sub TxtNota2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNota2.TextChanged

    End Sub
End Class