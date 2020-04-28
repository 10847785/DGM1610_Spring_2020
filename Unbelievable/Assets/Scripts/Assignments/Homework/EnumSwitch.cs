using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSwitch : MonoBehaviour
{
    enum position { Plus, Minus, Multiply, Divide}

    public string calc;

    public int smarts = 4;

    void calcMenu()
    {
        switch (smarts)
        {
            case 4:
                print("Plus");
                break;

            case 3:
                print("Minus");
                break;

            case 2:
                print("Multiply");
                break;

            case 1:
                print("Divide");
                break;

            default:
                print("Mil");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        position MyPosition;

        MyPosition = position.Plus;
    }

   
}
