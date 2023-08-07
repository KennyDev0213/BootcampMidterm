using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryScript : MonoBehaviour, IPickupObject
{
    Rigidbody rb;
    public Transform playerHand;

    public void Drop()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    public void Interact()
    {
        HandScript.Drop();
        HandScript.SetObjectInHand(gameObject);
        PickUp(playerHand);
    }

    public void PickUp(Transform position)
    {
        rb.isKinematic = true;
        rb.useGravity = false;

        transform.SetParent(position);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (playerHand == null) {
            playerHand = HandScript.hand;
        }
    }

}
