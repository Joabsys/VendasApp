namespace VendasApp.Processamento
{
    partial class FrmProcessarProduto
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ativar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Desativar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarca,
            this.ColumnID,
            this.ColumnAtivo,
            this.ColumnLogin});
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 319);
            this.dataGridView1.TabIndex = 13;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Selecionar";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ToolTipText = "Selecionar usuarios para operação";
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.ToolTipText = "Código do usuario";
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.ReadOnly = true;
            this.ColumnAtivo.ToolTipText = "Status do usuario";
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Login";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.ToolTipText = "Login do usuario";
            this.ColumnLogin.Width = 350;
            // 
            // FrmProcessarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmProcessarProduto";
            this.Text = "FrmProcessarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
    }
}