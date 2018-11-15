Public Class frm_Ejercicio16

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c As Single
        Dim msj As String
        a = Val(Me.txt1erNro.Text)
        b = Val(Me.Txt2doNro.Text)
        c = Val(Me.txt3erNro.Text)
        If (a > b) And (a > c) Then
            msj = "El 1er número es mayor"
        Else
            If (b > a) And (b > c) Then
                msj = "El 2do número es mayor"
            Else
                If (c > a) And (c > b) Then
                    msj = "El 3er número es mayor"
                Else
                    msj = "Dos o tres números son iguales"
                End If
            End If
        End If
        MsgBox(msj, MsgBoxStyle.Exclamation, "Resultado")
        LblMayor.Text = msj
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt1erNro.Text = ""
        Txt2doNro.Text = ""
        txt3erNro.Text = ""
        LblMayor.Text = ""
        txt1erNro.Focus()
    End Sub

    Private Sub frm_Ejercicio16_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txt1erNro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1erNro.TextChanged

    End Sub
End Class