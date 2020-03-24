using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopeview3 : MonoBehaviour
{
    public int zoom = 25;
    public int normal = 60;
    public float smooth = 12;
    public Camera CAM;


    public static bool iszoom = false;


    //public AudioSource zoomsfx;


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //zoomsfx.Play();
            iszoom = !iszoom;
        }
        if (iszoom)
        {
            CAM.fieldOfView = Mathf.Lerp(CAM.fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            CAM.fieldOfView = Mathf.Lerp(CAM.fieldOfView, normal, Time.deltaTime * smooth);
        }
    }
}
