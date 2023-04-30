using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool havePackage = false;
    [SerializeField] float timeToDestroy = 0f;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !havePackage)
        {
            Debug.Log(collision.tag);
            havePackage = true;
            Destroy(collision.gameObject, timeToDestroy);
        }
        if (collision.tag == "Customer" && havePackage)
        {
            Debug.Log(collision.tag);
            havePackage = false;
        }
    }
}
