using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tiedosto_teht_1
{
    class tiedosto
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"anna tiedoston nimi: ");
            string nimi = Console.ReadLine();
            if (File.Exists(nimi))
            {
                Console.WriteLine("tiedosto " + nimi + " on olemassa");
            }
            else
            {
                Console.WriteLine("tiedostoa " + nimi+ " ei ole olemassa");
            }
            string reitti = "F:/tiedostoteht2/teksti1.txt";
            if (!File.Exists(reitti))
            {


                TextWriter kyl = new StreamWriter(reitti);
                kyl.WriteLine("hello world");
                kyl.Close();
            }
            else
            {
                TextWriter kyl = new StreamWriter(reitti);
                kyl.WriteLine("hello again");
                kyl.WriteLine("uusi rivi tässä");
                kyl.Close();

            }
            string sisalto = File.ReadAllText("F:/tiedostoteht2/teksti1.txt");
            Console.WriteLine("tiedostossa lukee "+sisalto);
            List<string> Lista = new List<string>();
            Lista = (List<string>)Lista.Append(sisalto);
            Console.WriteLine(Lista);

           
            




        }
    }
}
