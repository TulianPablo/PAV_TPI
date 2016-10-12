<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevoProfesional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nuevoProfesional))
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_profesionales_mensaje = New System.Windows.Forms.Label()
        Me.dtp_fechaNac = New System.Windows.Forms.DateTimePicker()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.txt_fechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fechaAlta = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_fechaNac = New System.Windows.Forms.Label()
        Me.lbl_apeAfiliado = New System.Windows.Forms.Label()
        Me.lbl_nomAfiliado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_nroCalle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.box_datosPersonales = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nroCalle = New System.Windows.Forms.MaskedTextBox()
        Me.box_datosPersonales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_apellido
        '
        Me.txt_apellido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(100, 97)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(247, 25)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(100, 66)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(247, 25)
        Me.txt_nombre.TabIndex = 1
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
        'lbl_profesionales_mensaje
        '
        Me.lbl_profesionales_mensaje.AutoSize = True
        Me.lbl_profesionales_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profesionales_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_profesionales_mensaje.Location = New System.Drawing.Point(71, 461)
        Me.lbl_profesionales_mensaje.Name = "lbl_profesionales_mensaje"
        Me.lbl_profesionales_mensaje.Size = New System.Drawing.Size(167, 17)
        Me.lbl_profesionales_mensaje.TabIndex = 7
        Me.lbl_profesionales_mensaje.Text = "lbl_profesionales_mensaje"
        '
        'dtp_fechaNac
        '
        Me.dtp_fechaNac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaNac.Location = New System.Drawing.Point(522, 95)
        Me.dtp_fechaNac.MaxDate = New Date(2016, 10, 9, 0, 0, 0, 0)
        Me.dtp_fechaNac.Name = "dtp_fechaNac"
        Me.dtp_fechaNac.Size = New System.Drawing.Size(182, 25)
        Me.dtp_fechaNac.TabIndex = 5
        Me.dtp_fechaNac.Value = New Date(2016, 10, 9, 0, 0, 0, 0)
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(445, 495)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 29)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_aceptar.Location = New System.Drawing.Point(333, 495)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(96, 29)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
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
        'txt_fechaAlta
        '
        Me.txt_fechaAlta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fechaAlta.Location = New System.Drawing.Point(174, 411)
        Me.txt_fechaAlta.Mask = "00/00/0000"
        Me.txt_fechaAlta.Name = "txt_fechaAlta"
        Me.txt_fechaAlta.Size = New System.Drawing.Size(100, 25)
        Me.txt_fechaAlta.TabIndex = 2
        Me.txt_fechaAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_fechaAlta.ValidatingType = GetType(Date)
        '
        'lbl_fechaAlta
        '
        Me.lbl_fechaAlta.AutoSize = True
        Me.lbl_fechaAlta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaAlta.Location = New System.Drawing.Point(96, 414)
        Me.lbl_fechaAlta.Name = "lbl_fechaAlta"
        Me.lbl_fechaAlta.Size = New System.Drawing.Size(67, 17)
        Me.lbl_fechaAlta.TabIndex = 5
        Me.lbl_fechaAlta.Text = "Fecha Alta"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.ForeColor = System.Drawing.Color.Black
        Me.lbl_telefono.Location = New System.Drawing.Point(458, 129)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(58, 17)
        Me.lbl_telefono.TabIndex = 13
        Me.lbl_telefono.Text = "Teléfono"
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroDoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_nroDoc.Location = New System.Drawing.Point(414, 67)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(105, 17)
        Me.lbl_nroDoc.TabIndex = 11
        Me.lbl_nroDoc.Text = "Nro. Documento"
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoDoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(414, 38)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(105, 17)
        Me.lbl_tipoDoc.TabIndex = 10
        Me.lbl_tipoDoc.Text = "Tipo Documento"
        '
        'lbl_fechaNac
        '
        Me.lbl_fechaNac.AutoSize = True
        Me.lbl_fechaNac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaNac.ForeColor = System.Drawing.Color.Black
        Me.lbl_fechaNac.Location = New System.Drawing.Point(382, 100)
        Me.lbl_fechaNac.Name = "lbl_fechaNac"
        Me.lbl_fechaNac.Size = New System.Drawing.Size(130, 17)
        Me.lbl_fechaNac.TabIndex = 12
        Me.lbl_fechaNac.Text = "Fecha de Nacimiento"
        '
        'lbl_apeAfiliado
        '
        Me.lbl_apeAfiliado.AutoSize = True
        Me.lbl_apeAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apeAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lbl_apeAfiliado.Location = New System.Drawing.Point(37, 103)
        Me.lbl_apeAfiliado.Name = "lbl_apeAfiliado"
        Me.lbl_apeAfiliado.Size = New System.Drawing.Size(56, 17)
        Me.lbl_apeAfiliado.TabIndex = 9
        Me.lbl_apeAfiliado.Text = "Apellido"
        '
        'lbl_nomAfiliado
        '
        Me.lbl_nomAfiliado.AutoSize = True
        Me.lbl_nomAfiliado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomAfiliado.ForeColor = System.Drawing.Color.Black
        Me.lbl_nomAfiliado.Location = New System.Drawing.Point(37, 69)
        Me.lbl_nomAfiliado.Name = "lbl_nomAfiliado"
        Me.lbl_nomAfiliado.Size = New System.Drawing.Size(57, 17)
        Me.lbl_nomAfiliado.TabIndex = 8
        Me.lbl_nomAfiliado.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Matrícula"
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
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(522, 126)
        Me.txt_telefono.Mask = "(999)000-000-000"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(182, 25)
        Me.txt_telefono.TabIndex = 6
        Me.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nuevo Profesional"
        '
        'cbo_barrio
        '
        Me.cbo_barrio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_barrio.FormattingEnabled = True
        Me.cbo_barrio.Location = New System.Drawing.Point(100, 66)
        Me.cbo_barrio.Name = "cbo_barrio"
        Me.cbo_barrio.Size = New System.Drawing.Size(247, 25)
        Me.cbo_barrio.TabIndex = 2
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barrio.ForeColor = System.Drawing.Color.Black
        Me.lbl_barrio.Location = New System.Drawing.Point(46, 69)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(43, 17)
        Me.lbl_barrio.TabIndex = 5
        Me.lbl_barrio.Text = "Barrio"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calle.ForeColor = System.Drawing.Color.Black
        Me.lbl_calle.Location = New System.Drawing.Point(53, 38)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(36, 17)
        Me.lbl_calle.TabIndex = 3
        Me.lbl_calle.Text = "Calle"
        '
        'lbl_nroCalle
        '
        Me.lbl_nroCalle.AutoSize = True
        Me.lbl_nroCalle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroCalle.ForeColor = System.Drawing.Color.Black
        Me.lbl_nroCalle.Location = New System.Drawing.Point(377, 38)
        Me.lbl_nroCalle.Name = "lbl_nroCalle"
        Me.lbl_nroCalle.Size = New System.Drawing.Size(34, 17)
        Me.lbl_nroCalle.TabIndex = 4
        Me.lbl_nroCalle.Text = "Nro."
        '
        'txt_calle
        '
        Me.txt_calle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_calle.Location = New System.Drawing.Point(100, 35)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(247, 25)
        Me.txt_calle.TabIndex = 0
        '
        'box_datosPersonales
        '
        Me.box_datosPersonales.Controls.Add(Me.txt_matricula)
        Me.box_datosPersonales.Controls.Add(Me.lbl_nomAfiliado)
        Me.box_datosPersonales.Controls.Add(Me.lbl_apeAfiliado)
        Me.box_datosPersonales.Controls.Add(Me.lbl_fechaNac)
        Me.box_datosPersonales.Controls.Add(Me.lbl_tipoDoc)
        Me.box_datosPersonales.Controls.Add(Me.lbl_nroDoc)
        Me.box_datosPersonales.Controls.Add(Me.cbo_tipoDoc)
        Me.box_datosPersonales.Controls.Add(Me.dtp_fechaNac)
        Me.box_datosPersonales.Controls.Add(Me.lbl_telefono)
        Me.box_datosPersonales.Controls.Add(Me.txt_nroDoc)
        Me.box_datosPersonales.Controls.Add(Me.txt_telefono)
        Me.box_datosPersonales.Controls.Add(Me.txt_nombre)
        Me.box_datosPersonales.Controls.Add(Me.txt_apellido)
        Me.box_datosPersonales.Controls.Add(Me.Label1)
        Me.box_datosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_datosPersonales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_datosPersonales.ForeColor = System.Drawing.Color.Teal
        Me.box_datosPersonales.Location = New System.Drawing.Point(74, 80)
        Me.box_datosPersonales.Name = "box_datosPersonales"
        Me.box_datosPersonales.Size = New System.Drawing.Size(736, 182)
        Me.box_datosPersonales.TabIndex = 0
        Me.box_datosPersonales.TabStop = False
        Me.box_datosPersonales.Text = "Datos personales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nroCalle)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Controls.Add(Me.cbo_barrio)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.lbl_barrio)
        Me.GroupBox1.Controls.Add(Me.lbl_nroCalle)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(74, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domicilio"
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(419, 35)
        Me.txt_nroCalle.Mask = "9999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(100, 25)
        Me.txt_nroCalle.TabIndex = 1
        Me.txt_nroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_nuevoProfesional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(874, 551)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.box_datosPersonales)
        Me.Controls.Add(Me.txt_fechaAlta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fechaAlta)
        Me.Controls.Add(Me.lbl_profesionales_mensaje)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_nuevoProfesional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesionales"
        Me.box_datosPersonales.ResumeLayout(False)
        Me.box_datosPersonales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_profesionales_mensaje As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_fechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fechaAlta As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_apeAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_nomAfiliado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_nroCalle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents box_datosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nroCalle As System.Windows.Forms.MaskedTextBox
End Class
