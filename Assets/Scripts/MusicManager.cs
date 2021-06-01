using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

}
