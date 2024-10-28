using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAgente : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform targetTR;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = targetTR.position;
        anim.SetFloat("Speed", agente.velocity.magnitude);
    }
}
