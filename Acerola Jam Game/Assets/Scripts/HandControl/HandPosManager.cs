using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPosManager : MonoBehaviour
{
    [SerializeField]
    float howFarToLeftIsLeftHand = 1.5f;
    [SerializeField]
    float cursorSpeed = 1;

    [SerializeField]
    Transform leftHand;
    [SerializeField]
    Transform rightHand;

    Vector3 mouseWorldPos;

    private void Start()
    {
        //mouseWorldPos = Vector3.zero;
        //
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        //mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.x += Input.GetAxis("Mouse X") * cursorSpeed;
        mouseWorldPos.y += Input.GetAxis("Mouse Y") * cursorSpeed;

        mouseWorldPos.z = 0;

        rightHand.position = mouseWorldPos;
        leftHand.position = mouseWorldPos - new Vector3(howFarToLeftIsLeftHand, 0, 0);
    }
}
