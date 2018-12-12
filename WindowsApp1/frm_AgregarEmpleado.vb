Public Class frm_AgregarEmpleado
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim persona As New frm_nuevoUsuario
        persona.ShowDialog()


    End Sub
End Class