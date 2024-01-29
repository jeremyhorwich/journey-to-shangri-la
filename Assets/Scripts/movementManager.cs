using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementManager : MonoBehaviour
{
    [SerializeField] private Behaviour[] moveAbilities;

    private void OnEnable()
    {
        for (int i = 0; i < moveAbilities.Length; i++)
        {
            moveAbilities[i].enabled = true;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < moveAbilities.Length; i++)
        {
            moveAbilities[i].enabled = false;
        }
    }
}
