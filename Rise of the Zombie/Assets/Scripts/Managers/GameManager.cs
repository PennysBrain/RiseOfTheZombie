using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int zombieCount;
    public int increase;
    public int decrease;

    public int difficultyLevel;

    private void Awake()
    {
        increase = +10;
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
