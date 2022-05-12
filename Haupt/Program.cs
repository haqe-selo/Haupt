// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main()
    {
        do
        {
            string[] vn = { "John", "Paul", "George", "Ringo" };
            string[] nn = { "Lennon", "McCartney", "harrison", "Starr" };
            short[] ün = { 1, 4, 12, 3 };
            short[] zn = { 45, 23, 3, 32 };
            double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

            Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein");
            string eingabe_str = Console.ReadLine();
            short eingabe_short;
            
            bool flag = short.TryParse(eingabe_str, out eingabe_short);
            if (flag == true)
            {
                var data = GetData(eingabe_short, vn, nn, ün, zn, rechnungsbetrag);
                if (data.Item1 == true)
                {
                    Console.WriteLine($"{data.Item2},{data.Item3},{data.Item4},{data.Item5},{data.Item6},");
                }
                else
                {
                    Console.WriteLine("FEHLER!");
                }
            }
            else
            {
                var data = GetData(eingabe_short, vn, nn, ün, zn, rechnungsbetrag);
                if (data.Item1 == false)
                {
                    
                }
                else
                {
                    Console.WriteLine("FEHLER!");
                }



            }
        } while (true);

    }

    static (bool, string, string, short, short, double) GetData(string diff, string[] vn, string[] nn, short[] ün, short[] zn, double[] rb)
    {
        bool EI = false;
        int index = 0;

        for (int i = 0; i < nn.Length; i++)
        {
            if (diff == nn[i])
            {

                index = i;
                EI = true;
            }

        }


        return (EI, vn[index], nn[index], ün[index], zn[index], rb[index]);
    }

    static (bool, string, string, short, short, double) GetData(short diff, string[] vn, string[] nn, short[] ün, short[] zn, double[] rb)
    {
        bool EI = false;
        int index = 0;
        
        for (int i = 0; i < zn.Length; i++)
        {
            if (diff == zn[i])
            {

                index = i;
                EI = true;
            }

        }


        return (EI, vn[index], nn[index], ün[index], zn[index], rb[index]);
    }
}
      


