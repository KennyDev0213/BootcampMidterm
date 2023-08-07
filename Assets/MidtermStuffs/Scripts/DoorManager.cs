using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager instance;

    [SerializeField] MDoor[] doors;

    private void Awake() {
        if(instance != null && instance != this) 
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public DoorManager GetInstance()
    {
        return instance;
    }

    public void DisableDoorAt(int doorId) {
        foreach(MDoor door in doors) {
            if(door.id == doorId) {
                door.Deactivate();
                //return;
            }
        }
    }

    public void EnableDoorAt(int doorId) {
        foreach(MDoor door in doors) {
            if(door.id == doorId) {
                door.Activate();
                //return;
            }
        }
    }
}
