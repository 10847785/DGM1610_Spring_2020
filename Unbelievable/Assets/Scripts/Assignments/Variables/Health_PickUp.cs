using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_PickUp : PickUp
{
    public int healthAmount = 100;

    public Text HealthText;

    private Text HealthTotalText;

    // Start is called before the first frame update
    void Start()
    {
        print("Player health is" + healthAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("You Gained" + healthAmount + "Health!");
        Destroy(gameObject);
    }
}
