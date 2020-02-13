using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Else_Cause_Practice : MonoBehaviour
{
    public string TV;
    public int amountTVs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is not meant to be taken seriously, this is just for practice

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectables")) ;
        {
            else(amountTVs = 1);
        }

        else
        {
            if (amountTVs = 2) ;

        }

        if (other.gameObject.CompareTag("Collectable")) ;
        {
            amountTVs = 1;
        }

    
        else 
        {
            amountTVs = 0;
        }
    }
}
