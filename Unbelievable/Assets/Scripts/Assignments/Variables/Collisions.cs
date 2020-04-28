using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Collider Player;

   void OnCollisionEnter2D()
    {
        Debug.Log("Hit Object");
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Trigger"))
        {
            Debug.Log("Colliding with Player");
        }
    }

    void OnTriggerStay(Collider other)
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Trigger"))
        {
            Debug.Log("Player has collided with a trigger");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            
        }
    }

    void OnCollisionExit(Collision collision)
    {
       
    }
}
