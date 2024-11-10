using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawnearymenu : MonoBehaviour
{
    
    public void Respawn()
    {
        SceneManager.LoadScene("TIC");
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
