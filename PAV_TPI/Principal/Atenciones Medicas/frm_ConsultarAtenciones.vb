Public Class frm_ConsultarAtenciones


    Public form_atencion As frm_consultarDetalleAtencion

    Private Sub frm_ConsultarAtenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cbo_tipodoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades(), "id_especialidad", "nombre")
        lbl_mensajeAtenciones.Visible = False

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub



    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        dgv_atenciones.Rows.Clear()
        If Not String.IsNullOrEmpty(txt_nroAtencion.Text) Or Not String.IsNullOrEmpty(txt_matricula.Text) Or Not String.IsNullOrEmpty(txt_nroDoc.Text) Or cbo_tipodoc.SelectedIndex <> -1 Or cbo_especialidad.SelectedIndex <> -1 Then

            If validar_campos() Then
                cargar_grilla_CD()
            End If
        Else
            cargar_grilla_SD()
        End If
    End Sub

    Private Function validar_campos() As Boolean

        'valida que si se ingresa nro de doc tambien debe haberse ingresado tipo de doc obligatoriamente
        If cbo_tipodoc.SelectedValue = -1 And Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            lbl_mensajeAtenciones.Text = "Falta ingresar <Tipo de Documento>"
            lbl_mensajeAtenciones.Visible = True
            Return False
        End If

        't1 As Date = primera fecha a comparar
        't2 As Date = segunda fecha a comparar
        'DateTime.Compare(t1, t2) compara ambas fechas y devuelve un Integer
        'Si devuelve un nro menor que 0, entonces t1<t2
        'Si devuelve un nro mayor que 0, entonces t1>t2
        'Si devuelve 0, entonces son iguales
        Dim result As Integer = DateTime.Compare(dtp_fechaDesde.Value.Date, dtp_fechaHasta.Value.Date)
        If result > 0 Then
            lbl_mensajeAtenciones.Text = "La fecha Desde no puede ser mayor que la fecha Hasta"
            lbl_mensajeAtenciones.Visible = True
            Return False
        End If
        Return True
    End Function

    Public Sub cargar_grilla_SD()
        Dim str As String
        str = "SELECT am.fecha_atencion, am.nro_atencion, a.apellido + ', ' + a.nombre as afiliado, c.denominacion, p.apellido + ', ' + p.nombre as profesional, e.nombre , c.nro_centroMedico , SUM (dam.precio) as total  "
        Str &= "FROM AtencionMedica am JOIN Afiliado a ON (am.id_tipoDocAfiliado=a.id_tipoDoc AND am.nro_docAfiliado=a.nro_doc) "
        Str &= "JOIN DetalleAtencionMedica dam ON (am.nro_atencion=dam.nro_atencion AND am.nro_centroMedico= dam.nro_centroMedico) "
        Str &= "JOIN CentroMedico c ON(am.nro_centroMedico = c.nro_centroMedico) JOIN Profesional p ON (am.matricula=p.matricula) "
        Str &= "JOIN Especialidad e ON (am.id_especialidad=e.id_especialidad) "


        If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) And Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
            dtp_fechaDesde.Value.Day.ToString()
            str &= "WHERE am.fecha_atencion BETWEEN CAST('" & dtp_fechaDesde.Text & "' AS DATE) AND CAST('" & dtp_fechaHasta.Text & "' AS DATE)"
        End If

        str &= "GROUP BY am.fecha_atencion, am.nro_atencion, a.apellido + ', ' + a.nombre , c.denominacion, p.apellido + ', ' + p.nombre, e.nombre , c.nro_centroMedico "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            dgv_atenciones.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString})
        Next

        If dgv_atenciones.Rows.Count = 0 Then
            lbl_mensajeAtenciones.Text = "No se encontraron resultados"
            lbl_mensajeAtenciones.Visible = True
        End If

    End Sub

    Public Sub cargar_grilla_CD()

        Dim str As String
        str = "SELECT am.fecha_atencion, am.nro_atencion, a.apellido + ', ' + a.nombre as afiliado, c.denominacion, p.apellido + ', ' + p.nombre as profesional, e.nombre , c.nro_centroMedico , SUM (dam.precio) as total "
        str &= "FROM AtencionMedica am JOIN Afiliado a ON (am.id_tipoDocAfiliado=a.id_tipoDoc AND am.nro_docAfiliado=a.nro_doc) "
        str &= "JOIN DetalleAtencionMedica dam ON (am.nro_atencion=dam.nro_atencion AND am.nro_centroMedico= dam.nro_centroMedico) "
        str &= "JOIN CentroMedico c ON(am.nro_centroMedico = c.nro_centroMedico) JOIN Profesional p ON (am.matricula=p.matricula) "
        str &= "JOIN Especialidad e ON (am.id_especialidad=e.id_especialidad) "
        str &= "WHERE "

        Dim c As Integer = 0

        If Not String.IsNullOrEmpty(txt_nroAtencion.Text) Then
            str &= " am.nro_atencion = " & txt_nroAtencion.Text
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_matricula.Text) Then
            If c = 1 Then
                Str &= " AND "
            End If
            Str &= "am.matricula = " & txt_matricula.Text
            c = 1
        End If

        If Not cbo_tipodoc.SelectedValue = Nothing Then
            If c = 1 Then
                Str &= " AND "
            End If
            Str &= "am.id_tipoDocAfiliado = " & cbo_tipodoc.SelectedValue.ToString
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            If c = 1 Then
                Str &= " AND "
            End If
            Str &= "am.nro_docAfiliado = " & txt_nroDoc.Text
            c = 1
        End If

        If Not cbo_especialidad.SelectedValue = Nothing Then
            If c = 1 Then
                Str &= " AND "
            End If
            Str &= "am.id_especialidad= " & cbo_especialidad.SelectedValue.ToString
            c = 1
        End If

        If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) And Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
            If c = 1 Then
                Str &= " AND "
            End If
            dtp_fechaDesde.Value.Day.ToString()
            str &= " am.fecha_atencion BETWEEN CAST('" & dtp_fechaDesde.Text & "' AS DATE) AND CAST('" & dtp_fechaHasta.Text & "' AS DATE)"
            c = 1
        End If
        str &= "GROUP BY am.fecha_atencion, am.nro_atencion, a.apellido + ', ' + a.nombre , c.denominacion, p.apellido + ', ' + p.nombre, e.nombre , c.nro_centroMedico "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(Str).Rows
            dgv_atenciones.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString})
        Next
        'Valida si existen resultados o no
        If dgv_atenciones.Rows.Count = 1 Then
            lbl_mensajeAtenciones.Text = "No se encontraron resultados"
            lbl_mensajeAtenciones.Visible = True
        End If

    End Sub

    Private Sub dgv_atenciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_atenciones.CellDoubleClick


        form_atencion = New frm_consultarDetalleAtencion

        Dim sql As String
        Dim table As DataTable
        Dim subtotal As Integer
        form_atencion.Show()
        Dim t_subtotal As Integer = 0
        Dim t_descuento As Integer = 0
        Dim t_total As Integer = 0

        sql = "SELECT am.*, dam.id_practica,dam.porc_descuento, dam.precio, a.apellido + ' , ' +  a.nombre as afiliado, c.denominacion, p.apellido + ', ' + p.nombre as profesional, c.denominacion , pr.nombre "
        sql &= "FROM AtencionMedica am JOIN DetalleAtencionMedica dam ON (am.nro_atencion=dam.nro_atencion AND am.nro_centroMedico=dam.nro_centroMedico)"
        sql &= "JOIN Afiliado a ON (am.id_tipoDocAfiliado=a.id_tipoDoc AND am.nro_docAfiliado=a.nro_doc)"
        sql &= "JOIN CentroMedico c ON(am.nro_centroMedico = c.nro_centroMedico)"
        sql &= "JOIN Profesional p ON (am.matricula=p.matricula)"
        sql &= "JOIN Especialidad e ON (am.id_especialidad=e.id_especialidad)"
        sql &= "JOIN Practica pr ON (dam.id_practica=pr.id_practica)"
        sql &= "WHERE am.nro_atencion = " & dgv_atenciones.CurrentRow.Cells("col_nroAtencion").Value & " AND " & " am.nro_centroMedico = " & dgv_atenciones.CurrentRow.Cells("col_nroCentroMedico").Value
        table = BDHelper.getDBHelper.ConsultaSQL(sql)


        With form_atencion
            .txt_nro_atencion.Text = table.Rows(0)("nro_atencion")
            .dtp_fecha.Text = table.Rows(0)("fecha_atencion")
            .cbo_ctroMedico.SelectedValue = table.Rows(0)("nro_centroMedico")
            .cbo_tipoDoc.SelectedValue = table.Rows(0)("id_tipoDocAfiliado")
            .txt_nroDoc.Text = table.Rows(0)("nro_docAfiliado")
            .txt_apellidoNombre.Text = table.Rows(0)("afiliado")
            .cbo_profesional.SelectedValue = table.Rows(0)("matricula")
            .cbo_especialidad.SelectedValue = table.Rows(0)("id_especialidad")

            For Each row As Data.DataRow In table.Rows
                subtotal = (Integer.Parse(row.Item("precio")) - (Integer.Parse(row.Item("precio")) * Integer.Parse(row.Item("porc_descuento"))) / 100)
                .dgv_practicas.Rows.Add(New String() {row.Item("id_practica"), row.Item("fecha_atencion"), row.Item("nro_atencion"), row.Item("nombre"), row.Item("precio"), row.Item("porc_descuento"), subtotal})
            Next
            For c = 0 To .dgv_practicas.RowCount - 1
                t_subtotal = t_subtotal + Convert.ToDouble(.dgv_practicas.Rows(c).Cells("col_subtotal").Value)
                t_total = t_total + Convert.ToDouble(.dgv_practicas.Rows(c).Cells("col_precio").Value)
                t_descuento = t_descuento + (Convert.ToDouble(.dgv_practicas.Rows(c).Cells("col_precio").Value) * Convert.ToDouble(.dgv_practicas.Rows(c).Cells("col_porcentaje").Value)) / 100

            Next
            .txt_totales.Text = t_total
            .txt_descTotales.Text = t_descuento
            .txt_subTotales.Text = t_subtotal
        End With

        deshabilitar_Campos(False)


    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

        frm_AtencionMedica.Show()
    End Sub

    Private Sub deshabilitar_Campos(p1 As Boolean)

        With form_atencion
            For Each ctrl As Control In .Controls
                If TypeOf ctrl Is ComboBox Then
                    Dim cbo As ComboBox = ctrl
                    cbo.Enabled = p1
                ElseIf TypeOf ctrl Is TextBox Then
                    Dim txt As TextBox = ctrl
                    txt.Enabled = p1
                ElseIf TypeOf ctrl Is DateTimePicker Then
                    Dim dtp As DateTimePicker = ctrl
                    dtp.Enabled = p1
                ElseIf TypeOf ctrl Is GroupBox Then
                    Dim gp As GroupBox = ctrl
                    For Each ctr As Control In ctrl.Controls
                        If TypeOf ctr Is TextBox Then
                            Dim txt As TextBox = ctr
                            txt.Enabled = p1
                        ElseIf TypeOf ctr Is ComboBox Then
                            Dim cbo As ComboBox = ctr
                            cbo.Enabled = p1
                        ElseIf TypeOf ctr Is MaskedTextBox Then
                            Dim msk As MaskedTextBox = ctr
                            msk.Enabled = p1
                        End If
                    Next  
                End If
            Next
        End With
    End Sub



End Class