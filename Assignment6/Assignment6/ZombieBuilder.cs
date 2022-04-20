//The builder that creates the "Zombies" we need.
//Note here since all the Zombies are essentially instances of "ZombieWithAccessory"
//We can merge the abstract "Builder" and the "ConcreteBuilder" in the pattern together into one class

abstract class ZombieFactory
{
	public abstract IZombie CreateZombie();
}
class RegularZombieFactory : ZombieFactory
{
	public override IZombie CreateZombie()
	{
		return new Zombie();
	}
}
class ConeZombieFactory : ZombieFactory
{
	public override IZombie CreateZombie()
	{
		return new Cone(new Zombie());
	}
}
class BucketZombieFactory : ZombieFactory
{
	public override IZombie CreateZombie()
	{
		return new Bucket(new Zombie());
	}
}
class DoorZombieFactory : ZombieFactory
{
    public override IZombie CreateZombie()
    {
		return new ScreenDoor(new Zombie());
	}
}