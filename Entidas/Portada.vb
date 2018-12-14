Public Class Portada
    Dim NroExpediente As Integer
    Dim Asunto As Asuntos
    Dim Titulo As String
    Dim NombreSoli As String
    Dim Fecha As Date

    Public Sub New(nroexpediente As Integer, asunto As Asuntos, titulo As String, nombresoli As String, fecha As Date)
        Me.NroExpediente = nroexpediente
        Me.Asunto = asunto
        Me.Titulo = titulo
        Me.NombreSoli = nombresoli
        Me.Fecha = fecha
    End Sub

    Public Property pnroExpediente() As Integer
        Get
            Return Me.NroExpediente
        End Get
        Set(ByVal value As Integer)
            Me.NroExpediente = value
        End Set
    End Property

    Public Property pAsunto() As Asuntos
        Get
            Return Me.Asunto
        End Get
        Set(ByVal value As Asuntos)
            Me.Asunto = value
        End Set
    End Property
    Public Property ptitulo() As String
        Get
            Return Me.Titulo
        End Get
        Set(ByVal value As String)
            Me.Titulo = value
        End Set
    End Property
    Public Property pNombreSoli() As String
        Get
            Return Me.NombreSoli
        End Get
        Set(ByVal value As String)
            Me.NombreSoli = value
        End Set
    End Property
    Public Property pfecha() As Date
        Get
            Return Me.Fecha
        End Get
        Set(ByVal value As Date)
            Me.Fecha = value
        End Set
    End Property
End Class