using System;

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();
        int opcao;

        do
        {
            Console.WriteLine("menu da lampada:");
            Console.WriteLine("1 ligar a lampada");
            Console.WriteLine("2 desligar a lampada");
            Console.WriteLine("3 mostrar estado da lampada");
            Console.Write("escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        lampada.Ligar();
                        break;
                    case 2:
                        lampada.Desligar();
                        break;
                    case 3:
                        lampada.MostrarEstado();
                        break;
                }
            
            }
        } while (opcao != 0);
    }
}