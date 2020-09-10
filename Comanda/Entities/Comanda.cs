using System.Globalization;
using System.Collections.Generic;
using Padaria.Entities;
using System.Text;

namespace Padaria.Entities
{
    class Comanda
    {
        public int Numero { get; set; }
        public double valorTotal { get; set; }
        public List<ItemComanda> itens { get; set; } = new List<ItemComanda>();

        public Comanda()
        {
        }

        public double fecharComanda()
        {
            double total = 0.0;

            foreach (var addc in itens)
            {
                total = valorTotal + addc.Produtos.precoUnitario;
            }
            return total;
        }

        public void qtd()
        {
            double total = 0.0;

            foreach(var qtd in itens)
            {
                total = qtd.Quantidade * qtd.Produtos.precoUnitario;
            }
        }

        public void addlista(ItemComanda item)
        {
            itens.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Comanda resultado: ");
            foreach (ItemComanda view in itens)
            {
                sb.Append("Quantidade: " + view.Quantidade + ", Item: " + view.Produtos.Descricao + ", Preço: " + view.Produtos.precoUnitario.ToString("F2", CultureInfo.InvariantCulture));
            }

            return sb.ToString();
        }

    }
}
