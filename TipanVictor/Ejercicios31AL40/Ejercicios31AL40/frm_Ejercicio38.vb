Public Class frm_Ejercicio38

    Private Sub frm_Ejercicio38_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtRangoMedio.Text = ""
        Me.txtRangoAlto.Text = ""
        Me.txtRangoBajo.Text = ""
        Me.txtTotal.Text = ""
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
        Dim i, suma, r1, r2, r3 As Integer
        Dim peso As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        r1 = 0
        r2 = 0
        r3 = 0
        i = 0
        Do
            i = i + 1
            peso = Val(InputBox("Ingrese el peso -->  " + CStr(i), "PARA FINALIZAR INGRESE - 0 ", "", 450, 535))
            If peso <> 0 Then
                Me.ListBox1.Items.Add("peso  " + CStr(i) + " ----> " + CStr(peso))
                If peso < 9.8 Then
                    r1 = r1 + 1
                Else
                    If peso <= 10.2 Then
                        r2 = r2 + 1
                    Else
                        r3 = r3 + 1
                    End If
                End If
            End If
        Loop Until peso = 0
        suma = r1 + r2 + r3
        Me.txtRangoMedio.Text = CStr(r2)
        Me.txtRangoAlto.Text = CStr(r3)
        Me.txtRangoBajo.Text = CStr(r1)
        Me.txtTotal.Text = CStr(suma)
    End Sub
End Class