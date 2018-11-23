Public Class frm_Ejercicio34

    Private Sub frm_Ejercicio34_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.ListBox2.Items.Clear()
        Me.txtAcum1.Text = ""
        Me.txtAcum2.Text = ""
        Me.txtComparacion.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = True
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim i, c1, c2 As Integer
        Dim numero As Integer
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        c2 = 0
        For i = 1 To 15
            numero = Val(InputBox("LISTA1: Ingrese el numero -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
            Me.ListBox1.Items.Add("numero  " + CStr(i) + " ----> " + CStr(numero))
            c1 = c1 + numero
        Next
        For i = 1 To 15
            numero = Val(InputBox("LISTA2: Ingrese el numero -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
            Me.ListBox2.Items.Add("numero  " + CStr(i) + " ----> " + CStr(numero))
            c2 = c2 + numero
        Next
        Me.txtAcum1.Text = CStr(c1)
        Me.txtAcum2.Text = CStr(c2)
        If c1 > c2 Then
            Me.txtComparacion.Text = "Lista 1 Mayor"
        Else
            If c2 > c1 Then
                Me.txtComparacion.Text = "Lista 2 Mayor"
            Else
                Me.txtComparacion.Text = "Listas Iguales"
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub
End Class