Public Class MesadeEntrada
    Inherits Oficinas
    Public Sub New(nro As Integer, OficinaNombre As String, ubicacion As String, Admin As Boolean)
        MyBase.New(nro, OficinaNombre, ubicacion, Admin)
    End Sub

    Function iniciar(solicitante As Causante, empleado As Empleado, portada As Portada) As Expediente
        Dim exp As New Expediente(solicitante, empleado, portada)
        Return exp
    End Function

    Public Sub archivar(expediente As Expediente, estado As Boolean)
        expediente.pencurso = False
        If (estado = True) Then
            expediente.pestado = True
        Else
            expediente.pestado = False
        End If

    End Sub
End Class