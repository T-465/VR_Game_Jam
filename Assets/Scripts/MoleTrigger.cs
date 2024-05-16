using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoleTrigger : MonoBehaviour
{
    [SerializeField] GameObject Controller;
    public bool ButtonPressedOn;
    private bool collisionDetected;
    private bool readStop;
    //public bool ButtonPressedOff;

    private void Awake()
    {
        ButtonPressedOn = true;
        collisionDetected = false;
        readStop = false;
    }
    /*private void Update()
    {
        readStop = Controller.GetComponent<MoleControlSystem>().StopPattern;
        if (readStop == false)
        {
            ButtonPressedOn = false;
        }

    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        collisionDetected = true;
        ButtonPressedOn = true;
        Debug.Log("Reched");
    }
}
