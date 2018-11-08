Public Class frmEjercicio6

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub frmEjercicio6_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frmEjercicio6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpia()
    End Sub
    Sub limpia()
        Me.txtProducto.Text = ""
        Me.txtPrecAct.Text = ""
        Me.txtPrecAnt.Text = ""
        Me.lblAlzaD.Text = ""
        Me.lblAlzaP.Text = ""
        Me.txtProducto.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpia()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.lblAlzaD.Text = CStr(Val(Me.txtPrecAct.Text) - Val(Me.txtPrecAnt.Text))
        Me.lblAlzaD.Text = Format(Val(Me.lblAlzaD.Text), "###,##0.00")
        Me.lblAlzaP.Text = CStr(Val(Me.txtPrecAct.Text) * 100 / Val(Me.txtPrecAnt.Text))
        Me.lblAlzaP.Text = Format(Val(Me.lblAlzaP.Text), "###,##0.00")
        Me.lblAlzaP.Text = Me.lblAlzaP.Text + "%"
    End Sub
End Class