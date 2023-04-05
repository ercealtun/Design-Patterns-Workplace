using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Socket socket = new Socket();

    private Iron iron = new Iron();
    private Fridge fridge = new Fridge();
    
    SamsungPhone samsungPhone = new SamsungPhone();
    
    // Start is called before the first frame update
    void Start()
    {
        socket.Electrify(iron); // Connecting iron to socket
        socket.Electrify(fridge); // Connecting fridge to socket

        PhoneElectricalAppliancesAdapter adapter = new PhoneElectricalAppliancesAdapter(samsungPhone); // Connecting phone to adapter
        socket.Electrify(adapter); // Connecting adapter to socket
    }
    
}
