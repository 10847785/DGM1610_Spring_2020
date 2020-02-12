using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : PickUp
{
    public int healthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    TriggerEnter(Collider other)
    {
        Debug.Log("You Gained" +
    }
}
