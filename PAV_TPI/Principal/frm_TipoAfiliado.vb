Public Class frm_TipoAfiliado
    Dim bd As BDHelper = BDHelper.getDBHelper
    Friend row_selected As DataGridViewRow
    Dim consulta As String

    Private Sub frm_TipoAfiliado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_TipoAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_quitar.Enabled = False
        txt_id.Focus()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        dgv_rdos.Rows.Clear()
        If String.IsNullOrEmpty(txt_tipoAfiliado.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            consulta = "SELECT * FROM TipoAfiliado"
        Else
            consulta = "SELECT * FROM TipoAfiliado WHERE id_tipoAfiliado = " + txt_id.Text

        End If
        For Each row As DataRow In bd.ConsultaSQL(consulta).Rows
            dgv_rdos.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
        Next
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim consulta_editar As String

        If Not String.IsNullOrEmpty(txt_tipoAfiliado.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            txt_id.Enabled = False
            consulta_editar = "INSERT TipoAfiliado VALUES('" + txt_tipoAfiliado.Text + "')"
            bd.EjecutarSQL(consulta_editar)
            dgv_rdos.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM TipoAfiliado").Rows
                dgv_rdos.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        Else
            txt_id.Enabled = False
            MsgBox("Debe ingresar el nombre del tipo de afiliado únicamente.", MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim consulta_editar As String
        If MessageBox.Show("¿Desea editar el tipo de afiliado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            txt_id.Enabled = False
            If Not String.IsNullOrEmpty(txt_tipoAfiliado.Text) Then
                consulta_editar = "UPDATE TipoAfiliado SET nombre = '" + txt_tipoAfiliado.Text + "'"
                consulta_editar += "WHERE id_tipoAfiliado = " & dgv_rdos.CurrentRow.Cells(0).Value()
                consulta_editar += " AND nombre = '" + dgv_rdos.CurrentRow.Cells(1).Value + "'"
            Else
                MsgBox("Debe ingresar el nombre únicamente.", MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            bd.EjecutarSQL(consulta_editar)
            dgv_rdos.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM TipoAfiliado").Rows
                dgv_rdos.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        End If
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If MessageBox.Show("¿Desea eliminar el tipo de afiliado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_editar As String
            consulta_editar = "DELETE Especialidad WHERE id_tipoAfiliado = " + dgv_rdos.CurrentRow.Cells(0).Value()
            consulta_editar += " AND nombre = '" + dgv_rdos.CurrentRow.Cells(1).Value() + "'"
            bd.EjecutarSQL(consulta_editar)
            dgv_rdos.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM TipoAfiliado").Rows
                dgv_rdos.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        End If
    End Sub

    Private Sub dgv_bugs_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_rdos.CellClick
        btn_quitar.Enabled = True
        btn_editar.Enabled = True
        row_selected = dgv_rdos.CurrentRow
    End Sub
End Class