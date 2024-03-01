using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRubOrChop : MonoBehaviour
{
    float currentTimer;
    bool currentlyHoldingDown;
    
    private void Update()
    {
        if (currentlyHoldingDown)
        {
            currentTimer -= Time.deltaTime;

            if(currentTimer < 0)
            {
                Debug.Log("rub");
                //rub
            }
        }
    }

    public void ClickStartedToBeHeldDown(float timerResetValue)
    {
        currentTimer = timerResetValue;
        currentlyHoldingDown = true;
    }

    public void ClickLetGo()
    {
        currentlyHoldingDown = false;

        if(currentTimer > 0)
        {
            Debug.Log("chop");
            //Chop
        }
    }
}
