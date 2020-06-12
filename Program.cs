using System;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância com o método construtor sem argumentos
            Criatura sapato = new Criatura();

            // Instância da sobrecarga do método construtor com 1 argumento
            Criatura Grifo = new Criatura(165);
            System.Console.WriteLine(Grifo.Codigo);


            System.Console.WriteLine();

            // Instância com todos os atributos
            Criatura tenis = new Criatura(165, "Grifo", "Chamas", 99);
            System.Console.WriteLine(tenis.Codigo);
            System.Console.WriteLine(tenis.Nome);
            System.Console.WriteLine(tenis.Descricao);
            System.Console.WriteLine(tenis.Vida);

        }
    }
}
