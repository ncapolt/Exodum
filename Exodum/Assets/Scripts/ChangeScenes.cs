using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Experimental.XR.Interaction;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{

    void Update()
    {
        if (loremanager.Instance.Irse == true)
        {
            Interact();
        }
    }

    public void Interact()
    {
        
        

            SceneManager.LoadScene("TIC");
        
    }
}
