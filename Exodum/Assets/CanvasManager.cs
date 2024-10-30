using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject canvasMenu;     // Canvas del Menú Principal
    public GameObject canvasCreditos; // Canvas de Créditos

    // Muestra el Canvas del Menú Principal y oculta el de Créditos
    public void MostrarMenu()
    {
        canvasMenu.SetActive(true);
        canvasCreditos.SetActive(false);
    }

    // Muestra el Canvas de Créditos y oculta el del Menú Principal
    public void MostrarCreditos()
    {
        canvasMenu.SetActive(false);
        canvasCreditos.SetActive(true);
    }
}
