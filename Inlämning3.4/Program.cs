using System;
namespace inlämning3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till vår Radiostation!");
            Console.WriteLine("Vi har några krav om din önskelåt ska spelas.");
            Console.WriteLine("Hur lång är din låt? Svara i minuter och sekunder.");
            Console.Write("Minuter: ");
            int minut = int.Parse(Console.ReadLine());
            Console.Write("Sekunder: ");
            int sekund = int.Parse(Console.ReadLine());

            int totalsekund = minut * 60 + sekund;
            int minst = 2 * 60 + 45;
            int max = 4 * 60 + 20;

            if (totalsekund >= minst && totalsekund <= max)
            {
                Console.WriteLine("Din låt när våra krav!");
            }
            else
            {
                Console.WriteLine("Din låt når inte våra krav");
            }
        }
    }
}