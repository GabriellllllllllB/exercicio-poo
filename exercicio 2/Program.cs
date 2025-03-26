using System;

class Program
{
    static void Main(string[] args)
    {
        Contabancaria conta = new Contabancaria();

            
        int opcao = 0;

        while (opcao != 4) 
        {


            Console.WriteLine("menu de opções:");
            Console.WriteLine("1 - depositar");
            Console.WriteLine("2 - sacar");
            Console.WriteLine("3 - exibir saldo");

            Console.Write("escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("escreva o valor do deposito: R$ ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                    
                case 2:
                    Console.Write("escreva o valor do saque: R$ ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.sacar(valorSaque);
                    break;
                case 3:
                    conta.exibir();
                    break;
                default:
                    Console.WriteLine("tente outra opção");
                    break;

            }

        } 
    }
}
