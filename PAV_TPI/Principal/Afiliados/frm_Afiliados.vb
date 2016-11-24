Public Class frm_Afiliados

    Public form_editarAfiliados As frm_editarAfiliados
    Public form_nuevoAfiliado As frm_nuevoAfiliado
    Public form_bajaAfiliado As frm_bajaAfiliado

    Private Sub frm_Afiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        lbl_afiliados_mensaje.Visible = False
        dgv_resultados.Columns(11).Visible = False
        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")


    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        form_editarAfiliados = New frm_editarAfiliados
        form_editarAfiliados.formConsulta = Me
        form_editarAfiliados.Show()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        form_nuevoAfiliado = New frm_nuevoAfiliado
        form_nuevoAfiliado.Show()
    End Sub

    Private Sub dgv_resultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_resultados.CellContentClick
        If String.IsNullOrEmpty(dgv_resultados.CurrentRow.Cells(11).Value) Then
            btn_editar.Enabled = True
            btn_borrar.Enabled = True
        Else
            btn_borrar.Enabled = True
        End If

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        dgv_resultados.Columns(11).Visible = False
        If Not String.IsNullOrEmpty(txt_nombre.Text) Or Not String.IsNullOrEmpty(txt_apellido.Text) Or Not String.IsNullOrEmpty(txt_nroDoc.Text) Or
            cbo_tipoDoc.SelectedValue > -1 Or cbo_tipoAfiliado.SelectedValue > -1 Or chk_fechaBaja.Checked = True Then
            If validar_campos() Then
                dgv_resultados.Rows.Clear()
                cargar_grilla_CD()
            End If
        Else
            cargar_grilla_SD()
        End If
    End Sub

    Public Sub cargar_grilla_SD()
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Afiliado").Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString,
                                                  row.Item(8).ToString, row.Item(15).ToString, row.Item(10).ToString, row.Item(11).ToString})
        Next

        If dgv_resultados.Rows.Count = 0 Then
            lbl_afiliados_mensaje.Text = "No se encontraron resultados"
            lbl_afiliados_mensaje.Visible = True
        End If

    End Sub

    Public Sub cargar_grilla_CD()
        Dim str As String = "SELECT * FROM Afiliado a JOIN TipoDoc td ON(td.id_tipoDoc=a.id_tipoDoc)"
        str &= "JOIN TipoAfiliado ta ON(ta.id_tipoAfiliado = a.id_tipoAfiliado) WHERE "
        Dim c As Integer = 0

        If Not String.IsNullOrEmpty(txt_nombre.Text) Then
            str &= "a.nombre like '%" & txt_nombre.Text & "%'"
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_apellido.Text) Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "a.apellido like '%" & txt_apellido.Text & "%'"
            c = 1
        End If

        If Not cbo_tipoDoc.SelectedValue = Nothing Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "td.nombre = '" & cbo_tipoDoc.Text & "'"
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "a.nroDoc = " & txt_nroDoc.Text
            c = 1
        End If

        If Not cbo_tipoAfiliado.SelectedValue = Nothing Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "ta.nombre = '" & cbo_tipoAfiliado.Text & "'"
            c = 1
        End If

        If chk_fechaBaja.Checked = True Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "a.fecha_baja != NULL"
            c = 1
            dgv_resultados.Columns(11).Visible = True
        End If
        If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) Or Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
            If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) And Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
                If c = 1 Then
                    str &= " AND "
                End If
                dtp_fechaDesde.Value.Day.ToString()
                str &= "a.fecha_alta BETWEEN CAST('" & dtp_fechaDesde.Text & "' AS DATE) AND CAST('" & dtp_fechaHasta.Text & "' AS DATE)"
                c = 1
            End If
        End If

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString,
                                                  row.Item(8).ToString, row.Item(15).ToString, row.Item(10).ToString, row.Item(11).ToString})
        Next
        'Valida si existen resultados o no
        If dgv_resultados.Rows.Count = 0 Then
            lbl_afiliados_mensaje.Text = "No se encontraron resultados"
            lbl_afiliados_mensaje.Visible = True
        End If

    End Sub

    Public Function validar_campos() As Boolean

        'valida que si se ingresa nro de doc tambien debe haberse ingresado tipo de doc obligatoriamente
        If cbo_tipoDoc.SelectedValue = -1 And Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            lbl_afiliados_mensaje.Text = "Falta ingresar <Tipo de Documento>"
            lbl_afiliados_mensaje.Visible = True
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
            lbl_afiliados_mensaje.Text = "La fecha Desde no puede ser mayor que la fecha Hasta"
            lbl_afiliados_mensaje.Visible = True
            Return False
        End If
        Return True

    End Function

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        form_bajaAfiliado = New frm_bajaAfiliado
        form_bajaAfiliado.formConsulta = Me
        form_bajaAfiliado.Show()

    End Sub

    'valida que el textbox nombre sea alfabetico
    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        txt_nombre.Text = Trim(Replace(txt_nombre.Text, " ", ""))
        txt_nombre.Select(txt_nombre.Text.Length, 0)

    End Sub

    'valida que el textBox apellido sea alfabetico
    Private Sub txt_apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        txt_apellido.Text = Trim(Replace(txt_apellido.Text, " ", ""))
        txt_apellido.Select(txt_apellido.Text.Length, 0)

    End Sub

    'valida que el textbox nro documento sea numerico
    Private Sub txt_nroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroDoc.KeyPress

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

        txt_nroDoc.Text = Trim(Replace(txt_nroDoc.Text, "  ", " "))
        txt_nroDoc.Select(txt_nroDoc.Text.Length, 0)

    End Sub

End Class