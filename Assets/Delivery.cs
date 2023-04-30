using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 0, 255); 
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    SpriteRenderer spriteRenderer;
    private bool havePackage = false;
    [SerializeField] float timeToDestroy = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateCarColor();
    }

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
            UpdateCarColor();
        }
        if (collision.tag == "Customer" && havePackage)
        {
            Debug.Log(collision.tag);
            havePackage = false;
            UpdateCarColor();
        }
    }
    private void UpdateCarColor()
    {
        if (havePackage)
        {
            spriteRenderer.color = hasPackageColor;
        }
        else
        {
            spriteRenderer.color = noPackageColor;
        }
    }
}
