using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePadScript : MonoBehaviour
{

    public AudioSource activateSound, deactivateSound;
    [SerializeField] UnityEvent padActivateEvent, padDeactivateEvent;

    private void OnTriggerEnter(Collider other) {
        activateSound?.Play();
        padActivateEvent?.Invoke();
    }

    private void OnTriggerExit(Collider other) {
        deactivateSound?.Play();
        padDeactivateEvent?.Invoke();
    }
}
