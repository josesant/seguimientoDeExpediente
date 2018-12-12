Public Class Persona
    Private nombre As String
    Private apellido As String
    Dim dni As Integer
    Private domicilio As String
    Private telefono As String
    Private mail As String
    Private fechaNac As Date

    Public Sub New(nombre As String, apellido As String, dni As Integer, domicilio As String, telefono As Integer, mail As String, fechaNac As Date)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.dni = dni
        Me.domicilio = domicilio
        Me.telefono = telefono
        Me.mail = mail
    End Sub


    Public Property NewProperty() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            mail = value
        End Set
    End Property

    Public Property ptelefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

    Public Property pnombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property


    Public Property papellido() As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property

    Public Property pdni() As Integer
        Get
            Return dni
        End Get
        Set(ByVal value As Integer)
            dni = value
        End Set
    End Property


    Public Property pdomicilio() As String
        Get
            Return domicilio
        End Get
        Set(ByVal value As String)
            domicilio = value
        End Set
    End Property


    Public Property pfechaNac() As Date
        Get
            Return fechaNac
        End Get
        Set(ByVal value As Date)
            fechaNac = value
        End Set
    End Property


End Class