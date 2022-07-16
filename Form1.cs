using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuo_inss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double salario = 0, salarioDesc = 0, descInss =0, descIrf = 0;
            string nome = "", lista = "";

            salario = Convert.ToDouble(txtSalario.Text);
            nome = txtNome.Text;

            if(salario <= 1212)
            {
                descInss = salario * 0.075;
            
            }else if(salario <= 2427.35)
            {
                descInss = salario * 0.09;
            
            }else if(salario <= 3641.03)
            {
                descInss = salario * 0.12;
            
            }else if(salario <= 7082.22)
            { 
                descInss = salario * 0.14;
            }
            else
            {
                descInss = 7082.22 * 0.14;
            }

            salarioDesc = salario - descInss;

            if(salarioDesc <= 1903.98)
            {
                descIrf = 0;

            }else if(salarioDesc <= 2826.65)
            {
                descIrf = (salario - descInss)*0.075;
   
            }else if(salarioDesc <= 3751.05)
            {
                descIrf = (salario - descInss) * 0.15;
            }
            else if(salarioDesc <= 4664.68)
            {
                descIrf = (salario - descInss) * 0.225;
            }
            else
            {
                descIrf = (salario - descInss) * 0.227;
            }


            lista = "Folha de Pagamento " + Environment.NewLine;
            lista += "------------------------------------------------------"+ Environment.NewLine;
            lista += "Funcionario: "+ nome + Environment.NewLine;
            lista += "Salario Bruto: "+ salario + Environment.NewLine;
            lista += "Desconto:" + Environment.NewLine;
            lista += "      INSS :" + descInss + Environment.NewLine;
            lista += "       IRF :" + descIrf + Environment.NewLine;
            lista += "Salario Liquido: " +( salario - descInss -descIrf ) + Environment.NewLine;
            lista += "------------------------------------------------------";

            txtLista.Text = lista;

            
             
            



        }
    }
}
