using System;

namespace stato_serra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la temperatura della serra:  ");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura < 5)
                Console.Write("La serra ha dei danni irreparabili");
            else if (temperatura > 5 && temperatura < 18)
                Console.Write("La serra è in una situazione di pericolo");
            else
                Console.Write("La serra ha una temperatura normale");
            Console.ReadLine();
        }
    }
}
