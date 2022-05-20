using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Pregunta2
{
    public class Numero {
        private double numero1;
        private double numero2;
        public double num1 {
            get { return numero1; }
            set { numero1 = value; }
        }
        public double num2
        {
            get { return numero2; }
            set { numero2 = value; }
        }
        public double Sumar() {
            return Math.Round(num1 + num2, 8);
        }
        public double Restar()
        {
            return Math.Round(num1 - num2, 8);
        }
        public double Multiplicar()
        {
            return Math.Round(num1 * num2, 8);
        }
        public double Dividir()
        {
            return Math.Round(num1 / num2, 8);
        }
        public double Raiz()
        {
            return Math.Round(Math.Sqrt(num1), 8);
        }
        public double Cuadrado()
        {
            return Math.Round(Math.Pow(num1, 2), 8);
        }
        public double InvNum()
        {
            return num1 * -1;
        }
        public double unosobrex()
        {
            return Math.Round(1 / num1, 8);
        }
    }
    public partial class Form1 : Form
    {
        String c, num, operacion = "", descrip = "";
        bool zero = true, op = false;
        double resultado, num1, num2;
        Stack Pila = new Stack();

        public Form1()
        {
            InitializeComponent();
        }
        public void escnum(String enume)
        {

            if (op && enume != ",")
            {
                textBox1.Text = enume;
                descripcion.Text = "";
                op = false;
            }
            else
            {
                if (zero == true && enume != ",")
                {
                    textBox1.Text = enume;
                    zero = false;
                }
                else
                {
                    if (enume == ",")
                    {
                        textBox1.Text = enume + textBox1.Text;
                        zero = false;
                        op = false;
                    }
                    else
                    {
                        if (textBox1.Text.Substring(0, 1) == ",")
                        {
                            String aux, aux2;
                            if (textBox1.Text.Contains("-"))
                            {
                                aux2 = "," + enume;
                                aux = textBox1.Text.Substring(1, textBox1.Text.Length - 2) + aux2;
                                textBox1.Text = aux + "-";
                            }
                            else
                            {
                                aux = textBox1.Text.Substring(1, textBox1.Text.Length - 1) + "," + enume;
                                textBox1.Text = aux;
                            }


                        }
                        else
                        {
                            if (textBox1.Text.Contains("-"))
                            {
                                String aux = textBox1.Text.Substring(0, textBox1.Text.Length - 1) + enume;
                                textBox1.Text = aux + "-";
                            }
                            else
                            {
                                textBox1.Text = textBox1.Text + enume;
                            }
                        }


                    }
                }
            }

        }
        public void operaciones()
        {
            if (textBox1.Text.Contains("-"))
            {
                Pila.Push(Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) * -1);
            }
            else
            {
                Pila.Push(Convert.ToDouble(textBox1.Text));
            }
            if (Pila.Count == 2)
            {

                num2 = Convert.ToDouble(Pila.Pop());
                num1 = Convert.ToDouble(Pila.Pop());
                calcular(num1, num2, operacion);
                Pila.Push(resultado);
                if (resultado < 0)
                {
                    resultado = resultado * -1;
                    textBox1.Text = Convert.ToString(resultado) + "-";
                }
                else
                {
                    textBox1.Text = Convert.ToString(resultado);
                }
            }

            descripcion.Text = descrip;
            op = true;
        }
        public void operaciones2(String ope)
        {
            if (Pila.Count == 0)
            {
                if (textBox1.Text.Contains("-"))
                {
                    Pila.Push(Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) * -1);
                }
                else
                {
                    Pila.Push(Convert.ToDouble(textBox1.Text));
                }

            }
            num1 = Convert.ToDouble(Pila.Pop());
            calcular2(num1, ope);
            if (resultado < 0)
            {
                resultado = resultado * -1;
                textBox1.Text = Convert.ToString(resultado) + "-";
            }
            else
            {
                textBox1.Text = Convert.ToString(resultado);
            }
            descripcion.Text = descrip;
        }
        public void calcular(double num1, double num2, String ope)
        {
            Numero numero = new Numero();//Instanciando
            numero.num1 = num1;
            numero.num2 = num2;
            switch (ope)
            {
                case "+":
                    resultado = numero.Sumar();
                    descrip = "(" + num1.ToString() + " + " + num2.ToString() + ")";
                    break;
                case "-":
                    resultado = numero.Restar();
                    descrip = "(" + num1.ToString() + " - " + num2.ToString() + ")";
                    break;
                case "/":
                    resultado = numero.Dividir();
                    descrip = "(" + num1.ToString() + " / " + num2.ToString() + ")";
                    if (numero.num2 == 0) {
                        descrip = descrip + "= Error no hay division entre 0";
                    }
                    break;
                case "*":
                    resultado = numero.Multiplicar();
                    descrip = "(" + num1.ToString() + " * " + num2.ToString() + ")";
                    break;
                case "=":
                    resultado = num2;
                    break;
                default:
                    break;

            }
        }
        public void calcular2(double num1, String ope)
        {
            Numero numero = new Numero();//Instanciando
            numero.num1 = num1;
            numero.num2 = 0;
            switch (ope)
            {
                case "raiz":
                    descrip = "raiz(" + num1 + ")";
                    resultado = numero.Raiz();
                    break;
                case "cuadrado":
                    resultado = numero.Cuadrado();
                    descrip = "pow(" + num1 + ",2)";
                    break;
                case "elevmenos1":
                    resultado = numero.unosobrex();
                    descrip = "(1/" + num1 + ")";
                    break;
                case "invertirsigno":
                    resultado = numero.InvNum();
                    descrip = "- (" + num1 + ")";
                    break;
                default:
                    break;

            }
        }
        private void borrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 1)
            {

                textBox1.Text = "0";
                zero = true;
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            escnum("3");
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            zero = true;
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operacion = "";
            Pila.Clear();
            zero = true;
            descrip = "";
            descripcion.Text = descrip;

        }

        private void uno_sobre_x_Click(object sender, EventArgs e)
        {
            operacion = "elevmenos1";
            operaciones2(operacion);
            op = true;
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            operacion = "cuadrado";
            operaciones2(operacion);
            op = true;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            operacion = "raiz";
            operaciones2(operacion);
            op = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "/";
            op = true;
        }

        private void uno_Click(object sender, EventArgs e)
        {
            escnum("1");
        }

        private void dos_Click(object sender, EventArgs e)
        {
            escnum("2");
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "*";
            op = true;
        }

        private void ccuatro_Click(object sender, EventArgs e)
        {
            escnum("4");
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            escnum("5");
        }

        private void seis_Click(object sender, EventArgs e)
        {
            escnum("6");
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "-";
            op = true;
        }

        private void siete_Click(object sender, EventArgs e)
        {
            escnum("7");
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            escnum("8");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nueve_Click(object sender, EventArgs e)
        {
            escnum("9");
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "+";
            op = true;
        }

        private void inv_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "invertirsigno";
            operaciones2(operacion);
            op = true;
        }

        private void cero_Click(object sender, EventArgs e)
        {
            escnum("0");
        }

        private void coma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                escnum(",");
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            operaciones();
            operacion = "=";
 
        }
    }
}
