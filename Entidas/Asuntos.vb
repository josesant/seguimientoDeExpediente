Public Class Asuntos
    Dim Codigo As Integer
    Dim Descripcion As String
    Dim tope As Integer
    Dim flujo() As Oficinas


    Public Sub New(codigo As Integer, descrp As String)
        Me.Codigo = codigo
        Me.Descripcion = descrp
        Me.tope = 0
    End Sub

    Public Property pDescrp() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
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

    Public Property ptope() As Integer
        Get
            Return tope
        End Get
        Set(ByVal value As Integer)
            Me.tope = value
        End Set
    End Property

    Public Sub agregarOficina(oficina As Oficinas)
        flujo(tope) = oficina
        ReDim Preserve flujo(tope + 1)
    End Sub

    Function getPosicionActual(oficina As Oficinas) As Integer
        For i = 0 To tope
            If (flujo(i).Equals(oficina)) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Function getSiguienteOficina(ultima As Oficinas) As Oficinas
        For i = 0 To tope
            If (flujo(i).Equals(ultima)) Then
                Return flujo(i + 1)
            End If
        Next
        Return Nothing
    End Function


End Class
