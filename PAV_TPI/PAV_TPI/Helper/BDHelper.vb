Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String = "Data Source=AGUSTINA-PC;Integrated Security=True;Initial Catalog=DB_ObraSocial"
    'Private string_conexion As String = ConfigurationManager.ConnectionStrings("DB_ObraSocial").ConfigurationString
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            Return cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Shared Function GetBarrios() As DataTable
        Dim strSQL As String = "SELECT id_barrio, nombre FROM Barrio"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetEspecialidades() As DataTable
        Dim strSQL As String = "SELECT id_especialidad, nombre FROM Especialidad"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetTipoAfiliado() As DataTable
        Dim strSQL As String = "SELECT id_tipoAfiliado, nombre FROMm TipoAfiliado"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetTipoDoc() As DataTable
        Dim strSQL As String = "SELECT id_tipoDoc, nombre FROM TipoDoc"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetPerfiles() As DataTable
        Dim strSQL As String = "SELECT * FROM Perfil"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetCentroMedico(ByVal numero As String) As CentroMedico
        ' Funcion que recibe como parametro un numero de centro medico y retorna un Centro Medico
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim centroMedico As CentroMedico = New CentroMedico()

        Try
            conexion.ConnectionString = BDHelper.getDBHelper.string_conexion
            conexion.Open()
            cmd.Connection = conexion
            ' consulta sql recibe como parametro el numero de centro Medico 

            cmd = New SqlCommand("SELECT nro_centroMedico, denominacion, calle, numero, id_barrio, telefono, mail FROM CentroMedico WHERE nro_CentroMedico = @numero", conexion)
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero

            ' El resultado de la consulta se guarda en un objeto SqlDataReader

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            ' Mientras el SqlDataReader tenga datos
            If (reader.Read()) Then
                centroMedico.nro_centroMedico = reader.Item("nro_centroMedico")
                centroMedico.denominacion = reader.Item("denominacion")
                centroMedico.calle = reader.Item("calle")
                centroMedico.numero = reader.Item("numero")
                centroMedico.id_barrio = reader.Item("id_barrio")
                centroMedico.telefono = reader.Item("telefono")
                centroMedico.mail = reader.Item("mail")
                'centroMedico.fecha_baja = Convert.ToDateTime(reader.Item("fecha_baja"))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        'Retorna el centroMedico
        Return centroMedico

    End Function

    Sub insertar(ByRef oCentroMedico As CentroMedico)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()

            ' En la sentencia los @indican parámetros
            cmd = New SqlCommand("INSERT INTO centroMedico(nro_centroMedico,denominacion,calle,numero, id_barrio,telefono, mail )" + _
                                 " VALUES ( @nro_centroMedico , @denominacion, @calle, @numero , @id_barrio, @telefono, @mail )", conexion)
            cmd.Connection = conexion
            ' Se castea o convierte cada parámetro al tipo de dato requerido por la base de datos
            ' Se asigna a cada parámetro el valor de legajo, id de materia, fecha y nota
            cmd.Parameters.Add("@nro_centroMedico", SqlDbType.Int).Value = oCentroMedico.nro_centroMedico
            cmd.Parameters.Add("@denominacion", SqlDbType.NVarChar).Value = oCentroMedico.denominacion
            cmd.Parameters.Add("@calle", SqlDbType.NVarChar).Value = oCentroMedico.calle
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = oCentroMedico.numero
            cmd.Parameters.Add("@id_barrio", SqlDbType.VarChar).Value = oCentroMedico.id_barrio
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = oCentroMedico.telefono
            cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = oCentroMedico.mail
            'Ejecuta la consulta insert con los parámetros ya con los valores adecuados
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Shared Function GetPracticas() As DataTable
        Dim strSQL As String = "Select id_practica, nombre from Practica"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

End Class
