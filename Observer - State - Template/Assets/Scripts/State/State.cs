using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements the State design pattern

public abstract class State : MonoBehaviour
{
    public abstract State RunCurrentState();
}
