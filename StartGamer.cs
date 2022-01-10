using System;
using System.Collections.Generic;

public class StartGamer
{
	public StartGamer()
	{
        Shinobi shinobi1 = new Shinobi("Flavio", "22", "Konoha", "Sharingan");

        string[] allValues = { shinobi1.nome, shinobi1.idade, shinobi1.cidade, shinobi1.poder };

        foreach (var v in allValues)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("\n");

        var shinobis = new List<int> { };
        shinobis.AddRange(shinobi1.Skills(3));
        shinobis.AddRange(shinobi1.Skills(40));

        for (int i = 0; i < shinobis.Count; i++)
        {
            Console.WriteLine(shinobis[i]);
        }

        Console.Read();
    }
}
