using UnityEngine;
using UnityEngine.SceneManagement;

public class pisoScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Debug.Log("Colisión detectada con el jugador. Cambiando a la escena 'DeathScreenPiso'.");
            // Cambia a la escena llamada "DeathScreenPiso"
            SceneManager.LoadScene("DeathScreenPiso");
        }
    }
}
