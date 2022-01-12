using System;
using System.Collections.Generic;

public class StartGamer
{
	public StartGamer()
	{
        #region
        /*Console.Write($"{tab}Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());*/

        /*Console.WriteLine($"\n{tab}De onde voce e: ");
        Console.WriteLine($"{tab}1 - Folha ");
        Console.WriteLine($"{tab}2 - Pedra ");
        Console.WriteLine($"{tab}3 - Areia");
        Console.WriteLine($"{tab}4 - Nevoa");
        Console.Write($"{tab}->");
        int local = Convert.ToInt32(Console.ReadLine());*/

        /*Console.Write($"{tab}Digite seu Kaikenkenkai: ");
        string kaikenkenkai = Console.ReadLine();*/
        #endregion
        Profile();

        Console.Read();
    }

    public void Profile() {
        string tab = "\t";
        Console.Write($"{tab}Digite seu nome: ");
        string name = Console.ReadLine();

        Shinobi shinobi1 = new Shinobi(name);

        Console.Write($"\t|\t Nome: {shinobi1.name}");
        Console.Write($"\t|\t idade: {shinobi1.age}");
        Console.Write($"\t|\t cidade: {shinobi1.local}");
        Console.Write($"\t|\t poder: {shinobi1.power}");
    }
}
