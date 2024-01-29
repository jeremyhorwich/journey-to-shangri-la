using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helper : MonoBehaviour
{
    //Controlled characters list
    public static List<GameObject> characterList = new List<GameObject> { };

    //Switch the camera to player's room
    public static void playerFinder(Vector3 playerPosition, GameObject camera)
    {
        Vector3 newCameraPosition = new Vector3(Mathf.Floor(Mathf.Abs(playerPosition.x / 18)) * 18 + 9,
            Mathf.Floor(Mathf.Abs(playerPosition.y / 10)) * 10 + 5f, -10);
        camera.transform.position = newCameraPosition;
    }
}
