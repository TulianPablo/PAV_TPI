Public Class frm_nuevoAfiliado

    Private Sub frm_nuevoAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")
        mtb_fechaAlta.Text = Date.Today.ToString
        mtb_fechaAlta.Enabled = False
        lbl_afiliados_mensaje.Enabled = False

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As FormClosingEventArgs) Handles btn_aceptar.Click
        If MessageBox.Show("¿Desea registrar nuevo afiliado?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If validar_campos_completos() Then
                Dim str As String = "INSERT Afiliado"
                str &= "values('" & txt_nombre.Text & "',"
                str &= "'" & txt_apellido.Text & "',"
                str &= cbo_tipoDoc.SelectedValue + 1 & ","
                str &= txt_nroDoc.Text & ","
                str &= "'" & dtp_fechaNac.Text & "',"
                str &= "'" & txt_calle.Text & "',"
                str &= txt_nroCalle.Text & ","
                str &= cbo_barrio.SelectedValue + 1 & ","
                str &= txt_telefono.Text & ","
                str &= cbo_tipoAfiliado.SelectedValue + 1 & ","
                str &= "'" & mtb_fechaAlta.Text & "',"
                str &= "NULL)"
                BDHelper.getDBHelper.EjecutarSQL(str)
                lbl_afiliados_mensaje.Enabled = False
            End If
        Else
            lbl_afiliados_mensaje.Text = "Debe ingresar TODOS los datos"
            lbl_afiliados_mensaje.Enabled = True
        End If
    End Sub

    Private Function validar_campos_completos() As Boolean
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

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("¿Desea cancelar el registro? Va a perdre todos los datos cargados", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_apellido.MaskInputRejected

    End Sub
End Class