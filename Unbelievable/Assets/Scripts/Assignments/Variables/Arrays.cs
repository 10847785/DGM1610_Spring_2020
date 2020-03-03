using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] Enemies;

    // Start is called before the first frame update
    void Start()
    {
        Enemies = new string[3];

            Enemies[0] = "Lost Kids";
            Enemies[1] = "Monstors";
            Enemies[2] = "Player's Beast";

        foreach (string Enemy in Enemies);

    
    }

    public string[] Collectables;

    // Update is called once per frame
    void Update()
    {
        Collectables = new string[3];

            Collectables[0] = "TVs";
            Collectables[1] = "Scripts";
            Collectables[2] = "Feathers";

        foreach (string Items in Collectables) ;
    }
}
