Public Class frm_Ejercicio29

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim nota, i, c1, c2 As Integer
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        c2 = 0
        For i = 1 To 10
            nota = Val(InputBox("Ingrese la nota -->  " + CStr(i), "Ingreso de datos ", 0))
            Me.ListBox1.Items.Add("Nota número " + CStr(i) + " ----> " + CStr(nota))
            If nota >= 7 Then
                c1 = c1 + 1
            Else
                c2 = c2 + 1
            End If
        Next
        Me.txtNotasMenores.Text = Format(c2, "#0")
        Me.txtNotasMayores.Text = Format(c1, "#0")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ListBox1.Items.Clear()
        Me.txtNotasMayores.Text = ""
        Me.txtNotasMenores.Focus()
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class