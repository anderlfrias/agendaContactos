using CapaEntidades;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class D_Agenda
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void insertarContacto(E_Agenda contacto)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", contacto.Apellido);
            cmd.Parameters.AddWithValue("@TEL_MOVIL", contacto.Tel_movil);
            cmd.Parameters.AddWithValue("@TEL_CASA", contacto.Tel_casa);
            cmd.Parameters.AddWithValue("@EMAIL", contacto.Email);
            cmd.Parameters.AddWithValue("@DIRECCION", contacto.Direccion);
            cmd.Parameters.AddWithValue("@CIUDAD", contacto.Ciudad);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<E_Agenda> filtrarNombre(string nombre)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_FILTRAR_NOMBRE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            LeerFilas = cmd.ExecuteReader();

            List<E_Agenda> Listar = new List<E_Agenda>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Agenda
                {
                    Id_contacto = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Tel_movil = LeerFilas.GetString(4),
                    Tel_casa = LeerFilas.GetString(5),
                    Email = LeerFilas.GetString(6),
                    Direccion = LeerFilas.GetString(7),
                    Ciudad = LeerFilas.GetString(8)
                });
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public List<E_Agenda> filtrarApellido(string apellido)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_FILTRAR_APELLIDO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@APELLIDO", apellido);
            LeerFilas = cmd.ExecuteReader();

            List<E_Agenda> Listar = new List<E_Agenda>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Agenda
                {
                    Id_contacto = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Tel_movil = LeerFilas.GetString(4),
                    Tel_casa = LeerFilas.GetString(5),
                    Email = LeerFilas.GetString(6),
                    Direccion = LeerFilas.GetString(7),
                    Ciudad = LeerFilas.GetString(8)
                });
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public List<E_Agenda> filtrarTelefono(string telefono)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_FILTRAR_TELEFONO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            LeerFilas = cmd.ExecuteReader();

            List<E_Agenda> Listar = new List<E_Agenda>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Agenda
                {
                    Id_contacto = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Tel_movil = LeerFilas.GetString(4),
                    Tel_casa = LeerFilas.GetString(5),
                    Email = LeerFilas.GetString(6),
                    Direccion = LeerFilas.GetString(7),
                    Ciudad = LeerFilas.GetString(8)
                });
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void editarContacto(E_Agenda contacto)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;  
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_CONTACTO", contacto.Id_contacto);
            cmd.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", contacto.Apellido);
            cmd.Parameters.AddWithValue("@TEL_MOVIL", contacto.Tel_movil);
            cmd.Parameters.AddWithValue("@TEL_CASA", contacto.Tel_casa);
            cmd.Parameters.AddWithValue("@EMAIL", contacto.Email);
            cmd.Parameters.AddWithValue("@DIRECCION", contacto.Direccion);
            cmd.Parameters.AddWithValue("@CIUDAD", contacto.Ciudad);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarContacto(E_Agenda contacto)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_CONTACTO", contacto.Id_contacto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}