<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Practicas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dgv_resultados = New System.Windows.Forms.DataGridView()
        Me.id_practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.lbl_Practica_mensaje = New System.Windows.Forms.Label()
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id. Práctica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Especialidad"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(245, 25)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(262, 25)
        Me.txt_id.TabIndex = 3
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(245, 58)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(262, 25)
        Me.txt_nombre.TabIndex = 4
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(245, 92)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(262, 25)
        Me.cbo_especialidad.TabIndex = 5
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btn_buscar.Location = New System.Drawing.Point(514, 89)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(90, 31)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dgv_resultados
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_resultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_practica, Me.nombre, Me.especialidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_resultados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_resultados.Location = New System.Drawing.Point(34, 138)
        Me.dgv_resultados.Name = "dgv_resultados"
        Me.dgv_resultados.Size = New System.Drawing.Size(644, 217)
        Me.dgv_resultados.TabIndex = 7
        '
        'id_practica
        '
        Me.id_practica.HeaderText = "Id. Práctica"
        Me.id_practica.Name = "id_practica"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 250
        '
        'especialidad
        '
        Me.especialidad.HeaderText = "Especialidad"
        Me.especialidad.Name = "especialidad"
        Me.especialidad.Width = 250
        '
        'btn_editar
        '
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(130, 361)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(90, 30)
        Me.btn_editar.TabIndex = 10
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_nuevo.Location = New System.Drawing.Point(34, 361)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(90, 30)
        Me.btn_nuevo.TabIndex = 9
        Me.btn_nuevo.Text = "Nueva"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quitar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_quitar.Location = New System.Drawing.Point(226, 361)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(90, 30)
        Me.btn_quitar.TabIndex = 8
        Me.btn_quitar.Text = "Cancelar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'lbl_Practica_mensaje
        '
        Me.lbl_Practica_mensaje.AutoSize = True
        Me.lbl_Practica_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Practica_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_Practica_mensaje.Location = New System.Drawing.Point(322, 368)
        Me.lbl_Practica_mensaje.Name = "lbl_Practica_mensaje"
        Me.lbl_Practica_mensaje.Size = New System.Drawing.Size(135, 17)
        Me.lbl_Practica_mensaje.TabIndex = 23
        Me.lbl_Practica_mensaje.Text = "lbl_Practica_mensaje"
        '
        'frm_Practicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(713, 411)
        Me.Controls.Add(Me.lbl_Practica_mensaje)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.dgv_resultados)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cbo_especialidad)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frm_Practicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prácticas"
        CType(Me.dgv_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents dgv_resultados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents id_practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Practica_mensaje As System.Windows.Forms.Label
End Class
