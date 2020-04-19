using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAmmo : MonoBehaviour
{
    public const int maxAmmo = 20;

    public int currentAmmo = maxAmmo;

    public Text am;

    public Text maxAM;
    
   

    // Update is called once per frame
    void Update()
    {
        am.text = currentAmmo.ToString();
        maxAM.text = maxAmmo.ToString();
    }

    public void LoseAmmo(int amount)
    {
        currentAmmo -= amount;
        if(currentAmmo <= 0)
        {
            currentAmmo = 0;
            print("Out of Ammo!");
        }
    }

    void OnTriggerEnter(Collider other) {
 
        if (other.gameObject.CompareTag("PreFab"))
        {
           // AmmoManager.Ammo(AmmoPickUp);
            Destroy(gameObject);
        }
    }

        
 
}
