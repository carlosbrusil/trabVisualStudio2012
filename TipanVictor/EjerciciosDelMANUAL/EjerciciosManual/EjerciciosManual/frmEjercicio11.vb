Public Class frmEjercicio11

    Private Sub btnCalcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcu.Click
        Shell("c:\windows\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWord.Click
        Shell("c:\Archivos de programa\Microsoft Office\Office14\winword.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Shell("c:\Archivos de programa\Microsoft Office\Office14\excel.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnExplorador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorador.Click
        Shell("c:\windows\explorer.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        Shell("c:\windows\system32\cmd.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If (MsgBox("Deseas salir de la aplicacion", MsgBoxStyle.YesNo, "Uso de Shell") = MsgBoxResult.Yes) Then
            Me.Close()
        End If

    End Sub
End Class