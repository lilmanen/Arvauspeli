using System;

class Program
{
    static void Main()
    {
        string[] liiga = { "Italia", "Englanti", "Saksa", "Ranska", "Espania" };
        string[] mestari = { "Napoli", "Manchester City", "Bayern", "PSG", "Barcelona" };

        int maxAttempts = 3;
        bool playAgain = true;

        while (playAgain)
        {
            int correctAnswers = 0;

            Console.WriteLine(" ");
            Console.WriteLine("Arvaa maan jalkapalloliigan hallitseva mestari!");
            Console.WriteLine("Sinulla on kolme yritystä per maa");
            Console.WriteLine(" ");

            for (int i = 0; i < liiga.Length; i++)
            {
                int incorrectAttempts = 0;
                Console.WriteLine($"{i + 1}: Kuka voitti mestaruuden maassa: {liiga[i]}?");

                while (incorrectAttempts < maxAttempts)
                {
                    Console.Write("Arvaus ");
                    string userGuess = Console.ReadLine();

                    if (userGuess.Equals(mestari[i]))
                    {
                        Console.WriteLine("Oikein!");
                        correctAnswers++;
                        break;
                    }
                    else
                    {
                        incorrectAttempts++;
                        Console.WriteLine($"Väärin! Sinulla on {maxAttempts - incorrectAttempts} yritystä jäljellä.");
                    }
                }

                if (incorrectAttempts == maxAttempts)
                {
                    Console.WriteLine("Yritykset loppuivat.");
                    break;
                }
            }

            if (correctAnswers == liiga.Length)
            {
                Console.WriteLine("Onnittelut, tiesit kaikki!");
            }
            else
            {
                Console.WriteLine("Peli päättyi liian moneen väärään vastaukseen. Haluatko kokeilla uudelleen?");
            }

            Console.Write("Pelataanko uudelleen? (K/E): ");
            string playAgainResponse = Console.ReadLine();

            if (playAgainResponse != "K")
            {
                playAgain = false;
                Console.WriteLine("Kiitos ja näkemiin!");
            }
        }
    }
}