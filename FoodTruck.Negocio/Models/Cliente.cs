﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio.Models
{
    [Table(name: "Clientes")]
    public class Cliente
    {
        public long Id { get; set; }
        public String CPF { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }

        public String Descrever()
        {
            return String.Format($"{this.CPF} - {this.Nome} - {this.Email}");
        }
    }
}
