Imports Microsoft.Reporting.WinForms

Public Class frm_ListadoAtencionesPorCentroMedico

    Private Sub frm_ListadoAtencionesPorCentroMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn_actualizar_Click(sender, Nothing)
        CargarCombo(cbo_ctrosMedico, BDHelper.GetCentrosMedico, "nro_centroMedico", "denominacion")
        rpt_listadoAtencionesPorCentro.RefreshReport()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        rpt_listadoAtencionesPorCentro.LocalReport.SetParameters({New ReportParameter("pCentroMedico", cbo_ctrosMedico.Text)})
        rpt_listadoAtencionesPorCentro.LocalReport.DataSources.Clear()
        rpt_listadoAtencionesPorCentro.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.generarListado_AtencionesCentro(cbo_ctrosMedico.Text)))
        rpt_listadoAtencionesPorCentro.RefreshReport()
    End Sub

    Private Sub CargarCombo(combo As ComboBox, datos As Object, pk As String, descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub
End Class