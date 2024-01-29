using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControlSwitch : MonoBehaviour
{
    List<GameObject> characterList;
    [SerializeField] private GameObject mainCamera;
    int controlCounter = 0;

    //Initialize Yellow Happy being controlled
    private void Start()
    {
        characterList = helper.characterList;
        characterList.Add(GameObject.Find("yellowHappy"));

        for (int i = 0; i < characterList.Count; i++)
        {
            //characterList[i].GetComponent<BoxCollider2D>().enabled = false;
            characterList[i].GetComponent<movementManager>().enabled = false;
            characterList[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        }
        //characterList[controlCounter].GetComponent<BoxCollider2D>().enabled = true;
        characterList[controlCounter].GetComponent<movementManager>().enabled = true;
        characterList[controlCounter].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Switch which character is being controlled
            for (int i = 0; i < characterList.Count; i++)
            {
                //characterList[i].GetComponent<BoxCollider2D>().enabled = false;
                characterList[i].GetComponent<movementManager>().enabled = false;
                characterList[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
            controlCounter = (controlCounter + 1) % characterList.Count;
            //characterList[controlCounter].GetComponent<BoxCollider2D>().enabled = true;
            characterList[controlCounter].GetComponent<movementManager>().enabled = true;
            characterList[controlCounter].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

            //Switch the camera to follow the new character
            helper.playerFinder(characterList[controlCounter].transform.position, mainCamera);
        }
    }
}
