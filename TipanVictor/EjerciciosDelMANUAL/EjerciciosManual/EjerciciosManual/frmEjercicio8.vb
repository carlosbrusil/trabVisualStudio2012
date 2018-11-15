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
        Me.txtAlumno.Text = ""
        Me.txtNota1.Text = ""
        Me.txtCurso.Text = ""
        Me.lblObs.Text = ""
        Me.lblPromedio.Text = ""
        Me.lblSubtotal.Text = ""
        Me.lblPuntos.Text = ""
        Me.txtAlumno.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtro.Click
        Call limpia()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObtener.Click
        Dim desc As Integer
        Me.lblSubtotal.Text = CStr(Val(Me.txtNota1.Text) * Val(Me.txtCurso.Text))
        Select Case Val(Me.lblSubtotal.Text)
            Case 100, 101 : desc = 2
            Case 101.1 To 200 : desc = 4
            Case 200.1 To 500 : desc = 6
            Case Is > 500 : desc = 10
            Case Else : desc = 0
        End Select
        Me.lblPromedio.Text = CStr(desc)
        Me.lblObs.Text = Format(Val(Me.lblSubtotal.Text) * desc / 100, "###,##0.00")
        Me.lblPuntos.Text = Format(Val(lblSubtotal.Text) - Val(lblDescD.Text), "###,##0.00")
        Me.lblSubtotal.Text = Format(Val(Me.lblSubtotal.Text), "###,##0.00")

    End Sub
End Class