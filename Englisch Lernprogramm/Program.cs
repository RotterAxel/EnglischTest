using System;
using System.Linq;

namespace Englisch_Lernprogramm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] englishExpression = new string[] {"reliability",
                                                        "cancellations",
                                                        "luggage",
                                                        "coach class",
                                                        "delay",
                                                        "dissatisfaction",
                                                        "irritability",
                                                        "disruptive",
                                                        "steep climb",
                                                        "to stem from",
                                                        "interminable",
                                                        "to be cooped up",
                                                        "tarmak",
                                                        "convict",
                                                        "to be at fault",
                                                        "valuable",
                                                        "to soar",
                                                        "to be reflected in something",
                                                        "stiffer penalties",
                                                        "offender",
                                                        "legislation",
                                                        "to deny something",
                                                        "to contribute something",
                                                        "concession",
                                                        "to attend a meeting",
                                                        "accident",
                                                        "fashion collection",
                                                        "engaged",
                                                        "to reschedule an appointment",
                                                        "subsidiary" };

            string[] germanExpression = new string[] {"Die Zuverlässigkeit",
                                                        "Die Stornierungen",
                                                        "Das Gepäck",
                                                        "Die Touristenklasse",
                                                        "Die Verspätung",
                                                        "Die Unzufriedenheit",
                                                        "Die Reizbarkeit",
                                                        "störend",
                                                        "ein steiler Aufstieg",
                                                        "in etwas seine Ursache haben",
                                                        "langwierig",
                                                        "eingepfercht sein",
                                                        "Die Start- und Landebahn",
                                                        "Der Sträfling",
                                                        "Die Schuld tragen",
                                                        "teuer",
                                                        "aufsteigen",
                                                        "sich in etwas Wiederspiegeln",
                                                        "härtere Strafen",
                                                        "Der Täter",
                                                        "Die Gesetzgebung",
                                                        "etwas zurückweisen",
                                                        "etwas beitragen",
                                                        "Die Zugeständnisse",
                                                        "an einem Gespräch tielnehmen",
                                                        "der Unfall",
                                                        "die Modekollektion",
                                                        "besetzt sein",
                                                        "einen Termin verschieben",
                                                        "Die Tochtergesellschaft"
                                                        };
            Console.WriteLine("========================================================================");
            Console.WriteLine("WILLKOMMEN BEI DEINEM ENGLISCH LERNPROGRAMM FÜR EIN EINZIGES VOKABELTEST");
            Console.WriteLine("Schreiben sie die von dem erscheinendem Wort zugehörige Vokabel.");
            Console.WriteLine("========================================================================");
            bool exit = false;

            while(!exit)
            {
                Random rand = new Random();
                int temp = rand.Next(1, 2);
                string guess;

                if(temp == 1)
                {
                    temp = rand.Next(0, 29);
                    Console.WriteLine(germanExpression[temp]);
                    guess = Console.ReadLine();

                    if (guess == englishExpression[temp])
                    {
                        Console.WriteLine("CORRECT");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("======INCORRECT======");
                        Console.WriteLine("The correct guess was:    " + englishExpression[temp]);
                    }

                }
                else
                {
                    temp = rand.Next(0, 29);
                    Console.WriteLine(englishExpression[temp]);
                    guess = Console.ReadLine();

                    if (guess == germanExpression[temp])
                    {
                        Console.WriteLine("CORRECT");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("======INCORRECT======");
                        Console.WriteLine("The correct guess was" + germanExpression[temp]);
                    }
                }

            }
        }
    }
}
