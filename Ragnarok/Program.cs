using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
			SoundPlayer sp = new SoundPlayer();
			sp.SoundLocation = Environment.CurrentDirectory + "\\Music\\Odin-Sphere-Soundtrack-A-Fate-Accepted-_1080p_.wav";
			sp.PlayLooping();
			Console.ForegroundColor = ConsoleColor.DarkRed;//Font color
			System.Threading.Thread.Sleep(2000);//provides a time interval before running the next line of code
			Console.WriteLine("	 ______   _______ _______ __    _ _______ ______   _______ ___   _ "); //Title Block
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|    _ | |   _   |       |  |  | |   _   |    _ | |       |   | | |");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|   | || |  |_|  |    ___|   |_| |  |_|  |   | || |   _   |   |_| |");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|   |_||_|       |   | __|       |       |   |_||_|  | |  |      _|");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|    __  |       |   ||  |  _    |       |    __  |  |_|  |     |_ ");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|   |  | |   _   |   |_| | | |   |   _   |   |  | |       |    _  |");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("	|___|  |_|__| |__|_______|_|  |__|__| |__|___|  |_|_______|___| |_|");
			Console.ForegroundColor = ConsoleColor.Gray;
			System.Threading.Thread.Sleep(5000);
			Console.WriteLine("\n\nThe promised end is upon you\nSummon the courage to fight for your possibility of a future"); //Tagline
			System.Threading.Thread.Sleep(5000);
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
					System.Threading.Thread.Sleep(6000);
					Console.Write("------------------------\n" +
									"BERSERKER's main weapon is the sword\n" +
									"as Berserker uses the ATTACK command, it will build Rage and give access to\n" +
									"more skills with the RAGE command\n" +
									"SHOULDER CHARGE: moderate damage attack\n" +
									"BLOODLUST: player gains HP 2.5x the damage done to the target\n" +
									"CHAOS BURST: high attack damage\n" +
									"------------------------\n");
					System.Threading.Thread.Sleep(6000);
					Console.Write("WIZARD's main weapon is a Magic Staff\n" +
									"while the Wizard does not do much damage with the ATTACK command\n" +
									"Wizard does have access to damage dealing spells" +
									"with the MAGIC command at the cost of MP\n" +
                                    "------------------------\n");
                    System.Threading.Thread.Sleep(6000);
                    Console.Write("MONK's main weapon are martial arts\n" +
                                    "Monk has a special command named HARNESS\n" +
                                    "by using harness you can build focus that will give you access" +
									"to more skills with the ARTS command\n" +
									"INNER HEALING: gain HP with high max and low min value\n" +
									"RAPID PALM: combo attack with random hits and dmg that based off number of hits\n" +
									"AURA BOLT: high attack damage\n" +
									"Monk also gains a small amount of focus with the ATTACK command\n" +
                                    "------------------------\n");
					System.Threading.Thread.Sleep(6000);
					Console.Write("Every character has access to 5 Potions and 1 Hi-Potion\n" +
									"Potions give 5,000 HP, Hi-Potion gives 10,000\n" +
									"Wizard is given 2 Ethers to gain 300 MP on use\n" +
									"You may enter an invalid selection in any of the battle submenus\n" +
									"to take you back to the main battle menu\n" +
									"------------------------\n\n");
					System.Threading.Thread.Sleep(3000);
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Press Enter to continue:");
					Console.ReadKey();
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
					Console.Write("Please press enter:");
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
			sp.Stop();
			string player_choice = Console.ReadLine(); //Need this variable declared in the main body for use with battle loop
            string path;
			System.Threading.Thread.Sleep(700);
            bool player_select_loop = true;
            while (player_select_loop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nType 1 for BERSKER, Type 2 for WIZARD, Type 3 for MONK:");
                Console.ForegroundColor = ConsoleColor.Gray;
                player_choice = Console.ReadLine(); //declared in player select loop to give custom intro for battle to each character

                switch (player_choice)
                {
                    case "1": path = "------------------------\n" + "Blood Boiling, You approach Nidhogg\n" + "------------------------"; player_select_loop = false;
						    sp.SoundLocation = Environment.CurrentDirectory + "\\Music\\Odin-Sphere-Soundtrack-Hope_-Following-The-Difficult-Battle-_1080p_.wav";
							sp.PlayLooping(); break;
                    case "2": path = "------------------------\n" + "Wise and Thoughtful, You approach Nidhogg\n" + "------------------------"; player_select_loop = false;
							sp.SoundLocation = Environment.CurrentDirectory + "\\Music\\Odin-Sphere-Soundtrack-Battle-In-Fairy-Land-_1080p_.wav";
							sp.PlayLooping(); break;
                    case "3": path = "------------------------\n" + "Centered and Focused, You approach Nidhogg\n" + "------------------------"; player_select_loop = false;
							sp.SoundLocation = Environment.CurrentDirectory + "\\Music\\Odin-Sphere-Soundtrack-Terror-And-Courage-_1080p_.wav";
							sp.PlayLooping(); break;
                    default: path = "\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"; break;
                }
                Console.Write(path);
            }

            

            Random r = new Random(); //generic random variable for dmg modifying
			
			Player Berserker = new Player();
			Player Wizard = new Player();
			Player Monk = new Player();

			Berserker.player_hp = 8500;//Berserker essentials
			Berserker.skill_points = 3;
			Berserker.base_att_dmg = 3420;
			
			Wizard.player_hp = 7350;//Wizard essentials
			Wizard.skill_points = 300;
			Wizard.base_att_dmg = 2101;

			Monk.player_hp = 9700;//Monk essentials
			Monk.skill_points = 10;
			Monk.base_att_dmg = 3778;

			int nidhogg_hp = 35000;//Nidhogg essentials
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
										System.Threading.Thread.Sleep(900);
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
												int acc = r.Next(10);
												if (acc == 6) //Provides a 10% chance for Nidhogg to dodge 
												{
													Console.ForegroundColor = ConsoleColor.Red;
													Console.WriteLine("\nNidhogg anticpates your attack and swiftly dodges!");
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												else
												{
													int physical_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .65) / 2 );
													nidhogg_hp -= physical_dmg;
													Berserker.skill_points++;
													Console.ForegroundColor = ConsoleColor.Cyan;
													Console.WriteLine("\nYou slashed Nidhogg for {0:N0} damage! +1 Rage!" , physical_dmg);
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												break;
											case "2": //Berserker Rage Skill Menu
												string berserker_rage_skill;
												Console.Write("------------------------\n" +
																"   RAGE SKILL\t\tRAGE COST\n" +
																"------------------------\n" +
																"1. Shoulder Charge\t 2 Rage\n" +
																"2. Bloodlust\t\t 3 Rage\n" +
																"3. Chaos Burst\t\t 5 Rage\n" +
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
															int sc_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .99) / 1.98 );
															nidhogg_hp -= sc_dmg;
															Berserker.skill_points -= 2;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nWith reckless determination you charge with the spiked pauldron of your armor\n" +
																			"You inflicted {0:N0} damage with Shoulder Charge!\n", sc_dmg);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...");
													break;
													case "2"://Bloodlust
														if (Berserker.skill_points >= 3)
														{
															int bl_dmg = (int)(Berserker.base_att_dmg * (r.NextDouble() + .6) / 2 );
															nidhogg_hp -= bl_dmg;
															Berserker.player_hp += (int)(bl_dmg * 2.5);
															Berserker.skill_points -= 3;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nYour lust for battle gives you strength\n" + 
																			"You inflicted {0:N0} HP with Bloodlust!", bl_dmg);
															Console.ForegroundColor = ConsoleColor.Green;
															Console.Write("\nYou gained {0:N0} HP with Bloodlust! HP: {1:N0}\n", (int)(bl_dmg * 2.5), Berserker.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...");
													break;
													case "3"://Chaos Burst
														if (Berserker.skill_points >= 5)
														{
															int berserker_chaos = 9000;
															int cb_dmg = (int)(berserker_chaos * (r.NextDouble() + .96) / 2 );
															nidhogg_hp -= cb_dmg;
															Berserker.skill_points -= 5;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.Write("\nUnable to contain it any longer\n" +
																			"You release your fury in the form of dark energy that creates a spherical explosion\n" +
																			"You inflicted {0:N0} damage with Chaos Burst!\n", cb_dmg);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else Console.WriteLine("\nYou haven't built enough rage to use that skill...");
													break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}
											break;
											case "3": //Berserker Item Menu
												Console.Write("------------------------\n" +
																"   ITEM\t\tQUANTITY\n" +
																"------------------------\n" +
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
														else Console.WriteLine("\nYou have no Potions left to use");
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
														else Console.WriteLine("\nYou have no Hi-Potions left to use");
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
										System.Threading.Thread.Sleep(900);
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
												Console.WriteLine("\nYou bashed Nidhogg for {0:N0} damage!", physical_dmg);
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("\nPLAYER TURN END: Press enter");
												Console.ForegroundColor = ConsoleColor.Gray;
												Console.ReadKey(player_turn = false);
												break;
											case "2": //Wizard Magic Menu
												Console.Write("------------------------\n" +
																"   MAGIC\t\tMP COST\n" +
																"------------------------\n" +
																"1. Ice Lance\t\t25 MP\n" +
																"2. Fortify\t\t50 MP\n" +
																"3. HellFire\t\t100 MP\n" +
																"4. GravityWell\t\t\t200 MP\n" +
																"------------------------\n");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
                                                string spell_choice = Console.ReadLine();
                                                switch (spell_choice)
                                                {
                                                    case "1" ://Ice Lance
                                                        if (Wizard.skill_points >= 25)
                                                        { 
                                                            int il_dmg_range = r.Next(2500, 4511);
                                                            nidhogg_hp -= il_dmg_range;
                                                            Wizard.skill_points -= 25;
                                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                            Console.WriteLine("\nYou conjure a glistening Ice Lance and hurl it for {0:N0} damage!" , il_dmg_range);
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
												            Console.Write("\nPLAYER TURN END: Press enter");
												            Console.ForegroundColor = ConsoleColor.Gray;
												            Console.ReadKey(player_turn = false);
                                                        }
                                                        else Console.WriteLine("\nYou do not have enough MP to cast this spell...");
                                                    break;
                                                    case "2" ://Fortify
                                                        if (Wizard.skill_points >= 50)
                                                        {
                                                            int fort_heal_range = r.Next(10000, 15001);
                                                            Wizard.player_hp += fort_heal_range;
                                                            Wizard.skill_points -= 50;
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Engulfed by a shimmering light you gained {0:N0} HP! HP: {1:N0}", fort_heal_range, Wizard.player_hp);
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
												            Console.Write("\nPLAYER TURN END: Press enter");
												            Console.ForegroundColor = ConsoleColor.Gray;
												            Console.ReadKey(player_turn = false);
                                                        }
                                                        else Console.WriteLine("\nYou do not have enough MP to cast this spell...");
                                                    break;
                                                    case "3"://Hellfire
                                                        if (Wizard.skill_points >= 100)
                                                        {
                                                            int hf_hit_range = r.Next(24, 99);
                                                            Wizard.skill_points -= 100;
                                                            if (hf_hit_range >= 24 && hf_hit_range <=37)
                                                            {
                                                                int hf_dmg1 = r.Next(5999, 7556);
                                                                nidhogg_hp -= hf_dmg1;
                                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                                Console.WriteLine("\nYou rained down streams of fire from the sky\n" +
                                                                                    "Landed {0} hits for {1:N0} damage with Hellfire!\n", hf_hit_range, hf_dmg1);
                                                                Console.ForegroundColor = ConsoleColor.Yellow;
												                Console.Write("\nPLAYER TURN END: Press enter");
												                Console.ForegroundColor = ConsoleColor.Gray;
												                Console.ReadKey(player_turn = false);
                                                            }
                                                            else if (hf_hit_range >= 38 && hf_hit_range <=64)
                                                            {
                                                                int hf_dmg1 = r.Next(7556, 9123);
                                                                nidhogg_hp -= hf_dmg1;
                                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                                Console.WriteLine("\nYou rained down streams of fire from the sky\n" +
                                                                                    "Landed {0} hits for {1:N0} damage with Hellfire!\n", hf_hit_range, hf_dmg1);
                                                                Console.ForegroundColor = ConsoleColor.Yellow;
												                Console.Write("\nPLAYER TURN END: Press enter");
												                Console.ForegroundColor = ConsoleColor.Gray;
												                Console.ReadKey(player_turn = false);
                                                            }
                                                            else if (hf_hit_range >= 65 && hf_hit_range <=99)
                                                            {
                                                                int hf_dmg1 = r.Next(9223 , 12141);
                                                                nidhogg_hp -= hf_dmg1;
                                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                                Console.WriteLine("\nYou rained down streams of fire from the sky\n" +
                                                                                    "Landed {0} hits for {1:N0} damage with Hellfire!\n", hf_hit_range, hf_dmg1);
                                                                Console.ForegroundColor = ConsoleColor.Yellow;
												                Console.Write("\nPLAYER TURN END: Press enter");
												                Console.ForegroundColor = ConsoleColor.Gray;
												                Console.ReadKey(player_turn = false);
                                                            }
                                                        }
                                                        else Console.WriteLine("\nYou do not have enough MP to cast this spell...");
                                                    break;
                                                    case "4" ://GravityWell
                                                }
												break;
                                            case "3"://Wizard Item Menu
												Console.Write("------------------------\n" +
																"   ITEM\t\tQUANTITY\n" +
																"------------------------\n" +
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
														else Console.WriteLine("\nYou have no Potions left to use");
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
														else Console.WriteLine("\nYou have no Hi-Potions left to use");
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
										System.Threading.Thread.Sleep(900);
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
												int acc = r.Next(8);
												if (acc == 3) //Provides a 12.5% chance for Nidhogg to dodge 
												{
													Console.ForegroundColor = ConsoleColor.Red;
													Console.WriteLine("\nNidhogg anticpates your attack and swiftly dodges!");
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												else
												{
													int physical_dmg = (int)(Monk.base_att_dmg * (r.NextDouble() + .85) / 2);
													nidhogg_hp -= physical_dmg;
													if (Monk.skill_points < 50)
													{
														Monk.skill_points += 5;
														Console.ForegroundColor = ConsoleColor.Cyan;
														Console.WriteLine("\nYou pummeled Nidhogg for {0:N0} damage! +5 focus gained", physical_dmg);
														Console.ForegroundColor = ConsoleColor.Yellow;
														Console.Write("\nPLAYER TURN END: Press enter");
														Console.ReadKey(player_turn = false);
														Console.ForegroundColor = ConsoleColor.Gray;
													}
													else
													{
														Console.ForegroundColor = ConsoleColor.Cyan;
														Console.WriteLine("\nYou pummeled Nidhogg for {0:N0} damage!", physical_dmg);
														Console.ForegroundColor = ConsoleColor.Yellow;
														Console.Write("\nPLAYER TURN END: Press enter");
														Console.ReadKey(player_turn = false);
														Console.ForegroundColor = ConsoleColor.Gray;
													}
												}
												break;
											case "2"://Monk HARNESS cmd
												if (Monk.skill_points <= 29)
												{
													int focus_points = 20;
													Monk.skill_points += focus_points;
													Console.ForegroundColor = ConsoleColor.DarkGreen;
													Console.WriteLine("\nYou harness your chi +20 focus gained!");
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												else if (Monk.skill_points == 50)
												{
													Console.WriteLine("\nYour focus can be heightened no further, seize the moment and strike!");
												}
												else if (Monk.skill_points >= 30)
												{
													Monk.skill_points = 50;
													Console.ForegroundColor = ConsoleColor.DarkGreen;
													Console.WriteLine("\nYour focus is now max!");
													Console.ForegroundColor = ConsoleColor.Yellow;
													Console.Write("\nPLAYER TURN END: Press enter");
													Console.ForegroundColor = ConsoleColor.Gray;
													Console.ReadKey(player_turn = false);
												}
												break;
											case "3"://Monk Arts Menu
												Console.Write("------------------------\n" +
																"   ART\t\t\tFOCUS COST\n" +
																"------------------------\n" +
																"1. Inner Healing\t 20 Focus\n" +
																"2. Rapid Palm\t\t 30 Focus\n" +
																"3. Aura Bolt\t\t 50 Focus\n" +
																"------------------------\n");
												Console.ForegroundColor = ConsoleColor.Yellow;
												Console.Write("Type the corresponding number to the action you would like to execute:");
												Console.ForegroundColor = ConsoleColor.Gray;
												string art_choice = Console.ReadLine();
												switch (art_choice)
												{
													case "1"://Inner Healing
														if (Monk.skill_points >= 20)
														{
															int inner_heal = r.Next(5000, 10001);
															Monk.player_hp += inner_heal;
															Monk.skill_points -= 20;
															Console.ForegroundColor = ConsoleColor.Green;
															Console.WriteLine("\nYou gather your chi in your stomach and redisturb it throughout your body, gained {0:N0} HP! HP: {1:N0}", inner_heal, Monk.player_hp);
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else
														{
															Console.WriteLine("\nYou must harness more focus to use this skill.");
														}
													break;
													case "2"://Rapid Palm
														if (Monk.skill_points >= 30)
														{
															int palm_combo = r.Next(2, 5);
															Monk.skill_points -= 30;
															switch (palm_combo)
															{
																case 2 :
																	int palm_base_dmg = 4000;
																	int palm_dmg = (int)((palm_base_dmg * (r.NextDouble() + .98)) / 1.34);
																	nidhogg_hp -= palm_dmg;
																	Console.ForegroundColor = ConsoleColor.DarkCyan;
																	Console.WriteLine("\nYou landed {0} hits with Rapid Palm for {1:N0} damage!" , (palm_combo * 3), palm_dmg);
																	Console.ForegroundColor = ConsoleColor.Yellow;
																	Console.Write("\nPLAYER TURN END: Press enter");
																	Console.ForegroundColor = ConsoleColor.Gray;
																	Console.ReadKey(player_turn = false);
																break;
																case 3 :
																	int palm_base_dmg2 = 4500;
																	int palm_dmg2 = (int)((palm_base_dmg2 * (r.NextDouble() + 1.38)) / 1.54);
																	nidhogg_hp -= palm_dmg2;
																	Console.ForegroundColor = ConsoleColor.DarkCyan;
																	Console.WriteLine("\nYou landed {0} hits with Rapid Palm for {1:N0} damage!" , (palm_combo * 3), palm_dmg2);
																	Console.ForegroundColor = ConsoleColor.Yellow;
																	Console.Write("\nPLAYER TURN END: Press enter");
																	Console.ForegroundColor = ConsoleColor.Gray;
																	Console.ReadKey(player_turn = false);
																break;
																case 4 :
																	int palm_base_dmg3 = 5000;
																	int palm_dmg3 = (int)((palm_base_dmg3 * (r.NextDouble() + 1.75)) / 1.64);
																	nidhogg_hp -= palm_dmg3;
																	Console.ForegroundColor = ConsoleColor.DarkCyan;
																	Console.WriteLine("\nYou landed {0} hits with Rapid Palm for {1:N0} damage!" , (palm_combo * 3), palm_dmg3);
																	Console.ForegroundColor = ConsoleColor.Yellow;
																	Console.Write("\nPLAYER TURN END: Press enter");
																	Console.ForegroundColor = ConsoleColor.Gray;
																	Console.ReadKey(player_turn = false);
																break;
																default : break;
															}
														}
														else
														{
															Console.WriteLine("\nYou must harness more focus to use this skill.");
														}
													break;
													case "3"://Aura Bolt
														if (Monk.skill_points >= 50)
														{
															Monk.skill_points -= 50;
															int ab_dmg = (int)(Monk.base_att_dmg * (r.NextDouble() + 4.85) / 2);
															nidhogg_hp -= ab_dmg;
															Console.ForegroundColor = ConsoleColor.DarkCyan;
															Console.WriteLine("\nYou gather ambient energy and sculpt it with your hands\n" + 
																				"Once concentrated, you release a powerful beam with pinpoint accuracy\n" +
																				"You inflicted {0:N0} damage with Aura Bolt!", (ab_dmg));
															Console.ForegroundColor = ConsoleColor.Yellow;
															Console.Write("\nPLAYER TURN END: Press enter");
															Console.ForegroundColor = ConsoleColor.Gray;
															Console.ReadKey(player_turn = false);
														}
														else
														{
															Console.WriteLine("\nYou must harness more focus to use this skill.");
														}
													break;
													default: Console.Write("\nTHE PROPHECY IS WRITTEN IN STONE! Enter a proper response...\n"); break;
												}
												break;
											case "4"://Monk Item Menu
												Console.Write("------------------------\n" +
																"   ITEM\t\tQUANTITY\n" +
																"------------------------\n" +
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
														else Console.WriteLine("\nYou have no Potions left to use");
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
														else Console.WriteLine("\nYou have no Hi-Potions left to use");
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
								Console.Write("\nNIDHOGG TURN END: Press enter\n");
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
								Console.Write("\nNIDHOGG TURN END: Press enter\n");
								Console.ForegroundColor = ConsoleColor.Gray;
								Console.ReadKey(player_turn = true);
							}
							break;
						default: break;
					}
				}

				string defeat =
				"\n	▓█████▄ ▓█████ ▄▄▄     ▄▄▄█████▓ ██░ ██  \n" +
				"	▒██▀ ██▌▓█   ▀▒████▄   ▓  ██▒ ▓▒▓██░ ██▒ \n" +
				"	░██   █▌▒███  ▒██  ▀█▄ ▒ ▓██░ ▒░▒██▀▀██░ \n" +
				"	░▓█▄   ▌▒▓█  ▄░██▄▄▄▄██░ ▓██▓ ░ ░▓█ ░██  \n" +
				"	░▒████▓ ░▒████▒▓█   ▓██▒ ▒██▒ ░ ░▓█▒░██▓ \n" +
				"	▒▒▓  ▒ ░░ ▒░ ░▒▒    ▓▒█░ ▒ ░░    ▒ ░░▒░▒ \n" +
				"	░ ▒  ▒  ░ ░  ░ ▒    ▒▒ ░   ░     ▒ ░▒░ ░ \n" +
				"	░ ░  ░    ░    ░    ▒    ░       ░  ░░ ░ \n" +
				"        ░  ░      ░    ░            ░  ░	 \n" +
				"	░										 \n";



				string victory =

				"\n	██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗\n" +
				"	██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝\n" +
				"	██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝ \n" +
				"	╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝  \n" +
				"	 ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║   \n" +
				"	  ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ";
                                                       

				if (Berserker.player_hp <= 0 || Wizard.player_hp <= 0 || Monk.player_hp <= 0)//Defeat condition
				{
					sp.Stop();
					System.Threading.Thread.Sleep(2000);
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.Write("\n {0}", defeat);
					Console.WriteLine("\n\nTHE FUTURE OF HUMANITY IS LOST" + "\nThanks for playing though...");
					Console.ForegroundColor = ConsoleColor.Gray;
					break; //the last line of code becomes an infinite loop without this break
				}
				else if (nidhogg_hp <= 0)//Victory Condition
				{
					sp.Stop();
					System.Threading.Thread.Sleep(3500);
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.Write("\n\n {0}" , victory);
					Console.WriteLine("\n\nYOU WERE VICTORIOUS" + "\nHumanity now has a future because of you!" + "\nTHANKS FOR PLAYING!!!!");
					break;
				}
			}
			
			Console.ReadKey();



		}
	}
}
