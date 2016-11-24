Public Class frm_CentroMedico
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As estado = estado.insertar
    Friend row_selected As DataGridViewRow

    Private Sub frm_CentroMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_CentroMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_mensajeCtrosMedicos.Visible = False
        dvg_centrosMedicos.Columns(7).Visible = False
        habilitar_desabilitar(False)
        CargarCombo(cmb_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                Else
                    lbl_mensajeCtrosMedicos.Text = "Ya esta cargado un centro médico con ese número"
                    lbl_mensajeCtrosMedicos.Visible = True
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
            dvg_centrosMedicos.Rows.Clear()
            Me.cargaGrilla()
            lbl_mensajeCtrosMedicos.Text = "Se grabó con exito el centro médico"
            lbl_mensajeCtrosMedicos.Visible = True
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
            ctrl.Enabled = True
        Next
    End Sub


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clear_components()
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        txt_numero.Focus()
        Me.accion = estado.insertar
    End Sub


    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Dim fecha_baja = CType(DateTime.Now.ToString("dd/MM/yyyy"), System.DateTime)

        If MessageBox.Show("¿Desea borrar el centro médico?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_delete As String
            consulta_delete = "UPDATE centroMedico SET fecha_baja = '" & fecha_baja & "' WHERE nro_CentroMedico = " & dvg_centrosMedicos.CurrentRow.Cells(0).Value()

            BDHelper.getDBHelper.EjecutarSQL(consulta_delete)
            dvg_centrosMedicos.Rows.Clear()
            cargaGrilla()
        End If

    End Sub

    Private Sub habilitar_desabilitar(ByVal opc As Boolean)

        btn_agregar.Enabled = opc
        txt_denominacion.Enabled = opc
        txt_calle.Enabled = opc
        txt_nroCalle.Enabled = opc
        txt_telefono.Enabled = opc
        txt_mail.Enabled = opc
        cmb_barrio.Enabled = opc
        btn_borrar.Enabled = opc
        btn_editar.Enabled = opc
    End Sub

    Private Function validar() As Boolean
        lbl_mensajeCtrosMedicos.Visible = False
        ' Valida los campos requeridos ' 
        If String.IsNullOrEmpty(txt_numero.Text) Then
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar el Nro. Centro"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_numero.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_denominacion.Text) Then
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar la Denominación"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_denominacion.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_calle.Text) Then
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar la Calle"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_calle.Focus()
            Return False
        End If
        If Not String.IsNullOrEmpty(txt_nroCalle.Text) Then
            If txt_nroCalle.TextLength <> 4 Then
                lbl_mensajeCtrosMedicos.Text = "El Numero de calle debe ser de cuatro digitos"
                lbl_mensajeCtrosMedicos.Visible = True
                txt_nroCalle.Focus()
                Return False
            End If
        Else
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar el Nro. de Calle"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_nroCalle.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(cmb_barrio.SelectedIndex = -1) Then
            lbl_mensajeCtrosMedicos.Text = "Debe seleccionar el Barrio"
            lbl_mensajeCtrosMedicos.Visible = True
            cmb_barrio.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_calle.Text) Then
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar la Calle"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_calle.Focus()
            Return False
        End If
        If Not String.IsNullOrEmpty(txt_telefono.Text) Then
            If txt_telefono.TextLength > 9 Then
                lbl_mensajeCtrosMedicos.Text = "Si es un teléfono celular debe contener 9 dígitos y si es fijo 7 dígitos "
                lbl_mensajeCtrosMedicos.Visible = True
                txt_telefono.Focus()
                Return False
            End If
        Else
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar el Teléfono"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_telefono.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_mail.Text) Then
            lbl_mensajeCtrosMedicos.Text = "Debe ingresar el Mail"
            lbl_mensajeCtrosMedicos.Visible = True
            txt_mail.Focus()
            Return False
        End If


        Return True
    End Function

    Private Sub cargaGrilla()
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM CentroMedico ").Rows
            dvg_centrosMedicos.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString, row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString})

        Next
    End Sub

    Private Function validar_existencia() As termino
        Dim consulta As String = ""

        consulta = " SELECT * FROM CentroMedico "
        consulta += " WHERE nro_centroMedico =" + txt_numero.Text

        If (BDHelper.getDBHelper.ConsultaSQL(consulta).Rows.Count = 1) Then
            Return termino.rechazado
        End If
        Return termino.aprobado

    End Function

    Private Function insertar() As termino
        Dim consulta As String = ""
        Dim fecha_baja As DateTime
        consulta = "INSERT INTO CentroMedico ( "
        consulta += " nro_CentroMedico, denominacion, calle, numero, id_barrio, telefono, mail, fecha_baja)"
        consulta += " VALUES (" + Me.txt_numero.Text
        consulta += ", '" + Me.txt_denominacion.Text + "'"
        consulta += ", '" + Me.txt_calle.Text + "'"
        consulta += "," + Me.txt_nroCalle.Text
        consulta += "," + Me.cmb_barrio.SelectedValue.ToString
        consulta += "," + Me.txt_telefono.Text
        consulta += ", '" + Me.txt_mail.Text + "',"
        consulta += "'" + fecha_baja + "' )"

        BDHelper.getDBHelper.EjecutarSQL(consulta)
        Return termino.aprobado

    End Function

    Private Sub modificar()

        Dim comandStr As String
        comandStr = "UPDATE centroMedico SET "
        comandStr += "nro_centroMedico =" + txt_numero.Text + ", "
        comandStr += "denominacion='" + txt_denominacion.Text + "', "
        comandStr += "calle='" + txt_calle.Text + "', "
        comandStr += "numero=" + txt_nroCalle.Text + ", "
        comandStr += "telefono=" + txt_telefono.Text + ", "
        comandStr += "id_barrio=" + cmb_barrio.SelectedValue.ToString
        comandStr += " WHERE nro_centroMedico=" + txt_numero.Text

        BDHelper.getDBHelper.EjecutarSQL(comandStr)

    End Sub
    Private Sub dvg_centroMedicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_centrosMedicos.CellContentClick
        If String.IsNullOrEmpty(dvg_centrosMedicos.CurrentRow.Cells(7).Value) Then
            btn_editar.Enabled = True
            btn_borrar.Enabled = True
        Else
            btn_editar.Enabled = False
            btn_borrar.Enabled = False
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        btn_agregar.Enabled = True
        If MessageBox.Show("¿Desea editar el centro médico?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            habilitar_desabilitar(True)
            Dim tabla As New Data.DataTable
            Dim consulta As String = "SELECT * FROM CentroMedico WHERE nro_centroMedico = " + dvg_centrosMedicos.CurrentRow.Cells(0).Value.ToString
            tabla = BDHelper.getDBHelper.ConsultaSQL(consulta)

            txt_numero.Text = tabla.Rows(0)("nro_centroMedico")
            txt_denominacion.Text = tabla.Rows(0)("denominacion")
            txt_calle.Text = tabla.Rows(0)("calle")
            txt_nroCalle.Text = tabla.Rows(0)("numero")
            cmb_barrio.SelectedValue = tabla.Rows(0)("id_barrio")
            txt_telefono.Text = tabla.Rows(0)("telefono")
            txt_mail.Text = tabla.Rows(0)("mail")

            accion = estado.modificar
        End If
    End Sub


    'PARA MODIFICAR EL COLOR DE LOS BOTONES CUANDO ESTAN DESHABILITADOS
    Private Sub btn_agregar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_agregar.EnabledChanged
        Colores.ChangeColor(btn_agregar)
    End Sub

    Private Sub btn_editar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_editar.EnabledChanged
        Colores.ChangeColor(btn_editar)
    End Sub

    Private Sub btn_borrar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_borrar.EnabledChanged
        Colores.ChangeColor(btn_borrar)
    End Sub

    Private Sub btn_new_EnabledChanged(sender As Object, e As EventArgs) Handles btn_new.EnabledChanged
        Colores.ChangeColor(btn_new)
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        btn_agregar.Enabled = False
        Dim table As New Data.DataTable
        Dim str As String = "SELECT * FROM CentroMedico WHERE "
        Dim c As Integer = 0
        lbl_mensajeCtrosMedicos.Visible = False
        dvg_centrosMedicos.Rows.Clear()

        Try
            If Not String.IsNullOrEmpty(txt_numero.Text) Then
                str &= "nro_centroMedico = " & txt_numero.Text
                c = 1

                If chk_fechaBaja.Checked = True Then
                    If c = 1 Then
                        str &= " AND "
                    End If
                    str &= "fecha_baja is not NULL"
                    dvg_centrosMedicos.Columns(7).Visible = True
                Else
                    dvg_centrosMedicos.Columns(7).Visible = False
                End If

                For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
                    With row
                        dvg_centrosMedicos.Rows.Add(.Item(0).ToString, .Item(1).ToString, .Item(2).ToString, .Item(3).ToString, .Item(4).ToString, .Item(5).ToString, .Item(6).ToString, .Item(7).ToString)
                    End With

                Next
            Else
                If chk_fechaBaja.Checked = True Then
                    cargaGrilla()
                    dvg_centrosMedicos.Columns(7).Visible = True
                Else
                    dvg_centrosMedicos.Columns(7).Visible = False
                    str &= "fecha_baja is NULL"
                    For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
                        With row
                            dvg_centrosMedicos.Rows.Add(.Item(0).ToString, .Item(1).ToString, .Item(2).ToString, .Item(3).ToString, .Item(4).ToString, .Item(5).ToString, .Item(6).ToString, .Item(7).ToString)
                        End With

                    Next
                End If
            End If
            validarResultados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub validarResultados()
        If dvg_centrosMedicos.Rows.Count = 1 Then
            lbl_mensajeCtrosMedicos.Text = "No se encontraron resultados"
            lbl_mensajeCtrosMedicos.Visible = True
        End If
    End Sub

    'valida los textBox numericos 
    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero.KeyPress, txt_nroCalle.KeyPress, txt_telefono.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        txt_numero.Text = Trim(Replace(txt_numero.Text, "  ", " "))
        txt_numero.Select(txt_numero.Text.Length, 0)


    End Sub
    ' valida los textBox alfabeticos  
    Private Sub txt_denominacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_denominacion.KeyPress, txt_mail.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        txt_denominacion.Text = Trim(Replace(txt_denominacion.Text, " ", ""))
        txt_denominacion.Select(txt_denominacion.Text.Length, 0)

    End Sub




End Class