using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    PlayerInput playerInput;

    [SerializeField] Camera cam;

    public float interactionDistance = 1f;

    void Start()
    {
        playerInput = PlayerInput.GetInstance();
        if(cam == null){
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void DoUpdate()
    {
        if (playerInput.activatePressed)
        {
            Ray r = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(r, out hit, interactionDistance)){
                IInteractible interactible = hit.transform.GetComponent<IInteractible>();
                if(interactible != null){
                    interactible.Interact();
                }
            }
        }
    }

    private void Update() {
        DoUpdate();
    }
}
