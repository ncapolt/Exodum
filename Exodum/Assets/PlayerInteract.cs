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
                

                LucesScript lucesScript = collider.gameObject.GetComponent<LucesScript>();
                if (lucesScript != null)
                {
                    lucesScript.Interact();
                }
                
                ChangeScenes ChangeScenes = collider.gameObject.GetComponent<ChangeScenes>();
                if (ChangeScenes != null)
                {
                    ChangeScenes.Interact();
                }

                IrAMedios IrAMedios = collider.gameObject.GetComponent<IrAMedios>();
                if (IrAMedios != null)
                {
                    IrAMedios.Interact();
                }

                puzzle_tic puzzle_tic = collider.gameObject.GetComponent<puzzle_tic>();
                if (puzzle_tic != null)
                {
                    puzzle_tic.Interact();
                }
                RackScript RackScript = collider.gameObject.GetComponent<RackScript>();
                if (RackScript != null)
                {
                    RackScript.Interact();
                }
            }
        }
    }

    // Corregido: O mayúscula en el nombre del método.
    public NPCInteractable GetInteractableObject()
    {
        List<NPCInteractable> npcInteractableList = new List<NPCInteractable>();

        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            NPCInteractable npcInteractable = collider.gameObject.GetComponent<NPCInteractable>();
            if (npcInteractable != null) // Verificar que no sea null antes de retornar
            {
                npcInteractableList.Add(npcInteractable);
                
            }
        }

        NPCInteractable closestNPCInteractable = null;

        foreach (NPCInteractable npcInteractable in npcInteractableList)
        {
            if (closestNPCInteractable == null)
            {
                closestNPCInteractable= npcInteractable;
            }
            else
            {
                if (Vector3.Distance(transform.position, npcInteractable.transform.position) < Vector3.Distance(transform.position, closestNPCInteractable.transform.position))
                {
                    closestNPCInteractable = npcInteractable;
                }
            }
        }


        return closestNPCInteractable;
    }
}