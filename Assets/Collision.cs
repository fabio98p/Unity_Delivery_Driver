using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("woooooow");
    }
}
