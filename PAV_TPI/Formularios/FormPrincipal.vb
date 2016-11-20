Public Class frm_principal
    Public form_especialidades As frm_especialidades

    
    Private Sub btn_especialidades_Click(sender As Object, e As EventArgs) Handles btn_especialidades.Click
        form_especialidades = New frm_especialidades
        form_especialidades.Show()
    End Sub
End Class
