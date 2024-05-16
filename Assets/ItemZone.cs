using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemZone : MonoBehaviour
{
    public GameObject ball;

    void Update()
    {
      

    }

   private void OnTriggerEnter(Collider other)

   {
        if (other.gameObject.tag == "Ball")
        {
            other.transform.position = new Vector3(0, 1, 1);


        }

        if (other.gameObject.tag == "Pin")
        {
            Destroy(other.gameObject);


        }



    }



}
