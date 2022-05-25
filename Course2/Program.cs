using System;
using System.Globalization;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            //Adicionando produtos ao estoque
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            //Removendo produtos do estoque
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            int qtd1 = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd1);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
