using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lintera : MonoBehaviour
{
    public Light LuzLinterna;
    public bool Luzfunciona;
    public loremanager loremanager;
    // Start is called before the first frame update
    void Start()
    {
        LuzLinterna.enabled = false;
        Luzfunciona = loremanager.LnFun;
    }

    // Update is called once per frame
    void Update()
    {
        /*   if (Input.GetButtonDown("Linterna"))
           {
               if (LuzLinterna.enabled == false)
               {
                   LuzLinterna.enabled = true;
               }
               else if (LuzLinterna.enabled == true)
               {
                   LuzLinterna.enabled = false;
               }
           }*/

        if (Luzfunciona)
        {
         
            LinternaFun();
        }

        }
        /*public void Prenderlinterna()
    {
        LuzLinterna.enabled = true;
    }*/
    public void LinternaFun()
    {
        if (Input.GetButtonDown("Linterna"))
        {
            if (LuzLinterna.enabled == false)
            {
                LuzLinterna.enabled = true;
            }
            else if (LuzLinterna.enabled == true)
            {
                LuzLinterna.enabled = false;
            }
        }
    }

}
