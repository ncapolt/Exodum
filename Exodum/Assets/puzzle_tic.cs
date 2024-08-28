using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class puzzle_tic : MonoBehaviour
{
    public string[] letras;
    public int letra;
    public Text dialogo;
    public GameObject camara_puzzle;
    public GameObject camara_principal;
    bool juego_comenzo;

    // Start is called before the first frame update
    void Start()
    {
        letra = Random.Range(0, letras.Length); 
        Debug.Log(letras[letra]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            juego_comenzo = true;
        }
        if (Input.GetKeyDown("o"))
        {
            juego_comenzo = false;
            camara_puzzle.SetActive(false);
            camara_principal.SetActive(true);
        }

        if (juego_comenzo)
        {
            dialogo.text = letras[letra];
            camara_puzzle.SetActive(true);
            camara_principal.SetActive(false);

            puzzle();
        }
    }

    void PuzzleOn()
    {
        Debug.Log("funcionando");
        Debug.Log("Letra correcta");
        dialogo.text = "letra correcta";
    }

    void puzzle()
    {
        if (letra >= 0 && letra < letras.Length)
        {
            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(key))
                {
                    if (key.ToString().ToLower() == letras[letra].ToLower())
                    {
                        PuzzleOn();
                        repeticion();
                        
                    }

                    Debug.Log("La tecla " + key.ToString().ToLower() + " está presionada.");
                }
            }
        }
 
    }

    void repeticion()
    {
        letra = Random.Range(0, letras.Length);
    }

}

