using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BS
{
    class Program
    {
        static List<int> tab = new List<int>();
        static int sizeParsed;
        static void Main(string[] args)
        {

            do
            {

                bool tryParseSize;
                do
                {

                    Console.WriteLine("Wprowadź długość tablicy");
                    //int size = int.Parse(Console.ReadLine());

                    var input = Console.ReadLine();
                    //int sizeParsed;
                    tryParseSize = int.TryParse(input, out sizeParsed);
                    List<int> tab = new List<int>(sizeParsed);

                    if (!tryParseSize)
                    {
                        Console.WriteLine("Nieprawidłowa długość tablicy");
                    }

                }
                while (!tryParseSize);


                bool tryParse = false;
                int parsedvalue;
                Console.WriteLine("Aby wyjśc z programu wpisz \"exit\" ");


                for (int i = 0; i < sizeParsed; i++)
                {
                    Console.WriteLine("Wprowadź wartość do tablicy");
                    do
                    {
                        var output = Console.ReadLine();
                        tryParse = int.TryParse(output, out parsedvalue);



                        if (!tryParse)
                        {
                            Console.WriteLine("wprowadziłeś zły format!");

                        }


                    }
                    while (!tryParse);

                    tab.Add(parsedvalue);
                }






                Console.WriteLine("tablica przed posortowaniem");

                foreach (var item in tab)
                {

                    Console.WriteLine(item);
                }

                for (int z = 0; z < tab.Count; z++)
                {
                    for (int t = 0; t < tab.Count - 1; t++)
                    {
                        if (tab[t] > tab[t + 1])
                        {
                            int tmp = tab[t];
                            tab[t] = tab[t + 1];
                            tab[t + 1] = tmp;

                        }

                    }
                }
                Console.WriteLine("Tablica po posortowaniu");
                for (int v = 0; v < tab.Count; v++)
                {
                    Console.WriteLine(tab[v]);
                }
                string exit = Console.ReadLine();
                Console.Clear();
                if (exit == "exit")
                {
                    break;
                }
                else { continue; }

            }
            while (true);

        }

    }
}
