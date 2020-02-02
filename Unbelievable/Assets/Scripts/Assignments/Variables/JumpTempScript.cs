using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTempScript : MonoBehaviour
{
    public float JumpHeight;



    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            Jump();
        }

        void Jump() 
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, JumpHeight);
        }
    }
}
