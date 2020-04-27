using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AmmoManager : MonoBehaviour
{
    public static int Ammo;
    public int AmmoCount;
    public Text AmmoText;
    private Text AmountText;


    // Start is called before the first frame update
    void Start()
    {
        AmountText = GetComponent<Text>();
        Ammo = 0;
       // AmmoText.GetComponent<Text>().enabled = false;
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
