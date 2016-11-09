Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteAtenciones_CtroMedico

    Private Sub frm_ReporteAtenciones_CtroMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txt_fecDesde.Text = Date.Now.AddDays(-30).ToShortDateString()
        Me.txt_fecHasta.Text = Date.Now.ToShortDateString()
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        If IsDate(txt_fecDesde.Text) And IsDate((txt_fecHasta.Text)) Then
            rpt_atencionesCtroMedico.LocalReport.SetParameters({New ReportParameter("pFechaDesde", txt_fecDesde.Text), New ReportParameter("pFechaHasta", txt_fecHasta.Text)})
            rpt_atencionesCtroMedico.LocalReport.DataSources.Clear()
            rpt_atencionesCtroMedico.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.generarReporte(txt_fecDesde.Text, txt_fecHasta.Text)))
            rpt_atencionesCtroMedico.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class