using System;


class Shinobi
{
    public string nome = "";
    public string idade = "";
    public string cidade = "";
    public string poder = "";
    public Shinobi(string nome, string idade, string cidade, string poder = "")
    {
        this.nome = nome;
        this.idade = idade;
        this.cidade = cidade;
        this.poder = (poder != "" ? poder : "");
    }
}