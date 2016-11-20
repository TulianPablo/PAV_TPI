Public Class frm_editarProfesional
    Public form_Profesional As frm_Profesionales

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Desea actualizar los datos del profesional?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            ''If validar_campos_completos() Then
            Dim str As String = "UPDATE [dbo].[Profesional] SET "
            str &= "[matricula] = '" + txt_matricula.Text + "', "
            str &= "[nombre] = '" + txt_nombre.Text + "', "
            str &= "[apellido] = '" + txt_apellido.Text + "', "
            str &= "[fecha_nac] = '" + dtp_fechaNac.Text + "', "
            str &= "[calle] = '" + txt_calle.Text + "', "
            str &= "[nro] = " + txt_nroCalle.Text + ", "
            str &= "[id_barrio] = " + cbo_barrio.SelectedValue.ToString() + ", "
            str &= "[telefono] = " + txt_telefono.Text
            str &= " WHERE nro_doc = " + txt_nroDoc.Text + " AND id_tipoDoc = " + cbo_tipoDoc.SelectedValue.ToString

            BDHelper.getDBHelper.EjecutarSQL(str)
            Me.Close()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_editarProfesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")

        txt_matricula.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(0).Value
        txt_nombre.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(1).Value
        txt_apellido.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(2).Value
        cbo_tipoDoc.SelectedValue = form_Profesional.dgv_resultados.CurrentRow.Cells(3).Value
        txt_nroDoc.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(4).Value
        dtp_fechaNac.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(5).Value
        txt_calle.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(6).Value
        txt_nroCalle.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(7).Value
        cbo_barrio.SelectedValue = form_Profesional.dgv_resultados.CurrentRow.Cells(8).Value
        txt_telefono.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(9).Value
        txt_fechaAlta.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(10).Value
        txt_fechaAlta.Enabled = False

        cbo_tipoDoc.Enabled = False
        txt_nroDoc.Enabled = False

        txt_fechaBaja.Visible = False
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub
End Class