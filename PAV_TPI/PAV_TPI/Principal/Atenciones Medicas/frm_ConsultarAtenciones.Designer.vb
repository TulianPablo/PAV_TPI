<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultarAtenciones
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
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.dtp_fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgv_atenciones = New System.Windows.Forms.DataGridView()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_afiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CentroMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Profesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCentroMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_tipodoc = New System.Windows.Forms.ComboBox()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.lbl_fechaDesde = New System.Windows.Forms.Label()
        Me.txt_nroAtencion = New System.Windows.Forms.TextBox()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.cmb_tipodoc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nroAtencion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_mensajeAtenciones = New System.Windows.Forms.Label()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(139, 76)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(97, 23)
        Me.txt_matricula.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 32
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(139, 121)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(180, 23)
        Me.cbo_especialidad.TabIndex = 31
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_consultar.Location = New System.Drawing.Point(713, 150)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(105, 37)
        Me.btn_consultar.TabIndex = 30
        Me.btn_consultar.Text = "BUSCAR"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'dtp_fechaHasta
        '
        Me.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaHasta.Location = New System.Drawing.Point(639, 81)
        Me.dtp_fechaHasta.Name = "dtp_fechaHasta"
        Me.dtp_fechaHasta.Size = New System.Drawing.Size(181, 23)
        Me.dtp_fechaHasta.TabIndex = 29
        '
        'dtp_fechaDesde
        '
        Me.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaDesde.Location = New System.Drawing.Point(639, 32)
        Me.dtp_fechaDesde.Name = "dtp_fechaDesde"
        Me.dtp_fechaDesde.Size = New System.Drawing.Size(181, 23)
        Me.dtp_fechaDesde.TabIndex = 28
        '
        'dgv_atenciones
        '
        Me.dgv_atenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_atenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha, Me.col_nroAtencion, Me.col_afiliado, Me.col_CentroMedico, Me.col_Profesional, Me.col_especialidad, Me.col_nroCentroMedico, Me.col_total})
        Me.dgv_atenciones.Location = New System.Drawing.Point(24, 207)
        Me.dgv_atenciones.Name = "dgv_atenciones"
        Me.dgv_atenciones.Size = New System.Drawing.Size(796, 205)
        Me.dgv_atenciones.TabIndex = 27
        '
        'col_fecha
        '
        Me.col_fecha.FillWeight = 70.0!
        Me.col_fecha.HeaderText = "Fecha "
        Me.col_fecha.Name = "col_fecha"
        '
        'col_nroAtencion
        '
        Me.col_nroAtencion.HeaderText = "Nro. Atencion "
        Me.col_nroAtencion.Name = "col_nroAtencion"
        '
        'col_afiliado
        '
        Me.col_afiliado.HeaderText = "Afiliado"
        Me.col_afiliado.Name = "col_afiliado"
        '
        'col_CentroMedico
        '
        Me.col_CentroMedico.HeaderText = "Centro Medico"
        Me.col_CentroMedico.Name = "col_CentroMedico"
        '
        'col_Profesional
        '
        Me.col_Profesional.HeaderText = "Profesional"
        Me.col_Profesional.Name = "col_Profesional"
        '
        'col_especialidad
        '
        Me.col_especialidad.HeaderText = "Especialidad"
        Me.col_especialidad.Name = "col_especialidad"
        '
        'col_nroCentroMedico
        '
        Me.col_nroCentroMedico.HeaderText = "nro_centroMedico"
        Me.col_nroCentroMedico.Name = "col_nroCentroMedico"
        Me.col_nroCentroMedico.Visible = False
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        '
        'cbo_tipodoc
        '
        Me.cbo_tipodoc.FormattingEnabled = True
        Me.cbo_tipodoc.Location = New System.Drawing.Point(393, 32)
        Me.cbo_tipodoc.Name = "cbo_tipodoc"
        Me.cbo_tipodoc.Size = New System.Drawing.Size(118, 23)
        Me.cbo_tipodoc.TabIndex = 25
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(540, 81)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(71, 15)
        Me.lbl_fechaHasta.TabIndex = 24
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        '
        'lbl_fechaDesde
        '
        Me.lbl_fechaDesde.AutoSize = True
        Me.lbl_fechaDesde.Location = New System.Drawing.Point(537, 32)
        Me.lbl_fechaDesde.Name = "lbl_fechaDesde"
        Me.lbl_fechaDesde.Size = New System.Drawing.Size(73, 15)
        Me.lbl_fechaDesde.TabIndex = 23
        Me.lbl_fechaDesde.Text = "Fecha Desde"
        '
        'txt_nroAtencion
        '
        Me.txt_nroAtencion.Location = New System.Drawing.Point(139, 36)
        Me.txt_nroAtencion.Name = "txt_nroAtencion"
        Me.txt_nroAtencion.Size = New System.Drawing.Size(97, 23)
        Me.txt_nroAtencion.TabIndex = 22
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Location = New System.Drawing.Point(281, 75)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(93, 15)
        Me.lbl_nroDoc.TabIndex = 21
        Me.lbl_nroDoc.Text = "Nro Documento"
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.AutoSize = True
        Me.cmb_tipodoc.Location = New System.Drawing.Point(281, 36)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(97, 15)
        Me.cmb_tipodoc.TabIndex = 20
        Me.cmb_tipodoc.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Matrícula "
        '
        'lbl_nroAtencion
        '
        Me.lbl_nroAtencion.AutoSize = True
        Me.lbl_nroAtencion.Location = New System.Drawing.Point(29, 38)
        Me.lbl_nroAtencion.Name = "lbl_nroAtencion"
        Me.lbl_nroAtencion.Size = New System.Drawing.Size(81, 15)
        Me.lbl_nroAtencion.TabIndex = 19
        Me.lbl_nroAtencion.Text = "Nro. Atención"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 16
        '
        'lbl_mensajeAtenciones
        '
        Me.lbl_mensajeAtenciones.AutoSize = True
        Me.lbl_mensajeAtenciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_mensajeAtenciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeAtenciones.Location = New System.Drawing.Point(34, 168)
        Me.lbl_mensajeAtenciones.Name = "lbl_mensajeAtenciones"
        Me.lbl_mensajeAtenciones.Size = New System.Drawing.Size(147, 17)
        Me.lbl_mensajeAtenciones.TabIndex = 34
        Me.lbl_mensajeAtenciones.Text = "lbl_mensajeAtenciones"
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(393, 71)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(118, 23)
        Me.txt_nroDoc.TabIndex = 35
        '
        'btn_registrar
        '
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrar.Location = New System.Drawing.Point(24, 425)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(105, 37)
        Me.btn_registrar.TabIndex = 36
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'frm_ConsultarAtenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 477)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_nroDoc)
        Me.Controls.Add(Me.lbl_mensajeAtenciones)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_especialidad)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.dtp_fechaHasta)
        Me.Controls.Add(Me.dtp_fechaDesde)
        Me.Controls.Add(Me.dgv_atenciones)
        Me.Controls.Add(Me.cbo_tipodoc)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.lbl_fechaDesde)
        Me.Controls.Add(Me.txt_nroAtencion)
        Me.Controls.Add(Me.lbl_nroDoc)
        Me.Controls.Add(Me.cmb_tipodoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nroAtencion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_ConsultarAtenciones"
        Me.Text = "frm_ConsultarAtenciones"
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents dtp_fechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_atenciones As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_fechaHasta As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaDesde As System.Windows.Forms.Label
    Friend WithEvents txt_nroAtencion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_nroAtencion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeAtenciones As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_afiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CentroMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Profesional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroCentroMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
End Class
