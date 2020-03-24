using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammofill : MonoBehaviour
{
    Image ammo1;

   private float maxxammo = 150f;
   
    // Start is called before the first frame update
    void Start()
    {
        ammo1 = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        ammo1.fillAmount = Gunpoint.totalammo / maxxammo;

    }
}
