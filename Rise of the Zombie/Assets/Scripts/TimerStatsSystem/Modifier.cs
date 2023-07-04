using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Modifier : MonoBehaviour
{
    [SerializeField] List<Stat> statsToModify = new List<Stat>();
    [SerializeField] Timer curretTime;
    public float countIncrease = 1;
    public int multiply = 1;
    public Stat statMultiplyTracker;

    private void Awake()
    {
        if (curretTime == null)
        {
            Debug.Log(this.gameObject.name + " NEEDS A TIMER ASSIGNED");
        }
        if (statMultiplyTracker == true)
        {
            multiply = (int) statMultiplyTracker.count;
        }
    }

    private void Update()
    {
        if (statMultiplyTracker == true)
        {
            multiply = (int)statMultiplyTracker.count;
        }

        if (curretTime.timeWasReset)
        {
            for (int i = 0; i < statsToModify.Count; i++)
            {
                statsToModify[i].count += (countIncrease * multiply);
            }
        }
    }
}
