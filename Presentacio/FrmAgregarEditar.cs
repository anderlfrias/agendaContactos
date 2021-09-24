using CapaEntidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacio
{
    public partial class FrmAgregarEditar : Form
    {
        N_Agenda objNegocio = new N_Agenda();
        E_Agenda objEntidad = new E_Agenda();
        public bool editarse;

        public int id_contacto;
        public string codigo;
        public string nombre;
        public string apellido;
        public string tel_movil;
        public string tel_casa;
        public string email;
        public string direccion;
        public string ciudad;

        public FrmAgregarEditar()
        {
            InitializeComponent();
        }

        private void FrmAgregarEditar_Load(object sender, EventArgs e)
        {
            if(editarse == true)
            {
                mostrarDatosAEditar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void startWriting(string text)
        {
            if(text == "Nombre")
            {
                lblNombre.Visible = true;
                txtNombre.Text = "";
            }
            else if (text == "Apellido")
            {
                lblApellido.Visible = true;
                txtApellido.Text = "";
            }
            else if(text == "Tel. Movil")
            {
                lblMovil.Visible = true;
                txtMovil.Text = "";
            }
            else if(text == "Tel. Casa")
            {
                lblCasa.Visible = true;
                txtCasa.Text = "";
            }
            else if(text == "Correo Electronico")
            {
                lblEmail.Visible = true;
                txtEmail.Text = "";
            }
            else if(text == "Ciudad")
            {
                lblCiudad.Visible = true;
                txtCiudad.Text = "";
            }
            else if(text == "Direccion")
            {
                lblCiudad.Visible = true;
                txtCiudad.Text = "";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtNombre.Text);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtApellido.Text);
        }

        private void txtMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtMovil.Text);
        }

        private void txtCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtCasa.Text);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtEmail.Text);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtCiudad.Text);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            startWriting(txtDireccion.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificacionDatos())
            {
                if(editarse)
                {
                    editarContacto();
                }
                else
                {
                    guardarContactoNuevo();
                }

                cerrar();
            }
            else
            {
                MessageBox.Show("Asegurese de completar todos los campos");
            }
            
        }

        private void guardarContactoNuevo()
        {
                try
                {               
                    objEntidad.Nombre = txtNombre.Text.ToUpper();
                    objEntidad.Apellido = txtApellido.Text.ToUpper();
                    objEntidad.Tel_movil = txtMovil.Text.ToUpper();
                    objEntidad.Tel_casa = txtCasa.Text.ToUpper();
                    objEntidad.Email = txtEmail.Text.ToUpper();
                    objEntidad.Direccion = txtDireccion.Text.ToUpper();
                    objEntidad.Ciudad = txtCiudad.Text.ToUpper();

                    objNegocio.insertandoContacto(objEntidad);

                    MessageBox.Show("Contacto guardado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar guardar contacto"+ex);
                }
            
        }

        private void mostrarDatosAEditar()
        {
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtMovil.Text = tel_movil;
            txtCasa.Text = tel_casa;
            txtEmail.Text = email;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;

            lblNombre.Visible = true;
            lblApellido.Visible = true;
            lblMovil.Visible = true;
            lblCasa.Visible = true;
            lblEmail.Visible = true;
            lblDireccion.Visible = true;
            lblCiudad.Visible = true;
        }

        private void editarContacto()
        {
            try
            {
                objEntidad.Id_contacto = id_contacto;
                objEntidad.Nombre = txtNombre.Text.ToUpper();
                objEntidad.Apellido = txtApellido.Text.ToUpper();
                objEntidad.Tel_movil = txtMovil.Text;
                objEntidad.Tel_casa = txtCasa.Text;
                objEntidad.Email = txtEmail.Text.ToUpper();
                objEntidad.Direccion = txtDireccion.Text.ToUpper();
                objEntidad.Ciudad = txtCiudad.Text.ToUpper();

                objNegocio.editandoContacto(objEntidad);

                MessageBox.Show("Contacto editado exitosamente");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al intentar editar contacto" + ex);
            }
        }

        /*Este metodo me verifica los datos ingresados por el usuario
        Me verifica que cada TextBox tenga informacion diferente a que 
        tiene por default*/
        private bool verificacionDatos()
        {
            bool validar = true;
            if((txtNombre.Text == "Nombre") ||(txtNombre.Text == ""))
            {
                lblNombre.Text += " *Campo requerido";
                lblNombre.ForeColor = Color.Red;
                lblNombre.Visible = true;
                txtNombre.Text = "";
                txtNombre.Focus();
                validar = false;
            }
            else
            {
                lblNombre.Text = "Nombre:";
                lblNombre.ForeColor = Color.DimGray;
            } 
            
            if((txtApellido.Text == "Apellido") || (txtApellido.Text == ""))
            {
                lblApellido.Text += " *Campo requerido";
                lblApellido.ForeColor = Color.Red;
                lblApellido.Visible = true;
                txtApellido.Text = "";
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblApellido.Text = "Apellido:";
                lblApellido.ForeColor = Color.DimGray;
            }
            
            if ((txtMovil.Text == "Tel. Movil") || (txtMovil.Text == ""))
            {
                lblMovil.Text += " *Campo requerido";
                lblMovil.ForeColor = Color.Red;
                lblMovil.Visible = true;
                txtMovil.Text = "";
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblMovil.Text = " Tel. Movil: ";
                lblMovil.ForeColor = Color.DimGray;
            }
            
            if ((txtCasa.Text == "Tel. Casa") || (txtCasa.Text == ""))
            {
                lblCasa.Text += " *Campo requerido";
                lblCasa.ForeColor = Color.Red;
                lblCasa.Visible = true;
                txtCasa.Text = "";
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblCasa.Text = "Tel. Casa:";
                lblCasa.ForeColor = Color.DimGray;
            }
            
            if ((txtEmail.Text == "Correo Electronico") || (txtEmail.Text == ""))
            {
                lblEmail.Text += " *Campo requerido";
                lblEmail.ForeColor = Color.Red;
                lblEmail.Visible = true;
                txtEmail.Text = ""; 
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblEmail.Text = "Correo Electronico:";
                lblEmail.ForeColor = Color.DimGray;
            }
            
            if ((txtDireccion.Text == "Direccion") || (txtDireccion.Text == ""))
            {
                lblDireccion.Text += " *Campo requerido";
                lblDireccion.ForeColor = Color.Red;
                lblDireccion.Visible = true;
                txtDireccion.Text = ""; 
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblDireccion.Text = "Direccion:";
                lblDireccion.ForeColor = Color.DimGray;
            }
            
            if ((txtCiudad.Text == "Cuidad") || (txtCiudad.Text == ""))
            {
                lblCiudad.Text += " *Campo requerido";
                lblCiudad.ForeColor = Color.Red;
                lblCiudad.Visible = true;
                txtCiudad.Text = "";
                if (validar)
                {
                    txtCiudad.Focus();
                }
                validar = false;
            }
            else
            {
                lblCiudad.Text = "Ciudad:";
                lblCiudad.ForeColor = Color.DimGray;
            }

            return validar;
        }

        private void cerrar()
        {
            frmAgenda agenda = new frmAgenda();
            agenda.Visible = true;
            this.Visible = false;
        }


    }
}
