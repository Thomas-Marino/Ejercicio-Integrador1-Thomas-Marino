using System.Xml;

public enum ESistema { Decimal, Binario };

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;

        private double valorNumerico;

        public ESistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }
        // ---------------- Constructores ----------------
        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor , ESistema.Decimal);
        }
        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }
        public string Valor
        {
            get { return valorNumerico.ToString(); }
            set
            {
                // Intenta convertir el valor de cadena a double
                if (double.TryParse(value, out double resultado))
                {
                    valorNumerico = resultado;
                }
                else
                {
                    valorNumerico = double.NaN;
                }
            }
            //set { valorNumerico = value; }
        }
        /// <summary>
        /// Metodo encargado de inicializar los valores mediante un TryParse que retornará el valor parseado o NaN.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            this.sistema = sistema;
            if (double.TryParse(valor, out double resultado))
            {
                this.valorNumerico = resultado;
            }
            else
            {
                this.valorNumerico = double.NaN;
            }
        }
        // ---------------- Sobrecargas de operadores ----------------
        public static double operator +(Numeracion primerOperando, Numeracion segundoOperando)
        {
            if (double.TryParse(primerOperando.Valor, out double resultado) && double.TryParse(segundoOperando.Valor, out double resultado2))
            {
                return resultado + resultado2;
            }
            else
            {
                return double.MinValue;
            }
        }
        public static double operator -(Numeracion primerOperando, Numeracion segundoOperando)
        {
            if (double.TryParse(primerOperando.Valor, out double resultado) && double.TryParse(segundoOperando.Valor, out double resultado2))
            {
                return resultado - resultado2;
            }
            else
            {
                return double.MinValue;
            }
        }
        public static double operator *(Numeracion primerOperando, Numeracion segundoOperando)
        {
            if (double.TryParse(primerOperando.Valor, out double resultado) && double.TryParse(segundoOperando.Valor, out double resultado2))
            {
                return resultado * resultado2;
            }
            else
            {
                return double.MinValue;
            }
        }
        public static double operator /(Numeracion primerOperando, Numeracion segundoOperando)
        {
            if (double.TryParse(primerOperando.Valor, out double resultado) && double.TryParse(segundoOperando.Valor, out double resultado2))
            {
                if (resultado2 != 0)
                { 
                    return resultado / resultado2;
                }
                else
                {
                    return double.PositiveInfinity;
                }
           
            }
            else
            {
                return double.MinValue;
            }
        }
        /// <summary>
        /// Método encargado de convertir un valor entero decimal a binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario (int valor)
        {
            return Convert.ToString(valor, 2);
        }
        /// <summary>
        /// Método encargado de convertir un valor de tipo string a double para luego redondearlo en un entero y finalmente convertirlo en binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private static string DecimalABinario(string valor)
        {
            //int.TryParse(valor, out int valorParseado);
            double valorParseado = double.Parse(valor);
            int valorParseadoRedondeado = (int)Math.Round(valorParseado);
            if (valorParseadoRedondeado < 0)
            {
                valorParseadoRedondeado = 0;
            }
            return Convert.ToString(valorParseadoRedondeado, 2);
        }
        /// <summary>
        /// Método encargado de parsear el valor ingresado a double.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private static double BinarioADecimal(string valor)
        {
            double.TryParse(valor, out double valorP);
            return valorP;
        }
        /// <summary>
        /// Método encargado de Convertir un valor en un sistema númerico decimal o binario.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return $"{BinarioADecimal(this.Valor)}";
            }
            else
            {
                return DecimalABinario(this.Valor);
            }
        }
        /// <summary>
        /// Método encargado de retornar true si la cadena ingresada está compuesta solo por ceros y unos o false si es el caso contrario. 
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsBinario(string valor)
        {
            foreach(char numero in valor)
            {
                if (numero != '0' && numero != '1')
                {
                    return false;
                }
            }    
            return true;
        }
    }
}