using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    enum GameState
    {
        Start,
        Playing,
        GameOver
    }

    GameState currentState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = GameState.Start;
        Debug.Log("Game is starting");

        currentState = GameState.Playing;
        Debug.Log("Current State: " + currentState);

        currentState = GameState.GameOver;
        Debug.Log("Game Over!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
