<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Profesionales
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
        Me.box_datosPersonales = New System.Windows.Forms.GroupBox()
        Me.txt_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nomAfiliado = New System.Windows.Forms.Label()
        Me.lbl_apeAfiliado = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_profesionales_mensaje = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.chk_fechaBaja = New System.Windows.Forms.CheckBox()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.dtp_fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fechaAlta = New System.Windows.Forms.Label()
        Me.dtp_fechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgv_resultados = New System.Windows.Forms.DataGridView()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box_datosPersonales.SuspendLayout()
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'box_datosPersonales
        '
        Me.box_datosPersonales.Controls.Add(Me.txt_matricula)
        Me.box_datosPersonales.Controls.Add(Me.lbl_nomAfiliado)
        Me.box_datosPersonales.Controls.Add(Me.lbl_apeAfiliado)
        Me.box_datosPersonales.Controls.Add(Me.lbl_tipoDoc)
        Me.box_datosPersonales.Controls.Add(Me.lbl_nroDoc)
        Me.box_datosPersonales.Controls.Add(Me.cbo_tipoDoc)
        Me.box_datosPersonales.Controls.Add(Me.txt_nroDoc)
        Me.box_datosPersonales.Controls.Add(Me.txt_nombre)
        Me.box_datosPersonales.Controls.Add(Me.txt_apellido)
        Me.box_datosPersonales.Controls.Add(Me.Label1)
        Me.box_datosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_datosPersonales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_datosPersonales.ForeColor = System.Drawing.Color.Teal
        Me.box_datosPersonales.Location = New System.Drawing.Point(30, 65)
        Me.box_datosPersonales.Name = "box_datosPersonales"
        Me.box_datosPersonales.Size = New System.Drawing.Size(736, 150)
        Me.box_datosPersonales.TabIndex = 13
        Me.box_datosPersonales.TabStop = False
        Me.box_datosPersonales.Text = "Datos personales"
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(100, 35)
        Me.txt_matricula.Mask = "99999"
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(100, 25)
        Me.txt_matricula.TabIndex = 0
        Me.txt_matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_matricula.ValidatingType = GetType(Integer)
        '
        'lbl_nomAfiliado
        '
        Me.lbl_nomAfiliado.AutoSize = True
        Me.lbl_nomAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lbl_nomAfiliado.Location = New System.Drawing.Point(37, 69)
        Me.lbl_nomAfiliado.Name = "lbl_nomAfiliado"
        Me.lbl_nomAfiliado.Size = New System.Drawing.Size(57, 17)
        Me.lbl_nomAfiliado.TabIndex = 6
        Me.lbl_nomAfiliado.Text = "Nombre"
        '
        'lbl_apeAfiliado
        '
        Me.lbl_apeAfiliado.AutoSize = True
        Me.lbl_apeAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apeAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lbl_apeAfiliado.Location = New System.Drawing.Point(37, 100)
        Me.lbl_apeAfiliado.Name = "lbl_apeAfiliado"
        Me.lbl_apeAfiliado.Size = New System.Drawing.Size(56, 17)
        Me.lbl_apeAfiliado.TabIndex = 7
        Me.lbl_apeAfiliado.Text = "Apellido"
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoDoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(414, 38)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(105, 17)
        Me.lbl_tipoDoc.TabIndex = 8
        Me.lbl_tipoDoc.Text = "Tipo Documento"
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroDoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_nroDoc.Location = New System.Drawing.Point(414, 67)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(105, 17)
        Me.lbl_nroDoc.TabIndex = 9
        Me.lbl_nroDoc.Text = "Nro. Documento"
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(522, 33)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(182, 25)
        Me.cbo_tipoDoc.TabIndex = 3
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nroDoc.Location = New System.Drawing.Point(522, 64)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(182, 25)
        Me.txt_nroDoc.TabIndex = 4
        Me.txt_nroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(100, 66)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(247, 25)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(100, 97)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(247, 25)
        Me.txt_apellido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Matrícula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 32)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Consultar Profesionales"
        '
        'lbl_profesionales_mensaje
        '
        Me.lbl_profesionales_mensaje.AutoSize = True
        Me.lbl_profesionales_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profesionales_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_profesionales_mensaje.Location = New System.Drawing.Point(28, 228)
        Me.lbl_profesionales_mensaje.Name = "lbl_profesionales_mensaje"
        Me.lbl_profesionales_mensaje.Size = New System.Drawing.Size(167, 17)
        Me.lbl_profesionales_mensaje.TabIndex = 25
        Me.lbl_profesionales_mensaje.Text = "lbl_profesionales_mensaje"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_buscar.Location = New System.Drawing.Point(1005, 165)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 32)
        Me.btn_buscar.TabIndex = 17
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(116, 545)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(80, 32)
        Me.btn_editar.TabIndex = 19
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_borrar.Location = New System.Drawing.Point(202, 545)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(80, 32)
        Me.btn_borrar.TabIndex = 20
        Me.btn_borrar.Text = "Eliminar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(30, 545)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(80, 32)
        Me.btn_agregar.TabIndex = 18
        Me.btn_agregar.Text = "Nuevo"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'chk_fechaBaja
        '
        Me.chk_fechaBaja.AutoSize = True
        Me.chk_fechaBaja.Location = New System.Drawing.Point(797, 194)
        Me.chk_fechaBaja.Name = "chk_fechaBaja"
        Me.chk_fechaBaja.Size = New System.Drawing.Size(124, 17)
        Me.chk_fechaBaja.TabIndex = 16
        Me.chk_fechaBaja.Text = "Incluir dados de baja"
        Me.chk_fechaBaja.UseVisualStyleBackColor = True
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(797, 130)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(68, 13)
        Me.lbl_fechaHasta.TabIndex = 24
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        '
        'dtp_fechaHasta
        '
        Me.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaHasta.Location = New System.Drawing.Point(890, 126)
        Me.dtp_fechaHasta.Name = "dtp_fechaHasta"
        Me.dtp_fechaHasta.Size = New System.Drawing.Size(195, 20)
        Me.dtp_fechaHasta.TabIndex = 15
        '
        'lbl_fechaAlta
        '
        Me.lbl_fechaAlta.AutoSize = True
        Me.lbl_fechaAlta.Location = New System.Drawing.Point(794, 101)
        Me.lbl_fechaAlta.Name = "lbl_fechaAlta"
        Me.lbl_fechaAlta.Size = New System.Drawing.Size(71, 13)
        Me.lbl_fechaAlta.TabIndex = 23
        Me.lbl_fechaAlta.Text = "Fecha Desde"
        '
        'dtp_fechaDesde
        '
        Me.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaDesde.Location = New System.Drawing.Point(890, 97)
        Me.dtp_fechaDesde.Name = "dtp_fechaDesde"
        Me.dtp_fechaDesde.Size = New System.Drawing.Size(195, 20)
        Me.dtp_fechaDesde.TabIndex = 14
        '
        'dgv_resultados
        '
        Me.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricula, Me.col_nombre, Me.col_apellido, Me.col_tipoDoc, Me.col_nroDoc, Me.col_fechaNac, Me.col_calle, Me.col_nroCalle, Me.col_barrio, Me.col_telefono, Me.col_fechaAlta, Me.col_fechaBaja})
        Me.dgv_resultados.Location = New System.Drawing.Point(31, 261)
        Me.dgv_resultados.Name = "dgv_resultados"
        Me.dgv_resultados.Size = New System.Drawing.Size(1054, 275)
        Me.dgv_resultados.TabIndex = 21
        '
        'matricula
        '
        Me.matricula.HeaderText = "Matrícula"
        Me.matricula.Name = "matricula"
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Width = 220
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.Width = 220
        '
        'col_tipoDoc
        '
        Me.col_tipoDoc.HeaderText = "Tipo Documento"
        Me.col_tipoDoc.Name = "col_tipoDoc"
        Me.col_tipoDoc.Width = 150
        '
        'col_nroDoc
        '
        Me.col_nroDoc.HeaderText = "Nro. Documento"
        Me.col_nroDoc.Name = "col_nroDoc"
        Me.col_nroDoc.Width = 150
        '
        'col_fechaNac
        '
        Me.col_fechaNac.HeaderText = "Fecha de Nacimiento"
        Me.col_fechaNac.Name = "col_fechaNac"
        Me.col_fechaNac.Visible = False
        Me.col_fechaNac.Width = 200
        '
        'col_calle
        '
        Me.col_calle.HeaderText = "Calle"
        Me.col_calle.Name = "col_calle"
        Me.col_calle.Visible = False
        Me.col_calle.Width = 200
        '
        'col_nroCalle
        '
        Me.col_nroCalle.HeaderText = "Nro."
        Me.col_nroCalle.Name = "col_nroCalle"
        Me.col_nroCalle.Visible = False
        Me.col_nroCalle.Width = 50
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.Visible = False
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Teléfono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = False
        '
        'col_fechaAlta
        '
        Me.col_fechaAlta.HeaderText = "Fecha Alta"
        Me.col_fechaAlta.Name = "col_fechaAlta"
        Me.col_fechaAlta.ReadOnly = True
        Me.col_fechaAlta.Width = 150
        '
        'col_fechaBaja
        '
        Me.col_fechaBaja.HeaderText = "Fecha Baja"
        Me.col_fechaBaja.Name = "col_fechaBaja"
        Me.col_fechaBaja.ReadOnly = True
        Me.col_fechaBaja.Visible = False
        Me.col_fechaBaja.Width = 150
        '
        'frm_Profesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 593)
        Me.Controls.Add(Me.box_datosPersonales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_profesionales_mensaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.chk_fechaBaja)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.dtp_fechaHasta)
        Me.Controls.Add(Me.lbl_fechaAlta)
        Me.Controls.Add(Me.dtp_fechaDesde)
        Me.Controls.Add(Me.dgv_resultados)
        Me.Name = "frm_Profesionales"
        Me.Text = "frm_Profesionales"
        Me.box_datosPersonales.ResumeLayout(False)
        Me.box_datosPersonales.PerformLayout()
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents box_datosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents txt_matricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_nomAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_apeAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_profesionales_mensaje As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents chk_fechaBaja As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_fechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fechaAlta As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_resultados As System.Windows.Forms.DataGridView
    Friend WithEvents matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaBaja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
