Public Class frm_Ejercicio32



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim i, serie As Integer
        serie = 11
        For i = 1 To 25
            ListBox1.Items.Add("                             " + Format(i, "000") + "=========> " + CStr(serie))
            serie = serie + 11
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class