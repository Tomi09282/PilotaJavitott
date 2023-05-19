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
        nemzet();
        rajtszam();
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
        string lname = lista.Last().name; //visszaadja a listában az utolsó nevet
        Console.WriteLine($"4f: {lname}");

    }

    public static void rajtszam()
    {
        var query = ( // Kiválasztja azokat a sorokat ahol a rajtszám nagyobb mint 0 rajtszám szerint a számok listába
        from sor in lista where sor.rszam > 0 group sor by sor.rszam into szamok where szamok.Count() > 1 select szamok.Key);

        Console.Write($"7f:");
        foreach (var i in query)
        {
            Console.Write($" {i} ");
        }
        Console.WriteLine();

    }
    
    public static void nemzet()
    {
        
        var nemzet = (   // Kiválasztja azt a sort a listából ahol a rajtszám 0 rszam szerint a nemzetiséget
            from sor in lista where sor.rszam > 0 orderby sor.rszam select sor.nemzet).First(); //.first -> Első eleme a listának
        Console.WriteLine($"6f: {nemzet}");

    }


}
