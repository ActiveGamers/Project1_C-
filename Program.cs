using System;

namespace ali_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ali Joooon Saat Morede Nazaret Ro Vared Bokon:");
            int ClockAli = Convert.ToInt32(Console.ReadLine());

            if (ClockAli >= 0 && ClockAli <= 6)
            {
                Console.WriteLine("Nime Shab Be Kheir");
            }
            else if (ClockAli >= 6 && ClockAli <= 12)
            {
                Console.WriteLine("Sobh Be Kheir");
            }
            else if (ClockAli >= 12 && ClockAli <= 18)
            {
                Console.WriteLine("Bade Zohr Be Kheir");
            }
            else if (ClockAli >= 18 && ClockAli <= 24)
            {
                Console.WriteLine("Shab Be Kheir, Boro Begir Bekhab");
            }
            else
            {
                Console.WriteLine("Ali Jan, Saat Dorost Ro Vared Benamie");
            }

        }
    }
}
