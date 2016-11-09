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
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.btn_buscarProfesional = New System.Windows.Forms.Button()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.txt_profesional = New System.Windows.Forms.TextBox()
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
        Me.lbl_mensajeCentroMedicos = New System.Windows.Forms.Label()
        Me.lbl_mensajeProfesional = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_mensajeRegistracion = New System.Windows.Forms.Label()
        Me.btn_buscarCentro = New System.Windows.Forms.Button()
        Me.txt_nroCentro = New System.Windows.Forms.TextBox()
        Me.txt_centroMedico = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_nroCentro = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(552, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fecha"
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(50, 310)
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
        Me.txt_nro_atencion.TabIndex = 27
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(113, 16)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(76, 22)
        Me.txt_matricula.TabIndex = 30
        '
        'btn_buscarProfesional
        '
        Me.btn_buscarProfesional.Location = New System.Drawing.Point(195, 14)
        Me.btn_buscarProfesional.Name = "btn_buscarProfesional"
        Me.btn_buscarProfesional.Size = New System.Drawing.Size(60, 23)
        Me.btn_buscarProfesional.TabIndex = 32
        Me.btn_buscarProfesional.Text = "Buscar"
        Me.btn_buscarProfesional.UseVisualStyleBackColor = True
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(175, 308)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(264, 21)
        Me.cbo_especialidad.TabIndex = 35
        '
        'txt_profesional
        '
        Me.txt_profesional.Location = New System.Drawing.Point(272, 16)
        Me.txt_profesional.Name = "txt_profesional"
        Me.txt_profesional.Size = New System.Drawing.Size(382, 22)
        Me.txt_profesional.TabIndex = 34
        '
        'btn_registrar
        '
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrar.Location = New System.Drawing.Point(239, 609)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(92, 32)
        Me.btn_registrar.TabIndex = 36
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
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(126, 22)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(89, 21)
        Me.cbo_tipoDoc.TabIndex = 12
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(326, 25)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(98, 22)
        Me.txt_nroDoc.TabIndex = 14
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
        Me.lbl_apellidoNombre.Location = New System.Drawing.Point(13, 51)
        Me.lbl_apellidoNombre.Name = "lbl_apellidoNombre"
        Me.lbl_apellidoNombre.Size = New System.Drawing.Size(98, 12)
        Me.lbl_apellidoNombre.TabIndex = 0
        Me.lbl_apellidoNombre.Text = "Apellido y Nombre"
        '
        'txt_apellidoNombre
        '
        Me.txt_apellidoNombre.Location = New System.Drawing.Point(126, 51)
        Me.txt_apellidoNombre.Name = "txt_apellidoNombre"
        Me.txt_apellidoNombre.Size = New System.Drawing.Size(384, 22)
        Me.txt_apellidoNombre.TabIndex = 16
        '
        'btn_BuscarAfiliado
        '
        Me.btn_BuscarAfiliado.Location = New System.Drawing.Point(451, 20)
        Me.btn_BuscarAfiliado.Name = "btn_BuscarAfiliado"
        Me.btn_BuscarAfiliado.Size = New System.Drawing.Size(59, 23)
        Me.btn_BuscarAfiliado.TabIndex = 17
        Me.btn_BuscarAfiliado.Text = "Buscar"
        Me.btn_BuscarAfiliado.UseVisualStyleBackColor = True
        '
        'lbl_mensajeAfiliado
        '
        Me.lbl_mensajeAfiliado.AutoSize = True
        Me.lbl_mensajeAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeAfiliado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeAfiliado.Location = New System.Drawing.Point(263, 81)
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
        Me.GroupBox1.Location = New System.Drawing.Point(18, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 98)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Afiliado"
        '
        'lbl_porcDescuento
        '
        Me.lbl_porcDescuento.AutoSize = True
        Me.lbl_porcDescuento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_porcDescuento.Location = New System.Drawing.Point(157, 56)
        Me.lbl_porcDescuento.Name = "lbl_porcDescuento"
        Me.lbl_porcDescuento.Size = New System.Drawing.Size(137, 15)
        Me.lbl_porcDescuento.TabIndex = 15
        Me.lbl_porcDescuento.Text = "Porcentaje de descuento"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(78, 53)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(59, 23)
        Me.txt_precio.TabIndex = 14
        '
        'txt_porcDescuento
        '
        Me.txt_porcDescuento.Location = New System.Drawing.Point(300, 53)
        Me.txt_porcDescuento.Name = "txt_porcDescuento"
        Me.txt_porcDescuento.Size = New System.Drawing.Size(59, 23)
        Me.txt_porcDescuento.TabIndex = 16
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(26, 56)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(40, 15)
        Me.lbl_precio.TabIndex = 13
        Me.lbl_precio.Text = "Precio"
        '
        'dgv_practicas
        '
        Me.dgv_practicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_fecha, Me.col_nroAtencion, Me.col_Practica, Me.col_precio, Me.col_porcentaje, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(28, 117)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.Size = New System.Drawing.Size(632, 143)
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
        Me.cbo_practica.Location = New System.Drawing.Point(78, 19)
        Me.cbo_practica.Name = "cbo_practica"
        Me.cbo_practica.Size = New System.Drawing.Size(264, 23)
        Me.cbo_practica.TabIndex = 12
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(543, 70)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(92, 32)
        Me.btn_agregar.TabIndex = 18
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_practica
        '
        Me.lbl_practica.AutoSize = True
        Me.lbl_practica.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_practica.Location = New System.Drawing.Point(26, 27)
        Me.lbl_practica.Name = "lbl_practica"
        Me.lbl_practica.Size = New System.Drawing.Size(49, 15)
        Me.lbl_practica.TabIndex = 0
        Me.lbl_practica.Text = "Practica"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(380, 56)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(51, 15)
        Me.lbl_subtotal.TabIndex = 19
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(432, 53)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(59, 23)
        Me.txt_subtotal.TabIndex = 20
        '
        'lbl_datosObligatorios
        '
        Me.lbl_datosObligatorios.AutoSize = True
        Me.lbl_datosObligatorios.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosObligatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_datosObligatorios.Location = New System.Drawing.Point(26, 88)
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
        'lbl_mensajeCentroMedicos
        '
        Me.lbl_mensajeCentroMedicos.AutoSize = True
        Me.lbl_mensajeCentroMedicos.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeCentroMedicos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeCentroMedicos.Location = New System.Drawing.Point(263, 39)
        Me.lbl_mensajeCentroMedicos.Name = "lbl_mensajeCentroMedicos"
        Me.lbl_mensajeCentroMedicos.Size = New System.Drawing.Size(163, 17)
        Me.lbl_mensajeCentroMedicos.TabIndex = 40
        Me.lbl_mensajeCentroMedicos.Text = "lbl_mensajeCentroMedico"
        '
        'lbl_mensajeProfesional
        '
        Me.lbl_mensajeProfesional.AutoSize = True
        Me.lbl_mensajeProfesional.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeProfesional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeProfesional.Location = New System.Drawing.Point(269, 54)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(141, 609)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(92, 32)
        Me.btn_cancelar.TabIndex = 42
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_mensajeRegistracion
        '
        Me.lbl_mensajeRegistracion.AutoSize = True
        Me.lbl_mensajeRegistracion.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeRegistracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeRegistracion.Location = New System.Drawing.Point(359, 624)
        Me.lbl_mensajeRegistracion.Name = "lbl_mensajeRegistracion"
        Me.lbl_mensajeRegistracion.Size = New System.Drawing.Size(156, 17)
        Me.lbl_mensajeRegistracion.TabIndex = 43
        Me.lbl_mensajeRegistracion.Text = "lbl_mensajeRegistracion"
        '
        'btn_buscarCentro
        '
        Me.btn_buscarCentro.Location = New System.Drawing.Point(167, 12)
        Me.btn_buscarCentro.Name = "btn_buscarCentro"
        Me.btn_buscarCentro.Size = New System.Drawing.Size(60, 23)
        Me.btn_buscarCentro.TabIndex = 31
        Me.btn_buscarCentro.Text = "Buscar"
        Me.btn_buscarCentro.UseVisualStyleBackColor = True
        '
        'txt_nroCentro
        '
        Me.txt_nroCentro.Location = New System.Drawing.Point(85, 12)
        Me.txt_nroCentro.Name = "txt_nroCentro"
        Me.txt_nroCentro.Size = New System.Drawing.Size(76, 22)
        Me.txt_nroCentro.TabIndex = 29
        '
        'txt_centroMedico
        '
        Me.txt_centroMedico.Location = New System.Drawing.Point(244, 14)
        Me.txt_centroMedico.Name = "txt_centroMedico"
        Me.txt_centroMedico.Size = New System.Drawing.Size(382, 22)
        Me.txt_centroMedico.TabIndex = 33
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_nroCentro)
        Me.GroupBox3.Controls.Add(Me.btn_buscarCentro)
        Me.GroupBox3.Controls.Add(Me.txt_centroMedico)
        Me.GroupBox3.Controls.Add(Me.lbl_mensajeCentroMedicos)
        Me.GroupBox3.Controls.Add(Me.lbl_nroCentro)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 66)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Centro Medico"
        '
        'lbl_nroCentro
        '
        Me.lbl_nroCentro.AutoSize = True
        Me.lbl_nroCentro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroCentro.Location = New System.Drawing.Point(24, 15)
        Me.lbl_nroCentro.Name = "lbl_nroCentro"
        Me.lbl_nroCentro.Size = New System.Drawing.Size(54, 15)
        Me.lbl_nroCentro.TabIndex = 24
        Me.lbl_nroCentro.Text = "Numero "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_total)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgv_practicas)
        Me.Panel1.Controls.Add(Me.lbl_datosObligatorios)
        Me.Panel1.Controls.Add(Me.cbo_practica)
        Me.Panel1.Controls.Add(Me.txt_subtotal)
        Me.Panel1.Controls.Add(Me.lbl_porcDescuento)
        Me.Panel1.Controls.Add(Me.lbl_subtotal)
        Me.Panel1.Controls.Add(Me.txt_precio)
        Me.Panel1.Controls.Add(Me.lbl_practica)
        Me.Panel1.Controls.Add(Me.txt_porcDescuento)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.lbl_precio)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 263)
        Me.Panel1.TabIndex = 45
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(432, 88)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(62, 23)
        Me.txt_total.TabIndex = 24
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(380, 90)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(33, 15)
        Me.lbl_total.TabIndex = 23
        Me.lbl_total.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Practicas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_buscarProfesional)
        Me.GroupBox2.Controls.Add(Me.txt_matricula)
        Me.GroupBox2.Controls.Add(Me.txt_profesional)
        Me.GroupBox2.Controls.Add(Me.lbl_mensajeProfesional)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 71)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profesional"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Matricula"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(595, 23)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(106, 22)
        Me.dtp_fecha.TabIndex = 49
        Me.dtp_fecha.Value = New Date(2016, 10, 25, 14, 15, 48, 0)
        '
        'frm_AtencionMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 654)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.Text = "frm_AtencionMedica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nroAtencion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents txt_nro_atencion As System.Windows.Forms.TextBox
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscarProfesional As System.Windows.Forms.Button
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_profesional As System.Windows.Forms.TextBox
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
    Friend WithEvents lbl_mensajeCentroMedicos As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeProfesional As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeRegistracion As System.Windows.Forms.Label
    Friend WithEvents btn_buscarCentro As System.Windows.Forms.Button
    Friend WithEvents txt_nroCentro As System.Windows.Forms.TextBox
    Friend WithEvents txt_centroMedico As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nroCentro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
End Class
