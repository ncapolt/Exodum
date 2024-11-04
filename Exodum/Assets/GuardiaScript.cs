﻿
﻿using System.Collections;
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
    public bool isChasing = false;
    public LayerMask PLLayer;
    public Vector3 destination;
    public Transform RayPosi;
    public GameObject Death_Screen;
    void Start()
    {
        if (guardia == null)
            guardia = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        destination = guardia.destination;
        RaycastHit hit;
        Vector3 direccion = jugador.position - transform.position;

        if (Physics.Raycast(RayPosi.position, RayPosi.forward, out hit, DistanciaVision, PLLayer, QueryTriggerInteraction.Collide))
        {
            Debug.Log(hit.transform);
            if (hit.transform.gameObject.GetComponent<SC_FPSController>() != null)
            {
                Perseguir();
            }
        }
        if (Physics.Raycast(RayPosi.position, RayPosi.right, out hit, DistanciaVision, PLLayer, QueryTriggerInteraction.Collide))
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
        //if (!isChasing)
        //{
           // isChasing = true;
            guardia.destination = jugador.position;
      //  }
        //else
        //{
        //    isChasing = false;
        //}

        Debug.Log("perseguir");
    }

    private void OnDrawGizmos()
    {
        if (jugador != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(RayPosi.position, RayPosi.position + RayPosi.forward * 5);
            Gizmos.DrawLine(RayPosi.position, RayPosi.position + RayPosi.right * 5);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque");

        
            Death_Screen.SetActive(true);
        
    }
}
