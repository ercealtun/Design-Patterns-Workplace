using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDagger : WeaponBase
{
    public int damage = 100;

    public virtual void DoDamage()
    {
        PlayerStats.target.health -= damage;
        // do fire dmg stuff
    }
}
