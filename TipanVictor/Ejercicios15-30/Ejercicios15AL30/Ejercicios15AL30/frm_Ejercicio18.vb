Public Class frm_Ejercicio18
    Private Sub txtDia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDia.TextChanged
        If Val(txtDia.Text) < 0 Or Val(txtDia.Text) > 31 Then
            MsgBox("valor debe ser entre 1 y 31 ", MsgBoxStyle.Information, "error")
            Me.txtDia.SelectionStart = 0
            Me.txtDia.SelectionLength = Len(Me.txtDia.Text)
            Me.txtDia.Text = Me.txtDia.SelectedText
            Me.txtDia.Focus()
        End If

    End Sub

    Private Sub TxtMes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMes.TextChanged
        If Val(TxtMes.Text) < 0 Or Val(TxtMes.Text) > 12 Then
            MsgBox("valor debe ser entre 1 y 12 ", MsgBoxStyle.Information, "error")
            Me.TxtMes.SelectionStart = 0
            Me.TxtMes.SelectionLength = Len(Me.TxtMes.Text)
            Me.TxtMes.Text = Me.TxtMes.SelectedText
            Me.TxtMes.Focus()
        End If
    End Sub

    Private Sub txtAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAño.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(txtAño.Text) < 2000 Or Val(txtAño.Text) > 2018 Then
                MsgBox("Para este ejercicio debe ser entre 2000 y 2018 ", MsgBoxStyle.Information, "error")
                Me.txtAño.SelectionStart = 0
                Me.txtAño.SelectionLength = Len(Me.txtAño.Text)
                Me.txtAño.Text = Me.txtAño.SelectedText
                Me.txtAño.Focus()
            Else
                LblMensaje.Focus()
            End If

        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtDia.Text = ""
        TxtMes.Text = ""
        txtAño.Text = ""
        txtDia.Focus()
        LblMensaje.Text = ""
    End Sub

    Private Sub frm_Ejercicio18_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(txtDia.Text) = 24 And Val(TxtMes.Text) = 12 Then
            MsgBox("Merry Chistmas -  Es Navidad ", MsgBoxStyle.Exclamation, "NAVIDAD")
            LblMensaje.Text = "Es Navidad"
        End If
    End Sub
End Class