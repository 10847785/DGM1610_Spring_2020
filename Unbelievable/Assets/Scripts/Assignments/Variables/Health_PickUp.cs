﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_PickUp : PickUp
{
    public int healthAmount = 100;

    public Text HealthText;

    public Text HealthTotalText;


    // Start is called before the first frame update
    void Start()
    {
        print("Player health is" + healthAmount);
    }

  

    private void OnTriggerEnter(Collider other)
    {
        print("You Gained" + healthAmount + "Health!");
        Destroy(gameObject);
    }
}
