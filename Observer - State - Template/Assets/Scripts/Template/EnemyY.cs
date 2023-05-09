using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements Template design pattern

public class EnemyY : Enemy
{
    public static EnemyY instance = null;
    
    private void Awake()
    {
        instance = this;
    }

    public override void WithWho()
    {
        Debug.Log("with EnemyY");
    }
}
