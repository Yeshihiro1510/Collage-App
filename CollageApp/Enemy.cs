namespace CollageApp;

public abstract class Enemy(string name, int health, Weapon weapon)
{
    protected string _name = name;
    protected int _health = health;
    protected Weapon _weapon = weapon;

    public override string ToString() => $"{_name} with {_health} health and {_weapon}";
    public abstract Enemy Clone();
}

public class Weapon(string name, int damage)
{
    public override string ToString() => $"{name} with {damage} damage";
}

public class Rusher : Enemy
{
    public Rusher() : base(NumberedNameGenerator<Rusher>.GenerateNextName(), Random.Shared.Next(150, 200), new Weapon("Mace", 100))
    {
    }

    private Rusher(int health, Weapon weapon) : base(NumberedNameGenerator<Rusher>.GenerateNextName(), health, weapon)
    {
    }

    public override Rusher Clone() => new(base._health, base._weapon);
}

public class Ranger : Enemy
{
    public Ranger() : base(NumberedNameGenerator<Ranger>.GenerateNextName(), Random.Shared.Next(50, 100), new Weapon("Bow", 25))
    {
    }

    private Ranger(int health, Weapon weapon) : base(NumberedNameGenerator<Ranger>.GenerateNextName(), health, weapon)
    {
    }

    public override Ranger Clone() => new Ranger(base._health, base._weapon);
}