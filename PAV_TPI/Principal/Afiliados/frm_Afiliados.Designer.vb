<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Afiliados
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
        Me.gb_titulo = New System.Windows.Forms.GroupBox()
        Me.lbl_afiliados_mensaje = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cbo_tipoAfiliado = New System.Windows.Forms.ComboBox()
        Me.chk_fechaBaja = New System.Windows.Forms.CheckBox()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.dtp_fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fechaAlta = New System.Windows.Forms.Label()
        Me.dtp_fechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_nroDocAfiliado = New System.Windows.Forms.Label()
        Me.txt_nroDoc = New System.Windows.Forms.TextBox()
        Me.lbl_tipoAfiliado = New System.Windows.Forms.Label()
        Me.lbl_apeAfiliado = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_nomAfiliado = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dgv_resultados = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_tipoAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_titulo.SuspendLayout()
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_titulo
        '
        Me.gb_titulo.Controls.Add(Me.lbl_afiliados_mensaje)
        Me.gb_titulo.Controls.Add(Me.btn_buscar)
        Me.gb_titulo.Controls.Add(Me.btn_editar)
        Me.gb_titulo.Controls.Add(Me.btn_borrar)
        Me.gb_titulo.Controls.Add(Me.btn_agregar)
        Me.gb_titulo.Controls.Add(Me.cbo_tipoAfiliado)
        Me.gb_titulo.Controls.Add(Me.chk_fechaBaja)
        Me.gb_titulo.Controls.Add(Me.lbl_fechaHasta)
        Me.gb_titulo.Controls.Add(Me.dtp_fechaHasta)
        Me.gb_titulo.Controls.Add(Me.lbl_fechaAlta)
        Me.gb_titulo.Controls.Add(Me.dtp_fechaDesde)
        Me.gb_titulo.Controls.Add(Me.cbo_tipoDoc)
        Me.gb_titulo.Controls.Add(Me.lbl_tipoDoc)
        Me.gb_titulo.Controls.Add(Me.lbl_nroDocAfiliado)
        Me.gb_titulo.Controls.Add(Me.txt_nroDoc)
        Me.gb_titulo.Controls.Add(Me.lbl_tipoAfiliado)
        Me.gb_titulo.Controls.Add(Me.lbl_apeAfiliado)
        Me.gb_titulo.Controls.Add(Me.txt_apellido)
        Me.gb_titulo.Controls.Add(Me.lbl_nomAfiliado)
        Me.gb_titulo.Controls.Add(Me.txt_nombre)
        Me.gb_titulo.Controls.Add(Me.dgv_resultados)
        Me.gb_titulo.Location = New System.Drawing.Point(12, 12)
        Me.gb_titulo.Name = "gb_titulo"
        Me.gb_titulo.Size = New System.Drawing.Size(781, 508)
        Me.gb_titulo.TabIndex = 0
        Me.gb_titulo.TabStop = False
        Me.gb_titulo.Text = "Consultar Afiliados"
        '
        'lbl_afiliados_mensaje
        '
        Me.lbl_afiliados_mensaje.AutoSize = True
        Me.lbl_afiliados_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_afiliados_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_afiliados_mensaje.Location = New System.Drawing.Point(8, 107)
        Me.lbl_afiliados_mensaje.Name = "lbl_afiliados_mensaje"
        Me.lbl_afiliados_mensaje.Size = New System.Drawing.Size(139, 17)
        Me.lbl_afiliados_mensaje.TabIndex = 20
        Me.lbl_afiliados_mensaje.Text = "lbl_afiliados_mensaje"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_buscar.Location = New System.Drawing.Point(689, 92)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 32)
        Me.btn_buscar.TabIndex = 15
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(96, 460)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(80, 32)
        Me.btn_editar.TabIndex = 17
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_borrar.Location = New System.Drawing.Point(182, 460)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(80, 32)
        Me.btn_borrar.TabIndex = 18
        Me.btn_borrar.Text = "Eliminar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(10, 460)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(80, 32)
        Me.btn_agregar.TabIndex = 16
        Me.btn_agregar.Text = "Nuevo"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cbo_tipoAfiliado
        '
        Me.cbo_tipoAfiliado.FormattingEnabled = True
        Me.cbo_tipoAfiliado.Location = New System.Drawing.Point(70, 78)
        Me.cbo_tipoAfiliado.Name = "cbo_tipoAfiliado"
        Me.cbo_tipoAfiliado.Size = New System.Drawing.Size(177, 21)
        Me.cbo_tipoAfiliado.TabIndex = 5
        '
        'chk_fechaBaja
        '
        Me.chk_fechaBaja.AutoSize = True
        Me.chk_fechaBaja.Location = New System.Drawing.Point(270, 82)
        Me.chk_fechaBaja.Name = "chk_fechaBaja"
        Me.chk_fechaBaja.Size = New System.Drawing.Size(124, 17)
        Me.chk_fechaBaja.TabIndex = 10
        Me.chk_fechaBaja.Text = "Incluir dados de baja"
        Me.chk_fechaBaja.UseVisualStyleBackColor = True
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(503, 56)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(68, 13)
        Me.lbl_fechaHasta.TabIndex = 13
        Me.lbl_fechaHasta.Text = "Fecha Hasta"
        '
        'dtp_fechaHasta
        '
        Me.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaHasta.Location = New System.Drawing.Point(574, 53)
        Me.dtp_fechaHasta.Name = "dtp_fechaHasta"
        Me.dtp_fechaHasta.Size = New System.Drawing.Size(195, 20)
        Me.dtp_fechaHasta.TabIndex = 14
        '
        'lbl_fechaAlta
        '
        Me.lbl_fechaAlta.AutoSize = True
        Me.lbl_fechaAlta.Location = New System.Drawing.Point(500, 27)
        Me.lbl_fechaAlta.Name = "lbl_fechaAlta"
        Me.lbl_fechaAlta.Size = New System.Drawing.Size(71, 13)
        Me.lbl_fechaAlta.TabIndex = 11
        Me.lbl_fechaAlta.Text = "Fecha Desde"
        '
        'dtp_fechaDesde
        '
        Me.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaDesde.Location = New System.Drawing.Point(574, 24)
        Me.dtp_fechaDesde.Name = "dtp_fechaDesde"
        Me.dtp_fechaDesde.Size = New System.Drawing.Size(195, 20)
        Me.dtp_fechaDesde.TabIndex = 12
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(70, 51)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(177, 21)
        Me.cbo_tipoDoc.TabIndex = 3
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(20, 53)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(51, 13)
        Me.lbl_tipoDoc.TabIndex = 2
        Me.lbl_tipoDoc.Text = "Tipo Doc"
        '
        'lbl_nroDocAfiliado
        '
        Me.lbl_nroDocAfiliado.AutoSize = True
        Me.lbl_nroDocAfiliado.Location = New System.Drawing.Point(267, 56)
        Me.lbl_nroDocAfiliado.Name = "lbl_nroDocAfiliado"
        Me.lbl_nroDocAfiliado.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nroDocAfiliado.TabIndex = 8
        Me.lbl_nroDocAfiliado.Text = "Nro Doc"
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(317, 53)
        Me.txt_nroDoc.MaxLength = 8
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(177, 20)
        Me.txt_nroDoc.TabIndex = 9
        '
        'lbl_tipoAfiliado
        '
        Me.lbl_tipoAfiliado.AutoSize = True
        Me.lbl_tipoAfiliado.Location = New System.Drawing.Point(4, 82)
        Me.lbl_tipoAfiliado.Name = "lbl_tipoAfiliado"
        Me.lbl_tipoAfiliado.Size = New System.Drawing.Size(65, 13)
        Me.lbl_tipoAfiliado.TabIndex = 4
        Me.lbl_tipoAfiliado.Text = "Tipo Afiliado"
        '
        'lbl_apeAfiliado
        '
        Me.lbl_apeAfiliado.AutoSize = True
        Me.lbl_apeAfiliado.Location = New System.Drawing.Point(267, 30)
        Me.lbl_apeAfiliado.Name = "lbl_apeAfiliado"
        Me.lbl_apeAfiliado.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apeAfiliado.TabIndex = 6
        Me.lbl_apeAfiliado.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(317, 24)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(177, 20)
        Me.txt_apellido.TabIndex = 7
        '
        'lbl_nomAfiliado
        '
        Me.lbl_nomAfiliado.AutoSize = True
        Me.lbl_nomAfiliado.Location = New System.Drawing.Point(20, 27)
        Me.lbl_nomAfiliado.Name = "lbl_nomAfiliado"
        Me.lbl_nomAfiliado.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nomAfiliado.TabIndex = 0
        Me.lbl_nomAfiliado.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(70, 24)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(177, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'dgv_resultados
        '
        Me.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_apellido, Me.col_tipoDoc, Me.col_nroDoc, Me.col_fechaNac, Me.col_calle, Me.col_nroCalle, Me.col_barrio, Me.col_telefono, Me.col_tipoAfiliado, Me.col_fechaAlta, Me.col_fechaBaja, Me.col_id_tipoDoc, Me.col_id_tipoAfiliado})
        Me.dgv_resultados.Location = New System.Drawing.Point(11, 139)
        Me.dgv_resultados.Name = "dgv_resultados"
        Me.dgv_resultados.Size = New System.Drawing.Size(758, 312)
        Me.dgv_resultados.TabIndex = 19
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        '
        'col_tipoDoc
        '
        Me.col_tipoDoc.HeaderText = "TipoDoc"
        Me.col_tipoDoc.Name = "col_tipoDoc"
        '
        'col_nroDoc
        '
        Me.col_nroDoc.HeaderText = "Nro Doc"
        Me.col_nroDoc.Name = "col_nroDoc"
        '
        'col_fechaNac
        '
        Me.col_fechaNac.HeaderText = "fechaNac"
        Me.col_fechaNac.Name = "col_fechaNac"
        Me.col_fechaNac.Visible = False
        '
        'col_calle
        '
        Me.col_calle.HeaderText = "Calle"
        Me.col_calle.Name = "col_calle"
        Me.col_calle.Visible = False
        '
        'col_nroCalle
        '
        Me.col_nroCalle.HeaderText = "Nro"
        Me.col_nroCalle.Name = "col_nroCalle"
        Me.col_nroCalle.Visible = False
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.Visible = False
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = False
        '
        'col_tipoAfiliado
        '
        Me.col_tipoAfiliado.HeaderText = "Tipo Afiliado"
        Me.col_tipoAfiliado.Name = "col_tipoAfiliado"
        '
        'col_fechaAlta
        '
        Me.col_fechaAlta.HeaderText = "Fecha Alta"
        Me.col_fechaAlta.Name = "col_fechaAlta"
        '
        'col_fechaBaja
        '
        Me.col_fechaBaja.HeaderText = "Fecha Baja"
        Me.col_fechaBaja.Name = "col_fechaBaja"
        '
        'col_id_tipoDoc
        '
        Me.col_id_tipoDoc.HeaderText = "id_tipoDoc"
        Me.col_id_tipoDoc.Name = "col_id_tipoDoc"
        Me.col_id_tipoDoc.Visible = False
        '
        'col_id_tipoAfiliado
        '
        Me.col_id_tipoAfiliado.HeaderText = "id_tipoAfiliado"
        Me.col_id_tipoAfiliado.Name = "col_id_tipoAfiliado"
        Me.col_id_tipoAfiliado.Visible = False
        '
        'frm_Afiliados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 534)
        Me.Controls.Add(Me.gb_titulo)
        Me.Name = "frm_Afiliados"
        Me.Text = "Afiliados"
        Me.gb_titulo.ResumeLayout(False)
        Me.gb_titulo.PerformLayout()
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_titulo As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipoAfiliado As System.Windows.Forms.ComboBox
    Friend WithEvents chk_fechaBaja As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_fechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fechaAlta As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDocAfiliado As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipoAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_apeAfiliado As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nomAfiliado As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents dgv_resultados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_afiliados_mensaje As System.Windows.Forms.Label
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoAfiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fechaBaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id_tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id_tipoAfiliado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
