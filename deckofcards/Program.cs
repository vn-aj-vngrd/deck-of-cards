using System;
using System.Linq;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            while (true)
            {
                try
                {
                    string choice = app.Choice();
                    switch (Int32.Parse(choice))
                    {
                        case 1:
                            app.CreateDeck();
                            break;
                        case 2:
                            app.ShuffleDeck();
                            break;
                        case 3:
                            Console.Write("How many? ");
                            string num = Console.ReadLine();
                            try
                            {
                                app.Deal(Int32.Parse(num));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Please input a number.");
                            }
                            break;
                        case 4:
                            app.DisplayDeck();
                            break;
                        default:
                            Console.WriteLine("Please input a valid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please input a valid choice.");
                }

                Console.WriteLine("");
            }
        }
    }
}
