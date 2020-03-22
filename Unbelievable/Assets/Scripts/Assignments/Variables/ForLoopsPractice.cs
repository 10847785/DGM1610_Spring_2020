using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsPractice : MonoBehaviour
{
    public int numStanleys;
    public int numViolets;
    public int numCarries;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i <= numStanleys; i++)
        {
            Debug.Log("Stanleys are coming" + i);
        }

        for (int i = 0; i <= numViolets; i++)
        {
            Debug.Log("Violets are coming" + i);
        }

        for (int i = 0; i <= numCarries; i++)
        {
            Debug.Log("Carries are coming" + i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
