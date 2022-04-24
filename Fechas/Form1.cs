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
                lblDias.Text = Convert.ToString(dias+1); 
            }
            else
            {

                MessageBox.Show("ingrese un dia valido dentro del rango establecido");
                lblDias.Text = null;
                lblMeses.Text = null;
                lblAños.Text = null;
            }


            if (meses >0 && meses <= 12)
            {

                if (meses == 2 && dias<=28)

                    lblMeses.Text = " de " + "febrero";
                else
                {
                    if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                    {
                        lblMeses.Text = " de " + "febrero";
                    }
                    else
                    {
                        lblDias.Text = null;
                        lblMeses.Text = null;
                        lblAños.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("Es un año promedio, no es bisiesto");
                    }


                }

                if (meses == 3)

                    lblMeses.Text = " de " + "marzo";

                if (meses == 4)

                    if (dias<=30)
                    {
                        lblMeses.Text = " de " + "abril";
                    }
                    else
                    {
                        lblDias.Text = null;
                        lblMeses.Text = null;
                        lblAños.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                    

                if (meses == 5)

                    lblMeses.Text = " de " + "mayo";

                if (meses == 6)

                    if (dias<=30)
                    {
                        lblMeses.Text = " de " + "junio";
                    }
                    else
                    {
                        lblDias.Text = null;
                        lblMeses.Text = null;
                        lblAños.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }
                 

                if (meses == 7)

                    lblMeses.Text = " de " + "julio";

                if (meses == 8)

                    lblMeses.Text = " de " + "agosto";

                if (meses == 9)

                    if (dias<=30)
                    {
                        lblMeses.Text = " de " + "septiembre"; 
                    }
                    else
                    {
                        lblDias.Text = null;
                        lblMeses.Text = null;
                        lblAños.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                if (meses == 10)

                    lblMeses.Text = " de " + "octubre";

                if (meses == 11)

                    if (dias<=30)
                    {
                        lblMeses.Text = " de " + "noviembre"; 
                    }

                    else
                    {
                        lblDias.Text = null;
                        lblMeses.Text = null;
                        lblAños.Text = null;
                        txtDia.Text = null;
                        txtMes.Text = null;
                        txtAño.Text = null;
                        MessageBox.Show("este mes llega hasta 30 dias, no 31");
                    }

                if (meses == 12)

                    lblMeses.Text = " de " + "diciembre";

                if (meses==1)
                {
                    lblMeses.Text = " de " + "enero";
                }

               

            }
            else
            {

                MessageBox.Show("ingrese un mes valido");
                lblMeses.Text = null;

            }


            do
            {

                lblAños.Text = Convert.ToString(" de " + año);


                if (año > 2022)
                {

                    MessageBox.Show("ingrese un año valido");

                }


            } while (año>=1200 && año<=2022);

            MessageBox.Show("El año debe estar establecido entre lo declarado"); 
        }
  
        private void btLimpiar_Click(object sender, EventArgs e)
        {

            txtDia.Text = null;

            txtMes.Text = null;

            txtAño.Text = null;

            lblDias.Text = null;

            lblMeses.Text = null;

            lblAños.Text = null;

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}