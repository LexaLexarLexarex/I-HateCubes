using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLEFT : MonoBehaviour
{
    public GameObject Sphere;
    public float SL;
    public void OnButtonDown()
    {
        SL = Random.Range(0.50f, 0.50f);
        Sphere.transform.Translate(-SL, 0, 0);
    }
}