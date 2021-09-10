using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CubeFighter : Fighter
{
    protected override void Posture()
    {
        Scale += Vector3.forward * Random.Range(-1f,1f);
    }

    protected override void Battle(Fighter f)
    {
        //Cube dies too!
        base.Battle(f);
        Destroy(gameObject);
    }
}
