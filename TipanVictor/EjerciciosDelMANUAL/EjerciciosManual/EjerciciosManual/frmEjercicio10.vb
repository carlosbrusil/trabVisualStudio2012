Public Class frmEjercicio10

    Private Sub frmEjercicio10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpiar()
    End Sub
    Sub limpiar()
        Me.txtNombre.Text = ""
        Me.txtAñoNac.Text = ""
        Me.lblAños.Text = ""
        Me.LblCualidad.Text = ""
        Me.lblEdad.Text = ""
        Me.lblObs.Text = ""
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpiar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultado.Click
        If Not IsNumeric(Me.txtAñoNac.Text) Then
            MsgBox("debe ingresar digitos en el año", MsgBoxStyle.Information, "cuidado")
            Me.txtAñoNac.SelectionStart = 0
            Me.txtAñoNac.SelectionLength = Len(Me.txtAñoNac.Text)
            Me.txtAñoNac.Focus()
            Exit Sub

        End If
        Me.lblEdad.Text = CStr(Val(Year(Now())) - Val(txtAñoNac.Text))
        If Val(Me.lblEdad.Text) < 18 Then
            Me.lblObs.Text = "es menor de edad"
            Me.lblAños.Text = "Le falta " + CStr(18 - Val(Me.lblEdad.Text)) + "  para ser mayor de edad"
        Else
            Me.lblObs.Text = " ES MAYOR DE EDAD"
            Me.lblAños.Text = "Es mayor de edad, pasa " + CStr(Val(Me.lblEdad.Text) - 18) + "  años "
        End If
        Select Case Val(Me.lblEdad.Text)
            Case 0 To 12 : Me.LblCualidad.Text = "niño"
            Case 13 To 17 : Me.LblCualidad.Text = "adolescente"
            Case 18 To 30 : Me.LblCualidad.Text = "joven"
            Case 31 To 70 : Me.LblCualidad.Text = "Adulto"
            Case Is > 70 : Me.LblCualidad.Text = "anciano"
        End Select
    End Sub
End Class