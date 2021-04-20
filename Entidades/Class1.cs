using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double retorno = 0;
            string op = ValidarOperador(operador[0]);
            switch (operador)
            {
                case "+":
                    retorno = n1 + n2;
                    break;
                case "-":
                    retorno = n1 - n2;
                    break;
                case "*":
                    retorno = n1 * n2;
                    break;
                case "/":
                    retorno = n1 / n2;
                    break;
            }

            return retorno;
        }

        private static string ValidarOperador(char operador)
        {
            string retorno = "";

            switch (operador)
            {
                case '+':
                    retorno = "+";
                    break;
                case '-':
                    retorno = "-";
                    break;
                case '*':
                    retorno = "*";
                    break;
                case '/':
                    retorno = "/";
                    break;
                default:
                    retorno = "+";
                    break;
            }
            return retorno;
        }
    }

    public class Numero
    {
        public double numero;
        public string SetNumero{
            set
            {
                this.numero = validarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private double validarNumero(string strNumero)
        {
            double retorno;
            double.TryParse(strNumero, out retorno);

            return retorno;
        }

        public static bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach(char i in binario)
            {
                if(!(i == '0' || i == '1'))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static string BinarioADecimal(string binario)
        {
            string retorno = "Valor invalido";
            char[] bin = binario.ToCharArray();
            Array.Reverse(bin);
            int numero = 0;

            if (EsBinario(binario) == true)
            {
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] == '1')
                    {
                        numero += (int)Math.Pow(2, i);
                    }
                }
                retorno = Convert.ToString(numero);
            }
            return retorno;
        }
        
        public static string DecimalABinario(string numero)
        {
            string retorno = "Valor invalido";
            int num;

            if (int.TryParse(numero, out num) == true)
            {
                retorno = "";
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        retorno = "0" + retorno;
                    }
                    else
                    {
                        retorno = "1" + retorno;
                    }
                    num = (int)(num / 2);
                }
            }

            return retorno;
        }
        public static string DecimalABinario(double numero)
        {
            return Numero.DecimalABinario(Convert.ToString(numero));
        }

        public static double operator +(Numero x, Numero y)
        {
            return x.numero + y.numero;
        }
        public static double operator -(Numero x, Numero y)
        {
            return x.numero - y.numero;
        }
        public static double operator *(Numero x, Numero y)
        {
            return x.numero * y.numero;
        }
        public static double operator /(Numero x, Numero y)
        {
            double retorno = double.MinValue;
            if(y.numero != 0)
            {
                retorno = x.numero / y.numero;
            }
            return retorno;
        }

    }
}
