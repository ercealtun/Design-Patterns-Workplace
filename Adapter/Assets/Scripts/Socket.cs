using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket
{
    public void Electrify(ElectricalAppliances electricalAppliances)
    {
        int volt = electricalAppliances.PlugAndRun();
        Debug.Log(volt + " volts from the socket");
    }
}
