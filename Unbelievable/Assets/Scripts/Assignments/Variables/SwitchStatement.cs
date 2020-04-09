using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    public string weapon = "Fists";
    public int smarts = 3;

    void weaponsMenu()
    {
        switch (smarts)
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
        if(weapon == "Rocks")
        {
            print("Throw rocks");
        }
        else if(weapon == "Bow")
        {
            print("You can shoot arrows!");
        }
        else if(weapon == "Sword")
        {
            print("You have a sword!");

        }
        else
        {
            print("You have no weapons");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
