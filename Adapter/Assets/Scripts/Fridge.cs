using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : ElectricalAppliances
{
    private int volt;

    public Fridge()
    {
        this.volt = 120;
    }

    public override int PlugAndRun()
    {
        Debug.Log("Fridge is working");
        return volt;
    }

}
