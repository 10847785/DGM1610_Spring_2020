using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritancePractice
{
    public string enemies;
    public int lostKids;
    public int monsters;


    public InheritancePractice()
    {
        enemies = "lostKids";
        Debug.Log("The Lost Kids are near!");

    }

    public InheritancePractice(string newEnemyType)
    {
        enemies = newEnemyType;
        Debug.Log("A new enemy is approching!");

    }

    public void attack()
    {
        Debug.Log("The " + enemies + "are attacking!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
