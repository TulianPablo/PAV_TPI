<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MenuReportes
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
        Me.btn_reporteAtencionesCtro = New System.Windows.Forms.Button()
        Me.btn_listadoAtencionesCtroMedico = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_reporteAtencionesCtro
        '
        Me.btn_reporteAtencionesCtro.Location = New System.Drawing.Point(24, 27)
        Me.btn_reporteAtencionesCtro.Name = "btn_reporteAtencionesCtro"
        Me.btn_reporteAtencionesCtro.Size = New System.Drawing.Size(237, 28)
        Me.btn_reporteAtencionesCtro.TabIndex = 0
        Me.btn_reporteAtencionesCtro.Text = "Reporte de atenciones"
        Me.btn_reporteAtencionesCtro.UseVisualStyleBackColor = True
        '
        'btn_listadoAtencionesCtroMedico
        '
        Me.btn_listadoAtencionesCtroMedico.Location = New System.Drawing.Point(24, 75)
        Me.btn_listadoAtencionesCtroMedico.Name = "btn_listadoAtencionesCtroMedico"
        Me.btn_listadoAtencionesCtroMedico.Size = New System.Drawing.Size(237, 28)
        Me.btn_listadoAtencionesCtroMedico.TabIndex = 1
        Me.btn_listadoAtencionesCtroMedico.Text = "Listado de atenciones por centro medico"
        Me.btn_listadoAtencionesCtroMedico.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reporte Estadistico Atenciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_MenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 156)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_listadoAtencionesCtroMedico)
        Me.Controls.Add(Me.btn_reporteAtencionesCtro)
        Me.Name = "frm_MenuReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_reporteAtencionesCtro As System.Windows.Forms.Button
    Friend WithEvents btn_listadoAtencionesCtroMedico As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
