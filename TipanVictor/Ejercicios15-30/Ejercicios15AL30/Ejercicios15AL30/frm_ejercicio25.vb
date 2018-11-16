Public Class frm_ejercicio25

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim i As Integer
        For i = 1 To 100 Step 5
            ListBox1.Items.Add("    " + Format(i, "00") + "  " + Format(i + 1, "00") + "   " + Format(i + 2, "00") + "   " + Format(i + 3, "00") + "   " + Format(i + 4, "00"))
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class