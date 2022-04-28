using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitObject : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.hpPlayer = PlayerStats.hpMax;
        PlayerStats.garbageCapacity = PlayerStats.capacityMax;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStats.hpPlayer <=0)
        {
            this.GetComponent<Mover>().enabled=false;
            Debug.Log("Roomba is malfunctioning, take it to repair!");
        }
        if(PlayerStats.garbageCapacity <=0)
        {
            Debug.Log("Roomba is full, please empty it");
        }
    }
    /*private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
        {
            hpPlayer -= 10;
            Debug.Log(string.Format("Roomba has taken 10 damage, it's at {0} power level. Be careful!", hpPlayer));
            
        }
    }*/
}
