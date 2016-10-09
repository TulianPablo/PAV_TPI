Public Class frm_Afiliados

    Public form_editarAfiliados As frm_editarAfiliados
    Public form_nuevoAfiliado As frm_nuevoAfiliado

    Private Sub frm_Afiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        form_editarAfiliados = New frm_editarAfiliados
        form_editarAfiliados.Show()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        form_nuevoAfiliado = New frm_nuevoAfiliado
        form_nuevoAfiliado.Show()
    End Sub

    Private Sub dgv_resultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_resultados.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If String.IsNullOrEmpty(txt_nombre.Text) And String.IsNullOrEmpty(txt_apellido.Text) And String.IsNullOrEmpty(txt_nroDoc.Text) And
            cbo_tipoAfiliado.SelectedValue = -1 And cbo_tipoDoc.SelectedValue = -1 And String.IsNullOrEmpty(dtp_fechaDesde.Text) And
            String.IsNullOrEmpty(dtp_fechaHasta.Text) And chk_fechaBaja.Checked = False Then

            cargar_grilla_SD()
        Else
            cargar_grilla_CD()
        End If
    End Sub

    Public Sub cargar_grilla_SD()
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Afiliado").Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString,
                                                  row.Item(8).ToString, row.Item(9).ToString, row.Item(10).ToString, row.Item(11).ToString,
                                                  row.Item(12).ToString, row.Item(13).ToString})
        Next
    End Sub

    Public Sub cargar_grilla_CD()
        Dim str As String = "SELECT * FROM Afiliado a JOIN TipoDoc td ON(td.id_tipoDoc=a.id_tipoDoc)"
        str &= "JOIN TipoAfiliado ta ON(ta.id_tipoAfiliado = a.id_tipoAfiliado) WHERE "
        Dim c As Integer = 0

        If Not String.IsNullOrEmpty(txt_nombre.Text) Then
            str &= "a.nombre = '" & txt_nombre.Text & "'"
            c = 1
        End If

        If Not String.IsNullOrEmpty(txt_apellido.Text) Then
            If c = 1 Then
                str &= " AND "
            End If
            str &= "a.apellido = '" & txt_apellido.Text & "'"
            c = 1
        End If

        If Not cbo_tipoDoc.SelectedValue = -1 Then
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

        If Not cbo_tipoAfiliado.SelectedValue = -1 Then
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
        End If
        If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) Or Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
            If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) Or String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
                If c = 1 Then
                    str &= " AND "
                End If
                dtp_fechaDesde.Value.Day.ToString()
                str &= "a.fechaAlta BETWEEN CAST(" & dtp_fechaDesde.Text & " AS DATE) AND GETDATE()"
                c = 1
            End If
            If String.IsNullOrEmpty(dtp_fechaDesde.Text) Or Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
                If c = 1 Then
                    str &= " AND "
                End If
                dtp_fechaDesde.Value.Day.ToString()
                str &= "a.fechaAlta BETWEEN GETDATE() AND CAST(" & dtp_fechaDesde.Text & " AS DATE)"
                c = 1
            End If
            If Not String.IsNullOrEmpty(dtp_fechaDesde.Text) And Not String.IsNullOrEmpty(dtp_fechaHasta.Text) Then
                If c = 1 Then
                    str &= " AND "
                End If
                dtp_fechaDesde.Value.Day.ToString()
                str &= "a.fechaAlta BETWEEN CAST(" & dtp_fechaDesde.Text & " AS DATE) AND CAST(" & dtp_fechaHasta.Text & " AS DATE)"
                c = 1
            End If
        End If

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString,
                                                  row.Item(4).ToString, row.Item(5).ToString, row.Item(6).ToString, row.Item(7).ToString,
                                                  row.Item(8).ToString, row.Item(9).ToString, row.Item(10).ToString, row.Item(11).ToString,
                                                  row.Item(12).ToString, row.Item(13).ToString})
        Next

    End Sub

    Public Function validar_campos() As Boolean

        If String.IsNullOrEmpty(txt_nombre.Text) Then
            MsgBox("Campo <Nombre> es obligatorio.", vbOKOnly + vbCritical, "Importante")
            txt_nombre.Focus()
            Return False
        Else
            If (txt_nombre.Text >= 0) And (txt_nombre.Text <= 57) Then
                MsgBox("El campo <Nombre> es alfabetico", vbOKOnly + vbCritical, "Importante")
                txt_nombre.Text = 8
                Return False
            End If
        End If

        If String.IsNullOrEmpty(txt_apellido.Text) Then
            MsgBox("Campo <Apellido> es obligatorio.", vbOKOnly + vbCritical, "Importante")
            txt_nombre.Focus()
            Return False
        Else
            If (txt_nombre.Text >= 0) And (txt_nombre.Text <= 57) Then
                MsgBox("El campo <Apellido> es alfabetico", vbOKOnly + vbCritical, "Importante")
                txt_nombre.Text = 8
                Return False
            End If
        End If

        If String.IsNullOrEmpty(txt_nroDoc.Text) Then
            MsgBox("Campo <Nro Documento> es obligatorio.", vbOKOnly + vbCritical, "Importante")
            txt_nombre.Focus()
            Return False
        Else
            If (txt_nombre.Text >= 48) And (txt_nombre.Text <= 57) Then
                MsgBox("El campo <Nro Documento> es numerico", vbOKOnly + vbCritical, "Importante")
                txt_nombre.Text = 8
                Return False
            End If
        End If

        If cbo_tipoDoc.SelectedValue = -1 And Not String.IsNullOrEmpty(txt_nroDoc.Text) Then
            MsgBox("Falta ingresar <Tipo de Documento>", vbOKOnly + vbCritical, "Importante")
            cbo_tipoDoc.Focus()
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

End Class