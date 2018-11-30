Public Class Causante
    Inherits Persona

    Public Sub New(nombre As String, apellido As String, dni As Integer, domicilio As String, telefono As Integer, mail As String, tipo As Boolean)
        MyBase.New(nombre, apellido, dni, domicilio, telefono, mail, tipo)
    End Sub
End Class
