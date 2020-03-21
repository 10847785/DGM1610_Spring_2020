using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerators : MonoBehaviour
{

    enum Position { Up, Down, Left, Right }


    // Start is called before the first frame update
    void Start()
    {
        Position myPosition;

        myPosition = Position.Up;

    }

    Position ReversePosition (Position dir)
    {
        if (dir == Position.Up)
            dir = Position.Down;
        else if (dir == Position.Down)
            dir = Position.Up;
        else if (dir == Position.Left)
            dir = Position.Right;
        else if (dir == Position.Right)
            dir = Position.Left;

        return dir;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
