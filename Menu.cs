using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Menu
{
    public Menu()
    {
        Console.WriteLine("MENU INICIAL" + "\n\n");
        Console.WriteLine("1 -INICIAR JOGO");
        Console.WriteLine("2 - OPÇÔES");
        Console.WriteLine("3 - SAIR");
        int press1 = Convert.ToInt32(Console.ReadLine());

        switch (press1)
        {
            case 1:
                StartGamer startGamer = new StartGamer();

                Console.WriteLine(startGamer);
                break;
            case 2:
                break;
            case 3:
                break;
        }

    }
}
