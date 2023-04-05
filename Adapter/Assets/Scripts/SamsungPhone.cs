using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamsungPhone : Phone
{
    private int operatingVoltage;


    public SamsungPhone()
    {
        this.operatingVoltage = 5;
    }

    public override int Charge()
    {
        Debug.Log("Samsung phone is working");
        return operatingVoltage;
    }
}
