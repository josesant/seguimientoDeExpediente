Public Class Oficinas
    Dim Nro As Integer
    Dim OficinaNombre As String
    Dim Admin As Boolean

    Public Sub New(nro As Integer, OficinaNombre As String, Admin As Boolean)
        Me.Nro = nro
        Me.OficinaNombre = OficinaNombre
        Me.Admin = False
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

    Public Property pAdmin() As String
        Get
            Return Admin
        End Get
        Set(ByVal value As String)
            Admin = value
        End Set
    End Property



End Class
