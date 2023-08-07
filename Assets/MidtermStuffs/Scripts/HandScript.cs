using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    private void Start() {
        hand = transform;
    }

    public static HandScript instance;

    public static HandScript GetInstance()
    {
        return instance;
    }

    public static GameObject objectinHand;

    public static Transform hand;

    public static Transform GetHand(){
        return hand;
    }

    public static void SetObjectInHand(GameObject obj)
    {
        objectinHand = obj;
    }

    public static void Drop()
    {
        if(objectinHand == null) return;

        IPickupObject obj = objectinHand.GetComponent<IPickupObject>();
        obj.Drop();
    }
}
