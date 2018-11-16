Public Class frm_Ejercicio30

    Private Sub frm_Ejercicio30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtN.Text = ""
        Me.txtPromedio.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = False
        Me.btnOK.Enabled = True
        Me.txtN.Focus()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim n, i, cp As Integer
        Dim altura, s1, promedio As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        cp = 0
        n = Val(txtN.Text)
        For i = 1 To n
            altura = Val(InputBox("Ingrese la altura  de la persona -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
            Me.ListBox1.Items.Add("Pieza número " + CStr(i) + " ----> " + CStr(altura))
            s1 = s1 + altura
        Next
        promedio = s1 / n
        Me.txtPromedio.Text = Format(promedio, "#0.00")
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