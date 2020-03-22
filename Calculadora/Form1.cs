using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Form1 : Form
    {

        
        double operando1 = 0;
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if(operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if(operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if(operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "AC")
            {
                operando1 = 0; operando2 = 0;
            }
            else if (operacion == "^")
            {
                resultado = Math.Pow(operando1, operando2);
            }
            else if (operacion == "^-1")
            {
                resultado = Math.Pow(operando1, -1);
            }
            else if (operacion == "^2")
            {
                resultado = Math.Pow(operando1, 2);
            }
            else if (operacion == "^3")
            {
                resultado = Math.Pow(operando1, 3);
            }
            else if (operacion == "sin")
            {
                resultado = Math.Sin(Math.PI * operando2 / 180.0);
            }
            else if (operacion == "cos")
            {
                resultado = Math.Cos(operando2);
            }
            else if (operacion == "tan")
            {
                resultado = Math.Tan(operando2);
            }
            else if (operacion == "ln")
            {
                resultado = Math.Log(operando2);
            }
            else if (operacion == "RAIZ")
            {
                resultado = Math.Sqrt(operando2);
            }
            else if (operacion == "PI")
            {
                resultado = Math.Log(operando2);
            }
            else if (operacion == "Log")
            {
                resultado = Math.PI;
            }
            label1.Text = Convert.ToString(resultado);
        }

      
    }
}
