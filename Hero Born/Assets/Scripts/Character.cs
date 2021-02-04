using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Character
{

    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }



    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat($"Hero: {name} - {exp} EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }

}

public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon): base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat($"Hail: {name} - take up your {weapon.name}!");
    }
}

public struct Weapon
{
        public string name;
        public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat($"Weapon: {name} - {damage} DMG");
    }

}


