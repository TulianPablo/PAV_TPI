<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultarAtenciones
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
        Me.lbl_nroAtencion = New System.Windows.Forms.Label()
        Me.cmb_tipodoc = New System.Windows.Forms.Label()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.txt_nroAtencion = New System.Windows.Forms.TextBox()
        Me.lbl_fechaDesde = New System.Windows.Forms.Label()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.cbo_tipodoc = New System.Windows.Forms.ComboBox()
        Me.txt_nroDoc = New System.Windows.Forms.TextBox()
        Me.AfiliacionTableAdapter1 = New PAV_TPI.DB_TPIDataSetTableAdapters.AfiliacionTableAdapter()
        Me.dgv_atenciones = New System.Windows.Forms.DataGridView()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CentroMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Profesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_fechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'lbl_nroAtencion
        '
        Me.lbl_nroAtencion.AutoSize = True
        Me.lbl_nroAtencion.Location = New System.Drawing.Point(26, 31)
        Me.lbl_nroAtencion.Name = "lbl_nroAtencion"
        Me.lbl_nroAtencion.Size = New System.Drawing.Size(72, 13)
        Me.lbl_nroAtencion.TabIndex = 1
        Me.lbl_nroAtencion.Text = "Nro. Atención"
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.AutoSize = True
        Me.cmb_tipodoc.Location = New System.Drawing.Point(26, 74)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(86, 13)
        Me.cmb_tipodoc.TabIndex = 2
        Me.cmb_tipodoc.Text = "Tipo Documento"
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Location = New System.Drawing.Point(278, 65)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(82, 13)
        Me.lbl_nroDoc.TabIndex = 3
        Me.lbl_nroDoc.Text = "Nro Documento"
        '
        'txt_nroAtencion
        '
        Me.txt_nroAtencion.Location = New System.Drawing.Point(126, 31)
        Me.txt_nroAtencion.Name = "txt_nroAtencion"
        Me.txt_nroAtencion.Size = New System.Drawing.Size(131, 20)
        Me.txt_nroAtencion.TabIndex = 4
        '
        'lbl_fechaDesde
        '
        Me.lbl_fechaDesde.AutoSize = True
        Me.lbl_fechaDesde.Location = New System.Drawing.Point(537, 31)
        Me.lbl_fechaDesde.Name = "lbl_fechaDesde"
        Me.lbl_fechaDesde.Size = New System.Drawing.Size(71, 13)
        Me.lbl_fechaDesde.TabIndex = 5
        Me.lbl_fechaDesde.Text = "Fecha Desde"
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(540, 74)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(68, 13)
        Me.lbl_fechaHasta.TabIndex = 6
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        '
        'cbo_tipodoc
        '
        Me.cbo_tipodoc.FormattingEnabled = True
        Me.cbo_tipodoc.Location = New System.Drawing.Point(126, 65)
        Me.cbo_tipodoc.Name = "cbo_tipodoc"
        Me.cbo_tipodoc.Size = New System.Drawing.Size(131, 21)
        Me.cbo_tipodoc.TabIndex = 7
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(374, 62)
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(131, 20)
        Me.txt_nroDoc.TabIndex = 8
        '
        'AfiliacionTableAdapter1
        '
        Me.AfiliacionTableAdapter1.ClearBeforeFill = True
        '
        'dgv_atenciones
        '
        Me.dgv_atenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_atenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha, Me.col_nroAtencion, Me.col_apellido, Me.col_Nombre, Me.col_CentroMedico, Me.col_Profesional, Me.col_especialidad})
        Me.dgv_atenciones.Location = New System.Drawing.Point(33, 189)
        Me.dgv_atenciones.Name = "dgv_atenciones"
        Me.dgv_atenciones.Size = New System.Drawing.Size(741, 201)
        Me.dgv_atenciones.TabIndex = 9
        '
        'col_fecha
        '
        Me.col_fecha.HeaderText = "Fecha "
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Width = 90
        '
        'col_nroAtencion
        '
        Me.col_nroAtencion.HeaderText = "Nro. Atencion "
        Me.col_nroAtencion.Name = "col_nroAtencion"
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        '
        'col_Nombre
        '
        Me.col_Nombre.HeaderText = "Nombre"
        Me.col_Nombre.Name = "col_Nombre"
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
        'dtp_fechaDesde
        '
        Me.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaDesde.Location = New System.Drawing.Point(625, 31)
        Me.dtp_fechaDesde.Name = "dtp_fechaDesde"
        Me.dtp_fechaDesde.Size = New System.Drawing.Size(156, 20)
        Me.dtp_fechaDesde.TabIndex = 10
        '
        'dtp_fechaHasta
        '
        Me.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaHasta.Location = New System.Drawing.Point(625, 74)
        Me.dtp_fechaHasta.Name = "dtp_fechaHasta"
        Me.dtp_fechaHasta.Size = New System.Drawing.Size(156, 20)
        Me.dtp_fechaHasta.TabIndex = 10
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_consultar.Location = New System.Drawing.Point(684, 136)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(90, 32)
        Me.btn_consultar.TabIndex = 11
        Me.btn_consultar.Text = "BUSCAR"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matricula "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Especialidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 13
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(368, 24)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(137, 20)
        Me.txt_matricula.TabIndex = 15
        '
        'frm_ConsultarAtenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 443)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.dtp_fechaHasta)
        Me.Controls.Add(Me.dtp_fechaDesde)
        Me.Controls.Add(Me.dgv_atenciones)
        Me.Controls.Add(Me.txt_nroDoc)
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
        Me.Name = "frm_ConsultarAtenciones"
        Me.Text = "Consultar Atenciones Medicas"
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nroAtencion As System.Windows.Forms.Label
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents txt_nroAtencion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaDesde As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaHasta As System.Windows.Forms.Label
    Friend WithEvents cbo_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.TextBox
    Friend WithEvents AfiliacionTableAdapter1 As PAV_TPI.DB_TPIDataSetTableAdapters.AfiliacionTableAdapter
    Friend WithEvents dgv_atenciones As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_fechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CentroMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Profesional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
End Class
