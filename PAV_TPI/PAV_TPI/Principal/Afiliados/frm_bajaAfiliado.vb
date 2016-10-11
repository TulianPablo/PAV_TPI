Public Class frm_bajaAfiliado

    Private Sub frm_bajaAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txt_fechaBaja.Text = DateTime.Now.ToShortDateString

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As FormClosingEventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Está seguro que desea dar de baja afiliado?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim str As String = "UPDATE Afiliado SET fecha_baja = '" & txt_fechaBaja.Text & "'"
            str &= "WHERE nro_doc = " & txt_nroDoc.Text
            BDHelper.getDBHelper.EjecutarSQL(str)
            e.Cancel = False
            Me.Close()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class