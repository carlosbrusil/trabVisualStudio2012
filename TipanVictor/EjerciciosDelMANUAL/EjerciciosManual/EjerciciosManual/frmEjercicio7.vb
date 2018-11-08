Public Class frmEjercicio7

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim PHN As Single
        PHN = IIf(Val(txtHT.Text) > 48, 8.0, 7.0)
        Me.lblPH.Text = Format(PHN, "##0.00")
        Me.lblTHE.Text = Format(Val(Me.txtHE.Text) * 9.5, "###,##0.00")
        Me.lblTHN.Text = Format(Val(Me.txtHT.Text) * PHN, "###,##0.00")
        Me.lblTP.Text = Format(Val(lblTHN.Text) + Val(lblTHE.Text), "###,##0.00")

    End Sub

    Private Sub frmEjercicio7_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frmEjercicio7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpia()
    End Sub
    Sub limpia()
        Me.txtNomProf.Text = ""
        Me.txtHT.Text = ""
        Me.txtHE.Text = ""
        Me.lblPH.Text = ""
        Me.lblTHE.Text = ""
        Me.lblTHN.Text = ""
        Me.lblTP.Text = ""
        Me.txtNomProf.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpia()
    End Sub
End Class