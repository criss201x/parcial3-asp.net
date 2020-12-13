using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class ejercicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }

        protected void listValTerna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void listTernas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtTerna_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnConvertir_Click(object sender, EventArgs e, KeyPressEventArgs r)
        {



        }

        protected void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
        static bool isbin(string numero)
        {
            foreach (var c in numero)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }

        static int isoctal(int numero)
        {
            int j, d;
            int n = 1;
            int p = 1;
            int dec = 0;
            int i = 1;
            int ocno = 0;
            n = Convert.ToInt32(numero);
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                {
                    p = p * 1;
                }
                else
                {
                    p = p * 2;
                }
                dec = dec + (d * p);
                i++;
            }

            i = 1;
            for (j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            return ocno;
        }
        static string reversa(string numero)
        {
            char[] charArray = numero.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static List<string> segmetar(string numero)
        {
            List<string> segmentos = new List<string>();
            //String[] segmentos;
            int residuo = numero.Length % 3;
            for (int i = 0; i < numero.Length; i += 3)
            {
                if ((i + 3) < numero.Length)
                {
                    segmentos.Add(numero.Substring(i, 3));
                }
                else if(residuo==2)
                {
                    segmentos.Add("0"+ numero.Substring(i));
                }else if(residuo == 1)
                {
                    segmentos.Add(numero.Substring(i)+ "00");
                }
            }

            return segmentos;
        }
        protected void btnConvertir_Click(object sender, EventArgs e)
        {
            String numero = "";
            int numero_bi;
            String inverso;
            String valor_terna;
            string[] listas;
            numero = txtValor.Text;
            var  desordenar = new List<string>();
            String ordenar;
            string[] listas2;
            bool respuesta = isbin(numero);
            if (respuesta)
            {
                numero_bi = Convert.ToInt32(numero);
                //isoctal(numero_bi);
                inverso = reversa(numero);
                txtSalida.Text = "" + isoctal(numero_bi);
                listas = segmetar(inverso).ToArray();
                foreach (String dato in listas)
                {
                    ordenar = reversa(dato);
                    listTernas.Items.Add(ordenar);
                    desordenar.Add(ordenar);
                }
                listas2 = desordenar.ToArray();

                txtTerna.Text = string.Join(".", listas2);
                valor_terna = reversa("" + isoctal(numero_bi));
                foreach (char digito in valor_terna)
                {

                    listValTerna.Items.Add(""+digito);
                }
            }
            else
            {
                //Console.WriteLine("\nNO se puede digitar ");
                txtSalida.Text = "No es un numero binario";
            }
        }

        protected void listTernas_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}