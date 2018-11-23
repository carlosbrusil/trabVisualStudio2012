Public Class frm_Ejercicio37

    Private Sub frm_Ejercicio37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtSuma.Text = ""
        Me.txtPromedio.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = True
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnCalcular_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim suma, c1 As Integer
        Dim numero As Integer
        Dim promedio As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        suma = 0
        Do
            numero = Val(InputBox("Ingrese el numero -->  " + CStr(c1 + 1), "PARA FINALIZAR DIGITE - 0 ", "", 450, 535))
            If numero <> 0 Then
                Me.ListBox1.Items.Add("numero  " + CStr(c1 + 1) + " ----> " + CStr(numero))
                suma = suma + numero
                c1 = c1 + 1
            End If
        Loop Until numero = 0
        promedio = suma / (c1 - 1)

        Me.txtSuma.Text = CStr(suma)
        Me.txtPromedio.Text = CStr(promedio)
    End Sub
End Class