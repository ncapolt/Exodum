using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private string interactText;

    public void Interact()
    {
        SceneManager.LoadScene("TIC");
    }
}
