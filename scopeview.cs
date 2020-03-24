using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scopeview : MonoBehaviour
{
    public int zoom = 20;
    public int normal = 60;
    public float smooth = 12;
    public Camera CAM;
    //public Image scopedview11;


    public static bool iszoom = false;

    //public AudioSource zoomsfx;

   


    void Update()
    {
        

        if (Input.GetMouseButtonDown(1))
        {
            //zoomsfx.Play();
            iszoom = !iszoom;
            return;
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
