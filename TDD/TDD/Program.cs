using TDD.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        var cafetera = new Cafetera(100); 
        var azucarero = new Azucarero(50); 
        var vasoPequeno = new Vaso("pequeño"); 
        var vasoMediano = new Vaso("mediano"); 
        var vasoGrande = new Vaso("grande");  

        var maquina = new MaquinaCafe(cafetera, azucarero, vasoPequeno, vasoMediano, vasoGrande);

        Console.WriteLine(maquina.GetVasoDeCafe("mediano", 1, 2));
        Console.WriteLine(maquina.GetVasoDeCafe("grande", 2, 3));
        Console.WriteLine(maquina.GetVasoDeCafe("pequeño", 5, 0));
        Console.WriteLine(maquina.GetVasoDeCafe("grande", 1, 5)); 
        Console.WriteLine(maquina.GetVasoDeCafe("pequeño", 10, 1)); 
    }
}