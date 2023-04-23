using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    public int damage = 0;
    public IDoDamage damageType;

    public void TryDoAttack()
    {
        damageType?.DoDamage(damage);
    }

    public virtual void DoDamage()
    {
        PlayerStats.target.health -= damage;
    }
}
