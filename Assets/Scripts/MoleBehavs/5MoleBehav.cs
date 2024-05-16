using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VMoleBehaviour : MonoBehaviour
{
    [SerializeField] GameObject TriggerScrpt;
    private bool readOn;
    private bool repeatPattern;
    private bool allowBegin;
    private Vector3 startingPosition;

    private void Awake()
    {
        repeatPattern = false;
        startingPosition = this.transform.position;
        StartCoroutine(InitialDelay());
    }
    private void Update()
    {
        if (allowBegin)
        {
            readOn = TriggerScrpt.GetComponent<MoleTrigger>().ButtonPressedOn;
            if (readOn == true)
            {
                if (repeatPattern == false)
                {

                    repeatPattern = true;
                    StartCoroutine(Pattern());

                }
            }
            else
            {
                repeatPattern = false;
            }
        }

    }

    private IEnumerator Pattern()
    {
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0.4f, 0f);
        yield return new WaitForSeconds(0.3f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, -0.4f, 0f);
        yield return new WaitForSeconds(0.3f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //Debug.Log("Pattern Finished");
        if (repeatPattern)
        {
            StartCoroutine(Pattern());
        }

    }

    private IEnumerator InitialDelay()
    {
        yield return new WaitForSeconds(2);
        allowBegin = true;

    }



}

