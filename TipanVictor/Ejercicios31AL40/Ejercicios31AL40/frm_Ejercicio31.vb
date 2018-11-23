Public Class frm_Ejercicio31

    Private Sub frm_Ejercicio31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Sub limpiar()
        Me.ListBox1.Items.Clear()
        Me.txtN.Text = ""
        Me.txtc1.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnCalcular.Enabled = False
        Me.btnOK.Enabled = True
        Me.txtN.Focus()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim n, i, c1, c2 As Integer
        Dim sueldo, s1, promedio As Single
        Me.btnCalcular.Enabled = False
        Me.btnNuevo.Enabled = True
        c1 = 0
        c2 = 0
        n = Val(txtN.Text)
        For i = 1 To n
            sueldo = 0
            Do Until (sueldo >= 100 And sueldo <= 500)
                sueldo = Val(InputBox("Ingrese el sueldo del empleado -->  " + CStr(i), "Ingreso de datos ", "", 450, 535))
                If sueldo < 100 Or sueldo > 500 Then
                    MsgBox("Sueldo debe ser entre 100 y 500", MsgBoxStyle.Exclamation, "Error")
                End If
            Loop

            Me.ListBox1.Items.Add("Sueldo numero  " + CStr(i) + " ----> " + CStr(sueldo))
            s1 = s1 + sueldo
            If sueldo >= 100 And sueldo <= 300 Then
                c1 = c1 + 1
            Else
                If sueldo > 300 Then
                    c2 = c2 + 1
                End If
            End If
        Next
        promedio = s1 / n
        Me.TxtTotal.Text = Format(s1, "#0.00")
        Me.txtc1.Text = CStr(c1)
        Me.txtc2.Text = CStr(c2)
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
