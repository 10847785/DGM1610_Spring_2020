using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int Num = 5;

    public string Enemies;
        
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            Debug.Log(i + "Counting Up");
        }

        while (Num > 0)
        {
          //  i < Enemies; i++[Debug.Log]
            Debug.Log("Counting Down" + Num);
            Num --;
        }


    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
