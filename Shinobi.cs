using System;
using System.Collections.Generic;

class Shinobi
{
    public string name = "";
    public int age = 0;
    public string local = "";
    public string power = "";

    public int chakara = 0;
    public int velocidade = 0;
    public int forca = 0;
    public int area = 0;

    public Shinobi(string name, int age, int local, string power = "")
    {
        this.name = name;
        this.age = age;

        if(local == 1) {
            this.local = "Folha";
        }else if(local == 2) {
            this.local = "Pedra";
        }else if(local == 3) {
            this.local = "Areia";
        }else if(local == 4) {
            this.local = "Nevoa";
        }

        this.power = (power != "" ? power : "");
    }


}