using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements Template design pattern

public abstract class Enemy : MonoBehaviour
{
    public abstract void WithWho();
    public virtual void Attack()
    {
        Debug.Log("Attacking to the player ");
        WithWho();
    }
}
