using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemZone : MonoBehaviour
{
    public GameObject ballSpawn;

    void Update()
    {
      

    }

   private void OnTriggerEnter(Collider other)

   {
        if (other.gameObject.tag == "Ball")
        {
            other.transform.position = ballSpawn.transform.position;


        }

        if (other.gameObject.tag == "Pin")
        {
            Destroy(other.gameObject);


        }



    }



}
