Public Class frm_ejercicio26

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ListBox1.Items.Clear()
        Me.txtNro.Text = ""
        Me.txtNro.Focus()
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim i As Integer
        For i = 1 To Val(txtNro.Text)
            ListBox1.Items.Add("    " + Format(i, "00"))
        Next
        Me.btnCalcular.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNro.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            Me.btnCalcular.Enabled = True
            Me.btnNuevo.Enabled = True
        End If

    End Sub

    Private Sub txtNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNro.TextChanged

    End Sub
End Class