using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageDisappear : MonoBehaviour
{
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Garbage" && PlayerStats.garbageCapacity > 0)
            {
                Destroy(other.gameObject);
                PlayerStats.garbageCapacity--;
                PlayerStats.garbageEaten++;
            }
    }
}
