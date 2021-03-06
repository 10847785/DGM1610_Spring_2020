﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public const int maxHealth = 100;

    public int currentHealth = maxHealth;

    public Text hp;

    public Text maxHP;

   
    

    // Update is called once per frame
    void Update()
    {
        hp.text = currentHealth.ToString();
        maxHP.text = maxHealth.ToString();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
           
            print("You are Dead! Dead! Dead!");
        }
    }

    public void AddHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth >= 100)
        {
            currentHealth = 100;
          
            print("You've gained health!");
        }
    }
}
