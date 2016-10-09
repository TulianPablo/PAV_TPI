<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_InicioSesion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_LogIn_usuario = New System.Windows.Forms.TextBox()
        Me.txt_LogIn_contraseña = New System.Windows.Forms.MaskedTextBox()
        Me.txt_SignIn_contraseña = New System.Windows.Forms.MaskedTextBox()
        Me.txt_SignIn_usuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_LogIn_mensaje = New System.Windows.Forms.Label()
        Me.lbl_SignIn_mensaje = New System.Windows.Forms.Label()
        Me.btn_registrarseHabilitar = New System.Windows.Forms.Button()
        Me.btn_registrarse = New System.Windows.Forms.Button()
        Me.btn_iniciarSesion = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.date_fechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(120, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 45)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Bienvenido/a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Clave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(594, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Clave"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(580, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Usuario"
        '
        'txt_LogIn_usuario
        '
        Me.txt_LogIn_usuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LogIn_usuario.Location = New System.Drawing.Point(128, 224)
        Me.txt_LogIn_usuario.Name = "txt_LogIn_usuario"
        Me.txt_LogIn_usuario.Size = New System.Drawing.Size(177, 25)
        Me.txt_LogIn_usuario.TabIndex = 0
        '
        'txt_LogIn_contraseña
        '
        Me.txt_LogIn_contraseña.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LogIn_contraseña.Location = New System.Drawing.Point(128, 256)
        Me.txt_LogIn_contraseña.Name = "txt_LogIn_contraseña"
        Me.txt_LogIn_contraseña.Size = New System.Drawing.Size(177, 25)
        Me.txt_LogIn_contraseña.TabIndex = 1
        Me.txt_LogIn_contraseña.UseSystemPasswordChar = True
        '
        'txt_SignIn_contraseña
        '
        Me.txt_SignIn_contraseña.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SignIn_contraseña.Location = New System.Drawing.Point(657, 100)
        Me.txt_SignIn_contraseña.Name = "txt_SignIn_contraseña"
        Me.txt_SignIn_contraseña.Size = New System.Drawing.Size(259, 25)
        Me.txt_SignIn_contraseña.TabIndex = 5
        Me.txt_SignIn_contraseña.UseSystemPasswordChar = True
        '
        'txt_SignIn_usuario
        '
        Me.txt_SignIn_usuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SignIn_usuario.Location = New System.Drawing.Point(657, 68)
        Me.txt_SignIn_usuario.Name = "txt_SignIn_usuario"
        Me.txt_SignIn_usuario.Size = New System.Drawing.Size(259, 25)
        Me.txt_SignIn_usuario.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Iniciar Sesión"
        '
        'lbl_LogIn_mensaje
        '
        Me.lbl_LogIn_mensaje.AutoSize = True
        Me.lbl_LogIn_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LogIn_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_LogIn_mensaje.Location = New System.Drawing.Point(35, 304)
        Me.lbl_LogIn_mensaje.Name = "lbl_LogIn_mensaje"
        Me.lbl_LogIn_mensaje.Size = New System.Drawing.Size(119, 17)
        Me.lbl_LogIn_mensaje.TabIndex = 14
        Me.lbl_LogIn_mensaje.Text = "lbl_LogIn_mensaje"
        '
        'lbl_SignIn_mensaje
        '
        Me.lbl_SignIn_mensaje.AutoSize = True
        Me.lbl_SignIn_mensaje.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SignIn_mensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_SignIn_mensaje.Location = New System.Drawing.Point(502, 304)
        Me.lbl_SignIn_mensaje.Name = "lbl_SignIn_mensaje"
        Me.lbl_SignIn_mensaje.Size = New System.Drawing.Size(124, 17)
        Me.lbl_SignIn_mensaje.TabIndex = 22
        Me.lbl_SignIn_mensaje.Text = "lbl_SignIn_mensaje"
        '
        'btn_registrarseHabilitar
        '
        Me.btn_registrarseHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrarseHabilitar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarseHabilitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrarseHabilitar.Location = New System.Drawing.Point(503, 26)
        Me.btn_registrarseHabilitar.Name = "btn_registrarseHabilitar"
        Me.btn_registrarseHabilitar.Size = New System.Drawing.Size(130, 30)
        Me.btn_registrarseHabilitar.TabIndex = 3
        Me.btn_registrarseHabilitar.Text = "Registrarse"
        Me.btn_registrarseHabilitar.UseVisualStyleBackColor = True
        '
        'btn_registrarse
        '
        Me.btn_registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrarse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_registrarse.Location = New System.Drawing.Point(933, 250)
        Me.btn_registrarse.Name = "btn_registrarse"
        Me.btn_registrarse.Size = New System.Drawing.Size(110, 35)
        Me.btn_registrarse.TabIndex = 11
        Me.btn_registrarse.Text = "Registrar"
        Me.btn_registrarse.UseVisualStyleBackColor = True
        '
        'btn_iniciarSesion
        '
        Me.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_iniciarSesion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_iniciarSesion.Location = New System.Drawing.Point(322, 250)
        Me.btn_iniciarSesion.Name = "btn_iniciarSesion"
        Me.btn_iniciarSesion.Size = New System.Drawing.Size(110, 35)
        Me.btn_iniciarSesion.TabIndex = 2
        Me.btn_iniciarSesion.Text = "Iniciar Sesión"
        Me.btn_iniciarSesion.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(657, 131)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(259, 25)
        Me.txt_nombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(576, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(657, 162)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(259, 25)
        Me.txt_apellido.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(576, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Apellido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'txt_mail
        '
        Me.txt_mail.Enabled = False
        Me.txt_mail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mail.Location = New System.Drawing.Point(657, 224)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(259, 25)
        Me.txt_mail.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(599, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Mail"
        '
        'date_fechaNac
        '
        Me.date_fechaNac.Enabled = False
        Me.date_fechaNac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_fechaNac.Location = New System.Drawing.Point(657, 193)
        Me.date_fechaNac.Name = "date_fechaNac"
        Me.date_fechaNac.Size = New System.Drawing.Size(259, 25)
        Me.date_fechaNac.TabIndex = 8
        Me.date_fechaNac.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
        '
        'cbo_perfil
        '
        Me.cbo_perfil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Location = New System.Drawing.Point(657, 256)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(259, 25)
        Me.cbo_perfil.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(196, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 50)
        Me.Label8.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(527, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Perfil de Usuario"
        '
        'frm_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1087, 360)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_perfil)
        Me.Controls.Add(Me.date_fechaNac)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_registrarseHabilitar)
        Me.Controls.Add(Me.lbl_SignIn_mensaje)
        Me.Controls.Add(Me.lbl_LogIn_mensaje)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_registrarse)
        Me.Controls.Add(Me.txt_SignIn_contraseña)
        Me.Controls.Add(Me.txt_SignIn_usuario)
        Me.Controls.Add(Me.btn_iniciarSesion)
        Me.Controls.Add(Me.txt_LogIn_contraseña)
        Me.Controls.Add(Me.txt_LogIn_usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frm_InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_LogIn_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_LogIn_contraseña As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_iniciarSesion As System.Windows.Forms.Button
    Friend WithEvents txt_SignIn_contraseña As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_SignIn_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrarse As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_LogIn_mensaje As System.Windows.Forms.Label
    Friend WithEvents lbl_SignIn_mensaje As System.Windows.Forms.Label
    Friend WithEvents btn_registrarseHabilitar As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents date_fechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_perfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
