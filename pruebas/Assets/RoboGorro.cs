using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboGorro : MonoBehaviour
{
    public GameObject gorroAgente;
    public GameObject gorroSoldado;
    public bool isVulnerable = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RobaElGorro();
        }
    }

    void RobaElGorro()
    {
        gorroSoldado.SetActive(!gorroSoldado.activeInHierarchy);
        gorroAgente.SetActive(!gorroAgente.activeInHierarchy);
    }
}
