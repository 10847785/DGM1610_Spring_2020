using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    public int weaponType = 3;

    void weaponsMenu()
    {
        switch (weaponType)
        {
            case 3:
                print("Rocks");
                break;

            case 2:
                print("Bow");
                break;

            case 1:
                print("Sword");
                break;

            default:
                print("Fists");
                break;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
