// Component Element
public abstract class IZombie 
{
	private int health;
	public abstract int getHealth();
	
	private char type;
	public abstract char getType();		
	
	//add/remove for the Composite components. Empty for the Leaf components.
	public abstract void add(IZombie z);
	public abstract void remove(int index);
	
	//these are the "Operation()" in the pattern
	//In fact, so are getHealth and getType.
	public abstract int takeDamage(int d);
	public abstract bool die();
}
