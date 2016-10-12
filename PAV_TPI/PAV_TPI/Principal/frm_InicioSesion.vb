Public Class frm_InicioSesion

    Enum estado
        login
        signin
    End Enum
    Dim accion = estado.login
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim consulta As String
    Public form_principal As frm_principal

    Private Sub frm_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configuracion de campos
        lbl_LogIn_mensaje.Visible = False
        lbl_SignIn_mensaje.Visible = False
        CargarCombo(cbo_perfil, BDHelper.GetPerfiles(), "id_perfil", "nombre")
        enable_login(True)
    End Sub

    Private Sub enable_login(flag As Boolean)
        'campos login
        txt_LogIn_contraseña.Enabled = flag
        btn_iniciarSesion.Enabled = flag
        'campos signin
        txt_SignIn_usuario.Enabled = Not flag
        txt_SignIn_contraseña.Enabled = Not flag
        txt_nombre.Enabled = Not flag
        txt_apellido.Enabled = Not flag
        date_fechaNac.Enabled = Not flag
        txt_mail.Enabled = Not flag
        btn_registrarse.Enabled = Not flag
        cbo_perfil.Enabled = Not flag
        cbo_perfil.SelectedIndex = -1


        If (flag) Then
            'blanqueo campos signin
            txt_SignIn_usuario.Text = ""
            txt_SignIn_contraseña.Text = ""
            txt_nombre.Text = ""
            txt_apellido.Text = ""
            txt_mail.Text = ""
        Else
            'blanqueo campos login
            txt_LogIn_usuario.Text = ""
            txt_LogIn_contraseña.Text = ""
        End If
    End Sub

    Private Sub frm_InicioSesion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_registrarseHabilitar_Click(sender As Object, e As EventArgs) Handles btn_registrarseHabilitar.Click
        enable_login(False)
        lbl_LogIn_mensaje.Visible = False
        accion = estado.signin
    End Sub

    Private Function registrar_usuario() As termino
        Dim fecha_alta As DateTime
        consulta = "INSERT INTO Usuario (usuario, password, nombre, apellido, fecha_Nac, mail, fecha_alta, id_perfil) "
        consulta += "VALUES ('" + txt_SignIn_usuario.Text
        consulta += "' , '" + txt_SignIn_contraseña.Text
        consulta += "' , '" + txt_nombre.Text
        consulta += "' , '" + txt_apellido.Text
        consulta += "' , '" + date_fechaNac.Text
        consulta += "' , '" + txt_mail.Text
        consulta += "' , '" + fecha_alta
        consulta += "' , " + cbo_perfil.SelectedIndex.ToString + ")"

        BDHelper.getDBHelper.EjecutarSQL(consulta)
        Return termino.aprobado

    End Function

    Private Sub txt_LogIn_usuario_GotFocus(sender As Object, e As EventArgs) Handles txt_LogIn_usuario.GotFocus
        enable_login(True)

        accion = estado.login
    End Sub

    Private Sub btn_iniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciarSesion.Click

        Dim perfil_log As String
        Dim userLog As Usuario
        'verificacion de campos
        If (String.IsNullOrEmpty(txt_LogIn_usuario.Text) Or String.IsNullOrEmpty(txt_LogIn_contraseña.Text)) Then
            lbl_LogIn_mensaje.Text = "Faltan datos."
            lbl_LogIn_mensaje.Visible = True
            Return
        End If
        'validacion de datos
        userLog = validar_existencia(txt_LogIn_usuario.Text, txt_LogIn_contraseña.Text)
        If (userLog IsNot Nothing) Then
            frm_principal.lbl_usuarioLogueado.Text = txt_LogIn_usuario.Text
            'Obtencion del perfil logueado 
            perfil_log = getPerfilLogueado(userLog.id_perfil)
            habilitar_deshabilitarPorPerfil(perfil_log)
            frm_principal.Show()
            Me.Visible = False

        Else
            lbl_LogIn_mensaje.Text = "El usuario ingresado no existe o la clave no es válida."
            lbl_LogIn_mensaje.Visible = True
        End If
    End Sub

    Private Function validar_existencia(usuario As String, contraseña As String) As Usuario

        Dim oUser As Usuario = Nothing
        Dim oTable As DataTable

        'Armamos el query para ejecutar a la base
        Dim strSQL As String = "SELECT usuario, password, id_perfil from Usuario WHERE usuario = '" + usuario + "' AND password = '" + contraseña + "'"
        'Delegamos la ejecución del comando SQL al Helper
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        'Con la tabla devuelta por el Helper creamos un OBJETO User a partir de los datos de fila de la tabla Users
        If oTable.Rows.Count > 0 Then
            oUser = New Usuario()
            oUser.usuario = oTable.Rows(0).Item("usuario").ToString
            oUser.password = oTable.Rows(0).Item("password").ToString
            oUser.id_perfil = oTable.Rows(0).Item("id_perfil").ToString

        End If

        Return oUser
    End Function

    Private Function verificar_existencia(usuario As String) As Boolean
        consulta = "SELECT usuario FROM Usuario "
        consulta &= "WHERE usuario = '" + Usuario + "' "

        If (BDHelper.getDBHelper.ConsultaSQL(consulta).Rows.Count = 1) Then

            Return False
        End If
        Return True
    End Function

    Private Sub btn_registrarse_Click(sender As Object, e As EventArgs) Handles btn_registrarse.Click
       
        If (validar_campos()) Then  
            If (verificar_existencia(txt_SignIn_usuario.Text)) Then
                If (registrar_usuario() = termino.aprobado) Then
                    lbl_SignIn_mensaje.Text = "El usuario se registró con éxito."
                    lbl_SignIn_mensaje.Visible = True
                End If
            Else
                lbl_SignIn_mensaje.Text = "El usuario " + txt_SignIn_usuario.Text + " ya está registrado."
                lbl_SignIn_mensaje.Visible = True

            End If
        Else
            lbl_SignIn_mensaje.Text = "Debe ingresar TODOS los datos ."
            lbl_SignIn_mensaje.Visible = True
        End If

    End Sub

    Private Sub txt_SignIn_usuario_GotFocus(sender As Object, e As EventArgs) Handles txt_SignIn_usuario.GotFocus
        'configuracion de campos
        lbl_SignIn_mensaje.Visible = False
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Function validar_campos() As Boolean
        If (txt_SignIn_usuario.Text = "" Or txt_SignIn_contraseña.Text = "" Or txt_nombre.Text = "" Or txt_apellido.Text = "" Or date_fechaNac.Text = "" Or txt_mail.Text = "" Or cbo_perfil.SelectedIndex = -1) Then

            Return False
        Else
            Return True
        End If
    End Function

    Private Sub habilitar_deshabilitarPorPerfil(ByVal perfil As String)
        With frm_principal
            If (perfil = "Encargado") Then

                .btn_afiliados.Enabled = False
                .btn_informes.Enabled = False
                .btn_pagos.Enabled = False
                .btn_cuotas.Enabled = False
                .btn_tiposAfiliados.Enabled = False
                .btn_centrosMedicos.Enabled = False

            Else
                .btn_atenciones.Enabled = False
                .btn_practicas.Enabled = False
                .btn_especialidades.Enabled = False

            End If
        End With
    End Sub

    Private Function getPerfilLogueado(id_perfil As Integer) As String
        Dim consulta As String
        Dim otable As DataTable
        consulta = "SELECT nombre FROM Perfil WHERE id_perfil =" + id_perfil.ToString
        otable = BDHelper.getDBHelper.ConsultaSQL(consulta)
        Return otable.Rows(0).Item("nombre").ToString

    End Function

End Class