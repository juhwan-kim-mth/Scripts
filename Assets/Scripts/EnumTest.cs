using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    public enum GameState
    {
        Ready,
        Playing,
        Pause,
        GameOver
    };

    public GameState state;
    
    
    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Ready;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameState.Ready:
                print("You are Ready");
                break;
            case GameState.Playing:
                print("Game Playing");
                break;
            case GameState.Pause:
                print("Pause");
                break;
            case GameState.GameOver:
                print("Game Over");
                break;
        }
    }
}
