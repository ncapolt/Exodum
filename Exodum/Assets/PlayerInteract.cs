using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                NPCInteractable npcInteractable = collider.gameObject.GetComponent<NPCInteractable>();
                if (npcInteractable != null)
                {
                    npcInteractable.Interact();
                }
            }
        }
    }

    // Corregido: O mayúscula en el nombre del método.
    public NPCInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            NPCInteractable npcInteractable = collider.gameObject.GetComponent<NPCInteractable>();
            if (npcInteractable != null) // Verificar que no sea null antes de retornar
            {
                return npcInteractable;
            }
        }
        return null; // Si no encontró ningún NPCInteractable, retorna null
    }
}