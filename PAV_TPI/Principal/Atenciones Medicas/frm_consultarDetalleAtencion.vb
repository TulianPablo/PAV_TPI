Public Class frm_consultarDetalleAtencion
    Public consulta_atenciones As New frm_ConsultarAtenciones

    Private Sub frm_consultarDetalleAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombo(cbo_ctroMedico, BDHelper.GetCentrosMedico, "nro_centroMedico", "denominacion")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc, "id_tipoDoc", "nombre")
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades, "id_especialidad", "nombre")
        CargarCombo(cbo_profesional, BDHelper.GetProfesionales, "matricula", "nombre_completo")

        'Dim subtotal As Integer
        'With consulta_atenciones
        '    txt_nro_atencion.Text = .table.Rows(0)("nro_atencion")
        '    dtp_fecha.Text = .table.Rows(0)("fecha_atencion")
        '    cbo_ctroMedico.SelectedValue = .table.Rows(0)("nro_centroMedico")
        '    cbo_tipoDoc.SelectedValue = .table.Rows(0)("id_tipoDocAfiliado")
        '    txt_nroDoc.Text = .table.Rows(0)("nro_docAfiliado")
        '    txt_apellidoNombre.Text = .table.Rows(0)("afiliado")
        '    cbo_profesional.SelectedValue = .table.Rows(0)("matricula")
        '    cbo_especialidad.SelectedValue = .table.Rows(0)("id_especialidad")

        '    For Each row As Data.DataRow In .table.Rows
        '        subtotal = (Integer.Parse(row.Item("precio")) - (Integer.Parse(row.Item("precio")) * Integer.Parse(row.Item("porc_descuento"))) / 100)
        '        dgv_practicas.Rows.Add(New String() {row.Item("id_practica"), row.Item("fecha_atencion"), row.Item("nro_atencion"), row.Item("nombre"), row.Item("precio"), row.Item("porc_descuento"), subtotal})

        '    Next

        'End With
    End Sub


    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
        combo.Text = "SELECCIONAR"

    End Sub


End Class