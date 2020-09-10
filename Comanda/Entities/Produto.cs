using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Entities
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double precoUnitario { get; set; }

        public Produto(int codigo, string descricao, double precounitario)
        {
            Codigo = codigo;
            Descricao = descricao;
            precoUnitario = precounitario;
        }
    }
}
