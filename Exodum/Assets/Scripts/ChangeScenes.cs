using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Método de interacción para la puerta
    public void Interact()
    {
        // Si la variable 'Irse' es true, se permite cambiar de escena
        if (loremanager.Instance.Irse == true)
        {
            SceneManager.LoadScene("TIC");
        }
        else
        {
            // Mostrar el texto de advertencia y empezar la corutina para borrarlo después de 3 segundos
            loremanager.Instance.LoreTxt.text = "Debo prender las luces antes de mandarme a TIC";
            StartCoroutine(ClearMessageAfterDelay(3f)); // Llamar la corutina para borrar el mensaje
        }
    }

    // Corutina para borrar el mensaje después de un tiempo
    IEnumerator ClearMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Esperar los 3 segundos
        loremanager.Instance.LoreTxt.text = ""; // Borrar el texto
    }
}
