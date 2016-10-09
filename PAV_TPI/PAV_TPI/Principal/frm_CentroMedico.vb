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
        txt_numero.Enabled = True
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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        dvg_centrosMedicos.Rows.Clear()
        Dim table As New Data.DataTable

        Try
            If String.IsNullOrEmpty(txt_numero.Text) Then
                cargaGrilla()
            Else

                Dim busqueda As String = "SELECT * FROM CentroMedico WHERE nro_centroMedico = " & txt_numero.Text

                table = BDHelper.getDBHelper.ConsultaSQL(busqueda)
                If (table.Rows.Count = 1) Then

                    dvg_centrosMedicos.Rows.Add(table.Rows(0)("nro_centroMedico"), _
                                                table.Rows(0)("denominacion"), _
                                                table.Rows(0)("calle"), _
                                                table.Rows(0)("numero"), _
                                                table.Rows(0)("id_barrio"), _
                                                table.Rows(0)("telefono"), _
                                                table.Rows(0)("mail"), _
                                                table.Rows(0)("fecha_baja"))

                Else
                    MsgBox("El Centro Médico no existe.", vbOKOnly + vbCritical, "Aviso")
                End If


            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya está cargado un Centro Médico con ese número.", _
                                    "Importante", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
            Me.cargaGrilla()
            MessageBox.Show("Se grabó exitosamente.", "Importante", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        'habilitar_desabilitar(True)
        btn_borrar.Enabled = False
        txt_numero.Focus()
        Me.accion = estado.insertar
    End Sub


    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If MessageBox.Show("¿Desea borrar el centro médico?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_delete As String
            consulta_delete = "UPDATE centroMedico SET fecha_baja = " & "GETDATE()" & " WHERE nro_CentroMedico = " & dvg_centrosMedicos.CurrentRow.Cells(0).Value()

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

        ' Valida los campos requeridos ' 
        If String.IsNullOrEmpty(txt_numero.Text) Then
            MsgBox("Campo <Nro. Centro> es obligatorio.", vbOKOnly + vbCritical, "Importante")
            txt_numero.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_denominacion.Text) Then
            MsgBox("Campo <Denominacion> es obligatorio.", vbOKOnly + vbCritical, "Importante")
            txt_denominacion.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_calle.Text) Then
            MsgBox("Campo <Calle> es obligatorio. ", vbOKOnly + vbCritical, "Importante")
            txt_calle.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_nroCalle.Text) Then
            MsgBox("Campo < Nro. Calle > es obligatorio. ", vbOKOnly + vbCritical, "Importante")
            txt_nroCalle.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(cmb_barrio.SelectedIndex = -1) Then
            MsgBox("Campo < Barrio > es obligatorio. ", vbOKOnly + vbCritical, "Importante")
            cmb_barrio.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_telefono.Text) Then
            MsgBox("Campo < Telefono > es obligatorio. ", vbOKOnly + vbCritical, "Importante")
            txt_telefono.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txt_mail.Text) Then
            MsgBox("Campo < Mail > es obligatorio. ", vbOKOnly + vbCritical, "Importante")
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
        dvg_centrosMedicos.Rows.Clear()
        cargaGrilla()

    End Sub
    Private Sub dvg_centroMedicos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvg_centrosMedicos.CellClick
        btn_borrar.Enabled = True
        btn_editar.Enabled = True
        row_selected = dvg_centrosMedicos.CurrentRow

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If MessageBox.Show("¿Desea editar el centro médico?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            habilitar_desabilitar(True)
            Dim tabla As New Data.DataTable
            Dim consulta As String = "SELECT * FROM CentroMedico WHERE nro_centroMedico = " + row_selected.Cells(0).Value
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

End Class