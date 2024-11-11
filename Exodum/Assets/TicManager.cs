using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TicManager : MonoBehaviour
{
    public NavMeshAgent guardia;
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    public Transform PosOriginal;
    public static TicManager Instance;
    public GameObject Martillo;
    public bool martilloOn;
    public Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        if (guardia == null)
            guardia = GetComponent<NavMeshAgent>();
        StartCoroutine(Movimiento());
    }

    // Update is called once per frame
    void Update()
    {
        if (martilloOn)
        {
            ActivarMartillo();
        }
        destination = guardia.destination;
    }
    public void ActivarMartillo()
    {
        Martillo.SetActive(true);
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
