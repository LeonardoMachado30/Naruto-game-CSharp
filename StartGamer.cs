using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartGamer {
    //CONSTRUTOR
    public StartGamer() {

        string name = ProfileUser();

        SelectCharacter(name);

        Console.Read();
    }
    //CADASTRO DE PERFIL
    public string ProfileUser() {
        string tab = "\t";
        bool onlyLettersBool = false;
        string name = "";

        //Caso o usuario digite algum numero no nome, precisara digitar novamente
        do {
            Console.Clear();//Limpa o console

            Console.ForegroundColor = ConsoleColor.Yellow;//COR DE AVISO AVISO
            Console.WriteLine($"{tab}OBS: Não insira caracteres especiais \n{tab}Não insira numeros \n{tab}Nome deve ter menos de 10 caracteres ");

            Console.ForegroundColor = ConsoleColor.White;//Volta a cor padrão do console
            Console.Write($"{tab}Digite seu nome: ");

            name = Console.ReadLine();

            //Regex que valida somente letras
            Regex onlyLetters = new Regex(@"[a-zA-Z]+.[a-zA-Z]+");
            onlyLettersBool = onlyLetters.IsMatch(name);

            if (!onlyLettersBool) {
                Console.ForegroundColor = ConsoleColor.Red;//Muda cor da fonte do console para vermelho
                Console.WriteLine($"{tab}Digite seu nome sem numeros!");
                Console.WriteLine($"{tab}Precione qualquer botão para continuar...");
                Console.ReadLine();
            }

        } while (!onlyLettersBool);

        Console.WriteLine($"\n{tab}{tab} Nome: {name}\n");
        return name;
    }

    public void SelectCharacter(string name) {
        Console.Clear();//Limpa o console

        string tab = "\t";
        int press = 0;
        string[] chapters = { "Naruto", "Sasuke", "Kakashi" };

        do {
            Console.WriteLine($"{tab}SEJA BEM VINDO AO MUNDO DE NARUTO {name}\n");
            Console.WriteLine($"{tab}Escolha qual Shinobi voce quer: ");

            //"for" feito para interar os personagens
            for (int i = 0; i < chapters.Length; i++) {
                Console.WriteLine($"{tab}{i+1} - {chapters[i]}");
            }

            Console.Write($"{tab}-> ");

            press = Convert.ToInt32(Console.ReadLine());

            switch (press) {
                case 1:
                    Shinobi Naruto = new Shinobi("Naruto");

                    Console.WriteLine(Naruto.name);
                    break;
                case 2:
                    Shinobi Sasuke = new Shinobi("Sasuke");

                    Console.WriteLine(Sasuke.name);
                    break;
                case 3:
                    Shinobi Kakashi = new Shinobi("Kakashi");

                    Console.WriteLine(Kakashi.name);
                    break;
                default:
                    Console.WriteLine("Digite um personagem valido");
                    break;
            }
        } while (press > 3);
    }

    //Mudando estrutura padrão
    public void print(string str) {
        Console.WriteLine(str);
    }
}
