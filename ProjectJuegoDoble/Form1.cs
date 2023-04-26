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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            dtgv1.Location = new System.Drawing.Point(10, 10);
            dtgv1.Size = new System.Drawing.Size(540, 200);
          

            this.Controls.Add(dtgv1);

            string[,] data = new string[5, 5]
            {
                { "A1", "B1", "C1", "D1", "E1" },
                { "A2", "B2", "C2", "D2", "E2" },
                { "A3", "B3", "C3", "D3", "E3" },
                { "A4", "B4", "C4", "D4", "E4" },
                { "A5", "B5", "C5", "D5", "E5" }
            };

            dtgv1.ColumnCount = data.GetLength(1);


            for (int i = 0; i < data.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = data[i, j];

                    row.Cells.Add(cell);
                }
                dtgv1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Button button1 = new Button();
            Controls.Add(button1);
            button1.Text = "hola";

            string[,] data = new string[5, 5]
            {
                { "Frank", "Alex", "Minor", "Cristian", "Minor" },
                { "Brandon", "Daniel", "Marconi", "Marconi", "Michael" },
                { "Juan", "Alex", "Michael", "Juan", "Brandon" },
                { "Cristian", "Eliecer", "Natalia", "Frank", "Kevin" },
                { "Natalia", "Minor", "Daniel", "Kevin", "Eliecer" }
            };


            object valor = dtgv1.CurrentCell.Value;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (dtgv1.Rows[i].Cells[j].Value == valor)
                    {
                        button1.Text = data[i,j];

                        dtgv1.CurrentCell.Value = button1.Text;
                    }
                }
            }
        }
    }
}
