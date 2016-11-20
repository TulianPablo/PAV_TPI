<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoEstadístico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DTReporteEstadisticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReporte = New PAV_TPI.DsReporte()
        Me.rpt_estadistico = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_ctrosMedico = New System.Windows.Forms.ComboBox()
        CType(Me.DTReporteEstadisticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTReporteEstadisticoBindingSource
        '
        Me.DTReporteEstadisticoBindingSource.DataMember = "DTReporteEstadistico"
        Me.DTReporteEstadisticoBindingSource.DataSource = Me.DsReporte
        '
        'DsReporte
        '
        Me.DsReporte.DataSetName = "DsReporte"
        Me.DsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_estadistico
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DTReporteEstadisticoBindingSource
        Me.rpt_estadistico.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_estadistico.LocalReport.ReportEmbeddedResource = "PAV_TPI.ReporteEstadistico.rdlc"
        Me.rpt_estadistico.Location = New System.Drawing.Point(13, 55)
        Me.rpt_estadistico.Name = "rpt_estadistico"
        Me.rpt_estadistico.Size = New System.Drawing.Size(633, 524)
        Me.rpt_estadistico.TabIndex = 15
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(247, 16)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 14
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Centro Médico"
        '
        'cbo_ctrosMedico
        '
        Me.cbo_ctrosMedico.FormattingEnabled = True
        Me.cbo_ctrosMedico.Location = New System.Drawing.Point(97, 18)
        Me.cbo_ctrosMedico.Name = "cbo_ctrosMedico"
        Me.cbo_ctrosMedico.Size = New System.Drawing.Size(144, 21)
        Me.cbo_ctrosMedico.TabIndex = 16
        '
        'frm_ListadoEstadístico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 591)
        Me.Controls.Add(Me.cbo_ctrosMedico)
        Me.Controls.Add(Me.rpt_estadistico)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ListadoEstadístico"
        Me.Text = "ListadoEstadístico"
        CType(Me.DTReporteEstadisticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rpt_estadistico As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_ctrosMedico As System.Windows.Forms.ComboBox
    Friend WithEvents DTReporteEstadisticoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReporte As PAV_TPI.DsReporte
End Class
