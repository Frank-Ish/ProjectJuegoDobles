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
    public partial class FrmJuegoDobles : Form
    {
        public tbJugadores jugador { get; set; }

        Button[,] boton = new Button[5, 5];
        string[] duplicados = new string[12];
        int cont = 0;
        int partidaPerdida = 7;

        private bool isCrear;


        public FrmJuegoDobles()
        {
            InitializeComponent();

        }


        private void FrmJuegoDobles_Load(object sender, EventArgs e)
        {
            string nombre = this.jugador.nombre;
            cargarBotones();
            MessageBox.Show("El jugador " + nombre + " ha iniciado la partida");
        }

        public void cargarBotones()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    boton[i, j] = new Button();
                    boton[i, j].BackColor = Color.White;
                    boton[i, j].Width = 100;
                    boton[i, j].Height = 80;
                    boton[i, j].Text = String.Format(" {0}, {1}", i, j);
                    boton[i, j].Top = i * 80;
                    boton[i, j].Left = j * 100;
                    boton[i,j].Click += new EventHandler(FrmJuegoDobles_MouseClick);
                    this.Controls.Add(boton[i, j]);
                }
            }
        }

        private void FrmJuegoDobles_MouseClick(object sender, EventArgs e)
        {
            string duplicado = "";
            
            string[,] data = new string[5, 5]
            {
                { "Frank", "Alex", "Minor", "Cristian", "Minor" },
                { "Brandon", "Daniel", "Marconi", "Marconi", "Michael" },
                { "Juan", "Alex", "Michael", "Juan", "Brandon" },
                { "Cristian", "Eliecer", "Natalia", "Frank", "Kevin" },
                { "Natalia", "Miguel", "Daniel", "Kevin", "Eliecer" }
            };


            int index = this.Controls.IndexOf((Control)sender);

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (boton[i, j].TabIndex == index)
                    {
                        boton[i, j].Text = data[i, j];
                        duplicado = boton[i, j].Text;
                        if (hasDuplicate(duplicado))
                       {
                           
                           duplicados[cont] = duplicado;
                           
                           MessageBox.Show("Ha encontrado un valor repedito.");
                            cont++;
                            if (cont == 12)
                            {
                                MessageBox.Show("Felicidades, has encontrado todos los nombres duplicados.");

                                break;
                            }
                            
                        }
                        else
                        {
                            partidaPerdida--;
                            if (partidaPerdida < 5){
                                MessageBox.Show("Ha perdido una vida, le quedan " + partidaPerdida);
                            }
                            
                            
                            if(partidaPerdida == 0)
                            {
                                MessageBox.Show("Lo sentimos, ha perdido la partida.");
                                break;
                            }
                        }
                        
                    }
                }
            }
        }

        bool hasDuplicate(string duplicado)
        {
            
            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (boton[i, j].Text.Equals(duplicado))
                    {
                        cont++;
                    }
                }
            }
            if(cont == 2)
            {
                return true;
            }
            return false;
        }

        private void guardarPartida()
        {
            /*Random rnd = new Random();
            partidas partida = new partidas();
            partida.idPartida = rnd.Next(1, 1000);*/

            
           
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
