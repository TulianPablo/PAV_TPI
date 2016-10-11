<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevoAfiliado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_afiliados_mensaje = New System.Windows.Forms.Label()
        Me.dtp_fechaNac = New System.Windows.Forms.DateTimePicker()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.gb_afiliacion = New System.Windows.Forms.GroupBox()
        Me.mtb_fechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipoAfiliado = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoAfiliado = New System.Windows.Forms.Label()
        Me.lbl_fechaAlta = New System.Windows.Forms.Label()
        Me.gb_domicilio = New System.Windows.Forms.GroupBox()
        Me.cbo_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_nroCalle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_nroCalle = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_fechaNac = New System.Windows.Forms.Label()
        Me.lbl_apeAfiliado = New System.Windows.Forms.Label()
        Me.lbl_nomAfiliado = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gb_afiliacion.SuspendLayout()
        Me.gb_domicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_afiliados_mensaje)
        Me.GroupBox1.Controls.Add(Me.dtp_fechaNac)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_aceptar)
        Me.GroupBox1.Controls.Add(Me.cbo_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.gb_afiliacion)
        Me.GroupBox1.Controls.Add(Me.gb_domicilio)
        Me.GroupBox1.Controls.Add(Me.lbl_nroDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_fechaNac)
        Me.GroupBox1.Controls.Add(Me.lbl_apeAfiliado)
        Me.GroupBox1.Controls.Add(Me.lbl_nomAfiliado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 421)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo"
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(489, 44)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(155, 20)
        Me.txt_nroDoc.TabIndex = 25
        '
        'lbl_afiliados_mensaje
        '
        Me.lbl_afiliados_mensaje.AutoSize = True
        Me.lbl_afiliados_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_afiliados_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_afiliados_mensaje.Location = New System.Drawing.Point(17, 334)
        Me.lbl_afiliados_mensaje.Name = "lbl_afiliados_mensaje"
        Me.lbl_afiliados_mensaje.Size = New System.Drawing.Size(139, 17)
        Me.lbl_afiliados_mensaje.TabIndex = 32
        Me.lbl_afiliados_mensaje.Text = "lbl_afiliados_mensaje"
        '
        'dtp_fechaNac
        '
        Me.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaNac.Location = New System.Drawing.Point(130, 76)
        Me.dtp_fechaNac.MaxDate = New Date(2016, 10, 9, 0, 0, 0, 0)
        Me.dtp_fechaNac.Name = "dtp_fechaNac"
        Me.dtp_fechaNac.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fechaNac.TabIndex = 31
        Me.dtp_fechaNac.Value = New Date(2016, 10, 9, 0, 0, 0, 0)
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(336, 375)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 29)
        Me.btn_cancelar.TabIndex = 30
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_aceptar.Location = New System.Drawing.Point(224, 375)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(96, 29)
        Me.btn_aceptar.TabIndex = 29
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(489, 19)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(155, 21)
        Me.cbo_tipoDoc.TabIndex = 28
        '
        'gb_afiliacion
        '
        Me.gb_afiliacion.BackColor = System.Drawing.SystemColors.Control
        Me.gb_afiliacion.Controls.Add(Me.mtb_fechaAlta)
        Me.gb_afiliacion.Controls.Add(Me.cbo_tipoAfiliado)
        Me.gb_afiliacion.Controls.Add(Me.lbl_tipoAfiliado)
        Me.gb_afiliacion.Controls.Add(Me.lbl_fechaAlta)
        Me.gb_afiliacion.Location = New System.Drawing.Point(13, 242)
        Me.gb_afiliacion.Name = "gb_afiliacion"
        Me.gb_afiliacion.Size = New System.Drawing.Size(639, 72)
        Me.gb_afiliacion.TabIndex = 25
        Me.gb_afiliacion.TabStop = False
        Me.gb_afiliacion.Text = "Afiliacion"
        '
        'mtb_fechaAlta
        '
        Me.mtb_fechaAlta.Location = New System.Drawing.Point(104, 28)
        Me.mtb_fechaAlta.Mask = "00/00/0000"
        Me.mtb_fechaAlta.Name = "mtb_fechaAlta"
        Me.mtb_fechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fechaAlta.TabIndex = 22
        Me.mtb_fechaAlta.ValidatingType = GetType(Date)
        '
        'cbo_tipoAfiliado
        '
        Me.cbo_tipoAfiliado.FormattingEnabled = True
        Me.cbo_tipoAfiliado.Location = New System.Drawing.Point(434, 28)
        Me.cbo_tipoAfiliado.Name = "cbo_tipoAfiliado"
        Me.cbo_tipoAfiliado.Size = New System.Drawing.Size(155, 21)
        Me.cbo_tipoAfiliado.TabIndex = 21
        '
        'lbl_tipoAfiliado
        '
        Me.lbl_tipoAfiliado.AutoSize = True
        Me.lbl_tipoAfiliado.Location = New System.Drawing.Point(357, 28)
        Me.lbl_tipoAfiliado.Name = "lbl_tipoAfiliado"
        Me.lbl_tipoAfiliado.Size = New System.Drawing.Size(65, 13)
        Me.lbl_tipoAfiliado.TabIndex = 18
        Me.lbl_tipoAfiliado.Text = "Tipo Afiliado"
        '
        'lbl_fechaAlta
        '
        Me.lbl_fechaAlta.AutoSize = True
        Me.lbl_fechaAlta.Location = New System.Drawing.Point(39, 31)
        Me.lbl_fechaAlta.Name = "lbl_fechaAlta"
        Me.lbl_fechaAlta.Size = New System.Drawing.Size(58, 13)
        Me.lbl_fechaAlta.TabIndex = 17
        Me.lbl_fechaAlta.Text = "Fecha Alta"
        '
        'gb_domicilio
        '
        Me.gb_domicilio.BackColor = System.Drawing.SystemColors.Control
        Me.gb_domicilio.Controls.Add(Me.cbo_barrio)
        Me.gb_domicilio.Controls.Add(Me.lbl_barrio)
        Me.gb_domicilio.Controls.Add(Me.lbl_calle)
        Me.gb_domicilio.Controls.Add(Me.lbl_telefono)
        Me.gb_domicilio.Controls.Add(Me.lbl_nroCalle)
        Me.gb_domicilio.Controls.Add(Me.txt_calle)
        Me.gb_domicilio.Controls.Add(Me.txt_nroCalle)
        Me.gb_domicilio.Controls.Add(Me.txt_telefono)
        Me.gb_domicilio.Location = New System.Drawing.Point(13, 116)
        Me.gb_domicilio.Name = "gb_domicilio"
        Me.gb_domicilio.Size = New System.Drawing.Size(640, 106)
        Me.gb_domicilio.TabIndex = 24
        Me.gb_domicilio.TabStop = False
        Me.gb_domicilio.Text = "Domicilio"
        '
        'cbo_barrio
        '
        Me.cbo_barrio.FormattingEnabled = True
        Me.cbo_barrio.Location = New System.Drawing.Point(118, 78)
        Me.cbo_barrio.Name = "cbo_barrio"
        Me.cbo_barrio.Size = New System.Drawing.Size(238, 21)
        Me.cbo_barrio.TabIndex = 24
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(77, 78)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(34, 13)
        Me.lbl_barrio.TabIndex = 19
        Me.lbl_barrio.Text = "Barrio"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(81, 26)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 15
        Me.lbl_calle.Text = "Calle"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(370, 52)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 23
        Me.lbl_telefono.Text = "Telefono"
        '
        'lbl_nroCalle
        '
        Me.lbl_nroCalle.AutoSize = True
        Me.lbl_nroCalle.Location = New System.Drawing.Point(87, 52)
        Me.lbl_nroCalle.Name = "lbl_nroCalle"
        Me.lbl_nroCalle.Size = New System.Drawing.Size(24, 13)
        Me.lbl_nroCalle.TabIndex = 14
        Me.lbl_nroCalle.Text = "Nro"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(117, 23)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(472, 20)
        Me.txt_calle.TabIndex = 9
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(117, 49)
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(155, 20)
        Me.txt_nroCalle.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(434, 49)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(155, 20)
        Me.txt_telefono.TabIndex = 1
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Location = New System.Drawing.Point(400, 47)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(82, 13)
        Me.lbl_nroDoc.TabIndex = 22
        Me.lbl_nroDoc.Text = "Nro Documento"
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(400, 24)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDoc.TabIndex = 21
        Me.lbl_tipoDoc.Text = "Tipo Documento"
        '
        'lbl_fechaNac
        '
        Me.lbl_fechaNac.AutoSize = True
        Me.lbl_fechaNac.Location = New System.Drawing.Point(17, 76)
        Me.lbl_fechaNac.Name = "lbl_fechaNac"
        Me.lbl_fechaNac.Size = New System.Drawing.Size(93, 13)
        Me.lbl_fechaNac.TabIndex = 16
        Me.lbl_fechaNac.Text = "Fecha Nacimiento"
        '
        'lbl_apeAfiliado
        '
        Me.lbl_apeAfiliado.AutoSize = True
        Me.lbl_apeAfiliado.Location = New System.Drawing.Point(14, 50)
        Me.lbl_apeAfiliado.Name = "lbl_apeAfiliado"
        Me.lbl_apeAfiliado.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apeAfiliado.TabIndex = 13
        Me.lbl_apeAfiliado.Text = "Apellido"
        '
        'lbl_nomAfiliado
        '
        Me.lbl_nomAfiliado.AutoSize = True
        Me.lbl_nomAfiliado.Location = New System.Drawing.Point(14, 24)
        Me.lbl_nomAfiliado.Name = "lbl_nomAfiliado"
        Me.lbl_nomAfiliado.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nomAfiliado.TabIndex = 12
        Me.lbl_nomAfiliado.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(64, 21)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(305, 20)
        Me.txt_nombre.TabIndex = 35
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(64, 44)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(305, 20)
        Me.txt_apellido.TabIndex = 36
        '
        'frm_nuevoAfiliado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_nuevoAfiliado"
        Me.Text = "Afiliados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_afiliacion.ResumeLayout(False)
        Me.gb_afiliacion.PerformLayout()
        Me.gb_domicilio.ResumeLayout(False)
        Me.gb_domicilio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents gb_afiliacion As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipoAfiliado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaAlta As System.Windows.Forms.Label
    Friend WithEvents gb_domicilio As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_nroCalle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroCalle As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_apeAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_nomAfiliado As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb_fechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_afiliados_mensaje As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
