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
        Console.WriteLine("Escolha qual Shinobi voce quer: ");
        Console.WriteLine("1 - Naruto");
        Console.WriteLine("2 - Sasuke");
        Console.WriteLine("3 - Kakashi");
        Console.Write("-> ");
        
        int press = Convert.ToInt32(Console.ReadLine());
        
        switch (press) {
            case 1:
                Shinobi Naruto = new Shinobi("Naruto");
                break;
            case 2:
                Shinobi Sasuke = new Shinobi("Sasuke");
                break;
            case 3:
                Shinobi Kakashi = new Shinobi("Kakashi");
                break;
            default:
                break;
        }
        
        Console.Read();
    }

    public void Profile() {
        string tab = "\t";
        Console.Write($"{tab}Digite seu nome: ");
        string name = Console.ReadLine();


        Console.Write($"\t|\t Nome: {name}");
        //Console.Write($"\t|\t idade: {shinobi1.age}");
        //Console.Write($"\t|\t cidade: {shinobi1.local}");
        //Console.Write($"\t|\t poder: {shinobi1.power}");
    }
}
