﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bajaAfiliado
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
        Me.dtp_fechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.gb_afiliacion = New System.Windows.Forms.GroupBox()
        Me.txt_fechaBaja = New System.Windows.Forms.TextBox()
        Me.txt_fechaAlta = New System.Windows.Forms.TextBox()
        Me.lbl_fechaBaja = New System.Windows.Forms.Label()
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
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nroDoc = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gb_afiliacion.SuspendLayout()
        Me.gb_domicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fechaNac)
        Me.GroupBox1.Controls.Add(Me.cbo_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_aceptar)
        Me.GroupBox1.Controls.Add(Me.gb_afiliacion)
        Me.GroupBox1.Controls.Add(Me.gb_domicilio)
        Me.GroupBox1.Controls.Add(Me.lbl_nroDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.lbl_fechaNac)
        Me.GroupBox1.Controls.Add(Me.lbl_apeAfiliado)
        Me.GroupBox1.Controls.Add(Me.lbl_nomAfiliado)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 421)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dar de Baja"
        '
        'dtp_fechaNac
        '
        Me.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaNac.Location = New System.Drawing.Point(130, 76)
        Me.dtp_fechaNac.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtp_fechaNac.Name = "dtp_fechaNac"
        Me.dtp_fechaNac.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fechaNac.TabIndex = 29
        Me.dtp_fechaNac.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(489, 19)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(155, 21)
        Me.cbo_tipoDoc.TabIndex = 28
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(355, 374)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 29)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_aceptar.Location = New System.Drawing.Point(243, 374)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(96, 29)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'gb_afiliacion
        '
        Me.gb_afiliacion.BackColor = System.Drawing.SystemColors.Control
        Me.gb_afiliacion.Controls.Add(Me.txt_fechaBaja)
        Me.gb_afiliacion.Controls.Add(Me.txt_fechaAlta)
        Me.gb_afiliacion.Controls.Add(Me.lbl_fechaBaja)
        Me.gb_afiliacion.Controls.Add(Me.cbo_tipoAfiliado)
        Me.gb_afiliacion.Controls.Add(Me.lbl_tipoAfiliado)
        Me.gb_afiliacion.Controls.Add(Me.lbl_fechaAlta)
        Me.gb_afiliacion.Location = New System.Drawing.Point(13, 242)
        Me.gb_afiliacion.Name = "gb_afiliacion"
        Me.gb_afiliacion.Size = New System.Drawing.Size(639, 109)
        Me.gb_afiliacion.TabIndex = 25
        Me.gb_afiliacion.TabStop = False
        Me.gb_afiliacion.Text = "Afiliacion"
        '
        'txt_fechaBaja
        '
        Me.txt_fechaBaja.Location = New System.Drawing.Point(109, 59)
        Me.txt_fechaBaja.Name = "txt_fechaBaja"
        Me.txt_fechaBaja.Size = New System.Drawing.Size(110, 20)
        Me.txt_fechaBaja.TabIndex = 25
        '
        'txt_fechaAlta
        '
        Me.txt_fechaAlta.Location = New System.Drawing.Point(109, 30)
        Me.txt_fechaAlta.Name = "txt_fechaAlta"
        Me.txt_fechaAlta.Size = New System.Drawing.Size(110, 20)
        Me.txt_fechaAlta.TabIndex = 24
        '
        'lbl_fechaBaja
        '
        Me.lbl_fechaBaja.AutoSize = True
        Me.lbl_fechaBaja.Location = New System.Drawing.Point(37, 66)
        Me.lbl_fechaBaja.Name = "lbl_fechaBaja"
        Me.lbl_fechaBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_fechaBaja.TabIndex = 23
        Me.lbl_fechaBaja.Text = "Fecha Baja"
        '
        'cbo_tipoAfiliado
        '
        Me.cbo_tipoAfiliado.FormattingEnabled = True
        Me.cbo_tipoAfiliado.Location = New System.Drawing.Point(434, 49)
        Me.cbo_tipoAfiliado.Name = "cbo_tipoAfiliado"
        Me.cbo_tipoAfiliado.Size = New System.Drawing.Size(155, 21)
        Me.cbo_tipoAfiliado.TabIndex = 21
        '
        'lbl_tipoAfiliado
        '
        Me.lbl_tipoAfiliado.AutoSize = True
        Me.lbl_tipoAfiliado.Location = New System.Drawing.Point(354, 52)
        Me.lbl_tipoAfiliado.Name = "lbl_tipoAfiliado"
        Me.lbl_tipoAfiliado.Size = New System.Drawing.Size(65, 13)
        Me.lbl_tipoAfiliado.TabIndex = 18
        Me.lbl_tipoAfiliado.Text = "Tipo Afiliado"
        '
        'lbl_fechaAlta
        '
        Me.lbl_fechaAlta.AutoSize = True
        Me.lbl_fechaAlta.Location = New System.Drawing.Point(37, 31)
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
        Me.cbo_barrio.Location = New System.Drawing.Point(117, 76)
        Me.cbo_barrio.Name = "cbo_barrio"
        Me.cbo_barrio.Size = New System.Drawing.Size(256, 21)
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
        Me.txt_calle.MaxLength = 100
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(472, 20)
        Me.txt_calle.TabIndex = 9
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(117, 49)
        Me.txt_nroCalle.MaxLength = 10
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(155, 20)
        Me.txt_nroCalle.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(434, 49)
        Me.txt_telefono.MaxLength = 14
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
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(64, 47)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(305, 20)
        Me.txt_apellido.TabIndex = 11
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(489, 47)
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(155, 20)
        Me.txt_nroDoc.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(64, 21)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(305, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'frm_bajaAfiliado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_bajaAfiliado"
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
    Friend WithEvents dtp_fechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents gb_afiliacion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_fechaBaja As System.Windows.Forms.Label
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
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_fechaBaja As System.Windows.Forms.TextBox
    Friend WithEvents txt_fechaAlta As System.Windows.Forms.TextBox
End Class
