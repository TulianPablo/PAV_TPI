Public Class frm_Profesionales
    Public form_nuevoProfesional As frm_nuevoProfesional

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        form_nuevoProfesional = New frm_nuevoProfesional
        form_nuevoProfesional.Show()
    End Sub

    Private Sub frm_Profesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_profesionales_mensaje.Visible = False
        btn_editar.Enabled = False
        btn_borrar.Enabled = False

        dgv_resultados.Columns(11).Visible = False
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub


End Class