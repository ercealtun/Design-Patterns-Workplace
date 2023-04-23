using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAxe : WeaponBase
{
    public FireAxe()
    {
        damage = 20;
        damageType = new DoDa
    }

    public virtual void DoDamage()
    {
        PlayerStats.target.health -= damage;
        // do fire dmg stuff
    }
}
