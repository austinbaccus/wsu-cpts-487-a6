public abstract class ZombieDecorator : IZombie
{
    protected IZombie zombie;

    public ZombieDecorator(IZombie _zombie)
    {
        this.zombie = _zombie;
    }

    public virtual bool Die()
    {
        return zombie.die();
    }

    public virtual int GetHealth()
    {
        return zombie.getHealth();
    }

    public virtual char GetType()
    {
        return zombie.getType();
    }

    public virtual int TakeDamage(int d)
    {
        return zombie.takeDamage(d);
    }
}