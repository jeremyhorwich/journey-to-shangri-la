using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class twoWayTeleport : MonoBehaviour
{
    [SerializeField] BoxCollider2D targetPoint;
    [SerializeField] GameObject mainCamera;
    public event EventHandler<OriginHitEventArgs> OriginHit;
    public class OriginHitEventArgs : EventArgs
    {
        public Vector3 targetPoint;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetPoint.enabled = false;
            collision.transform.position = targetPoint.transform.position;
            helper.playerFinder(collision.transform.position, mainCamera);
            Invoke("reEnable", 1f);
            
            if (collision.gameObject.name == "yellowHappy")
            {
                OriginHit?.Invoke(this, new OriginHitEventArgs { targetPoint = targetPoint.transform.position });

            }
        }
    }
    private void reEnable()
    {
        targetPoint.enabled = true;
    }
}
