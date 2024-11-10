using UnityEngine;

public class HammerMove : MonoBehaviour
{
    public Transform startPosition;  // Empty que define la posición inicial
    public Transform endPosition;    // Empty que define la posición final
    public float speed = 5.0f;       // Velocidad de la animación
    private bool isSwinging = false; // Para controlar si el martillo está en movimiento
    private bool returning = false;  // Para controlar el regreso del martillo
    public Collider colliderMartillo;
    public GameObject[] destructibleObjects;  // Array para las sillas u objetos que quieres destruir
    public bool bancoDestroy;

    void Update()
    {
        // Si se hace clic con el mouse y el martillo no está en movimiento
        if (Input.GetMouseButtonDown(0) && !isSwinging)
        {
            isSwinging = true; // Comienza el swing
            colliderMartillo.enabled = true;
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
                colliderMartillo.enabled = false;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destructible")
        {
            Destroy(collision.gameObject);
            bancoDestroy = true;
        }
    }

}