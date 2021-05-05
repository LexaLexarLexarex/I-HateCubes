using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRIGHT : MonoBehaviour
{
    public GameObject Sphere;
    public float SR;
    public void OnButtonDownRight()
    {
        SR = Random.Range(0.50f, 0.50f);
        Sphere.transform.Translate(SR, 0, 0);
    }
}