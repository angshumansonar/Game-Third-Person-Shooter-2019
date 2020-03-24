using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammofill3 : MonoBehaviour
{
    Image ammo3;

    private float maxxammo = 300f;

    // Start is called before the first frame update
    void Start()
    {
        ammo3 = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        ammo3.fillAmount = Gunpoint3.totalammo / maxxammo;

    }
}
