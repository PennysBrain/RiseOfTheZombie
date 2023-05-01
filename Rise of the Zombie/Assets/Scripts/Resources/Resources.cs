using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public string Type;
    public int amount;

    public void AddResources()
    {
        amount++;
    }

  public  void RemoveResources()
    {
        amount--;
    }
}
