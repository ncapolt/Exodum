using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class puzzle_tic : MonoBehaviour
{
    public string[] letras;
    public int letra;

    // Start is called before the first frame update


    // Update is called once per frame
     void Start()
    {
        int letra = Random.Range(0, 26);

        Debug.Log(letras[letra]);

    }
    void Update()
    {
        //Debug.Log(letras[i]);

        if (letra >= 0 && letra < letras.Length)
        {



            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(key))
                {
                    
                    if (key.ToString().ToLower() == letras[letra].ToLower())
                    {
                        Debug.Log("Letra correcta");
                    }
                    
                    Debug.Log("La tecla " + key.ToString().ToLower() + " está presionada.");
                }
            }
        }
    }

    
    void PuzzleOn()
    {

    }
   
}
