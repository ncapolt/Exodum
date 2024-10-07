using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martilloScript : MonoBehaviour
{
    public Transform startPosition;  // Empty que define la posición inicial
    public Transform endPosition;    // Empty que define la posición final
    public float speed = 5.0f;       // Velocidad de la animación
    private bool isSwinging = false; // Para controlar si el martillo está en movimiento
    private bool returning = false;  // Para controlar el regreso del martillo

    void Update()
    {
        // Si se hace clic con el mouse y el martillo no está en movimiento
        if (Input.GetMouseButtonDown(0) && !isSwinging)
        {
            isSwinging = true; // Comienza el swing
        }

        // Mover el martillo hacia la posición final
        if (isSwinging && !returning)
        {
            transform.position = Vector3.Lerp(transform.position, endPosition.position, speed * Time.deltaTime);

            // Cuando llega a la posición final
            if (Vector3.Distance(transform.position, endPosition.position) < 0.1f)
            {
                returning = true; // Ahora regresa a la posición inicial
            }
        }

        // Mover el martillo de regreso a la posición inicial
        if (returning)
        {
            transform.position = Vector3.Lerp(transform.position, startPosition.position, speed * Time.deltaTime);

            // Cuando regresa a la posición inicial
            if (Vector3.Distance(transform.position, startPosition.position) < 0.1f)
            {
                returning = false;  // Resetea el regreso
                isSwinging = false; // Detiene el movimiento
            }
        }
    }

    // Método que se llama cuando el martillo toca otro objeto
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto golpeado tiene el tag "Destructible"
        if (other.CompareTag("Destructible"))
        {
            Debug.Log("Martillo impactó una silla destructible.");
        }
    }
}