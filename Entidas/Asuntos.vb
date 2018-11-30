Public Class Asuntos
    Dim Codigo As Integer
    Dim Descrp As String


    Public Sub New(codigo As Integer, descrp As String)
        Me.Codigo = codigo
        Me.Descrp = descrp
    End Sub

    Public Property pDescrp() As String
        Get
            Return Descrp
        End Get
        Set(ByVal value As String)
            Descrp = value
        End Set
    End Property


    Public Property pCodigo() As String
        Get
            Return Codigo
        End Get
        Set(ByVal value As String)
            Codigo = value
        End Set
    End Property


End Class
