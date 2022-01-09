using System;

class Program
{
    public static void Main(string[] args)
    {
        Shinobi shinobi = new Shinobi("Flavio", "22", "Konoha");

        Console.WriteLine(shinobi.nome);
        Console.Read();
    }
}