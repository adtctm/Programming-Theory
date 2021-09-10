using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class SphereFighter : Fighter
{
    protected override void Posture()
    {
        this.Scale = Vector3.one * Time.time;
    }
    protected override void Battle(Fighter f)
    {
        //Sphere is peaceful do nothing
    }
}
