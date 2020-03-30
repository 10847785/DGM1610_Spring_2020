using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string pickUpName;
    public string pickUpType;
    public int pointsToAdd;
  
    
    void OnTriggerEnter(Collider other){
        //Check to see if trigger detected player
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddPoints(pointsToAdd);
            Destroy (gameObject);
        }
    }
}
