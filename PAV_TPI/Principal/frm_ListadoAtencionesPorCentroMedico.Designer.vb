<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoAtencionesPorCentroMedico
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
        Me.DTListadoPorCentroMedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReporte = New PAV_TPI.DsReporte()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rpt_listadoAtencionesPorCentro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbo_ctrosMedico = New System.Windows.Forms.ComboBox()
        CType(Me.DTListadoPorCentroMedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTListadoPorCentroMedicoBindingSource
        '
        Me.DTListadoPorCentroMedicoBindingSource.DataMember = "DTListadoPorCentroMedico"
        Me.DTListadoPorCentroMedicoBindingSource.DataSource = Me.DsReporte
        '
        'DsReporte
        '
        Me.DsReporte.DataSetName = "DsReporte"
        Me.DsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(246, 23)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 6
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Centro Médico"
        '
        'rpt_listadoAtencionesPorCentro
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DTListadoPorCentroMedicoBindingSource
        Me.rpt_listadoAtencionesPorCentro.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_listadoAtencionesPorCentro.LocalReport.ReportEmbeddedResource = "PAV_TPI.ListadoAtencionesCentroMedico.rdlc"
        Me.rpt_listadoAtencionesPorCentro.Location = New System.Drawing.Point(12, 62)
        Me.rpt_listadoAtencionesPorCentro.Name = "rpt_listadoAtencionesPorCentro"
        Me.rpt_listadoAtencionesPorCentro.Size = New System.Drawing.Size(732, 362)
        Me.rpt_listadoAtencionesPorCentro.TabIndex = 7
        '
        'cbo_ctrosMedico
        '
        Me.cbo_ctrosMedico.FormattingEnabled = True
        Me.cbo_ctrosMedico.Location = New System.Drawing.Point(96, 23)
        Me.cbo_ctrosMedico.Name = "cbo_ctrosMedico"
        Me.cbo_ctrosMedico.Size = New System.Drawing.Size(144, 21)
        Me.cbo_ctrosMedico.TabIndex = 9
        '
        'frm_ListadoAtencionesPorCentroMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 436)
        Me.Controls.Add(Me.cbo_ctrosMedico)
        Me.Controls.Add(Me.rpt_listadoAtencionesPorCentro)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ListadoAtencionesPorCentroMedico"
        Me.Text = "Listado de Atenciones por Centro Medico"
        CType(Me.DTListadoPorCentroMedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rpt_listadoAtencionesPorCentro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTListadoPorCentroMedicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReporte As PAV_TPI.DsReporte
    Friend WithEvents cbo_ctrosMedico As System.Windows.Forms.ComboBox
End Class
