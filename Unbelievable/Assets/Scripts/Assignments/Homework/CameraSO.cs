using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SO", menuName = "Camera Scriptable Object/New Camera")]


public class CameraSO : ScriptableObject
{

    public new string camera;

    public Vector3 Position;

    public Vector3 Scale;

   
}
