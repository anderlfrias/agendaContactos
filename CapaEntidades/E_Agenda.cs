using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class E_Agenda
    {
        private int id_contacto;
        private string codigo;
        private string nombre;
        private string apellido;
        private string tel_movil;
        private string tel_casa;
        private string email;
        private string direccion;
        private string ciudad;

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tel_movil { get => tel_movil; set => tel_movil = value; }
        public string Tel_casa { get => tel_casa; set => tel_casa = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}