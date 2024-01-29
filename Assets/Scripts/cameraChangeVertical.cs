using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChangeVertical : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            float transitionDir = Input.GetAxisRaw("Vertical");
            other.transform.position = new Vector3(other.transform.position.x, 
                other.transform.position.y + 1f * transitionDir, other.transform.position.z);
            helper.playerFinder(other.transform.position, mainCamera);
        }
    }
}
