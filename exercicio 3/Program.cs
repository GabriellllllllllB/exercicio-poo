using System;

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        Console.Write("escreva o produto: ");
        produto.nome = Console.ReadLine();
        Console.Write("escreva o preço: ");
        produto.preço = Convert.ToDouble(Console.ReadLine());
        Console.Write("escreva a quantidade do estoque: ");
        produto.quantidade = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("escolha uma opcao:");
            Console.WriteLine("1 adicionar ao estoque");
            Console.WriteLine("2 remover do estoque");
            Console.WriteLine("3 exibir detalhes");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("escreva a quantidade que você deseja adicionar ao estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.adicionarestoque(quantidade);
            }
            else if (opcao == 2)
            {
                Console.Write("escreva a quantidade que você deseja remover do estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.removerestoque(quantidade);
            }
            else if (opcao == 3)
            {
                produto.exibirdetalhes();
            }
        }
    }
}