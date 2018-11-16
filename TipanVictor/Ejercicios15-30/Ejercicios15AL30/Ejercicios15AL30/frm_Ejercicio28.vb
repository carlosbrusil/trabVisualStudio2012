Public Class frm_Ejercicio28

    Private Sub frm_Ejercicio28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim n, i, cp As Integer
        Dim medidapieza As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        cp = 0
        n = Val(txtN.Text)
        For i = 1 To n
            medidapieza = Val(InputBox("Ingrese la longitud de la pieza -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
            Me.ListBox1.Items.Add("Pieza número " + CStr(i) + " ----> " + CStr(medidapieza))
            If (medidapieza >= 1.2 And medidapieza <= 1.3) Then
                cp = cp + 1
            End If
        Next
        Me.txtAptas.Text = Format(cp, "#0")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnOK.Enabled = True

        End If
    End Sub

    Private Sub txtN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN.TextChanged

    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtN.Text = ""
        Me.txtAptas.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = False
        Me.btnOK.Enabled = True
        Me.txtN.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.btnCalcular.Enabled = True
        Me.btnOK.Enabled = False
    End Sub
End Class