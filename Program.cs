using System;

class Program
{
    public static void Main(string[] args)
    {
        Shinobi shinobi = new Shinobi("Flavio", "22", "Konoha", "Sharingan");
        string[] allValues = { shinobi.nome, shinobi.idade, shinobi.cidade, shinobi.poder };

        foreach (var v in allValues)
        {
            Console.WriteLine(v);
        }
        Console.Read();
    }
}