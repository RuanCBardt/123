using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodTruck.Negocio.Models;

namespace FoodTruck.Grafico
{
    public partial class ManterPedido : Form
    {
        internal Pedido pedidoSelecionado;

        public ManterPedido()
        {
            InitializeComponent();
        }
    }
}
