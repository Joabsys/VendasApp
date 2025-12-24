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
            this.maskedTextBoxDTvalidade = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(31, 52);
            this.labelQuantidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(91, 21);
            this.labelQuantidade.TabIndex = 3;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // maskedTextBoxDTCadastro
            // 
            this.maskedTextBoxDTCadastro.Location = new System.Drawing.Point(352, 96);
            this.maskedTextBoxDTCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxDTCadastro.Mask = "00/00/0000";
            this.maskedTextBoxDTCadastro.Name = "maskedTextBoxDTCadastro";
            this.maskedTextBoxDTCadastro.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxDTCadastro.TabIndex = 4;
            this.maskedTextBoxDTCadastro.TabStop = false;
            this.maskedTextBoxDTCadastro.Click += new System.EventHandler(this.maskedTextBoxDTCadastro_Click);
            this.maskedTextBoxDTCadastro.MouseLeave += new System.EventHandler(this.maskedTextBoxDTCadastro_MouseLeave);
            // 
            // maskedTextBoxDTvalidade
            // 
            this.maskedTextBoxDTvalidade.Location = new System.Drawing.Point(352, 206);
            this.maskedTextBoxDTvalidade.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxDTvalidade.Mask = "00/00/0000";
            this.maskedTextBoxDTvalidade.Name = "maskedTextBoxDTvalidade";
            this.maskedTextBoxDTvalidade.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxDTvalidade.TabIndex = 5;
            this.maskedTextBoxDTvalidade.TabStop = false;
            this.maskedTextBoxDTvalidade.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDTvalidade.Click += new System.EventHandler(this.maskedTextBoxDTvalidade_Click);
            this.maskedTextBoxDTvalidade.MouseLeave += new System.EventHandler(this.maskedTextBoxDTvalidade_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Validade";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Enabled = false;
            this.checkBoxAtivo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.Location = new System.Drawing.Point(136, 52);
            this.checkBoxAtivo.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(63, 25);
            this.checkBoxAtivo.TabIndex = 1;
            this.checkBoxAtivo.TabStop = false;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(36, 95);
            this.maskedTextBoxQuantidade.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxQuantidade.Mask = "00000";
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxQuantidade.TabIndex = 2;
            this.maskedTextBoxQuantidade.TabStop = false;
            this.maskedTextBoxQuantidade.Click += new System.EventHandler(this.maskedTextBoxQuantidade_Click);
            this.maskedTextBoxQuantidade.MouseLeave += new System.EventHandler(this.maskedTextBoxQuantidade_MouseLeave);
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(36, 205);
            this.maskedTextBoxPreco.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxPreco.Mask = "00000";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxPreco.TabIndex = 3;
            this.maskedTextBoxPreco.TabStop = false;
            this.maskedTextBoxPreco.Click += new System.EventHandler(this.maskedTextBoxPreco_Click);
            this.maskedTextBoxPreco.MouseLeave += new System.EventHandler(this.maskedTextBoxPreco_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VendasApp.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(512, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-2, -56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 30);
            this.panel2.TabIndex = 16;
            // 
            // FrmRelatorioProdutoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(548, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxDTvalidade);
            this.Controls.Add(this.maskedTextBoxDTCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRelatorioProdutoFiltro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Pordutos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDTCadastro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDTvalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}