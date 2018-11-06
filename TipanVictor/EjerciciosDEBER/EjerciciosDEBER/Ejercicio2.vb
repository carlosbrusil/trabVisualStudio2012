Public Class Ejercicio2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtPERIMETRO.Text = Val(txtLADO.Text) * 4
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtLADO.Text = ""
        TxtPERIMETRO.Text = ""
        txtLADO.Focus()
    End Sub

    Private Sub Ejercicio2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class