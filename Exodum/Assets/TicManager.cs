using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicManager : MonoBehaviour
{
    public static TicManager Instance;
    public GameObject Martillo;
    public bool martilloOn;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (martilloOn)
        {
            ActivarMartillo();
        }
    }
    public void ActivarMartillo()
    {
        Martillo.SetActive(true);
    }
}
