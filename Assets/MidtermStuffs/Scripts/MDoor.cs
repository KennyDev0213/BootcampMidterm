using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDoor : MonoBehaviour
{
    public AudioSource deactivateAudio, activateAudio;
    public int id = -1;

    public void Activate()
    {
        activateAudio?.Play();
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        deactivateAudio?.Play();
        gameObject.SetActive(false);
    }
}
