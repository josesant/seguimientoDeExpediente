Public Class frm_principal
    Private Sub btn_mesa_Click(sender As Object, e As EventArgs) Handles btn_mesa.Click
        Dim mesa As New Frm_expediente

        mesa.Show()




    End Sub

    Private Sub btn_normal_Click(sender As Object, e As EventArgs) Handles btn_normal.Click
        Dim normal As New frm_normal
        normal.ShowDialog()


    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Dim admin As New frm_adminstrador
        admin.ShowDialog()



    End Sub

    Private Sub btn_oficina_Click(sender As Object, e As EventArgs) Handles btn_oficina.Click
        Dim oficina As New frm_empleado
        oficina.ShowDialog()

    End Sub
End Class