Public Class frm_Ejercicio19

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        txt3erNro.Text = ""
        LblMensaje.Text = ""
        txt1erNro.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim suma, producto As Single
        If Val(txt1erNro.Text) = Val(Txt2doNro.Text) And Val(txt1erNro.Text) = Val(txt3erNro.Text) Then
            suma = Val(txt1erNro.Text) + Val(Txt2doNro.Text)
            producto = suma * Val(txt3erNro.Text)
            LblMensaje.Text = "La suma de los dos primeros=" + CStr(suma) + Chr(13) + " y el producto de la suma por el 3ero = " + CStr(producto)
        Else
            LblMensaje.Text = "No son iguales"
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class