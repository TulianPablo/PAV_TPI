Imports Microsoft.Reporting.WinForms

Public Class frm_ListadoAtencionesPorCentroMedico

    Private Sub frm_ListadoAtencionesPorCentroMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn_actualizar_Click(sender, Nothing)
        rpt_listadoAtencionesPorCentro.RefreshReport()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        rpt_listadoAtencionesPorCentro.LocalReport.SetParameters({New ReportParameter("pCentroMedico", TextBox1.Text)})
        rpt_listadoAtencionesPorCentro.LocalReport.DataSources.Clear()
        rpt_listadoAtencionesPorCentro.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.generarListado_AtencionesCentro(TextBox1.Text)))
        rpt_listadoAtencionesPorCentro.RefreshReport()
    End Sub
End Class