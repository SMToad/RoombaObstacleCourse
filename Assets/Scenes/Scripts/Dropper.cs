using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 3; 
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
        //GetComponent<Use Gravity>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Timer();
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
            //GetComponent<Use Gravity>().enabled = true;
        }
    }
    void Timer()
    {
        int timePassed = (int)Time.time;
        string minutes = ((timePassed / 60) / 10 == 0 ? "0" : "") + timePassed/60; 
        string seconds = ((timePassed % 60) / 10 == 0 ? "0" : "") + timePassed%60; 
        Debug.Log(minutes + ":" + seconds);
    }
}
