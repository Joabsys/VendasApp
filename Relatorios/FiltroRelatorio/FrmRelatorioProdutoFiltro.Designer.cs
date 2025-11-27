namespace VendasApp.Relatorios.FiltroRelatorio
{
    partial class FrmRelatorioProdutoFiltro
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxDTCadastro = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(21, 32);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(63, 15);
            this.labelQuantidade.TabIndex = 3;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // maskedTextBoxDTCadastro
            // 
            this.maskedTextBoxDTCadastro.Location = new System.Drawing.Point(235, 60);
            this.maskedTextBoxDTCadastro.Mask = "00/00/0000";
            this.maskedTextBoxDTCadastro.Name = "maskedTextBoxDTCadastro";
            this.maskedTextBoxDTCadastro.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDTCadastro.TabIndex = 6;
            this.maskedTextBoxDTCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(235, 128);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Validade";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.Location = new System.Drawing.Point(91, 32);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(51, 19);
            this.checkBoxAtivo.TabIndex = 11;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(24, 59);
            this.maskedTextBoxQuantidade.Mask = "00000";
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxQuantidade.TabIndex = 12;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(24, 127);
            this.maskedTextBoxPreco.Mask = "00000";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPreco.TabIndex = 13;
            // 
            // FrmRelatorioProdutoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 195);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBoxDTCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "FrmRelatorioProdutoFiltro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Pordutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDTCadastro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
    }
}