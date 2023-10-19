class Wizard : Human
{
    public Wizard(string name) : base(name, 3, 25, 3, 50)
    {
    }

    public override int Attack(Human target)
    {
        int damage = 3 * Intelligence;
        target.Health -= damage;
        Health += damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage and healed for {damage}!");
        return target.Health;
    }

    public void Heal(Human target)
    {
        int healing = 3 * Intelligence;
        target.Health += healing;
        Console.WriteLine($"{Name} healed {target.Name} for {healing} points!");
    }
}