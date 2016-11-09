Public Class frm_MenuReportes

    
    Private Sub btn_reporteAtencionesCtro_Click(sender As Object, e As EventArgs) Handles btn_reporteAtencionesCtro.Click
        frm_ReporteAtenciones_CtroMedico.ShowDialog()

    End Sub


    Private Sub btn_listadoAtencionesCtroMedico_Click(sender As Object, e As EventArgs) Handles btn_listadoAtencionesCtroMedico.Click
        frm_ListadoAtencionesPorCentroMedico.ShowDialog()

    End Sub
End Class