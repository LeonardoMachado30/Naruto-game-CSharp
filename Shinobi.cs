using System;
using System.Collections.Generic;

class Shinobi
{
    public string nome = "";
    public string idade = "";
    public string cidade = "";
    public string poder = "";

    public int chakara = 0;
    public int velocidade = 0;
    public int forca = 0;
    public int area = 0;
    public Shinobi(string nome, string idade, string cidade, string poder = "")
    {
        this.nome = nome;
        this.idade = idade;
        this.cidade = cidade;
        this.poder = (poder != "" ? poder : "");
    }


}