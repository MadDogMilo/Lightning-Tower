using System.Collections.Generic;
using System.Linq;

public class LightningTower : Tower
{
    // Tower properties
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Range { get; set; }
    public int AttackSpeed { get; set; }
    public int Damage { get; set; }

    // Tower constructor
    public LightningTower()
    {
        // Set tower properties
        Name = "Lightning Tower";
        Cost = 200;
        Range = 150;
        AttackSpeed = 7;
        Damage = 50;
    }

    // Tower attack method
    public override void Attack(Bloon bloon)
    {
        // Apply damage to the bloon and chain lightning to nearby bloons
        bloon.Health -= Damage;
        List<Bloon> nearbyBloons = GetNearbyBloons(bloon);
        foreach (Bloon nearbyBloon in nearbyBloons)
        {
            nearbyBloon.Health -= Damage / 2;
        }
    }

    // Method to get nearby bloons within a specific range
    private List<Bloon> GetNearbyBloons(Bloon bloon)
    {
        List<Bloon> nearbyBloons = new List<Bloon>();
        foreach (Bloon otherBloon in Game.Bloons)
        {
            if (otherBloon != bloon && DistanceTo(otherBloon) <= Range)
            {
                nearbyBloons.Add(otherBloon);
            }
        }

        return nearbyBloons;
    }
}