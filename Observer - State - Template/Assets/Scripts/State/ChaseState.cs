using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements the State design pattern

public class ChaseState : State
{
    public AttackState attackState;
    public bool isInAttackRange;
    public override State RunCurrentState()
    {
        Debug.Log("Enemy is chasing the player");
        if (isInAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;
        }
    }
}
