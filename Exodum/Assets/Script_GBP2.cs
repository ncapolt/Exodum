using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Script_GBP2 : MonoBehaviour
{
    public NavMeshAgent guardiaPB;
    public Transform Player;
    bool persigo = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Correr());
    }

    // Update is called once per frame
    void Update()
    {
        if (persigo == true)
        {
            guardiaPB.destination = Player.position;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque");
        if (collision.gameObject.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


            string currentScene = SceneManager.GetActiveScene().name;


            if (currentScene == "TIC")
            {
                SceneManager.LoadScene("DeathScreen");
            }
            else if (currentScene == "PlantaBaja")
            {
                SceneManager.LoadScene("DeathScreenGuardia2");
            }

        }
    }
    IEnumerator Correr()
    {
        yield return new WaitForSeconds(15);
        persigo = true;

    }
    
}
