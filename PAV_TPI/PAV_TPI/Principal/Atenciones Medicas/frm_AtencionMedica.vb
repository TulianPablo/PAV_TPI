Public Class frm_AtencionMedica
    Dim atenciones As New List(Of DetalleAtencionMedica)
    Public habilitar As Boolean

    Private Sub frm_AtencionMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nro_atencion.Enabled = False
        dtp_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc, "id_tipoDoc", "nombre")
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades, "id_especialidad", "nombre")
        CargarCombo(cbo_practica, BDHelper.GetPracticas, "id_practica", "nombre")


        'If habilitar Then
        deshabilitar(False)
        'Else
        '    deshabilitar_Campos(False)
        'End If

    End Sub
    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
        combo.Text = "SELECCIONAR"


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

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

        lbl_mensajeRegistracion.Visible = True
        If (dgv_practicas.Rows.Count > 1) Then
            If (BDHelper.insertar(txt_nro_atencion.Text, dtp_fecha.Text, txt_nroCentro.Text, cbo_tipoDoc.SelectedValue, txt_nroDoc.Text, txt_matricula.Text, cbo_especialidad.SelectedValue, atenciones)) Then
                lbl_mensajeRegistracion.Text = "Atención medica registrada con exito"
            Else
                lbl_mensajeRegistracion.Text = "Ha ocurrido un error inesperado, no se pudo registrar la atencion medica."
            End If

        Else
            lbl_mensajeRegistracion.Text = "Debe asignar por lo menos una practica"
            lbl_mensajeRegistracion.Visible = True
        End If

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If (validar_campos()) Then
            If (validar_seleccionPractica()) Then
                nro_atencion()
                Dim oDetalle = New DetalleAtencionMedica()

                oDetalle.fecha_atencion = dtp_fecha.Text
                oDetalle.nro_atencion = txt_nro_atencion.Text
                oDetalle.id_practica = cbo_practica.SelectedValue
                oDetalle.nombre_practica = cbo_practica.Text
                oDetalle.porc_descuento = txt_porcDescuento.Text
                oDetalle.precio_practica = txt_precio.Text


                atenciones.Add(oDetalle)

                ' Se lo agrega a la grilla de detalles de atencion 
                dgv_practicas.Rows.Add(New Object() {oDetalle.id_practica, oDetalle.fecha_atencion.ToString, oDetalle.nro_atencion, oDetalle.nombre_practica, oDetalle.precio_practica, oDetalle.porc_descuento, txt_subtotal.Text})

                txt_total.Text = calcularTotal()
                txt_total.Enabled = True
            End If
        End If



    End Sub



    Private Sub btn_BuscarAfiliado_Click(sender As Object, e As EventArgs) Handles btn_BuscarAfiliado.Click
        Dim consulta As String
        Dim tabla As DataTable
        consulta = "SELECT apellido + ',' + nombre AS nombre_completo, id_tipoAfiliado FROM Afiliado WHERE id_tipoDoc = " & (cbo_tipoDoc.SelectedValue.ToString()).ToString
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
        sql = "Select Max(nro_atencion)+1 From AtencionMedica where nro_centroMedico=" + txt_nroCentro.Text

        If Not IsDBNull(BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0)) Then
            txt_nro_atencion.Text = BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0).ToString()
        Else
            txt_nro_atencion.Text = "1"
        End If

    End Sub



    Private Sub cbo_practica_selectionChangeCommited(sender As Object, e As EventArgs) Handles cbo_practica.SelectionChangeCommitted
        Dim strSQL As String
        Dim tabla As New DataTable

        If (cbo_tipoDoc.SelectedIndex <> -1 And (Not String.IsNullOrEmpty(txt_nroDoc.Text))) Then

            If Not (cbo_practica.SelectedText = "SELECCIONAR") Then

                txt_precio.Enabled = True
                txt_porcDescuento.Enabled = True
                txt_subtotal.Enabled = True

                strSQL = "SELECT precioPractica, porc_cobertura FROM PracticaXTipoAfiliado WHERE (id_tipoPractica= " + (cbo_practica.SelectedIndex + 1).ToString
                strSQL &= " AND id_tipoAfiliado=" + txt_apellidoNombre.Tag + ")"
                tabla = BDHelper.getDBHelper.ConsultaSQL(strSQL)
                txt_precio.Text = (tabla.Rows(0).Item("precioPractica")).ToString
                txt_porcDescuento.Text = (tabla.Rows(0).Item("porc_cobertura")).ToString
                txt_subtotal.Text = (Integer.Parse(txt_precio.Text) - (Integer.Parse(txt_precio.Text) * Integer.Parse(txt_porcDescuento.Text)) / 100).ToString
            End If
        Else
            lbl_datosObligatorios.Visible = True
            lbl_datosObligatorios.Text = "Debe ingresar <Tipo Documento> y <Nro Documento del Afiliado"

        End If

    End Sub

    Private Sub cbo_especialidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_especialidad.SelectionChangeCommitted
        If (cbo_especialidad.SelectedIndex <> -1) Then
            cbo_practica.Enabled = True
            CargarCombo(cbo_practica, BDHelper.GetPracticasxEspecialidad(cbo_especialidad.SelectedIndex + 1), "id_practica", "nombre")

        End If

    End Sub

    Private Sub clear_components()
        'Procedimiento Clear_components: Permite limpiar todos los campos de un formulario, independientemente del 
        'tipo de control

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = ctrl
                chk.Checked = False
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = ctrl
                rb.Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = ctrl
                cbo.SelectedIndex = -1
            ElseIf (Not TypeOf ctrl Is Label) And (Not TypeOf ctrl Is Button) Then
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Private Function calcularTotal() As Double
        Dim c As Integer
        Dim calculo As Double
        calculo = 0
        For c = 0 To Me.dgv_practicas.RowCount - 1
            calculo = calculo + Convert.ToDouble(Me.dgv_practicas.Rows(c).Cells("col_subtotal").Value)
        Next
        Return calculo
    End Function

    Private Function validar_campos() As Boolean
        Dim fecha_hoy As Date
        fecha_hoy = DateTime.Now.ToString("dd/MM/yyyy")
        't1 As Date = primera fecha a comparar
        't2 As Date = segunda fecha a comparar
        'DateTime.Compare(t1, t2) compara ambas fechas y devuelve un Integer
        'Si devuelve un nro menor que 0, entonces t1<t2
        'Si devuelve un nro mayor que 0, entonces t1>t2
        'Si devuelve 0, entonces son iguales
        Dim result As Integer = DateTime.Compare(fecha_hoy.Date, dtp_fecha.Value.Date)
        If result > 0 Then
            lbl_datosObligatorios.Text = "La fecha seleccionada no puede ser menor a la actual "
            lbl_datosObligatorios.Visible = True
            Return False
        End If
        If String.IsNullOrEmpty(txt_nroCentro.Text) Then
            lbl_mensajeCentroMedicos.Text = "Debe ingresar el numero de centro Medico"
            lbl_mensajeCentroMedicos.Visible = True
            Me.txt_nroCentro.Focus()
            Return False
        End If
        If (cbo_tipoDoc.SelectedIndex = -1) Or String.IsNullOrEmpty(txt_nroDoc.Text) Then
            lbl_mensajeAfiliado.Text = "Debe ingresar <Tipo Doc> y <Nro. Doc> del afiliado"
            lbl_mensajeAfiliado.Visible = True
            cbo_tipoDoc.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_matricula.Text) Then
            lbl_mensajeProfesional.Text = "Debe ingresar la matricula del profesional"
            lbl_mensajeProfesional.Visible = True
            Me.txt_profesional.Focus()
            Return False
        End If
        If (cbo_especialidad.SelectedIndex = -1) Then
            lbl_datosObligatorios.Text = "Debe seleccionar una especialidad"
            lbl_datosObligatorios.Visible = True
            cbo_especialidad.Focus()
            Return False
        End If
        If (cbo_practica.SelectedIndex = -1) Then
            lbl_datosObligatorios.Text = "Debe seleccionar una practica"
            lbl_datosObligatorios.Visible = True
            cbo_practica.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function validar_seleccionPractica() As Boolean
        For Each row As DataGridViewRow In dgv_practicas.Rows
            If (row.Cells("col_id").Value = cbo_practica.SelectedValue.ToString) Then
                lbl_datosObligatorios.Text = "No puede añadir esa practica, ya ha sido seleccionada"
                lbl_datosObligatorios.Visible = True
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub deshabilitar(p1 As Boolean)

        cbo_practica.Enabled = p1
        lbl_mensajeCentroMedicos.Visible = p1
        lbl_mensajeProfesional.Visible = p1
        lbl_mensajeAfiliado.Visible = p1
        lbl_datosObligatorios.Visible = p1
        lbl_mensajeRegistracion.Visible = p1
        txt_centroMedico.Enabled = p1
        txt_profesional.Enabled = p1
        txt_apellidoNombre.Enabled = p1
        txt_total.Enabled = p1
        txt_porcDescuento.Enabled = p1
        txt_precio.Enabled = p1
        txt_subtotal.Enabled = p1
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("¿Desea cancelar el registro? Va a perder todos los datos cargados", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub deshabilitar_Campos(p1 As Boolean)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = ctrl
                chk.Enabled = p1
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = ctrl
                rb.Enabled = p1
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = ctrl
                cbo.Enabled = p1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = ctrl
                txt.Enabled = p1
            ElseIF TypeOf ctrl Is DateTimePicker then
                Dim dtp As DateTimePicker = ctrl
                dtp.Enabled = p1
            ElseIf TypeOf ctrl Is GroupBox Then
                Dim gb As GroupBox = ctrl
                gb.Enabled = p1
            ElseIf TypeOf ctrl Is Panel Then
                Dim pnl As Panel = ctrl
                pnl.Enabled = p1
            End If
        Next
        lbl_mensajeAfiliado.Visible = p1
        lbl_mensajeCentro.Visible = p1
        lbl_mensajeCentroMedicos.Visible = p1
        lbl_mensajeProfesional.Visible = p1
        lbl_mensajeRegistracion.Visible = p1
        lbl_datosObligatorios.Visible = p1
        btn_registrar.Enabled = p1
        btn_cancelar.Enabled = p1

    End Sub


End Class