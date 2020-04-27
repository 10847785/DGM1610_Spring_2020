using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerPlayer : MonoBehaviour
{
   // public LevelManager LevelManager;
    public HealthManager Damage;
    // Start is called before the first frame update
    void Start()
    {
      //  LevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
           // LevelManager.RespawnPlayer();
         //   Damage.SubHealth(1);
        }
    }
}
