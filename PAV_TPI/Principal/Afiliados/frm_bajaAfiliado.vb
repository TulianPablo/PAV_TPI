Public Class frm_bajaAfiliado
    Public formConsulta As frm_Afiliados

    Private Sub frm_bajaAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")

        txt_apellido.Enabled = False
        txt_nombre.Enabled = False
        txt_nroDoc.Enabled = False
        cbo_tipoDoc.Enabled = False
        cbo_barrio.Enabled = False
        cbo_tipoAfiliado.Enabled = False
        txt_fechaAlta.Enabled = False
        dtp_fechaNac.Enabled = False
        txt_calle.Enabled = False
        txt_nroCalle.Enabled = False
        txt_telefono.Enabled = False
        txt_fechaBaja.Enabled = False

        txt_nombre.Text = formConsulta.dgv_resultados.CurrentRow.Cells(0).Value
        txt_apellido.Text = formConsulta.dgv_resultados.CurrentRow.Cells(1).Value
        cbo_tipoDoc.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(12).Value
        txt_nroDoc.Text = formConsulta.dgv_resultados.CurrentRow.Cells(3).Value
        dtp_fechaNac.Value = formConsulta.dgv_resultados.CurrentRow.Cells(4).Value
        txt_calle.Text = formConsulta.dgv_resultados.CurrentRow.Cells(5).Value
        txt_nroCalle.Text = formConsulta.dgv_resultados.CurrentRow.Cells(6).Value
        cbo_barrio.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(7).Value
        txt_telefono.Text = formConsulta.dgv_resultados.CurrentRow.Cells(8).Value
        cbo_tipoAfiliado.SelectedValue = formConsulta.dgv_resultados.CurrentRow.Cells(13).Value
        txt_fechaAlta.Text = formConsulta.dgv_resultados.CurrentRow.Cells(10).Value
        txt_fechaBaja.Text = DateTime.Now.ToShortDateString

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Está seguro que desea dar de baja afiliado?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim str As String = "UPDATE Afiliado SET fecha_baja = '" & txt_fechaBaja.Text & "'"
            str &= "WHERE nro_doc = " & txt_nroDoc.Text
            BDHelper.getDBHelper.EjecutarSQL(str)
            formConsulta.cargar_grilla_SD()
            Me.Close()
            'Else
            '    e.Cancel = True
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class