namespace JokempoWinForms
{
    partial class Form1
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
            btnIniciar = new Button();
            txtNome = new TextBox();
            buttonPedra = new Button();
            buttonTesoura = new Button();
            buttonPapel = new Button();
            lblResultado = new Label();
            lblPC = new Label();
            btnEstatisticas = new Button();
            lstEstatisticas = new ListBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(80, 106);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(154, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Definir Jogaddor";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(37, 58);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o nome do Jogador";
            txtNome.Size = new Size(240, 27);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // buttonPedra
            // 
            buttonPedra.Location = new Point(315, 106);
            buttonPedra.Name = "buttonPedra";
            buttonPedra.Size = new Size(94, 29);
            buttonPedra.TabIndex = 2;
            buttonPedra.Text = "Pedra";
            buttonPedra.UseVisualStyleBackColor = true;
            buttonPedra.Click += buttonPedra_Click;
            // 
            // buttonTesoura
            // 
            buttonTesoura.Location = new Point(415, 106);
            buttonTesoura.Name = "buttonTesoura";
            buttonTesoura.Size = new Size(94, 29);
            buttonTesoura.TabIndex = 3;
            buttonTesoura.Text = "Tesoura";
            buttonTesoura.UseVisualStyleBackColor = true;
            buttonTesoura.Click += buttonTesoura_Click;
            // 
            // buttonPapel
            // 
            buttonPapel.Location = new Point(515, 106);
            buttonPapel.Name = "buttonPapel";
            buttonPapel.Size = new Size(94, 29);
            buttonPapel.TabIndex = 4;
            buttonPapel.Text = "Papel";
            buttonPapel.UseVisualStyleBackColor = true;
            buttonPapel.Click += buttonPapel_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.Control;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(422, 238);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(77, 22);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // lblPC
            // 
            lblPC.AutoSize = true;
            lblPC.BackColor = SystemColors.Control;
            lblPC.BorderStyle = BorderStyle.Fixed3D;
            lblPC.Location = new Point(422, 181);
            lblPC.Name = "lblPC";
            lblPC.Size = new Size(82, 22);
            lblPC.TabIndex = 6;
            lblPC.Text = "Escolha PC";
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.Location = new Point(741, 106);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Size = new Size(173, 29);
            btnEstatisticas.TabIndex = 7;
            btnEstatisticas.Text = "Ver Estatisticas";
            btnEstatisticas.UseVisualStyleBackColor = true;
            btnEstatisticas.Click += btnEstatisticas_Click;
            // 
            // lstEstatisticas
            // 
            lstEstatisticas.FormattingEnabled = true;
            lstEstatisticas.Location = new Point(706, 181);
            lstEstatisticas.Name = "lstEstatisticas";
            lstEstatisticas.Size = new Size(240, 184);
            lstEstatisticas.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1101, 450);
            Controls.Add(lstEstatisticas);
            Controls.Add(btnEstatisticas);
            Controls.Add(lblPC);
            Controls.Add(lblResultado);
            Controls.Add(buttonPapel);
            Controls.Add(buttonTesoura);
            Controls.Add(buttonPedra);
            Controls.Add(txtNome);
            Controls.Add(btnIniciar);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private TextBox txtNome;
        private Button buttonPedra;
        private Button buttonTesoura;
        private Button buttonPapel;
        private Label lblResultado;
        private Label lblPC;
        private Button btnEstatisticas;
        private ListBox lstEstatisticas;
    }
}
