Public Class frm_principal
    Public form_especialidades As frm_Especialidades
    Public form_CentrosMedicos As frm_CentroMedico
    Public form_TipoAfiliado As frm_TipoAfiliado
    Public form_Practicas As frm_Practicas
    Public form_Afiliados As frm_Afiliados
    Public form_Atenciones As frm_ConsultarAtenciones
    Public form_Profesionales As frm_Profesionales

    Private Sub btn_especialidades_Click(sender As Object, e As EventArgs) Handles btn_especialidades.Click
        form_especialidades = New frm_Especialidades
        form_especialidades.Show()
    End Sub

    Private Sub btn_centrosMedicos_Click(sender As Object, e As EventArgs) Handles btn_centrosMedicos.Click
        form_CentrosMedicos = New frm_CentroMedico
        form_CentrosMedicos.Show()
    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_obraSocial.Width = Me.Width
        lbl_menu.Width = Me.Width
        lbl_portada.Width = Me.Width

    End Sub

    Private Sub frm_principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            Dim form_inicioSesion = New frm_InicioSesion
            form_inicioSesion.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_tiposAfiliados_Click(sender As Object, e As EventArgs) Handles btn_tiposAfiliados.Click
        form_TipoAfiliado = New frm_TipoAfiliado
        form_TipoAfiliado.Show()
    End Sub

    Private Sub btn_practicas_Click(sender As Object, e As EventArgs) Handles btn_practicas.Click
        form_Practicas = New frm_Practicas
        form_Practicas.Show()
    End Sub

    Private Sub btn_afiliados_Click(sender As Object, e As EventArgs) Handles btn_afiliados.Click
        form_Afiliados = New frm_Afiliados
        form_Afiliados.Show()
    End Sub

    Private Sub btn_atenciones_Click(sender As Object, e As EventArgs) Handles btn_atenciones.Click
        form_Atenciones = New frm_ConsultarAtenciones
        form_Atenciones.Show()
    End Sub

    Private Sub btn_profesionales_Click(sender As Object, e As EventArgs) Handles btn_profesionales.Click
        form_Profesionales = New frm_Profesionales
        form_Profesionales.Show()
    End Sub


    'PARA MODIFICAR EL COLOR DE LOS BOTONES CUANDO ESTAN DESHABILITADOS
    Private Sub btn_especialidades_EnabledChanged(sender As Object, e As EventArgs) Handles btn_especialidades.EnabledChanged
        Colores.ChangeColor(btn_especialidades)
    End Sub

    Private Sub btn_centrosMedicos_EnabledChanged(sender As Object, e As EventArgs) Handles btn_centrosMedicos.EnabledChanged
        Colores.ChangeColor(btn_centrosMedicos)
    End Sub

    Private Sub btn_practicas_EnabledChanged(sender As Object, e As EventArgs) Handles btn_practicas.EnabledChanged
        Colores.ChangeColor(btn_practicas)
    End Sub

    Private Sub btn_afiliados_EnabledChanged(sender As Object, e As EventArgs) Handles btn_afiliados.EnabledChanged
        Colores.ChangeColor(btn_afiliados)
    End Sub

    Private Sub btn_tiposAfiliados_EnabledChanged(sender As Object, e As EventArgs) Handles btn_tiposAfiliados.EnabledChanged
        Colores.ChangeColor(btn_tiposAfiliados)
    End Sub

    Private Sub btn_profesionales_EnabledChanged(sender As Object, e As EventArgs) Handles btn_profesionales.EnabledChanged
        Colores.ChangeColor(btn_profesionales)
    End Sub

    Private Sub btn_cuotas_Click(sender As Object, e As EventArgs) Handles btn_cuotas.Click
        Colores.ChangeColor(btn_cuotas)
    End Sub

    Private Sub btn_informes_Click(sender As Object, e As EventArgs) Handles btn_informes.Click
        Colores.ChangeColor(btn_informes)
        frm_MenuReportes.ShowDialog()


    End Sub

    Private Sub btn_atenciones_EnabledChanged(sender As Object, e As EventArgs) Handles btn_atenciones.EnabledChanged
        Colores.ChangeColor(btn_atenciones)
    End Sub

    Private Sub btn_pagos_Click(sender As Object, e As EventArgs) Handles btn_pagos.Click
        Colores.ChangeColor(btn_pagos)
    End Sub

End Class
