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
        ButtonPressedOn = false;
        collisionDetected = false;
        readStop = false;
    }
    private void Update()
    {
        readStop = Controller.GetComponent<MoleControlSystem>().StopPattern;
        if (readStop == false)
        {
            ButtonPressedOn = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionDetected = true;
        ButtonPressedOn = true;
    }
}
/*public bool ButtonPressedOn;
private bool ThisIsStartButton;
private bool collideOccured;
//public bool ButtonPressedOff;

private void Awake()
{
    if (this.transform.tag == "StartButton")
    {
        ThisIsStartButton = true;
    }
    if (this.transform.tag == "StopButton")
    {
        ThisIsStartButton = false;
    }

    ButtonPressedOn = false;
    collideOccured = false;
}
private void Update()
{
    if (ThisIsStartButton)
    {

        if (collideOccured)
        {
            StartCoroutine(TriggerOn());

            collideOccured = false;

        }

    }


    if (ThisIsStartButton == false)
    {
        if (collideOccured) 
        {
            ButtonPressedOn = false;
            collideOccured = false;
        }
    }


}

private void OnCollisionEnter(Collision collision)
{
    collideOccured = true;
}

private IEnumerator TriggerOn()
{
    ButtonPressedOn = true;
    yield return new WaitForSeconds(0.1f);
    ButtonPressedOn = false;
}
private IEnumerator TriggerOff()
{
    ButtonPressedOn = false;
    yield return new WaitForSeconds(0.1f);
    ButtonPressedOn = false;
}
}*/
