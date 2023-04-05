using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : ElectricalAppliances
{
    private int volt;

    public Iron()
    {
        this.volt = 220;
    }

    public override int  PlugAndRun()
    {
        Debug.Log("Iron is working");
        return volt;
    }
}
