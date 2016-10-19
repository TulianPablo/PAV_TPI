Public Class frm_bajaProfesional
    Public form_Profesional As frm_Profesionales


    Private Sub frm_bajaProfesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")

        txt_matricula.Enabled = False
        txt_apellido.Enabled = False
        txt_nombre.Enabled = False
        txt_nroDoc.Enabled = False
        cbo_tipoDoc.Enabled = False
        cbo_barrio.Enabled = False
        txt_fechaAlta.Enabled = False
        dtp_fechaNac.Enabled = False
        txt_calle.Enabled = False
        txt_nroCalle.Enabled = False
        txt_telefono.Enabled = False
        txt_fechaBaja.Enabled = False

        txt_matricula.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(0).Value
        txt_nombre.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(1).Value
        txt_apellido.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(2).Value
        cbo_tipoDoc.SelectedValue = form_Profesional.dgv_resultados.CurrentRow.Cells(3).Value
        txt_nroDoc.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(4).Value
        dtp_fechaNac.Value = form_Profesional.dgv_resultados.CurrentRow.Cells(5).Value
        txt_calle.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(6).Value
        txt_nroCalle.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(7).Value
        cbo_barrio.SelectedValue = form_Profesional.dgv_resultados.CurrentRow.Cells(8).Value
        txt_telefono.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(9).Value
        txt_fechaAlta.Text = form_Profesional.dgv_resultados.CurrentRow.Cells(10).Value
        txt_fechaBaja.Text = DateTime.Now.ToShortDateString
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As FormClosingEventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Está seguro que desea dar de baja al profesional?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim str As String = "UPDATE Profesional SET fecha_baja = '" & txt_fechaBaja.Text & "'"
            str &= "WHERE matricula = " & txt_matricula.Text
            BDHelper.getDBHelper.EjecutarSQL(str)
            e.Cancel = False
            Me.Close()
        Else
            e.Cancel = True
        End If
    End Sub
End Class