using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopsPractice : MonoBehaviour
{
    public int itemsInBag = 5;
    public int rocks = 20;
    public int magic = 3;

    // Start is called before the first frame update
    void Start()
    {
        while (itemsInBag > 0)
        {
            itemsInBag--;
            Debug.Log("Found items in bag");
        }

        while (rocks > 0)
        {
            rocks--;
            Debug.Log("Rocks in bag!");
        }

        while (magic > 0)
        {
            magic--;
            Debug.Log("Magic has spawned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
