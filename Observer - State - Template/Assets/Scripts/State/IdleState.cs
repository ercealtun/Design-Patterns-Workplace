using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements the State design pattern

public class IdleState : State
{
    public ChaseState chaseState;
    public bool canSeeThePlayer;
    public override State RunCurrentState()
    {
        if (canSeeThePlayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }
}
