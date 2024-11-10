using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lore_manager : MonoBehaviour
{
    
    public puzzle_tic puzzle_Tic;
    public Text Lore;
    public HammerMove HammerMove;
    
    void Start()
    {
        StartCoroutine(Lores());
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle_Tic.puzzleCompletado)
        {

        }
        if (HammerMove.bancoDestroy == true)
        {
            StartCoroutine(GuardiaPersigue());
        }
    }
    IEnumerator Lores()
    {
        yield return new WaitForSeconds(2);
        Lore.text = "Deberia de ir a planta baja";
        yield return new WaitForSeconds(2);
        Lore.text = "Por haber prendido las luces aparecieron varios guardias en Tic y PB";
        yield return new WaitForSeconds(2);
        Lore.text = "Aparte tengo que sacar lo bancos estos";
        yield return new WaitForSeconds(2);
        Lore.text = "Cierto que en L1 estaba la maza de ivo que usa con los de river";
        yield return new WaitForSeconds(2);
        Lore.text = "";
    }
    IEnumerator puzzle_hecho()
    {
        yield return new WaitForSeconds(2);
        Lore.text = "Ahora ya puedor abrir el Rack que tiene el martillo y romper los bancos  ";
    }
    IEnumerator GuardiaPersigue()
    {
        yield return new WaitForSeconds(2);
        Lore.text = "Ahora el guarida te escucho y te esta persiguiendo, CORRE!!!!";
        yield return new WaitForSeconds(2);
        Lore.text = "";
    }
}
