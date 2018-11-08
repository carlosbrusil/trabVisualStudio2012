Public Class Ejercicio3

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If Trim(txtNombre.Text) = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtTelefono.Focus()
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtCE.Focus()
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtCE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtOBSERVACIONES.Focus()
        End If
    End Sub

    Private Sub txtCE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCE.TextChanged

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim RES As MsgBoxResult
        RES = MsgBox("Desea salir de la aplicacion ", MsgBoxStyle.YesNo, "Sistema")
        If RES = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnNuevo.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtNombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtCE.Text = ""
        Me.txtOBSERVACIONES.Text = ""
        Me.txtNombre.Focus()

    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Me.Close()
    End Sub
End Class
