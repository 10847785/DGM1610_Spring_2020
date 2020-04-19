using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public static int Ammo;
    Text AmmoText;
    public int AmmoCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        AmmoText = GetComponent<Text>();
        Ammo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ammo > 10)
            Ammo = 10;
        Debug.Log("Picked up 10 ammo!");
    }

    public static void AddAmmo (int AmmoAdd)
    {
        Ammo += AmmoAdd;
    }

    public static void SubAmmo (int AmmoSub)
    {
        Ammo -= AmmoSub;
    }
}
