using Entidades;
using System.Drawing.Text;

namespace EjercicioIntegrador1
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Operacion calculadora;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
            radioButton1.Select();
        }
        // ---------------- Botones ----------------
        // ---------------- Botones de cierre.
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ---------------- Boton de limpiar.
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxbOperando1.ResetText();
            TxbOperando2.ResetText();
            TxbResultado.ResetText();
            CbSeleccionOperador.ResetText();
        }
        // ---------------- Boton de operar.
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbOperando1.Text))
            {
                TxbOperando1.Text = "0";
            }
            if (string.IsNullOrEmpty(TxbOperando2.Text))
            {
                TxbOperando2.Text = "0";
            }
            this.primerOperando = new Numeracion(TxbOperando1.Text, this.sistema);
            this.segundoOperando = new Numeracion(TxbOperando2.Text, this.sistema);
            this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
            setResultado();
            resultado.Valor = resultado.ConvertirA(this.sistema);
            TxbResultado.Text = resultado.Valor;
        }
        // ---------------- Radio Button Decimal.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Decimal;
        }
        // ---------------- Radio Button Binario.
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
        }
        /// <summary>
        /// Método encargado de inicializar el objeto resultado de tipo Numeracion y settear la operacion matematica entre el primer operando y el segundo operando dependiendo del operador seleccionado.
        /// </summary>
        private void setResultado()
        {
            this.resultado = new Numeracion(0.0, this.sistema);
            if (CbSeleccionOperador.Text != "")
            {
                //resultado.Valor = $"{calculadora.Operar(char.Parse(CbSeleccionOperador.Text))}";
                resultado = calculadora.Operar(char.Parse(CbSeleccionOperador.Text));
            }
            else
            {
                resultado = calculadora.Operar(' ');
            }
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}