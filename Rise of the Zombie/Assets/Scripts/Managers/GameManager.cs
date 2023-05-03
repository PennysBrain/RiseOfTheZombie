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

    private void Awake()
    {
        increase = +10;
        instance = this;
    }

    public void Difficulty()
    {
        switch (difficultyLevel)
        {
            case 1://Easy mode

                break;

            case 2://Normal Mode

                break;
           
            case 3://Hard Mode

                break;
            default://Normal
             
                break;
        }
    }

    private void TurnUpTheHeat()
    {
        if (zombieCount >= increase)
        {
            //
        }
    }

    
}
