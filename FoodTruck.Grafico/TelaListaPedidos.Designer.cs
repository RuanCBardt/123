﻿namespace FoodTruck.Grafico
{
    partial class TelaListaPedidos
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
            this.dgListaPedidos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAlteraPedido = new System.Windows.Forms.Button();
            this.brRemovePedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaPedidos
            // 
            this.dgListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataCompra,
            this.Cliente,
            this.ValorTotal});
            this.dgListaPedidos.Location = new System.Drawing.Point(6, 7);
            this.dgListaPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgListaPedidos.Name = "dgListaPedidos";
            this.dgListaPedidos.RowTemplate.Height = 28;
            this.dgListaPedidos.Size = new System.Drawing.Size(520, 235);
            this.dgListaPedidos.TabIndex = 0;
            this.dgListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaPedidos_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            // 
            // DataCompra
            // 
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.HeaderText = "Data do Pedido";
            this.DataCompra.Name = "DataCompra";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // btAlteraPedido
            // 
            this.btAlteraPedido.Location = new System.Drawing.Point(462, 251);
            this.btAlteraPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAlteraPedido.Name = "btAlteraPedido";
            this.btAlteraPedido.Size = new System.Drawing.Size(66, 30);
            this.btAlteraPedido.TabIndex = 1;
            this.btAlteraPedido.Text = "Alterar";
            this.btAlteraPedido.UseVisualStyleBackColor = true;
            this.btAlteraPedido.Click += new System.EventHandler(this.btAlteraPedido_Click);
            // 
            // brRemovePedido
            // 
            this.brRemovePedido.Location = new System.Drawing.Point(393, 251);
            this.brRemovePedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brRemovePedido.Name = "brRemovePedido";
            this.brRemovePedido.Size = new System.Drawing.Size(66, 30);
            this.brRemovePedido.TabIndex = 2;
            this.brRemovePedido.Text = "Remover";
            this.brRemovePedido.UseVisualStyleBackColor = true;
            this.brRemovePedido.Click += new System.EventHandler(this.brRemovePedido_Click);
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 292);
            this.Controls.Add(this.brRemovePedido);
            this.Controls.Add(this.btAlteraPedido);
            this.Controls.Add(this.dgListaPedidos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            this.Load += new System.EventHandler(this.TelaListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaPedidos;
        private System.Windows.Forms.Button btAlteraPedido;
        private System.Windows.Forms.Button brRemovePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}