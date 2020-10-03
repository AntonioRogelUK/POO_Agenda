using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda;

        public Form1()
        {
            InitializeComponent();

            agenda = new Agenda();

            lblContactos.Text = "0 contactos";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto(txtNombre.Text, txtCelular.Text, 
                    txtParticular.Text, txtEmail.Text);

                agenda.AgregarContacto(contacto);

                CargarGrid(agenda.PropiedadContactos);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }

        private void CargarGrid(List<Contacto> contactos) 
        {
            try
            {
                dgvContactos.DataSource = null;
                dgvContactos.DataSource = contactos;
                lblContactos.Text = $"{contactos.Count} contactos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContactos.Rows.Count > 0) 
                {
                    int renglon = dgvContactos.CurrentRow.Index;
                    Contacto contactoEliminar = agenda.PropiedadContactos[renglon];
                    agenda.EliminarContacto(contactoEliminar);
                    CargarGrid(agenda.PropiedadContactos);
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Contacto> contactosBusqueda = new List<Contacto>();
                foreach(Contacto contacto in agenda.PropiedadContactos) 
                {
                    if (contacto.PropiedadNombre.IndexOf(txtBuscar.Text) > -1) 
                    {
                        contactosBusqueda.Add(contacto);
                    }
                }
                CargarGrid(contactosBusqueda);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }
    }
}
