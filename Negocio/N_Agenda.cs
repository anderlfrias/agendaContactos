using CapaDatos;
using CapaEntidades;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class N_Agenda
    {
        D_Agenda objDato = new D_Agenda();

        public void insertandoContacto(E_Agenda contacto)
        {
            objDato.insertarContacto(contacto);
        }

        public List<E_Agenda> filtrandoNombre(string nombre)
        {
            return objDato.filtrarNombre(nombre);
        }
        public List<E_Agenda> filtrandoApellido(string apellido)
        {
            return objDato.filtrarApellido(apellido);
        }
        public List<E_Agenda> filtrandoTelefono(string telefono)
        {
            return objDato.filtrarTelefono(telefono);
        }
        public void editandoContacto(E_Agenda contacto)
        {
            objDato.editarContacto(contacto);
        }
        public void eliminandoContacto(E_Agenda contacto)
        {
            objDato.eliminarContacto(contacto);
        }

    }
}