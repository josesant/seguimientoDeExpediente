Public Class Causante
    Inherits Persona

    Public Sub New(nombre As String, apellido As String, dni As Integer, domicilio As String, telefono As Integer, mail As String, fechaNac As Date)
        MyBase.New(nombre, apellido, dni, domicilio, telefono, mail, fechaNac)
    End Sub
End Class
