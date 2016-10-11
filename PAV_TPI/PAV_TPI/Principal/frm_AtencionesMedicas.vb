Public Class Atenciones_Medicas
    Private Sub Atenciones_Medicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc, "id_tipoDoc", "nombre")
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades, "id_especialidad", "nombre")
        CargarCombo(cbo_practica, BDHelper.GetPracticas, "id_practica", "nombre")
        lbl_mensajeCentroMedicos.Visible = False
        lbl_mensajeProfesional.Visible = False
        txt_numeroCentro.Enabled = False
        txt_porcDescuento.Enabled = False
        txt_precio.Enabled = False

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
        consulta = "SELECT denominacion FROM CentroMedico WHERE denominacion= " & txt_numeroCentro.Text
        tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count > 0) Then
            txt_centroMedico.Text = tabla.Rows(0).Item("denominacion").ToString
        Else
            lbl_mensajeCentroMedicos.Text = "Ese centro medico NO existe"
            lbl_mensajeCentroMedicos.Visible = True
        End If
    End Sub

    Private Sub btn_buscarProfesional_Click(sender As Object, e As EventArgs) Handles btn_buscarProfesional.Click
        Dim consulta As String
        Dim tabla As DataTable
        consulta = "SELECT apellido and nombre as nombreCompleto FROM Profesional WHERE matricula= " & txt_matricula.Text
        tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count > 0) Then
            txt_centroMedico.Text = tabla.Rows(0).Item("nombreCompleto").ToString
        Else
            lbl_mensajeProfesional.Text = "Ese profesional NO existe"
            lbl_mensajeProfesional.Visible = True
        End If
    End Sub

    Private Sub cbo_practica_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_practica.SelectedValueChanged
        Dim strSQL As String
        Dim tabla As DataTable
        strSQL = "SELECT precioPractica, porc_cobertura FROM PracticaXTipoAfiliado WHERE id_tipoPractica= " & cbo_practica.SelectedIndex.ToString
        tabla = BDHelper.getDBHelper.ConsultaSQL(strSQL)
        txt_precio.Text = tabla.Rows(0).Item("precioPractica")
        txt_porcDescuento.Text = tabla.Rows(0).Item("porc_cobertura")
    End Sub

End Class


