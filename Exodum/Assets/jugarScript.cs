using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CambiarEscenaPorNombre(string nombreEscena)
    {
        SceneManager.LoadScene("Medios");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
