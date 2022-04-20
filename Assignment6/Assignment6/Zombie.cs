//leaves elements
//leaf zombie

public class Zombie : IZombie
{

	private int health = 50;
	private char type = 'R';

	//add and remove are place holders Zombie inherits from the IZombie
	public override void add(IZombie z)
	{
		// TODO Auto-generated method stub

	}

	public override void remove(int index)
	{
		// TODO Auto-generated method stub

	}

	public override int takeDamage(int d)
	{
		// TODO Auto-generated method stub
		//return left over damage if needs to
		int leftOver = d - health;
		health -= d;
		return leftOver;
	}

	public override bool die()
	{
		// TODO Auto-generated method stub
		return health <= 0;
	}

	public override int getHealth()
	{
		// TODO Auto-generated method stub
		return this.health;
	}

	public override char getType()
	{
		// TODO Auto-generated method stub
		return this.type;
	}
}

//The rest of the accessories: identical with Zombie as a leaf.
class Cone : ZombieDecorator
{
	private int health = 25;
	private char type = 'C';

	public Cone(IZombie zombie) : base(zombie)
    {
		this.zombie = zombie;
    }

	public override int getHealth()
	{
		// TODO Auto-generated method stub
		return this.health;
	}

	public override char getType()
	{
		// TODO Auto-generated method stub
		return this.type;
	}


	public override int takeDamage(int d)
	{
		// TODO Auto-generated method stub
		//return left over damage if needs to
		int leftOver = d - health;
		health -= d;
		return leftOver;
	}


	public override bool die()
	{
		// TODO Auto-generated method stub
		return health <= 0;
	}


	public override void add(IZombie z)
	{
		// TODO Auto-generated method stub

	}


	public override void remove(int index)
	{
		// TODO Auto-generated method stub

	}
}

//same with bucket and screendoor
class Bucket : ZombieDecorator
{
	private int health = 100;
	private char type = 'B';

	public Bucket(IZombie zombie) : base(zombie)
	{
		this.zombie = zombie;
	}

	public override int getHealth()
	{
		// TODO Auto-generated method stub
		return this.health;
	}


	public override char getType()
	{
		// TODO Auto-generated method stub
		return this.type;
	}


	public override int takeDamage(int d)
	{
		// TODO Auto-generated method stub
		//return left over damage if needs to
		int leftOver = d - health;
		health -= d;
		return leftOver;
	}


	public override bool die()
	{
		// TODO Auto-generated method stub
		return health <= 0;
	}


	public override void add(IZombie z)
	{
		// TODO Auto-generated method stub

	}


	public override void remove(int index)
	{
		// TODO Auto-generated method stub

	}
}

class ScreenDoor : ZombieDecorator
{
	private int health = 25;
	private char type = 'S';

	public ScreenDoor(IZombie zombie) : base(zombie)
	{
		this.zombie = zombie;
	}

	public override int getHealth()
	{
		// TODO Auto-generated method stub
		return this.health;
	}


	public override char getType()
	{
		// TODO Auto-generated method stub
		return this.type;
	}


	public override int takeDamage(int d)
	{
		// TODO Auto-generated method stub
		//return left over damage if needs to
		int leftOver = d - health;
		health -= d;
		return leftOver;
	}


	public override bool die()
	{
		// TODO Auto-generated method stub
		return health <= 0;
	}


	public override void add(IZombie z)
	{
		// TODO Auto-generated method stub

	}


	public override void remove(int index)
	{
		// TODO Auto-generated method stub

	}
}
