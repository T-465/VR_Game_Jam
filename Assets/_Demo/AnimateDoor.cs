using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{ 
    public Transform PlayerPosition;
    private Transform doorPosition;
    private float playerDistance;
    private float distanceThreshold = 2.0f;
    private Animator doorAnimator;

    void Start()
    {
        doorPosition = GetComponent<Transform>();
        PlayerPosition = PlayerPosition.GetComponent<Transform>();
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is close to the door
        if (Vector3.Distance(PlayerPosition.position, doorPosition.position) < distanceThreshold)
        {
            // Open the door
            doorAnimator.SetBool("character_nearby", true);
        }
        else
        {
            // Close the door
            doorAnimator.SetBool("character_nearby", false);
        }
    }
}
