using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope_Practice : MonoBehaviour
{
    public int supplies;

    public int paintings = 10;

    public int artPieces = 7;

    // Start is called before the first frame update
    void Start(int water, int rocks)
    {
        int complete = 17;

        complete = paintings * artPieces * supplies;

        Debug.Log("You've found all the art supplies!");

    }

    void Update()
    {
 
        int incomplete = 0-16;

        incomplete = paintings * artPieces * supplies;

        Debug.Log("You have not found all the art supplies!");
    }

   
}
