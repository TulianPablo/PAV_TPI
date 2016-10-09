Public Class frm_Practicas
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As estado = estado.insertar
    Dim bd As BDHelper = BDHelper.getDBHelper
    Friend row_selected As DataGridViewRow
    Dim consulta As String

    Private Sub frm_Practicas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Practicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarCampos(False)
        CargarCombo(cbo_especialidad, BDHelper.GetEspecialidades(), "id_especialidad", "nombre")
    End Sub

    Private Sub HabilitarCampos(flag As Boolean)
        btn_editar.Enabled = flag
        btn_quitar.Enabled = flag
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim consulta_editar As String

        If Not String.IsNullOrEmpty(txt_nombre.Text) And String.IsNullOrEmpty(txt_id.Text) Then
            txt_id.Enabled = False
            consulta_editar = "INSERT Practica VALUES('" & txt_nombre.Text & "')"
            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Practica").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        Else
            txt_id.Enabled = False
            MsgBox("Debe ingresar el nombre de la Práctica únicamente", MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If MessageBox.Show("¿Desea eliminar la Práctica?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim consulta_editar As String
            consulta_editar = "DELETE Practica WHERE id_practica = " & dgv_resultados.CurrentRow.Cells(0).Value()
            consulta_editar &= " AND nombre = '" & dgv_resultados.CurrentRow.Cells(1).Value() & "'"
            bd.EjecutarSQL(consulta_editar)
            dgv_resultados.Rows.Clear()
            For Each row As DataRow In bd.ConsultaSQL("SELECT * FROM Practica").Rows
                dgv_resultados.Rows.Add(New String() {row.Item(0).ToString, row.Item(1).ToString})
            Next
        End If
    End Sub
End Class