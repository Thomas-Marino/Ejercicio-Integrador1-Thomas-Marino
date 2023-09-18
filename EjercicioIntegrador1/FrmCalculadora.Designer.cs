namespace EjercicioIntegrador1
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnOperar = new Button();
            BtnLimpiar = new Button();
            BtnCerrar = new Button();
            TxbOperando1 = new TextBox();
            CbSeleccionOperador = new ComboBox();
            TxbOperando2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GrpSistemasNumericos = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            TxbResultado = new TextBox();
            GrpSistemasNumericos.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOperar
            // 
            BtnOperar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOperar.Location = new Point(12, 384);
            BtnOperar.Name = "BtnOperar";
            BtnOperar.Size = new Size(242, 40);
            BtnOperar.TabIndex = 1;
            BtnOperar.Text = "Operar";
            BtnOperar.UseVisualStyleBackColor = true;
            BtnOperar.Click += BtnOperar_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLimpiar.Location = new Point(282, 384);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(242, 40);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrar.Location = new Point(546, 384);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(242, 40);
            BtnCerrar.TabIndex = 3;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // TxbOperando1
            // 
            TxbOperando1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxbOperando1.Location = new Point(12, 303);
            TxbOperando1.Name = "TxbOperando1";
            TxbOperando1.Size = new Size(242, 43);
            TxbOperando1.TabIndex = 4;
            TxbOperando1.TextAlign = HorizontalAlignment.Center;
            // 
            // CbSeleccionOperador
            // 
            CbSeleccionOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSeleccionOperador.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            CbSeleccionOperador.FormattingEnabled = true;
            CbSeleccionOperador.Items.AddRange(new object[] { "", "+", "-", "/", "*" });
            CbSeleccionOperador.Location = new Point(320, 303);
            CbSeleccionOperador.Name = "CbSeleccionOperador";
            CbSeleccionOperador.Size = new Size(170, 43);
            CbSeleccionOperador.TabIndex = 5;
            // 
            // TxbOperando2
            // 
            TxbOperando2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxbOperando2.Location = new Point(546, 303);
            TxbOperando2.Name = "TxbOperando2";
            TxbOperando2.Size = new Size(242, 43);
            TxbOperando2.TabIndex = 6;
            TxbOperando2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 260);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 7;
            label1.Text = "Primer operador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(320, 259);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 8;
            label2.Text = "Operacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(546, 259);
            label3.Name = "label3";
            label3.Size = new Size(218, 31);
            label3.TabIndex = 9;
            label3.Text = "Segundo operador:";
            // 
            // GrpSistemasNumericos
            // 
            GrpSistemasNumericos.Controls.Add(radioButton2);
            GrpSistemasNumericos.Controls.Add(radioButton1);
            GrpSistemasNumericos.Location = new Point(302, 185);
            GrpSistemasNumericos.Name = "GrpSistemasNumericos";
            GrpSistemasNumericos.Size = new Size(208, 53);
            GrpSistemasNumericos.TabIndex = 10;
            GrpSistemasNumericos.TabStop = false;
            GrpSistemasNumericos.Text = "Representar resultado en:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(140, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Binario";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Decimal";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(197, 50);
            label4.TabIndex = 11;
            label4.Text = "Resultado:";
            // 
            // TxbResultado
            // 
            TxbResultado.BackColor = SystemColors.Window;
            TxbResultado.Enabled = false;
            TxbResultado.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            TxbResultado.Location = new Point(215, 60);
            TxbResultado.Name = "TxbResultado";
            TxbResultado.Size = new Size(549, 57);
            TxbResultado.TabIndex = 12;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 450);
            Controls.Add(TxbResultado);
            Controls.Add(label4);
            Controls.Add(GrpSistemasNumericos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxbOperando2);
            Controls.Add(CbSeleccionOperador);
            Controls.Add(TxbOperando1);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Thomas Marino";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            GrpSistemasNumericos.ResumeLayout(false);
            GrpSistemasNumericos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnOperar;
        private Button BtnLimpiar;
        private Button BtnCerrar;
        private TextBox TxbOperando1;
        private ComboBox CbSeleccionOperador;
        private TextBox TxbOperando2;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox GrpSistemasNumericos;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private TextBox TxbResultado;
    }
}