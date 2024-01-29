using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerControlled;
    [SerializeField] private float moveSpeed;
    Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            movement = movement.normalized;
        }

    }
    private void FixedUpdate()
    {
        playerControlled.MovePosition(playerControlled.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
