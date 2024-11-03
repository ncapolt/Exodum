using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackScript : MonoBehaviour
{
    public GameObject martillo;
    public puzzle_tic puzzleScript; // Referencia al script del puzzle

    public void Interact()
    {
        if (puzzleScript.puzzleCompletado) // Verifica si el puzzle está completado
        {
            martillo.SetActive(true); // Activa el GameObject martillo
        }
       
    }
}
