using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour
{
    Image barh;
    public Text healthbarstatustext;
  


    float maxhealth = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        barh = GetComponent<Image>();
         
    }

   
    void Update()
    {
        barh.fillAmount = Mathf.Lerp(barh.fillAmount, (Target.health / maxhealth),20f*Time.deltaTime) ;

        if(Target.health == maxhealth)
        {
            healthbarstatustext.text = "full Health";
            healthbarstatustext.color = Color.white;
        }
        else if (Target.health <35f)
        {
            healthbarstatustext.text = "low Health";
            healthbarstatustext.color = Color.red;
        }
        else
            healthbarstatustext.text = " ";

    }
}
