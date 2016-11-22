<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AtencionMedica
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
        Me.lbl_nroAtencion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.txt_nro_atencion = New System.Windows.Forms.TextBox()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_apellidoNombre = New System.Windows.Forms.Label()
        Me.txt_apellidoNombre = New System.Windows.Forms.TextBox()
        Me.btn_BuscarAfiliado = New System.Windows.Forms.Button()
        Me.lbl_mensajeAfiliado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_porcDescuento = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_porcDescuento = New System.Windows.Forms.TextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.dgv_practicas = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_practica = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_practica = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.lbl_datosObligatorios = New System.Windows.Forms.Label()
        Me.lbl_mensajeCentro = New System.Windows.Forms.Label()
        Me.lbl_mensajeProfesional = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_mensajeRegistracion = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.cbo_profesional = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_ctroMedico = New System.Windows.Forms.ComboBox()
        Me.lbl_mensajeCentroMedico = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nroAtencion
        '
        Me.lbl_nroAtencion.AutoSize = True
        Me.lbl_nroAtencion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroAtencion.Location = New System.Drawing.Point(28, 23)
        Me.lbl_nroAtencion.Name = "lbl_nroAtencion"
        Me.lbl_nroAtencion.Size = New System.Drawing.Size(84, 15)
        Me.lbl_nroAtencion.TabIndex = 22
        Me.lbl_nroAtencion.Text = "Nro. Atención "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fecha"
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(31, 240)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(71, 13)
        Me.lbl_especialidad.TabIndex = 25
        Me.lbl_especialidad.Text = "Especialidad"
        '
        'txt_nro_atencion
        '
        Me.txt_nro_atencion.Location = New System.Drawing.Point(144, 23)
        Me.txt_nro_atencion.Name = "txt_nro_atencion"
        Me.txt_nro_atencion.Size = New System.Drawing.Size(76, 22)
        Me.txt_nro_atencion.TabIndex = 7
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(130, 237)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(264, 21)
        Me.cbo_especialidad.TabIndex = 3
        '
        'btn_registrar
        '
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrar.Location = New System.Drawing.Point(327, 559)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(92, 32)
        Me.btn_registrar.TabIndex = 5
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nro. Documento"
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(123, 22)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(89, 21)
        Me.cbo_tipoDoc.TabIndex = 0
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(326, 25)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(98, 22)
        Me.txt_nroDoc.TabIndex = 1
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(10, 27)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(97, 15)
        Me.lbl_tipoDoc.TabIndex = 3
        Me.lbl_tipoDoc.Text = "Tipo Documento"
        '
        'lbl_apellidoNombre
        '
        Me.lbl_apellidoNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidoNombre.Location = New System.Drawing.Point(10, 53)
        Me.lbl_apellidoNombre.Name = "lbl_apellidoNombre"
        Me.lbl_apellidoNombre.Size = New System.Drawing.Size(122, 22)
        Me.lbl_apellidoNombre.TabIndex = 0
        Me.lbl_apellidoNombre.Text = "Apellido y Nombre"
        '
        'txt_apellidoNombre
        '
        Me.txt_apellidoNombre.Location = New System.Drawing.Point(123, 53)
        Me.txt_apellidoNombre.Name = "txt_apellidoNombre"
        Me.txt_apellidoNombre.Size = New System.Drawing.Size(384, 22)
        Me.txt_apellidoNombre.TabIndex = 3
        '
        'btn_BuscarAfiliado
        '
        Me.btn_BuscarAfiliado.Location = New System.Drawing.Point(451, 20)
        Me.btn_BuscarAfiliado.Name = "btn_BuscarAfiliado"
        Me.btn_BuscarAfiliado.Size = New System.Drawing.Size(59, 23)
        Me.btn_BuscarAfiliado.TabIndex = 2
        Me.btn_BuscarAfiliado.Text = "Buscar"
        Me.btn_BuscarAfiliado.UseVisualStyleBackColor = True
        '
        'lbl_mensajeAfiliado
        '
        Me.lbl_mensajeAfiliado.AutoSize = True
        Me.lbl_mensajeAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeAfiliado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeAfiliado.Location = New System.Drawing.Point(295, 78)
        Me.lbl_mensajeAfiliado.Name = "lbl_mensajeAfiliado"
        Me.lbl_mensajeAfiliado.Size = New System.Drawing.Size(129, 17)
        Me.lbl_mensajeAfiliado.TabIndex = 18
        Me.lbl_mensajeAfiliado.Text = "lbl_mensajeAfiliado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_mensajeAfiliado)
        Me.GroupBox1.Controls.Add(Me.btn_BuscarAfiliado)
        Me.GroupBox1.Controls.Add(Me.txt_apellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbl_apellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.cbo_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 98)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Afiliado"
        '
        'lbl_porcDescuento
        '
        Me.lbl_porcDescuento.AutoSize = True
        Me.lbl_porcDescuento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_porcDescuento.Location = New System.Drawing.Point(148, 58)
        Me.lbl_porcDescuento.Name = "lbl_porcDescuento"
        Me.lbl_porcDescuento.Size = New System.Drawing.Size(137, 15)
        Me.lbl_porcDescuento.TabIndex = 3
        Me.lbl_porcDescuento.Text = "Porcentaje de descuento"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(69, 55)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(59, 22)
        Me.txt_precio.TabIndex = 2
        '
        'txt_porcDescuento
        '
        Me.txt_porcDescuento.Location = New System.Drawing.Point(291, 55)
        Me.txt_porcDescuento.Name = "txt_porcDescuento"
        Me.txt_porcDescuento.Size = New System.Drawing.Size(59, 22)
        Me.txt_porcDescuento.TabIndex = 4
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(17, 58)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(40, 15)
        Me.lbl_precio.TabIndex = 13
        Me.lbl_precio.Text = "Precio"
        '
        'dgv_practicas
        '
        Me.dgv_practicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_fecha, Me.col_nroAtencion, Me.col_Practica, Me.col_precio, Me.col_porcentaje, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(13, 129)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.Size = New System.Drawing.Size(632, 129)
        Me.dgv_practicas.TabIndex = 17
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id "
        Me.col_id.Name = "col_id"
        '
        'col_fecha
        '
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = False
        '
        'col_nroAtencion
        '
        Me.col_nroAtencion.HeaderText = "Nro. Atencion "
        Me.col_nroAtencion.Name = "col_nroAtencion"
        Me.col_nroAtencion.Visible = False
        '
        'col_Practica
        '
        Me.col_Practica.HeaderText = "Practica"
        Me.col_Practica.Name = "col_Practica"
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio"
        Me.col_precio.Name = "col_precio"
        '
        'col_porcentaje
        '
        Me.col_porcentaje.HeaderText = "% Descuento"
        Me.col_porcentaje.Name = "col_porcentaje"
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "Subtotal"
        Me.col_subtotal.Name = "col_subtotal"
        '
        'cbo_practica
        '
        Me.cbo_practica.FormattingEnabled = True
        Me.cbo_practica.Location = New System.Drawing.Point(69, 21)
        Me.cbo_practica.Name = "cbo_practica"
        Me.cbo_practica.Size = New System.Drawing.Size(264, 21)
        Me.cbo_practica.TabIndex = 0
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(553, 82)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(92, 32)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_practica
        '
        Me.lbl_practica.AutoSize = True
        Me.lbl_practica.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_practica.Location = New System.Drawing.Point(17, 29)
        Me.lbl_practica.Name = "lbl_practica"
        Me.lbl_practica.Size = New System.Drawing.Size(49, 15)
        Me.lbl_practica.TabIndex = 0
        Me.lbl_practica.Text = "Practica"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(371, 58)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(51, 15)
        Me.lbl_subtotal.TabIndex = 5
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(423, 55)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(59, 22)
        Me.txt_subtotal.TabIndex = 6
        '
        'lbl_datosObligatorios
        '
        Me.lbl_datosObligatorios.AutoSize = True
        Me.lbl_datosObligatorios.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosObligatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_datosObligatorios.Location = New System.Drawing.Point(17, 90)
        Me.lbl_datosObligatorios.Name = "lbl_datosObligatorios"
        Me.lbl_datosObligatorios.Size = New System.Drawing.Size(139, 17)
        Me.lbl_datosObligatorios.TabIndex = 21
        Me.lbl_datosObligatorios.Text = "lbl_datosObligatorios"
        '
        'lbl_mensajeCentro
        '
        Me.lbl_mensajeCentro.AutoSize = True
        Me.lbl_mensajeCentro.Location = New System.Drawing.Point(307, 88)
        Me.lbl_mensajeCentro.Name = "lbl_mensajeCentro"
        Me.lbl_mensajeCentro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensajeCentro.TabIndex = 39
        '
        'lbl_mensajeProfesional
        '
        Me.lbl_mensajeProfesional.AutoSize = True
        Me.lbl_mensajeProfesional.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeProfesional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeProfesional.Location = New System.Drawing.Point(316, 204)
        Me.lbl_mensajeProfesional.Name = "lbl_mensajeProfesional"
        Me.lbl_mensajeProfesional.Size = New System.Drawing.Size(149, 17)
        Me.lbl_mensajeProfesional.TabIndex = 41
        Me.lbl_mensajeProfesional.Text = "lbl_mensajeProfesional"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(214, 559)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(92, 32)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_mensajeRegistracion
        '
        Me.lbl_mensajeRegistracion.AutoSize = True
        Me.lbl_mensajeRegistracion.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeRegistracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeRegistracion.Location = New System.Drawing.Point(64, 603)
        Me.lbl_mensajeRegistracion.Name = "lbl_mensajeRegistracion"
        Me.lbl_mensajeRegistracion.Size = New System.Drawing.Size(156, 17)
        Me.lbl_mensajeRegistracion.TabIndex = 43
        Me.lbl_mensajeRegistracion.Text = "lbl_mensajeRegistracion"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(423, 90)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(62, 22)
        Me.txt_total.TabIndex = 7
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(371, 92)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(32, 13)
        Me.lbl_total.TabIndex = 23
        Me.lbl_total.Text = "Total"
        '
        'cbo_profesional
        '
        Me.cbo_profesional.FormattingEnabled = True
        Me.cbo_profesional.Location = New System.Drawing.Point(130, 205)
        Me.cbo_profesional.Name = "cbo_profesional"
        Me.cbo_profesional.Size = New System.Drawing.Size(162, 21)
        Me.cbo_profesional.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Profesional"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(574, 23)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(106, 22)
        Me.dtp_fecha.TabIndex = 49
        Me.dtp_fecha.Value = New Date(2016, 10, 25, 14, 15, 48, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Centro Médico"
        '
        'cbo_ctroMedico
        '
        Me.cbo_ctroMedico.FormattingEnabled = True
        Me.cbo_ctroMedico.Location = New System.Drawing.Point(144, 59)
        Me.cbo_ctroMedico.Name = "cbo_ctroMedico"
        Me.cbo_ctroMedico.Size = New System.Drawing.Size(162, 21)
        Me.cbo_ctroMedico.TabIndex = 0
        '
        'lbl_mensajeCentroMedico
        '
        Me.lbl_mensajeCentroMedico.AutoSize = True
        Me.lbl_mensajeCentroMedico.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeCentroMedico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeCentroMedico.Location = New System.Drawing.Point(316, 68)
        Me.lbl_mensajeCentroMedico.Name = "lbl_mensajeCentroMedico"
        Me.lbl_mensajeCentroMedico.Size = New System.Drawing.Size(163, 17)
        Me.lbl_mensajeCentroMedico.TabIndex = 52
        Me.lbl_mensajeCentroMedico.Text = "lbl_mensajeCentroMédico"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.dgv_practicas)
        Me.GroupBox2.Controls.Add(Me.lbl_practica)
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.cbo_practica)
        Me.GroupBox2.Controls.Add(Me.lbl_total)
        Me.GroupBox2.Controls.Add(Me.lbl_precio)
        Me.GroupBox2.Controls.Add(Me.txt_porcDescuento)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.lbl_datosObligatorios)
        Me.GroupBox2.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox2.Controls.Add(Me.txt_subtotal)
        Me.GroupBox2.Controls.Add(Me.lbl_porcDescuento)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 264)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Practicas"
        '
        'frm_AtencionMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_mensajeProfesional)
        Me.Controls.Add(Me.cbo_profesional)
        Me.Controls.Add(Me.lbl_mensajeCentroMedico)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_ctroMedico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_mensajeRegistracion)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_mensajeCentro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.cbo_especialidad)
        Me.Controls.Add(Me.txt_nro_atencion)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nroAtencion)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_AtencionMedica"
        Me.Text = "Atención Médica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nroAtencion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents txt_nro_atencion As System.Windows.Forms.TextBox
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoNombre As System.Windows.Forms.Label
    Friend WithEvents txt_apellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarAfiliado As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeAfiliado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_porcDescuento As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_porcDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents dgv_practicas As System.Windows.Forms.DataGridView
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbo_practica As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_practica As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_datosObligatorios As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeCentro As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeProfesional As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeRegistracion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_ctroMedico As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_mensajeCentroMedico As System.Windows.Forms.Label
    Friend WithEvents cbo_profesional As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
