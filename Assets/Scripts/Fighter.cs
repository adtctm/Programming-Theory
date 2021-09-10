using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    [SerializeField] private float scaleClamp = 2f;
    [SerializeField] private float scaleMin = 0.1f;

    //ENCAPSULATION
    public Vector3 Scale
    {
        get
        {
            return transform.localScale;
        }
        set
        {
            gameObject.transform.localScale = ClampVector(value, scaleMin, scaleClamp); ;
        }
    }

    private void Update()
    {
        Posture();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Battle(collision.gameObject.GetComponent<Fighter>());
    }

    //POLYMORPHISM
    protected abstract void Posture();

    //POLYMORPHISM
    protected virtual void Battle(Fighter f)
    {
        //Aggressor wins
        Destroy(f.gameObject);
    }

    //ABSTRACTION
    private Vector3 ClampVector(Vector3 v, float min, float max)
    {
        if (v.x > max) { v.x = max; };
        if (v.y > max) { v.y = max; };
        if (v.z > max) { v.z = max; };
        if (v.x < min) { v.x = min; };
        if (v.y < scaleMin) { v.y = min; };
        if (v.z < min) { v.z = min; };

        return v;
    }
}
