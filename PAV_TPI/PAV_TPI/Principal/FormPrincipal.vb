Public Class frm_principal
    Public form_especialidades As frm_Especialidades
    Public form_CentrosMedicos As frm_CentroMedico
    Public form_TipoAfiliado As frm_TipoAfiliado
    Public form_Practicas As frm_Practicas
    Public form_Afiliados As frm_Afiliados
    Public form_Atenciones As Atenciones_Medicas
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
        form_Atenciones = New Atenciones_Medicas
        form_Atenciones.Show()
    End Sub

    Private Sub btn_profesionales_Click(sender As Object, e As EventArgs) Handles btn_profesionales.Click
        form_Profesionales = New frm_Profesionales
        form_Profesionales.Show()
    End Sub

    Private Sub btn_especialidades_EnabledChanged(sender As Object, e As EventArgs) Handles btn_especialidades.EnabledChanged
        If (btn_especialidades.Enabled = False) Then
            btn_especialidades.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_centrosMedicos_EnabledChanged(sender As Object, e As EventArgs) Handles btn_centrosMedicos.EnabledChanged
        If (btn_centrosMedicos.Enabled = False) Then
            btn_especialidades.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_practicas_EnabledChanged(sender As Object, e As EventArgs) Handles btn_practicas.EnabledChanged
        If (btn_practicas.Enabled = False) Then
            btn_practicas.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_afiliados_EnabledChanged(sender As Object, e As EventArgs) Handles btn_afiliados.EnabledChanged
        If (btn_afiliados.Enabled = False) Then
            btn_afiliados.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_tiposAfiliados_EnabledChanged(sender As Object, e As EventArgs) Handles btn_tiposAfiliados.EnabledChanged
        If (btn_tiposAfiliados.Enabled = False) Then
            btn_tiposAfiliados.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_profesionales_EnabledChanged(sender As Object, e As EventArgs) Handles btn_profesionales.EnabledChanged
        If (btn_profesionales.Enabled = False) Then
            btn_profesionales.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_cuotas_Click(sender As Object, e As EventArgs) Handles btn_cuotas.Click
        If (btn_cuotas.Enabled = False) Then
            btn_cuotas.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_informes_Click(sender As Object, e As EventArgs) Handles btn_informes.Click
        If (btn_informes.Enabled = False) Then
            btn_informes.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_atenciones_EnabledChanged(sender As Object, e As EventArgs) Handles btn_atenciones.EnabledChanged
        If (btn_atenciones.Enabled = False) Then
            btn_atenciones.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btn_pagos_Click(sender As Object, e As EventArgs) Handles btn_pagos.Click
        If (btn_pagos.Enabled = False) Then
            btn_pagos.BackColor = Color.LightGray
        End If
    End Sub
End Class
