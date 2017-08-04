using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok
{
	class Program
	{
        public abstract class Character_Class
        {
            int max_hp;
        }
        class Item_Name
        {
            public string item_name { get; set; }
            public int item_amount { get; set; }
        }
        class Item_Menu
        {
            Dictionary<string , int> item_menu = new Dictionary<string , int>()
            { }
        }

        static void Main(string[] args)
		{
			Console.WriteLine("	 ______   _______ _______ __    _ _______ ______   _______ ___   _ "); //Title Block
			Console.WriteLine("	|    _ | |   _   |       |  |  | |   _   |    _ | |       |   | | |");
			Console.WriteLine("	|   | || |  |_|  |    ___|   |_| |  |_|  |   | || |   _   |   |_| |");
			Console.WriteLine("	|   |_||_|       |   | __|       |       |   |_||_|  | |  |      _|");
			Console.WriteLine("	|    __  |       |   ||  |  _    |       |    __  |  |_|  |     |_ ");
			Console.WriteLine("	|   |  | |   _   |   |_| | | |   |   _   |   |  | |       |    _  |");
			Console.WriteLine("	|___|  |_|__| |__|_______|_|  |__|__| |__|___|  |_|_______|___| |_|");
			Console.WriteLine("\n\nThe promised end is upon you\nSummon the courage to fight for your possibility of a future"); //Tagline
			Console.ReadKey();
			
			Console.Write("\nDo you need instuctions? Type 1 (yes) or 0 (no), then press enter:"); // instruction question

			bool instruct_loop = true; //This allows for my if/else statements to be nested inside of a while loop 
			while (instruct_loop) //The while loop is necessary to cycle back to the instruction question after the else condition
			{
				string instruct = Console.ReadLine();
				if (instruct == "1")
				{
                    Console.Write("\nIn this game you will have your choice of 3 classes:\n" +
                                    "BESERKER, WIZARD, or MONK\n" +
                                    "Engage is a desperate turn based battle to rid the world of\n" +
                                    "NIDHOGG: The source of decay and blight upon this land\n");
                    System.Threading.Thread.Sleep(4200); //provides a time interval before running the next line of code
                    Console.Write("------------------------\n" +
                                    "BERSERKER's main weapon is the sword\n" +
                                    "as Berserker uses the ATTACK command, it will build Rage and give access to\n" + 
                                    "more skills with the RAGE command\n" +
                                    "------------------------\n");
                    System.Threading.Thread.Sleep(4200);
                    Console.Write("WIZARD's main weapon is a Magic Staff\n" +
                                    "while the Wizard does not do much damage with the ATTACK command\n" +
                                    "Wizard does have access to damage dealing spells with the MAGIC command at the\n" +
                                    "cost of MP\n" +
                                    "------------------------\n");
                    System.Threading.Thread.Sleep(4200);
                    Console.Write("MONK's main weapon are martial arts\n" +
                                    "Monk has a special command named FOCUS\n" +
                                    "by using focus you can build SP that will give you access to more skills\n" +
                                    "with the ARTS command\n" +
                                    "------------------------\n\n");
                    System.Threading.Thread.Sleep(5000);
                    Console.Write("STEEL YOUR NERVE and CHOOSE YOUR PATH\n" + "Please press enter:");
					Console.ReadKey(instruct_loop = false); //So the loop ends once the user pressing a key to continue
				}
				else
				if (instruct == "0")
				{
					Console.Write("\n\nSTEEL YOUR NERVE and CHOSE YOUR PATH\n" + "Please press enter:");
					Console.ReadKey(instruct_loop = false);
				}
				else
				{
					Console.Write("THE PROPHECY IS WRITTEN IN STONE! Enter a proper response...");
					Console.Write("\n\nDo you need instuctions? Type 1 (yes) or 0 (no), then press enter:");
				}
			}
			Console.WriteLine("\nType 1 for BERSKER, Type 2 for WIZARD, Type 3 for MONK:");
			Console.ReadKey();


		}
	}
}
