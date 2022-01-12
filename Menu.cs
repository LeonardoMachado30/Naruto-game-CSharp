using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Menu
{
    public Menu()
    {
        string tab = "\t";

        Console.WriteLine($"{tab}{tab}MENU INICIAL" + "\n\n");
        Console.WriteLine($"{tab}1 - INICIAR JOGO");
        Console.WriteLine($"{tab}2 - OPÇÔES");
        Console.WriteLine($"{tab}3 - SAIR");
        Console.Write($"{tab}->");
        int press = Convert.ToInt32(Console.ReadLine());

        switch (press)
        {
            case 1:
                StartGamer startGamer = new StartGamer();

                Console.WriteLine(startGamer);

                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.Blue;
                break;
            case 3:
                break;
        }

    }
}
