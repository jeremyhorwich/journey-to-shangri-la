using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsDown : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, mainCamera.transform.position.z + 10);
            collision.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z + 10);
        }
    }
}
