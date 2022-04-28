using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateAngleX = 0;
    [SerializeField] float rotateAngleY  = 1;
    [SerializeField] float rotateAngleZ = 0;
    float timeToWait = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
            transform.Rotate(rotateAngleX, rotateAngleY, rotateAngleZ);
    }
}
