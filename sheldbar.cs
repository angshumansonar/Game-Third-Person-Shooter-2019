using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sheldbar : MonoBehaviour
{
    Image shildbar;
    public Text ssbarstatustext;

    float maxpo = 100f;

    // Start is called before the first frame update
    void Start()
    {
        shildbar = GetComponent<Image>();

    }


    void Update()
    {
        shildbar.fillAmount =Mathf.Lerp(shildbar.fillAmount,(Target.shieldpower / maxpo),20f*Time.deltaTime);

        if (Target.shieldpower == maxpo)
        {
            ssbarstatustext.text = "Full Shield";
            ssbarstatustext.color = Color.white;
        }
        
        else if (Target.shieldpower<=0f)
        {
            ssbarstatustext.text = "No Shield";
            ssbarstatustext.color = Color.red;
        }
        else
            ssbarstatustext.text = " ";
    }
}