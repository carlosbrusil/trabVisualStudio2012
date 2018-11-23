Public Class frm_Ejercicio40

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub txtRangoMedio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
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
        Dim i, nrocuenta As Integer
        Dim saldo, suma As Single
        Dim estado As String
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        i = 0
        suma = 0
        Do
            i = i + 1
            nrocuenta = Val(InputBox("Ingrese numero de cuenta ---> ", "PARA FINALIZAR INGRESE - un valor negativo ", "", 450, 535))
            If nrocuenta >= 0 Then
                saldo = Val(InputBox("Ingrese el saldo ---> ", "LECTURA DEL SALDO ", "", 450, 535))
                If saldo > 0 Then
                    estado = "ACREEDOR"
                    suma = suma + saldo
                Else
                    If saldo < 0 Then
                        estado = "DEUDOR"
                    Else
                        estado = "NULO"
                    End If
                End If
                Me.ListBox1.Items.Add("     Nrocuenta  " + Format(nrocuenta, "000000") + "  Saldo: " + Format(saldo, "###,000.00") + "  Estado de cuenta es " + estado)
            End If
        Loop Until nrocuenta < 0
        Me.txtTotal.Text = Format(suma, "###,###.00") + " $"
    End Sub

    Private Sub frm_Ejercicio40_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
End Class