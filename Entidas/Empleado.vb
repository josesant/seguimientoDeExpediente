
Public Class Empleado

    Inherits Persona

    Dim nroLegajo As Integer
    Dim oficina As Oficinas

    Public Sub New(nombre As String, apellido As String, dni As Integer, domicilio As String, telefono As Integer, mail As String, fechaNac As Date, nroLegajo As Integer, oficina As Oficinas)
        MyBase.New(nombre, apellido, dni, domicilio, telefono, mail, fechaNac)
        Me.nroLegajo = nroLegajo
        Me.oficina = oficina
    End Sub


    Public Property pnroLegajo() As Integer
        Get
            Return nroLegajo
        End Get
        Set(ByVal value As Integer)
            nroLegajo = value
        End Set
    End Property

End Class

