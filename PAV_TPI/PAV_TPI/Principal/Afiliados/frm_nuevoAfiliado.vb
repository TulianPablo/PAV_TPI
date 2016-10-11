Public Class frm_nuevoAfiliado

    Private Sub frm_nuevoAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombo(cbo_tipoAfiliado, BDHelper.GetTipoAfiliado(), "id_tipoAfiliado", "nombre")
        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")
        mtb_fechaAlta.Text = Date.Today.ToString
        mtb_fechaAlta.Enabled = False
        lbl_afiliados_mensaje.Visible = False

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        lbl_afiliados_mensaje.Visible = False

        If MessageBox.Show("¿Desea registrar nuevo afiliado?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If validar_campos_completos() Then
                Dim str As String = "INSERT [dbo].[Afiliado] "
                str &= "([nombre],[apellido],[id_tipoDoc],[nro_doc],[fecha_nac],[calle],[nro],[id_barrio],[telefono],[id_tipoAfiliado],[fecha_alta],[fecha_baja]) "
                str &= "VALUES('" & txt_nombre.Text & "',"
                str &= "'" & txt_apellido.Text & "',"
                str &= cbo_tipoDoc.SelectedValue & ","
                str &= txt_nroDoc.Text & ","
                str &= "'" & dtp_fechaNac.Text & "',"
                str &= "'" & txt_calle.Text & "',"
                str &= txt_nroCalle.Text & ","
                str &= cbo_barrio.SelectedValue & ","
                str &= txt_telefono.Text & ","
                str &= cbo_tipoAfiliado.SelectedValue & ","
                str &= "'" & mtb_fechaAlta.Text & "',"
                str &= "NULL)"
                BDHelper.getDBHelper.EjecutarSQL(str)
                Me.Close()
            Else
                lbl_afiliados_mensaje.Text = "Debe ingresar TODOS los datos"
                lbl_afiliados_mensaje.Visible = True
            End If
        End If

    End Sub

    Private Function validar_campos_completos() As Boolean
        If String.IsNullOrEmpty(txt_nombre.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(txt_apellido.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(txt_nroDoc.Text) Then
            Return False
        End If

        If cbo_tipoDoc.SelectedValue = -1 Then
            Return False
        End If

        If String.IsNullOrEmpty(txt_calle.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(txt_nroCalle.Text) Then
            Return False
        End If

        If cbo_barrio.SelectedValue = -1 Then
            Return False
        End If

        If cbo_tipoAfiliado.SelectedValue = -1 Then
            Return False
        End If

        Return True

    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("¿Desea cancelar el registro? Va a perder todos los datos cargados", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Valida que el campo nombre sea alfabetico
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

    'valida que el textbox nro documento sea numerico
    Private Sub txt_nroCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroCalle.KeyPress

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

        txt_nroCalle.Text = Trim(Replace(txt_nroCalle.Text, "  ", " "))
        txt_nroCalle.Select(txt_nroDoc.Text.Length, 0)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class