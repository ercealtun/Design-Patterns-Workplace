using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements the State design pattern
public class AttackState : State
{
    public override State RunCurrentState()
    {
        if (GetComponentInParent<StateManager>().gameObject.name == "EnemyX")
        {
            EnemyX.instance.Attack();
        }else if (GetComponentInParent<StateManager>().gameObject.name == "EnemyY")
        {
            EnemyY.instance.Attack();
        }
        return this;
    }
}
