using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Object_Practice : MonoBehaviour
{
    public int HealthToAdd = 5;

    public static int Health;

    public TextAlignment HealthText;

    

    // Start is called before the first frame update
    void Start()
    {
        HealthText = (GetComponent<TextAlignment>());

        Health = 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Health > 5) ;
            Health = 5;
    }
}
