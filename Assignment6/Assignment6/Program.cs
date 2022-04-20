main(new string[0]);

static void main(string[] args)
{
	int damage = 25;

	RegularZombieFactory rf = new RegularZombieFactory();
	ConeZombieFactory cf = new ConeZombieFactory();
	BucketZombieFactory bf = new BucketZombieFactory();
	DoorZombieFactory df = new DoorZombieFactory();

	string input;

	while (true)
	{
		Console.WriteLine("1. Create Zombies?");
		Console.WriteLine("2. Demo game play.");

		Console.WriteLine("Enter q to exit, or r to restart.");

		//q to quit
		try
		{
			input = Console.ReadLine();
			//exit
			if (input=="q")
			{
				return;
			}

			//loop the creation 
			if (input == "1")
			{
				Console.WriteLine("-----------------------------");
				Console.WriteLine("Enter creation (q to exit):");

				//create new zombies
				//in this solution, the "Client" and "Director" are merged in this Main class
				while (true)
				{
					Console.WriteLine("Which kind?");
					Console.WriteLine("1. (R)egular; 2. (C)one; 3. (B)ucket; 4. (S)creenDoor");

					input = Console.ReadLine();

					if (input == "q") break;
					//pass in the builder (concrete builder); assume input correct. Default will create a regular zombie.
					//typically, if there's more than one builder, a type check should happen here
					
					IZombie z = directBuilder(rf, cf, bf, df, input);

					if (z != null)
					{
						GameObjectManager.enemies.Add(z);
					}
					printArray(GameObjectManager.enemies);

				}
			}

			//demo loop
			else if (input == "2")
			{
				if (GameObjectManager.enemies.Count == 0)
				{
					Console.WriteLine("No zombies created yet. Start over.");
					continue;
				}

				//loop through attacks of the zombies
				//you may automate it, or simulate it with clicks, or delay with timer
				//for simplicity purpose, I'm automating the process here
				int count = 0;
				while (GameObjectManager.enemies.Count != 0)
				{
					Console.WriteLine("Round " + count + ": ");
					count++;
					printArray(GameObjectManager.enemies);

					Console.WriteLine("\n[1] Peashooter");
					Console.WriteLine("[2] Watermelon");
					Console.WriteLine("[3] Magent-shroom\n");
					int result = int.Parse(Console.ReadLine());

					GameEventManager.simulateCollisionDetection(result);

					//GameObjectManager.enemies[0].takeDamage(damage);
					//check if the zombie has died
					if (GameObjectManager.enemies[0].die())
						GameObjectManager.enemies.RemoveAt(0);
				}
				printArray(GameObjectManager.enemies);
			}

			else if (input == "p")
			{
				//print the GameObjectManager.enemies array
				printArray(GameObjectManager.enemies);
			}

			else if (input == "r")
			{
				//restart
				GameObjectManager.enemies.Clear();
			}
		}
		catch (Exception e)
		{
			// TODO Auto-generated catch block
			Console.WriteLine(e.Message);
		}
	}
}

static IZombie directBuilder(RegularZombieFactory z, ConeZombieFactory c, BucketZombieFactory b, DoorZombieFactory d, string t)
{
	//since we use only one builder, the type check can be done here instead.
	switch (t)
	{
		//regular zombie
		case "1":
		case "r":
		case "R":
			return z.CreateZombie();
			break;
		//cone zombie
		case "2":
		case "c":
		case "C":
			return c.CreateZombie();
			break;
		//bucket zombie
		case "3":
		case "b":
		case "B":
			return b.CreateZombie();
			break;
		//Screen door zombie
		case "4":
		case "s":
		case "S":
			return d.CreateZombie();
			break;
		default:
			return z.CreateZombie();
			break;
	}
}

static void printArray(List<IZombie> l)
{
	Console.Write("[");
	for (int i = 0; i < l.Count; i++)
	{
		IZombie z = l[i];
		Console.Write(z.getType() + "/" + z.getHealth() + ", ");
	}
	Console.WriteLine("]");
}
