Public Class frmEjercicio5
    Dim cd, cr As Integer
    Dim td, tr, saldo As Single

    Private Sub frmEjercicio5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As MsgBoxResult
        res = MsgBox("desea cerrar el formulario ", MsgBoxStyle.YesNo, "cuidado")
        If res = MsgBoxResult.No Then
            ' respondio que no
            e.Cancel = True
        End If
    End Sub
    Private Sub frmEjercicio5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpia()
    End Sub
    Sub limpia()
        tr = 0
        td = 0
        cr = 0
        cd = 0
        saldo = 0
        Me.txtCliente.Text = ""
        Me.txtMonto.Text = ""
        Me.lblCantDep.Text = ""
        Me.lblCantRet.Text = ""
        Me.lblTotDep.Text = ""
        Me.lblTotRet.Text = ""
        Me.lblSaldo.Text = ""
        Me.btnOK.Visible = True
        Me.btnDeposito.Enabled = False
        Me.btnRetiro.Enabled = False
        Me.txtCliente.ReadOnly = False
        Me.txtMonto.ReadOnly = True
        Me.txtCliente.Focus()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.txtCliente.ReadOnly = True
        Me.txtMonto.ReadOnly = False
        Me.btnOK.Visible = False
        Me.btnDeposito.Enabled = True
        Me.btnRetiro.Enabled = True
        ' leemos desde input
        saldo = Val(InputBox("Ingrese el monto de la cuenta " + Chr(13) + Chr(13) + "la cuenta se apertura con cualquier valor ", "Nueva cuenta", 350))
        Me.lblSaldo.Text = CStr(saldo)
        td = saldo
        cd = 1
        Me.lblCantDep.Text = CStr(cd)
        Me.lblTotDep.Text = CStr(td)
        Me.txtMonto.Focus()

    End Sub

    Private Sub btnDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposito.Click
        Dim deposito As Single
        deposito = CSng(Me.txtMonto.Text)
        td = td + deposito
        cd = cd + 1
        Me.lblCantDep.Text = CStr(cd)
        Me.lblTotDep.Text = CStr(td)
        saldo = CSng(Me.lblSaldo.Text)
        Me.lblSaldo.Text = CStr(saldo + deposito)
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = Len(txtMonto.Text)
        txtMonto.Focus()
    End Sub

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        Dim retiro As Single
        saldo = CSng(Me.lblSaldo.Text)
        retiro = CSng(Me.txtMonto.Text)
        If retiro > saldo Then
            MsgBox("la cantidad a retirar supera el saldo actual ", MsgBoxStyle.Critical, "disculpe")
            Me.txtMonto.Text = ""
            Me.txtMonto.Focus()
        Else
            tr = tr + retiro
            cr = cr + 1
            Me.lblCantRet.Text = CStr(cr)
            Me.lblTotRet.Text = CStr(tr)
            saldo = CSng(Me.lblSaldo.Text)
            Me.lblSaldo.Text = CStr(saldo - retiro)
        End If
        txtMonto.SelectionStart = 0
        txtMonto.SelectionLength = Len(txtMonto.Text)
        txtMonto.Focus()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpia()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged

    End Sub
End Class