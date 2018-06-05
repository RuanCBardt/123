using FoodTruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    public partial class TelaListaPedidos : Form
    {
        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void dgListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            dgListaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListaPedidos.MultiSelect = false;
            dgListaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListaPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            dgListaPedidos.DataSource = pedidos;
        }

        private void btVisualizaPedido_Click(object sender, EventArgs e)
        {
            AdicionarPedidos tela = new AdicionarPedidos();
            tela.Show();
        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }
        
        private bool VerificarSelecao()
        {
            if (dgListaPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void brRemovePedido_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoSelecionado = (Pedido)dgListaPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(pedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o pedido");
                    }

                    CarregarPedidos();
                }
            }
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void btAlteraPedido_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido PedidoSelecionado = (Pedido)dgListaPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(PedidoSelecionado);
            }
        }

        private void AbreTelaInclusaoAlteracao(Pedido PedidoSelecionado)
        {
            AdicionarPedidos tela = new AdicionarPedidos();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = PedidoSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }
    }
}
