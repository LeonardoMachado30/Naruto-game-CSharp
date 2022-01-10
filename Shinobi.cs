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

    public List<int> Skills(int chakara = 0, int velocidade = 0, int forca = 0, int area = 0)
    {
        var result = new List<int> { chakara, velocidade, forca, area };
        
        return result;
    }
}