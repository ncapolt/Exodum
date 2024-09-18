using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lintera : MonoBehaviour
{
    public Light LuzLinterna;
    // Start is called before the first frame update
    void Start()
    {
        LuzLinterna.enabled = false;
    }

    // Update is called once per frame
    void Update()
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
    public void Prenderlinterna()
    {
        LuzLinterna.enabled = true;
    }

}
