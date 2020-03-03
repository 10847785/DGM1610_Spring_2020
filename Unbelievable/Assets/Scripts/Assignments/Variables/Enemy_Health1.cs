﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health1 : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //Keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");
            // Add points to score for killing enemy
            //scoreManager.AddPoints(points);
            //Move enemy to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            // Reset enemy health
            currentHealth = maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
