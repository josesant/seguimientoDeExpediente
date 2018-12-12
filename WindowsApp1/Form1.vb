Public Class frm_Logeo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_contrase.BackColor = Color.Transparent
        lbl_titulo.BackColor = Color.Transparent
        lbl_usuario.BackColor = Color.Transparent

    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        Dim nuevo As New frm_nuevoUsuario

        nuevo.ShowDialog()


    End Sub

    Private Sub lbl_contrase_Click(sender As Object, e As EventArgs) Handles lbl_contrase.Click

    End Sub

    Private Sub lbl_titulo_Click(sender As Object, e As EventArgs) Handles lbl_titulo.Click

    End Sub

    Private Sub btn_ingresaar_Click(sender As Object, e As EventArgs) Handles btn_ingresaar.Click

        '   Dim prueba As New Frm_expediente
        '  prueba.Show()
        'prueba de mesa de entrada

        ' Dim portada As New frm_portada
        'portada.Show()
        'prueba de portada

        Dim foja As New frm_foja
        foja.Show()
        'prueba de foja

    End Sub
End Class
