Public Class Ejercicio8

    Private Sub Txt2doNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt2doNro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(txt1erNro.Text) = Val(Txt2doNro.Text) Then
                MsgBox("Deben ser diferentes vuelva a ingresar")
                Txt2doNro.Focus()
            End If
        End If
    End Sub

    Private Sub Txt2doNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2doNro.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(txt1erNro.Text) > Val(Txt2doNro.Text) Then
            TxtR1.Text = Val(txt1erNro.Text) + Val(Txt2doNro.Text)
            TxtR2.Text = Val(txt1erNro.Text) - Val(Txt2doNro.Text)
        Else
            TxtR1.Text = Val(txt1erNro.Text) * Val(Txt2doNro.Text)
            TxtR2.Text = Val(txt1erNro.Text) / Val(Txt2doNro.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        TxtR1.Text = ""
        TxtR2.Text = ""
        txt1erNro.Focus()
    End Sub
End Class