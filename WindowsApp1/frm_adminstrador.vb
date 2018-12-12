Public Class frm_adminstrador
    Private Sub btn_Empleado_Click(sender As Object, e As EventArgs) Handles btn_Empleado.Click

        Dim agregar As New frm_AgregarEmpleado




        agregar.ShowDialog()


    End Sub

    Private Sub btn_oficina_Click(sender As Object, e As EventArgs) Handles btn_oficina.Click
        Dim agregarOfina As New frm_oficina
        agregarOfina.ShowDialog()

    End Sub
End Class