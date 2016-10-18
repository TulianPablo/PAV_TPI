Public Class frm_AtencionMedica
    Dim atenciones As List(Of DetalleAtencionMedica)
    Private Sub AtencionMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc, "id_tipoDoc", "nombre")
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades, "id_especialidad", "nombre")
        cbo_practica.Enabled = False

        lbl_mensajeCentroMedicos.Visible = False
        lbl_mensajeProfesional.Visible = False
        lbl_mensajeAfiliado.Visible = False
        txt_nro_atencion.Enabled = False
        txt_porcDescuento.Enabled = False
        txt_precio.Enabled = False
        txt_subtotal.Enabled = False
        nro_atencion()

    End Sub
    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_buscarCentro_Click(sender As Object, e As EventArgs) Handles btn_buscarCentro.Click
        Dim consulta As String
        Dim tabla As DataTable
        consulta = "SELECT denominacion FROM CentroMedico WHERE nro_centroMedico= " & txt_nroCentro.Text
        tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count > 0) Then
            txt_centroMedico.Text = tabla.Rows(0).Item("denominacion").ToString
            lbl_mensajeCentro.Visible = False
        Else
            lbl_mensajeCentroMedicos.Text = "El centro medico ingresado NO existe"
            lbl_mensajeCentroMedicos.Visible = True
        End If
    End Sub

    Private Sub btn_buscarProfesional_Click(sender As Object, e As EventArgs) Handles btn_buscarProfesional.Click
        Dim consulta As String
        Dim tabla As DataTable
        consulta = "SELECT apellido + ',' + nombre AS nombre_completo FROM Profesional WHERE matricula= " & txt_matricula.Text
        tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count > 0) Then
            txt_profesional.Text = tabla.Rows(0).Item("nombre_completo").ToString
            lbl_mensajeProfesional.Visible = False
        Else
            lbl_mensajeProfesional.Text = "El profesional ingresado NO existe"
            lbl_mensajeProfesional.Visible = True
        End If
    End Sub

    Private Sub cbo_practica_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_practica.SelectedIndexChanged
        Dim strSQL As String
        Dim tabla As New DataTable

        strSQL = "SELECT precioPractica, porc_cobertura FROM PracticaXTipoAfiliado WHERE id_tipoPractica= " + (cbo_practica.SelectedIndex + 1).ToString
        strSQL &= " AND id_tipoAfiliado=" + txt_apellidoNombre.Tag
        BDHelper.getDBHelper.ConsultaSQL(strSQL)
        txt_precio.Text = tabla.Rows(0)("precioPractica").ToString
        txt_porcDescuento.Text = tabla.Rows(0)("porc_cobertura").ToString
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        BDHelper.insertar(txt_nro_atencion.Text, txt_fecha.Text, txt_nroCentro.Text, cbo_tipoDoc.SelectedValue, txt_nroDoc.Text, txt_matricula.Text, cbo_especialidad.SelectedValue, atenciones)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        'validacione

        Dim oDetalle = New DetalleAtencionMedica()

        oDetalle.fecha_atencion = txt_fecha.Text
        oDetalle.ordinal = txt_nro_atencion.Text
        oDetalle.id_practica = cbo_practica.SelectedValue
        oDetalle.nombre_practica = cbo_practica.Text
        oDetalle.porc_descuento = txt_porcDescuento.Text
        oDetalle.precio_practica = txt_precio.Text
        oDetalle.subtotal = txt_subtotal.Text

        atenciones = New List(Of DetalleAtencionMedica)
        atenciones.Add(oDetalle)

        ' Se lo agrega a la grilla de detalles de atencion 
        dgv_practicas.Rows.Add(New Object() {oDetalle.fecha_atencion, oDetalle.ordinal, oDetalle.id_practica, oDetalle.nombre_practica, oDetalle.precio_practica, oDetalle.porc_descuento, oDetalle.subtotal})

    End Sub

    Private Sub txt_nroCentro_TextChanged(sender As Object, e As EventArgs) Handles txt_nroCentro.TextChanged

    End Sub

    Private Sub cbo_especialidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_especialidad.SelectedValueChanged

        If (cbo_especialidad.SelectedIndex <> -1) Then
            cbo_practica.Enabled = True
            CargarCombo(cbo_practica, BDHelper.GetPracticasxEspecialidad(cbo_especialidad.SelectedIndex), "id_practica", "nombre")
            txt_precio.Enabled = True
            txt_porcDescuento.Enabled = True
            txt_subtotal.Enabled = True
        End If
    End Sub

    Private Sub btn_BuscarAfiliado_Click(sender As Object, e As EventArgs) Handles btn_BuscarAfiliado.Click
        Dim consulta As String
        Dim tabla As DataTable
        consulta = "SELECT apellido + ',' + nombre AS nombre_completo, id_tipoAfiliado FROM Afiliado WHERE id_tipoDoc = " & (cbo_tipoDoc.SelectedIndex + 1).ToString
        consulta &= "AND nro_doc = " & txt_nroDoc.Text
        tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count > 0) Then
            txt_apellidoNombre.Text = tabla.Rows(0).Item("nombre_completo").ToString
            txt_apellidoNombre.Tag = tabla.Rows(0).Item("id_tipoAfiliado").ToString
            lbl_mensajeAfiliado.Visible = False
        Else
            lbl_mensajeAfiliado.Text = "No es un afiliado o NO posee una afiliacion vigente"
            lbl_mensajeAfiliado.Visible = True
        End If
    End Sub

    Private Sub nro_atencion()
        Dim sql As String
        sql = "Select Max(ordinal)+1 From AtencionMedica"

        If Not IsDBNull(BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0)) Then
            txt_nro_atencion.Text = BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0).ToString()
        Else
            txt_nro_atencion.Text = "1"
        End If

    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        frm_ConsultarAtenciones.Show()
    End Sub
End Class