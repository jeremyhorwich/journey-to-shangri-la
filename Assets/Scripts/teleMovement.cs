using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerControlled;
    Vector2 movement;

    void Update()
    {
        Vector2 playerPosition = playerControlled.transform.position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerControlled.MovePosition(new Vector2(playerPosition.x, playerPosition.y + 2));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerControlled.MovePosition(new Vector2(playerPosition.x, playerPosition.y - 2));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerControlled.MovePosition(new Vector2(playerPosition.x - 2, playerPosition.y));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerControlled.MovePosition(new Vector2(playerPosition.x + 2, playerPosition.y));
        }
    }
}
