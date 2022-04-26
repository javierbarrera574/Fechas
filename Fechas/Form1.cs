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

        int mes1;

        int mes2;

        int mes3;

        int mes4;

        int mes5;

        int mes6;

        int mes7;

        int mes8;

        int mes9;

        int mes10;

        int mes11;

        int mes12;

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

            //else
            //{

            //    MessageBox.Show("ingrese un dia valido dentro del rango establecido");
            //    lblDias.Text = null;
            //    lblMeses.Text = null;
            //    lblAños.Text = null;
            //}


            if (meses >0 && meses <= 12)
            {

                if (meses == 2 && dias <= 28)

                {


                    if (dias==28)
                    {
                        mes2 = meses + 1;
                        mes2 = mes3;

                        if (meses==3)
                        {

                            dias = 1;
                            



                        }

                    }

                    


                    lblMeses.Text = " de " + "febrero";

                }


                else

                {
                    if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                    {

                        if (dias==29)
                        {
                            mes2 = meses + 1;
                            mes2 = mes3;


                            //dias = 1;
                            //int diasiguiente = dias;


                            if (mes3==3)
                            {
                                dias = 1;
                            }

                        }

                        lblMeses.Text = " de " + "febrero";
                    }

                }

                if (meses == 3)

                {

                    if (dias==31)
                    {
                        mes3 = meses + 1;

                        mes3 = mes4;

                        if (mes4==4)
                        {
                            dias = 1;
                        }
                    }
                    
                    lblMeses.Text = " de " + "marzo"; 
                
                
                }

                if (meses == 4)

                    if (dias<=30)
                    {

                        if (dias==30)
                        {
                            mes4 = meses + 1;

                            mes4 = mes5;

                            if (mes5==1)
                            {
                                dias = 1;
                            }


                        }


                        lblMeses.Text = " de " + "abril";
                    }
                    

                if (meses == 5)

                    lblMeses.Text = " de " + "mayo";

                if (meses == 6)

                    if (dias<=30)
                    {

                        if (dias==30)
                        {
                            mes7 = meses + 1;

                            mes7 = mes8;

                            if (mes7==7)
                            {
                                dias = 1;
                            }

                        }

                        lblMeses.Text = " de " + "junio";
                    }

                if (meses == 7)

                {


                    if (dias == 31)
                    {
                        
                        

                        int mes7 = meses+1;

                        mes7 = mes8;

                        if (mes8 == 8)
                        {
                            dias = 1;
                        }

                    }


                    lblMeses.Text = " de " + "julio"; 
                
                }

                if (meses == 8)

                    lblMeses.Text = " de " + "agosto";

                if (meses == 9)

                    if (dias<=30)
                    {


                        if (dias == 30)
                        {
                            int mes9 = mes10;

                            if (mes10 == 10)
                            {
                                dias = 1;
                            }

                        }
                        lblMeses.Text = " de " + "septiembre"; 
                    }
                 
                if (meses == 10)

                    lblMeses.Text = " de " + "octubre";

                if (meses == 11)

                    if (dias<=30)
                    {

                        if (dias==30)
                        {
                            mes11 = meses +1;
                            mes11 = mes12;

                            if (mes12==12)
                            {
                                dias = 1;
                            }

                        }

                        lblMeses.Text = " de " + "noviembre"; 
                    }



                if (meses == 12)


                {

                    if (dias==31)
                    {
                        mes12 = meses + 1;
                        mes12 = mes1;

                        if (mes1==1)
                        {
                            dias = 1;
                        }
                    }

                    lblMeses.Text = " de " + "diciembre";


                }

                if (meses==1)
                {
                    if (dias==31)
                    {
                        int mes2 = meses + 1;//aca en teoria se tendria que incrementar el mes



                    }
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



///PROBAR SI ESTA MIERDA FUNCIONA EN ALGUN MOMENTO