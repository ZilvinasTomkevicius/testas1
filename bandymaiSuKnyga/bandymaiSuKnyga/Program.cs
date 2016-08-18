using System;
public class Bandymas
{
    public static int Main(string[] args)
    {
        Console.WriteLine("iveskite produktus per kableli");
        string produktai = Console.ReadLine();

        int produktuSkaicius = 0;

        foreach(char kablelis in produktai)
        if (kablelis == ',') produktuSkaicius++;

        produktuSkaicius = produktuSkaicius +1;

        Console.WriteLine("ivesti produktai: " + produktai + " prodouktu skaicius: " + produktuSkaicius);
        Console.ReadKey();
       


        return 0;

    }
}
   



