using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Batt_SocketScript : MonoBehaviour, IInteractible
{
    HandScript playerHand;
    [SerializeField] UnityEvent socketEvent;
    public Transform socket;

    private void Start() {
        playerHand = HandScript.GetInstance();
    }

    public void Interact(){
        GameObject obj = HandScript.objectinHand;
        if(obj == null || obj.tag != "Battery"){
            return;
        }

        BatteryScript batteryInstance = obj.GetComponent<BatteryScript>();
        batteryInstance.PickUp(socket);

        batteryInstance.enabled = false;

        socketEvent?.Invoke();
    }
}
