namespace Componentes
{
    partial class F_comboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_tranposrtes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElemnetos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_tranporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_tranposrtes
            // 
            this.cb_tranposrtes.FormattingEnabled = true;
            this.cb_tranposrtes.Items.AddRange(new object[] {
            "Carro",
            "Aviao ",
            "Navio",
            "Onibus ",
            "Trem"});
            this.cb_tranposrtes.Location = new System.Drawing.Point(12, 12);
            this.cb_tranposrtes.Name = "cb_tranposrtes";
            this.cb_tranposrtes.Size = new System.Drawing.Size(174, 21);
            this.cb_tranposrtes.TabIndex = 0;
            this.cb_tranposrtes.SelectedIndexChanged += new System.EventHandler(this.cb_tranposrtes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(192, 12);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(185, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElemnetos
            // 
            this.btn_limparElemnetos.Location = new System.Drawing.Point(192, 41);
            this.btn_limparElemnetos.Name = "btn_limparElemnetos";
            this.btn_limparElemnetos.Size = new System.Drawing.Size(185, 23);
            this.btn_limparElemnetos.TabIndex = 2;
            this.btn_limparElemnetos.Text = "Limpar elementos";
            this.btn_limparElemnetos.UseVisualStyleBackColor = true;
            this.btn_limparElemnetos.Click += new System.EventHandler(this.btn_limparElemnetos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_resetarElementos.Location = new System.Drawing.Point(192, 70);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(185, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar elemento";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_tranporte
            // 
            this.tb_tranporte.Location = new System.Drawing.Point(192, 143);
            this.tb_tranporte.Name = "tb_tranporte";
            this.tb_tranporte.Size = new System.Drawing.Size(185, 20);
            this.tb_tranporte.TabIndex = 4;
            // 
            // btn_adicionarNovoTransporte
            // 
            this.btn_adicionarNovoTransporte.Location = new System.Drawing.Point(192, 169);
            this.btn_adicionarNovoTransporte.Name = "btn_adicionarNovoTransporte";
            this.btn_adicionarNovoTransporte.Size = new System.Drawing.Size(185, 23);
            this.btn_adicionarNovoTransporte.TabIndex = 5;
            this.btn_adicionarNovoTransporte.Text = "Adicionar novo transporte";
            this.btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarNovoTransporte.Click += new System.EventHandler(this.btn_adicionarNovoTransporte_Click);
            // 
            // F_comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btn_adicionarNovoTransporte);
            this.Controls.Add(this.tb_tranporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElemnetos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_tranposrtes);
            this.Name = "F_comboBox";
            this.Text = "F_comboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tranposrtes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElemnetos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_tranporte;
        private System.Windows.Forms.Button btn_adicionarNovoTransporte;
    }
}