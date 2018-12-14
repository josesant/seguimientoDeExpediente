Public Class Fojas
    Dim numero As Integer
    Dim descripcion As String
    Dim oficina As Oficinas
    Dim empleado As Empleado

    Public Sub New(numero As Integer, descripcion As String, oficina As Oficinas, empleado As Empleado)
        Me.numero = numero
        Me.descripcion = descripcion
        Me.oficina = oficina
        Me.empleado = empleado
    End Sub

    Public Property pnumero() As Integer
        Get
            Return Me.numero
        End Get
        Set(ByVal value As Integer)
            Me.numero = value
        End Set
    End Property

    Public Property pdescripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(ByVal value As String)
            Me.descripcion = value
        End Set
    End Property

    Public Property poficina() As Oficinas
        Get
            Return Me.oficina
        End Get
        Set(ByVal value As Oficinas)
            Me.oficina = value
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
End Class
