using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

public class GuardiaScript : MonoBehaviour
{
    public float DistanciaVision;
    public NavMeshAgent guardia;
    public Transform jugador;
    public Animator anim;
    bool isChasing = false;
    public LayerMask PLLayer;
    void Start()
    {
        if (guardia == null)
            guardia = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 direccion = jugador.position - transform.position;

        if (Physics.Raycast(transform.position, direccion, out hit, DistanciaVision, PLLayer,QueryTriggerInteraction.Collide))
        {
            Debug.Log(hit.transform);
            if (hit.transform.gameObject.GetComponent<SC_FPSController>() != null)
            {
                Perseguir();
            }
        }
    }

    void Perseguir()
    {
        if (!isChasing)
        {
            isChasing = true;
            guardia.destination = jugador.position;
        }

        Debug.Log("perseguir");
    }

    private void OnDrawGizmos()
    {
        if (jugador != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, jugador.position);
        }
    }
}
