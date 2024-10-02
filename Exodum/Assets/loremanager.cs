using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class loremanager : MonoBehaviour
{
    public static loremanager Instance; // Singleton
    public bool Irse = false; // Bandera de cambio de escena
    public Text LoreTxt;
    public Text Tareas;
    public Text Aviso;
    bool TareaActiva = false; // Controla si la tarea está activa
    public Lintera linterna;
    public bool LnFun = false; // Controla el estado de la linterna

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Evitar duplicados
        }
    }

    void Start()
    {
        StartCoroutine(LoreMedios());
    }

    void Update()
    {
        // Controlar si la linterna se puede activar
        if (TareaActiva && Input.GetKey(KeyCode.F))
        {
            loremanager.Instance.LnFun = true;
            if (loremanager.Instance.LnFun)
            {
                linterna.LinternaFun();
                LoreTxt.text = "";
            }
        }

        // Verificar si ya se pueden cambiar de escenas (Irse es true)
        if (Irse == true && Tareas.text != "")
        {
            // Llamar función para cambiar la tarea y el texto
            TareasCompletadas();
        }
    }

    // Corrutina para mostrar textos de lore
    IEnumerator LoreMedios()
    {
        yield return new WaitForSeconds(2);
        LoreTxt.text = "¿Donde estoy?";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Alta siesta me pegué...";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Está más oscuro que el futuro del país.";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Debería prender las luces o algo.";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "¿Mi vieja no me había puesto una linterna en la mochila?";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Sí, acá está.";
        yield return new WaitForSeconds(2);
        LoreTxt.text = "Presiona la F para prender la linterna.";
        TareaActiva = true;
        yield return new WaitForSeconds(2);
        StartCoroutine(TareasOn());
    }

    // Corrutina para mostrar las tareas
    IEnumerator TareasOn()
    {
        yield return new WaitForSeconds(0.1f);
        Aviso.text = "Nueva tarea: Busca la térmica y prende las luces.";
        yield return new WaitForSeconds(4);
        Aviso.text = "";
        Tareas.text = "Tareas: Busca la caja de luces en alguna de las aulas.";
    }

    // Método que se llama cuando la condición de 'Irse' es verdadera
    void TareasCompletadas()
    {
        Tareas.text = ""; // Limpiar texto de tareas
        LoreTxt.text = "Ya puedo bajar a TIC!";
        StartCoroutine(MostrarMensajeTemporizado("Ya puedo bajar a TIC!", 2f)); // Corutina para mostrar el mensaje por 2 segundos
    }

    // Corutina para mostrar el mensaje temporalmente
    IEnumerator MostrarMensajeTemporizado(string mensaje, float duracion)
    {
        LoreTxt.text = mensaje;
        yield return new WaitForSeconds(duracion);
        LoreTxt.text = ""; // Limpiar el texto después de la duración
    }
}
