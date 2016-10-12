Public Class frm_Profesionales
    Public form_nuevoProfesional As frm_nuevoProfesional
    Public form_bajaProfesional As frm_bajaProfesional
    Public form_editarProfesional As frm_editarProfesional

    Private Sub frm_Profesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_profesionales_mensaje.Visible = False
        btn_editar.Enabled = False
        btn_borrar.Enabled = False

        dgv_resultados.Columns(11).Visible = False
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        form_nuevoProfesional = New frm_nuevoProfesional
        form_nuevoProfesional.Show()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        form_editarProfesional = New frm_editarProfesional
        form_editarProfesional.Show()
    End Sub

    Public Sub cargar_grilla_CD()
        Dim str As String = "SELECT * FROM Profesional p JOIN TipoDoc td ON (td.id_tipoDoc = p.id_tipoDoc) "
        Dim c As Integer = 0

        If Not String.IsNullOrEmpty(txt_nombre.Text) Then
            str &= "p.nombre LIKE '%" & txt_nombre.Text & "%'"
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_apellido.Text) Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "p.apellido LIKE '%" & txt_apellido.Text & "%'"
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
            str &= "p.nroDoc = " & txt_nroDoc.Text
            c = 1
        End If

        If chk_fechaBaja.Checked = True Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "p.fecha_baja != NULL"
            c = 1
            dgv_resultados.Columns(11).Visible = True
        End If

        'If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) Or Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
        '    If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) And Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
        '        If c = 1 Then
        '            str &= " AND "
        '        End If
        '        dtp_fechaDesde.Value.Day.ToString()
        '        str &= "p.fecha_alta BETWEEN CAST('" & dtp_fechaDesde.Text & "' AS DATE) AND CAST('" & dtp_fechaHasta.Text & "' AS DATE)"
        '        c = 1
        '    End If
        'End If

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString,
                                                  row.Item(8).ToString, row.Item(9).ToString, row.Item(10).ToString, row.Item(11).ToString,
                                                  row.Item(12).ToString, row.Item(13).ToString})
        Next
        'Valida si existen resultados o no
        If dgv_resultados.Rows.Count = 0 Then
            lbl_profesionales_mensaje.Text = "No se encontraron resultados."
            lbl_profesionales_mensaje.Visible = True
        End If
    End Sub

    Public Function validar_campos() As Boolean
        'valida que si se ingresa nro de doc tambien debe haberse ingresado tipo de doc obligatoriamente
        If cbo_tipoDoc.SelectedValue = -1 And Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            lbl_profesionales_mensaje.Text = "Falta ingresar Tipo de Documento."
            lbl_profesionales_mensaje.Visible = True
            Return False
        End If

        'Dim result As Integer = DateTime.Compare(dtp_fechaDesde.Value.Date, dtp_fechaHasta.Value.Date)
        'If result > 0 Then
        '    lbl_profesionales_mensaje.Text = "La fecha Desde no puede ser mayor que la fecha Hasta."
        '    lbl_profesionales_mensaje.Visible = True
        '    Return False
        'End If
        Return True
    End Function

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        form_bajaProfesional = New frm_bajaProfesional
        form_bajaProfesional.Show()
    End Sub


    'PARA MODIFICAR EL COLOR DE LOS BOTONES CUANDO ESTAN DESHABILITADOS
    Private Sub btn_agregar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_agregar.EnabledChanged
        If (btn_agregar.Enabled = False) Then
            btn_agregar.BackColor = Colores.GetGris
            btn_agregar.ForeColor = Colores.GetGris
        Else
            btn_agregar.BackColor = Color.White
            btn_agregar.ForeColor = Colores.GetVerdeAgua
        End If
    End Sub

    Private Sub btn_editar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_editar.EnabledChanged
        If (btn_editar.Enabled = False) Then
            btn_editar.BackColor = Colores.GetGris
            btn_editar.ForeColor = Colores.GetGris
        Else
            btn_editar.BackColor = Color.White
            btn_editar.ForeColor = Colores.GetVerdeAgua
        End If
    End Sub

    Private Sub btn_borrar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_borrar.EnabledChanged
        If (btn_borrar.Enabled = False) Then
            btn_borrar.BackColor = Colores.GetGris
            btn_borrar.ForeColor = Colores.GetGris
        Else
            btn_borrar.BackColor = Color.White
            btn_borrar.ForeColor = Colores.GetVerdeAgua
        End If
    End Sub

End Class