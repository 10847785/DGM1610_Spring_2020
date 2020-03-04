using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public bool MoveAxis;


    public Transform BoundryPoint;
    public bool IsBoundry;


    public Transform EdgeCheck;
    private bool IsEdge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // IsEdge = Physics.(EdgeCheck.position, IsBoundry, BoundryPoint);

       // IsBoundry = Physics.(BoundryPoint.position, IsBoundry, BoundryPoint);
    }
}
