using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Lampada
{
    private bool Ligada;

    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("a lampada foi ligada.");
    }

    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("a lampada foi desligada.");
    }

    public void MostrarEstado()
    {
        if (Ligada)
            Console.WriteLine("a lampada esta ligada.");
        else
            Console.WriteLine("a lampada esta desligada.");
    }
}
