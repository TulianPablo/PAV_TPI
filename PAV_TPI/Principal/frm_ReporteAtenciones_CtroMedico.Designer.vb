<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteAtenciones_CtroMedico
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DTReporteAtencionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReporte = New PAV_TPI.DsReporte()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.txt_fecHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecDesde = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rpt_atencionesCtroMedico = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DTReporteAtencionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTReporteAtencionesBindingSource
        '
        Me.DTReporteAtencionesBindingSource.DataMember = "DTReporteAtenciones"
        Me.DTReporteAtencionesBindingSource.DataSource = Me.DsReporte
        '
        'DsReporte
        '
        Me.DsReporte.DataSetName = "DsReporte"
        Me.DsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(364, 21)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(84, 23)
        Me.btn_generar.TabIndex = 10
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'txt_fecHasta
        '
        Me.txt_fecHasta.Location = New System.Drawing.Point(258, 24)
        Me.txt_fecHasta.Mask = "00/00/0000"
        Me.txt_fecHasta.Name = "txt_fecHasta"
        Me.txt_fecHasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecHasta.TabIndex = 9
        Me.txt_fecHasta.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta:"
        '
        'txt_fecDesde
        '
        Me.txt_fecDesde.Location = New System.Drawing.Point(108, 24)
        Me.txt_fecDesde.Mask = "00/00/0000"
        Me.txt_fecDesde.Name = "txt_fecDesde"
        Me.txt_fecDesde.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecDesde.TabIndex = 7
        Me.txt_fecDesde.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Desde:"
        '
        'rpt_atencionesCtroMedico
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DTReporteAtencionesBindingSource
        Me.rpt_atencionesCtroMedico.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_atencionesCtroMedico.LocalReport.ReportEmbeddedResource = "PAV_TPI.ReporteAtencionesPorCentroMedico.rdlc"
        Me.rpt_atencionesCtroMedico.Location = New System.Drawing.Point(31, 63)
        Me.rpt_atencionesCtroMedico.Name = "rpt_atencionesCtroMedico"
        Me.rpt_atencionesCtroMedico.Size = New System.Drawing.Size(496, 305)
        Me.rpt_atencionesCtroMedico.TabIndex = 11
        '
        'frm_ReporteAtenciones_CtroMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 393)
        Me.Controls.Add(Me.rpt_atencionesCtroMedico)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.txt_fecHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fecDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ReporteAtenciones_CtroMedico"
        Me.Text = "Reporte de Atenciones por Centro Medico"
        CType(Me.DTReporteAtencionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents txt_fecHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fecDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rpt_atencionesCtroMedico As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTReporteAtencionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReporte As PAV_TPI.DsReporte
End Class
