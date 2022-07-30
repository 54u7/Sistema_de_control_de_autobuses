using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

namespace CapaDato
{
    public class DatoClass
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //CHOFERES

        //MOSTRAR Y BUSCAR DATOS
        public List<EntidadesClass>ListarDatosChoferes(string buscar)
        {
            SqlDataReader leerFilasChofer;
            SqlCommand cmd = new SqlCommand("sp_buscarChofer", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscarChofer", buscar);

            leerFilasChofer = cmd.ExecuteReader();

            List<EntidadesClass> ListarChofer = new List<EntidadesClass>();
            while (leerFilasChofer.Read())
            {
                ListarChofer.Add(new EntidadesClass
                {
                    Id = leerFilasChofer.GetInt32(0),
                    Nombre = leerFilasChofer.GetString(1),
                    Apellido = leerFilasChofer.GetString(2),
                    Nacimiento = leerFilasChofer.GetString(3),
                    Cedula = leerFilasChofer.GetString(4)
                });
            }
            conexion.Close();
            leerFilasChofer.Close();
            return ListarChofer;
        }

        //INSERTAR DATOS
        public void InsertarDatosChoferes(EntidadesClass dato)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarChofer", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@nombre", dato.Nombre);
            cmd.Parameters.AddWithValue("@apellido", dato.Apellido);
            cmd.Parameters.AddWithValue("@nacimiento", dato.Nacimiento);
            cmd.Parameters.AddWithValue("@cedula", dato.Cedula);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //ELIMINAR
        public void EliminarDatosChoferes(EntidadesClass dato)//categoria
        {
            SqlCommand cmd = new SqlCommand("sp_eliminarChofer", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", dato.Id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //AUTOBUSES 
        //MOSTRAR DATOS
        public List<EntidadAutobuses> ListarDatosAutobuses(string buscar)
        {
            SqlDataReader leerFilasAutobus;
            SqlCommand cmd = new SqlCommand("sp_buscarAutobus", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscarAutobus", buscar);

            leerFilasAutobus = cmd.ExecuteReader();

            List<EntidadAutobuses> ListarAutobus = new List<EntidadAutobuses>();
            while (leerFilasAutobus.Read())
            {
                ListarAutobus.Add(new EntidadAutobuses
                {
                    Id = leerFilasAutobus.GetInt32(0),
                    Marca = leerFilasAutobus.GetString(1),
                    Modelo = leerFilasAutobus.GetString(2),
                    Placa = leerFilasAutobus.GetString(3),
                    Color = leerFilasAutobus.GetString(4),
                    Año = leerFilasAutobus.GetString(5)
                });
            }
            conexion.Close();
            leerFilasAutobus.Close();
            return ListarAutobus;
        }

        //INSERTAR
        public void InsertarDatosAutobuses(EntidadAutobuses dato)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarAutobus", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@marca", dato.Marca);
            cmd.Parameters.AddWithValue("@modelo", dato.Modelo);
            cmd.Parameters.AddWithValue("@placa", dato.Placa);
            cmd.Parameters.AddWithValue("@color", dato.Color);
            cmd.Parameters.AddWithValue("@año", dato.Año);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        //ELIMINAR 
        public void EliminarDatosAutobuses(EntidadAutobuses dato)//categoria
        {
            SqlCommand cmd = new SqlCommand("sp_eliminarAutobus", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", dato.Id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //RUTAS
        //MOSTRAR DATOS

        public List<EntidadRutas> ListarDatosRutas(string buscar)
        {
            SqlDataReader leerFilasRutas;
            SqlCommand cmd = new SqlCommand("sp_buscarRutas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscarRutas", buscar);

            leerFilasRutas = cmd.ExecuteReader();

            List<EntidadRutas> ListarRutas = new List<EntidadRutas>();
            while (leerFilasRutas.Read())
            {
                ListarRutas.Add(new EntidadRutas
                {
                    Id = leerFilasRutas.GetInt32(0),
                    Rutas = leerFilasRutas.GetString(1),
                });
            }
            conexion.Close();
            leerFilasRutas.Close();
            return ListarRutas;
        }

        //INSERTAR

        public void InsertarDatosRutas(EntidadRutas dato)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarRutas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ruta", dato.Rutas);
            
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        //ELIMINAR
        public void EliminarDatosRuta(EntidadRutas dato)//categoria
        {
            SqlCommand cmd = new SqlCommand("sp_eliminarRuta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", dato.Id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //sp_buscarOcupado
        public List<EntidadOcupados>ListarDatosOcupado(string buscar)
        {
            SqlDataReader leerFilasRutas;
            SqlCommand cmd = new SqlCommand("sp_buscarOcupado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscarOcupado", buscar);

            leerFilasRutas = cmd.ExecuteReader();

            List<EntidadOcupados> ListarRutas = new List<EntidadOcupados>();
            while (leerFilasRutas.Read())
            {
                ListarRutas.Add(new EntidadOcupados
                {
                    Id = leerFilasRutas.GetInt32(0),
                    Nombre = leerFilasRutas.GetString(1),
                    Cedula = leerFilasRutas.GetString(2),
                    Marca = leerFilasRutas.GetString(3),
                    Placa = leerFilasRutas.GetString(4),
                    Ruta = leerFilasRutas.GetString(5)
                });
            }
            conexion.Close();
            leerFilasRutas.Close();
            return ListarRutas;
        }

        //

        public void InsertarDatosOcupado(EntidadOcupados dato)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarOcupado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@nombre", dato.Nombre);
            cmd.Parameters.AddWithValue("@cedula", dato.Cedula);
            cmd.Parameters.AddWithValue("@marca", dato.Marca);
            cmd.Parameters.AddWithValue("@placa", dato.Placa);
            cmd.Parameters.AddWithValue("@ruta", dato.Ruta);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }

}
