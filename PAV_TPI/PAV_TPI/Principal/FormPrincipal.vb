Public Class frm_principal
    Public form_especialidades As frm_Especialidades
    Public form_CentrosMedicos As frm_CentroMedico
    Public form_TipoAfiliado As frm_TipoAfiliado
    Public form_Practicas As frm_Practicas
    Public form_Afiliados As frm_Afiliados

    'FORMULARIO DE PRUEBA, DESPUES HAY QUE BORRARLO ***********************************************************************************************
    Public form_IniciarSesion As frm_InicioSesion
    'BOTON DE PRUEBA, DESPUES HAY QUE BORRARLO ****************************************************************************************************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_IniciarSesion = New frm_InicioSesion
        form_IniciarSesion.Show()
    End Sub


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
End Class
