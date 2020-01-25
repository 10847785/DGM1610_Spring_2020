using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggers_Practice : MonoBehaviour
{

    // Declaration 
    public int members;
    public float alive;
    public float dead;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(members 10, alive 10, dead 0); 
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collision other){

        }

        void OnTriggerStay(Collision other){

        }

        void OnTriggerEnd(Collision other){

        }
    }
}
