using Entidades;
using System.Drawing.Text;
using System.Text;

namespace EjercicioIntegrador1
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Operacion calculadora;
        private Numeracion.ESistema sistema;

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
            CbSeleccionOperador.Enabled = true;
            TxbOperando1.Enabled = true;
            TxbOperando2.Enabled = true;
            BtnOperar.Enabled = true;
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
            setResultado();
            CbSeleccionOperador.Enabled = false;
            TxbOperando1.Enabled = false;
            TxbOperando2.Enabled = false;
            BtnOperar.Enabled = false;
        }
        // ---------------- Radio Button Decimal.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // de binario paso a decimal.
            {
                if (TxbResultado.Text != "")
                {
                    resultado = calculadora.Operar(char.Parse(CbSeleccionOperador.Text));
                    TxbResultado.Text = resultado.Valor;
                }
            }
            else
            {
                if (TxbResultado.Text != "")
                {
                    resultado.Valor = resultado.ConvertirA(Numeracion.ESistema.Binario);
                    TxbResultado.Text = resultado.Valor;
                }
            }
        }
        // ---------------- Radio Button Binario.
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Método encargado de inicializar el objeto resultado de tipo Numeracion y settear la operacion matematica entre el primer operando y el segundo operando dependiendo del operador seleccionado.
        /// </summary>
        private void setResultado()
        {
            this.primerOperando = new Numeracion(TxbOperando1.Text, Numeracion.ESistema.Decimal);
            this.segundoOperando = new Numeracion(TxbOperando2.Text, Numeracion.ESistema.Decimal);
            this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
            this.resultado = new Numeracion("0.0", Numeracion.ESistema.Decimal);
            if (CbSeleccionOperador.SelectedItem is null)
            {
                CbSeleccionOperador.SelectedIndex = 0;
            }
            resultado = calculadora.Operar(char.Parse(CbSeleccionOperador.Text));
            if (radioButton2.Checked)
            {
                resultado.Valor = resultado.ConvertirA(Numeracion.ESistema.Binario);
            }
            TxbResultado.Text = resultado.Valor;
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}