using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoleControlSystem : MonoBehaviour
{
 
    [SerializeField] GameObject StopButton;
    public bool StopPattern;
    private bool OffPressed;

    private void Update()
    {
        
        OffPressed = StopButton.GetComponent<MoleTriggerOff>().ButtonPressedOff;
        StopPattern = OffPressed;
    }
}
