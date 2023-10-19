        Wizard wizard = new Wizard("Gandalf");
        Ninja ninja = new Ninja("Ryu");
        Samurai samurai = new Samurai("Hattori");

        Human target = new Human("Enemigo", 3, 3, 3, 100);

        wizard.Attack(target);
        wizard.Heal(wizard);

        ninja.Attack(target);
        ninja.Steal(target);

        samurai.Attack(target);
        samurai.Meditate();

        Console.WriteLine($"{target.Name}'s Salud restante: {target.Health}");
        Console.WriteLine($"{wizard.Name}'s vida: {wizard.Health}");
        Console.WriteLine($"{ninja.Name}'s vida: {ninja.Health}");
        Console.WriteLine($"{samurai.Name}'s vida: {samurai.Health}");

