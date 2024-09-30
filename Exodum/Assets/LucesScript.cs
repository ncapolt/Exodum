using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesScript : MonoBehaviour
{
    public GameObject LucesMedios;
  

    public void Interact()
    {
        
        LucesMedios.SetActive(true); // Deactivates LucesMedios
        loremanager.Instance.Irse = true;
    }


}