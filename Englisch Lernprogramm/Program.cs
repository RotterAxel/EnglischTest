using Englisch_Lernprogramm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Englisch_Lernprogramm
{
    class Program
    {
        private static readonly Random rand = new Random();

        static void Main(string[] args)
        {
            //string[] englishExpression = new string[] {"reliability",
            //                                            "cancellations",
            //                                            "luggage",
            //                                            "coach class",
            //                                            "delay",
            //                                            "dissatisfaction",
            //                                            "irritability",
            //                                            "disruptive",
            //                                            "steep climb",
            //                                            "to stem from",
            //                                            "interminable",
            //                                            "to be cooped up",
            //                                            "tarmac",
            //                                            "convict",
            //                                            "to be at fault",
            //                                            "valuable",
            //                                            "to soar",
            //                                            "to be reflected in something",
            //                                            "stiffer penalties",
            //                                            "offender",
            //                                            "legislation",
            //                                            "to deny something",
            //                                            "to contribute something",
            //                                            "concessions",
            //                                            "to attend a meeting",
            //                                            "accident",
            //                                            "fashion collection",
            //                                            "to be engaged",
            //                                            "to reschedule an appointment",
            //                                            "subsidiary" };

            string[] englishExpression = new string[] {"confidentiality",
                                                        "a subsidiary",
                                                        "a warehouse",
                                                        "plant",
                                                        "bureaucratic",
                                                        "hierarchichal",
                                                        "a distribution centre",
                                                        "the stock level",
                                                        "to abolish something",
                                                        "perks",
                                                        "to negotiate something",
                                                        "accountability",
                                                        "a performance measure",
                                                        "customer satisfaction",
                                                        "headquarters",
                                                        "a trade union",
                                                        "data processing",
                                                        "the boardroom",
                                                        "the filing cabinet",
                                                        "a letter of credit",
                                                        "a business card",
                                                        "the Chief Executive Officer",
                                                        "business hours",
                                                        "a good reputation",
                                                        "reliability",
                                                        "a public limited company",
                                                        "to hire somebody",
                                                        "a performance report",
                                                        "cutting-edge technology",
                                                        "the workforce" };

            //string[] germanExpression = new string[] {"die Zuverlässigkeit",
            //                                            "die Stornierungen",
            //                                            "das Gepäck",
            //                                            "die Touristenklasse",
            //                                            "die Verspätung",
            //                                            "die Unzufriedenheit",
            //                                            "die Reizbarkeit",
            //                                            "störend",
            //                                            "ein steiler Aufstieg",
            //                                            "in etwas seine Ursache haben",
            //                                            "langwierig",
            //                                            "eingepfercht sein",
            //                                            "die Start- und Landebahn",
            //                                            "der Sträfling",
            //                                            "die Schuld tragen",
            //                                            "teuer",
            //                                            "aufsteigen",
            //                                            "sich in etwas Wiederspiegeln",
            //                                            "härtere Strafen",
            //                                            "der Täter",
            //                                            "die Gesetzgebung",
            //                                            "etwas zurückweisen",
            //                                            "etwas beitragen",
            //                                            "die Zugeständnisse",
            //                                            "an einer Besprechung teilnehmen",
            //                                            "der Unfall",
            //                                            "die Modekollektion",
            //                                            "besetzt sein",
            //                                            "einen Termin verschieben",
            //                                            "die Tochtergesellschaft"
            //                                            };

            string[] germanExpression = new string[] {"die Vertraulichkeit",
                                                        "eine Tochtergesellschaft",
                                                        "ein Lager",
                                                        "eine Fabrikanlage",
                                                        "bürokratisch",
                                                        "hierarchisch",
                                                        "eine Vertriebszentrale",
                                                        "der Lagerbestandlauf",
                                                        "etwas abschaffen",
                                                        "freiwillige Sozialleistungen",
                                                        "etwas verhandeln",
                                                        "Verantwortung",
                                                        "eine Erfolgsmessgrösse",
                                                        "die Kundenzufriedenheit",
                                                        "die Zentrale",
                                                        "eine Gewwerkschafft",
                                                        "Informationsverarbeitung",
                                                        "das Sitzungszimmer des Aufsichtsrats",
                                                        "der Aktenschrank",
                                                        "ein Akkreditiv",
                                                        "eine Visitenkarte",
                                                        "der Geschäftsführer",
                                                        "die Öffnungszeiten",
                                                        "ein guter Ruf",
                                                        "die Zuverlässigkeit",
                                                        "eine Aktiengesellschaft",
                                                        "jemanden einstellen",
                                                        "ein Leistungsbericht",
                                                        "Spitzentechnik",
                                                        "die Belegschaft"
                                                        };
            Console.WriteLine("========================================================================");
            Console.WriteLine("WILLKOMMEN BEI DEINEM ENGLISCH LERNPROGRAMM FÜR EIN EINZIGES VOKABELTEST");
            Console.WriteLine("Schreiben sie die von dem erscheinendem Wort zugehörige Vokabel.");
            Console.WriteLine("========================================================================");
            bool exit = false;
            bool quit = false;
            int temp;
            string input;
            string guess;
            List<int> germanCollection = new List<int>();
            List<int> englischCollection = new List<int>();

            while (!quit)
            {
                for (int i = 0; i < 15; ++i)
                {
                    germanCollection.Add(i);
                    englischCollection.Add(i);
                }
                #region MainGame
                while (!exit)
                {
                    temp = rand.Next(1, 3);

                    if (englischCollection.Count() == 0 && germanCollection.Count() == 0) exit = true;

                    if (temp == 1)
                    {
                        if (germanCollection.Count() == 0) return;
                        temp = rand.Next(0, germanCollection.Count());
                        Console.WriteLine(germanExpression[temp]);
                        guess = Console.ReadLine();

                        if (guess == englishExpression[temp])
                        {
                            Console.WriteLine("CORRECT");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            germanCollection.Remove(temp);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("======INCORRECT======");
                            Console.WriteLine("The correct guess was:    " + englishExpression[temp]);
                            Console.WriteLine("");
                        }

                    }
                    else
                    {
                        if (englischCollection.Count() == 0) return;
                        temp = rand.Next(0, englischCollection.Count());
                        Console.WriteLine(englishExpression[temp]);
                        guess = Console.ReadLine();

                        if (guess == germanExpression[temp])
                        {
                            Console.WriteLine("CORRECT");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            englischCollection.Remove(temp);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("======INCORRECT======");
                            Console.WriteLine("The correct guess was:    " + germanExpression[temp]);
                            Console.WriteLine("");
                        }
                    }

                }
                #endregion
                Console.WriteLine("Congratulations on finishing the entire vocabulary list");
                Console.WriteLine("Would you like to play again? (Y/N?): ");
                input = Console.ReadLine();
                input = input.ToLower();
                if(input == "n")
                {
                    quit = true;
                }
                Console.WriteLine();
            }
        }

       
    }
}
