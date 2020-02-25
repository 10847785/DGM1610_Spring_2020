using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{
    public int AmmoPickUp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
 
        if (other.gameObject.CompareTag("PreFab"))
        {
           // AmmoManager.Ammo(AmmoPickUp);
            Destroy(gameObject);
        }
    }

        
 
}
