Public Class frm_ConsultarAtenciones

    Private Sub frm_ConsultarAtenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub
   
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        dgv_atenciones.Columns(11).Visible = False
        If Not String.IsNullOrEmpty(txt_nroAtencion.Text) Or Not String.IsNullOrEmpty(txt.Text) Or Not String.IsNullOrEmpty(txt_nroDoc.Text) Or
            cbo_tipodoc.SelectedValue > -1 Or cbo_tipoAfiliado.SelectedValue > -1 Or chk_fechaBaja.Checked = True Then
            If validar_campos() Then
                dgv_atenciones.Rows.Clear()
                cargar_grilla_CD()
            End If
        Else
            cargar_grilla_SD()
        End If
    End Sub
End Class