using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("Medios");
        }
    }
}
