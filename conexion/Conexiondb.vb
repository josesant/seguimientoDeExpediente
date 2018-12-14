Imports MySql.Data.MySqlClient
Public Class Conexiondb
    Public conec As New MySqlConnection
    Public cnn As New MySqlCommand

    Public Sub conectar()
        Try
            conec.ConnectionString = "Server=localhost;Database=prueba2222;Uid=root;Pwd=;"
            conec.Open()
            MsgBox("se conecto")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            conec.Clone()
            MsgBox("se desconecto")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
Public Class insercion
    Public cnn As New MySqlCommand

    Function insertarOficina()

        cnn.CommandText = "select "

    End Function
End Class
