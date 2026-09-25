Imports Microsoft.Extensions.Diagnostics.HealthChecks
Public Class ClienteService
    Private ReadOnly repository As ClienteRepository
    Public Sub New(repository As ClienteRepository)
        Me.repository = repository
    End Sub

    Public Function Crear(cliente As Cliente) As Cliente
        repository.Registro(cliente)
        Return cliente
    End Function

    Public Function ObtenerTodos() As List(Of Cliente)
        Return repository.ObtenerTodos()
    End Function

    Public Function ObtenerPorId(id As Integer) As Cliente
        Return repository.ObtenerPorId(id)
    End Function

    Public Function Modificar(id As Integer, clienteModificado As Cliente) As Cliente
        Dim existente = repository.ObtenerPorId(id)
        If existente Is Nothing Then
            Return Nothing
        End If
        ' Establecer el Id y aplicar cambios (simple reemplazo aquí)
        clienteModificado.Id = id
        repository.Modificar(clienteModificado)
        Return clienteModificado
    End Function

    Public Function Eliminar(id As Integer) As Boolean
        Dim cliente = repository.ObtenerPorId(id)
        If cliente Is Nothing Then
            Return False
        End If
        repository.Eliminar(cliente)
        Return True
    End Function


End Class
