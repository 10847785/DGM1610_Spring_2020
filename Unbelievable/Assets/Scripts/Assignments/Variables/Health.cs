using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    

    public int healthToAdd;

    
    

    void OnTriggerEnter(Collider other)
    {
        var health = other.gameObject.GetComponent<Player_Health>();

        if (health != null)
        {
            health.AddHealth(healthToAdd);
        }
    }
    
}
