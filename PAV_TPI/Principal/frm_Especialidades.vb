Public Class frm_Especialidades

    Dim bd As BDHelper = BDHelper.getDBHelper
    Friend row_selected As DataGridViewRow
    Dim consulta As String


    Public Sub frm_especialidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id.Enabled = True
        txt_especialidad.Enabled = True
        lbl_Especialidad_mensaje.Visible = False
        btn_buscar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = True
        btn_quitar.Enabled = False

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        dgv_resultados.Rows.Clear()
        btn_quitar.Enabled = False
        btn_editar.Enabled = False

        If String.IsNullOrEmpty(txt_especialidad.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            consulta = "SELECT * FROM Especialidad"
        Else
            consulta = "SELECT * FROM Especialidad WHERE id_especialidad = " & txt_id.Text
        End If

        For Each row As DataRow In bd.ConsultaSQL(consulta).Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString})
        Next

    End Sub


    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim consulta_editar As String
        lbl_Especialidad_mensaje.Visible = False
        btn_editar.Enabled = False
        btn_quitar.Enabled = False

        If Not String.IsNullOrEmpty(txt_especialidad.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            txt_id.Enabled = False
            If validar_repeticion() Then

                consulta_editar = "INSERT Especialidad VALUES('" & txt_especialidad.Text & "',NULL)"
                bd.EjecutarSQL(consulta_editar)
                dgv_resultados.Rows.Clear()
                For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                    dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString})
                Next
            Else
                lbl_Especialidad_mensaje.Text = "La especialidad ya existe"
                lbl_Especialidad_mensaje.Visible = True
            End If
        Else
            txt_id.Clear()
            txt_id.Enabled = False
            lbl_Especialidad_mensaje.Text = "Debe ingresar nombre de especialidad solamente"
            lbl_Especialidad_mensaje.Visible = True
            Exit Sub
        End If

    End Sub

    Private Function validar_repeticion() As Boolean
        For Each row As DataGridViewRow In dgv_resultados.Rows
            If txt_especialidad.Text = row.Cells(1).Value Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If MessageBox.Show("¿Desea borrar la especialidad?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_baja As String
            consulta_baja = "UPDATE Especialidad SET fecha_baja = GETDATE() WHERE id_especialidad = " & dgv_resultados.CurrentRow.Cells(0).Value()
            bd.EjecutarSQL(consulta_baja)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString})
            Next
        End If
    End Sub

    Private Sub dgv_bugs_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_resultados.CellClick
        If String.IsNullOrEmpty(dgv_resultados.CurrentRow.Cells(2).Value) Then
            btn_quitar.Enabled = True
            btn_editar.Enabled = True
            row_selected = dgv_resultados.CurrentRow
        End If
        
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim consulta_editar As String
        lbl_Especialidad_mensaje.Visible = False
        If MessageBox.Show("¿Desea editar la especialidad?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            txt_id.Enabled = False
            If Not String.IsNullOrEmpty(txt_especialidad.Text) Then
                consulta_editar = "UPDATE Especialidad SET nombre = '" & txt_especialidad.Text & "'"
                consulta_editar &= "WHERE id_especialidad = " & dgv_resultados.CurrentRow.Cells(0).Value()
                consulta_editar &= " AND nombre = '" & dgv_resultados.CurrentRow.Cells(1).Value & "'"
            Else
                lbl_Especialidad_mensaje.Text = "Debe ingresar nombre solamente"
                lbl_Especialidad_mensaje.Visible = True
                Exit Sub
            End If

            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString})
            Next
        End If

    End Sub


    ''PARA MODIFICAR EL COLOR DE LOS BOTONES CUANDO ESTAN DESHABILITADOS
    'Private Sub btn_nuevo_EnabledChanged(sender As Object, e As EventArgs) Handles btn_nuevo.EnabledChanged
    '    Colores.ChangeColor(btn_nuevo)
    'End Sub

    'Private Sub btn_editar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_editar.EnabledChanged
    '    Colores.ChangeColor(btn_editar)
    'End Sub

    'Private Sub btn_quitar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_quitar.EnabledChanged
    '    Colores.ChangeColor(btn_quitar)
    'End Sub

    'Private Sub btn_buscar_EnabledChanged(sender As Object, e As EventArgs) Handles btn_buscar.EnabledChanged
    '    Colores.ChangeColor(btn_buscar)
    'End Sub
End Class