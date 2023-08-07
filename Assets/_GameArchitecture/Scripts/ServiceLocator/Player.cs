using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody cameraRb;
    public Health playerHealth;
    private IAudioManager audioManager;

    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = ServiceLocator.GetService<IAudioManager>();
        playerHealth.OnDeath += Death;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioManager.PlayAudio(clip);
        }
    }
    
    void Death()
    {
        cameraRb.useGravity = true;
        cameraRb.isKinematic = false;
        PlayerInput.GetInstance().isDisabled = true; 
    }
}
