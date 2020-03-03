using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static int playerHealth;
    
    

    void Awake()
    {
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth > 5)
            playerHealth = 5;

        
    }

    public static void HealthAdd (int AddHealth)
    {
        playerHealth += AddHealth;
    }

    public void HealthSub (int SubHealth)
    {
        playerHealth -= SubHealth;
    }
}
