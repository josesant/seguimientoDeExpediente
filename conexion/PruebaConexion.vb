Public Class PruebaConexion
    Private Sub btn_conec_Click(sender As Object, e As EventArgs) Handles btn_conec.Click
        Dim conectar As New Conexiondb
        conectar.conectar()

        Me.Visible = "false"
        btn_desccone.Visible = "True"


    End Sub

    Private Sub btn_desccone_Click(sender As Object, e As EventArgs) Handles btn_desccone.Click
        Dim desc As New Conexiondb
        desc.desconectar()

        btn_conec.Visible = "True"
        Me.Visible = "False"
    End Sub
End Class