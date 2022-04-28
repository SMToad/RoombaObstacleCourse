using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
            PlayerStats.hpPlayer -= 10;
            Debug.Log(string.Format("Roomba has taken 10 damage, it's at {0} power level. Be careful!", PlayerStats.hpPlayer));
            
        }
        if(other.gameObject.tag == "Player" && gameObject.tag != "Wall")
        {
                GetComponent<MeshRenderer>().material.color = Color.white;
                gameObject.tag = "Hit";
        }
    }
}
