Public Class frm_Ejercicio35

    Private Sub frm_Ejercicio35_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtN.Text = ""
        Me.txtPares.Text = ""
        Me.txtImpares.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = False
        Me.btnOK.Enabled = True
        Me.txtN.Focus()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim n, i, c1, c2 As Integer
        Dim numero As Integer
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        c2 = 0
        n = Val(txtN.Text)
        For i = 1 To n
            numero = Val(InputBox("Ingrese el numero -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
            Me.ListBox1.Items.Add("numero  " + CStr(i) + " ----> " + CStr(numero))
            If numero Mod 2 = 0 Then
                c1 = c1 + 1
            Else
                c2 = c2 + 1
            End If
        Next
        Me.txtPares.Text = CStr(c1)
        Me.txtImpares.Text = CStr(c2)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.btnCalcular.Enabled = True
        Me.btnOK.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub
End Class