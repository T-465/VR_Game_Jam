using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    [SerializeField] GameObject TriggerScrpt;
    private bool readOn;
    private bool beginPattern;
    private bool stunned;
    private bool repeatPattern;
    private Vector3 startingPosition;

    private void Awake()
    {
        repeatPattern= false;
        startingPosition = this.transform.position;
    }
    private void Update()
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
            repeatPattern= false;
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



}

