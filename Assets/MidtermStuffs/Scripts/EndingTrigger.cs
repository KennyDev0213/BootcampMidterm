using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        //Debug.Log(CutsceneManager.GetInstance());
        if (other.gameObject.tag == "Player") {
            PlayerInput.GetInstance().isDisabled = true;
            CutsceneManager.GetInstance().PlayWin();
        }
    }
}
