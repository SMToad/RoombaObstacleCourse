using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    int health=100;
    void Start() 
    {
       meshRenderer=GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if(health==0)
        {
            var img=Resources.Load<Texture>("TitanDeathImg");
            meshRenderer.material.mainTexture=img;
        }
    }
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log(string.Format("Health is {0}",health));
        if(health==0) return;
        if(other.gameObject.name=="Player [Levi]")
        {
            health-=10;
            StartCoroutine(Flasher());
        }
    }
    IEnumerator Flasher()
    {
        for(int i=0;i<5;i++)
        {
            var curColor=meshRenderer.material.color;
           meshRenderer.material.color=Color.red;
           yield return new WaitForSeconds(.1f);
           meshRenderer.material.color=curColor;
        }
    }
}
