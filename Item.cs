using System;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
public class CannedTuna : Item
{
    public CannedTuna() : base("Canned Tuna", "A can of tuna that increases the agent's damage by 3.")
    {
        DamageBoost = 3;
    }

    public int DamageBoost { get; }
}

public class Thang : Item
{
    public Thang(string name, string description) : base(name, description)
    {
    }
}
public class Thang1 : Thang
{
    public Thang1() : base("Thang 1", "The first mysterious Thang.")
    {
    }
}

public class Thang2 : Thang
{
    public Thang2() : base("Thang 2", "The second mysterious Thang.")
    {
    }
}

public class Thang3 : Thang
{
    public Thang3() : base("Thang 3", "The third mysterious Thang.")
    {
    }
}

public class Thang4 : Thang
{
    public Thang4() : base("Thang 4", "The fourth and final mysterious Thang.")
    {
    }
}


