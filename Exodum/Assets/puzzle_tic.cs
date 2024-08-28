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


    // Update is called once per frame
     void Start()
    {
        letra = Random.Range(0, 26);
        Debug.Log(letras[letra]);
        

    }
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            juego_comenzo = true;
        }
        //Debug.Log(letras[i]);
        if (juego_comenzo)
        {


            dialogo.text = letras[letra];
            camara_puzzle.gameObject.SetActive(true);
            camara_principal.gameObject.SetActive(false);
  
            if (letra >= 0 && letra < letras.Length)
            {



                foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
                {
                    if (Input.GetKeyDown(key))
                    {

                        if (key.ToString().ToLower() == letras[letra].ToLower())
                        {
                            PuzzleOn();
                            juego_comenzo = false;  
                        }

                        Debug.Log("La tecla " + key.ToString().ToLower() + " está presionada.");
                    }
                }
            }
        }

        
    }

    
    void PuzzleOn()
    {
        Debug.Log("funcionando");
        Debug.Log("Letra correcta");
        dialogo.text = "letra correcta";
    }
   
}
