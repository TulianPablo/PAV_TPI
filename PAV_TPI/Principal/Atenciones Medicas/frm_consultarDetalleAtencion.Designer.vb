<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consultarDetalleAtencion
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
        Me.cbo_profesional = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_ctroMedico = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_mensajeCentro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_apellidoNombre = New System.Windows.Forms.TextBox()
        Me.lbl_apellidoNombre = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.txt_nro_atencion = New System.Windows.Forms.TextBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nroAtencion = New System.Windows.Forms.Label()
        Me.dgv_practicas = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_subtotales = New System.Windows.Forms.Label()
        Me.txt_totales = New System.Windows.Forms.TextBox()
        Me.lbl_DescTot = New System.Windows.Forms.Label()
        Me.txt_descTotales = New System.Windows.Forms.TextBox()
        Me.txt_subTotales = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_profesional
        '
        Me.cbo_profesional.FormattingEnabled = True
        Me.cbo_profesional.Location = New System.Drawing.Point(93, 203)
        Me.cbo_profesional.Name = "cbo_profesional"
        Me.cbo_profesional.Size = New System.Drawing.Size(148, 21)
        Me.cbo_profesional.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Profesional"
        '
        'cbo_ctroMedico
        '
        Me.cbo_ctroMedico.FormattingEnabled = True
        Me.cbo_ctroMedico.Location = New System.Drawing.Point(93, 57)
        Me.cbo_ctroMedico.Name = "cbo_ctroMedico"
        Me.cbo_ctroMedico.Size = New System.Drawing.Size(162, 21)
        Me.cbo_ctroMedico.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Centro Médico"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(493, 28)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(106, 20)
        Me.dtp_fecha.TabIndex = 63
        Me.dtp_fecha.Value = New Date(2016, 10, 25, 14, 15, 48, 0)
        '
        'lbl_mensajeCentro
        '
        Me.lbl_mensajeCentro.AutoSize = True
        Me.lbl_mensajeCentro.Location = New System.Drawing.Point(291, 86)
        Me.lbl_mensajeCentro.Name = "lbl_mensajeCentro"
        Me.lbl_mensajeCentro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensajeCentro.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_apellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbl_apellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbl_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.txt_nroDoc)
        Me.GroupBox1.Controls.Add(Me.cbo_tipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 98)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Afiliado"
        '
        'txt_apellidoNombre
        '
        Me.txt_apellidoNombre.Location = New System.Drawing.Point(123, 53)
        Me.txt_apellidoNombre.Name = "txt_apellidoNombre"
        Me.txt_apellidoNombre.Size = New System.Drawing.Size(384, 20)
        Me.txt_apellidoNombre.TabIndex = 16
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
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(326, 25)
        Me.txt_nroDoc.Mask = "99999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(98, 20)
        Me.txt_nroDoc.TabIndex = 14
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(123, 22)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(89, 21)
        Me.cbo_tipoDoc.TabIndex = 12
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
        'cbo_especialidad
        '
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(93, 235)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(250, 21)
        Me.cbo_especialidad.TabIndex = 57
        '
        'txt_nro_atencion
        '
        Me.txt_nro_atencion.Location = New System.Drawing.Point(93, 19)
        Me.txt_nro_atencion.Name = "txt_nro_atencion"
        Me.txt_nro_atencion.Size = New System.Drawing.Size(52, 20)
        Me.txt_nro_atencion.TabIndex = 56
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(15, 235)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(67, 13)
        Me.lbl_especialidad.TabIndex = 55
        Me.lbl_especialidad.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Fecha"
        '
        'lbl_nroAtencion
        '
        Me.lbl_nroAtencion.AutoSize = True
        Me.lbl_nroAtencion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroAtencion.Location = New System.Drawing.Point(12, 21)
        Me.lbl_nroAtencion.Name = "lbl_nroAtencion"
        Me.lbl_nroAtencion.Size = New System.Drawing.Size(84, 15)
        Me.lbl_nroAtencion.TabIndex = 53
        Me.lbl_nroAtencion.Text = "Nro. Atención "
        '
        'dgv_practicas
        '
        Me.dgv_practicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_fecha, Me.col_nroAtencion, Me.col_Practica, Me.col_precio, Me.col_porcentaje, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(18, 299)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.Size = New System.Drawing.Size(581, 129)
        Me.dgv_practicas.TabIndex = 66
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Practicas"
        '
        'lbl_subtotales
        '
        Me.lbl_subtotales.AutoSize = True
        Me.lbl_subtotales.Location = New System.Drawing.Point(422, 502)
        Me.lbl_subtotales.Name = "lbl_subtotales"
        Me.lbl_subtotales.Size = New System.Drawing.Size(46, 13)
        Me.lbl_subtotales.TabIndex = 68
        Me.lbl_subtotales.Text = "Subtotal"
        '
        'txt_totales
        '
        Me.txt_totales.Location = New System.Drawing.Point(487, 443)
        Me.txt_totales.Name = "txt_totales"
        Me.txt_totales.Size = New System.Drawing.Size(68, 20)
        Me.txt_totales.TabIndex = 69
        '
        'lbl_DescTot
        '
        Me.lbl_DescTot.AutoSize = True
        Me.lbl_DescTot.Location = New System.Drawing.Point(422, 476)
        Me.lbl_DescTot.Name = "lbl_DescTot"
        Me.lbl_DescTot.Size = New System.Drawing.Size(59, 13)
        Me.lbl_DescTot.TabIndex = 70
        Me.lbl_DescTot.Text = "Descuento"
        '
        'txt_descTotales
        '
        Me.txt_descTotales.Location = New System.Drawing.Point(487, 469)
        Me.txt_descTotales.Name = "txt_descTotales"
        Me.txt_descTotales.Size = New System.Drawing.Size(68, 20)
        Me.txt_descTotales.TabIndex = 69
        '
        'txt_subTotales
        '
        Me.txt_subTotales.Location = New System.Drawing.Point(487, 495)
        Me.txt_subTotales.Name = "txt_subTotales"
        Me.txt_subTotales.Size = New System.Drawing.Size(68, 20)
        Me.txt_subTotales.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Total"
        '
        'frm_consultarDetalleAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 528)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_DescTot)
        Me.Controls.Add(Me.txt_subTotales)
        Me.Controls.Add(Me.txt_descTotales)
        Me.Controls.Add(Me.txt_totales)
        Me.Controls.Add(Me.lbl_subtotales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_practicas)
        Me.Controls.Add(Me.cbo_profesional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_ctroMedico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_mensajeCentro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbo_especialidad)
        Me.Controls.Add(Me.txt_nro_atencion)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nroAtencion)
        Me.Name = "frm_consultarDetalleAtencion"
        Me.Text = "Detalle de Atención Médica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_profesional As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_ctroMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_mensajeCentro As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellidoNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nro_atencion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_nroAtencion As System.Windows.Forms.Label
    Friend WithEvents dgv_practicas As System.Windows.Forms.DataGridView
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotales As System.Windows.Forms.Label
    Friend WithEvents txt_totales As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescTot As System.Windows.Forms.Label
    Friend WithEvents txt_descTotales As System.Windows.Forms.TextBox
    Friend WithEvents txt_subTotales As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
