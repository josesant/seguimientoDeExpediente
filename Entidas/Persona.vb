Public Class Persona

    Private mail As String
    Public Property NewProperty() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            mail = value
        End Set
    End Property


    Private telefono As String
    Public Property ptelefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property
    Private nombre As String
    Public Property pnombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Private apellido As String
    Public Property papellido() As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property

    Private dni As String
    Public Property pdni() As Integer
        Get
            Return dni
        End Get
        Set(ByVal value As Integer)
            dni = value
        End Set
    End Property

    Private domicilio As String
    Public Property pdomicilio() As String
        Get
            Return domicilio
        End Get
        Set(ByVal value As String)
            domicilio = value
        End Set
    End Property


End Class
