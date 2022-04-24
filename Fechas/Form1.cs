using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fechas
{
    public partial class Form1 : Form
    {

        int dias;

        int meses;

        int año;

        public Form1()
        {
            InitializeComponent();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {

            dias = int.Parse(txtDia.Text);

            meses = int.Parse(txtMes.Text);

            año = int.Parse(txtAño.Text);

            if (dias>=1 && dias<=31)
            {
                lblResultado.Text = "";
            }
            else
            {

                MessageBox.Show("ingrese un dia valido dentro del rango establecido");
                lblResultado.Text = null;
            }


            if (meses >0 && meses <= 12)
            {

                if (meses == 2 && dias<=28)

                    lblResultado.Text = "febrero";
                else
                {
                    if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                    {
                        lblResultado.Text = "febrero";
                    }
                    else
                    {
                        lblResultado.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("Es un año promedio, no es bisiesto");
                    }


                }

                if (meses == 3)

                    lblResultado.Text = "marzo";

                if (meses == 4)

                    if (dias<=30)
                    {
                        lblResultado.Text = "abril";
                    }
                    else
                    {
                        lblResultado.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                    

                if (meses == 5)

                    lblResultado.Text = "mayo";

                if (meses == 6)

                    if (dias<=30)
                    {
                        lblResultado.Text = "junio";
                    }
                    else
                    {
                        lblResultado.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }
                 

                if (meses == 7)

                    lblResultado.Text = "julio";

                if (meses == 8)

                    lblResultado.Text = "agosto";

                if (meses == 9)

                    if (dias<=30)
                    {
                        lblResultado.Text = "septiembre"; 
                    }
                    else
                    {
                        lblResultado.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                if (meses == 10)

                    lblResultado.Text = "octubre";

                if (meses == 11)

                    if (dias<=30)
                    {
                        lblResultado.Text = "noviembre"; 
                    }

                    else
                    {
                        lblResultado.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                if (meses == 12)

                    lblResultado.Text = "diciembre";

                if (meses==1)
                {
                    lblResultado.Text = "enero";
                }

               

            }
            else
            {

                MessageBox.Show("ingrese un mes valido");
                lblResultado.Text = null;

            }

            lblResultado.Text = Convert.ToString(dias+1 + " de " +  lblResultado.Text + " de " + año);
        }

         

        private void txtMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

            txtDia.Text = null;

            txtMes.Text = null;

            txtAño.Text = null;

            lblResultado.Text = null;



        }

        private void btActual_Click(object sender, EventArgs e)
        {

          

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}