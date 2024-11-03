using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class puzzle_tic : MonoBehaviour
{
    public string[] palabras;
    public int acierto;
    public Text dialogo;
    public GameObject camara_puzzle;
    public GameObject camara_principal;
    public Text textoSalir;
    public GameObject interactUI;

    [HideInInspector]
    public bool puzzleCompletado = false; // Esta variable indica si el puzzle está completo

    private bool juego_comenzo;
    private string palabraActual;
    private char[] palabraMostrar;
    private string textoPrincipal;

    void Start()
    {
        acierto = 0;
        SeleccionarPalabraAleatoria();
        camara_puzzle.SetActive(false);
        dialogo.text = "";
        dialogo.gameObject.SetActive(false);
        textoSalir.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (juego_comenzo)
        {
            puzzle();
        }
    }

    public void Interact()
    {
        if (!juego_comenzo)
        {
            juego_comenzo = true;
            camara_puzzle.SetActive(true);
            camara_principal.SetActive(false);
            textoPrincipal = new string(palabraMostrar);
            dialogo.text = textoPrincipal;
            dialogo.gameObject.SetActive(true);

            textoSalir.gameObject.SetActive(true);
            interactUI.SetActive(false);
        }
        else
        {
            TerminarJuego();
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

        textoPrincipal = new string(palabraMostrar);
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
                        textoPrincipal = new string(palabraMostrar);
                        dialogo.text = textoPrincipal;
                        Debug.Log("Letra correcta: " + letra);
                    }
                    else
                    {
                        StartCoroutine(MostrarLetraIncorrecta());
                        Debug.Log("Letra incorrecta: " + letra);
                    }

                    if (new string(palabraMostrar) == palabraActual)
                    {
                        juego_comenzo = false;
                        puzzleCompletado = true; // Indica que el puzzle está completado
                        dialogo.text = "¡Palabra completa, puzzle superado!";
                        StartCoroutine(Esperame());
                    }
                    break;
                }
            }
        }
    }

    void TerminarJuego()
    {
        juego_comenzo = false;
        dialogo.text = "";
        dialogo.gameObject.SetActive(false);
        camara_puzzle.SetActive(false);
        camara_principal.SetActive(true);

        textoSalir.gameObject.SetActive(false);
        interactUI.SetActive(true);
    }

    IEnumerator MostrarLetraIncorrecta()
    {
        dialogo.text = "Letra incorrecta";
        yield return new WaitForSeconds(2);
        dialogo.text = textoPrincipal;
    }

    IEnumerator Esperame()
    {
        yield return new WaitForSeconds(5);
        TerminarJuego();
    }
}
