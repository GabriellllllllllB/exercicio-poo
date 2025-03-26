using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aluno
{
    public string ra;
    public string nome;
    public double notaprova;
    public double notatrabalho;
    public double notafinal;

    public void dados()
    {

        Console.WriteLine("escreva o RA do aluno");
        ra = Console.ReadLine();
        Console.WriteLine("escreva o nome do aluno");
        nome = Console.ReadLine();
        Console.WriteLine("escreva o valor da nota da prova");
        notaprova = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("escreva o valor da nota do trabalho");
        notatrabalho = Convert.ToDouble(Console.ReadLine());

    }
    public void media()
    {
        notafinal = (notaprova + notatrabalho) / 2;
    }
    public void notaf()
    {
        if (notafinal >= 6.0)
        {
            Console.WriteLine($" {nome} {ra} aprovado, média {notafinal:F2}.");
        }
        else
        {
            double notamedia = 12;
            notamedia = 12 - notafinal;
            Console.WriteLine($"aluno {nome} (ra: {ra}) precisa de {notamedia:F2} na prova final.");
        }
    }
}




