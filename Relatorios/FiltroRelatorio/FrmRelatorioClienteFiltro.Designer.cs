namespace VendasApp.Relatorios.FiltroRelatorio
{
    partial class FrmRelatorioClienteFiltro
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxAtivo = new System.Windows.Forms.CheckBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(168, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.comboBox1.Location = new System.Drawing.Point(37, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Documento";
            // 
            // CheckBoxAtivo
            // 
            this.CheckBoxAtivo.AutoSize = true;
            this.CheckBoxAtivo.Location = new System.Drawing.Point(168, 16);
            this.CheckBoxAtivo.Name = "CheckBoxAtivo";
            this.CheckBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.CheckBoxAtivo.TabIndex = 7;
            this.CheckBoxAtivo.Text = "Ativo";
            this.CheckBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.Location = new System.Drawing.Point(37, 66);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBairro.Location = new System.Drawing.Point(37, 126);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(100, 20);
            this.textBoxBairro.TabIndex = 10;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(37, 99);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(34, 13);
            this.labelBairro.TabIndex = 11;
            this.labelBairro.Text = "Bairro";
            // 
            // FrmRelatorioClienteFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 161);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.CheckBoxAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRelatorioClienteFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxAtivo;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
    }
}