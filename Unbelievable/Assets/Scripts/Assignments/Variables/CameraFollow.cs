using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public CharacterController Player;

    public float CameraSpeed = 1f;

    // Camera positions

    public float offSetX;
    public float offSetY;
    public float offSetZ;


    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       float interpolation = CameraSpeed * Time.deltaTime;

       transform.position = new Vector3(Player.transform.position.x + offSetX, Player.transform.position.y + offSetY, Player.transform.position.z + offSetZ);

    } 
}
