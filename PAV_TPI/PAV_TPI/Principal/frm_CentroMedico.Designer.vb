<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CentroMedico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CentroMedico))
        Me.lbl_nroCentroMedico = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_denominacion = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nroCalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.col_fechaBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvg_centrosMedicos = New System.Windows.Forms.DataGridView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        CType(Me.dvg_centrosMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nroCentroMedico
        '
        Me.lbl_nroCentroMedico.AutoSize = True
        Me.lbl_nroCentroMedico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroCentroMedico.Location = New System.Drawing.Point(111, 26)
        Me.lbl_nroCentroMedico.Name = "lbl_nroCentroMedico"
        Me.lbl_nroCentroMedico.Size = New System.Drawing.Size(77, 17)
        Me.lbl_nroCentroMedico.TabIndex = 0
        Me.lbl_nroCentroMedico.Text = "Nro. Centro"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(201, 23)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(129, 25)
        Me.txt_numero.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Denominación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calle"
        '
        'txt_denominacion
        '
        Me.txt_denominacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_denominacion.Location = New System.Drawing.Point(201, 54)
        Me.txt_denominacion.Name = "txt_denominacion"
        Me.txt_denominacion.Size = New System.Drawing.Size(365, 25)
        Me.txt_denominacion.TabIndex = 3
        '
        'txt_calle
        '
        Me.txt_calle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_calle.Location = New System.Drawing.Point(201, 97)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(200, 25)
        Me.txt_calle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nro."
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nroCalle.Location = New System.Drawing.Point(457, 97)
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(109, 25)
        Me.txt_nroCalle.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Barrio"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(201, 128)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(200, 25)
        Me.cmb_barrio.TabIndex = 9
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(132, 162)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(59, 17)
        Me.lbl_telefono.TabIndex = 10
        Me.lbl_telefono.Text = "Teléfono"
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(201, 159)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(200, 25)
        Me.txt_telefono.TabIndex = 11
        '
        'txt_mail
        '
        Me.txt_mail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mail.Location = New System.Drawing.Point(201, 190)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(365, 25)
        Me.txt_mail.TabIndex = 13
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(347, 20)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(30, 30)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mail"
        '
        'col_fechaBaja
        '
        Me.col_fechaBaja.HeaderText = "Fecha de Baja"
        Me.col_fechaBaja.Name = "col_fechaBaja"
        Me.col_fechaBaja.Width = 150
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "Mail"
        Me.col_mail.Name = "col_mail"
        Me.col_mail.Visible = False
        Me.col_mail.Width = 150
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Teléfono"
        Me.col_telefono.Name = "col_telefono"
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.Visible = False
        '
        'col_nroCalle
        '
        Me.col_nroCalle.HeaderText = "Nro. Calle"
        Me.col_nroCalle.Name = "col_nroCalle"
        Me.col_nroCalle.Visible = False
        '
        'col_Calle
        '
        Me.col_Calle.HeaderText = "Domicilio"
        Me.col_Calle.Name = "col_Calle"
        Me.col_Calle.Width = 150
        '
        'col_denominacion
        '
        Me.col_denominacion.HeaderText = "Denominación"
        Me.col_denominacion.Name = "col_denominacion"
        Me.col_denominacion.Width = 200
        '
        'col_nroCentro
        '
        Me.col_nroCentro.HeaderText = "Nro. Centro"
        Me.col_nroCentro.Name = "col_nroCentro"
        Me.col_nroCentro.Width = 110
        '
        'dvg_centrosMedicos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvg_centrosMedicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvg_centrosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_centrosMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nroCentro, Me.col_denominacion, Me.col_Calle, Me.col_nroCalle, Me.col_barrio, Me.col_telefono, Me.col_mail, Me.col_fechaBaja})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvg_centrosMedicos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dvg_centrosMedicos.Location = New System.Drawing.Point(29, 246)
        Me.dvg_centrosMedicos.Name = "dvg_centrosMedicos"
        Me.dvg_centrosMedicos.Size = New System.Drawing.Size(755, 156)
        Me.dvg_centrosMedicos.TabIndex = 14
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(29, 408)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(80, 32)
        Me.btn_agregar.TabIndex = 15
        Me.btn_agregar.Text = "Nuevo"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_borrar.Location = New System.Drawing.Point(201, 408)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(80, 32)
        Me.btn_borrar.TabIndex = 17
        Me.btn_borrar.Text = "Eliminar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(115, 408)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(80, 32)
        Me.btn_editar.TabIndex = 16
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_new.Location = New System.Drawing.Point(593, 185)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(80, 32)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "Buscar"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'frm_CentroMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(815, 463)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dvg_centrosMedicos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.cmb_barrio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nroCalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_denominacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_nroCentroMedico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CentroMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centros Médicos"
        CType(Me.dvg_centrosMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nroCentroMedico As System.Windows.Forms.Label
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_denominacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nroCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents col_fechaBaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dvg_centrosMedicos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
End Class
