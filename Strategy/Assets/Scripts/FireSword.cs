using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSword : WeaponBase
{
    public int damage = 20;

    public virtual void DoDamage()
    {
        PlayerStats.target.health -= damage;
        // do fire dmg stuff
    }
}
