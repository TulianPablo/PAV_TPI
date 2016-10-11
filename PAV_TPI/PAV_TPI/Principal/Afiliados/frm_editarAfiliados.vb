Public Class frm_editarAfiliados

    Private Sub frm_editarAfiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nombre.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(0).Value
        txt_apellido.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(1).Value
        cbo_tipoDoc.SelectedText = frm_Afiliados.dgv_resultados.CurrentRow.Cells(2).Value
        txt_nroDoc.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(3).Value
        dtp_fechaNac.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(4).Value
        txt_calle.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(5).Value
        txt_nroCalle.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(6).Value
        cbo_barrio.SelectedText = frm_Afiliados.dgv_resultados.CurrentRow.Cells(7).Value
        txt_telefono.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(8).Value
        cbo_tipoAfiliado.SelectedText = frm_Afiliados.dgv_resultados.CurrentRow.Cells(9).Value
        txt_fechaAlta.Text = frm_Afiliados.dgv_resultados.CurrentRow.Cells(10).Value
        txt_fechaAlta.Enabled = False

        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

End Class