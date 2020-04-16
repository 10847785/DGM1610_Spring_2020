using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAnimation : MonoBehaviour
{
    public float z_speed = 3f;
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, z_speed);
    }
}
