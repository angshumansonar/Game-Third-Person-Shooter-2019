using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammofill2 : MonoBehaviour
{
    Image ammo2;

   private float maxxammo =30f;

    // Start is called before the first frame update
    void Start()
    {
        ammo2 = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        ammo2.fillAmount = Gunpoint2.totalammo / maxxammo;

    }
}
