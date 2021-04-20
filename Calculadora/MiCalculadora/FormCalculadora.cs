using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora de Joaquin Garcia del curso 2A";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static double Operar(string n1, string n2, string operador)
        {
            Numero num1 = new Numero(n1);
            Numero num2 = new Numero(n2);

            return Calculadora.Operar(num1, num2, operador);
        }

        private void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.comboBox2.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = Convert.ToString((Operar(this.textBox1.Text, this.textBox4.Text, this.comboBox2.Text)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = Numero.DecimalABinario(this.textBox5.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = Numero.BinarioADecimal(this.textBox5.Text);
        }
    }
}
