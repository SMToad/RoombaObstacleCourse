using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyGarbage : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStats.garbageCapacity = PlayerStats.capacityMax;
        }
    }
}
