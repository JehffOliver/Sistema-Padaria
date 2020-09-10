using System;
using System.Globalization;
using Padaria.Entities;

namespace Padaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos itens foram consumidos? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                Console.Write("Código do produto: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Descrição do produto: ");
                string descricao = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(codigo, descricao, preco);

                ItemComanda item = new ItemComanda(produto, n);

                Comanda c = new Comanda();

                c.addlista(item);

                Console.WriteLine(c);

            }
        }
    }
}
