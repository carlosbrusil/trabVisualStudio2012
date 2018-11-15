Public Class frmEjercicio8

    Private Sub frmEjercicio8_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frmEjercicio8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpia()
    End Sub
    Sub limpia()
        Me.txtProducto.Text = ""
        Me.txtCantComp.Text = ""
        Me.txtPrecUnit.Text = ""
        Me.lblDescD.Text = ""
        Me.lblDesPor.Text = ""
        Me.lblSubtotal.Text = ""
        Me.lblTotal.Text = ""
        Me.txtProducto.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpia()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim desc As Integer
        Me.lblSubtotal.Text = CStr(Val(Me.txtCantComp.Text) * Val(Me.txtPrecUnit.Text))
        Select Case Val(Me.lblSubtotal.Text)
            Case 100, 101 : desc = 2
            Case 101.1 To 200 : desc = 4
            Case 200.1 To 500 : desc = 6
            Case Is > 500 : desc = 10
            Case Else : desc = 0
        End Select
        Me.lblDesPor.Text = CStr(desc)
        Me.lblDescD.Text = Format(Val(Me.lblSubtotal.Text) * desc / 100, "###,##0.00")
        Me.lblTotal.Text = Format(Val(lblSubtotal.Text) - Val(lblDescD.Text), "###,##0.00")
        Me.lblSubtotal.Text = Format(Val(Me.lblSubtotal.Text), "###,##0.00")

    End Sub
End Class