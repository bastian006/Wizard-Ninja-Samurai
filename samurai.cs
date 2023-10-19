class Samurai : Human
{
    public Samurai(string name) : base(name, 5, 7, 5, 200)
    {
    }

    public override int Attack(Human target)
    {
        int currentHealth = target.Health;
        base.Attack(target);

        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{target.Name} was defeated!");
        }
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200; // Heals the Samurai back to full health
        Console.WriteLine($"{Name} meditated and restored full health!");
    }
}