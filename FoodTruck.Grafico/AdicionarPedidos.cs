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
using FoodTruck.Negocio;
using FoodTruck.Grafico;

namespace FoodTruck.Grafico
{
    public partial class AdicionarPedidos : Form
    {
        Pedido pedido = new Pedido();

        public Pedido PedidoSelecionado { get; internal set; }

        public AdicionarPedidos()
        {
            InitializeComponent();
        }

        private void AdicionarPedidos_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaDatagrids()
        {
            dgBebidas.AutoGenerateColumns = false;
            dgBebidas.DataSource = pedido.Bebidas.ToList();
            dgLanches.AutoGenerateColumns = false;
            dgLanches.DataSource = pedido.Lanches.ToList();
            
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
            pedido.Bebidas.Add(bebidaSelecionada);
            CarregaDatagrids();
            CarregaTotal();
        }

        private void BtAdicionaLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)cbLanches.SelectedItem;
            pedido.Lanches.Add(lancheSelecionado);
            CarregaDatagrids();
            CarregaTotal();
        }

        private void CarregaTotal()
        {
            lbTotal.Text = pedido.ValorTotal.ToString();
        }

        private void btSalvarPedido_Click(object sender, EventArgs e)
        {
            pedido.Cliente = cbClientes.SelectedItem as Cliente;
            pedido.DataCompra = DateTime.Now;
            Validacao validacao;
            if (PedidoSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastrarPedido(pedido);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarPedido(pedido);
            }
            if (validacao.Valido)
            {
                MessageBox.Show("Pedido cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                String msg = "";
                foreach (var mensagem in validacao.Mensagens)
                {
                    msg += mensagem + Environment.NewLine;
                }
                MessageBox.Show(msg, "Erro");
            }
            this.Close();
        }

        private void btRemoverBebidaSelecionada_Click(object sender, EventArgs e)
        {
              Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
              pedido.Bebidas.Remove(bebidaSelecionada);
              CarregaDatagrids();
              CarregaTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)cbLanches.SelectedItem;
            pedido.Lanches.Remove(lancheSelecionado);
            CarregaDatagrids();
            CarregaTotal();
        }

        private void AdicionarPedidos_Shown(object sender, EventArgs e)
        {
            if (PedidoSelecionado != null)
            {
                this.cbClientes.SelectedItem = PedidoSelecionado.Cliente;
                this.dgBebidas.DataSource = PedidoSelecionado.Bebidas.ToList();
                this.dgLanches.DataSource = PedidoSelecionado.Lanches.ToList();
                this.lbTotal.Text = PedidoSelecionado.ValorTotal.ToString();
                pedido = PedidoSelecionado;
            }
        }
    } 
}
