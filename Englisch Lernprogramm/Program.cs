﻿using Englisch_Lernprogramm;
using System;
using System.Linq;

namespace Englisch_Lernprogramm
{
    class Program
    {
        private static readonly Random rand = new Random();

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
                                                        "tarmac",
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
                                                        "concessions",
                                                        "to attend a meeting",
                                                        "accident",
                                                        "fashion collection",
                                                        "to be engaged",
                                                        "to reschedule an appointment",
                                                        "subsidiary" };

            string[] germanExpression = new string[] {"die Zuverlässigkeit",
                                                        "die Stornierungen",
                                                        "das Gepäck",
                                                        "die Touristenklasse",
                                                        "die Verspätung",
                                                        "die Unzufriedenheit",
                                                        "die Reizbarkeit",
                                                        "störend",
                                                        "ein steiler Aufstieg",
                                                        "in etwas seine Ursache haben",
                                                        "langwierig",
                                                        "eingepfercht sein",
                                                        "die Start- und Landebahn",
                                                        "der Sträfling",
                                                        "die Schuld tragen",
                                                        "teuer",
                                                        "aufsteigen",
                                                        "sich in etwas Wiederspiegeln",
                                                        "härtere Strafen",
                                                        "der Täter",
                                                        "die Gesetzgebung",
                                                        "etwas zurückweisen",
                                                        "etwas beitragen",
                                                        "die Zugeständnisse",
                                                        "an einer Besprechung teilnehmen",
                                                        "der Unfall",
                                                        "die Modekollektion",
                                                        "besetzt sein",
                                                        "einen Termin verschieben",
                                                        "die Tochtergesellschaft"
                                                        };
            Console.WriteLine("========================================================================");
            Console.WriteLine("WILLKOMMEN BEI DEINEM ENGLISCH LERNPROGRAMM FÜR EIN EINZIGES VOKABELTEST");
            Console.WriteLine("Schreiben sie die von dem erscheinendem Wort zugehörige Vokabel.");
            Console.WriteLine("========================================================================");
            bool exit = false;
            int temp;
            string guess;

            while (!exit)
            {
                temp = rand.Next(1, 3);

                if (temp == 1)
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
