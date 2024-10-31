using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackScript : MonoBehaviour
{
    public GameObject martillo;

    // Start is called before the first frame update
    public void Interact()
    {
        martillo.SetActive(true); // Activa el GameObject martillo
    }
}
