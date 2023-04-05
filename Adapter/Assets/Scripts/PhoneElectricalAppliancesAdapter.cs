using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneElectricalAppliancesAdapter : ElectricalAppliances
{
    private Phone phone;

    public PhoneElectricalAppliancesAdapter(Phone phone)
    {
        this.phone = phone;
    }

    public override int PlugAndRun()
    {
        return phone.Charge();
    }
}
