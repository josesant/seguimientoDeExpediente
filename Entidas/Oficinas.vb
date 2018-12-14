Public Class Oficinas
    Dim Nro As Integer
    Dim OficinaNombre As String
    Dim ubicacion As String
    Dim Admin As Boolean
    Dim empleados() As Empleado
    Dim tope As Integer

    Public Sub New(nro As Integer, OficinaNombre As String, ubicacion As String, Admin As Boolean)
        Me.Nro = nro
        Me.OficinaNombre = OficinaNombre
        Me.ubicacion = ubicacion
        Me.Admin = False
        Me.tope = 0
    End Sub

    Public Property pNro() As Integer
        Get
            Return Nro
        End Get
        Set(ByVal value As Integer)
            Nro = value
        End Set
    End Property

    Public Property pOficinaNombre() As String
        Get
            Return OficinaNombre
        End Get
        Set(ByVal value As String)
            OficinaNombre = value
        End Set
    End Property
    Public Property pubicacion() As String
        Get
            Return Me.ubicacion
        End Get
        Set(ByVal value As String)
            Me.ubicacion = value
        End Set
    End Property
    Public Property pAdmin() As String
        Get
            Return Admin
        End Get
        Set(ByVal value As String)
            Admin = value
        End Set
    End Property

    Public Sub agregarFoja(numero As Integer, descripcion As String, empleado As Empleado, exp As Expediente)

        Dim foja As New Fojas(numero, descripcion, Me, empleado)
        exp.agregarFoja(foja)
    End Sub

    Function derivar(Expediente As Expediente) As Oficinas
        Return Expediente.continuarFlujo(Me)
    End Function

    Public Sub agregarEmpleado(empleado As Empleado)
        empleados(tope) = empleado
        ReDim Preserve empleados(tope + 1)
    End Sub

End Class
