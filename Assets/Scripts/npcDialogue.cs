using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcDialogue : MonoBehaviour
{
    [SerializeField] Text dialogueBox;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueBox.enabled = false;
    }
}
