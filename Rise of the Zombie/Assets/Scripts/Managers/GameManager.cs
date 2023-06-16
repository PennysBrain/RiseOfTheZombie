using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int zombieCount;
    public int zombieExcaped;

    public int increase;
    public int decrease;

    public int difficultyLevel;

    private ZombieCountUI zombieCountUI;

    private void Awake()
    {
        instance = this;
        increase = 10;
        zombieCountUI = FindObjectOfType<ZombieCountUI>();
    }

    public void Difficulty()
    {
        switch (difficultyLevel)
        {
            case 1: // Easy mode
                break;

            case 2: // Normal Mode
                break;

            case 3: // Hard Mode
                break;

            default: // Normal
                break;
        }
    }

    private void TurnUpTheHeat()
    {
        if (zombieCount >= increase)
        {
            // Increase the difficulty
        }
    }

    // Call this method when a zombie is killed
    public void ZombieKilled()
    {
        zombieCount++;
        zombieCountUI.AddXPOnZombieKill();
        TurnUpTheHeat();
    }
}
