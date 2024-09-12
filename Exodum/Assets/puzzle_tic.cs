using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class puzzle_tic : MonoBehaviour
{
    public string[] palabras;  
    public int acierto;
    public Text dialogo;
    public GameObject camara_puzzle;
    public GameObject camara_principal;
    bool juego_comenzo;

    private string palabraActual;  
    private char[] palabraMostrar; 

    // Start is called before the first frame update
    void Start()
    {
        acierto = 0;
        SeleccionarPalabraAleatoria();
    }

    // Update is called once per frame
    public void Interact()
    { 
        {
            juego_comenzo = true;
        }
        if (Input.GetKeyDown("escape"))
        {
            juego_comenzo = false;
            dialogo.text = "";
            camara_puzzle.SetActive(false);
            camara_principal.SetActive(true);
        }

        if (juego_comenzo)
        {
            camara_puzzle.SetActive(true);
            camara_principal.SetActive(false);

            puzzle();
        }
    }

    void SeleccionarPalabraAleatoria()
    {
        int indice = Random.Range(0, palabras.Length);
        palabraActual = palabras[indice].ToUpper();  
        palabraMostrar = new string('_', palabraActual.Length).ToCharArray();

        palabraMostrar[0] = palabraActual[0];
        palabraMostrar[palabraActual.Length - 1] = palabraActual[palabraActual.Length - 1];

        for (int i = 0; i < palabraActual.Length; i++)
        {
            if (palabraActual[i] == ' ')
            {
                palabraMostrar[i] = ' ';  
            }
        }

        dialogo.text = new string(palabraMostrar);
    }

    void puzzle()
    {
        if (palabraActual != null)
        {
            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(key))
                {
                    char letra = key.ToString().ToUpper()[0];
                    bool letraEncontrada = false;

                    for (int i = 0; i < palabraActual.Length; i++)
                    {
                        if (palabraActual[i] == letra)
                        {
                            palabraMostrar[i] = letra;
                            letraEncontrada = true;
                        }
                    }

                    if (letraEncontrada)
                    {
                        dialogo.text = new string(palabraMostrar);
                        Debug.Log("Letra correcta: " + letra);
                    }
                    else
                    {
                        dialogo.text = "Letra incorrecta";
                        Debug.Log("Letra incorrecta: " + letra);
                    }

                    if (new string(palabraMostrar) == palabraActual)
                    {
                        juego_comenzo = false;
                        dialogo.text = "¡Palabra completa, puzzle superado!";
                        StartCoroutine(Esperame());
                    }
                }
            }
        }
    }

    IEnumerator Esperame()
    {
        yield return new WaitForSeconds(5);
        dialogo.text = "";
        camara_puzzle.SetActive(false);
        camara_principal.SetActive(true);
    }
}
