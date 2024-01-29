using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class becomeHappy : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject happyTrigger;

    private void Awake()
    {
        this.enabled = false;
    }
    private void Start()
    {
        Behaviour follow = happyTrigger.GetComponent<follow>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "yellowHappy" && follow.whichBoxAmI == happyTrigger.name)
        {
            Destroy(happyTrigger);
            Destroy(this.gameObject);
            happy = (GameObject)Instantiate(happy, this.transform.position, Quaternion.identity);
            helper.characterList.Add(happy);
            happy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            happy.GetComponent<movementManager>().enabled = false;
            follow.whichBoxAmI = "none";
        }
    }
}