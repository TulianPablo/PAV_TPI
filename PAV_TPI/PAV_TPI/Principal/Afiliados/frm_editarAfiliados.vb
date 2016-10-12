Public Class frm_editarAfiliados

    Public formConsulta As frm_Afiliados

    Private Sub frm_editarAfiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")

        txt_nombre.Text = formConsulta.dgv_resultados.CurrentRow.Cells(0).Value
        txt_apellido.Text = formConsulta.dgv_resultados.CurrentRow.Cells(1).Value
        cbo_tipoDoc.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(2).Value
        txt_nroDoc.Text = formConsulta.dgv_resultados.CurrentRow.Cells(3).Value
        dtp_fechaNac.Text = formConsulta.dgv_resultados.CurrentRow.Cells(4).Value
        txt_calle.Text = formConsulta.dgv_resultados.CurrentRow.Cells(5).Value
        txt_nroCalle.Text = formConsulta.dgv_resultados.CurrentRow.Cells(6).Value
        cbo_barrio.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(7).Value
        txt_telefono.Text = formConsulta.dgv_resultados.CurrentRow.Cells(8).Value
        cbo_tipoAfiliado.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(9).Value
        txt_fechaAlta.Text = formConsulta.dgv_resultados.CurrentRow.Cells(10).Value


        txt_fechaAlta.Enabled = False

        cbo_tipoDoc.Enabled = False
        txt_nroDoc.Enabled = False

        txt_fechaBaja.Visible = False


    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Desea actualizar afiliado?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            ''If validar_campos_completos() Then
            Dim str As String = "UPDATE [dbo].[Afiliado] SET"
            str &= "[nombre] = '" + txt_nombre.Text + "', "
            str &= "[apellido] = '" + txt_apellido.Text + "', "
            'str &= "[id_tipoDoc] = " + cbo_tipoDoc.SelectedValue + ", "
            'str &= "[nro_doc] = " + txt_nroDoc.Text + ", "
            str &= "[fecha_nac] = '" + dtp_fechaNac.Text + "', "
            str &= "[calle] = '" + txt_calle.Text + "', "
            str &= "[nro] = " + txt_nroCalle.Text + ", "
            str &= "[id_barrio] = " + cbo_barrio.SelectedValue.ToString() + ", "
            str &= "telefono = " + txt_telefono.Text + ", "
            str &= "[id_tipoAfiliado] = " + cbo_tipoAfiliado.SelectedValue.ToString()
            str &= "WHERE nro_doc = " + txt_nroDoc.Text + " AND id_tipoDoc = " + cbo_tipoDoc.SelectedValue.ToString()
            BDHelper.getDBHelper.EjecutarSQL(str)
            Me.Close()
            'Else
            '    lbl_afiliados_mensaje.Text = "Debe ingresar TODOS los datos"
            '    lbl_afiliados_mensaje.Visible = True
            'End If
        End If
    End Sub
End Class