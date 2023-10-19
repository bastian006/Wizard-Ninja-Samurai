class Ninja : Human
{
    public Ninja(string name) : base(name, 3, 5, 75, 100)
    {
    }

    public override int Attack(Human target)
    {
        int damage = Dexterity;
        if (new Random().Next(1, 6) == 1) // 20% chance of additional damage
        {
            damage += 10;
        }
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} stole 5 health points from {target.Name}!");
    }
}