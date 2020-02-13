using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_PickUp : Pickup
{
    public int healthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
     // print("Player health is" + healthAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
     // Debug Gained" + healthAmount + " Health!");
    }
}

public class Pickup
{
}