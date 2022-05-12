using System;

class Program
{
    public static void Main()


    {
        Console.WriteLine("Geben Sie bitte ein Wort ein ");
        string n = (Console.ReadLine());
        Console.WriteLine("Geben Sie bitte  ein Zahl ein  ");
        int m = Convert.ToInt32(Console.ReadLine());
        int anzahl = 0;

        anzahl = ausgabeTextMalX(n, m);


        Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);  // Das wurde vom Herrn Salo programiert//

    }
    static int ausgabeTextMalX(string name, int zahl)
    {
        for (int i = 0; i < zahl; i++)
        {

            Console.WriteLine(name);


        }


        return zahl * name.Length;
    }


}