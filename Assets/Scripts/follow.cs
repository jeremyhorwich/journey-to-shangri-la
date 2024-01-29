using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] GameObject yellowHappy;
    [SerializeField] float followSpeed;
    [SerializeField] List<twoWayTeleport> twoWayTeleportList = new List<twoWayTeleport>();
    public static string whichBoxAmI;
    private bool boxFollow;
    Vector3 targetPosition;
    Vector2 targetDistance;
    Vector3 targetDirection;
    makeFollow makeFollow;

    //Initialize ladder teleport functionality
    void Start()
    {
        //makeFollow = this.GetComponent<makeFollow>();
        //makeFollow.BoxCollided += SetBoxToFollow;
        foreach (twoWayTeleport i in twoWayTeleportList)
        {
            i.OriginHit += UpdateBoxPosition;
            whichBoxAmI = "none";
        }
    }

    //Make box follow player if it has been touched
    void Update()
    {
        targetPosition = yellowHappy.GetComponent<Transform>().position;
        targetDistance = targetPosition-this.transform.position;
        if (boxFollow == true && targetDistance.magnitude > 1.5f)
        {
            targetDirection = targetDistance.normalized;
            this.transform.position = new Vector3(this.transform.position.x + targetDirection.x * followSpeed * Time.deltaTime,
            this.transform.position.y + targetDirection.y * followSpeed * Time.deltaTime, this.transform.position.z);
        }
    }

    //Make box follow player when touched
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "yellowHappy")
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.transform.position = new Vector2(targetPosition.x, targetPosition.y - 1);
            boxFollow = true;
            whichBoxAmI = this.gameObject.name;
        }
    }
    
    private void UpdateBoxPosition(object sender, twoWayTeleport.OriginHitEventArgs e)
    {
        if (boxFollow == true) this.transform.position = e.targetPoint;
    }

    private void OnDestroy()
    {
        //makeFollow.BoxCollided -= SetBoxToFollow;
        foreach (twoWayTeleport i in twoWayTeleportList)
        {
            i.OriginHit -= UpdateBoxPosition;
        }
    }
}
