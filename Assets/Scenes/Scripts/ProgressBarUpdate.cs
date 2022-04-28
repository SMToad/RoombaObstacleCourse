using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBarUpdate : MonoBehaviour
{
    public int maxValue;
    public int currValue;
    public Image Mask;
    // Start is called before the first frame update
    void Start()
    {
        maxValue = GameObject.FindGameObjectsWithTag("Garbage").Length;
        currValue=0;
    }

    // Update is called once per frame
    void Update()
    {
        currValue = (int)PlayerStats.garbageEaten;
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fillAmount = (float)currValue / (float)maxValue;
        Mask.fillAmount = fillAmount;
    }
}
