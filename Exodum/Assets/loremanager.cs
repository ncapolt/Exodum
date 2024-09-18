﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class loremanager : MonoBehaviour
{
    public Text LoreTxt;
    public Text Tareas;
    bool TareaActiva;
    public Lintera linterna;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (LoreMedios ());
    }

    // Update is called once per frame
    void Update()
    {
        if (TareaActiva) 
        {
            if (Input.GetKeyUp(KeyCode.F)) 
            {
                linterna.Prenderlinterna();
                LoreTxt.text = null;
            }
        }

    }
    IEnumerator LoreMedios()
    {
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Donde estoy loco?";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Alta siesta me pegue, creo que tenia noni";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Esta mas oscuro que el futuro del pais";
        yield return new WaitForSeconds (2);
        LoreTxt.text = "Deberia prender las luces o algo";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "¿Mi vieja no me habia puesto una linterna en la mochila?";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Si, aca esta";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Apreta la F para prender la linterna";
        TareaActiva = true;

    }
}
