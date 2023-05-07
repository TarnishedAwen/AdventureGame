using System;
namespace SplatoonFanGame;


public abstract class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
}

public class WeaponOne : Weapon
{
    public WeaponOne()
    {
        Name = "Splatana";
        Damage = 15;
    }
}
public class WeaponTwo : Weapon
{
    public WeaponTwo()
    {
        Name = "Ink Dualies";
        Damage = 10;
    }
}
public class WeaponThree : Weapon
{
    public WeaponThree()
    {
        Name = "Ink Sniper";
        Damage = 35;
    }
}



