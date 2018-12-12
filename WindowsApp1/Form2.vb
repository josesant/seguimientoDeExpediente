Public Class frm_nuevoUsuario


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim juan As New frm_nuevoUsuario


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lbl_domici.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frm_nuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_apelli.BackColor = Color.Transparent
        lbl_dni.BackColor = Color.Transparent
        lbl_domici.BackColor = Color.Transparent
        lbl_nombre.BackColor = Color.Transparent
        lbl_tel.BackColor = Color.Transparent
        lbl_titulo.BackColor = Color.Transparent


    End Sub
End Class