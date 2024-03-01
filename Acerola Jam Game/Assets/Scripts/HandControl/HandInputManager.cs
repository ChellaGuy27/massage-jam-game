using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInputManager : MonoBehaviour
{

    [SerializeField]
    float timeUntilChopTurnsToRub = 0.2f;

    [SerializeField]
    HandRubOrChop leftHandRubOrChop;
    [SerializeField]
    HandRubOrChop rightHandRubOrChop;

    void Update()
    {
        //Left click (left hand)
        if (Input.GetMouseButtonDown(0))
        {
            leftHandRubOrChop.ClickStartedToBeHeldDown(timeUntilChopTurnsToRub);
        }
        if (Input.GetMouseButtonUp(0))
        {
            leftHandRubOrChop.ClickLetGo();
        }

        //Right click (right hand)
        if (Input.GetMouseButtonDown(1))
        {
            rightHandRubOrChop.ClickStartedToBeHeldDown(timeUntilChopTurnsToRub);
        }
        if (Input.GetMouseButtonUp(1))
        {
            rightHandRubOrChop.ClickLetGo();
        }
    }
}
