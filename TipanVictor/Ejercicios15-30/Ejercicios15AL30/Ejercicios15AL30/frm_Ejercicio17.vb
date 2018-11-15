Public Class frm_Ejercicio17

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

    Private Sub txtAño_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAño.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case Val(Me.TxtMes.Text)
            Case 1 To 3 : Me.LblMensaje.Text = "Primer Trimestre"
            Case 4 To 6 : Me.LblMensaje.Text = "Segundo Trimestre"
            Case 7 To 9 : Me.LblMensaje.Text = "terer trimestre"
            Case 10 To 12 : Me.LblMensaje.Text = "cuarto trimestre"
        End Select
    End Sub

    Private Sub frm_Ejercicio17_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ejercicio17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
End Class