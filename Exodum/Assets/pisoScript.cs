using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pisoScript
    : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Jugador ha colisionado con el piso.");
            SceneManager.LoadScene("DeathScreenPiso");
        }
    }

}
