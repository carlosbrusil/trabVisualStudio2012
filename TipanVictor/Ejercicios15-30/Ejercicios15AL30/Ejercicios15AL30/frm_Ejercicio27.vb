Public Class frm_Ejercicio27

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim i, n As Integer
        Dim suma, promedio As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        suma = 0
        For i = 1 To 10
            n = Val(InputBox("Ingrese el --->  " + CStr(i) + "  número ", "Ingreso de datos ", 0))
            Me.ListBox1.Items.Add("Dato número " + CStr(i) + " ----> " + CStr(n))
            suma = suma + n
        Next
        promedio = suma / 10
        Me.txtPromedio.Text = Format(promedio, "###,#00.00")
        Me.txtSuma.Text = Format(suma, "##0")
    End Sub

    Private Sub txtNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.ListBox1.Items.Clear()
        Me.txtSuma.Text = ""
        Me.txtPromedio.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frm_Ejercicio27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class