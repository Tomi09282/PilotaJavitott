using System;                     
using System.IO;                 
using System.Text;                
using System.Collections.Generic; 
using System.Linq;               
using ConsoleApp7;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Beolvas();
        darab();
        utolsonev();
        szazad();
    }





    static List<Pilota> lista = new List<Pilota>();
    public static void Beolvas()
    {

        var f = new StreamReader("pilotak.csv", Encoding.UTF8);
        string elso = f.ReadLine(); //lehagyja az elso sort

        while (!f.EndOfStream)
        {
            lista.Add(new Pilota(f.ReadLine()));
        }
        f.Close();
    }




    public static void darab()
    {
        Console.WriteLine($"3f: {lista.Count}");

    }



    public static void szazad() {
        var ev = ( //Kiválasztja a 1901 előtt született neveket
        from sor in lista
        where sor.year < 1901
        select (sor.name, sor.szuletes)
        );
        Console.WriteLine($"5f: ");
        foreach (var sor in ev)
        {
            Console.WriteLine($"{sor.name}, [{sor.szuletes}] ");
        }
    }
    public static void utolsonev()
    {
        string lname = lista.Last().name;
        Console.WriteLine($"4f: {lname}");

    }




}