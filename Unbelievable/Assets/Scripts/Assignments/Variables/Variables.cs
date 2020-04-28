using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaration
    public int amount;
    public float money;
    public float cost;


    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount, money, cost);
    }

   

    void Cookies(int amount, float money, float cost)
    {
        float total;

        total = money - cost* amount;

        print("Hello World");
    }
}
