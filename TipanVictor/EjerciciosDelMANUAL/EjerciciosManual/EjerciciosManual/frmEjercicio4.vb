Public Class frmEjercicio4

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmEjercicio4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub

    Private Sub frmEjercicio4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Function Mayuscula(ByVal v As Integer) As Boolean
        If v >= 65 And v <= 90 Then
            Mayuscula = True
        Else
            Mayuscula = False
        End If
    End Function
    Function Minuscula(ByVal v As Integer) As Boolean
        If v >= 97 And v <= 122 Then
            Minuscula = True
        Else
            Minuscula = False
        End If


    End Function
    Function Numero(ByVal v As Integer) As Boolean
        If v < 48 Or v > 57 Then
            Numero = False
        Else
            Numero = True
        End If
    End Function
    Function Especial(ByVal v As Integer) As Boolean
        If (v = 13 Or v = 8 Or v = 32 Or v = 225 Or v = 233 Or v = 237 Or v = 243 Or v = 250 Or v = 241 Or v = 209) Then
            Especial = True
        Else
            Especial = False
        End If
    End Function
    Sub Ingresados()
        If (Trim(Me.txtApeNom.Text) <> "" And IsDate(Me.txtFecNac.Text) And Trim(Me.txtTurno.Text) <> "" And Trim(Me.txtProm.Text) <> "") Then
            btnNuevo.Enabled = True
            btnSalir.Enabled = True
        Else
            btnNuevo.Enabled = False
            btnSalir.Enabled = False
        End If

    End Sub
    Sub Limpiar()
        Me.txtApeNom.Text = ""
        Me.txtFecNac.Text = ""
        Me.txtProm.Text = ""
        Me.txtTurno.Text = ""
        Me.btnNuevo.Enabled = False
        Me.btnSalir.Enabled = False
        Me.txtApeNom.Focus()
    End Sub

    Private Sub txtApeNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApeNom.KeyPress
        Static anteriorespacio As Boolean
        If Asc(e.KeyChar) = 13 Then
            Me.txtFecNac.Focus()
        End If
        If Asc(e.KeyChar) = 32 Then
            anteriorespacio = True
        Else
            If Mayuscula(Asc(e.KeyChar)) Or Minuscula(Asc(e.KeyChar)) Or Especial(Asc(e.KeyChar)) Then
                If Trim(e.KeyChar) = "" Or anteriorespacio Then
                    ' convertir a mayuscula
                    e.KeyChar = UCase(e.KeyChar)
                Else
                    ' convierte a minuscula
                    e.KeyChar = LCase(e.KeyChar)
                End If
                anteriorespacio = False
            Else
                MsgBox("debe ingresar solo letras", MsgBoxStyle.Information, "cuidado")
                e.KeyChar = ChrW(0)
                Me.btnNuevo.Enabled = False
                Me.btnSalir.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtApeNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApeNom.TextChanged
        Ingresados()
    End Sub

    Private Sub txtFecNac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecNac.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtTurno.Focus()
        End If
    End Sub

    Private Sub txtFecNac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecNac.LostFocus
        If IsDate(Me.txtFecNac.Text) Then
            Ingresados()
        Else
            MsgBox("debe ingresar una fecha", MsgBoxStyle.Information, "cuidado")
            Me.txtFecNac.SelectionStart = 0
            Me.txtFecNac.SelectionLength = Len(Me.txtFecNac.Text)
            Me.txtFecNac.Text = Me.txtFecNac.Text
            Me.txtFecNac.Focus()
        End If
    End Sub

    Private Sub txtFecNac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecNac.TextChanged

    End Sub

    Private Sub txtTurno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTurno.KeyPress
        Dim letra As String
        If Asc(e.KeyChar) = 13 Then
            Me.txtProm.Focus()
        Else
            letra = UCase(e.KeyChar)
            If letra = "M" Or letra = "T" Or letra = "N" Or Asc(e.KeyChar) = 8 Then
                'convierte a mayuscula
                e.KeyChar = UCase(e.KeyChar)
            Else
                MsgBox("debe ingresar solo letras M, T o N ", MsgBoxStyle.Information, "ERROR")
                ' ignorar el caracter ingresado
                e.KeyChar = ChrW(0)
                Me.btnNuevo.Enabled = False
                Me.btnSalir.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtTurno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTurno.TextChanged
        Ingresados()
    End Sub

    Private Sub txtProm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProm.KeyPress
        If Numero(Asc(e.KeyChar)) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            Ingresados()
        Else
            MsgBox("debe ingresar solo numeros", MsgBoxStyle.Information, "cuidado")
            e.KeyChar = ChrW(0)
            Me.btnSalir.Enabled = False
            Me.btnNuevo.Enabled = False
        End If
    End Sub

    Private Sub txtProm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProm.TextChanged
        If Val(txtProm.Text) < 0 Or Val(txtProm.Text) > 20 Then
            MsgBox("valor debe ser entre 1 y 20 ", MsgBoxStyle.Information, "error")
            Me.txtProm.SelectionStart = 0
            Me.txtProm.SelectionLength = Len(Me.txtProm.Text)
            Me.txtProm.Text = Me.txtProm.SelectedText
            Me.txtProm.Focus()
            Me.btnNuevo.Enabled = False
            Me.btnSalir.Enabled = False
        Else
            Ingresados()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub
End Class