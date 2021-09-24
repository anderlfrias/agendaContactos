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
    public partial class frmAgenda : Form
    {
        N_Agenda objNegocio = new N_Agenda();
        E_Agenda objEntidad = new E_Agenda();
        FrmAgregarEditar aggCliente = new FrmAgregarEditar();
        public string filtro = "";
        public string tipoFiltro;
        public frmAgenda()
        {
            InitializeComponent();
        }
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedIndex = 0;
            tipoFiltro = cboFiltro.SelectedItem.ToString();
            mostrarfiltrarContactos(filtro, tipoFiltro);
            estilosTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarfiltrarContactos(string filterName, string filterType)
        {
            
            if(filterType == "NOMBRE")
            {
                dgvContactos.DataSource = objNegocio.filtrandoNombre(filterName);
            }
            else if (filterType == "APELLIDO")
            {
                dgvContactos.DataSource = objNegocio.filtrandoApellido(filterName);
            }
            else if(filterType == "TELEFONO")
            {
                dgvContactos.DataSource = objNegocio.filtrandoTelefono(filterName);
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoFiltro = cboFiltro.SelectedItem.ToString();
            txtFiltro.Focus();
            txtFiltro.Text = "Ingrese el "+tipoFiltro.ToLower();
            txtFiltro.ForeColor = Color.DimGray;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFiltro.Text == "Ingrese el " + tipoFiltro.ToLower())
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.DimGray;
            }
            filtro = txtFiltro.Text;
            mostrarfiltrarContactos(filtro, tipoFiltro);
        }

        private void estilosTabla()
        {
            dgvContactos.Columns[0].Visible = false;
            dgvContactos.Columns[1].Width = 70;
            dgvContactos.Columns[2].Width = 80;
            dgvContactos.Columns[3].Width = 80;
            dgvContactos.Columns[4].Width = 80;
            dgvContactos.Columns[5].Width = 80;

            dgvContactos.ClearSelection();
        }

        private void txtFiltro_OnValueChanged(object sender, EventArgs e)
        {

            if (txtFiltro.Text != "Ingrese el " + tipoFiltro.ToLower())
            {
                filtro = txtFiltro.Text;
                mostrarfiltrarContactos(filtro, tipoFiltro);
            }
        }

        private void eliminarContacto()
        {
            if(dgvContactos.SelectedRows.Count > 0)
            {
                objEntidad.Id_contacto = Convert.ToInt32(dgvContactos.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminandoContacto(objEntidad);

                mostrarfiltrarContactos("", tipoFiltro);

                MessageBox.Show("Registro eliminadoexcitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea eliminar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarContacto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            aggCliente.editarse = false;
            this.Visible = false;
            aggCliente.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count > 0)
            {
                aggCliente.id_contacto = Convert.ToInt32(dgvContactos.CurrentRow.Cells[0].Value.ToString());
                aggCliente.nombre= dgvContactos.CurrentRow.Cells[2].Value.ToString();
                aggCliente.apellido = dgvContactos.CurrentRow.Cells[3].Value.ToString();
                aggCliente.tel_movil = dgvContactos.CurrentRow.Cells[4].Value.ToString();
                aggCliente.tel_casa = dgvContactos.CurrentRow.Cells[5].Value.ToString();
                aggCliente.email = dgvContactos.CurrentRow.Cells[6].Value.ToString();
                aggCliente.direccion = dgvContactos.CurrentRow.Cells[7].Value.ToString();
                aggCliente.ciudad = dgvContactos.CurrentRow.Cells[8].Value.ToString();

                aggCliente.editarse = true;
                this.Visible = false;
                aggCliente.Show();
            }
            else
            {
                MessageBox.Show("Seleccione el contacto a editar");
            }
            
        }
    }
}
