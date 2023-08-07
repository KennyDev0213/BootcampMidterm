using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    public static CutsceneManager instance;

    PlayerInput playerInput;

    public GameObject playerObject;

    public UIManager uiManager;

    [SerializeField] PlayableDirector introScene;
    [SerializeField] PlayableDirector lossScene;
    [SerializeField] PlayableDirector winScene;

    [SerializeField] GameObject[] cutsceneCameras;
    

    [SerializeField] Health _playerHealth;

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

    public static CutsceneManager GetInstance(){
        return instance;
    }

    private void Start() {
        playerInput = PlayerInput.GetInstance();
        _playerHealth.OnDeath += PlayDeathScene;
    }

    private void OnEnable() {
        introScene.stopped += EnablePlayer;
    }

    private void OnDisable() {
        introScene.stopped -= EnablePlayer;
    }

    private void PlayDeathScene() {
        lossScene.Play();
    }

    void DisablePlayerInput()
    {
        playerInput.isDisabled = true;
    }

    public void PlayIntro()
    {
        playerObject.SetActive(false);
        playerInput.isDisabled = true;
        DisablePlayerInput();
        introScene.Play();
    }

    public void PlayWin()
    {
        uiManager.OnWin();
        winScene.Play();
    }

    public void PlayLoss()
    {
        //lossScene.Play();
    }

    private void EnablePlayer(PlayableDirector director) {
        foreach(GameObject cam in cutsceneCameras)
        {
            cam.SetActive(false);
        }
        playerInput.isDisabled = false;
        playerObject.SetActive(true);
    }
}
