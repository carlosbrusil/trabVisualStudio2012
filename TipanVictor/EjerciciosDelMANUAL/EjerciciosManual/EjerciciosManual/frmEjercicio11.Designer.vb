<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio11
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcu = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnExplorador = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Programas a ejecutar"
        '
        'btnCalcu
        '
        Me.btnCalcu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcu.Location = New System.Drawing.Point(185, 131)
        Me.btnCalcu.Name = "btnCalcu"
        Me.btnCalcu.Size = New System.Drawing.Size(224, 42)
        Me.btnCalcu.TabIndex = 15
        Me.btnCalcu.Text = "Calculadora Electrónica"
        Me.btnCalcu.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(185, 275)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(224, 42)
        Me.btnExcel.TabIndex = 17
        Me.btnExcel.Text = "Microsoft Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnExplorador
        '
        Me.btnExplorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplorador.Location = New System.Drawing.Point(185, 344)
        Me.btnExplorador.Name = "btnExplorador"
        Me.btnExplorador.Size = New System.Drawing.Size(224, 42)
        Me.btnExplorador.TabIndex = 18
        Me.btnExplorador.Text = "Explorador de Windows"
        Me.btnExplorador.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(185, 411)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(224, 42)
        Me.btnDos.TabIndex = 19
        Me.btnDos.Text = "Simbolo del Sistema"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(242, 474)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 42)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnWord
        '
        Me.btnWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWord.Location = New System.Drawing.Point(185, 206)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(224, 42)
        Me.btnWord.TabIndex = 21
        Me.btnWord.Text = "Microsoft Word"
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'frmEjercicio11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 545)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnExplorador)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnCalcu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USO DE SHELL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalcu As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnExplorador As System.Windows.Forms.Button
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnWord As System.Windows.Forms.Button
End Class
