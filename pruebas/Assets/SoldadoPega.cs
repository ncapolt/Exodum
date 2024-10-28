using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldadoPega : MonoBehaviour
{
    public Animator anim;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("Punch");
        }
    }
}
