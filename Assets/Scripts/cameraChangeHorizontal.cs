using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChangeHorizontal : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            float transitionDir = Input.GetAxisRaw("Horizontal");
            other.transform.position = new Vector3(other.transform.position.x + 1f * transitionDir,
                other.transform.position.y, other.transform.position.z);
            helper.playerFinder(other.transform.position, mainCamera);
        }
    }
}
