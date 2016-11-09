
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.


    'Private string_conexion As String = "Data Source=maquis;Initial Catalog=pav_tp;User ID=avisuales1;Password=avisuales1"
    'Private string_conexion As String = "Data Source=.\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True"
    Private string_conexion As String = "Data Source= EQUIPO-PC\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True"


    Private Shared instance As BDHelper 'Unica instancia de la clase

    'Private string_conexion As String = ConfigurationManager.ConnectionStrings("TPI").ConnectionString

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
        Dim strSQL As String = "Select id_barrio, nombre from Barrio"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)

    End Function

    Shared Function GetEspecialidades() As DataTable
        Dim strSQL As String = "SELECT id_especialidad, nombre FROM Especialidad"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function GetTipoAfiliado() As DataTable
        Dim strSQL As String = "Select id_tipoAfiliado, nombre from TipoAfiliado"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)

    End Function

    Shared Function GetTipoDoc() As DataTable
        Dim strSQL As String = "Select id_tipoDoc, nombre from TipoDoc"
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)

    End Function

    Shared Function GetPerfiles() As DataTable
        Dim strSQL As String = "Select * from Perfil"
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

    Public Shared Function insertar(ByVal nro_atencion As String, ByVal fecha As String, ByVal nro_centro As String, ByVal tipo_doc As Integer, ByVal nro_doc As String, matricula As String, especialidad As Integer, detalles As List(Of DetalleAtencionMedica))

        Dim tabla As New DataTable
        Dim query As String = "INSERT INTO AtencionMedica (fecha_atencion,nro_atencion, id_tipoDocAfiliado, nro_docAfiliado, id_especialidad, nro_centroMedico,matricula) VALUES( '" + fecha + "'"
        query += "," + nro_atencion
        query += ", " + tipo_doc.ToString()
        query += "," + nro_doc
        query += ", " + especialidad.ToString()
        query += ", " + nro_centro
        query += ", " + matricula + ");"

        For Each detalle As DetalleAtencionMedica In detalles
            query += "INSERT INTO DetalleAtencionMedica (fecha_atencion,nro_atencion,nro_centroMedico, id_practica, porc_descuento, precio) VALUES( '" + fecha + "'"
            query += "," + nro_atencion
            query += "," + nro_centro
            query += "," + detalle.id_practica.ToString()
            query += "," + detalle.porc_descuento.ToString()
            query += "," + detalle.precio_practica.ToString() + ");"
        Next

        Return BDHelper.getDBHelper.EjecutarTransaction(query) > 0
    End Function

    Public Shared Function GetPracticasxEspecialidad(ByVal id_especialidad As Integer) As DataTable
        Dim strSQL As String = "SELECT id_practica, nombre FROM Practica WHERE id_especialidad = " + id_especialidad.ToString
        Return BDHelper.getDBHelper.ConsultaSQL(strSQL)
    End Function
    Public Function EjecutarTransaction(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction = Nothing
        Dim status As Integer = 0
        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            trans = conexion.BeginTransaction()
            With cmd
                .Connection = conexion
                .CommandType = CommandType.Text
                ' Establece la instrucción a ejecutar
                .Transaction = trans
                .CommandText = strSql
                ' Retorna el resultado de ejecutar el comando
                status = .ExecuteNonQuery()
            End With
            trans.Commit()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function insert_atencionMedica_commands(ByVal fecha As String, ByVal nro_centro As String, ByVal tipo_doc As Integer, ByVal nro_doc As String, matricula As String, especialidad As Integer, detalles As List(Of DetalleAtencionMedica)) As Boolean
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction = Nothing
        Dim status As Integer = 0

        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()
            'Seteamos propiedades comunes de los comandos
            trans = conexion.BeginTransaction()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans

            'Isertamos DATOS cabecera de la Atencion
            cmd.CommandText = "INSERT INTO AtencionMedica (fechaAtencion,id_tipoDocAfiliado, nro_docAfiliado, id_especialidad, nro_centroMedico,matricula) VALUES( '" + fecha + "'" + ", " + tipo_doc.ToString() + "," + nro_doc + ", " + especialidad.ToString() + ", " + nro_centro + ", " + matricula + ");"

            cmd.ExecuteNonQuery()

            'Insertamos DATOS por cada detalle de Atencion
            For Each detalle As DetalleAtencionMedica In detalles
                cmd.CommandText = "INSERT INTO DetalleAtencionMedica (fechaAtencion, ordinal, id_practica, porc_descuento, precio) VALUES( '" + fecha + "'" + "," + "@nro_Atencion" + "," + detalle.id_practica.ToString() + "," + detalle.porc_descuento.ToString() + "," + detalle.precio_practica.ToString() + ");"
                cmd.ExecuteNonQuery()
            Next
            status = 1
            trans.Commit()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status

    End Function

    Function generarReporte(ByVal fecDesde As String, ByVal fecHasta As String) As DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT c.denominacion, e.nombre, COUNT(am.nro_centroMedico) " & _
            "FROM AtencionMedica am, CentroMedico c, Especialidad e " & _
            "WHERE(am.nro_centroMedico = c.nro_centroMedico And am.id_especialidad = e.id_especialidad) " & _
            "AND (am.fecha_atencion >='" + Convert.ToDateTime(fecDesde).ToString("dd/MM/yyyy") + "' " & _
            "AND am.fecha_atencion <='" + Convert.ToDateTime(fecHasta).ToString("dd/MM/yyyy") + "') " & _
            "GROUP BY c.denominacion, e.nombre "

            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

        Return tabla
    End Function

    Function generarListado_AtencionesCentro(pctro_medico As String) As Object
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT am.fecha_atencion,a.apellido + ', ' + a.nombre as afiliado, p.apellido + ', ' + p.nombre as profesional, e.nombre " & _
            "FROM AtencionMedica am JOIN Afiliado a ON (am.id_tipoDocAfiliado=a.id_tipoDoc AND am.nro_docAfiliado=a.nro_doc) " & _
            "JOIN Profesional p ON (am.matricula=p.matricula) " & _
            "JOIN Especialidad e ON (am.id_especialidad=e.id_especialidad) " & _
            "JOIN CentroMedico c ON(am.nro_centroMedico = c.nro_centroMedico)" & _
            "WHERE c.denominacion = '" & pctro_medico & "'"

            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

        Return tabla
    End Function

End Class