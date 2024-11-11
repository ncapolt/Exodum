using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Script_GBP : MonoBehaviour
{
    public NavMeshAgent guardiaPB;
    public Transform PLayer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        guardiaPB.speed = speed;
        guardiaPB.destination = PLayer.position;
        StartCoroutine(Fast());
    }

    // Update is called once per frame
    void Update()
    {
        guardiaPB.destination = PLayer.position;
       

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
    IEnumerator Fast()
    {
        yield return new WaitForSeconds(1);
        speed ++;
        yield return new WaitForSeconds(0.1f);
        Fast();
    }
}
