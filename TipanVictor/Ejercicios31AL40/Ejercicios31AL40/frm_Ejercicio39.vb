Public Class frm_Ejercicio39

    Private Sub frm_Ejercicio39_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtSuma.Text = ""
        Me.txtMensaje.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = True
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnCalcular_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim suma, c1 As Integer
        Dim numero As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        suma = 0
        Do
            c1 = c1 + 1
            numero = Val(InputBox("Ingrese el numero -->  " + CStr(c1), "PARA FINALIZAR INGRESE -  9999 ", "", 450, 535))
            If numero <> 9999 Then
                Me.ListBox1.Items.Add("numero  " + CStr(c1) + " ----> " + CStr(numero))
                suma = suma + numero
            End If
        Loop Until numero = 9999
        If suma < 0 Then
            txtMensaje.Text = "El acumulado es <  0"
        Else
            If suma = 0 Then
                txtMensaje.Text = "El acumulado es = 0 "
            Else
                txtMensaje.Text = "El acumulado es > 0"
            End If
        End If
        Me.txtSuma.Text = CStr(suma)
    End Sub
End Class