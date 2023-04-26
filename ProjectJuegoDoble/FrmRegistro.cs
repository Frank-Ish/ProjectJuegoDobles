using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectJuegoDoble
{
    public partial class FrmRegistro : Form
    {

        JugadorBL judadorInst = new JugadorBL();

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar())
                {
                    MessageBox.Show("El cliente se guardo correctamente.");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private bool guardar()
        {
            if (validar())
            {
                tbJugadores jugador = new tbJugadores();
                jugador.cedula = mskCedula.Text;
                jugador.nombre = txtNombre.Text;
                jugador.nickname = txtNickN.Text;
                jugador.fechaIngreso = dtFechaNac.Value;
                jugador.contrasena = txtPass.Text;
               

                judadorInst.guardar(jugador);

                return true;
            }
            else
            {
                MessageBox.Show("No se guardo, verifique los datos.");
                return false;
            }
        }

        private bool validar()
        {

            if (mskCedula.Text == String.Empty)
            {
                MessageBox.Show("Falta la cedula.");
                return false;
            }
            else if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Falta el nombre.");
                return false;
            }
            else if (txtNickN.Text == String.Empty)
            {
                MessageBox.Show("Falta el primer apellido.");
                return false;
            }
            else if (txtPass.Text == String.Empty)
            {
                MessageBox.Show("Falta el segundo apellido.");
                return false;
            }

            //todas las validaciones estan bien
            return true;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
