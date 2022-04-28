using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class CapacityBar : MonoBehaviour
{
    public int maxValue;
    public int currValue;
    public Image Mask;
    // Start is called before the first frame update
    void Start()
    {
        maxValue = (int) PlayerStats.capacityMax;
        currValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currValue = maxValue - (int)PlayerStats.garbageCapacity;
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fillAmount = (float)currValue / (float)maxValue;
        Mask.fillAmount = fillAmount;
    }
}
