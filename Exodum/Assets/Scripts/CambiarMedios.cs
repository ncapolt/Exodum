using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarMedios : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("TIC");
        }
    }
}
