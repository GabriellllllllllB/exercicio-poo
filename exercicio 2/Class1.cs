using System;

public class Contabancaria
{
    public string numeroconta;
    public string titular;
    public double saldo;

    public void Depositar(double valor)
    {
        if (valor > 0) 
        {
            saldo += valor; 
            Console.WriteLine($"R${valor} depositado");
        }
    }

    public void sacar(double valor)
    {
        if (valor > 0) 
        {
            if (saldo >= valor) 
            {
                saldo -= valor;
                Console.WriteLine($"R${valor} sacado");
            }
            else
            {
                Console.WriteLine("sem saldo");
            }
        }
    }
    public void exibir()
    {
        Console.WriteLine($"R${saldo}");
    }
}
