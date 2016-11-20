Public Class frm_nuevoProfesional
    Private Sub frm_nuevoProfesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_fechaAlta.Text = Date.Today.ToString
        txt_fechaAlta.Enabled = False
        lbl_profesionales_mensaje.Visible = False

        CargarCombo(cbo_tipoDoc, BDHelper.GetTipoDoc(), "id_tipoDoc", "nombre")
        CargarCombo(cbo_barrio, BDHelper.GetBarrios(), "id_barrio", "nombre")
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        lbl_profesionales_mensaje.Visible = False

        If MessageBox.Show("¿Desea registrar el nuevo profesional?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If validar_camposCompletos() Then
                Dim str As String = "INSERT [dbo].[Profesional] "
                str &= "([matricula],[apellido],[nombre],[id_tipoDoc],[nro_doc],[fecha_nac],[calle],[nro],[id_barrio],[telefono],[fecha_baja],[fecha_alta]) "
                str &= "VALUES('" & txt_matricula.Text & "',"
                str &= "'" & txt_apellido.Text & "',"
                str &= "'" & txt_nombre.Text & "',"
                str &= cbo_tipoDoc.SelectedValue & ","
                str &= txt_nroDoc.Text & ","
                str &= "'" & dtp_fechaNac.Text & "',"
                str &= "'" & txt_calle.Text & "',"
                str &= txt_nroCalle.Text & ","
                str &= cbo_barrio.SelectedValue & ","
                str &= txt_telefono.Text & ","
                str &= "NULL,"
                str &= "'" & txt_fechaAlta.Text & "')"
                BDHelper.getDBHelper.EjecutarSQL(str)
                Me.Close()
            Else
                lbl_profesionales_mensaje.Text = "Debe ingresar TODOS los datos"
                lbl_profesionales_mensaje.Visible = True
            End If
        End If
    End Sub

    Private Function validar_camposCompletos() As Boolean
        If String.IsNullOrEmpty(txt_matricula.Text) Then
            Return False
        End If

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
        Return True

    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar el registro?" & vbNewLine & "Se perderán todos los datos cargados", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class