using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpointscript : MonoBehaviour
{
    public GameObject theplayer;
    public float placeX;
    public float placeZ;
    
    void Start()
    {
        placeX = Random.Range(30,-30);
        placeZ = Random.Range(30,-30);
        theplayer.transform.position = new Vector3(placeX, 10f, placeZ);
    }

}
