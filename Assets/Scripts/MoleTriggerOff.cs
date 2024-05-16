using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoleTriggerOff : MonoBehaviour
{
    public bool ButtonPressedOff;
    private bool collisionDetected;
    //public bool ButtonPressedOff;

    private void Awake()
    {
        ButtonPressedOff = false;
        collisionDetected = false;
    }
    private void Update()
    {
        if (collisionDetected)
        {
            ButtonPressedOff = true;
            collisionDetected = false;

        }

        else
        {
            ButtonPressedOff = false;
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionDetected = true;
    }
}