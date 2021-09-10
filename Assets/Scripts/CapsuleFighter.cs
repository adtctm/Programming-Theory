using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CapsuleFighter : Fighter
{
    protected override void Posture()
    {
        Scale = Vector3.one * (Mathf.Sin(Time.time) + 1.5f);
    }
}
