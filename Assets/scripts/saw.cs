using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw : MonoBehaviour
{
    public float spinSpeed = 600;
    void Update ()
    {
        // ennsimpel script för att få en sak att rotera runt z axeln
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
