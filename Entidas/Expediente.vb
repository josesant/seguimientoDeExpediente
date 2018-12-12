Public Class Expediente
    Dim enCurso As Boolean
    Dim solicitante As Causante
    Dim empleado As Empleado
    Dim portada As Portada
    Dim estado As Boolean
    Dim fojas() As Fojas
    Dim tope As Integer

    Public Sub New(solicitante As Causante, empleado As Empleado, portada As Portada)
        Me.solicitante = solicitante
        Me.empleado = empleado
        Me.portada = portada
        Me.enCurso = True
        Me.estado = False
        Me.tope = 0
    End Sub

    Public Property ptope() As Integer
        Get
            Return Me.tope
        End Get
        Set(ByVal value As Integer)
            Me.tope = value
        End Set
    End Property

    Public Property pestado() As Boolean
        Get
            Return Me.estado
        End Get
        Set(ByVal value As Boolean)
            Me.estado = value
        End Set
    End Property

    Public Property pportada() As Portada
        Get
            Return Me.portada
        End Get
        Set(ByVal value As Portada)
            Me.portada = value
        End Set
    End Property

    Public Property psolicitante() As Causante
        Get
            Return Me.solicitante
        End Get
        Set(ByVal value As Causante)
            Me.solicitante = value
        End Set
    End Property
    Public Property pempleado() As Empleado
        Get
            Return Me.empleado
        End Get
        Set(ByVal value As Empleado)
            Me.empleado = value
        End Set
    End Property

    Public Property pencurso() As Boolean
        Get
            Return Me.enCurso
        End Get
        Set(ByVal value As Boolean)
            Me.enCurso = value
        End Set
    End Property

    Public Sub agregarFoja(foja As Fojas)
        fojas(tope) = foja
        ReDim Preserve fojas(tope + 1)
    End Sub

    Function continuarFlujo(ultima As Oficinas) As Oficinas
        Return Me.portada.pAsunto.getSiguienteOficina(ultima)
    End Function

    Function getUltimaOficina() As Oficinas
        Return Me.fojas(tope).poficina
    End Function
End Class
