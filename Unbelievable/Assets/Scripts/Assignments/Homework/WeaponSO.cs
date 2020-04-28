using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SO", menuName = "Weapon Scriptable Object/New Weapon")]

public class WeaponSO : ScriptableObject
    
{

 //Weapons management
    public string weapon;

    public string description;

    public GameObject model;

    public Projectiles type;


}
