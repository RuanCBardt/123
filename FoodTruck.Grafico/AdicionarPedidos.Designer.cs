using System;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    partial class AdicionarPedidos
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
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.cbLanches = new System.Windows.Forms.ComboBox();
            this.btAdicionaBebida = new System.Windows.Forms.Button();
            this.btAdicionaLanche = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalvarPedido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(119, 60);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(230, 21);
            this.cbClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bebidas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lanches";
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(119, 110);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(243, 21);
            this.cbBebidas.TabIndex = 4;
            // 
            // cbLanches
            // 
            this.cbLanches.FormattingEnabled = true;
            this.cbLanches.Location = new System.Drawing.Point(556, 110);
            this.cbLanches.Name = "cbLanches";
            this.cbLanches.Size = new System.Drawing.Size(243, 21);
            this.cbLanches.TabIndex = 5;
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(368, 108);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(23, 23);
            this.btAdicionaBebida.TabIndex = 6;
            this.btAdicionaBebida.Text = "+";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btAdicionaLanche
            // 
            this.btAdicionaLanche.Location = new System.Drawing.Point(805, 108);
            this.btAdicionaLanche.Name = "btAdicionaLanche";
            this.btAdicionaLanche.Size = new System.Drawing.Size(23, 23);
            this.btAdicionaLanche.TabIndex = 7;
            this.btAdicionaLanche.Text = "+";
            this.btAdicionaLanche.UseVisualStyleBackColor = true;
            this.btAdicionaLanche.Click += new System.EventHandler(this.BtAdicionaLanche_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tamanho,
            this.Preco});
            this.dgBebidas.Location = new System.Drawing.Point(119, 137);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(343, 288);
            this.dgBebidas.TabIndex = 8;
            this.dgBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBebidas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Valor";
            this.Preco.HeaderText = "Valor";
            this.Preco.Name = "Preco";
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLanche,
            this.ValorLanche});
            this.dgLanches.Location = new System.Drawing.Point(556, 137);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(243, 288);
            this.dgLanches.TabIndex = 9;
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            // 
            // ValorLanche
            // 
            this.ValorLanche.DataPropertyName = "Valor";
            this.ValorLanche.HeaderText = "Valor";
            this.ValorLanche.Name = "ValorLanche";
            // 
            // btSalvarPedido
            // 
            this.btSalvarPedido.Location = new System.Drawing.Point(724, 449);
            this.btSalvarPedido.Name = "btSalvarPedido";
            this.btSalvarPedido.Size = new System.Drawing.Size(75, 23);
            this.btSalvarPedido.TabIndex = 10;
            this.btSalvarPedido.Text = "Salvar";
            this.btSalvarPedido.UseVisualStyleBackColor = true;
            this.btSalvarPedido.Click += new System.EventHandler(this.btSalvarPedido_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(183, 454);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // AdicionarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 494);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSalvarPedido);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAdicionaLanche);
            this.Controls.Add(this.btAdicionaBebida);
            this.Controls.Add(this.cbLanches);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientes);
            this.Name = "AdicionarPedidos";
            this.Text = "AdicionarPedidos";
            this.Load += new System.EventHandler(this.AdicionarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.ComboBox cbLanches;
        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btAdicionaLanche;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.Button btSalvarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn NomeLanche;
        private DataGridViewTextBoxColumn ValorLanche;
        private Label label4;
        private Label lbTotal;
    }
}