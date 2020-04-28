using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This following line of code adds our Scriptable Object as an option in the Asset menu.
[CreateAssetMenu(fileName = "New SO", menuName = "New Scriptable Object/New Object")]

public class SO : ScriptableObject // Notice how we change the inheritance from MonoBehavior to Scriptable Object
{
    //Scriptable Objects like Mono scripts can contain variables.

    public new string name;

    public string description;

    public GameObject model;

    public Color color;
    
    //Scriptable Objects do not use MonoBehavior callbacks such as Start() and Update().

    //Scriptable Objects can also contain function and conditionals.

    
}
