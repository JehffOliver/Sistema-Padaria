using System;
using System.Collections.Generic;
using Padaria.Entities;

namespace Padaria.Entities
{
    class ItemComanda
    {
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }

        public ItemComanda()
        {

        }

        public ItemComanda(Produto produtos, int quantidade)
        {
            Produtos = produtos;
            Quantidade = quantidade;
        }
    }
}
