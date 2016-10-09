Public Class frm_bajaAfiliado

    Private Sub frm_bajaAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_apellido.Enabled = False
        txt_nombre.Enabled = False
        txt_nroDoc.Enabled = False
        cbo_tipoDoc.Enabled = False
        cbo_barrio.Enabled = False
        cbo_tipoAfiliado.Enabled = False
        dtp_fechaAlta.Enabled = False
        dtp_fechaNac.Enabled = False
        txt_calle.Enabled = False
        txt_nroCalle.Enabled = False
        txt_telefono.Enabled = False
        dtp_fechabaja.Enabled = False

    End Sub

    Private Sub cargar_datos(ByVal dat() As String)
        txt_apellido.Text = dat(1).ToString
        txt_nombre.Text = dat(0).ToString
        txt_nroDoc.Text = dat(2).ToString
        cbo_tipoDoc.Text = dat(3).ToString
        cbo_barrio.Text = dat(4).ToString
        cbo_tipoAfiliado.Text = dat(5).ToString
        dtp_fechaAlta.Text = dat(6).ToString
        dtp_fechaNac.Text = dat(7).ToString
        txt_calle.Text = dat(8).ToString
        txt_nroCalle.Text = dat(9).ToString
        txt_telefono.Enabled = dat(10).ToString
        dtp_fechabaja.Enabled = DateTime.Now.ToShortDateString
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

    End Sub
End Class