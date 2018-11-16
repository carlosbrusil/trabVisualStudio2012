Public Class frm_ejercicio24

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txt1erNro.Text = ""
        Me.Txt2doNro.Text = ""
        Me.txt3erNro.Text = ""
        Me.txtMayor.Text = ""
        Me.txtMenor.Text = ""
        Me.txtRango.Text = ""
        Me.txt1erNro.Focus()
    End Sub

    Private Sub txt1erNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1erNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt2doNro.Focus()
        End If
    End Sub

    Private Sub txt1erNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1erNro.TextChanged

    End Sub

    Private Sub Txt2doNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt2doNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt3erNro.Focus()
        End If
    End Sub

    Private Sub Txt2doNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2doNro.TextChanged

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim n1, n2, n3, mayor, menor As Single
        n1 = Val(txt1erNro.Text)
        n2 = Val(Txt2doNro.Text)
        n3 = Val(txt3erNro.Text)
        'encuentra el mayor y menor
        If n1 > n2 Then
            If (n1 > n3) Then
                mayor = n1
                If (n2 > n3) Then
                    menor = n3
                Else
                    menor = n2
                End If
            Else
                mayor = n3
                If (n1 > n2) Then
                    menor = n2
                Else
                    menor = n1
                End If
            End If
        Else
            If (n2 > n3) Then
                mayor = n2
                If (n1 > n3) Then
                    menor = n3
                Else
                    menor = n1
                End If
            Else
                mayor = n3
                If (n1 > n2) Then
                    menor = n2
                Else
                    menor = n1
                End If
            End If
        End If
        txtRango.Text = CStr(mayor - menor)
        txtMayor.Text = mayor
        txtMenor.Text = menor
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class