using System;
namespace SplatoonFanGame;
public abstract class Agent
{
    public string Name { get; set; }
    public Weapon Weapon { get; set; }
    public int Score { get; set; }
    public Inventory Inventory { get; set; }
    public int Health { get; set; }
    public abstract int Attack();
    public System.Windows.Media.Color Color { get; set; }



}
public class AgentOne : Agent
{
    public AgentOne()
    {
        Name = "Agent 3";
        Weapon = new WeaponOne();
        Inventory = new Inventory();
        Health = 100;
        Color = System.Windows.Media.Colors.Green;
    }
    private bool hasAttacked = false;

    public override int Attack()
    {
        if (!hasAttacked)
        {
            hasAttacked = true;
            return 0;
        }
        else
        {
            hasAttacked = false;
            return Weapon.Damage;
        }
    }
}


public class AgentTwo : Agent
{
    public AgentTwo()
    {
        Name = "Agent 4";
        Weapon = new WeaponTwo();
        Inventory = new Inventory();
        Health = 100;
        Color = System.Windows.Media.Colors.Yellow;
    }
    public bool CanDodge()
    {
        int dodgeChance = new Random().Next(1, 101); // Random number between 1 and 100
        return dodgeChance <= 30; // 30% chance to dodge


    }

    public override int Attack()
    {
        // Implement the attack logic for Agent Four
        return Weapon.Damage;
    }

}

public class AgentThree : Agent
{
    public AgentThree()
    {
        Name = "Agent 8";
        Weapon = new WeaponThree();
        Inventory = new Inventory();
        Health = 150;
        Color = System.Windows.Media.Colors.Magenta;
    }
    private int turnsToWait = 0;

    public override int Attack()
    {
        if (turnsToWait == 0)
        {
            turnsToWait = new Random().Next(1, 3); // Randomly wait 1 or 2 turns before next attack
            return Weapon.Damage;
        }
        else
        {
            turnsToWait--;
            return 0;
        }
    }
}

