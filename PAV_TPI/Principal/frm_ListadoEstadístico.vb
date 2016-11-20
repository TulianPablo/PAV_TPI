Imports Microsoft.Reporting.WinForms

Public Class frm_ListadoEstadístico

    Private Sub Listados_Estadisticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombo(cbo_ctrosMedico, BDHelper.GetCentrosMedico, "nro_centroMedico", "denominacion")
        rpt_estadistico.RefreshReport()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        rpt_estadistico.LocalReport.SetParameters({New ReportParameter("pcentroMedico", cbo_ctrosMedico.SelectedValue.ToString)})
        rpt_estadistico.LocalReport.DataSources.Clear()
        rpt_estadistico.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.generar_estaditica(cbo_ctrosMedico.SelectedValue.ToString)))
        rpt_estadistico.RefreshReport()
    End Sub

    Private Sub CargarCombo(combo As ComboBox, datos As Object, pk As String, descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub
    
End Class