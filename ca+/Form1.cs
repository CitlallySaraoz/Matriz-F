using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ca_
{
    public partial class Form1 : Form
    {

        int[,] MatrizA = new int[100,100];
        int[,] MatrizB = new int[100, 100];
        int[,] MatrizResult = new int[100, 100];
        int[,] MatrizSuma = new int[100, 100];
        

        int i, j, Filas, Columnas;

        private void btnCargar_Click(object sender, EventArgs e)
        {

            Insertar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Sumar();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Resar();+
        }

        private void Insertar()
        {
            Filas = Convert.ToInt32(txtFilas.Text);
            Columnas = Convert.ToInt32(txtColumnas.Text);




            dgvMA.RowCount = Filas;
            dgvMA.ColumnCount = Columnas;

            dgvMB.RowCount = Filas;
            dgvMB.ColumnCount = Columnas;




            


            //MessageBox.Show("Datos De matriz B insertados");
           

        }

        private void Sumar()
        {

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();

            dgvResultado.RowCount = Filas;
            dgvResultado.ColumnCount = Columnas;

            for (i = 0; i < Filas; i++)
            {
                for (j = 0; j < Columnas; j++)
                {
                    MatrizA[i, j] = Convert.ToInt32(dgvMA.Rows[i].Cells[j].Value);
                    MatrizB[i, j] = Convert.ToInt32(dgvMB.Rows[i].Cells[j].Value);

                }
            }

            

            


            for (i = 0; i < Filas; i++)
            {
                for (j = 0; j < Columnas; j++)
                {

                    MatrizSuma[i, j] = MatrizA[i, j] + MatrizB[i, j];

                    dgvResultado.Rows[i].Cells[j].Value = MatrizSuma[i, j];

                }
            }
        }


        private void Resar()
        {

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();

            dgvResultado.RowCount = Filas;
            dgvResultado.ColumnCount = Columnas;

            for (i = 0; i < Filas; i++)
            {
                for (j = 0; j < Columnas; j++)
                {
                    MatrizA[i, j] = Convert.ToInt32(dgvMA.Rows[i].Cells[j].Value);
                    MatrizB[i, j] = Convert.ToInt32(dgvMB.Rows[i].Cells[j].Value);

                }
            }






            for (i = 0; i < Filas; i++)
            {
                for (j = 0; j < Columnas; j++)
                {

                    MatrizSuma[i, j] = MatrizA[i, j] - MatrizB[i, j];

                    dgvResultado.Rows[i].Cells[j].Value = MatrizSuma[i, j];

                }
            }
        }




    }
}
