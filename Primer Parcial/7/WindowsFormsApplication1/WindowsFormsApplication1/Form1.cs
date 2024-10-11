using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String exp;
        public Form1()
        {
            InitializeComponent();
        }

        public static bool EsOperador(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/');
        }

        public static double AplicarOperacion(double a, double b, char operador)
        {
            switch (operador)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("División por cero no permitida.");
                    }
                    return a / b;
                default: throw new ArgumentException("Operador inválido");
            }
        }

        public static int Precedencia(char operador)
        {
            if (operador == '+' || operador == '-') return 1;
            if (operador == '*' || operador == '/') return 2;
            return 0;
        }
        public double Evaluar(string expresion)
        {
            Stack<double> valores = new Stack<double>();
            Stack<char> operadores = new Stack<char>();

            for (int i = 0; i < expresion.Length; i++)
            {
                if (Char.IsWhiteSpace(expresion[i])) continue;

                if (Char.IsDigit(expresion[i]))
                {
                    double valor = 0;
                    while (i < expresion.Length && (Char.IsDigit(expresion[i]) || expresion[i] == '.'))
                    {
                        if (expresion[i] == '.')
                        {
                            
                            i++;
                            double factor = 0.1;
                            while (i < expresion.Length && Char.IsDigit(expresion[i]))
                            {
                                valor += (expresion[i] - '0') * factor;
                                factor /= 10;
                                i++;
                            }
                        }
                        else
                        {
                            valor = valor * 10 + (expresion[i] - '0');
                            i++;
                        }
                    }
                    valores.Push(valor);
                    i--;
                }
                else if (expresion[i] == '(')
                {
                    operadores.Push(expresion[i]);
                }
                else if (expresion[i] == ')')
                {
                    while (operadores.Peek() != '(')
                    {
                        double b = valores.Pop();
                        double a = valores.Pop();
                        valores.Push(AplicarOperacion(a, b, operadores.Pop()));
                    }
                    operadores.Pop();
                }
                else if (EsOperador(expresion[i]))
                {
                    while (operadores.Count > 0 && Precedencia(operadores.Peek()) >= Precedencia(expresion[i]))
                    {
                        double b = valores.Pop();
                        double a = valores.Pop();
                        valores.Push(AplicarOperacion(a, b, operadores.Pop()));
                    }
                    operadores.Push(expresion[i]);
                }
            }

            while (operadores.Count > 0)
            {
                double b = valores.Pop();
                double a = valores.Pop();
                valores.Push(AplicarOperacion(a, b, operadores.Pop()));
            }

            return valores.Pop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exp = "";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '0';
            textBox1.Text = exp;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '1';
            textBox1.Text = exp;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '2';
            textBox1.Text = exp;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '3';
            textBox1.Text = exp;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '4';
            textBox1.Text = exp;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '5';
            textBox1.Text = exp;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '6';
            textBox1.Text = exp;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '7';
            textBox1.Text = exp;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '8';
            textBox1.Text = exp;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '9';
            textBox1.Text = exp;
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            exp = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSuma_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '+';
            textBox1.Text = exp;
        }

        private void butIgual_Click(object sender, EventArgs e)
        {
            try
            {
                exp = textBox1.Text;
                double r = Evaluar(exp);
                textBox1.Text = r.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error"; 
            }
        }

        private void butResta_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '-';
            textBox1.Text = exp;
        }

        private void butMulti_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + 'x';
            textBox1.Text = exp;
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            exp = textBox1.Text + '/';
            textBox1.Text = exp;
        }
    }
}
