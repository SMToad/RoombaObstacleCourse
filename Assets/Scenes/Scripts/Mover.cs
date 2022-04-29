using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float gravity=0.01f;
    float dTime;
    float playerYPosition;  
    float posError = 0.01f;
    [SerializeField] float moveSpeed=5; 
    bool isOnGround=true;

    // Start is called before the first frame update
    void Start()
    {
       dTime=Time.deltaTime;
       playerYPosition=GameObject.Find("Player Roomba").transform.position.y;
   }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float yPosition=GameObject.Find("Player Roomba").transform.position.y;
        if (System.Math.Abs(yPosition - playerYPosition) < posError) isOnGround=true;
        float yValue=isOnGround ? Input.GetAxis("Jump") * dTime * moveSpeed : 0;
        if(yValue!=0) isOnGround=false;

        float xValue=Input.GetAxis("Horizontal") * dTime * moveSpeed;
        float zValue=Input.GetAxis("Vertical") * dTime * moveSpeed;
       
        transform.Translate (xValue, yValue - (isOnGround? 0 : 1) * gravity, zValue); 
        
    }
}
