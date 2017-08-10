using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok
{
	class Program
	{
        public class Player
        {
			public int player_hp { get; set; }
			public int skill_points { get; set; }
			public int base_att_dmg { get; set; }
			public int player_dmg { get; set; }
		}

		static void Main(string[] args)
        {
			Console.ForegroundColor = ConsoleColor.DarkRed;//Font color
            Console.WriteLine("	 ______   _______ _______ __    _ _______ ______   _______ ___   _ "); //Title Block
            Console.WriteLine("	|    _ | |   _   |       |  |  | |   _   |    _ | |       |   | | |");
            Console.WriteLine("	|   | || |  |_|  |    ___|   |_| |  |_|  |   | || |   _   |   |_| |");
            Console.WriteLine("	|   |_||_|       |   | __|       |       |   |_||_|  | |  |      _|");
            Console.WriteLine("	|    __  |       |   ||  |  _    |       |    __  |  |_|  |     |_ ");
            Console.WriteLine("	|   |  | |   _   |   |_| | | |   |   _   |   |  | |       |    _  |");
            Console.WriteLine("	|___|  |_|__| |__|_______|_|  |__|__| |__|___|  |_|_______|___| |_|");
			Console.ForegroundColor = ConsoleColor.Gray;

			Console.WriteLine("\n\nThe promised end is upon you\nSummon the courage to fight for your possibility of a future"); //Tagline

			System.Threading.Thread.Sleep(2000);//provides a time interval before running the next line of code
			Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nDo you need instuctions? Type 1 (yes) or 0 (no), then press enter:"); //instruction question
			Console.ForegroundColor = ConsoleColor.Gray;

			bool instruct_loop = true; //This allows for my if/else statements to be nested inside of a while loop 
            while (instruct_loop) //The while loop is necessary to cycle back to the instruction question after the else condition
            {
                string instruct = Console.ReadLine();
                if (instruct == "1")
                {
                    Console.Write("\nIn this game you will have your choice of 3 classes:\n" +
                                    "BESERKER, WIZARD, or MONK\n" +
                                    "Engage is a desperate turn based battle to rid the world of\n" +
                                    "NIDHOGG: The source of decay and blight upon this land\n" +
									"Nidhogg is the dragon that threatens humanity as the prophecy demands\n");
                    System.Threading.Thread.Sleep(3000); 
                    Console.Write("------------------------\n" +
                                    "BERSERKER's main weapon is the sword\n" +
                                    "as Berserker uses the ATTACK command, it will build Rage and give access to\n" +
                                    "more skills with the RAGE command\n" +
									"SHOULDER CHARGE: attack with higher minimum damage base than regular attack\n" +
									"BLOODLUST: gains HP same as damage done to target\n" +
									"CHAOS BURST: high attack damage\n" +
                                    "------------------------\n");
                    System.Threading.Thread.Sleep(3000);
                    Console.Write("WIZARD's main weapon is a Magic Staff\n" +
                                    "while the Wizard does not do much damage with the ATTACK command\n" +
                                    "Wizard does have access to damage dealing spells with the MAGIC command at the\n" +
                                    "cost of MP\n" +
                                    "------------------------\n");
                    System.Threading.Thread.Sleep(3000);
                    Console.Write("MONK's main weapon are martial arts\n" +
                                    "Monk has a special command named HARNESS\n" +
                                    "by using harness you can build focus that will give you access to more skills\n" +
                                    "with the ARTS command\n" +
                                    "------------------------\n");
					System.Threading.Thread.Sleep(3000);
					Console.Write("Every character has access to 5 Potions and 1 Hi-Potion\n" +
									"Potions give 5,000 HP, Hi-Potion gives 10,000\n" +
									"Wizard is given 2 Ethers to gain 300 MP on use\n" +
									"------------------------\n\n");
					System.Threading.Thread.Sleep(4000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("STEEL YOUR NERVE and CHOOSE YOUR PATH\n");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Please press enter:");
					Console.ForegroundColor = ConsoleColor.Gray;
					instruct_loop = false; 
                }
                else
                if (instruct == "0")
                {
					System.Threading.Thread.Sleep(1000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("\nSTEEL YOUR NERVE and CHOSE YOUR PATH\n");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Please press enter:");
                    instruct_loop = false;
					Console.ForegroundColor = ConsoleColor.Gray;
				}
                else
                {
					System.Threading.Thread.Sleep(500);
					Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("\n\nDo you need instuctions? Type 1 (yes) or 0 (no), then press enter:");
					Console.ForegroundColor = ConsoleColor.Gray;
				}
            }
            string player_choice = Console.ReadLine(); //Need this variable declared in the main body for use with battle loop
            string path;
			System.Threading.Thread.Sleep(1000);
            bool player_select_loop = true;
            while (player_select_loop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nType 1 for BERSKER, Type 2 for WIZARD, Type 3 for MONK:");
                Console.ForegroundColor = ConsoleColor.Gray;
                player_choice = Console.ReadLine(); //declared in player select loop to give custom intro for battle to each character

                switch (player_choice)
                {
                    case "1": path = "------------------------\n" + "Blood Boiling, You approach Nighogg\n" + "------------------------"; player_select_loop = false; break;
                    case "2": path = "------------------------\n" + "Wise and Thoughtful, You approach Nidhogg\n" + "------------------------"; player_select_loop = false; break;
                    case "3": path = "------------------------\n" + "Centered and Focused, You approach Nidhogg\n" + "------------------------"; player_select_loop = false; break;
                    default: path = "\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"; break;
                }
                Console.Write(path);
            }

            

            Random r = new Random(); //generic random variable for dmg modifying
			
			Player Berserker = new Player();
			Player Wizard = new Player();
			Player Monk = new Player();

			Berserker.player_hp = 6500;//Berserker essentials
			Berserker.skill_points = 3;
			Berserker.base_att_dmg = 3420;
			
			Wizard.player_hp = 5050;//Wizard essentials
			Wizard.skill_points = 300;
			Wizard.base_att_dmg = 2101;

			Monk.player_hp = 7700;//Monk essentials
			Monk.skill_points = 10;
			Monk.base_att_dmg = 3778;

			int nidhogg_hp = 25000;//Nidhogg essentials
			int nidhogg_base_dmg = 3701;

			int potion_amt = 5;//item variables
			int hipotion_amt = 1;
			int ether_amt = 2;
			string item_choice;

			string player_action;//variable to take player's choice in the battle menu

			bool player_turn = true;//needed for switching between player and nidhogg turn

			while ((player_turn) & (Berserker.player_hp > 0 || Wizard.player_hp > 0 || Monk.player_hp > 0 || nidhogg_hp > 0))
			{
					switch (player_choice) //branches correctly for the character chosen
					{
			
								case "1"://Berserker battle loop
									while ((player_turn) & (Berserker.player_hp > 0))
									{
										System.Threading.Thread.Sleep(1000);
										Console.Write("\n------------------------\n");
										Console.WriteLine("Current HP: {0:N0}\t" + "Rage: {1}", Berserker.player_hp, Berserker.skill_points); 
										Console.Write("------------------------\n" +
														"1. ATTACK\n" + 
														"2. RAGE\n" + 
														"3. ITEM\n" +
														"------------------------\n");
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.Write("Type the corresponding number to the action you would like to execute:");
										Console.ForegroundColor = ConsoleColor.Gray;
										player_action = Console.ReadLine();
										switch (player_action)
										{
											case "1": //Berserker standard attack
												int physical_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .55) / 2 );
												nidhogg_hp -= physical_dmg;
												Berserker.skill_points++;
												Console.ForegroundColor = ConsoleColor.Cyan;
												Console.WriteLine("\nYou slashed Nidhogg for {0:N0} HP worth of damage!" , physical_dmg);
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("\nPLAYER TURN END: Press enter");
												Console.ForegroundColor = ConsoleColor.Gray;
												Console.ReadKey(player_turn = false);
												break;
											case "2": //Berserker Rage Skill Menu
												string berserker_rage_skill;
												Console.Write("------------------------\n" +
																"1. Shoulder Charge\t 2\n" +
																"2. Bloodlust\t\t 5\n" +
																"3. Chaos Burst\t\t 10\n" +
																"------------------------\n");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
												berserker_rage_skill = Console.ReadLine();
												switch (berserker_rage_skill)
												{
													case "1"://Shoulder Charge
														if (Berserker.skill_points >= 2)
														{
															int sc_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .98) / 2 );
															nidhogg_hp -= sc_dmg;
															Berserker.skill_points -= 2;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nYou inflicted {0:N0} HP with Shoulder Charge!\n", sc_dmg);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...");
													break;
													case "2"://Bloodlust
														if (Berserker.skill_points >= 4)
														{
															int bl_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .74) / 2 );
															nidhogg_hp -= bl_dmg;
															Berserker.player_hp += bl_dmg;
															Berserker.skill_points -= 4;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nYou inflicted {0:N0} HP with Bloodlust!", bl_dmg);
															Console.ForegroundColor = ConsoleColor.Green;
															Console.Write("\nYou gained {0:N0} HP with Bloodlust!\n", bl_dmg);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...");
													break;
													case "3"://Chaos Burst
														if (Berserker.skill_points >= 10)
														{
															int berserker_chaos = 9000;
															int cb_dmg = (int)(berserker_chaos * (r.NextDouble() + .8) / 2 );
															nidhogg_hp -= cb_dmg;
															Berserker.skill_points -= 10;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nYou inflicted {0:N0} HP with Chaos Burst!\n", cb_dmg);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...\n");
													break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}
											break;
											case "3": //Berserker Item Menu
												Console.Write("------------------------\n" +
																"1. Potion\t {0}\n" +
																"2. Hi-Potion\t {1}\n", potion_amt, hipotion_amt);
												Console.Write("------------------------\n");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
												item_choice = Console.ReadLine();
												switch (item_choice)
												{
													case "1"://Potion
														if (potion_amt > 0)
														{
															potion_amt--;
															Berserker.player_hp += 5000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 5,000 HP! HP: {0:N0}", Berserker.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no potions left to use");
													break;
													case "2"://Hi-Potion
														if (hipotion_amt > 0)
														{
															hipotion_amt--;
															Berserker.player_hp += 10000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 10,000 HP! HP: {0:N0}", Berserker.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no hi-potions left to use");
													break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}		
												break;
											default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
										}

									}	
									break;
								case "2": //Wizard battle loop
									while ((player_turn) & (Wizard.player_hp > 0 || nidhogg_hp > 0))
									{
										System.Threading.Thread.Sleep(1000);
										Console.Write("\n------------------------\n");
										Console.WriteLine("Current HP: {0:N0}\t" + "MP: {1}", Wizard.player_hp, Wizard.skill_points);
										Console.Write("------------------------\n" +
														"1. ATTACK\n" +
														"2. MAGIC\n" +
														"3. ITEM\n" +
														"------------------------\n");
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.Write("Type the corresponding number to the action you would like to execute:");
										Console.ForegroundColor = ConsoleColor.Gray;
										player_action = Console.ReadLine();
										switch (player_action)
										{
											case "1": //Wizard standard attack
												int physical_dmg = (int)(Wizard.base_att_dmg * (r.NextDouble() + .56) / 2);
												nidhogg_hp -= physical_dmg;
												Console.ForegroundColor = ConsoleColor.Cyan;
												Console.WriteLine("\nYou bashed Nidhogg for {0:N0}", physical_dmg + " HP worth of damage!");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("\nPLAYER TURN END: Press enter");
												Console.ForegroundColor = ConsoleColor.Gray;
												Console.ReadKey(player_turn = false);
												break;
											case "2": //Wizard Magic Menu
												Console.Write("------------------------\n");
												break;
											case "3"://Wizard Item Menu
												Console.Write("------------------------\n" +
																"1. Potion\t {0}\n" +
																"2. Hi-Potion\t {1}\n" +
																"3. Ether\t {2}\n" , potion_amt, hipotion_amt, ether_amt);
												Console.Write("------------------------\n");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
												item_choice = Console.ReadLine();
												switch (item_choice)
												{
													case "1"://Potion
														if (potion_amt > 0)
														{
															potion_amt--;
															Wizard.player_hp += 5000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 5,000 HP! HP: {0:N0}", Wizard.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no potions left to use");
													break;
													case "2"://Hi-Potion
														if (hipotion_amt > 0)
														{
															hipotion_amt--;
															Wizard.player_hp += 10000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 10,000 HP! HP: {0:N0}", Wizard.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no hi-potions left to use");
													break;
													case "3"://Ether
														if (ether_amt > 0)
														{
															ether_amt--;
															Wizard.skill_points += 300;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 300 MP! MP: {0}", Wizard.skill_points);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no ethers left to use");
														break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}
											break;
											default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
										}
									}
									break;
								case "3": //Monk Battle Loop
									while ((player_turn) & (Monk.player_hp > 0 || nidhogg_hp > 0))
									{
										System.Threading.Thread.Sleep(1000);
										Console.Write("\n------------------------\n");
										Console.WriteLine("Current HP: {0:N0}\t" + "Focus: {1} | 50", Monk.player_hp, Monk.skill_points);
										Console.Write("------------------------\n" +
														"1. ATTACK\n" +
														"2. HARNESS\n" +
														"3. ARTS\n" +
														"4. ITEM\n" +
														"------------------------\n");
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.Write("Type the corresponding number to the action you would like to execute:");
										Console.ForegroundColor = ConsoleColor.Gray;
										player_action = Console.ReadLine();
										switch (player_action)
										{
											case "1"://Monk standard attack
												int physical_dmg = (int)(Monk.base_att_dmg * (r.NextDouble() + .85) / 2);
												nidhogg_hp -= physical_dmg;
												Console.ForegroundColor = ConsoleColor.Cyan;
												Console.WriteLine("\nYou pummeled Nidhogg for {0:N0}", physical_dmg + " HP worth of damage!");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("\nPLAYER TURN END: Press enter");
												Console.ReadKey(player_turn = false);
												Console.ForegroundColor = ConsoleColor.Gray;
												break;
											case "2"://Monk HARNESS cmd
												if (Monk.skill_points < 50)
												{
													int focus_points = 10;
													Monk.skill_points += focus_points;
													Console.ForegroundColor = ConsoleColor.DarkGreen;
													Console.WriteLine("\nYou harness your chi, +10 focus gained");
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												else if (Monk.skill_points == 50)
												{
													Console.WriteLine("\nYour focus can be heightened no further, seize the moment and strike!");
												}
												break;
											case "3"://Monk Arts Menu
												Console.Write("------------------------\n");
												break;
											case "4"://Monk Item Menu
												Console.Write("------------------------\n" +
																"1. Potion\t {0}\n" +
																"2. Hi-Potion\t {1}\n", potion_amt, hipotion_amt);
												Console.Write("------------------------\n");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
												item_choice = Console.ReadLine();
												switch (item_choice)
												{
													case "1"://Potion
														if (potion_amt > 0)
														{
															potion_amt--;
															Monk.player_hp += 5000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 5,000 HP! HP: {0:N0}", Monk.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no potions left to use");
													break;
													case "2"://Hi-Potion
														if (hipotion_amt > 0)
														{
															hipotion_amt--;
															Monk.player_hp += 10000;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gained 10,000 HP! HP: {0:N0}", Monk.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou have no hi-potions left to use");
													break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}
												break;
											default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
										}
									}
									break;
									default: break;
					}
				if (player_turn == false) //At first I tried using 2 while loops but figured out the code needs to be nested inside the same 
										//loop to actually recall the first player_choice switch
				{
					switch (player_choice) //Nidhogg battle loop
					{
						
							case "1"://Attack against Berserker
							while ((player_turn == false) & (Berserker.player_hp > 0 && nidhogg_hp > 0))
							{
								System.Threading.Thread.Sleep(1000);
								int player_turn_dmg = (int)(nidhogg_base_dmg * (r.NextDouble() + .65) / 2);
								Berserker.player_hp -= player_turn_dmg;
								Console.ForegroundColor = ConsoleColor.DarkMagenta;
								Console.Write("\n\nNidhogg retaliates with a fericous blow\n" +
													"You suffer {0:N0} HP worth of damage!\n", player_turn_dmg);
								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.Write("\nNIDHOGG TURN END: Press enter\n");
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.ReadKey(player_turn = true);
							}
							break;
							case "2"://Attack against Wizard
							while ((player_turn == false) & (Wizard.player_hp > 0 && nidhogg_hp > 0))
							{
								System.Threading.Thread.Sleep(1000);
								int player_turn_dmg = (int)(nidhogg_base_dmg * (r.NextDouble() + .65) / 2);
								Wizard.player_hp -= player_turn_dmg;
								Console.ForegroundColor = ConsoleColor.DarkMagenta;
								Console.Write("\n\nNidhogg retaliates with a fericous blow\n" +
													"You suffer {0:N0} HP worth of damage!\n", player_turn_dmg);
								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.WriteLine("\nNIDHOGG TURN END: Press enter\n");
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.ReadKey(player_turn = true);
							}
							break;
							case "3"://Attack against monk
							while ((player_turn == false) & (Monk.player_hp > 0 && nidhogg_hp > 0))
							{
								System.Threading.Thread.Sleep(1000);
								int player_turn_dmg = (int)(nidhogg_base_dmg * (r.NextDouble() + .65) / 2); 
								Monk.player_hp -= player_turn_dmg;
								Console.ForegroundColor = ConsoleColor.DarkMagenta;
								Console.Write("\n\nNidhogg retaliates with a fericous blow\n" +
													"You suffer {0:N0} HP worth of damage!\n", player_turn_dmg);
								Console.ForegroundColor = ConsoleColor.Yellow;
								Console.WriteLine("\nNIDHOGG TURN END: Press enter");
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.ReadKey(player_turn = true);
							}
							break;
						default: break;
					}
				}
				if (Berserker.player_hp <= 0 || Wizard.player_hp <= 0 || Monk.player_hp <= 0)//Defeat condition
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("THE FUTURE OF HUMANITY IS LOST" + "\nThanks for playing though...");
					Console.ForegroundColor = ConsoleColor.Gray;
					break; //the last line of code becomes an infinite loop without this break
				}
				else if (nidhogg_hp <= 0)//Victory Condition
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("YOU WERE VICTORIOUS" + "\nHuman now has a future because of you!" + "\nTHANKS FOR PLAYING!!!!");
					break;
				}
			}
			
			Console.ReadKey();



		}
	}
}
