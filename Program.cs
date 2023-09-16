using System;

class Program
{
    static void Main()
    {
        bool jatkaPelia = true;

        while (jatkaPelia)

        {

            string paakaupunki = "Vilna";
            string guess = "";
            int arvausLkm = 0;
            int arvausMax = 3;
            bool arvauksetLoppu = false;

            Console.WriteLine("*** Pääkaupunkivisa ***");
            Console.WriteLine("Mikä on Liettuan pääkaupunki?");
            Console.WriteLine("Huom, 3 yritystä");
            Console.WriteLine(" ");



            while (guess != paakaupunki && !arvauksetLoppu)
            {

                if (arvausLkm < arvausMax)
                {
                    Console.Write("Arvaus: ");
                    guess = Console.ReadLine();
                    arvausLkm++;

                }
                else
                {
                    arvauksetLoppu = true;
                    Console.WriteLine(" ");
                    Console.WriteLine("Hävisit pelin :(");
          

                }
                if (guess == paakaupunki)
                Console.Write("Oikein!");
              


            }

            Console.WriteLine(" ");
            Console.WriteLine("Pelataanko uudelleen? (K/E): ");
            string response = Console.ReadLine();
            if (response != "K")
            {
                jatkaPelia = false;
                Console.WriteLine("Kiitos pelistä!");
            }


            Console.ReadLine();
        }
    }

}