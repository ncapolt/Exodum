
﻿using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

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
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    public Transform PosOriginal;
    public HammerMove HammerMove;
    void Start()
    {
        if (guardia == null)
            guardia = GetComponent<NavMeshAgent>();
        StartCoroutine(Movimiento());
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
        if (HammerMove.bancoDestroy == true)
        {
            Perseguir();
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
            if (collision.gameObject.CompareTag("Player"))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                // Obtener la escena actual
                string currentScene = SceneManager.GetActiveScene().name;

                // Cambiar la escena dependiendo de la escena actual
                if (currentScene == "TIC")
                {
                    SceneManager.LoadScene("DeathScreen"); // Cambia "EscenaFinal" por la escena a la que quieres ir
                }
                else if (currentScene == "PlantaBaja")
                {
                    SceneManager.LoadScene("DeathScreenGuardia2");
                }
                // Agrega más condiciones para otras escenas si es necesario
            }
        }
        
    

    void IrAPosi1()
    {
        guardia.destination = Pos1.position;
    }
    void IrAPosi2()
    {
        guardia.destination = Pos2.position;
    }
    void IrAPosi3()
    {
        guardia.destination = Pos3.position;
    }
    void IrAPosiOriginal()
    {
    guardia.destination = PosOriginal.position;
    }
    IEnumerator Movimiento()
    {
        yield return new WaitForSeconds(3);
        IrAPosi1();
        yield return new WaitForSeconds(3);
        IrAPosi2();
        yield return new WaitForSeconds(3);
        IrAPosi3();
        yield return new WaitForSeconds(3);
        IrAPosiOriginal();
        yield return new WaitForSeconds(3);
        StartCoroutine(Movimiento());


    }
        
}
