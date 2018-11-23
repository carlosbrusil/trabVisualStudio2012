Public Class frm_Ejercicio33

    Private Sub frm_Ejercicio33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ListBox1.Items.Clear()
        Me.btnCalcular.Enabled = True
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.btnCalcular.Enabled = False
        Dim i, serie As Integer
        serie = 8
        i = 1
        Do While (serie <= 500)
            ListBox1.Items.Add("                             " + Format(i, "00") + "=========> " + CStr(serie))
            serie = serie + 8
            i = i + 1
        Loop
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class