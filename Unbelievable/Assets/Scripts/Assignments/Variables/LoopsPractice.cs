using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsPractice : MonoBehaviour
{
    public int numScripts = 10;
    public int numTVs = 7;
    public int numWeapons = 5;
    public int numHealth = 8;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= numScripts; i++)
        {
            Debug.Log("Script has reappeared" + i);
        }

        for (int i = 0; i <= numTVs; i++)
        {
            Debug.Log("TV has turned on" + i);
        }

        for (int i = 0; i >= numWeapons; i++)
        {
            Debug.Log("Weapons have been made" + i);
        }

        for (int i=0; i <= numHealth; i++)
        {
            Debug.Log("Health has regenerated" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
