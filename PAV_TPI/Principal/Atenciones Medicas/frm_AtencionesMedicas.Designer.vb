﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atenciones_Medicas
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
        Me.lbl_nroAtencion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nroCentro = New System.Windows.Forms.Label()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.txt_nro_atencion = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nroCentro = New System.Windows.Forms.TextBox()
        Me.btn_buscarCentro = New System.Windows.Forms.Button()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.btn_buscarProfesional = New System.Windows.Forms.Button()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.txt_centroMedico = New System.Windows.Forms.TextBox()
        Me.txt_profesional = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.lbl_mensajeCentro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_mensajeAfiliado = New System.Windows.Forms.Label()
        Me.btn_BuscarAfiliado = New System.Windows.Forms.Button()
        Me.txt_apellidoNombre = New System.Windows.Forms.TextBox()
        Me.lbl_apellidoNombre = New System.Windows.Forms.Label()
        Me.lbl_mensajeCentroMedicos = New System.Windows.Forms.Label()
        Me.lbl_mensajeProfesional = New System.Windows.Forms.Label()
        Me.lbl_porcDescuento = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_porcDescuento = New System.Windows.Forms.TextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.dgv_practicas = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_practica = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_practica = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nroAtencion
        '
        Me.lbl_nroAtencion.AutoSize = True
        Me.lbl_nroAtencion.Location = New System.Drawing.Point(32, 27)
        Me.lbl_nroAtencion.Name = "lbl_nroAtencion"
        Me.lbl_nroAtencion.Size = New System.Drawing.Size(75, 13)
        Me.lbl_nroAtencion.TabIndex = 0
        Me.lbl_nroAtencion.Text = "Nro. Atención "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(556, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'lbl_nroCentro
        '
        Me.lbl_nroCentro.AutoSize = True
        Me.lbl_nroCentro.Location = New System.Drawing.Point(32, 68)
        Me.lbl_nroCentro.Name = "lbl_nroCentro"
        Me.lbl_nroCentro.Size = New System.Drawing.Size(76, 13)
        Me.lbl_nroCentro.TabIndex = 2
        Me.lbl_nroCentro.Text = "Centro Medico"
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(32, 231)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(67, 13)
        Me.lbl_especialidad.TabIndex = 4
        Me.lbl_especialidad.Text = "Especialidad"
        '
        'lbl_profesional
        '
        Me.lbl_profesional.AutoSize = True
        Me.lbl_profesional.Location = New System.Drawing.Point(32, 199)
        Me.lbl_profesional.Name = "lbl_profesional"
        Me.lbl_profesional.Size = New System.Drawing.Size(59, 13)
        Me.lbl_profesional.TabIndex = 5
        Me.lbl_profesional.Text = "Profesional"
        '
        'txt_nro_atencion
        '
        Me.txt_nro_atencion.Location = New System.Drawing.Point(148, 27)
        Me.txt_nro_atencion.Name = "txt_nro_atencion"
        Me.txt_nro_atencion.Size = New System.Drawing.Size(76, 20)
        Me.txt_nro_atencion.TabIndex = 6
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(613, 27)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(76, 20)
        Me.txt_fecha.TabIndex = 7
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'txt_nroCentro
        '
        Me.txt_nroCentro.Location = New System.Drawing.Point(148, 63)
        Me.txt_nroCentro.Name = "txt_nroCentro"
        Me.txt_nroCentro.Size = New System.Drawing.Size(76, 20)
        Me.txt_nroCentro.TabIndex = 8
        '
        'btn_buscarCentro
        '
        Me.btn_buscarCentro.Location = New System.Drawing.Point(230, 63)
        Me.btn_buscarCentro.Name = "btn_buscarCentro"
        Me.btn_buscarCentro.Size = New System.Drawing.Size(60, 23)
        Me.btn_buscarCentro.TabIndex = 9
        Me.btn_buscarCentro.Text = "Buscar"
        Me.btn_buscarCentro.UseVisualStyleBackColor = True
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(148, 199)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(76, 20)
        Me.txt_matricula.TabIndex = 8
        '
        'btn_buscarProfesional
        '
        Me.btn_buscarProfesional.Location = New System.Drawing.Point(230, 196)
        Me.btn_buscarProfesional.Name = "btn_buscarProfesional"
        Me.btn_buscarProfesional.Size = New System.Drawing.Size(60, 23)
        Me.btn_buscarProfesional.TabIndex = 9
        Me.btn_buscarProfesional.Text = "Buscar"
        Me.btn_buscarProfesional.UseVisualStyleBackColor = True
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(148, 231)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(264, 21)
        Me.cbo_especialidad.TabIndex = 12
        '
        'txt_centroMedico
        '
        Me.txt_centroMedico.Location = New System.Drawing.Point(307, 61)
        Me.txt_centroMedico.Name = "txt_centroMedico"
        Me.txt_centroMedico.Size = New System.Drawing.Size(382, 20)
        Me.txt_centroMedico.TabIndex = 10
        '
        'txt_profesional
        '
        Me.txt_profesional.Location = New System.Drawing.Point(307, 199)
        Me.txt_profesional.Name = "txt_profesional"
        Me.txt_profesional.Size = New System.Drawing.Size(382, 20)
        Me.txt_profesional.TabIndex = 10
        '
        'btn_registrar
        '
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrar.Location = New System.Drawing.Point(590, 525)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(92, 32)
        Me.btn_registrar.TabIndex = 16
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'lbl_mensajeCentro
        '
        Me.lbl_mensajeCentro.AutoSize = True
        Me.lbl_mensajeCentro.Location = New System.Drawing.Point(311, 92)
        Me.lbl_mensajeCentro.Name = "lbl_mensajeCentro"
        Me.lbl_mensajeCentro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensajeCentro.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nro. Documento"
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(126, 22)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(73, 21)
        Me.cbo_tipoDoc.TabIndex = 12
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(326, 25)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(98, 20)
        Me.txt_nroDoc.TabIndex = 14
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(10, 27)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDoc.TabIndex = 3
        Me.lbl_tipoDoc.Text = "Tipo Documento"
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 90)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Afiliado"
        '
        'lbl_mensajeAfiliado
        '
        Me.lbl_mensajeAfiliado.AutoSize = True
        Me.lbl_mensajeAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.lbl_mensajeAfiliado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeAfiliado.Location = New System.Drawing.Point(477, 72)
        Me.lbl_mensajeAfiliado.Name = "lbl_mensajeAfiliado"
        Me.lbl_mensajeAfiliado.Size = New System.Drawing.Size(113, 17)
        Me.lbl_mensajeAfiliado.TabIndex = 18
        Me.lbl_mensajeAfiliado.Text = "lbl_mensajeAfiliado"
        '
        'btn_BuscarAfiliado
        '
        Me.btn_BuscarAfiliado.Location = New System.Drawing.Point(480, 39)
        Me.btn_BuscarAfiliado.Name = "btn_BuscarAfiliado"
        Me.btn_BuscarAfiliado.Size = New System.Drawing.Size(59, 23)
        Me.btn_BuscarAfiliado.TabIndex = 17
        Me.btn_BuscarAfiliado.Text = "Buscar"
        Me.btn_BuscarAfiliado.UseVisualStyleBackColor = True
        '
        'txt_apellidoNombre
        '
        Me.txt_apellidoNombre.Location = New System.Drawing.Point(126, 51)
        Me.txt_apellidoNombre.Name = "txt_apellidoNombre"
        Me.txt_apellidoNombre.Size = New System.Drawing.Size(316, 20)
        Me.txt_apellidoNombre.TabIndex = 16
        '
        'lbl_apellidoNombre
        '
        Me.lbl_apellidoNombre.Location = New System.Drawing.Point(13, 51)
        Me.lbl_apellidoNombre.Name = "lbl_apellidoNombre"
        Me.lbl_apellidoNombre.Size = New System.Drawing.Size(98, 12)
        Me.lbl_apellidoNombre.TabIndex = 0
        Me.lbl_apellidoNombre.Text = "Apellido y Nombre"
        '
        'lbl_mensajeCentroMedicos
        '
        Me.lbl_mensajeCentroMedicos.AutoSize = True
        Me.lbl_mensajeCentroMedicos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.lbl_mensajeCentroMedicos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeCentroMedicos.Location = New System.Drawing.Point(499, 91)
        Me.lbl_mensajeCentroMedicos.Name = "lbl_mensajeCentroMedicos"
        Me.lbl_mensajeCentroMedicos.Size = New System.Drawing.Size(148, 17)
        Me.lbl_mensajeCentroMedicos.TabIndex = 20
        Me.lbl_mensajeCentroMedicos.Text = "lbl_mensajeCentroMedico"
        '
        'lbl_mensajeProfesional
        '
        Me.lbl_mensajeProfesional.AutoSize = True
        Me.lbl_mensajeProfesional.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.lbl_mensajeProfesional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_mensajeProfesional.Location = New System.Drawing.Point(499, 240)
        Me.lbl_mensajeProfesional.Name = "lbl_mensajeProfesional"
        Me.lbl_mensajeProfesional.Size = New System.Drawing.Size(132, 17)
        Me.lbl_mensajeProfesional.TabIndex = 20
        Me.lbl_mensajeProfesional.Text = "lbl_mensajeProfesional"
        '
        'lbl_porcDescuento
        '
        Me.lbl_porcDescuento.AutoSize = True
        Me.lbl_porcDescuento.Location = New System.Drawing.Point(205, 50)
        Me.lbl_porcDescuento.Name = "lbl_porcDescuento"
        Me.lbl_porcDescuento.Size = New System.Drawing.Size(126, 13)
        Me.lbl_porcDescuento.TabIndex = 15
        Me.lbl_porcDescuento.Text = "Porcentaje de descuento"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(126, 47)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(59, 20)
        Me.txt_precio.TabIndex = 14
        '
        'txt_porcDescuento
        '
        Me.txt_porcDescuento.Location = New System.Drawing.Point(337, 47)
        Me.txt_porcDescuento.Name = "txt_porcDescuento"
        Me.txt_porcDescuento.Size = New System.Drawing.Size(59, 20)
        Me.txt_porcDescuento.TabIndex = 16
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(74, 50)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_precio.TabIndex = 13
        Me.lbl_precio.Text = "Precio"
        '
        'dgv_practicas
        '
        Me.dgv_practicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_Practica, Me.col_precio, Me.col_porcentaje, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(29, 102)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.Size = New System.Drawing.Size(638, 154)
        Me.dgv_practicas.TabIndex = 17
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id "
        Me.col_id.Name = "col_id"
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
        Me.cbo_practica.Location = New System.Drawing.Point(126, 13)
        Me.cbo_practica.Name = "cbo_practica"
        Me.cbo_practica.Size = New System.Drawing.Size(264, 21)
        Me.cbo_practica.TabIndex = 12
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(575, 47)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(92, 32)
        Me.btn_agregar.TabIndex = 18
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_practica
        '
        Me.lbl_practica.AutoSize = True
        Me.lbl_practica.Location = New System.Drawing.Point(74, 21)
        Me.lbl_practica.Name = "lbl_practica"
        Me.lbl_practica.Size = New System.Drawing.Size(46, 13)
        Me.lbl_practica.TabIndex = 0
        Me.lbl_practica.Text = "Practica"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Location = New System.Drawing.Point(428, 50)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(46, 13)
        Me.lbl_subtotal.TabIndex = 19
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(480, 47)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(59, 20)
        Me.txt_subtotal.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_subtotal)
        Me.GroupBox2.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox2.Controls.Add(Me.lbl_practica)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.cbo_practica)
        Me.GroupBox2.Controls.Add(Me.dgv_practicas)
        Me.GroupBox2.Controls.Add(Me.lbl_precio)
        Me.GroupBox2.Controls.Add(Me.txt_porcDescuento)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.lbl_porcDescuento)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 256)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Practicas"
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_consultar.Location = New System.Drawing.Point(487, 525)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(92, 32)
        Me.btn_consultar.TabIndex = 21
        Me.btn_consultar.Text = "CONSULTAR"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Atenciones_Medicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 577)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.lbl_mensajeProfesional)
        Me.Controls.Add(Me.lbl_mensajeCentroMedicos)
        Me.Controls.Add(Me.lbl_mensajeCentro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_profesional)
        Me.Controls.Add(Me.txt_centroMedico)
        Me.Controls.Add(Me.cbo_especialidad)
        Me.Controls.Add(Me.btn_buscarProfesional)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.btn_buscarCentro)
        Me.Controls.Add(Me.txt_nroCentro)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_nro_atencion)
        Me.Controls.Add(Me.lbl_profesional)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.lbl_nroCentro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nroAtencion)
        Me.Name = "Atenciones_Medicas"
        Me.Text = "Atenciones Medicas"
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
    Friend WithEvents lbl_nroCentro As System.Windows.Forms.Label
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_profesional As System.Windows.Forms.Label
    Friend WithEvents txt_nro_atencion As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nroCentro As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscarCentro As System.Windows.Forms.Button
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscarProfesional As System.Windows.Forms.Button
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_centroMedico As System.Windows.Forms.TextBox
    Friend WithEvents txt_profesional As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeCentro As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellidoNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeCentroMedicos As System.Windows.Forms.Label
    Friend WithEvents lbl_mensajeProfesional As System.Windows.Forms.Label
    Friend WithEvents lbl_porcDescuento As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_porcDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents dgv_practicas As System.Windows.Forms.DataGridView
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbo_practica As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_practica As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_BuscarAfiliado As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeAfiliado As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
End Class
