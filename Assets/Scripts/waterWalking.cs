using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class waterWalking : MonoBehaviour
{
    GameObject water;
    private void Awake()
    {
        water = GameObject.Find("Water!");
    }
    private void OnEnable()
    {
        water.GetComponent<TilemapCollider2D>().enabled = false;
    }
    private void OnDisable()
    {
        water.GetComponent<TilemapCollider2D>().enabled = true;
    }
}
