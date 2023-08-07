using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelManager[] Levels;
    public static GameManager instance {get; private set;}
    private GameState currentState;
    private LevelManager currentLevel;
    private int currentLevelIndex;
    private bool inputActive;

    private void Awake() {
        
        if(instance != null && instance != this){
            Destroy(gameObject);
            return;
        }

        
        instance = this;
    }

    public static GameManager GetInstance() {
        return instance;
    }

    public bool IsInputActive() {
        return inputActive;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProcessState(GameState state, LevelManager level){
        currentLevel = level;
        currentState = state;

        switch (currentState)
        {
            case GameState.Briefing:
            break;

            case GameState.LevelStart:
            break;

            case GameState.LevelIn:
            break;

            case GameState.LevelEnd:
            break;

            case GameState.GameOver:
            break;

            case GameState.GameEnd:
            break;
        }
    }
}


public enum GameState
{
    Briefing,
    LevelStart,
    LevelIn,
    LevelEnd,
    GameOver,
    GameEnd
}