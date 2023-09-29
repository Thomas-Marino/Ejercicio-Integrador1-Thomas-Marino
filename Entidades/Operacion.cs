using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }

            set
            {
                primerOperando = value;
            }

        }
        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }

            set
            {
                segundoOperando = value;
            }

        }
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.PrimerOperando = primerOperando;
            this.SegundoOperando = segundoOperando;
        }
        /// <summary>
        /// Método encargado de realizar y retornar el resultado de una operacion matematica entre un primer operando y segundo operando dependiendo del operador ingresado.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public Numeracion Operar(char operador)
        {
            double resultado;
            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;
                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;
                case '/':
                    resultado = this.primerOperando / this.segundoOperando;
                    break;
                default:
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
            }
            Numeracion retorno = new Numeracion(resultado, Numeracion.ESistema.Decimal);
            return retorno;
        }


    }
}
