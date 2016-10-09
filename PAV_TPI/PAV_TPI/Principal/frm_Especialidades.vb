Public Class frm_Especialidades

    Dim bd As BDHelper = BDHelper.getDBHelper
    Friend row_selected As DataGridViewRow
    Dim consulta As String

    Public Sub frm_especialidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id.Enabled = True
        txt_especialidad.Enabled = True
        btn_buscar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = True
        btn_quitar.Enabled = False

    End Sub

    Private Sub frm_especialidades_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        dgv_resultados.Rows.Clear()
        If String.IsNullOrEmpty(txt_especialidad.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            consulta = "SELECT * FROM Especialidad"
        Else
            consulta = "SELECT * FROM Especialidad WHERE id_especialidad = " & txt_id.Text

        End If
        For Each row As DataRow In bd.ConsultaSQL(consulta).Rows
            dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
        Next

    End Sub


    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim consulta_editar As String

        If Not String.IsNullOrEmpty(txt_especialidad.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            txt_id.Enabled = False
            consulta_editar = "INSERT Especialidad VALUES('" & txt_especialidad.Text & "')"
            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        Else
            txt_id.Enabled = False
            MsgBox("Debe ingresar nombre de especialidad solamente", MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If

    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If MessageBox.Show("¿Desea borrar la especialidad?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_editar As String
            consulta_editar = "DELETE Especialidad WHERE id_especialidad = " & dgv_resultados.CurrentRow.Cells(0).Value()
            consulta_editar &= " AND nombre = '" & dgv_resultados.CurrentRow.Cells(1).Value() & "'"
            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        End If

    End Sub

    Private Sub dgv_bugs_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_resultados.CellClick
        btn_quitar.Enabled = True
        btn_editar.Enabled = True
        row_selected = dgv_resultados.CurrentRow
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim consulta_editar As String
        If MessageBox.Show("¿Desea editar la especialidad?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            txt_id.Enabled = False
            If Not String.IsNullOrEmpty(txt_especialidad.Text) Then
                consulta_editar = "UPDATE Especialidad SET nombre = '" & txt_especialidad.Text & "'"
                consulta_editar &= "WHERE id_especialidad = " & dgv_resultados.CurrentRow.Cells(0).Value()
                consulta_editar &= " AND nombre = '" & dgv_resultados.CurrentRow.Cells(1).Value & "'"
            Else
                MsgBox("Debe ingresar nombre solamente", MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Especialidad").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class