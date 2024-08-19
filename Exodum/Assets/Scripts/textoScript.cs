using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoScript : MonoBehaviour
{
    // Reference to the Text UI component
    public Text textoNotificacion;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure that textoNotificacion is assigned and initialize it properly
        if (textoNotificacion != null)
        {
            textoNotificacion.text = "";  // Initialize with an empty string
        }
        else
        {
            Debug.LogError("TextoNotificacion is not assigned in the inspector.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add functionality here if needed
    }

    // Method to show notification text
    public void MostrarNotificacion(string mensaje)
    {
        if (textoNotificacion != null)
        {
            textoNotificacion.text = mensaje;
        }
        else
        {
            Debug.LogError("TextoNotificacion is not assigned.");
        }
    }
}
