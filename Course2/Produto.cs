using System.Globalization;

namespace Course2
{
    class Produto
    {
        //Nome de atributo sempre começa com letra maiúscula
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            //CultureInfo.InvariantCulture serve para usar o ponto como separador de decimais
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $" +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
