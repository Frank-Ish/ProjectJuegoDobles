using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectJuegoDoble
{
    public partial class FrmLogin : Form
    {
        JugadorBL jugadorInst = new JugadorBL();

        tbJugadores jugador = new tbJugadores();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lbNickN_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            //tbJugadores jugadorObtenido = new tbJugadores();

            jugador.nickname = txtNombre.Text;
            jugador.contrasena = txtPass.Text;
            jugador = jugadorInst.obtenerPorID(jugador);

            if (jugador != null)
            {
                FrmJuegoDobles frm = new FrmJuegoDobles();
                this.Close();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Lo sentimos, el jugador no ha sido encontrado, intentelo de nuevo.");
            }
        }
    }
}
