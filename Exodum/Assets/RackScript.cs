using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RackScript : MonoBehaviour
{
    public Text loretext;
    public GameObject martillo;
    public puzzle_tic puzzleScript;


    public void Interact()
    {
        if (puzzleScript.puzzleCompletado)
        {
            martillo.SetActive(true);
        }
        else
        {
            loretext.text = "Debo completar el Ahorcado para abrir el rack";
            StartCoroutine(ClearMessageAfterDelay(3f));
        }

        IEnumerator ClearMessageAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay); // Esperar los 3 segundos
            loretext.text = "";

        }
    }
}
