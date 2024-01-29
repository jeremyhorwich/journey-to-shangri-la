using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class makeFollow : MonoBehaviour
{
    public event EventHandler BoxCollided;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "yellowHappy")
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            BoxCollided?.Invoke(this, EventArgs.Empty);
        }
    }
}
