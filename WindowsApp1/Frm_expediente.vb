Public Class Frm_expediente
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_expediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_buscar.BackColor = Color.Transparent

    End Sub

    Private Sub btn_agregarExpediente_Click(sender As Object, e As EventArgs) Handles btn_agregarExpediente.Click
        Dim portada As New frm_portada
        portada.ShowDialog()


    End Sub
End Class